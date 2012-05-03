namespace ``C# Concerns``
open FsUnit
open ExampleCSharpProject

(*
    This is here to show some C# usage.
    If you find that your F# tests are getting verbose and messy, it's
    a damn good clue that your C# code is getting messy too.

    Try to keep the surface area of your classes nice as small :-)

*)

[<Scenario("I'm trying to do something with NUnit and C#")>]
type ``Given a class that has been initialised with some values`` ()=
    let exampleName = "Example Name"
    let exampleValue = 10
    let subject = new Class1(exampleName, exampleValue)

    [<Then>] member
        check.``when I query object's name, Should return example name`` ()=
            subject.MyName --> should equal exampleName

    [<Then>] member 
        check.``when I query object's value, Should return example value`` ()=
            subject.MyValue --> should equal exampleValue


[<Scenario("I'm using a builder to stack a bunch of variables together")>]
type ``Given a builder with default values`` ()=
    let subject = (new BuilderExample()).WithDefaults()

    [<Then>] member
        check.``Should have default values`` ()=
            (subject.Destination,subject.Name, subject.PublishDate)
            --> should equal (BuilderExample.DefaultDestination, BuilderExample.DefaultName, BuilderExample.DefaultPublishDate)

[<Scenario("I'm using a builder to stack a bunch of variables together")>]
type ``Given a builder with default values and a new name`` ()=
    let changed_name = "My different name"
    let subject = (new BuilderExample()).WithDefaults().WithName(changed_name)

    [<Then>] member
        check.``when I change the name in the Builder, it should be persisted`` ()=
            subject.Name --> should equal changed_name

