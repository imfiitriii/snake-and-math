# Snake And Math

---

##  Group Members

1. Muhammad Haziq bin Alias — 24006251
2. Muhammad Akmal Rafiuddin bin Mohd Rizal — 24006013
3. Muhammad Adam Bin Mohd Kamal @ Afdzal — 24006270
4. Muhamad Azfar Ukail Bin Mohd Azuan — 24005439
5. Muhammad Adam Ashraf Bin Abdul Razak — 24006028
6. Muhammad Imran Fitri Bin Badrul Munir — 24005993

---

##  1.0 Project Description

**Snake & Math** is an educational, multiplayer, turn-based game designed to enhance users’ mathematical problem-solving skills. The game supports up to **four players**, consisting of both real players and AI-controlled bots.

Inspired by the classic *Snake and Ladder* board game, this version introduces a unique twist by integrating **mathematical challenges** into gameplay. As players advance to higher positions on the board, the difficulty of the questions increases, providing a progressively more challenging and engaging experience.

---

###  Gameplay Overview

* Players select the number of participants (**minimum 1, maximum 4**)
* Any remaining slots are automatically filled with **bots**
* Players can choose bot difficulty levels:

  * Easy
  * Medium
  * Hard

Each difficulty level affects the probability of bots answering questions correctly.

---

###  Turn Mechanics

1. A player answers a mathematical question
2. The dice rolls automatically after answering
3. Movement is determined by answer accuracy:

   * ✅ Correct answer → Move forward
   * ❌ Incorrect answer → Move backward
   * ⏳ Timeout → Treated as incorrect (move backward)

This system adds a strategic and educational element beyond traditional gameplay.

---

###  Time-Based Challenge

* Each player is given a **time limit** to answer
* Failure to respond in time results in a penalty (moving backward)

---

###  Power-Ups System

The game introduces special power-ups to enhance gameplay:

* ** Time Freeze**

  * Earned by answering **5 consecutive questions correctly**
  * Allows players to gain an advantage by controlling time

* ** Snake Blocker**

  * Randomly generated on board tiles
  * Prevents the negative effect of landing on a snake

---

###  Classic Mechanics with a Twist

* Landing on a **ladder** → Move forward
* Landing on a **snake** → Move backward

These classic elements are combined with educational mechanics to create a fun and interactive learning experience.

---

##  2.0 System Features

*  Adjustable **bot difficulty levels** (affects accuracy and challenge)
*  Flexible **player selection** (1–4 players)
*  Interactive **power-ups system**:

  * Time Freeze (reward-based)
  * Snake Blocker (random tile-based)
*  Progressive **question difficulty system**
* ⏱ **Time-limited answering system**
*  Enhanced gameplay combining **education + classic board mechanics**

---



#  Step-by-Step Guide to Run the Project

Follow the instructions below to successfully set up and run the project on your device.

---

##  Requirements

* Microsoft Visual Studio must be installed
   Download here: https://visualstudio.microsoft.com/downloads/

* Ensure the required Visual Studio components (as highlighted in the project documentation) are installed

![WhatsApp Image 2026-04-02 at 00 21 34](https://github.com/user-attachments/assets/0bebcfe6-2732-49ed-92d4-8eee4ca884fc)

---

##  Setup Instructions

###  Step 1: Clone the Repository

Clone the project repository to your local machine.

---

###  Step 2: Open the Project

* Open the solution file (`.sln`) using Visual Studio

---

###  Step 3: Set Project Platform to x64

To avoid compatibility issues with the database:

1. In Visual Studio, go to:
   **Project > SnakeAndMath Properties**
2. Click on **Build**
3. Set:

```
Platform Target = x64
```

---

###  Step 4: Download the Database

Download the database file from the link below:

 https://drive.google.com/file/d/1dCdbuUqBm4GAuHJwbEjoJOB9NVeEeRJN/view?usp=sharing

---

###  Step 5: Place the Database File

* Locate your project directory
* Navigate to:

```
C:\...\snake-and-math\SnakeAndMath\bin\Debug
```

* Place the downloaded `.accdb` file inside this folder

---

###  Step 6: Verify File Name

 Ensure the database file name is exactly:

```
Question.accdb
```

---

###  Step 7: Rebuild the Project

* In Visual Studio, go to:
  **Build > Rebuild Solution**

---

###  Step 8: Run the Project

* Click **Start / Run**
* The application should now run successfully

---

##  Common Error & Fix (Database)

###  Error:

**"The 'Microsoft.ACE.OLEDB.12.0' provider is not registered on the local machine"**

---

###  Solution

#### Step 1: Install Microsoft Access Database Engine (x64 version)

Download and install from:
https://www.microsoft.com/en-us/download/details.aspx?id=54920

---

#### Step 2: Rebuild and Run

* Return to Visual Studio
* Click:
  **Build > Rebuild Solution**
* Run the project again

---

##  Notes

* Ensure the database file is placed in the correct folder
* Do not rename the database file
* Make sure your project platform is set to **x64** before running

---



