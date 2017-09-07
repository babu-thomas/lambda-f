// An interpreter for the lambda calculus

(*
    Goal - Interpret this expression - \x.x.y
    Steps -
    1. Write grammar for the lambda calculus
        
        <expression> := <identifier> | <function> | <application>
        <identifier> := /[a-z]+/ (lowercase alphabets)
        <function> := '\' <name> '.' <expression>
        <application> := <function> <expression>
 
    2. Lex
    3. Parse
    4. Execute (??)
    5. Profit
*)

[<EntryPoint>]
let main argv = 
    printfn "Hello World!"
    0
