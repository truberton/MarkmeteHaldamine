using System;
using System.Xml;

namespace MarkmeteHaldamine
{
    class ListNotes
    {
        public void List()
        {
            Console.WriteLine("Olemasolevad märkmed on:");

            XmlDocument doc = new XmlDocument();
            doc.Load("markmed.xml");

            int i = 0;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                i++;
                Console.WriteLine(i.ToString() + ") " + node.Attributes["pealkiri"].InnerText);
            }
            Console.WriteLine();
            Console.WriteLine("Millist soovite lugeda?");
            int vastus = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Tekst: " + doc.DocumentElement.ChildNodes[vastus].Attributes["tekst"].InnerText);
        }
    }
}
