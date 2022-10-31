# Unity
Simple unity prototype with a chain event system for roguelike type games


A Spell interface that is used to define a core mechanic that can be triggered from player input(mouse inputs or KB), players can store several spells through
the use of the Array in the player controller and then just call whichever the active spell is with  **.Cast()**

There is 2 mains Event to **.invoke()** for the whole process to work, OnEnd and OnCast 
* If you want something to happen at the end of a spell(like in the demo level), you need to just add the Event from the player controller on the spell when you pick it up.

* If you want something to happen at the beginning of a spell,or something to modifiy the behavior of the spell,you need to bind code to the OnCast event in the
player controller

This repo contains a simple demo level with the Fireball spell which will cast another Fireball after either hitting something or living for too long, you can uncomment the code binding the OnEndEvent on the effect to have this happens times infinity(if the ball gets stuck in geometry this risk overwhelming the physics engine)
