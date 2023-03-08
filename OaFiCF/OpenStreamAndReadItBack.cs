using System;
using System.Diagnostics;
using System.Windows;

namespace OaFiCF
{
    class OpenStreamAndReadItBack
    {
        public static bool noOpenedFileYet = false;
        public static void stream(string filePath)
        {
            
            try
            {
                // don't open itself
                if (filePath.Contains("OaFiCF.exe"))
                {
                    Console.WriteLine("Consist");
                }
                // open the rest
                else
                {
                    noOpenedFileYet = true;
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
