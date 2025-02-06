# CisDeck
## Streamdeck with custom Software and Hardware

### Hardware
The Hardware consists out of 2 main Components:
- A 4x4 Matrix Membrane Keypad
- An Arduino Nano

The packaging is made out of cardboard and tape due to missing materials.

Images:

<img src="https://github.com/ironflipper/cisdeck/blob/main/githubutils/1000026987.jpg?raw=true" width="400" height="500">
<img src="https://github.com/ironflipper/cisdeck/blob/main/githubutils/1000026988.jpg?raw=true" width="400" height="500">

### You want to build your own Cisdeck?
[How to build your own Cisdeck](https://github.com/CisDeck/cisdeck-arduino/wiki)

### Software
There are 2 software for this project.
1. Software on the Arduino

*The Software on the Arduino consists of a 4x4 matrix Keypad Reader code.
The key that got clicked gets printed into a defined serial output/console.*

2. Software on a Device/Computer

*This is a C# Software consisting of a GUI for User-Interaction and a back-end Script that checks the serial output for pressed keys.
If a key is pressed, the code will execute the configured action in the GUI.
Every configured Option is saved in a file in the main directory.*
