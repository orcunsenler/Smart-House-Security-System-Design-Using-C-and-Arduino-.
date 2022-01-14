#include <DHT.h>
#include <Keypad.h>
#include <Servo.h>


#define PIR 2
#define ledpin 11
#define ledpin2 8
#define DHTPIN  12
#define DHTTYPE DHT11


DHT dht(DHTPIN, DHTTYPE);
Servo Door;
int move=0;
int light = A1;
int light_value=0;
const byte row = 4;
const byte column = 4;
int forward=10;
int back=9;
int speed=3;




char key_board[row][column]={
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}
};

 byte row_pins[4]={22,24,26,28};
 byte column_pins[4]={30,32,34,36};
 Keypad KeyBoard = Keypad(makeKeymap(key_board),row_pins,column_pins,row,column);
String sendText;


void setup() {
  
  pinMode(ledpin,OUTPUT);
  pinMode(light, INPUT);
  pinMode(5,OUTPUT);
  pinMode(ledpin2,OUTPUT);
  pinMode(6,OUTPUT);
  pinMode(PIR, INPUT);
  pinMode(forward,OUTPUT);
  pinMode(back,OUTPUT);
  pinMode(speed,OUTPUT);
  dht.begin();
  Door.attach(7);
  Door.write(90);
  digitalWrite(speed,LOW);
  digitalWrite(forward,HIGH);
  digitalWrite(back,LOW);
  Serial.begin(9600);
}

void loop() {
 
  char key = KeyBoard.getKey();
  char keySend;
  move = digitalRead(PIR);
  int mois = dht.readHumidity();
  int temp = dht.readTemperature();
  light_value = analogRead(light);
    if(key!=NO_KEY){keySend=key;
  sendText = sendText + keySend + "," + temp + "," + mois + "," + light_value + "," + move + ",";
  Serial.println(sendText);
  sendText = "";
  }
  else{
  keySend = '*';
  sendText = sendText + keySend + "," + temp + "," + mois + "," + light_value + "," + move + ",";
  Serial.println(sendText);
  sendText = "";
    }
   delay(500);
if(Serial.available())
{
  char dataIn= Serial.read();
  int d = 300;
  if(dataIn == 'a')
  {
    Door.write(0);
    }
  else if (dataIn == 'b')
   {
    Door.write(90);
    }
 else if(dataIn== 'd')
  {
    analogWrite(ledpin,light_value/5);
    analogWrite(8,light_value/5);
    analogWrite(5,light_value/5);
    
    }
  else if(dataIn=='e')
   {
    analogWrite(ledpin,light_value/10);
    analogWrite(8,light_value/10);
    analogWrite(5,light_value/10);
    }
 else if(dataIn=='f')
  {
    analogWrite(ledpin,light_value/15);
    analogWrite(8,light_value/15);
    analogWrite(5,light_value/15);
    }
 else  if(dataIn=='g')
  {
    analogWrite(ledpin,0);
    analogWrite(8,0);
    analogWrite(5,0);
    }
    
   else if(dataIn=='x')
    {
      digitalWrite(5,LOW);
      digitalWrite(ledpin,LOW);
      digitalWrite(8,LOW);
     noTone(6);
      }
   else if(dataIn=='y')
      {
        
       digitalWrite(5,HIGH);
       digitalWrite(8,HIGH);
       digitalWrite(11,HIGH);
       tone(6,d);
        }
      else if(dataIn=='r')
        {
          analogWrite(speed,175);
          
         }
       else if(dataIn=='t')
         {
       
          analogWrite(speed,200);
          //delay(10000);
        
          }
       else if(dataIn=='u')
          {
            digitalWrite(speed,250);
          
            }
         else if(dataIn=='p')
            {
              digitalWrite(speed,LOW);
              
              }
 
          delay(1000);   
}
 
}
