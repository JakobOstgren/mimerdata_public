# 📅 Automatisk datumtabell för Power BI

Innehåller två filer som tillsammans automatiserar skapandet av en komplett datumtabell i Power BI, inklusive svenska datumformat, korrekta sorteringskolumner och räkenskapsår som börjar i valfri månad

## AutomaticDateTable DAX
DAX‑skriptet genererar en datumtabell baserad på min- och maxdatum. Tabellen innehåller:

- År, kvartal, månad, veckodag (namn & nummer)  
- År–månad och sorteringskolumner  
- Räkenskapsår (juli–juni) med tillhörande start/slut-år, kvartal och månader  
- Automatiskt anpassade svenska formatsträngar

## AutomaticDateTable TMDL
TMDL-filen skapar eller ersätter tabellen **Datum** i modellen och:

- Mappar varje kolumn mot motsvarande fält i DAX-tabellen  
- Anger datatyper, formatering och sorteringskolumner  
- Organiserar kolumner i mappar som *Sorteringskolumner* och *Räkenskapsår*  
- Skapar tabellen som en beräknad partition

## Användning
1. Lägg till DAX‑koden som en ny beräknad tabell i Power BI Desktop. Ändra parametrarna till önskade värden. **Dölj tabellen — den fungerar som en generisk grundtabell och ska inte användas direkt i rapporten.**
2. Kör TMDL‑skriptet för att skapa upp en ny datumtabell baserad på grundtabellen. Ändra tabellnamnet och eventuella kolumnnamn efter behov.
3. Resultatet blir en eller flera användarvänliga datumtabeller som alla pekar tillbaka på den dolda bas‑tabellen.
``