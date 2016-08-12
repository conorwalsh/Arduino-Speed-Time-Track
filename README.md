# Arduino Speed Time Track

Description
-----------

This project is a track that toy cars can race down. An arduino records the speed and times of each car on each run. The Arduino then sends this information to a Windows Application which records the data and draws a speed time graph. The software also calculates the acceleration of the car. The Arduino uses four LDRs and the length of the car to calculate its speed and acceleration. The Arduino uses LDRs to sense the light levels above the track, when a car passes over the sensor the sensor senses that it has gone dark and the Arduino times how long it is dark for. The Arduino then calculates the speed by dividing the toy cars length by the time taken to give the speed in m/s.

Setup
---------
1. Make the Car Track either according to my instructions or using your own specifications.
2. Wire the Circuit according to the circuit diagram.
3. You need to edit <a href="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Arduino%20Code/Arduino_Speed_Time_Track/Arduino_Speed_Time_Track.ino#L77">Line 77</a> of the Arduino code with the Length of your toy car. This value is used to calculate the speed of the car. IF THIS VALUE IS NOT CORRECT THE SPEED VALUES WILL BE INCORRECT.
4. Upload Arduino code to the Arduino.
5. You can use the prebuilt .exe file in the Ready to go folder, if you want to edit the utility you need to use Visual Studio to edit the Visual Studio Files.

Schematics
-----------

Breadboard View:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Schematics/Arduino%20Speed%20Time%20Track%20Fritzing_bb.png" width="350"/>

Schematic View:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Schematics/Arduino%20Speed%20Time%20Track%20Fritzing_schem.png" width="350"/>

Screenshots
---------

Utility After Startup:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Utility%20Screenshots/Startup.png" width="300"/>

Device Connected:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Utility%20Screenshots/Connected.png" width="300"/>

Test Running:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Utility%20Screenshots/Running%20Test.png" width="300"/>

Test Results with Graph (The graphs can be saved as image files):<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Utility%20Screenshots/Results%20and%20Graph.png" width="300"/>

Test Results with Graph and Readout (The Readout can be saved as a text file or copied to the clipboard):<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Utility%20Screenshots/Readout.png" width="300"/>

Sample Saved Graph Image:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Utility%20Screenshots/Sample%20Graph%20Saved%20Image.png" width="300"/>

Sample Saved Readout Text File:<br/>
<a href="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Utility%20Screenshots/Sample%20Graph%20Readout%20Text%20File.txt" target="_blank">Click for Sample Readout Text File</a>

Car Track
-----------------------
The track is made from a piece of 2x1 (44mm x 22mm) timber that is 1.6 metres long.<br/>
The 2x1 is enclosed by a think piece of plywood 5mm thick (The width is not important) and 32mm high. The plywood is used as a guide rail on both sides of the 2x1 and as a stop at the end.<br/>
I have marked a Start Line 100mm into the track to release the toy cars from this makes the track 1.5 metres long. <br/>
I drilled holes at 460mm, 720mm, 980mm and 1240mm for the LDRs (Every 260mm). This allows the toy car abit of distance to get moving before the first measurement is taken and it also allows space at the end in case the toy car bounces off the stop at the end of the track so that it won't go over the sensor again. If you drill a smaller hole first to allow the leads from the LDR to pass through and then drill a hole the size of the LDR face and its depth it will hold the LDR securly.<br/>
<br/><strong>Photos</strong><br/>
Track and Laptop on my Desk:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Track%20Photos/Track%20and%20Laptop.jpg" width="400"/>

Arduino and Breadboard Circuit:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Track%20Photos/Arduino%20and%20Breadboard.jpg" width="400"/>

LDR Sensor in Track:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Track%20Photos/Sensor%20in%20Track.jpg" width="400"/>

Toy Car on Track:<br/>
<img src="https://github.com/conorwalsh/Arduino-Speed-Time-Track/blob/master/Track%20Photos/Car%20on%20Track.jpg" width="400"/>

Credits
--------
Thanks to http://playground.arduino.cc/Csharp/SerialCommsCSharp for the code that I based the serial communication code for the C# application on.

License (MIT)
------
Copyright (c) 2016 Conor Walsh 

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Thanks
------

Thank you for taking the time to look at this project I hope that it is of use to you,<br/>
<img src="http://conorwalsh.net/sig.png" /><br/>
Conor Walsh.
