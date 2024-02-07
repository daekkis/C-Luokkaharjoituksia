# CSharpLuokkaharjoituksia
Esimerkkejä ja harjoituksia C# luokista ja olioista

## Luokkien periytyminen
Luokka voi periä toiselta luokalta kenttä ja metodeja. Luokkaa, jonka ominaisuuksia peritään (inheritance) kutsutaan yliluokaksi (super class, parent class) ja perivää luokkaa aliluokaksi (subclass, child class). Perimisen keskinen idea on se, että yliluokassa määriteltyjä ominaisuuksia (kenttiä) ja metodeja ei tarvitse enää määritellä aliluokassa, riittää että kerrotaan niiden periytyvän yliluokasta. Yliluokalla ja aliluokalla voi olla saman nimisiä metodeja, jotka toimivat eri tavalla. Tätä kutsutaan metodien ylikirjoittamiseksi (method overload). Jos aliluokassa metodi on kirjoitettu eri tavalla kuin yliluokassa, yliluokan määritys syrjäyttää aliluokan saman nimisen metodin. Aliluokan metodi voi myös syrjäyttää yliluokan metodin, silloin, kun yliluokan metodi on määritetty virtuaaliseksi (virtual) ja aliluokassa metodi on määritelty syrjäyttäväksi (overload). Seuraavassa esimerkissä on kolme luokkaa: yliluokka lemmikinomistajalle sekä kaksi aliluokkaa kissanomistajalle ja koiranomistajalle.

```csharp

```
