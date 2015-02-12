module PascalsTriangle

//  Build a line from the line above it
let buildLine = function
    | [] -> [1]
    | lineAbove -> List.map2 (fun a b -> a + b) (0 :: lineAbove) (lineAbove @ [0])

//  Build a triangle of a given depth.
let pascalsTriangle depth = 

    [1 .. depth]
    |> List.fold
        (fun (triangle, lastLine) _ ->
            let newLine = buildLine lastLine
            triangle @ [newLine], newLine
        )
        ([], []) // start with an empty triangle and empty line
    |> fst
    


//  Faster build line function (but not clearer)
//let buildLine = function
//    | [] -> [1]
//    | lineAbove ->
//        lineAbove @ [0]         //  Pad the line with an empty element at the end...
//            |> List.fold        //  ...then fold to do the sums and build the line.
//                (fun state element -> 
//                    let lastElement, newList = state
//                    element, newList @ [element + lastElement]
//                )
//                (0, [])         //  State - the last value is zero, the new line is empty
//            |> snd