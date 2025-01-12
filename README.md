[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

How would you describe this game world in objects？
The game world consist of these objects:

UI
Player
Plant
Background
camera

What attributes and actions do these objects have?
UI: calculating the amount of seeds/Calculating how many seeds are planted/remains

Player
Movement: up/w,down/s,left/a,right/d

Space: Planting the seed

Plant:
Stays on player location and exists.

How do these objects act on or affect each other?

The player's current position affects where the seed is planted
The number of seed objects in the scene affects what is displayed on the UI

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

My code mostly fulfills all the plan I had for the game objects. I first begin working on the player's script, and in connection to my plan, the player's movement is the first thing I should be working on and get it down. It is also an essential part to the player's object and the overall requirement. So my plan for the movement is that when pressing w or up arrow key, the player will move up, s and down arrow key player will move down, a & Left arrow for left and d & right arrow for right, which is also what I put in my plan. I know that Unity has a input system that will assign value to the wasd keys, so I directly used that and created my movement script by assigning  a float called moveInputHorizontal to Input.GetAxis("Horizontal") for horizontal movement and a float called moveInputVertical to Input.GetAxis("Vertical"); for vertical movement. With the new values I created a vector3 value(vector3 used for x,y,a values) and * by speed and Time.deltaTme so that the player's movement speed is linked to speed(also something that I should include in the plan stage but forgot, I should be able to change player speed to test for the right speed for movement that isn't too fast or too slow.) . Finally I just made sure player position will always add the vector3. since vector3 will be 0 when no key is pressed, the player won't move, and when vector 3 changes, then player will add the vector3 value to it. 

Last thing for the player is the planting the seed function, which I followed the plan and implemented a new method in which when space key is pressed, it will call the function plantSeed(). In plantSeed() function, it should plant the seed, or the seed sprite on the player location, which is something I had for my plan, and I did exactly that using a instantiate function that will create a gameobject based on the prefab(which is the plant sprite), and then made sure that the plant will stay on player's exact location at the moment when the plant is placed(while also having the same rotation, else a error came up). However something that I don't have in my plan is that the plant should only be planted when there is more then 0 seed, so I added a restriction using if statement, making sure the plantSeed() function will only ran if there are seeds. Another thing for player script that I don't have in my plan is that I need to assign the number of seeds player should have at the beginning of the game, that player should be initialized with some seeds, which I did in the start function. Another thing I don't have in my plan is that I didn't put the information that everytime when seed is planted and at the beginning of the game, the player script should "tell"(update) the UI for the game that the player started with 5 seeds and that player has planted a seed, which I did by calling for UI update after the plantseed function is called and when the game starts.

For the UI, I followed through my plan and just made sure that the text for seeds remain and seeds plant updates according to the new values. Something that is different from the plan is that we stated UI will calculate new seeds and remain seeds, but infact the script for UI is just updating the text. The numbers are been calculated in player script when seeds is been planted.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
