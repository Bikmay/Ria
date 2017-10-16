using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace CheckListFronts
{
    class IExml
    {

        static string nameofFile = "froL.txt";

        public static void WriteFontsToXmlList(List<string> ListOfFonts) //Вписываем в Xml список шрифтов 
        {
            XmlDocument file = new XmlDocument();

            file.Load(nameofFile);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = false;

            using (XmlWriter writer = XmlWriter.Create(nameofFile, settings))
            {
                writer.WriteStartAttribute("list");



                for (int i = 0; i < ListOfFonts.Count; i++)
                {
                    writer.WriteElementString("font", ListOfFonts.ElementAt(i));
                }

                writer.WriteEndAttribute();
            }


            
        }
        
    }
}
