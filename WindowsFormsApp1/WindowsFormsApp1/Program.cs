using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public static class UnitInfo
    {
        public static string Callsign { get; set; }
        public static string Name { get; set; }
        public static string Coordinates { get; set; }
        public static double LocationX { get; set; }
        public static double LocationY { get; set; }
        public static int Whatdo { get; set; }  // Код вида действия
    }

   
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
