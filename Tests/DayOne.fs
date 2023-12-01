module Tests

open NUnit.Framework
open Solutions.DayOne

[<Test>]
let ``It concats the digits in a string of digits and characters`` () =
    let input = "qlcnz54dd757jfnlfgz"
    Assert.AreEqual(57, input |> getFirstAndLastDigit)

[<Test>]
let ``it concats the digits in a string when the first digit is a word`` () =
    let input = "qdkneight6zqcrgxxnkjdbb"
    Assert.AreEqual(86, input |> getFirstAndLastDigit)

[<Test>]
let ``it concats the digits in a string when the last digit is a word`` () =
    let input = "pgmm1mcvcrmxsevenfour1three1threexx"
    Assert.AreEqual(13, input |> getFirstAndLastDigit)

[<Test>]
let ``it concats the digits in a string when first and last digits are a word`` () =
    let input = "sixkzqqznmmcqqxninepdqbf8nine"
    Assert.AreEqual(69, input |> getFirstAndLastDigit)

[<Test>]
let ``it concats the digits in a string when the only digit in the string is a word`` () =
    let input = "sixkzqqznmmc"
    Assert.AreEqual(66, input |> getFirstAndLastDigit)

[<Test>]
let ``it concats the digits in a string when the only digit in the string is a digit`` () =
    let input = "6kzqqznmmc"
    Assert.AreEqual(66, input |> getFirstAndLastDigit)

[<Test>]
let ``it computes the correct result for example 1`` () =
    let example = [ "1abc2"; "pqr3stu8vwx"; "a1b2c3d4e5f"; "treb7uchet" ]
    Assert.AreEqual(142, (example |> processStringList))

[<Test>]
let ``it computes the correct result for example 2`` () =
    let example =
        [ "two1nine"
          "eightwothree"
          "abcone2threexyz"
          "xtwone3four"
          "4nineeightseven2"
          "zoneight234"
          "7pqrstsixteen" ]

    Assert.AreEqual(281, (example |> processStringList))
