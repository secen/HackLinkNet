# The Game Design Document
- Name: HackLinkNet - HACKLINKNET 
- Genre: Hacking
- Platform: Windows PC/STEAM
- ENGINE: WPF C#
- Development Time 2020.07.01-Present
- Estimated End Of Development Time: 2020.09.22
# Features
- Over 30 storyline missions
- 3 Factions
- Multiple Endings
- Randomly generated world and mission
- Versus mode (BONUS FEATURE)
- Semi-realistic commands and software
# Inspirations
- Hacknet
- Uplink
- Hacker Evolution
#Design Goals
- Smooth Gameplay
- Immersive Atmosphere (Music and Presentation Helps a TON)
# Details
## Start Screen
- Two Buttons and Two Text Boxes:
  -TextBoxes:
    -Username
    -Password
  -Buttons:
    -Login
    -Register
- Previous Agents Tab on the right
- Title Screen At The Top
- World Map in the background.
## Mission Structure
- Name
- Description
- Condition to fulfill, possible conditions:
  - Destroy data
  - Copy data
  - Wipe server
  - Modify Logs
  - Delete Logs
  - Respond with Information
  - Modifying Accounts:
   - Medical
   - Bank
   - Criminal
   - User
- Condition to take (usually a rank in the organisation)
- Pay
## Server Structure
- Greet Page (usually a login screen)
- Files
- Logs
- Links
- Users
- Admin Options
### Special kinds of servers
#### Banking
Banking servers usually have increased security, and they hold bank accounts.
Bank Account Makeup:
- Number
- Sum
- Transfers
#### Mission
Mission servers are the way the player is able to gain missions, while initially only one will be available, more will open up (to a maximum of 5), from different organisations. These are also the places where the player can read up on the news and purchase hacking tools.
#### Forums
Organisations have different forums where they communicate, this is one way to scoop info, and so called secret missions, where the reward varies greatly, as opposed to standard or story missions, think of them as side quests.
#### Organisational
Organisations have servers that hold their records, these can be broken into, and that will be required for certain quests, or as side activities the player can do if he chooses to do so, in order to learn more about the so called "Lore" of the game.
## Hacking
Hacking is done via hacking tools, which can be purchased from mission servers or downloaded from forums.
### The Password Cracker
The Password Cracker comes in various versions and forms:
#### The Bruter
The Bruter brute forces the password, taking the longest time to resolve, usually triggering detection systems.
#### The Dictionary Attacker
The Dictionary Attacker uses a common word dictionary to guess a common password, particularly useful for forums and email servers.
### The Decryptor
Decryptors decrypt files in order for the user to be able to use the contents.
#### SHA-256
#### Eliptical Curve
#### MD512
## File Utilities
### File Copier
### File Remover
### File Reader
