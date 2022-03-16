# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# PC for you

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Antonio Mohorić | amohoric@foi.hr | 0016142069 | mohoricantonio
Marko Mušica | mmusica@foi.hr | 0016142667 | mmusica
Fran Rubinić | frubinic@foi.hr | 0246091478 | frubinic

## Opis domene
Naša aplikacija će podržavati rad trgovine "PC for you" koja se bavi prodajom komponenata za računala, a nudi i uslugu slaganja računala po zahtjevu korisnika. Aplikacija će sadržavati specifikacije komponenata i provjeru kompatibilnosti istih. Nakon uspješnog slaganja računala korisniku bi se ispisala ukupna cijena, cijena po komponentama i cijena slaganja računala, a nakon toga korisnik može naručiti komponente ili računalo.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija | Korisnik se može registrirati i spremiti osobne podatke za narudžbu | 
F02 | Prijava | Osoba se može prijaviti kao admin ili korisnik | 
F03 | Upravljanje komponentama | Admin ima mogućnost dodavanja, brisanja i uređivanja komponenata | 
F04 | Kreiranje narudžbe | Korisnik odabire komponente koje želi u svojem novom računalu |
F05 | Provjera kompatibilnosti | Aplikacija javlja korisniku jesu li komponente međusobno kompatibilne|
F06 | Pregled narudžbi | Korisnik ima mogućnost pregleda izvršenih narudžbi |
F07 | Izračun cijene i kreiranje računa | Aplikacija računa ukupnu cijenu i kreira račun za narudžbu |
F08 | Otkazivanje narudžbe | Korisnik može otkazati narudžbu ukoliko narudžba još nije poslana |
F09 | Statistika prodanih komponenti | Admin može vidjeti statistiku koja prikazuje prodaju komponenti i pregled komponenti koje se često prodaju zajedno|

## Tehnologije i oprema
.NET (Visual Studio), MySQL Workbench, Draw.io, MS Word, MS Excel, Visual Paradigm, GitHub
