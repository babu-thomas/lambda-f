module Tokenizer

type Token =
    | LParen
    | RParen
    | Lambda
    | Dot
    | Variable of char

let alphabet = List.ofSeq "abcdefghijklmnopqrstuvwxyz"

let rec tokenize (text:char list) =
    match text with
        | [] -> []
        | '('::rest -> LParen::tokenize rest
        | ')'::rest -> RParen::tokenize rest
        | '.'::rest -> Dot::tokenize rest
        | '\\'::rest -> Lambda::tokenize rest
        | c::rest ->
            (if List.contains c alphabet
            then [Variable c]
            else []) @ tokenize rest