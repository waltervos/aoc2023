open System.IO

open Solutions.DayOne

let solution =
    File.ReadAllLines "..\\Puzzles\\day-01.txt" |> List.ofArray |> processStringList

printfn "%i" solution
