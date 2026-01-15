namespace SWITCHCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt kas ta soovib omale uut autot
            string sisestus = "";
            Console.WriteLine("kas sa soovid endale uut autot?");
            sisestus = Console.ReadLine();
            //kui ei, siis programm lõppeb kasutajale sõnumiga "headaega"
            if (sisestus == "ei")
            {
                Console.WriteLine("headaega");
            }
            //kui jah, siis küsi kasutajalt milline automudel talle meeldib
            string automudel = "";
            if (sisestus == "jah")
            {
                Console.WriteLine("Milline automudel sulle meeldib");
                automudel = Console.ReadLine();
                switch (automudel)
                {
                    case "audi":
                        Console.WriteLine("audi on noormuttidele");
                        break;
                    case "volkswagen":
                        Console.WriteLine("autobahn on su elu ja armastus");
                        break;
                    case "lada":
                        Console.WriteLine("ah käi potilaadale!");
                        Console.WriteLine("OPPA, SEE JUBA LÄHEB");
                        break;
                    case "mustang":
                        Console.WriteLine("hobustele autokuuris asja pole");
                        break;
                    case "opel":
                        Console.WriteLine("opeleeri kuskil mujal");
                        break;
                }
            }
            //erista switch case abil:

            //  kui talle meeldib audi - siis ütle audi on noormuttidele
            //  kui talle meeldib volkswagen - siis ütle autobahn on su elu ja armastus
            //  kui talle meeldib lada - siis ütle ah käi potilaadale!
            //  kui talle meeldib mustang - hobustele autokuuris asja pole
            //  kui talle meeldib opel - siis ütle opeleeri kuskil mujal
            //  kui talle meeldib programmi kirjutaja lemmikmark - OPPA, SEE JUBA LÄHEB
            //(kui eelnevalt oli ülesande kirjelduses programmeerija lemmikmark, siis asenda seal see mark millegi muuga)

            //küsi kasutajalt millises riigis talle meeldiks elada
            //valikuteks anna talle: ei tea, Eesti, Läti, Leedu, saksamaa, poola, ukraina.
            string riik = "";
            Console.WriteLine("Millises riigis sulle meeldiks elada: \"ei tea\", \"Eesti\", \"Läti\", \"Leedu\", \"Saksamaa\", \"Poola\", \"Ukraina\"?");
            riik = Console.ReadLine();
            //erista switch case abil riik, ning prindi konsooli selle riigi lipu jagu ridu, mis on värvitud console.backgroundcolor meetodiga
            switch (riik)
            {
                case "ei tea":
                    Console.WriteLine("kurb :c");
                    break;
                case "Eesti":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "Läti":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "Leedu":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "Saksamaa":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "Poola":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "Ukraina":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.WriteLine("       ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
            //lipuvärve vaata googlest, kasuta võimalikult sarnaseid vasteid, üks lipp on 6 rida,
            //et kolmese triibuga lippe saaks teha (&/3=2 rida per triip)ja kahe triibuga lippe saaks teha (6/2 =3 rida per triip

            //küsi kasutajalt kas ta õpib koolis
            string kasõpib = "";
            Console.WriteLine("Kas sa õpid koolis?");
            kasõpib = Console.ReadLine();
            //kui ei, siis programm lõppeb kasutajale sõnumiga "edu tööturul"
            if (kasõpib == "ei")
            {
                Console.WriteLine("edu tööturul");
            }
            //kui jah, siis küsi kasutajalt mitmendas klassis ta käib
            else if (kasõpib == "jah")
            {
                Console.WriteLine("Mitmendas klassis saa käid?");
                //tee muutuja "vastus" mis hoiab meeles kasutaja vastust
                string vastus = "";
                vastus = Console.ReadLine();
                switch (vastus)
                {
                    case "1":
                        Console.WriteLine("kelleks sa saada tahad?");
                        vastus = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("kas sulle koolis meeldib õppida?");
                        vastus = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("kuidas kolmandas klassis läheb?");
                        vastus = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("kas koolis kiusatakse sind?");
                        vastus = Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("kirjuta oma sõnadega murdvõrrandi valem");
                        vastus = Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("kas kohustuslik kirjandus meeldib, või on ajaraiskamine?");
                        vastus = Console.ReadLine();
                        break;
                    case "7":
                        Console.WriteLine("Kas põhikool on raske, või lihtne");
                        vastus = Console.ReadLine();
                        break;
                    case "8":
                        Console.WriteLine("kellena sa ennast tänasel tööturul näed ja kas see mida sina teha tahad sellega kokku sobib?");
                        vastus = Console.ReadLine();
                        break;
                }
                if (vastus == "9" && vastus == "10" && vastus == "11" && vastus == "12")
                {
                    vastus = "";
                    while (vastus == "")
                    {
                        Console.WriteLine("mis pärast kooli lõpetamist plaanis on? Vasta kas: \"ei tea\", \"ei kavatse kooli lõpetada\", \"oma vastus\"");
                        vastus = Console.ReadLine();
                    }
                    switch (vastus)
                    {
                        case "ei tea":
                            Console.WriteLine("loodan et see idee ka ükspäev tuleb");
                            break;
                        case "ei kavatse kooli lõpetada":
                            Console.WriteLine("see on halb otsus. mul on sinust kahju :c");
                            break;
                        default:
                            Console.WriteLine($"oh, see on hea asi teha :D {vastus}");
                            break;
                    }
                }
                Console.WriteLine($"Küsitlusprogramm sulgub, viimane sisestatud vastus {vastus}");
            }

            //kui klass, kus õpilane parasjagu on, asub vahemikus 1-4, siis
            //      erista switch case abil:
            //          esimeses klassis - küsi muutujasse "vastus" küsimusele "kelleks sa saada tahad?" sisend.
            //          teises klassis - küsi muutujasse "vastus" küsimusele "kas sulle koolis meeldib õppida?" sisend.
            //          kolmandas klassis - küsi muutujasse "vastus" küsimusele "kuidas kolmandas klassis läheb?" sisend.
            //          neljandas klassis - küsi muutujasse "vastus" küsimusele "kas koolis kiusatakse sind?" sisend.
            //kui klass, kus õpilane parasjagu on, asub vahemikus 5-8, siis
            //      erista switch case abil:
            //          viiendas klassis - küsi muutujasse "vastus" küsimusele "kirjuta oma sõnadega murdvõrrandi valem" sisend.
            //          kuuendas klassis - küsi muutujasse "vastus" küsimusele "kas kohustuslik kirjandus meeldib, või on ajaraiskamine?" sisend.
            //          seitsmendas klassis - küsi muutujasse "vastus" küsimusele "Kas põhikool on raske, või lihtne" sisend.
            //          kaheksandas klassis - küsi muutujasse "vastus" küsimusele "kellena sa ennast tänasel tööturul näed ja kas see mida sina teha tahad sellega kokku sobib?" sisend.
            //kui klass, kus õpilane parasjagu on, asub kõrgemal kui 8 klass, siis:
            //küsi kasutajalt niikaua kuni muutuja "vastus" tühi ei ole (tsüklis) "mis pärast kooli lõpetamist plaanis on?"
            //anna talle valikuks "ei tea", "ei kavatse kooli lõpetada", "oma vastus"
            //tsükkel käib niikaua kuni vastuses midagi on.
            //erista switch case abil:
            //  kui ta ei tea - kuva sõnum "loodan et see idee ka ükspäev tuleb"
            //  kui ei kavatse - kuva sõnum "see on halb otsus. mul on sinust kahju :c"
            //  kõige muu puhul - "oh, see on hea asi teha :D" ja sõnumisse kuvatakse kasutaja vastus muutujast vastus
            //viimase sõnumina kuva "Küsitlusprogramm sulgub, viimane sisestatud vastus" ning lisa juurde muutuja vastus sisu
        }
    }
}
