using System;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Windows;

namespace OaFiCF
{
    static class ReadAllFiles
    {
        public static string myP;
        public static void getPath()
        {
            try
            {
                var pat = Environment.CurrentDirectory;
                var config = ConfigurationManager.AppSettings["suffix"];
                var milliseconds = ConfigurationManager.AppSettings["delayForOpenInMilisecconds"];
                string[] myPats = Directory.GetFiles(pat, config);
                //Console.WriteLine("Files2:" + pat);
                //Console.WriteLine("Files1:" + config);

                foreach (var myPat in myPats)
                {
                    myP += myPat + Environment.NewLine;
                    Thread.Sleep(Int16.Parse(milliseconds));
                    OpenStreamAndReadItBack.stream(myPat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
