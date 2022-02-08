# ECS
Senaste projektet i C#, runt två år gammalt.
Målet var att bygga en "enkel" kopia av Unitys [Entity Component System](https://docs.unity3d.com/Packages/com.unity.entities@0.17/manual/index.html) för att bättre förstå [dataorienterad design](https://en.wikipedia.org/wiki/Data-oriented_design).
När jag kollade igenom koden nu så - förutom att vilja skriva om allt från grunden - gick jag nog igenom en fas där jag överanvände varenda designpattern/princip jag kunde, t.ex:
- [Factory](https://en.wikipedia.org/wiki/Factory_method_pattern)
- [Composition over inheritance](https://en.wikipedia.org/wiki/Composition_over_inheritance)
- [Command](https://en.wikipedia.org/wiki/Command_pattern)
- [Observer/Pub/Sub](https://codewithshadman.com/publish-subscribe-design-pattern-in-csharp/)
- [Prototype](https://www.dofactory.com/net/prototype-design-pattern)
Hade jag gjort projektet idag hade jag nog spenderat 10% av tiden till planering och skrivit hälften av koden, men om inte annat så fick jag lära mig vad [scope creep](https://en.wikipedia.org/wiki/Scope_creep) är. 
