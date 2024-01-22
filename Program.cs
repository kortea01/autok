using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_jan_21_autok_kortea
{
    internal static class Program
    {
        public static List<Autok> autok = new List<Autok>();
        public static Adatbazis db = null;
        public static Form_nyito form_nyito = null;
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            db = new Adatbazis();
            autok = db.getAllAuto();
            form_nyito = new Form_nyito();
            Application.Run(new Form_nyito());
        }
    }
}
