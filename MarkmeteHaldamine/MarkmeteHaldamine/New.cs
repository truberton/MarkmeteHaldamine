using System;
using System.Xml.Linq;


namespace MarkmeteHaldamine
{
    /// <summary>
    /// This class creates a new note in the XML file.
    /// </summary>
    class New
    {
        /// <example>
        /// <code>
        /// uus.Create();
        /// </code>
        /// </example>
        public void Create()
        {
            Console.WriteLine("Mis on pealkiri?");
            string pealkiri = Console.ReadLine();

            Console.WriteLine("Mis on tekst?");
            string tekst = Console.ReadLine();
           
            XElement xml = XElement.Load("markmed.xml");
            xml.Add(new XElement("Märkus",
            new XAttribute("pealkiri", pealkiri), new XAttribute("tekst", tekst)
            ));
            xml.Save("markmed.xml");
        }
    }
}
