# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:** DrömMatchen
**Grupp:**  Oliver Ågren
**Datum:**  2026-09-17
**GitHub:**  Oliver-agg

---

## Gruppmedlemmar

| Oliver Ågren | 2026-09-17 |
|------|-----------|
| [Oliver] | Zip + RAPPORT.md + REFLEKTION.md |
| [Oliver] | REFLEKTION.md |
| [Namn 3] | REFLEKTION.md |

---

## G — Hur vi löste uppgiften
- Uppgiften i sig var ganska lätt då hjälpen från dina kommentarer i Visual studio till och börja med. Jag Främst använde måndagspresentationen som verktyg och Gemini(Läraren i classroom). 

- "Class Match" fick jag reda på att man kan förkorta sin property ganska markant med hjälp utav auto property. En get har vanligtvis alltid en (return) och samma gäller set, vanligtvis alltid en value, så att skriva ut allt är ganska onödigt. Så jag använde auto-property.

- Konstruktorn är något som behöver parametrar, så jag satte ihop parametern med propertyn. Alltså ta värdet som skickades via parametern (hemmalag) och spara det i propertyn (Hemmalag).

- Metod Presentera, detta är ju en metod som inte returerar något (void). () säger att den inte tar emot några parametrar. Sedan gjorde jag en kropp för metoden där jag skrev en Console.WriteLine. 

Metod AnnounceraMålskytt är också en metod och jag har behandalt den på samma sätt som jag behandlade Presentera metoden.

- "Class Spelare" Här gjorde jag samma sak som på class match när det kom till property. Jag skrev den på samma kort lätt sätt, alltså auto-property.

- Sedan en konstruktor, sen igen så behöver en konstruktor parametrar, tilldelade tre styck som sattes ihop med propertyn i en kropp. I announceramålskytt skriver jag namn, nummer och position. På grund av att min get är public så kan den göra att andra klasser kan ta del av klassen. Bara läsa dock, inte ändra då min set är private. Bara spelare klassen kan faktiskt ändra det, i konstruktorn. 

- "Program.cs" Här skall jag faktiskt ta använding av mina klasser. Jag börjar med att skapa två spelare som har namn, nummer och position.
Spelare är kopplad till min property, min property är kopplad till min konstruktorn, i konstruktorn har vi string namn, int nummer och string postion. Jag matchar alltså argumenten i ordning för min konstruktor. Det måste vara string, det måste vara int, det måste vara string. Tänkte samma för new match.

Match.Presentera() Metoden har inga parametrar, varför? För att metoden bor i class match. I den klassen ägs properties hemmalag, bortalag och datum. Metoden har alltså tillgång till alla egna properties.

AnnounceraMålskytt(Spelare spelare) Metoden har parametrar, varför? Då jag skapade två olika spelare så behöver metoden veta om vilken spelare jag pratar om. 


### Klasserna

>public class Match och public class Spelare

### Metoderna

> Public void Presentera(), Public void AnnounceraMålskytt, 

### Main()

> Program.cs

### Git

> Hit användes när jag var klar med plugg för stunden. Eller när jag kom på att jag hade satt Ronaldos nummer tkill 9 när det skulle vara 7...

### Kodkvalitet

> Använding auto-properties, meningsfulla namn på varibaler och metoder. Separerade ansvar för klasserna.

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> 

### Varför vi löste det såhär

> 

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
[klistra in här]
```
