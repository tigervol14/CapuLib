# CaPuLiB!

Capulib is a library mod that is made for mod creators to make mod creation an easier experience! 




# How To Use

Here is a tutorial on how to use CapuLib.

#### For Users
Download the CapuLib.dll from the github page
Copy it over to your mods folder
And you have it installed!


#### For Developers
Add CapuLib.dll as a reference in your visual studio project
Then follow the tutorial down there.

‎ 
‎ 
‎ 
‎ 

## Player Module

The Player module has multiple different functions to control the player & more!

### Change Bounce:
The Change bounce function is pretty straight forward! You are able to use this method to do it.
```CapuLib.Modules.Player.ChangeBounce(100)```
You are able to change the 100 at the end to any number you want, the less the number the more bouncy it is.
If you want to change it to the default put the number 200.

### Change Size:
The Change size function is alsooo pretty straight forward! Heres an example of code.
```CapuLib.Modules.Player.ChangeSize(1)```
It is pretty obvious that the lower the number is the smaller you are, and the bigger the number is the bigger you are.

### Send Vibration & Click sound:
The send vibration function is the way you are able to vibrate the controller.
```CapuLib.Modules.Player.SendVibration(true)```
the boolean at the end is to decide if you want to send it to the left controller or the right controller.
true = Left Controller
false = Right Controller
There is also another function similar to this that is used in the buttons!
```CapuLib.Modules.Player.ClickSound(true, 0)```
Keep the 0 as 0.

More Player Module Documentation Later.
