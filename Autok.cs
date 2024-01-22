using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_jan_21_autok_kortea
{
    internal class Autok
    {
        string rendszam;
        string marka;
        string modell;
        int gyartasi_ev;
        DateTime forgalmi_erv;
        int vetelar;
        int km_allas;
        int hengerurtartalom;
        int tomeg;
        int teljesitmeny;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Gyartasi_ev { get => gyartasi_ev; set => gyartasi_ev = value; }
        public DateTime Forgalmi_erv { get => forgalmi_erv; set => forgalmi_erv = value; }
        public int Vetelar { get => vetelar; set => vetelar = value; }
        public int Km_allas { get => km_allas; set => km_allas = value; }
        public int Hengerurtartalom { get => hengerurtartalom; set => hengerurtartalom = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }

        public Autok(DateTime forgalmi_erv, string rendszam, string marka, string modell, int gyartasi_ev, int vetelar, int km_allas, int hengerurtartalom, int tomeg, int teljesitmeny)
        {
            Forgalmi_erv = forgalmi_erv;
            Rendszam = rendszam;
            Marka = marka;
            Modell = modell;
            Gyartasi_ev = gyartasi_ev;
            Forgalmi_erv = forgalmi_erv;
            Vetelar = vetelar;
            Km_allas = km_allas;
            Hengerurtartalom = hengerurtartalom;
            Tomeg = tomeg;
            Teljesitmeny = teljesitmeny;
        }

        public Autok()
        {
        }

        public override string ToString()
        {
            return $"{this.marka} {this.modell} ({this.vetelar})";
        }
    }
}
