namespace Solutions

open System

module DayOne =

    let getWordDigits (input: string) =
        let writtenNumbers =
            [ "one"; "two"; "three"; "four"; "five"; "six"; "seven"; "eight"; "nine" ]

        writtenNumbers
        |> List.indexed
        |> List.map (fun (i, s) ->
            match input.LastIndexOf(s) with
            | -1 -> -1, ""
            | idx -> idx, (i + 1).ToString())
        |> List.filter (fun item ->
            match item with
            | -1, "" -> false
            | _ -> true)
        |> Map.ofList

    let getCharDigits (input: string) =
        input
            |> Seq.toList
            |> List.indexed
            |> List.filter (fun (i, c) -> c |> Char.IsDigit)
            |> List.map (fun (i, c) -> i, c.ToString())
            |> Map.ofList

    let mergeDigitMaps charDigits wordDigits =
        Map.fold (fun s k v -> Map.add k v s) charDigits wordDigits
        |> Map.toList
        |> List.map (fun (idx, s) -> s)

    let getFirstAndLastDigit (input: string) =
        let wordDigits = getWordDigits input

        let charDigits =
            getCharDigits input

        let allDigits =
            mergeDigitMaps charDigits wordDigits

        let firstDigit = allDigits[0]
        let lastDigit = allDigits |> List.last

        firstDigit + lastDigit |> Int32.Parse

    let processStringList stringList =
        stringList
        |> List.map (fun (line) -> getFirstAndLastDigit line)
        |> List.sum