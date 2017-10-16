  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckListFronts
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(CheckBaseFonts);

            thread.Start();
        }

        static void CheckBaseFonts()
        {

            while(true)
            {
                IExml.WriteFontsToXmlList(LocalFonts.GetSetupingFonts());

                //TODO отправка на сервер

                Thread.Sleep(900000);
            }


        }
    }
}
