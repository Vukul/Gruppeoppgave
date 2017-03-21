# Gruppeoppgave

Kravspesifikasjoner
Eivind, Pål Magnus og Andreas Vu

Programmet:
Programmet vårt skal være et geografisk lære program. Brukeren får vist fram et kart over Europa. Et land skal lyse opp, brukeren skal velge et svar ut ifra tre alternativer. Kun ett av alternativene er riktig. 
Det er knapper som du kan velge etter å ha valgt svaralternativ, “neste” og “sjekk svar”. Trykker man på “neste” får man ikke vite om man har fått riktig, trykker man på “sjekk svar” så får du vite om du har valgt riktig eller galt. Man får 1 poeng for hver riktig man får.
På slutten av testen kommer det opp en popup-melding som sier hvor mange poeng du har fått, men du får ikke vite hvilke svar som var riktig og hvilke som var feil. 


Design:

Man skal kunne velge størrelse på vinduet selv ved å dra i hjørnene, man kan ikke maksimere vinduet, men man kan minimere vinduet.
⅔ av vinduet skal være dekket av kartet, også skal den siste ⅓ på høyresiden inneholde spørsmålet, svaralternativer, “neste”- og “sjekk svar” knapp. Det skal kun være 10 spørsmål.
Man kan trykke på bildet slik at det forstørres over hele vinduet, og trykker man igjen vil den gå tilbake til opprinnelig størrelse.




Rollefordeling
Prosjektleder - Pål Magnux
Sys. dev - Øyvind
Prog. sjef - Vups

System og programmering design
Formen:
I FormLoad skal utføre en funksjon som heter LoadSpm.
LoadSpm: velger tall fra 0-39, av land i Europa, og velger ut fra resultatet et tilfeldig land.

Metoder/funksjoner:

1. Vu
private void LoadSpm(int spm) {}
Skal finne frem bilde og riktig svar til bildet, skal også sette opp dette i applikasjonen.
Bruker en random int, for å finne et tall mellom 0 og 39. Har en string array med path til hvert av bildene også en annen string array som inneholder riktig svar. LoadSpm skal finne frem riktig bilde og svar i forhold til det tilfeldig tallet. 

2. Eivind
private void RanSpm(int spm) {}
Funksjonen bruker det samme arrayet med svar, som brukt i LoadSpm. Den velger to av svarene som skal være med i tillegg til det riktige svaret. Metoden skal først sjekke om disse to ikke er lik det riktige svaret, og dermed legge de til. Hvis et av de tilfeldige valgte  er det samme som det riktige svaret, skal funksjonen startes på nytt.  	

5. Pablo
private void Count() 
Den har en int som går opp med en etter hvert trykk på ‘’neste’’ knappen. Når denne når 10, skal slutt - resultatet komme opp med en messagebox og applikasjonen avsluttes.  

4. Eivind
private void Check() 
Som navnet sier, sjekke om svaret er riktig eller galt. funksjonen skal sjekke om svaret stemmer i forhold til arrayet med de riktige svarene. Dette skal skje ved en if funksjon og med det gi en melding om det er riktig svar, og en else dersom svaret er feil.





3. Vu
private void radiobtns()
Bytter text på radiobuttons, med det riktige svaret pluss de to tilfeldige. Velger et tall fra og med 1 til og med 3. Velges 1, vil det riktige svaret tilhøre og dukke opp på den første RadioButton. Det samme skal skje hvis 2 eller 3 blir valgt, og den flytter så til andre eller tredje RadioButton.

6. Pablo
“Neste” knappen kaller alle metodene og funksjonene som blir brukt. Skal bytte til nytt random nummer mellom 0 og 39.

7. Pablo
‘’Sjekk svar’’ appen kaller funksjonen Check(), og kommer med en messagebox som forteller om svaret er riktig eller galt.  

