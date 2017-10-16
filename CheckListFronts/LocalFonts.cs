using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace CheckListFronts
{
    class LocalFonts
    {

        public static int countOfFamiliesFonts = 0;

        private static FontFamily[] ParsingDesctopFonts()
        {
            FontFamily[] fontFamilies; //Создаём массив семей шрифтов


            InstalledFontCollection installedFontCollection = new InstalledFontCollection();//Создаём и инициализруем объект штоб воткнуть потом в массив

            fontFamilies = installedFontCollection.Families; //впихиваем массив семьи щрифтов

            countOfFamiliesFonts = fontFamilies.Length; // на всякий берём их колличество

            return fontFamilies;

            

        }

        public static List<string> GetSetupingFonts()//Создаём список с названием всех шрифтов 
        {
            FontFamily[] massFonts;
            List<string> ReturnList=new List<string>();

            massFonts = ParsingDesctopFonts();

            for(int i=0;i<massFonts.Length;i++)
            {
                ReturnList.Add(massFonts[i].Name);
            }

            return ReturnList;
        }

    }
}
