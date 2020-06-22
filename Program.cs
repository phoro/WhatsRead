using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsRead
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// 
        /// </summary>
        
        // array per desar el text
        public static string[] textarxiu = { "text","array"};
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WhatsReader());
                      
            
            Llegeix();
        }
        public static void Llegeix()
        {
        
            try
            {   // Obre l'arxiu de text .
                StreamReader lector = new StreamReader("text.txt");
               
                {
                    // Read the stream to a string.
                    string line = lector.ReadToEnd();
                    textarxiu[0] = line;
                    Console.WriteLine("****************provant***************");
                    Console.WriteLine(textarxiu[0]);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
