Jersey Boys
present
Amethyst

START SCENE FILE
The two scenes of the project are `Assets/Scenes/StartOfGame` and `Assets/Scenes/Level1`.
The entry point of the game is the `Assets/Scenes/StartOfGame` scene.

HOW TO PLAY
In order to run the project, you can simply run one of the provided builds (Only MacOS build is tested).
Also, the meta files are made visible in the settings if you decide to launch the project in Unity Game Engine.

- You can navigate around the main player using the left, right, and side arrow keys.
- As soon as the game starts, you will notice a secondary robot player headed towards you. You can observe the AI implemented here to Follow
- You will notice yellow spheres (placeholder enemies) that close in on the player and attack when close. If the player runs far away, the spheres leave him alone and patrol their designated area
- You can kill these yellow enemies by pressing spacebar and jumping on top of them
- You will also notice red pills that you can collect to boost your health
- You will notice four beams of yellow light that highlight where the four gems are located which you have to collect
- For now, the gem located in the forest behind the player is obstacle free and so is the gem located in the rocky mountains to the right
- The third gem located in the river in front of you is in the middle of the lake, and you have to jump through floating plates to get to it
- The fourth gem is located on a warehouse at the other end of the game terrain, and you have to pass through a spinning fan to get to it
- You can hear audio when you collect the gems, get attacked by enemy, kill an enemy. You can also hear spatial audio of flowing water as you get close to the river and of people talking when you get to warehouse

KNOWN PROBLEM AREAS
- The design of obstacles is not fully complete yet at the moment hence the gems can be captured without much struggle. More intriguing and complex obstacles are in development. 
- We have noticed some lag and inconvenience in mouse movement to steer player at certain times which needs to be investigated more

MANIFEST
Following is a breakdown of the different areas the team members worked in:

Vivek Pandey

- Project setup
- Design and development of the entire game terrain, environment, and animations for spinning fan and floating elevators
- Game Audio
- Scripts contributed:
    - Assets/Scripts/Sound.cs: 
        Serializable class that holds the various properties of audio source and audio clips
    - Assets/Scripts/AudioManager.cs: 
        The centralized audio manager that controls the game audio throughout the game. Manages all the audio clips, handles creation various audio sources, and controls playback of the audio.
        The kinds of audio used in the game so far are 
        - theme music (temporarily disabled),
        - notifications of gems collection, health damage from enemy and killing of enemy
        - spatial audio of flowing river, noises of people as the player navigates to various regions of the game terrain
    - Assets/Scripts/KeyStrokesHandler.cs
        Handles the shortcut keystrokes in the game
    - Assets/Scripts/FanSpinTrigger.cs:
        Controls the playback of a mechanim animation that spins a fan when the player gets close


Dhruvik Patel

- Created two colliders on the enemies to detect damage or destroy. If the enemy runs into the player, damage is collected by the player and this is realized by the collider attached to the enemy. Same goes for the destroy collider, which rests on top of the enemy as currently the only way to kill an enemy is to jump on it.
- Created an Animator for Robot Kyle that controls what animation to play for Robot Kyle using different AIStates defined in KyleKiller.cs and WalkScript.cs. Transitions in animation is defined by two parameters ("AtTarget" and "Attacking").
- Scripts contributed:
    - Assets/Characters/Robot Kyle/Scripts/WalkScript.cs
        This script controls how Robot Kyle behaves by switching its animations up based on the AIStates. If the player is farther away, Robot Kyle would follow waypoints sets in place and thus use the Walk animation (Patrol state). If the player is somewhat closer to Robot Kyle, it would start pursue and would use the walk animation (Purse state). Lastly if Robot Kyle is in the attack state, it would use the run animation to chase the player. Once Robot Kyle catches up to the player, it would play the idle animation as it has reached it waypoint. Two parameters control the switch between the animations ("AtTarget" and "Attacking"). 
    - Assets/Scripts/DestroyEnemy.cs
        This script controls when to destroy to the enemy by using collider to detect when the player jumps on the top of the enemy. When a player jumps on top, the OnTriggerEnter() method would destroy the enemy with a delay of 0.25 seconds.
    - Assets/Characters/Robot Kyle/Scripts/KyleKiller.cs (Authored by Adithya)
        Added the AIState information to make the WalkScript.cs script work. Please see details from Adithya on KyleKiller.cs.

Adithya Thiruvalluvan

- Created a new enemy character using unity store assets 'Robot Kyle' added components for rigidbody, capsule collider, Nav Mesh Agent, and kylekiller script. Tuned Tranform scale and Nav Mesh Agent fields to make Kyle a large enemy capable of high speeds with slow acceleration and turning direction.
- Scripts contributed:
    - Assets/Characters/Robot Kyle/Scripts/KyleKiller.cs
        This script enables Nav Mesh Agent for Robot Kyle to pursue his target while facing in the correct direction. I've included a Facetarget function that uses Quaternion Slerp to naturally rotate Kyle towards the target direction.

Sujil Maharjan

- Worked on configuring the EnemyAI and Shield. Created a cylinder for the shield and appropriately transparent material. For the Enemy AI, I put 4 waypoints where each enemy will patrol 2 of those waypoints (overlapping) and when the target is near, it will change the state to pursuing the target.
- Scripts contributed:
    - Assets/Scripts/Shield.cs
        This script activates the shield for the player. During the time that the shield is activated, enemies cannot attack the player. The attack would not decrease the health of the player.
    - Assets/EnemyAI.cs
        This script enables the NavMeshAgent to go through multiple states. First state is Patrol. This is when the yellow balls (current implementation of the enemy which will be later replaced by actual characters) patrol two different waypoints. Another state is Persue. This is when the player is close to the yellow balls. Then the enemy will start pursuing the player actively. If the enemy reaches close enough to the player to attack then, another state is Attack. This is when the health will be impacted for the player and enemy. 


Arjun Bastola



SIZE REDUCTION
For size reduction, we reduced unnecessary cache files like the Library and obj folders. We also cleaned out any assets that weren't used in the game.    
Some assets related to terrain development were quite large in size to begin with (for example, the conifers tree asset), and therefore, they still ended up taking more space than anticipated.
