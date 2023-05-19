DATENBANK EINRICHTEN
1. Aktuelles Image für MySQL laden
docker pull mysql // (lädt das aktuelle Image für MySQL

2. Neuen Container mit Namen dba2ilv und root passwort dba2ilv anlegen
docker run name dba2ilv p 3306:3306 e MYSQL_ROOT_PASSWORD=dba2ilv d mysql:latest

3. Aktuelles Image für phpmyadmin laden
docker pull phpmyadmin

4. Verbindung mit MySQL Container erstellen, Webinterface läuft dann auf 127.0.0.1:8080
docker run --name myadmin -d --link dba2ilv:db -p 8080:80 phpmyadmin

5. Im Webinterface mit "root" und "dba2ilv" anmelden

6. Datenbank erstellen (Name: home_library)

7. Benutzer anlegen (Name: User1  Passwort: dba2ilv)

8. Im Entity Developer Verbindung zur Datenbank einstellen

9. Im Entity Developer Datenbank übertragen


DATENBANK BEDIENEN
Zuerst müssen in den Tabellen für Author, Publisher, Genre Daten eingetragen werden.
Anschließend kann in der Book-Tabelle ein Datensatz angelegt werden.


LÖSCHEN: Zum Löschen eines Eintrags, muss immer die ganze Zeile markiert werden - Anschließend "Submit Changes".

EINFÜGEN: Ein Eintrag kann direkt in die Tabelle gemacht werden - Anschließend "Submit Changes".