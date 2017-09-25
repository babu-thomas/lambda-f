// An interpreter for the lambda calculus

(*
    Goal - Interpret this expression - (\x.x \y.y)
    Steps -
    1. Write grammar for the lambda calculus....DONE!!
        
        <expression>  := <variable> | <function> | <application>
        <variable>    := /[a-z]/ (lowercase alphabets)
        <function>    := '\' <variable> '.' <expression>
        <application> := '(' <function> <space> <expression> ')'
 
    2. Lex....DONE!!
    3. Parse
    4. Execute (??)
    5. Profit
*)

open Tokenizer

[<EntryPoint>]
let main argv =
    "(\x.x \y.y)"
    |> List.ofSeq
    |> tokenize
    |> printfn "%A"
    0