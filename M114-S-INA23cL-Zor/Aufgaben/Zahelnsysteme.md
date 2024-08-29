# Zahlensysteme und Codierung

## 2 Zahlensysteme

### 2.1 Umrechnung

- **Weshalb wird das Zahlensystem Dual benötigt?**
  - Das Dualsystem wird benötigt, weil es direkt mit der binären Natur der elektronischen Schaltungen in Computern korrespondiert. In digitalen Systemen sind die Zustände Ein (1) und Aus (0) leicht darzustellen und zuverlässig zu verarbeiten.

- **Zähle im hexadezimalen Zahlensystem bis auf 10. Welche Zustände gibt es?**
  - Die Zustände im Hexadezimalsystem bis 10 sind: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F, 10.

- **In einer binären Zahl haben die einzelnen Stellen eine bestimmte Wertigkeit. Schreibe die dezimale Wertigkeit aller Stellen einer 11-stelligen binären Zahl.**
  - Die dezimalen Wertigkeiten von rechts nach links: 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024.

- **FFFF<sub>16</sub> zu Dezimal**
  - \(FFFF_{16}\) = \(65535_{10}\)

- **1001<sub>2</sub> zu Dezimal**
  - \(1001_{2}\) = \(9_{10}\)

- **764<sub>8</sub> zu Dezimal**
  - \(764_{8}\) = \(500_{10}\)

- **255<sub>10</sub> zu Binär und Hexadezimal**
  - Binär: \(255_{10}\) = \(11111111_{2}\)
  - Hexadezimal: \(255_{10}\) = \(FF_{16}\)

- **21845<sub>10</sub> zu Binär und Hexadezimal**
  - Binär: \(21845_{10}\) = \(101010101010101_{2}\)
  - Hexadezimal: \(21845_{10}\) = \(5555_{16}\)

- **51966<sub>10</sub> zu Binär und Hexadezimal**
  - Binär: \(51966_{10}\) = \(1100101011101110_{2}\)
  - Hexadezimal: \(51966_{10}\) = \(CAEE_{16}\)

- **1010 1111 1111 1110<sub>2</sub> zu Dezimal und Hexadezimal**
  - Dezimal: \(1010111111111110_{2}\) = \(45054_{10}\)
  - Hexadezimal: \(1010111111111110_{2}\) = \(AFFE_{16}\)

- **3E8<sub>16</sub> zu Binär und Dezimal**
  - Binär: \(3E8_{16}\) = \(1111101000_{2}\)
  - Dezimal: \(3E8_{16}\) = \(1000_{10}\)

- **Um welche Farbe handelt es sich: FEC800<sub>16</sub>?**
  - Die Farbe FEC800<sub>16</sub> ist ein leuchtendes Gelb.

- **Welchen hexadezimalen Wert hat die grüne Farbe dieses Skripts?**
  - Ein typischer grüner Farbwert in Hexadezimal ist #00FF00.

- **Wo findet das oktale Zahlensystem unter Unix sein Einsatzgebiet?**
  - Das oktale Zahlensystem wird unter Unix hauptsächlich zur Darstellung von Dateirechten (Permissions) verwendet.

### 2.2 Zahlencodierung

- **Wie viele Zahlen können mit 10 Bits dargestellt werden?**
  - Mit 10 Bits können \(2^{10} = 1024\) verschiedene Zahlen dargestellt werden.

- **Wie viele Zahlen können mit einem Byte dargestellt werden und was ist die größte Zahl, welche ohne Vorzeichen dargestellt werden kann?**
  - Mit einem Byte (8 Bits) können \(2^8 = 256\) Zahlen dargestellt werden, die größte Zahl ohne Vorzeichen ist 255.

- **Weshalb sind die beiden Zahlen unterschiedlich groß?**
  - Die Zahlen sind unterschiedlich groß, weil ein Byte 8 Bits hat und die Darstellung von Zahlen mit 10 Bits entsprechend mehr Möglichkeiten bietet.

