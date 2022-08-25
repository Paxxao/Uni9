/* TInkerCAD

**Creation of traffic light, alerts and simulate motor while.
  the light green is High**

 Program: IoT_at24082022
  Gabriel Paixão
 date: 08/24/2022
 version: 1.0
*/
#define LED_BUILTIN 13
#define led_red 0
#define led_yellow 1
#define led_green 2
#define alert 3
#define motor 4

int blink_time = 500;

void setup()
{

  pinMode(led_red, OUTPUT);
  pinMode(led_yellow, OUTPUT);
  pinMode(led_green, OUTPUT);
  pinMode(LED_BUILTIN, OUTPUT);
  pinMode(alert, OUTPUT);
  pinMode(motor, OUTPUT);
}

void loop()
{
  digitalWrite(LED_BUILTIN, HIGH);
  delay(blink_time);
  digitalWrite(LED_BUILTIN, LOW);
  delay(blink_time);

  digitalWrite(led_red, LOW);
  digitalWrite(led_yellow, LOW);
  digitalWrite(led_green, HIGH);
  digitalWrite(alert, LOW);
  digitalWrite(motor, HIGH);
  delay(3000);

  digitalWrite(led_red, LOW);
  digitalWrite(led_yellow, HIGH);
  digitalWrite(led_green, LOW);
  digitalWrite(alert, LOW);
  digitalWrite(motor, LOW);
  delay(1000);

  digitalWrite(led_red, HIGH);
  digitalWrite(led_yellow, LOW);
  digitalWrite(led_green, LOW);
  digitalWrite(alert, HIGH);
  digitalWrite(motor, LOW);
  delay(5000);
}