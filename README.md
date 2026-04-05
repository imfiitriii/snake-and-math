# Snake And Math


##  Group Members

1. Muhammad Haziq bin Alias — 24006251
2. Muhammad Akmal Rafiuddin bin Mohd Rizal — 24006013
3. Muhammad Adam Bin Mohd Kamal @ Afdzal — 24006270
4. Muhamad Azfar Ukail Bin Mohd Azuan — 24005439
5. Muhammad Adam Ashraf Bin Abdul Razak — 24006028
6. Muhammad Imran Fitri Bin Badrul Munir — 24005993

---

#  1.0 Project Description

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

# 2.0 System Features

The **Snake & Math** system includes a variety of features designed to enhance both gameplay and the learning experience.

---

### 🎮 Core Gameplay Features

- **Turn-Based Mechanics**
  - Players take turns answering mathematical questions
  - Player rolls dice after answering a questions

- **Movement System**
  - ✅ Correct answer → Move forward  
  - ❌ Incorrect answer → Move backward  
  - ⏳ Timeout → Treated as incorrect  

---

### 🤖 AI & Difficulty System

- **Adjustable Bot Difficulty Levels**
  - Easy, Medium, Hard
  - Difficulty determines the **probability of correct answers**

---

### 🧠 Educational Features

- **Time-Limited Answering**
  - Each player must answer within a **time limit**
  - Encourages quick thinking and problem-solving skills

---

### ⚡ Power-Ups System

- Players can obtain a random power-up item after **5 consecutive correct answers**
 
- **Time Boost**
  - Doubles the time limit for the next turn

- **Snake Shield**
  - Gives player immunity while landing on a snake tile

---

### 🐍 Classic Board Mechanics

- **Snakes**
  - Landing on a snake causes the player to move backward

- **Ladders**
  - Landing on a ladder allows the player to move forward

---

### 🛠 System & Technical Features

- **Database Integration**
  - Uses a `.accdb` database file to store and manage questions

- **Platform Configuration**
  - Optimized to run on **x64 architecture**

- **Error Handling Support**
  - Includes solutions for common database connection issues

---
# 3.0 Object-Oriented Programming (OOP) Concepts

The **Snake & Math** project is developed using Object-Oriented Programming (OOP) principles to ensure modularity, reusability, and maintainability of the system.

---

## 1. Encapsulation

Encapsulation is used to bind data and methods within classes while to protect attributes inside components.

**Concepts used:**
- Usage of getters and setters for properties
- Usage of class constructors

---

##  2. Abstraction

Abstraction is applied to hide complex implementation details and show only essential features.

**Concepts used:**
- Usage of interface IItem
- Implementation of interface IItem in SnakeShield and TimeBoost Class
---

## 3.Inheritance

Inheritance allows new classes to derive properties and behavior from existing classes.

**Concepts used:**
- A `BotPlayer` class inherited from the `Player` class
- Bot-specific attributes and methods (difficulty, auto-answering) is added without rewriting base player features

---

##  4. Polymorphism

Polymorphism allows methods to behave differently based on the object using them.


**Concepts used:**
- A method like `AnswerQuestion()` behaves differently for `Player` class and `Bot` class

---
By applying OOP concepts such as **Encapsulation, Abstraction, Inheritance, and Polymorphism**, the **Snake & Math** project achieves:

- Cleaner code structure  
- Better scalability  
- Easier maintenance  
- Improved development efficiency  

---

#  4.0 Step-by-Step Guide to Run the Project

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

# 5.0 Project structure

This section will describe the purpose of the files in our solution.

- frmGameSession.cs : Acts as the main program file that controls the form events when a game starts
- GameBoard.cs : GameBoard class that controls the logic for a gameboard
- Player.cs : Contains `Player` class to define logic and `Bot` class that inherits and overrides `Player` attributes and methods
- Items.cs : Contains `IItem` interface, `SnakeShield` and `TimeBoost` class
- Timer.cs : Contains `Timer` class that controls player timer
- dice.cs : Contains `Dice` class
- Question.cs : Contains `Question` class

---


