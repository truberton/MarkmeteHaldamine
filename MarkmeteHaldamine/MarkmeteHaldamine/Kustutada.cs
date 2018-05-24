using System;
using System.Xml;


namespace MarkmeteHaldamine
{
    class Kustutada
    {
        /// <summary>
        /// This class deletes the chosen note.
        /// </summary>
        public void kustuta()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("markmed.xml");

            Console.WriteLine("Millist soovite kustutada?:");
            int i = 0;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                i++;
                Console.WriteLine(i.ToString() + ") " + node.Attributes["pealkiri"].InnerText);
            }
            int vastus = int.Parse(Console.ReadLine()) - 1;
            XmlNode root = doc.DocumentElement;

            root.RemoveChild(root.ChildNodes[vastus]);
            doc.Save("markmed.xml");
        }
    }
}
