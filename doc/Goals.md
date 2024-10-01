There's many goals of the game. Through these various goals, the game ultimately becomes a platform.

# Machine accessibility
Spiral Knights found a lot of success through being a browser game that could be played on most systems, far ahead of its time. Although browser is a pretty messy target to develop for, the game should definitely be made accessible to a wide as possible audience. Godot Engine enables this with cross platform support.

* Low system requirements
* Cross platform
	* Windows as primary target
	* Linux as secondary target -- smaller userbase, but free to export to and test and has gotten so much better in the last decade. Linux users are also great bug reporters.
	* Mac as tertiary target -- dwindling userbase of gamers and becoming more segregated from Windows and Linux due to change of processor architecture and will require expensive, dedicated machines to test on, but still free to export from Godot.
	* Android and iOS are also possible exports for Godot. These targets are especially important for reaching the kids and many international audiences. Being on virtually every imaginable platform is a huge part of what made Fortnite a big hit with all the kids. However, as a passion project it will likely become very hard to support it well and these platforms are not reasonably prioritised from any perspective other than the business one.
	* Consoles could work, but we're not going there yet.

# Gameplay accessibility
Accessibility in gameplay is always a formidable goal and one that has thankfully become more respected with time. Spiral Knights was decent in some ways such as controller play and having space for self-imposed challenges, but failed in a few others such as colour smearing (enemies often shared colour scheme with the level) and overall lacking modern sensibilities.

* Tailorable difficulty
* Support for many input methods
* Fundamental modern accessibility features
	* Accessible to the colour blind
	* Closed captions

# Social
Spiral Knights acts as a strong social platform. Its characters are expressive, you can play intricate dress-up, and meet up in a digital physical space.

* Aesthetic character customisation
* Chat systems
* Public socialising lobbies (town squares)
* Up to ~100 players per social lobby (will probably perform poorly on lower-end machines)

# Roguelike
Spiral Knights pulls on roguelikes with its Arcade gates, randomised levels, and pick-ups. An even stronger roguelike system where you also pick up gear would be fun and provide a lot of replay value.

* Support for randomised and semi-randomised levels
* Per-run pickups
* Roguelike mode where you start out with little gear and get more with time

# Competitive
Lockdown is a wonderful part of Spiral Knights with an extremely high competitive level, complex mechanics and strategising. It also suffered a lot of flaws due to unfit netcode, pay to win aspects, imbalanced weapons, and toxicity.

* Better adjusted netcode to reduce the impact of latency and instability
* Fog of war and shared visibility of the map
* PvP-only adjustments to balance
* More interesting game modes
* Optimisation for high FPS
* No pay to win elements

# Player-created content
A commonly requested feature for SK, and something that would doubtlessly keep the community engaged. If the game is open source, this could be done in the engine editor. More reasonably it would be in-game in the form of custom emblems, a level editor, and possibly a weapon design system. This would take more work, but would allow more players to engage.

# Gratifying difficult content
Spiral Knights unfortunately mostly introduced difficulty through throwing more monsters at the player and making them soak up more damage.

Fun challenges are often introduced through:
* Monster formations (e.g. Trojans spawning with their backs covered; turrets spawning in inconvenient locations and with cover from melee enemies)
* Spawn wave management (e.g. managing the turrets and the big finale in arenas)

Less fun challenge is generally introduced through:
* More monsters (e.g. Firestorm Citadel's endless waves of zombies in D26 finale)
* Damage sponging
* Bullshit mechanics (e.g. Heart of Ice's wandering souls)

Ideas for better difficulty implementation:
* Difficulty should only marginally affect monster health -- when pushed for artificial difficulty, more monsters is generally more fun than spongier monsters even if it's not necessarily a great design method.
* Monsters can have variable acting speed
* Monsters can have variable AI. For example, in early SK, Alpha Wolvers would aim towards the player between every bite. This was deemed too challenging, and they were nerfed to just bite in a straight line. This could be changed so that the re-homing behaviour is present in higher difficulties. There could be a change of direction between bites that scales between 0 degrees on easy and 180 degrees on hardest, putting the change to a maximum of something like 30 degrees on easy-ish, 90 degrees on medium, and 120 degrees on hard-ish.

# Single player and local play
The game should be resilient to any central server going down. Not relying on a central server for everything would be good for costs too.

# Central server
The game should have a central server to handle progression, socialising, matchmaking, etc.