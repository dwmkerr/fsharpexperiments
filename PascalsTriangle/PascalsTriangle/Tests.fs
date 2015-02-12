module Tests
open PascalsTriangle
open NUnit.Framework

//  Tests for building lines

[<Test>]
let ``Can build a line from an empty line``() = 
    let lineAbove = []
    let line = buildLine lineAbove
    let expected = [1]
    Assert.AreEqual(expected, line)

[<Test>]
let ``Can build a line from the first line``() = 
    let lineAbove = [1]
    let line = buildLine lineAbove
    let expected = [1;1]
    Assert.AreEqual(expected, line)

[<Test>]
let ``Can build a line from the fifth line``() = 
    let lineAbove = [1;4;6;4;1]
    let line = buildLine lineAbove
    let expected = [1;5;10;10;5;1]
    Assert.AreEqual(expected, line)

[<Test>]
let ``Can build a line even if the line above isn't symmetric``() = 
    let lineAbove = [1;3;4;5;2]
    let line = buildLine lineAbove
    let expected = [1;4;7;9;7;2]
    Assert.AreEqual(expected, line)

    
//  Tests for building triangles

[<Test>]
let ``Handles depth zero``() = 
    let triangle = pascalsTriangle 0
    let expected = 
        [
        ]
    Assert.IsTrue( (expected = triangle) )
    
[<Test>]
let ``Handles depth one``() = 
    let triangle = pascalsTriangle 1
    let expected = 
        [
            [1]
        ]
    Assert.IsTrue( (expected = triangle) )
    
[<Test>]
let ``Handles depth two``() = 
    let triangle = pascalsTriangle 2
    let expected = 
        [   
            [1]
            [1;1]
        ]
    Assert.IsTrue( (expected = triangle) )
    
[<Test>]
let ``Handles depth six``() = 
    let triangle = pascalsTriangle 6
    let expected = 
        [
            [1]
            [1;1]
            [1;2;1]
            [1;3;3;1]
            [1;4;6;4;1] 
            [1;5;10;10;5;1]
        ]
    Assert.IsTrue( (expected = triangle) )