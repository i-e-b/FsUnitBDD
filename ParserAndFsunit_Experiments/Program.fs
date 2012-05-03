// Learn more about F# at http://fsharp.net
module TopLevel
open System

// Quick test type:
type LightBulb(state) = 
    member x.On = state
    override x.ToString() =
        match x.On with
        | true -> "On"
        | false -> "Off"

ignore (Console.ReadKey())