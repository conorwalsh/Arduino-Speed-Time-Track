/*

                   Copyright (c) 2016 Conor Walsh
                  Website: http://www.conorwalsh.net
                GitHub:  https://github.com/conorwalsh
                   Project: Arduino Speed Time Track

            MIT LICENCE

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
    _____      ____                        __        __    _     _       ____   ___  _  __   
   / ___ \    / ___|___  _ __   ___  _ __  \ \      / /_ _| |___| |__   |___ \ / _ \/ |/ /_  
  / / __| \  | |   / _ \| '_ \ / _ \| '__|  \ \ /\ / / _` | / __| '_ \    __) | | | | | '_ \ 
 | | (__   | | |__| (_) | | | | (_) | |      \ V  V / (_| | \__ \ | | |  / __/| |_| | | (_) |
  \ \___| /   \____\___/|_| |_|\___/|_|       \_/\_/ \__,_|_|___/_| |_| |_____|\___/|_|\___/ 
   \_____/                                                                                   
 
 */

//If you are using this code with a serial monitor and NOT using the utility change this value to 1
int DEBUG = 0;

//This value chnages to 1 when the program is ready to run DO NOT CHANGE THIS VALUE
int RTG = 0;

//*******SET VALUES*******//
int ldr1 = A0;
int ldr2 = A1;
int ldr3 = A2;
int ldr4 = A3;

unsigned long timeStart1, timeEnd1, timeStart2, timeEnd2, timeStart3, timeEnd3, timeStart4, timeEnd4;

int timeElap1;
int timeElap2;
int timeElap3;
int timeElap4;

float speed1;
float speed2;
float speed3;
float speed4;

float speedkph1;
float speedkph2;
float speedkph3;
float speedkph4;

int ldrVal1;
int ldrVal2;
int ldrVal3;
int ldrVal4;

//Adjust these values to set the sensitivity of the LDRs
int threshold = 150;
//Use this value for an LDR if it is less sensitive than the other LDRs
int thresholdsensitive = 50;

int ldrValThres1;
int ldrValThres2;
int ldrValThres3;
int ldrValThres4;
//*****SET VALUES END*****//

//*******SET CAR LENGTH*******//
//Set you toy car length in millimetres
int carLen = 83;
//*****SET CAR LENGTH END*****//

int speedno = 0;

byte inputByte_0;
byte inputByte_1;
byte inputByte_2;
byte inputByte_3;
byte inputByte_4;

void setup() {
  Serial.begin(9600);

  if(DEBUG==1){
  Serial.println("CALIBRATION");
  Serial.println("");
  }
  
  int ldrval1 = analogRead(ldr1);
  
  ldrValThres1 = analogRead(ldr1) - threshold;

  if(DEBUG==1){
  Serial.print("Current LDR1 value: ");
  Serial.println(ldrval1);

  Serial.print("LDR1 Recording Threshold: ");
  Serial.println(ldrValThres1);
  Serial.println("");
  }

  int ldrval2 = analogRead(ldr2);
  
  ldrValThres2 = analogRead(ldr2) - thresholdsensitive;
  
  if(DEBUG==1){
  Serial.print("Current LDR2 value: ");
  Serial.println(ldrval2);

  Serial.print("LDR2 Recording Threshold: ");
  Serial.println(ldrValThres2);
  Serial.println("");
  }

  int ldrval3 = analogRead(ldr3);
  
  ldrValThres3 = analogRead(ldr3) - threshold;
  
  if(DEBUG==1){
  Serial.print("Current LDR3 value: ");
  Serial.println(ldrval3);

  Serial.print("LDR3 Recording Threshold: ");
  Serial.println(ldrValThres3);
  Serial.println("");
  }
  
  int ldrval4 = analogRead(ldr4);
  
  ldrValThres4 = analogRead(ldr4) - threshold;
  
  if(DEBUG==1){
  Serial.print("Current LDR4 value: ");
  Serial.println(ldrval4);

  Serial.print("LDR4 Recording Threshold: ");
  Serial.println(ldrValThres4);
  Serial.println("");
  }

  /*if(DEBUG == 1){
    RTG = 1;
  }*/

  while(RTG!=1){
  if (Serial.available() == 5) 
    {
      //Read buffer
      inputByte_0 = Serial.read();
      delay(100);    
      inputByte_1 = Serial.read();
      delay(100);      
      inputByte_2 = Serial.read();
      delay(100);      
      inputByte_3 = Serial.read();
      delay(100);
      inputByte_4 = Serial.read();   
    }
    //Check for start of Message
    if(inputByte_0 == 16)
    {       
         //Detect Command type
         switch (inputByte_1) 
         {
            case 127:
               //Set PIN and value
               switch (inputByte_2)
              {
                case 4:
                  if(inputByte_3 == 255)
                  {
                    //digitalWrite(ledPin_3, HIGH); 
                    break;
                  }
                  else
                  {
                    //digitalWrite(ledPin_3, LOW); 
                    break;
                  }
                break;
              } 
              break;
            case 128:
              //Say hello
              Serial.print("HELLO FROM ARDUINO");
              RTG = 1;
              break;
          } 
          //Clear Message bytes
          inputByte_0 = 0;
          inputByte_1 = 0;
          inputByte_2 = 0;
          inputByte_3 = 0;
          inputByte_4 = 0;
          //Let the PC know we are ready for more data
          Serial.print("-READY TO RECEIVE");
    }
  }

  if(DEBUG==1){
  Serial.println("READY");
  Serial.println("");
  }
  
}

