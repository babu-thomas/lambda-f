(*
    Grammar -
        <expression> := <identifier> | <function> | <application>
        <identifier> := /[a-z]+/ (lowercase alphabets)
        <function> := '\' <identifier> '.' <expression>
        <application> := <function> <expression>
*)

module Ast

type Program = Expression list

and Expression =
    | Name of Identifier
    | Function of Function
    | Application of Function * Expression

and Identifier = string

and Function = LambdaSign * Identifier * DotSign * Expression

and LambdaSign = char

and DotSign = char