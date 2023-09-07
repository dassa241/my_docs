
#include <EEPROM.h>

#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7, 3, POSITIVE);  // Set the LCD I2C address
#include <Wire.h>
#include <dht.h>
#include <SoftwareSerial.h>
#define DHT21_A_PIN A0
#define e_fan 9
#define c_fan 10
#define light 11

byte count = 0;
bool mod = 1;
dht DHT_A;

SoftwareSerial mySerial(3, 2); // RX, TX
unsigned long mil = 0;
bool flag = 0;
String data, roll;
float te, hu, lux = 0;
byte  def_temp = 31, def_hu = 90, def_lux = 30;

bool t_flag = 0, h_flag, l_flag = 0;
bool li_ok, c_ok, e_ok;

long li_count = 0, c_count = 0, e_count = 0;
void setup() {

 Serial.begin(9600);
  mySerial.begin(9600);
  Serial.println("Strat");
  pinMode(e_fan, OUTPUT);
  pinMode(c_fan, OUTPUT);
  pinMode(light, OUTPUT);
  digitalWrite(e_fan, LOW);
  digitalWrite(c_fan, LOW);
  digitalWrite(light, LOW);

  lcd.begin(16, 2);
  lcd.setCursor(0, 0);
  lcd.print("Starting...");
  delay(2000);
 

  lcd.setCursor(0, 1);
  lcd.print("Waiting for PC");
  lcd.setCursor(0, 1);
  delay(2000);

  char ack;
  while (mySerial.find("1") <= 0 ) {
    mySerial.println("2");

  }





  lcd.clear();
  lcd.print("Connected");
  delay(2000);
  Serial.println("AT");
  delay(500);
  Serial.println("AT+CNMI=2,2,0,0,0");
  delay(500);
  Serial.println("AT+CMGF=1\r");
  delay(500);



  delay(100);

  dht();
  lux = analogRead(A1);
  lux = map(lux, 0, 1024, 0, 100);



}

void loop() {
  tym();
  // ;
  if (mySerial.available()) {
    char c = mySerial.read();
    if (c == '\n') {
      chk();
      //Serial.println(data);
      data = "";
    }
    else {
      data += c;
    }
  }

  if (Serial.available()) {
    char c = Serial.read();
    //Serial.print(c);
    if (c == '\n') {
      chk();
      //Serial.println(data);
      data = "";
    }
    else {
      data += c;
    }
  }


  if (mod == 1) {
    lux = analogRead(A1);
    lux = map(lux, 0, 1024, 0, 100);
    if (lux < def_lux) {
      analogWrite(light, map(lux, 0, def_lux, 255.00, 0.00));
      li_ok = 1;
    }
    else {
      analogWrite(light, 0);
      li_ok = 0;
    }


    double te_val = te - def_temp;

    if (te_val >= 0 &&  te_val < 6) {
      te_val = te_val / 5.0 * 255.0;
      analogWrite(c_fan, te_val);
      c_ok = 1;
    }
    else if (te_val <= 0) {
      analogWrite(c_fan, 0);
      c_ok = 0;
    }
    else if (te_val > 5) {
      analogWrite(c_fan, 255);
      c_ok = 1;
    }


    double hu_val = hu - def_hu;

    if (hu_val >= 0 &&  hu_val < 6) {
      hu_val = hu_val / 5.0 * 255.0;
      analogWrite(e_fan, hu_val);
      e_ok = 1;
    }
    else if (hu_val < 0) {
      analogWrite(e_fan, 0);
      e_ok = 0;
    }
    else if (hu_val > 5) {
      analogWrite(e_fan, 255);
      e_ok = 1;
    }

  }

  if (flag) {
    dht();
    sms_contrl();
    flag = 0;

    lux = analogRead(A1);
    lux = map(lux, 0, 1024, 0, 100);

    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Hu ");
    lcd.print(hu);
    lcd.print("%");
    lcd.setCursor(0, 1);
    lcd.print("Tmp ");
    lcd.print(te);
    lcd.print("C");
    lcd.setCursor(15, 1);
    if (mod) {
      lcd.print("A");
    }
    else
      lcd.print("M");
    lcd.setCursor(10, 0);

    lcd.print("Lux");
    lcd.print(int(lux));
    lcd.print("%");
    count++;
    if (count == 1) {
      mySerial.print("L");
      mySerial.println(lux);
    }
    if (count == 2) {
      mySerial.print("H");
      mySerial.println(hu);
    }
    if (count == 3) {
      mySerial.print("T");
      mySerial.println(te);
      count = 0;
    }

  }

}


//***************************************************************************************************
void sms_contrl() {
  if (c_ok == 1 && t_flag == 0 && mod == 1 && c_count > 30) {
    roll = "Temp increase. Turn on the Cooling Fan\n";
    sms();
    t_flag = 1;
    c_count = 0;
  }

  if (c_ok == 0 && t_flag == 1) {
    t_flag = 0;
  }


  if (e_ok == 1 && h_flag == 0 && mod == 1 && e_count > 30) {

    roll = "Humidity increase. Turn on the Exhaust Fan\n";
    sms();
    h_flag = 1;
    e_count = 0;
  }

  if (e_ok == 0 && h_flag == 1) {
    h_flag = 0;
  }

  if (li_ok == 1 && l_flag == 0 && mod == 1 && li_count > 30) {

    roll = "Light level goes low. Turn on the Light\n";
    sms();
    l_flag = 1;
    li_count = 0;
  }

  if (li_ok == 0 && l_flag == 1 && mod == 1) {
    l_flag = 0;
  }

}
//****************************************************************************************************

