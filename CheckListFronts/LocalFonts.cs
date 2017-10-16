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

        public static FontFamily[] ParsingDesctopFonts()
        {
            FontFamily[] fontFamilies; //Создаём массив семей шрифтов


            InstalledFontCollection installedFontCollection = new InstalledFontCollection();//Создаём и инициализруем объект штоб воткнуть потом в массив

            fontFamilies = installedFontCollection.Families; //впихиваем массив семьи щрифтов

            countOfFamiliesFonts = fontFamilies.Length; // на всякий берём их колличество

            return fontFamilies;

            

        }

    }
}