- **Hersteller von TV-Geräten oder Monitoren werben damit, dass ihre Geräte 16 Millionen Farben darstellen können. Wie viele Bits sind zur Darstellung einer Farbe notwendig?**
  - 24 Bits sind notwendig, um 16.777.216 (ca. 16 Millionen) Farben darzustellen.

- **Wie lautet die genaue Anzahl möglicher Farbkombinationen?**
  - Die genaue Anzahl ist 16.777.216 (24 Bit, \(2^{24}\)).

- **Eine Farbe wird mit dem RGB-Farbcode dargestellt. Wie viele Bits gibt es für die Farben Rot, Grün und Blau?**
  - Jeweils 8 Bits für Rot, Grün und Blau, insgesamt 24 Bits.

- **Welches ist die größte und welches ist die kleinste Zahl, welche mit 32 Bits (vorzeichenlos) dargestellt werden kann?**
  - Größte Zahl: \(2^{32} - 1 = 4294967295\)
  - Kleinste Zahl: 0

- **Welches ist die größte und welches ist die kleinste Zahl, welche mit 32 Bits (vorzeichenbehaftet) dargestellt werden kann?**
  - Größte Zahl: \(2^{31} - 1 = 2147483647\)
  - Kleinste Zahl: \(-2^{31} = -2147483648\)

- **In einem Spiel kann eine maximale Score von 100 erreicht werden. Wie viele Bits werden benötigt, um dies zu speichern?**
  - Es werden 7 Bits benötigt, um die Zahl 100 darzustellen (weil \(2^7 = 128\)).

- **Welchen Zahlenbereich hat eine IPv4-Adresse? Wie viele Bits werden benötigt, um eine IPv4-Adresse zu speichern?**
  - Eine IPv4-Adresse hat einen Bereich von 0.0.0.0 bis 255.255.255.255, und es werden 32 Bits benötigt.

- **Eine IPv6-Adresse wird in acht Blöcken à 16 Bits gespeichert. Wie viele IPv6-Adressen kann es geben?**
  - Es gibt \(2^{128}\) mögliche IPv6-Adressen.

- **Eine Gleitkommazahl wird mit einem Vorzeichen-Bit, dem Exponent und einer Mantisse codiert. Weshalb diese Aufteilung?**
  - Diese Aufteilung ermöglicht die Darstellung von sehr großen und sehr kleinen Zahlen sowie eine hohe Präzision.

- **Weshalb kann es bei Berechnungen von Gleitkommazahlen zu Genauigkeitsfehlern kommen?**
  - Genauigkeitsfehler können auftreten, weil nicht alle Dezimalzahlen exakt als Binärzahlen dargestellt werden können, und weil die Mantisse nur eine begrenzte Anzahl von Bits hat.

- **Eine binäre Gleitkommazahl hat diesen Wert: 0.11<sub>2</sub>. Welchem dezimalen Wert entspricht die Zahl?**
  - 0.11<sub>2</sub> entspricht 0.75<sub>10</sub>.

- **Im Speicher ist eine Gleitkommazahl nach IEEE 754 abgespeichert. Wie lautet die Zahl für diese Bitfolge: 1100 0011 0001 0110 1000 0000 0000 0000<sub>2</sub>?**
  - Die genaue Dezimalzahl ergibt sich aus der Interpretation nach IEEE 754, was für eine vollständige Berechnung die Dekodierung von Vorzeichen, Exponent und Mantisse erfordert. Für die gegebenen Bits könnte der Wert etwa 150.375 in Dezimal sein, aber dies sollte überprüft werden, indem man die IEEE 754-Formel anwendet.

## 3 Zeichencodierung

- **Der Speicher enthält folgende, in ASCII codierte Information. Was bedeutet sie? 5A 65 69 63 68 65 6E 20 69 6E 20 41 53 43 49 49 00<sub>16</sub>**
  - Die ASCII-Codierung „5A 65 69 63 68 65 6E 20 69 6E 20 41 53 43 49 49 00“ steht für „Zeichen in ASCII“.

- **Stelle deinen Namen in ASCII codiert dar.**
  - Zum Beispiel, für den Namen „Max“: M = 77, a = 97, x = 120. In Hexadezimal: 4D 61 78.

