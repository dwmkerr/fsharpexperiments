module Printing

let printLine line = 
    line
    |> List.map (printf "%d ")
    |> ignore
    printf "\n"

let printTriangle triangle = 
    triangle
    |> List.map printLine
    |> ignore