﻿module FsUnit
open NUnit.Framework
open NUnit.Framework.Constraints

// Rename attributes
type Scenario(Description:string) = inherit TestFixtureAttribute() // description gets dropped-- it's just for code, and I want to enforce it.
type Then() = inherit TestAttribute()

// Check a set of contraints
let should (f : 'a -> #Constraint) x (y : obj) =
    let c = f x
    let y =
        match y with
        | :? (unit -> unit) -> box (new TestDelegate(y :?> unit -> unit))
        | _                 -> y
    Assert.That(y, c)

// English language friendly sugar:
let be = id
let (-->) x f = f(x)

// F# mappings for .Net stuff
let equal x = new EqualConstraint(x)
let not x = new NotConstraint(x)
let contain x = new ContainsConstraint(x)
let haveLength n = Has.Length.EqualTo(n)
let haveCount n = Has.Count.EqualTo(n)
let Null = new NullConstraint()
let Empty = new EmptyConstraint()
let EmptyString = new EmptyStringConstraint()
let NullOrEmptyString = new NullOrEmptyStringConstraint()
let True = new TrueConstraint()
let False = new FalseConstraint()
let sameAs x = new SameAsConstraint(x)
let throw = Throws.TypeOf
