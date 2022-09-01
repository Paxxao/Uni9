/* TInkerCAD

**Creation of traffic light, alerts and simulate motor while.
  the light green is High**

 Program: IoT_at.2trafficligth
  Gabriel Paixão
 date: 08/31/2022
 version: 1.0
 

*/

// Definindo nomes para os pinos
#define LED_BUILTIN 13
#define led_green1	2
#define led_green2 	5
#define led_yellow1 3
#define led_yellow2 6
#define led_red1 	4
#define led_red2 	7
#define alert1 		8	
#define alert2 		10	
#define motor1 		9
#define motor2 		11


int blink_time =  500;      // criando variavel para o tempo de piscada do LED_BUILTIN
int go1_time	= 5000;     // criando variavel para o tempo de farol verde    Semáforo1
int go2_time	= 3000;     // criando variavel para o tempo de farol verde    Semáforo2
int holdon_time = 2000;     // criando variavel para o tempo de farol amarelo  Semaforo1 e 2
int stop1 		= 6000;     // criando variavel para o tempo de farol vermelho Semáforo1
int stop2 		= 4000;     // criando variavel para o tempo de farol vermelho Semáforo1

void setup()
{
  pinMode(LED_BUILTIN, OUTPUT);	// Definindo pino (LED_BUILTIN) como Saida
  pinMode(led_green1, OUTPUT); 	// Definindo pino (led_gree1n) como Saida
  pinMode(led_yellow1, OUTPUT);	// Definindo pino (led_yellow1) como Saida 	
  pinMode(led_red1, OUTPUT);	// Definindo pino (led_red1) como Saida 	
  pinMode(alert1, OUTPUT);		// Definindo pino (alert1) como Saida
  pinMode(motor1, OUTPUT);		// Definindo pino (motor1) como Saida
  
  pinMode(led_green2, OUTPUT); 	// Definindo pino (led_green2) como Saida
  pinMode(led_yellow2, OUTPUT);	// Definindo pino (led_yellow2) como Saida 	
  pinMode(led_red2, OUTPUT);	// Definindo pino (led_red2) como Saida 	
  pinMode(alert2, OUTPUT);		// Definindo pino (alert2) como Saida
  pinMode(motor2, OUTPUT);		// Definindo pino (motor2) como Saida

}

void loop()
{
  digitalWrite(LED_BUILTIN, HIGH);
  delay(blink_time);
  digitalWrite(LED_BUILTIN, LOW);
  delay(blink_time);
  
/*-------------- Semáforo 1 -------------*/  
    // Verde Ligado e Motor1 aciona 
  digitalWrite(led_green1, HIGH);
  digitalWrite(led_yellow1, LOW);
  digitalWrite(led_red1, LOW);
  digitalWrite(alert1, LOW);
  digitalWrite(alert2, LOW);
  digitalWrite(motor1, HIGH);
  delay(go1_time);
  
    // Amarelo Ligado
  digitalWrite(led_green1, LOW);
  digitalWrite(led_yellow1, HIGH);
  digitalWrite(led_red1, LOW);
  digitalWrite(alert1, LOW);
  digitalWrite(motor1, LOW);
  delay(holdon_time);

    // Vermelho Ligado e Alarme1 aciona
  digitalWrite(led_green1, LOW); 
  digitalWrite(led_yellow1, LOW);
  digitalWrite(led_red1, HIGH);
  digitalWrite(alert1, HIGH);
  digitalWrite(motor1, LOW);
  delay(stop2);
  
/*-------------- Semáforo 2 -------------*/  
    // Verde Ligado e Motor2 aciona 
  digitalWrite(led_green2, HIGH);
  digitalWrite(led_yellow2, LOW);
  digitalWrite(led_red2, LOW);
  digitalWrite(alert1, LOW);
  digitalWrite(alert2, LOW);
  digitalWrite(motor2, HIGH);
  delay(go2_time);
  
    // Amarelo Ligado
  digitalWrite(led_green2, LOW);
  digitalWrite(led_yellow2, HIGH);
  digitalWrite(led_red2, LOW);
  digitalWrite(alert2, LOW);
  digitalWrite(motor2, LOW);
  delay(holdon_time);

    // Vermelho Ligado e Alarme2 aciona
  digitalWrite(led_green2, LOW); 
  digitalWrite(led_yellow2, LOW);
  digitalWrite(led_red2, HIGH);
  digitalWrite(alert2, HIGH);
  digitalWrite(motor2, LOW);
  delay(stop2);
}