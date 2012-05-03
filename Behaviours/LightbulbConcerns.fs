namespace LightbulbConcerns
open FsUnit
open TopLevel

[<Scenario("A user is trying to see")>]
type ``Given a Lightbulb that has had it's state set to true`` ()=
    let lightbulb = new LightBulb(true)

    [<Then>] member
        check.``when I ask if the lightbulb is ON it answers TRUE`` ()=
            lightbulb.On --> should be True

    [<Then>] member 
        check.``when I convert it to a string it becomes "On".`` ()=
            string lightbulb --> should equal "On"

[<Scenario("A user is trying to save energy")>]
type ``Given a Lightbulb that has it's state set to false`` ()=
    let lightBulb = new LightBulb(false)

    [<Then>] member 
        check.``when I ask if the lightbulb is ON it answers FALSE`` ()=
            lightBulb.On --> should be False

    [<Then>] member
        check.``when I convert it to a string it becomes "Off"`` ()=
            string lightBulb --> should equal "Off"