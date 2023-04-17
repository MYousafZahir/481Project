<div id="top"></div>

# CPSC 481 Winter 2023 Project: PlayerLink

## Table of Contents
- [CPSC 481 Winter 2023 Project: PlayerLink](#cpsc-481-winter-2023-project-playerlink)
  - [Table of Contents](#table-of-contents)
- [Background](#background)
- [Tools and Technologies](#tools-and-technologies)
- [Walkthrough](#walkthrough)
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
    - [`npm start`](#npm-start)
    - [`npm test`](#npm-test)
    - [`npm run build`](#npm-run-build)
    - [`npm run eject`](#npm-run-eject)
  - [Learn More](#learn-more)
    - [Code Splitting](#code-splitting)
    - [Analyzing the Bundle Size](#analyzing-the-bundle-size)
    - [Making a Progressive Web App](#making-a-progressive-web-app)
    - [Advanced Configuration](#advanced-configuration)
    - [Deployment](#deployment)
    - [`npm run build` fails to minify](#npm-run-build-fails-to-minify)
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


# Walkthrough
## Step 1. Login 
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



In the project directory, you can run:

### `npm start`

Runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in your browser.

The page will reload when you make changes.\
You may also see any lint errors in the console.

### `npm test`

Launches the test runner in the interactive watch mode.\
See the section about [running tests](https://facebook.github.io/create-react-app/docs/running-tests) for more information.

### `npm run build`

Builds the app for production to the `build` folder.\
It correctly bundles React in production mode and optimizes the build for the best performance.

The build is minified and the filenames include the hashes.\
Your app is ready to be deployed!

See the section about [deployment](https://facebook.github.io/create-react-app/docs/deployment) for more information.

### `npm run eject`

**Note: this is a one-way operation. Once you `eject`, you can't go back!**

If you aren't satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.

Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except `eject` will still work, but they will point to the copied scripts so you can tweak them. At this point you're on your own.

You don't have to ever use `eject`. The curated feature set is suitable for small and middle deployments, and you shouldn't feel obligated to use this feature. However we understand that this tool wouldn't be useful if you couldn't customize it when you are ready for it.

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

To learn React, check out the [React documentation](https://reactjs.org/).

### Code Splitting

This section has moved here: [https://facebook.github.io/create-react-app/docs/code-splitting](https://facebook.github.io/create-react-app/docs/code-splitting)

### Analyzing the Bundle Size

This section has moved here: [https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size](https://facebook.github.io/create-react-app/docs/analyzing-the-bundle-size)

### Making a Progressive Web App

This section has moved here: [https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app)

### Advanced Configuration

This section has moved here: [https://facebook.github.io/create-react-app/docs/advanced-configuration](https://facebook.github.io/create-react-app/docs/advanced-configuration)

### Deployment

This section has moved here: [https://facebook.github.io/create-react-app/docs/deployment](https://facebook.github.io/create-react-app/docs/deployment)

### `npm run build` fails to minify

This section has moved here: [https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify](https://facebook.github.io/create-react-app/docs/troubleshooting#npm-run-build-fails-to-minify)


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
