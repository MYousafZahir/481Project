<div id="top"></div>

# CPSC 481 Winter 2023 Project: PlayerLink

## Table of Contents
- [CPSC 481 Winter 2023 Project: PlayerLink](#cpsc-481-winter-2023-project-playerlink)
  - [Table of Contents](#table-of-contents)
- [Background](#background)
- [Tools and Technologies](#tools-and-technologies)
- [Installation](#installation)
  - [Step 1. Blazor](#step-1-blazor)
  - [Step 2. Clone GitHub Repository](#step-2-clone-github-repository)
  - [Step 3: Starting the PlayerLink Application](#step-3-starting-the-playerlink-application)
- [PlayerLink System Walkthrough](#playerlink-system-walkthrough)
  - [Step 1. Login](#step-1-login)
  - [Step 2. Make an Account](#step-2-make-an-account)
  - [Step 3. Account Setup (1 out of 3)](#step-3-account-setup-1-out-of-3)
  - [Step 4: Account Setup (2 out of 3)](#step-4-account-setup-2-out-of-3)
  - [Step 5. Account Setup (3 out of 3)](#step-5-account-setup-3-out-of-3)
  - [Step 6: Lobby Preference (1 out of 3)](#step-6-lobby-preference-1-out-of-3)
  - [Step 7: Lobby Preference (2 out of 3)](#step-7-lobby-preference-2-out-of-3)
  - [Step 8: Lobby Preference (3 out of 3)](#step-8-lobby-preference-3-out-of-3)
  - [Lobby - Create Lobby](#lobby---create-lobby)
  - [Lobby - Join Lobby](#lobby---join-lobby)
  - [Lobby - Lobby Chat](#lobby---lobby-chat)
  - [Lobby - Side Bar](#lobby---side-bar)
  - [Lobby - Searching for Lobby Games](#lobby---searching-for-lobby-games)
  - [Lobby - Additional Filtering for Lobby Games](#lobby---additional-filtering-for-lobby-games)
  - [Lobby - Friend Requests](#lobby---friend-requests)
- [Team Members](#team-members)

# Background
This a full stack application that allows users interested in fly fishing to store their expeditions in various ways, such as logging every fish they catch, what fly they used, the weather conditions, etc. We are hoping that fly fishers are able to use this application to catch the fish that they want.\
This project uses `React` as its frontend, and `NodeJS` with `ExpressJS` and `SQL` as the backend.

The gaming industry, and in particular the multiplayer scene, has seen explosive growth in terms of users over the last few decades. The technologies behind modern games have advanced rapidly in terms of both graphics and popularity, however, they have failed to meet the demands of gamers in terms of addressing their needs to communicate and build social networks with one another. Current institutions, such as built-in chat functionality or Discord, fail to both remove bad actors who actively partake in toxic, annoying or weird behavior and to connect like minded individuals. 

This is why we have introduced PlayerLink, to address the social needs of gamers and facilitate long-term friendships among them.

PlayerLink was created using the `Blazor` web framework.

# Tools and Technologies
The following languages and tools were used to build our project:
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [CSS](https://developer.mozilla.org/en-US/docs/Web/CSS)
- [HTML](https://html.com/)


# Installation
## Step 1. Blazor
Install [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor).


Then, open up your terminal and check if `Blazor` is installed:
```
$ dotnet ---version
7.0.203
```

## Step 2. Clone GitHub Repository
Enter the following on the terminal of your device to download the PlayerLink project:
```
$ git clone https://github.com/MYousafZahir/481Project/tree/Main-2
```

## Step 3: Starting the PlayerLink Application
Go to the root directory of the project and then start the app:
```
$ cd PlayerLink                  // first, go to root directory of the project...
$ ...\PlayerLink> dotnet watch   // then, start the application in the root directory
```
Open [http://localhost:5178](http://localhost:3000) to view the application in the browser.

# PlayerLink System Walkthrough
## Step 1. Login 
The following steps (Steps 1 - 8) is required for the user as an initial setup and registration for the PlayerLink system.

The user is presented the PlayerLink login page. There are two text fields: 
- Enter username
- Enter password 

which is meant for users with an existing PlayerLink account to login to their account. After the user has entered their correct username and password, they can click the "Login" button below to move on to the PlayerLink home page.

Users without an existing account need to follow the steps described below to register an account.

There are additional four links below the page:
- `Forgot Username?`
- `Forgot Password?`
- `New to Playerlink?`
- `Register`

In order to register an account, the user must click on `Register`. This will redirect to the `Make an Account` page.

## Step 2. Make an Account
The `Make an Account` page is for the user to register a PlayerLink account. There are four fields that the user is required to fill out:
- `Email` : email must include an '@'  
- `Username` : user can choose their own username
- `Password` : can be of any length or consist of any symbol
- `Date of Birth`
  - ``Month`` : must be between 1-12
  - `Day` : must be between 1-31
  - `Year` : must be a number between 1900-2099 


Once the user fills out all of the four fields correctly, a `Create Account` button will become visible. The user can click the button and will be directed to the `Account Setup (1 out of 3)` page. 

## Step 3. Account Setup (1 out of 3)
The `Account Setup (1 out of 3)` is for the user to select a profile picture for their account. The user must click on the bordered square to select a profile picture. 
Once the user has done that, their image will appear on the bordered square, and a `Continue` button will appear on the bottom left of the page. The user can click `Continue` and will be directed to the `Account Setup (2 out of 3)` page.

## Step 4: Account Setup (2 out of 3)
The `Account Setup (2 out of 3)` is for the user to select their top 3 favourite genres from the provided genres. This is an important step later on as it allows the system to provide the user with appropriate genre recommendations for gaming lobbies. 

Once the user has selected their top 3 favourite genres, a `Continue` button will appear on the bottom left of the page. The user can click `Continue` and will be directed to the `Account Setup (3 out of 3)` page.

## Step 5. Account Setup (3 out of 3)
The `Account Setup (3 out of 3)` is for the user to select their top 3 favourite games. This is an important step later on as it allows the system to provide the user appropriate game recommendations for gaming lobbies. 

The user will do this by entering their games on the search bar on the bottom right of the page. Once a game is entered, it will appear in the middle of the screen. 

Once the user has selected their top 3 favourite games, a `Continue` button will appear on the bottom left of the page. The user can click `Continue` and will be directed to the `Lobby Preference (1 out of 3)` page.

## Step 6: Lobby Preference (1 out of 3)
The `Lobby Preference (1 out of 3)` is for the user to get recommended lobbies based on the game they selected. The user can only select one game out of the three that are presented by clicking on them. Once a game is selected, the user can click on the `Continue` button which will direct them to the `Lobby Preference (1 out of 3)` page.

## Step 7: Lobby Preference (2 out of 3)
The `Lobby Preference (2 out of 3)` is for the user to set game preferences for the game that they had selected. 
The page presents the following:
- `Rank` : Level of skill associated with lobbies, user can click on one or more of the the ranks "Level 1", "Level 2", "Level 3".
- `Server`: Geographical location associated with lobbies, user can click on any of the presented options

Once the user has selected the `Rank` and `Server` for the lobby recommendations that they want, they  can click `Continue` and will be directed to the `Lobby Preference (3 out of 3)` page.

## Step 8: Lobby Preference (3 out of 3)
The `Lobby Preference (3 out of 3)` is for the user to set lobby trait preferences for the game that they had selected. 
The page presents the following:
- `Desired Traits` : Lobby traits the user is looking for
- `Undesired Traits`: Traits that the user wants to avoid
- `Your Traits` : Traits that describe the user themselves


Traits can be things such as rank, hobbies, game mode, or goals for the lobby. Example tags: Aggressive, Fast, Novice, etc. This way, the user can be recommended lobbies based on their desires.

Once the user has filled out `Desired Traits`, `Undesired Traits`, and `Your Traits`, they can click the `Search` button on the bottom right. Then, the user will be presented the `Lobby` page that displays their recommended lobbies. 

This marks the end of the account creation process.

## Lobby - Create Lobby
In order to create a lobby, the user can click on the `Create Lobby` button on the top right of the page. A pop-up will appear with the following fields:
- `Game` : Enter the name of the game in which this new lobby will host
- `Lobby Name` : Enter a custom lobby name
- `Number of Players` : Set the maximum number of players that can join the lobby
- `Desired Tags` : List of lobby traits the user is looking for (separated by a comma)
- `Undesired Tags` : List of lobby traits the user wants to avoid (separated by a comma)
- `Describe Yourself` : List of traits that describe the user themselves (separated by a comma)

Once all the above fields are filled out, the user is able to create their own lobby by clicking the `Create Lobby` button on the bottom right of the pop-up. Then, user will be able to see their lobby on the list of lobbies as they scroll down the current page.

Alternatevily, the user can cancel creating a new lobby by clicking the `Close` button next to the `Create Lobby` button or the `X` button at the top right of the pop-up page.

## Lobby - Join Lobby
On the current `Lobby` page, the user can click on any of the lobbies presented. Once they click on a lobby, a pop-up will appear showing each of the members of the lobby and their traits. Also, the `Desired Traits`, `Undesired Traits`, and `Owner Tags` of the lobby is shown. 

The user can join a lobby by clicking on the blue `Join Lobby` button on the bottom of the pop-up. This will direct the user to the `Lobby Chat` page.

## Lobby - Lobby Chat
The `Lobby Chat` page is where the user can communicate with other members of the lobby. Once the user is in a lobby chat, they are automatically placed on a voice call with other members. The user will be able to see and use the following functionalities:
- `Enter a message` : Chat message field for text communication between lobby members. The user can input any text into the text field and hit 'Enter' or click on the `Send` button to send the message
- `Invite` button : Used for inviting friends to the current lobby. A pop-up will appear in which the user can invite friends by clicking the `Invite` button. Once `Invite` button is clicked, it will turn green.
- `Leave` : Used for leaving the lobby. A pop-up error message will appear prompting the user to confirm the decision to leave a the lobby. A green `Yes` and a red `No` button is presented for the user to make a decision. Clicking the `Yes` button will redirect the user back to the main `Lobby` page. Clicking the `No` button allows the user to remain in the `Lobby Chat` page. 
- `Muting microphone`: User is able to mute themselves during the voice call by clicking the 'microphone' symbol located on the left-hand side. The microphone symbol will have a red line crossed on it to indicate that the user is muted.
- `Deafening`: User is able to mute their speaker during the voice call by clicking the 'headphone' symbol located on the left-hand side. The headphone symbol will have a red line crossed on it to indicate that the user is deafened (user will not be able to hear other members in the voice call).
- `Demonstration of Functionality` : Pressing '~' in the text box will invoke a interactable pop up for a join request to appear, pressing  in the text box "alt" will invoke a message from user "Bob" 

## Lobby - Side Bar
Right clicking on a friend will invoke a context menu that is interactable, clicking chat will bring a chat pop up window, clicking `Remove` will remove them from the friend list.

## Lobby - Searching for Lobby Games
On the main `Lobby` page, the user can click on the `Search Game` search bar to search for their lobby games. The user is presented with all the available lobbies if they click on the `Search Game`. They can click on any of the available lobbies in the search, and if the lobby exists the system will present display them to the user.


## Lobby - Additional Filtering for Lobby Games
On the main `Lobby` page, the user can click on the `Filter` button to filter lobbies based on traits (for a more advanced search). 

Clicking on the `Filter` button presents the user with a pop-up with following:
- `Desired Traits` : Lobby traits the user is looking for
- `Undesired Traits`: Traits that the user wants to avoid
- `Your Traits` : Traits that describe the user themselves

Traits can be things such as rank, hobbies, game mode, or goals for the lobby. Example tags: Aggressive, Fast, Novice, etc. 

Once the user has filled out `Desired Traits`, `Undesired Traits`, and `Your Traits`, they can click the blue `Save Changes` button on the bottom right. Then, the user will be displayed the appropriate lobbies based on the filters (traits) that they had set. 

## Lobby - Friend Requests
On the main `Lobby` page, the user can click on the `+` beside 'Friends' (located on the left-hand side of the page) to add, reject friend requests, or search for friends.

Clicking on the `+` button presents the user with a pop-up with following:
- `Requests` : Friend requests of the user. The user can accept or reject the friend request by either clicking the red `Reject` button or the green `Accept` button. The user will be indicated which option they have clicked.
- `Search Friends` : Search bar in which the user can enter the username of a member who they want to send a friend. Alternatively, the user can just search for an existing friend.

# Team Members
This project was made by Computer Science Undergraduate students from the University of Calgary
as a final project for the CPSC 481 Winter 2023 course. \
Here is the list of authors:

- [Yousaf Zahir](https://github.com/MYousafZahir)
- [Eric Mao](https://github.com/HAPPYSACKS) 
- [Haider Tawfik](https://github.com/HaiderTawfik) 
- [Runze Li]()
- [Anish Pokhrel](https://github.com/apokhrel7)

 

<p align="right">(<a href="#top">back to top</a>)</p>
