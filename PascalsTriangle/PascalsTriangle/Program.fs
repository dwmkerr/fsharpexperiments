module Program
open System
open Printing
open PascalsTriangle

[<EntryPoint>]
let main argv = 
    
    printfn "How many lines?"
            
    Console.ReadLine()
    |> Int32.Parse
    |> pascalsTriangle
    |> printTriangle

    Console.ReadLine() |> ignore
     
    0 // return an integer exit code
