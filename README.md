# Unity2D_Everupdating_Shooter_Tutorial

In this Project I will be making a simple Unity 2D project as a tutorial for the members of the AMS Game Development Association

In this project I will be making a shooter demo, in which the Player (a box) will be able to shoot a bullet (a circle) to hit a target (another box) and in doing so change the color of the target upon collision.

This will go over many basic essentials perfect for a entry level tutorial.
- This will go over place objects and prefabs in a scene.
- Creating MonoBehaviour scripts going over public and private variables (and in doing so the inspector).
- It goes through Debug.Log, GetComponent, Instantiate as well as other primary functions, methods and primitives.   
- Goes of collision and triggers

# This was made and presented in November 2018

As a way to promote the usability of Unity as well as aid members with different things/tools they can use in their own project, I made a small task for myself, in which I will update this Unity project biweekly (up till the end of March 2019) in doing so I add new functionality to the demo (i.e. moveable players, light triggers, audio triggers, UI and UX implementation) with the condition that I only use the premade gameobjects presented in Unity2D (in order to assure members that no extra steps are required outside of using the Unity Game Engine).

Each time it is updated (in a major fashion) a new branch will be made in this repository and its details/changes will be noted in this ReadMe text document.

So from November up till this date (December 29th 2018) these are the changes that have been premade

#The repository was made December 29th 2018 - Master Branch

- Player can now move up and down along the y-axis (with limits dictated by the projected view of the main camera)
- Bullets increase in size the further it is from the player (with reasonable limit)
- When ever the target is 'hit' the target will randomly change its position along the y-axis (With the same limits acted on the player)
- When the target changes position it also Instantiates a bullet aimed back to the player's X-axis position (with a delay of 0.2 seconds)
  - done with a coroutine and Ienumurator
- if the bullet Instantiated by the target hits the player, the player gameobject is destroyed.
- if the bullets goes beyond a certain point along the x-axis (in either direction), it is destroyed
- If a bullet from the player and a bullet from the target collide, both bullets are destroyed and a large block (same prefab as the target) scaled in the y-direction to go out of bounds of the camera view is Instantiated.
- If the bullet collides with the large Block (Aka The Board), the bullet is redirected back at the bullet with 1.5X the original speed

The next installment of this project (new branch) will be made on the 12th Of Jan 2019

# By the 12th Jan 2019

The following should be accomplished

- [] The board will be destroyed after a certain amount of time after being instantiated
- [ ] There should be a cap on the amount of bullets the player can Instantiate, only refilling after they get destroyed (object spooling)
- [ ] Each bullet from the player should be a random color
- [ ] There should be a start menu scene before this scene is playable
- [ ]  other additions are welcome but should be documented.

 
