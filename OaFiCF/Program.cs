using System;
using System.Configuration;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace OaFiCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurationManager.AppSettings["suffix"];
            ReadAllFiles.getPath();

            if (OpenStreamAndReadItBack.noOpenedFileYet)
            {
                //Console.WriteLine("Full path of current directory:" + curDir);
                //Console.ReadKey();
                MessageBox.Show(ReadAllFiles.myP);
            }
            else
            {
                MessageBox.Show("No any file have been found by suffix " + config);
                Environment.Exit(0);
            }

        }
    }
}
