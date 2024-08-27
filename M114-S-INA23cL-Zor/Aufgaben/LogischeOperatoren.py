## 1.1 Login
#
#import random
#
## Generiere zufällige True/False-Werte für username und password
#username = bool(random.getrandbits(1))
#password = bool(random.getrandbits(1))
#
## Überprüfe, ob sowohl username als auch password True sind
#login = True if username and password else False
#
## Ausgabe der Werte
#print(username)
#print(password)
#print(login)



## 1.2 Serverraum
#
#import random
#
#sns_temp = bool(random.getrandbits(1))
#sns_smoke = bool(random.getrandbits(1))
#
## Alarm wird ausgelöst, wenn einer der Sensoren False ist
#alert = not (sns_temp and sns_smoke)
#
#print(sns_temp)
#print(sns_smoke)
#print(alert)



## 1.3 Backup
#
#import random
#
#time = bool(random.getrandbits(1))
#volume = bool(random.getrandbits(1))
#enable = bool(random.getrandbits(1))
#
#backup_run = not time and (volume and enable)
#
#print(time)
#print(volume)
#print(enable)
#print(backup_run)


## 1.4 Teilen
#
## Test für alle möglichen 4-Bit-Zahlen
#for A in [0, 1]:
#    for B in [0, 1]:
#        for C in [0, 1]:
#            for D in [0, 1]:
#                # Berechne den Dezimalwert der 4-Bit-Zahl
#                decimal_value = A * 8 + B * 4 + C * 2 + D
#                
#                # Überprüfen, ob die Zahl durch 3 teilbar ist
#                if decimal_value % 3 == 0:
#                    print(f"Binär: {A}{B}{C}{D} -> Durch 3 teilbar: Ja")
#                else:
#                    print(f"Binär: {A}{B}{C}{D} -> Durch 3 teilbar: Nein")