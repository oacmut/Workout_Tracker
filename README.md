# Pontvadász ZH 

## Borbély Balázs - OACMUT

## Cherry Picking árlap

### Windows Forms Application
##### User Interface 

- `1x2p` Az alkalmazásból a **kilépés csak megerősítő kérdés után** lehetséges. 
- `2x1p` **Többablakos alkalmazás** legalább két felugró ablakkal. Minden Form-nak saját osztályon kell alapulnia, és funcionalitással kell rendelkeznie. Az ablakok nyílhatnak gombokkal vagy felső menüből is.
- `1x2p` **Anchorok alkalmazása**: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.	

6 pont

##### Tábla adatainak megjelenítése `DataGridView`-ban 

- `1x2p` Adatok  megjelenítése 
- `1x2p` Ha a tábla adatforrása saját osztály.

4 pont

##### Adatkötés `BindingSource` -on keresztül

- `1x2p` Működő  `BindingSource` 

2 pont

##### Új rekord rögzítése 

- `1x1p` Ha legalább egy nem kulcs mező, pl. _Mennyiség_ is fel van véve
- `1x2p` Ellenőrzéshez kötött adatfelvitel (egyszerű validáció pl: `String.IsNullOrEmpty()`)
- `1x2p` Felugró ablakon keresztül történik _Ok_ és _Mégse_ gombbal
- `1x2p` Ha az űrlap legördülő dobozon vagy listán keresztül beállítható idegen kulcsot is tartalmaz
- `2x1p` A kitöltési hiba `ErrorProvider`-en keresztül kerülnek közlésre a felhasználóval, hibás kitöltés esetén nem enged rányomni az _Ok_ gombra
- `1x2p` `Regex` alapú validáció
- `1x1p` Hibás kitöltés esetén nem lehet megynomni az _Ok_ gombot. 

12 pont

#####  Rekord törlése 

- `1x2p` Sikeres törlés
- `1x2p` Megerősítéshez kötött törlés

4 pont

### ASP .NET 
ASP .NET alkalmazás, melyet lehet a Forms alapú projekttel közös solution-ben létrehozni.

- `1x2p`  `program.cs` beállítása `wwwroot` mappában tárolt statikus tartalmak megosztására

2 pont

##### API végpontok

- `1x3p` Teljes SQL tábla adatainak szolgáltatása API végponton keresztül 
- `2x2p` SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül
- `1x3p` SQL tábla egy választható rekordjának törlése
- `1x5p` Új rekord felvétele `HttpPost` metóduson keresztül SQL táblába

13 pont

### Hozott anyagok

Megtalálható a wwwroot mappában, hozott.js néven.

##### Saját Adatbázis

SQL script formájában, de legjobb Azure SQL szerveren hosztolni

- `3x1p` Az alkalmazásban használt táblánként pont
- `1x1p` Az adatbázis tartalmaz Constraint-eket (min 2)
- `1x1p` Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan
- `1x2p` Az adatbázis saját Azure SQL szerveren van

7 pont

##### Weboldal

Itt csak azok az elemek számíthatóak be, amelyeknek meg van a ZH alatt felépített API végpontja. 

- `1x1p` A weboldalnak van egy értelmezhető struktúrája
- `1x1p` A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
- `1x1p` A weboldal javascriptet használ API végpont által szolgáltatott adatok betöltésére, hozott anyagként
- `1x1p` A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése

4 pont

### Egyéb, extra

- `2x1p`  `Scaffold-DbContext` használata (ajándék)

2 pont

##Összesen: 56 pont
