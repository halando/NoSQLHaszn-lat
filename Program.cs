// See https://aka.ms/new-console-template for more information
using NoSQL;
Database db = new Database("https://index.hu");
/*Response valasz = db.Get();
Console.WriteLine(valasz.Message);*/
string adatbazis = @"
    {

        koktelok:
            {       
                osszetevok:
                    [
                        {id:1,megnevezes: 'Rum'},
                        {id:2,megnevezes: 'Vodka'},
                        {id:3,megnevezes: 'Narancsle'}
                        {id:4,megnevezes: 'Coca-Cola'}
                     ],
                  keverekek:
                    [
                         { id:1,
                           megnevezes: 'Elso',
                           recept:[
                                {osszetevo:2, mennyiseg:50}
                                 {osszetevo:3, mennyiseg:150}
                                    ]
                                                           
                           }{ id:2,
                           megnevezes: 'Rumos-cola',
                           recept:[
                                {osszetevo:1, mennyiseg:50}
                                 {osszetevo:4, mennyiseg:150}
                                    ]
                                                           
                           }
                     ]
            }";
Response valasz =db.Post(adatbazis);
Console.WriteLine(valasz.Message);