using System.Reflection.Metadata;

namespace IF_ELSEIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt tema pikkust
            float pikkus = 0.0f;
            Console.WriteLine("Mis on sinu pikkus meetrites?");
            pikkus = float.Parse(Console.ReadLine());
            //kui ta on lühem kui 0cm, ütle võimatu pikkus
            if (pikkus < 0.0f)
            {
                Console.WriteLine("võimatu pikkus");
            }
            //kui ta on lühem kui 1m, ütle juntsu
            else if (pikkus < 1.0f)
            {
                Console.WriteLine("juntsu");
            }
            //kui ta on lühem kui 2m, ütle tavaline kolge
            else if (pikkus < 2.0f)
            {
                Console.WriteLine("tavaline kolge");
            }
            //kui ta on pikem kui 2m, ütle hiiglane
            else if (pikkus > 2.0f)
            {
                Console.WriteLine("hiiglane");
            }

            //küsi kasutaja vanust
            int vanus = 0;
            Console.WriteLine("Mis on sinu vanus?");
            vanus = int.Parse(Console.ReadLine());
            //küsi kasutajalt praegust aastaarvu
            int aasta = 0;
            Console.WriteLine("Mis aasta on praegu");
            aasta = int.Parse(Console.ReadLine());
            //lahuta aastast kasutaja vanus
            int arvutus = aasta - vanus;
            //kui on sündinud 2025-2020, ütle talle kes sulle arvuti juba andis
            if  (arvutus > 2020 &&  arvutus < 2025)
            {
                Console.WriteLine("kes sulle arvuti juba andis");
            }
            //kui on sündinud 2020-2015, ütle talle skibidi sigmaless
            else if (arvutus > 2015 &&  arvutus < 2020)
            {
                Console.WriteLine("skibidi sigmaless");
            }
            //kui on sündinud 2015-2010, küsi talt kas ta tahab saada programmeerijaks
            else if (arvutus > 2010 && aasta < 2015)
            {
                Console.WriteLine("kas ta tahab saada programmeerijaks");
                string valik = Console.ReadLine();
                if (valik == "jah")
                {
                    Console.WriteLine("tubli");
                }
                else if (valik == "ei")
                {
                    Console.WriteLine("kahju");
                }
            }
            //  kui jah, ütle tubli
            //  kui ei, ütle kahju
            //kui sündinud enne 2010 küsi mitu range comicsit ta oma redditi lugemise ajal leidis
            else if (arvutus < 2010)
            {
                Console.WriteLine("mitu range comicsit sa oma redditi lugemise ajal leidsid");
            }

            //küsi kasutajalt elukoha suunakoodi
            string suunakood = "";
            Console.WriteLine("Mis on sinu elukoha suunakood?");
            suunakood = Console.ReadLine();
            //kui suunakood on väiksem kui 5 tähte, ütle talle 1 täht on puudu
            if (suunakood.Length < 5)
            {
                Console.WriteLine("1 täht on puudu");
            }
            //kui suunakood on suurem kui 5 tähte, ütle talle 1 täht on üle
            if (suunakood.Length > 5)
            {
                Console.WriteLine("1 täht on üle");
            }
            //kui suunakood on 5 tähte, ütle "ahha nüüd tean kus elad"
            if (suunakood.Length == 5)
            {
                Console.WriteLine("ahha nüüd tean kus elad");
            }

            //küsi kasutajalt kas ta töötab
            string töö = "";
            Console.WriteLine("Kas saa töötad?");
            töö = Console.ReadLine();
            //kui kasutaja vastab jah, siis ütle tubli
            if (töö == "jah")
            {
                Console.WriteLine("Tubli!");
            }
            //kui kasutaja vastab ei, siis ütle kahju, miks sa siis töökohta ei otsi?
            else if (töö == "ei")
            {
                Console.WriteLine("Kahju, miks sa siis töökohta ei otsi?");
            }
            //kui kasutaja vastab otsin siis ütle loodan et sa saad varsti tööle C:
            else if  (töö == "otsin")
            {
                Console.WriteLine("loodan et sa saad varsti tööle C:");
            }

            //küsi kasutajalt tema parooli 
            string parool = "";
            string parool2 = "";
            Console.WriteLine("Mis on sinu parool?"); 
            parool = Console.ReadLine();
            //seejärel küsi kasutajalt tema 2FA koodi,
            Console.WriteLine("Mis on sinu 2FA parool?");
            parool2 = Console.ReadLine();
            //kui parool on vale, ütle sissepääs keelatud
            if (parool != "1234")
            {
                Console.WriteLine("sissepääs on keelatud");
            }
            //kui parool on õige, kontrolli 2FA koodi:
            if (parool == "1234")
            {
                //  kui 2FA kood on lühem kui 6 tähte ütle sissepääs on keelatud, kood on liiga lühike
                if (parool2.Length < 6)
                {
                    Console.WriteLine("sissepääs on keelatud, kood on liiga lühike");
                }
                //  kui 2FA kood on pikem kui 6 tähte ütle sissepääs on keelatud, kood on liiga pikk
                if (parool2.Length > 6)
                {
                    Console.WriteLine("sissepääs on keelatud, kood on liiga pikk");
                }
                //  kui 2FA kood on 6 tähte lase sisse, ütle "oled sissepääsenud"
                if (parool2.Length == 6)
                {
                    Console.WriteLine("oled sissepääsenud");
                }
            }
            //NB: 2FA kood ei matchima eksisteeriva näitega nagu parool.
        }
    }
}
