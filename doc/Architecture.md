For costs and ease of development, the game should be built on Godot with peer-to-peer being the primary method of play. Godot can run headless to make servers, which can be used to host larger public lobbies, private gameplay spaces, and competitive spaces.

A central server handles authentication for online play, matchmaking, server browsing, and orchestration of gameplay servers. However, the central server is not crucial to the game. This has two important consequences:
* There is no need for central server development until relatively far into the game's development cycle
* The game is made resilient to the server going down and remains playable even if the central server is taken down