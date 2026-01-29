namespace meetodülesanded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vastus = "";
            string info = "";
            do
            {
                //kasutajalt info saamine
                Console.WriteLine("Palun sisesta filtreeritav lähteinfo: ");
                info = GetResponse();
                Console.WriteLine("Palun sisesta otsitav info: ");
                string searchthisword = GetResponse();

                //filtreerimine ja teavitus
                bool doeswordexist = Findthisword(searchthisword, info);
                if (doeswordexist == true)
                {
                    Console.WriteLine("Leidsime sõna \"" + searchthisword + "\"sinu sisestatud infost: \"");
                    Console.WriteLine(info);
                }
                else
                {
                    Console.WriteLine("Sõna \"" + searchthisword + "\" infost puudub \"");

                }
                //programmi töö kordamine
                vastus = RepeatAction();
            } while (vastus == "jah");
            vastus = "";

            do
            {
                Console.WriteLine("Kas soovid infosse midagi juurde lisada?");
                vastus = GetResponse();
                if (vastus == "jah")
                {
                    Console.WriteLine("Kirjuta juurde lisatav info:");
                    info += Console.ReadLine();
                }
                vastus = "";
                vastus = RepeatAction();

            } while (vastus == "jah");
            do
            {
                Console.WriteLine("Kas salvestad dokumendi töölauale või dokumendikausta?");
                string kuhu = GetResponse();
                string saveFileHere = "";
                if (kuhu == "töölaud")
                {
                    saveFileHere = "C:\\Users\\opilane\\Desktop\\info.txt";
                }
                else if (kuhu == "dokumendid")
                {
                    saveFileHere = "C:\\Users\\opilane\\Documents\\info.txt";
                }
                else
                {
                    Console.WriteLine("ei saa aru, " + kuhu + " ei olesalvestatav asukoht");
                    vastus = RepeatAction();
                }
                File.WriteAllText(saveFileHere, info);

            } while (vastus == "jah");
           

            //programmi lõpp
            Console.WriteLine("Headaega");

        }

        private static string RepeatAction()
        {
            string vastus;
            Console.WriteLine("Kas tahad tegevust korrata: (jah/ei)");
            vastus = GetResponse();
            return vastus;
        }

        public static bool Findthisword(string filter, string tobefiltered)
        {
            if (tobefiltered.Contains(filter))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static string GetResponse()
        {
            string sisestus = "";
            while (sisestus == "")
            {
                sisestus = Console.ReadLine();
            }
            return sisestus;
        }
        
    }
}
