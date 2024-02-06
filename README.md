# CSharpLuokkaharjoituksia
Esimerkkejä ja harjoituksia C# luokista ja olioista

## Luokkien periytyminen
Luokka voi periä toiselta luokalta kenttä ja metodeja. Luokkaa, jonka ominaisuuksia peritään (inheritance) kutsutaan yliluokaksi (super class, parent class) ja perivää luokkaa aliluokaksi (subclass, child class). Perimisen keskinen idea on se, että yliluokassa määriteltyjä ominaisuuksia (kenttiä) ja metodeja ei tarvitse enää määritellä aliluokassa, riittää että kerrotaan niiden periytyvän yliluokasta. Yliluokalla ja aliluokalla voi olla saman nimisiä metodeja, jotka toimivat eri tavalla. Tätä kutsutaan metodien ylikirjoittamiseksi (method overload). Jos aliluokassa metodi on kirjoitettu eri tavalla kuin yliluokassa, yliluokan määritys syrjäytyy. 