void chk() {


  if (data.startsWith("T")) {
    def_temp = data.substring(1).toInt();
    EEPROM.update(0, def_temp);

    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Temp floating");
    lcd.setCursor(0, 1);
    lcd.print("   set to ");
    lcd.print(def_temp);
    delay(1000);


  }
  else if (data.startsWith("H")) {
    def_hu = data.substring(1).toInt();
    EEPROM.update(1, def_hu);
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Hu floating");
    lcd.setCursor(0, 1);
    lcd.print("   set to ");
    lcd.print(def_hu);
    delay(1000);

  }

  else if (data.startsWith("L")) {
    def_lux = data.substring(1).toInt();
    EEPROM.update(2, def_lux);
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Lux floating");
    lcd.setCursor(0, 1);
    lcd.print("   set to ");
    lcd.print(def_lux);
    delay(1000);


    /* lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("T ");
      lcd.print(def_temp);
      lcd.setCursor(6, 0);
      lcd.print("H");
      lcd.print(def_hu);
      lcd.setCursor(12, 0);
      lcd.print("T");
      lcd.print(def_lux);
      lcd.setCursor(0, 1);
      lcd.print("data Saved");
      delay(1000);*/

  }

  else if (data.indexOf("readunit") >= 0 ) {
    roll = "Reply from unit \n";
    sms();
  }

  // Serial.println(data.indexOf("cfoff"));
  if (data.indexOf("cfoff") >= 0 && mod == 0) {
    digitalWrite(c_fan, LOW);
    // Serial.println("c_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Cooling Fan off");
    delay(1000);
  }

  else if (data.indexOf("cflow") >= 0 && mod == 0) {
    analogWrite(c_fan, 50);
    // Serial.println("c_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Cooling Fan low");
    delay(1000);
  }

  else if (data.indexOf("cfmid") >= 0 && mod == 0) {
    analogWrite(c_fan, 100);
    // Serial.println("c_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Cooling Fan mid");
    delay(1000);
  }

  else if (data.indexOf("cfhi") >= 0 && mod == 0) {
    analogWrite(c_fan, 255);
    // Serial.println("c_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Cooling Fan high");
    delay(1000);
  }

  //*******************************************************************


  if (data.indexOf("efoff") >= 0) {
    digitalWrite(e_fan, LOW);
    //Serial.println("e_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Exhaust Fan off");
    delay(1000);
  }

  else if (data.indexOf("eflow") >= 0) {
    analogWrite(e_fan, 50);
    //Serial.println("e_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Exhaust Fan low");
    delay(1000);
  }

  else if (data.indexOf("efmid") >= 0) {
    analogWrite(e_fan, 100);
    //Serial.println("e_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Exhaust Fan mid");
    delay(1000);
  }
  else if (data.indexOf("efhi") >= 0) {
    analogWrite(e_fan, 255);
    //Serial.println("e_on");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Exhaust Fan high");
    delay(1000);
  }

  //*************************************************************

  if (data.indexOf("lioff") >= 0 && mod == 0) {
    digitalWrite(light, LOW);
    //  Serial.println("e_off");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Light off");
    delay(1000);
  }

  else if (data.indexOf("lilow") >= 0 && mod == 0) {
    analogWrite(light, 50);
    //  Serial.println("e_off");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Light low");
    delay(1000);
  }
  else if (data.indexOf("limid") >= 0 && mod == 0) {
    analogWrite(light, 100);
    //  Serial.println("e_off");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Light mid");
    delay(1000);
  }

  else if (data.indexOf("lihi") >= 0 && mod == 0) {
    analogWrite(light, 255);
    //  Serial.println("e_off");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Light hi");
    delay(1000);
  }



  if (data.indexOf("auto") >= 0) {
    mod = 1;
    
    //  Serial.println("e_off");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Auto Mode");
    lcd.setCursor(0, 1);
    lcd.print("  actived..");
    delay(1000);
  }
  else if (data.indexOf("manu") >= 0) {
    mod = 0;
    //  Serial.println("e_off");
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("Manual Mode");
    lcd.setCursor(0, 1);
    lcd.print("  actived..");
    delay(1000);
  }

}

//******************************************************************************************
void sms() {

  lcd.clear();
  lcd.print("Sensding sms...");
  String msg_body = roll;
  msg_body += "\nTemp = ";
  msg_body += String(te);
  msg_body += "C \nHumidity = ";
  msg_body += String(hu);
  msg_body += "% \nLux Level =";
  msg_body += String(lux);
  msg_body += "% ";


  Serial.println("AT");
  delay(500);
  Serial.println("AT+CMGF=1");
  delay(500);
 // Serial.println("AT+CMGS=\"+94717424602\"");
   Serial.println("AT+CMGS=\"+94715701413\"");
  delay(500);
  Serial.println(msg_body);
  delay(500);
  
  delay(500);
  lcd.clear();
  lcd.print("Sent..");
  delay(1000);
}

//**************************************************************************************
void tym() {
  if (millis() - mil > 500) {
    flag = 1;
    mil = millis();
    li_count++;
    if (li_count > 100) {
      li_count = 100;
    }
    c_count++;
    if (c_count > 100) {
      c_count = 100;
    }
    e_count++;
    if (e_count > 100) {
      e_count = 100;
    }
  }
}

//******************************************************************************************
void dht() {
  int chk = DHT_A.read21(DHT21_A_PIN);
  te = DHT_A.temperature, 1;
  hu = DHT_A.humidity, 1;
}

