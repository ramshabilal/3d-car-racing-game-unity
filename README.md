# 3D Car Racing Game 

This project is a thrilling racing game developed in Unity where players can race through dynamic tracks, compete against AI opponents, and strive for victory. This repository contains the source code and assets for a 3D car racing game developed in Unity.

## Features Implemented
#### Car Customization
- Changed car materials and adjusted car body, glass, wheels, and fenders colors to enhance visual appeal.

#### Terrain Creation
- Created a terrain with various landscapes, including mountainous regions, grassy plains, dense forests, and a lake.

#### Circuit Design
- Utilized EasyRoads3D plugin to design and create the racing circuit.
- Designed a loop circuit around the terrain, avoiding steep drops and tight turns.

#### Camera Setup
- Configured a multipurpose camera rig to provide dynamic views of the racing action. Adjusted camera settings for realistic tracking of the player's car during gameplay.

#### AI Opponents
- Implemented AI-controlled opponent cars to compete against the player.
- Created a series of waypoints for AI cars to follow the designated racing circuit automatically.

#### Sound or FX
- Integrated sound effects such as engine sounds and tire screeches to enhance the gaming experience.

#### Main Menu
- Main menu allows user to choose a car from two options: Red and Blue, and choose a track from two options: Circular and ZigZag.

#### Car Selection 
- Car Selection Menu, with the help of scripts, is added to allow user to select a car which is then saved as user pref. Then, the car is spawned into any of the two tracks (scenes) that the user chooses. One of the cars has a different drag so it moves faster than the other. Also, colors of both cars are different.

#### Track Selection
- Track Selection Menu is added to allow user to choose a track. If user chooses Circular, the scene (level) with circular track opens, otherwise the zigzag scene opens.

#### Lap System
A lap system is added and user can only win after the third lap. This is implemented using a lap counter that keeps track of the laps. Everytime the user crosses the finish mark, the lap count increments.  
**Note:** For the purpose of the demo, I went backward to cross the finish line and show how the lap system works. However, for the actual game, an invisible block is place between the start and finish points so user cannot win by going backward to cross the finish line. 

#### Shortcuts
- Shortcuts are placed in both circuits to add element of surprise and alternatives for player.

#### HUD - Display Lap Count
- A Display allows user to see how many laps out of total 3 have been elapsed. The user wins after the 3rd lap.
## Video Demo

**Updated demos:**
Intro of game mechanics: https://drive.google.com/file/d/1VY7UbAgb04RMNQ4WqHYBFBgfaMn2oAPW/view?usp=drive_link   

**Video of gameplay:** 
https://drive.google.com/file/d/1CK6mHOhaFlUuTppkuB3AMPAOW__CsQh8/view?usp=sharing

**Initial demo:**
https://drive.google.com/file/d/1hCSG38Vvd5IGa7sIkvLsyT7sUcZqRdov/view?usp=sharing 

### All requirements of the assignment are met.

## Main Scene
[scene_inclass.unity file contains the main scene](Assets/MainMenu.unity)

### Features under progress:
- Shortcuts in the road network
- Menu
- Cars and circuits to choose from
- HUD where the player can see the current speed, lap number, or other details
