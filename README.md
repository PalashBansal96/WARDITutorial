# Unity Tutorial
Basic ball game scene for a basic GameDev tutorial with unity for the WARDI course at IIIT Delhi.

## About
This is the cleaned and improved upon version of the code that was done in the class. Made in Unity 2018.
Check the commits for a step by step walkthrough of the changes.

## Major changes from the class.
* Prefab folder: Prefabs are game objects that can be used again and again in the scene. You can use these to create more similar levels own levels. [Read more here](https://docs.unity3d.com/Manual/Prefabs.html).
* Coin collection code and score management have been moved to separate scripts and attached to the Coin and Player objects.
* Camera has a follow script attached that follows the player. 
* Player movement has parameters that can be changed dynamically by game designers from the editor.

## Future Steps 
* Try to add more platforms and create a complete level. 
* Duplicate the current scene and create another level.
* Try to link the levels by using the [LoadScene](https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html) method in Unity.
* Use GoogleVR library to integrate Cardboard VR in the game and build on mobile. Follow this [guide](https://developers.google.com/vr/develop/unity/get-started-android).