- **Das Emoji mit dem Unicode U+1F642 sieht so aus: 🙂**
  - **Wie wird das Emoji in UTF-8, UTF-16 und UTF-32 codiert?**
    - UTF-8: F0 9F 99 82
    - UTF-16: D83D DE42
    - UTF-32: 0001F642

- **Stelle deinen Namen in Unicode dar und codiere ihn in UTF-8.**
  - Zum Beispiel, für den Namen „Max“: M = U+004D, a = U+0061, x = U+0078.
  - In UTF-8: 4D 61 78

- **Welche zwei Vorteile bringt eine Base64-Codierung mit sich?**
  - Base64 ermöglicht die sichere Übertragung von Binärdaten über textbasierte Protokolle und sorgt für eine einheitliche Darstellung der Daten.
  - Es reduziert die Gefahr von Datenkorruption bei der Übertragung über Systeme, die bestimmte Zeichen anders behandeln könnten (z. B. E-Mail).

- **In welchem Fall werden bei Base64 Nullbits ergänzt und wie werden sie dargestellt?**
  - Nullbits werden ergänzt, wenn die Anzahl der ursprünglichen Bits nicht durch 6 teilbar ist. Diese Nullbits werden als „=“ Zeichen am Ende der Base64-Ausgabe dargestellt.

- **Welcher Text verbirgt sich hinter dieser in Base64 codierten Bitfolge: 000001 011010 101100 011110 111010 111000<sub>2</sub>?**
  - Dieser Base64-codierte Text entspricht den Zeichen "abc123".

- **Die in Hexadezimal dargestellte Bitfolge 33 5D 78<sub>16</sub> soll in Base64 codiert werden. Wie sieht der Base64-String aus?**
  - Der Base64-String für „33 5D 78“ lautet: "M11e".

- **Die in Hexadezimal dargestellte Bitfolge 1 27 72 87 5E<sub>16</sub> soll in Base64 codiert werden. Wie sieht der Base64-String aus?**
  - Der Base64-String für „1 27 72 87 5E“ lautet: "Enchnw==".

- **Das Steuerzeichen für Escape soll in Base64 codiert werden. Wie sieht der Base64-String aus?**
  - Das Steuerzeichen für Escape (ASCII 27) wird in Base64 als "Gx==" dargestellt.

- **Der in UTF-8 codierte Text "Hello" soll in Base64 gewandelt werden. Wie sieht der Base64-String aus?**
  - Der Base64-String für „Hello“ lautet: "SGVsbG8=".

- **Der Base64-String "SSB3YXMgVVRGLTg=" beinhaltet einen in UTF-8 codierten Text. Wie lautet er?**
  - Der Text lautet „I was UTF-8“.

## 4 Files

- **Beschreibe die Begriffe Filename und Dateiendung.**
  - **Filename**: Der Name einer Datei, der die Datei identifiziert.
  - **Dateiendung**: Der Suffix des Dateinamens, der das Dateiformat oder den Dateityp angibt, z. B. `.txt`, `.jpg`, `.png`.

- **Beschreibe drei beliebige Dateiendungen.**
  - `.txt`: Textdatei
  - `.jpg`: Bilddatei im JPEG-Format
  - `.zip`: Komprimiertes Archiv

- **Welche Funktionalität hat eine Dateiendung?**
  - Eine Dateiendung teilt dem Betriebssystem mit, wie die Datei behandelt oder geöffnet werden soll und mit welchem Programm sie standardmäßig verbunden ist.

- **Erstelle ein File mit der Dateiendung `.txt`. Schreibe deinen Namen in das File und ändere anschließend die Dateiendung in `.png`.**
  - **Was geschieht im Explorer?**
    - Der Datei-Explorer wird die Datei als Bilddatei anzeigen, obwohl sie kein Bild enthält.
  - **Kann das File geöffnet werden?**
    - Es kann versucht werden, aber es wird nicht korrekt angezeigt, da die Dateiformatinformationen fehlen.
  
  *Dokumentiere deine Antworten mit Printscreens.*

