![A MAZE](/Maze/Assets/UdacityVR/Images/1.JPG)

# Introduction

What is a game? It's very difficult to define. In the book 'The Art of Game Design', Jesse Schell takes several definitions of a game and elaborates each. My favorite definition of a game among them is 

"A Game is a closed, formal system, that engages players in a structured conflict, and resolves in an unequal outcome." - Tracy Fullerton, Chris Swain, and Steve Hoffman.

Games are ubiquitous by nature. From 'Rock-Paper-Scissor' to 'Robo Recall', there are games that can be played anywhere using anything.

Digital games have changed the world of gaming. Today, video games are a 100 billion dollar industry. This is one of the few industries that always embraces technology and innovation. Already 4K - consoles like Xbox One X and the PS4 pro have brought the gaming to life in terms of how they look and feel. Now, Virtual Reality can take the already raised bar and raise it even further. 

Virtual Reality is capable of providing players with a whole new much-improved gaming experience all around. When you put on a VR headset like Oculus Rift or HTC Vive, you will no longer feel like playing a game. It feels like you are actually a part of the game. 

As a VR game lets the player into its world, developing games for VR will take more things into consideration when compared to building the games for flat screens. In this article, I'm going to present the design and development process that I have taken while building a VR game called 'A MAZE' for google cardboard as a part of Udacity Virtual Reality Nano Degree program.

 Below is the game play video of the A - MAZE game.
 
 [![Alt text](https://img.youtube.com/vi/ejedjHqVDR4/0.jpg)](https://youtu.be/ejedjHqVDR4)
 
 # [Download Android apk file from here](https://drive.google.com/file/d/1TuCsTiKTNBf-yhaPkQZFF6k5gkIwXDNe/view)
 
 # The Process

## Statement of Purpose

A MAZE is the combination of treasure hunt game and the traditional pathfinding maze game built for Virtual Reality. To get the treasure the player has to go through a labyrinth, find the key and find the path to the temple. The temple door opens only if the player has the key. The player can collect the coins on his way through the game and use them to break the walls and create short-cuts in the maze.

The targeted audience is anyone who wants to experience playing a game in VR. 

## Persona

|Syntax |Description|
|-------|-----------|
|Name |Ayub      |
|Age |15      |
|Occupation |High School Student      |
|VR Experience | No|
    I love playing video games. I have a great collection of gaming consoles in my home.
    
    
Ayub is a high school student studying in class 10. He loves playing video games and has collection of major gaming consoles. He has heard amazing things about VR gaming and is waiting for an opportunity to experience it.

## Designs, Sketches & Models

### 1. Maze Path

I wanted to create a slightly complex maze. I came up with the below designs

![A MAZE](/Maze/Assets/UdacityVR/Images/2.JPG "Maze Path Sketch")

![A MAZE](/Maze/Assets/UdacityVR/Images/3.JPG "Maze Path Sketch")

![A MAZE](/Maze/Assets/UdacityVR/Images/4.JPG "Maze Path Sketch")

Below is the final maze that I have built in Unity3D.

![A MAZE](/Maze/Assets/UdacityVR/Images/5.JPG "Final Maze Path")

### 2. Key & Coin

Below are the 3-D models of Key & Coin used in the game. I got these assets in the projects starter kit. 

![A MAZE](/Maze/Assets/UdacityVR/Images/6.JPG "Key")

![A MAZE](/Maze/Assets/UdacityVR/Images/7.JPG "Coin")

### 3. Treasure Chest & Win UI

Below are the 3-D models of Treasure chest & the user interface to show Win message. I got these assets in the project's starter kit. 

![A MAZE](/Maze/Assets/UdacityVR/Images/8.JPG "Treasure Chest & Win UI")

## User testing
I wanted to get valuable and honest feedback about this application. So, I chose my colleague at workplace whom I thought would be the right user for testing this app. A short intro about him below

*Rup:*
He is a senior QA engineer in the company that I'm working for currently. He is highly creative. He looks for even minutest details while testing. He also plays a lot of video games.

**User Test - 1:** What do you feel about the setting, scale & mood of the scene?

*Rup:* I feel like my head is touching the roof inside the maze. The ambient music is really good.

    Increased the height of the maze walls.  
    
**User Test - 2:** What do you feel about the movement?

*Rup:* First few teleportations felt weird to me. But I got used to these very quickly. Now, I feel like I have powers to transport instantly to whatever position I see here.
      
**User Test - 3:** How is the overall feel of the VR experience? Any suggestions?

*Rup:* The overall experience is good. But, I don't see any point in collecting coins while playing the game. And also the walls don't look realistic. I can see some distortion like things on the walls. 

      Yes, the coins are of no use. So, I have added the wall-breaking feature with the help of coins. Yes, the pixel distortion is coming because of one bad design decision I have taken. Instead of scaling a smaller wall, I have used multiple walls to increase its size. In my next version of this game, I will take care of these distortions.
      
 # Breakdown of final piece
 
 The gameplay goes like this.
1. The player will be shown some introduction about the game and a short demo on how to break the walls with the help of coins. Then the player can enter the MAZE.
2. Player has to click the waypoints to navigate. Can collect coins and break walls. 
3. Player has to find the key and a path to the temple.
4. If the player reaches the temple with the key, the temple doors will be opened. 
5. That's it! The player wins the treasure and can choose to replay the game again. 

# Conclusion

It's a great learning experience for me working on this project. This is the first time I have used C# programming to create gameplay interactions. User testing has really helped me to add the cool wall breaking feature in the game. Working on game development is far more satisfying than playing a game.

# Next Steps..

If ever I get a chance to work on version 2 of this game, I would love to build a far bigger maze with multiple levels and create a whole new gameplay experience.