void loop() {
  
  ldrVal1 = analogRead(ldr1);
  if(ldrVal1<=ldrValThres1){
    timeStart1 = millis();
      
    if(DEBUG==1){
    Serial.print("Start Time 1: ");
    Serial.println(timeStart1);
    }
    while(ldrVal1<=ldrValThres1){
      ldrVal1 = analogRead(ldr1);
    }
    timeEnd1 = millis();
      
    if(DEBUG==1){    
    Serial.print("End Time 1: ");
    Serial.println(timeEnd1);
    }
    timeElap1 = timeEnd1 - timeStart1;
          
    if(DEBUG==1){
    Serial.print("Elapsed Time 1: ");
    Serial.println(timeElap1);
    }
    
    speed1 = (float)carLen / (float)timeElap1;
    speedkph1 = speed1 * 3.6;
    if(DEBUG==1){
    Serial.print("Speed 1: ");
    Serial.print(speed1);
    Serial.print("m/s ");
    }
    else{
      Serial.print(speed1);
      Serial.print(":");
    }
          
    if(DEBUG==1){
    Serial.print(speedkph1);
    Serial.println("km/h");
    Serial.println("");
    }
    

    speedno++;
  }


  ldrVal2 = analogRead(ldr2);
  if(ldrVal2<=ldrValThres2){
    timeStart2 = millis();
          
    if(DEBUG==1){
    Serial.print("Start Time 2: ");
    Serial.println(timeStart2);
    }
    while(ldrVal2<=ldrValThres2){
      ldrVal2 = analogRead(ldr2);
    }
    timeEnd2 = millis();
          
    if(DEBUG==1){
    Serial.print("End Time 2: ");
    Serial.println(timeEnd2);
    }
    timeElap2 = timeEnd2 - timeStart2;
          
    if(DEBUG==1){
    Serial.print("Elapsed Time 2: ");
    Serial.println(timeElap2);
    }
    
    speed2 = (float)carLen / (float)timeElap2;
    speedkph2 = speed2 * 3.6;
    if(DEBUG==1){
    Serial.print("Speed 2: ");
    Serial.print(speed2);
    Serial.print("m/s ");
    }
    else{
      Serial.print(speed2);
      Serial.print(":");
    }
    if(DEBUG==1){
    Serial.print(speedkph2);
    Serial.println("km/h");
    Serial.println("");
    }
    
    
    speedno++;
  }


  ldrVal3 = analogRead(ldr3);
  if(ldrVal3<=ldrValThres3){
    timeStart3 = millis();
          
    if(DEBUG==1){
    Serial.print("Start Time 3: ");
    Serial.println(timeStart3);
    }
    while(ldrVal3<=ldrValThres3){
      ldrVal3 = analogRead(ldr3);
    }
    timeEnd3 = millis();
          
    if(DEBUG==1){
    Serial.print("End Time 3: ");
    Serial.println(timeEnd3);
    }
    timeElap3 = timeEnd3 - timeStart3;
          
    if(DEBUG==1){
    Serial.print("Elapsed Time 3: ");
    Serial.println(timeElap3);
    }
    
    speed3 = (float)carLen / (float)timeElap3;
    speedkph3 = speed3 * 3.6;
    if(DEBUG==1){
    Serial.print("Speed 3: ");
    Serial.print(speed3);
    Serial.print("m/s ");
    }
    else{
      Serial.print(speed3);
      Serial.print(":");
    }     
    if(DEBUG==1){
    Serial.print(speedkph3);
    Serial.println("km/h");
    Serial.println("");
    }
    
    
    speedno++;
  }

  
  ldrVal4 = analogRead(ldr4);
  if(ldrVal4<=ldrValThres4){
    timeStart4 = millis();
          
    if(DEBUG==1){
    Serial.print("Start Time 4: ");
    Serial.println(timeStart4);
    }
    while(ldrVal4<=ldrValThres4){
      ldrVal4 = analogRead(ldr4);
    }
    timeEnd4 = millis();
          
    if(DEBUG==1){
    Serial.print("End Time 4: ");
    Serial.println(timeEnd4);
    }
    timeElap4 = timeEnd4 - timeStart4;
          
    if(DEBUG==1){
    Serial.print("Elapsed Time 4: ");
    Serial.println(timeElap4);
    }
    
    speed4 = (float)carLen / (float)timeElap4;
    speedkph4 = speed4 * 3.6;
    if(DEBUG==1){
    Serial.print("Speed 4: ");
    Serial.print(speed4);
    Serial.print("m/s ");
    }
    else{
      Serial.print(speed4);
      Serial.print(":");
    }
    if(DEBUG==1){
    Serial.print(speedkph4);
    Serial.println("km/h");
    Serial.println("");
    }
    
    
    speedno++;
  }

  if(speedno>=4){
          
    if(DEBUG==1){
    Serial.println("");
    Serial.print("Speed 1: ");
    Serial.print(speed1);
    Serial.print("m/s Speed 2: ");
    Serial.print(speed2);
    Serial.print("m/s Speed 3: ");
    Serial.print(speed3);
    Serial.print("m/s Speed 4: ");
    Serial.print(speed4);
    Serial.println("m/s");
    Serial.println("");

    Serial.println("");
    Serial.print("Speed 1: ");
    Serial.print(speedkph1);
    Serial.print("km/h Speed 2: ");
    Serial.print(speedkph2);
    Serial.print("km/h Speed 3: ");
    Serial.print(speedkph3);
    Serial.print("km/h Speed 4: ");
    Serial.print(speedkph4);
    Serial.println("km/h");
    Serial.println("");
    }
    else{
      Serial.print(timeEnd1);
      Serial.print(":");
      Serial.print(timeEnd2);
      Serial.print(":");
      Serial.print(timeEnd3);
      Serial.print(":");
      Serial.print(timeEnd4);
      Serial.println("");
    }
    speedno = 0;
  }
}