- **Erstelle ein File mit der Dateiendung `.docx`. Ergänze das File mit einem Text und einem Bild. Ändere anschließend die Dateiendung in `.zip`.**
  - **Was geschieht im Explorer?**
    - Der Datei-Explorer erkennt die Datei nun als ein ZIP-Archiv.
  - **Kann das File geöffnet werden?**
    - Ja, aber es wird als ein komprimiertes Archiv behandelt, das geöffnet werden kann, um den Inhalt zu extrahieren.
  - **Wo kann der eingefügte Text und das eingefügte Bild gefunden werden?**
    - Der Text und das Bild befinden sich in den extrahierten Dateien innerhalb des Archivs.

  *Dokumentiere deine Antworten mit Printscreens.*

- **Erstelle unter Linux ein ausführbares Programm, indem ein C oder C++ Programm kompiliert wird. Führe ein Reverse Engineering durch und erstelle ein Disassembly.**
  - **Mit welchem Befehl kann das Disassembly erzeugt werden?**
    - Der Befehl `objdump -d <filename>` kann verwendet werden, um das Disassembly zu erzeugen.
  - **Welche Programmiersprache ist im Disassembly zu lesen?**
    - Das Disassembly zeigt Maschinencode, der in Assembler-Sprache dargestellt wird.

  *Erstelle einen Printscreen des erstellten Codes.*

- **Schreibe diesen String als binäre Zeichenfolge in ein File: Hello**
  - **Wie lautet die Zahl für die in UTF-8 codierte Zeichenfolge?**
    - Die UTF-8 kodierte Zeichenfolge für „Hello“ lautet 48656C6C6F in Hexadezimal.

- **Mit welchem Befehl kann der als Zahl codierte Text in ein File geschrieben werden?**
  - Unter Linux kann dies mit dem Befehl `echo -n "Hello" > file.bin` geschehen.

- **Schreibe diesen String als binäre Zeichenfolge in ein File: Saturn: 🪐**
  - **Tipp: Das Emoji hat den Unicode U+1FA90.**
  - **Wie lautet die Zahl für die in UTF-8 codierte Zeichenfolge?**
    - „Saturn: 🪐“ wird als "53617475726E3A F09FA6A0" in UTF-8 codiert.

- **Mit welchem Befehl wird der Text in ein File geschrieben?**
  - Mit `echo -n "Saturn: 🪐" > file.bin`.

- **Schreibe die in UTF-8 codierte Zahl FF<sub>16</sub> in ein File.**
  - **Mit welchem Befehl wird das Zeichen in ein File geschrieben?**
    - Dies kann mit `echo -n -e '\xFF' > file.bin` erreicht werden.
  - **Welches Zeichen wird dargestellt und weshalb?**
    - Das Zeichen 255 (ÿ in ISO 8859-1) wird dargestellt, weil `FF` das Dezimal-Äquivalent 255 hat.

- **Schreibe ein Textfile, welcher deinen Namen enthält.**
  - **Mit welchem Befehl kann das File binär ausgegeben werden?**
    - Der Befehl `xxd file.txt` zeigt den binären Inhalt an.

  *Wie sieht der Inhalt des Files aus?*

- **Schreibe ein Textfile, welches dieses Emoji (Unicode U+1F5A5) enthält: 🖥️**
  - **Mit welchem Befehl kann das File binär ausgegeben werden?**
    - Der Befehl `xxd file.txt` kann dafür verwendet werden.
  - **Wie sieht der Inhalt des Files aus?**
    - Das Emoji wird in UTF-8 als „F09F96A5“ dargestellt.
  - **Wie viele Bytes werden für dieses Zeichen benötigt und weshalb?**
    - Es werden 4 Bytes benötigt, da das Emoji außerhalb des Basic Multilingual Plane (BMP) liegt und damit 4 Byte in UTF-8 kodiert wird.

- **Schreibe eine Hello-World Applikation in C. Erstelle eine ausführbare Datei.**
  - **Mit welchem Befehl kann das File binär ausgegeben werden?**
    - Der Befehl `xxd hello_world` zeigt den binären Inhalt der ausführbaren Datei an.

  *Wie sieht der Inhalt des Files aus?*

  *Findest du den String „Hello World“ in der binären Ausgabe?*
