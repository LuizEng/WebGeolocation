#include <SPI.h>
#include <ArduinoJson.h>
#include <TinyGPS++.h>

//time definitions
#Define UPDATE_RATE 2000 //2 seconds
unsigned long lastUpdate = 0;

//TinyGPS definitions
TinyGPSPlus tinyGPS;
#define GPS_BAUD 9600

//Serial definitions
#define ARDUINO_GPS_RX 3
#define ARDUINO_GPS_TX 2
SoftwareSerial ssGPS(ARDUINO_GPS_TX,ARDUINO_GPS_RX);

#define gpsPort ssGPS

#define SerialMonitor Serial

//http Definitions

EthernetClient client;
const unsigned long HTTP_TIMEOUT 10000;
const char* server = "https://webgeolocation.azurewebsites.net/"; 

void setup() 
{
  SerialMonitor.Begin(9600);
  gpsPort.begin(GPS_BAUD);

}

void loop() 
{
  if ((lastUpdate + UPDATE_RATE) <= millis())
  {
    if (tinyGPS.location.isUpdated())
    {
      
    }
  }

}

bool SendRequest()
{
  JsonObject& root = jsonBuffer.createObject();
  root["name"] = "hash";

  JsonArray& dataJson = root.createNestedArray("data");
  dataJson.set("latitude", tinyGPS.location.lat());
  dataJson.set("longitude",tinyGPS.location.lng());
  dataJson.set("altitude", tinyGPS.altitude.feet());
  dataJson.set("speed", tinyGPS.speed.mph());
  dataJson.set("course", tinyGPS.course.deg());
  dataJson.set("date", tinyGPS.date.value());
  dataJson.set("time", tinyGPS.time.value());
  dataJson.set("satellites", tinyGPS.satellites.value());

  if (root.success())
  {
       
  }
  return false;
}

bool Connect(const char* hostName)
{
    Serial.print("Connect to ");
    Serial.println(hostName);  

    return client.connect(hostName,80)
}
