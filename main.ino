int buzzer = 12;
int val = 0;

String data;
void setup() {

  //setup the buzzer
  pinMode(buzzer, OUTPUT);
  Serial.begin(9600);
  Serial.setTimeout(50);
}
void loop() {
}
void toggle() {
  //read if buzzer is on and switches it
  val = digitalRead(buzzer);
  if (val == HIGH) {
    digitalWrite(buzzer, LOW);
    }
  else {
    digitalWrite(buzzer, HIGH);
  }
}
void serialEvent() {
  data = Serial.readString();
  if (data == "toggle") {
    toggle();
  }
  if (data == "beep") {
    beep();
  }
  //checks if string starts with ' ' then for every letter it beeps a dot or a dash
  if (data[0] == ' ') {
    for (char l : data){
      if (l == '.') {
        dot();
        delay(50);
      }
      else if (l == '-'){
        dash();
        delay(50);
      }
    }
    
  }
}
void beep() {
  toggle();
  delay(400);
  toggle();
}
void dot() {
  toggle();
  delay(100);
  toggle();
}
void dash(){
  toggle();
  delay(300);
  toggle();
}
