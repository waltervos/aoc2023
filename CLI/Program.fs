open System
open System.IO

let solution =
    File.ReadAllLines "..\\Puzzles\\day-01.txt"
    |> List.ofArray
    |> List.map (fun (stringList) -> stringList |> Seq.toList)
    |> List.map (fun charList ->
        charList
        |> List.fold
            (fun total char ->
                let charAsString = Char.ToString char

                let charValue =
                    match Int32.TryParse charAsString with
                    | true, char -> charAsString
                    | _ -> ""

                total + charValue)
            "")
    |> List.fold
        (fun total intString ->
            let firstInt = intString[0] |> Char.ToString
            let lastInt = intString |> Seq.toList |> List.last |> Char.ToString
            
            total + (firstInt + lastInt |> Int32.Parse))
        0

printfn "%A" solution
