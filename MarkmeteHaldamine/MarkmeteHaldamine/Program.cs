using System;
using System.IO;

namespace MarkmeteHaldamine
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("markmed.xml"))
            {
                var xml = new CreateXML();
                xml.create();
            }
            while (true)
            {
                Console.WriteLine("\n--------------------------\nMida soovite teha?\n1. lugeda\n2. luua\n3. kustutada\n4. lõpetada\n--------------------------");
                string vastus = Console.ReadLine();
                switch (vastus)
                {
                    case "1":
                        ListNotes listNotes = new ListNotes();
                        listNotes.List();
                        break;
                    case "2":
                        New uus = new New();
                        uus.Create();
                        break;
                    case "3":
                        Kustutada kustutada = new Kustutada();
                        kustutada.kustuta();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("The fuck");
                        break;
                }
            }
        }
    }
}
