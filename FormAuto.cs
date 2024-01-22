using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2024_jan_21_autok_kortea
{
    
    public partial class FormAuto : Form
    {        
        string muvelet;
        public FormAuto(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }
        private void FormAuto_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "add":
                this.Text = "Új autó";                 
                button_Muvelet.Text = "Rögzítés";
                button_Muvelet.BackColor = Color.Yellow;
                button_Muvelet.Click += new EventHandler(insertAuto);
                    break;

                case "edit":
                    this.Text = "Módosítás";
                    button_Muvelet.Text = "Módosítás";
                    button_Muvelet.BackColor = Color.Green;
                    button_Muvelet.ForeColor = Color.White;
                    button_Muvelet.Click += new EventHandler(updateAuto);
                    adatamezokBetoltese();                    
                    break;

                case "delete":
                    this.Text = "Törlés";
                    button_Muvelet.Text = "Törlés";
                    button_Muvelet.BackColor = Color.BlueViolet;
                    button_Muvelet.ForeColor = Color.White;
                    button_Muvelet.Click += new EventHandler(deleteAuto);
                    adatamezokBetoltese();
                    break;
            }           

        }

        private void adatamezokBetoltese()
        {
            Autok auto = (Autok)Program.form_nyito.listBox_autok.SelectedItem;
            textBox_auto_rendszam.Text = auto.Rendszam.ToString();
            textBox_marka.Text = auto.Marka.ToString();
            textBox_modell.Text = auto.Modell.ToString();
            numup_gyartasi_ev.Value = (decimal)auto.Gyartasi_ev;
            numericUpDown_teljesitmeny.Value = (decimal)auto.Teljesitmeny;
            numericUpDown_hengerurt.Value = (decimal)auto.Hengerurtartalom;
            numericUpDown_kmora.Value = (decimal)auto.Km_allas;
            numericUpDown_tomeg.Value = (decimal)auto.Tomeg;
            dateTime_forgalmi_erv.Value = auto.Forgalmi_erv;
            numericUp_vetelar.Value = auto.Vetelar;
        }

        private void updateAuto(object sender, EventArgs e)        {
            
            Autok auto = (Autok)Program.form_nyito.listBox_autok.SelectedItem;
            auto.Rendszam = textBox_auto_rendszam.Text;
            auto.Marka = textBox_marka.Text;
            auto.Modell= textBox_modell.Text;
            auto.Gyartasi_ev= Convert.ToInt32(numup_gyartasi_ev.Value);
            auto.Teljesitmeny = Convert.ToInt32(numericUpDown_teljesitmeny.Value);
            auto.Hengerurtartalom = Convert.ToInt32(numericUpDown_hengerurt.Value);
            auto.Km_allas = Convert.ToInt32(numericUpDown_kmora.Value);
            auto.Tomeg = Convert.ToInt32(numericUpDown_tomeg.Value);
            auto.Forgalmi_erv = dateTime_forgalmi_erv.Value;
            auto.Vetelar = Convert.ToInt32(numericUp_vetelar.Value);
            Program.db.updateAuto(auto);
        }

        private void insertAuto(object sender, EventArgs e)
        {
            Autok auto = new Autok();
            auto.Rendszam = textBox_auto_rendszam.Text;
            auto.Marka = textBox_marka.Text;
            auto.Modell = textBox_modell.Text;
            auto.Gyartasi_ev = Convert.ToInt32(numup_gyartasi_ev.Value);
            auto.Teljesitmeny = Convert.ToInt32(numericUpDown_teljesitmeny.Value);
            auto.Hengerurtartalom = Convert.ToInt32(numericUpDown_hengerurt.Value);
            auto.Km_allas = Convert.ToInt32(numericUpDown_kmora.Value);
            auto.Tomeg = Convert.ToInt32(numericUpDown_tomeg.Value);
            auto.Forgalmi_erv = dateTime_forgalmi_erv.Value;
            auto.Vetelar = Convert.ToInt32(numericUp_vetelar.Value);
            Program.db.insertAuto(auto);
        }

        private void deleteAuto(object sender, EventArgs e)
        {
            Autok auto = (Autok)Program.form_nyito.listBox_autok.SelectedItem;
            Program.db.deleteAuto(auto);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button_Muvelet_Click(object sender, EventArgs e)
        {

        }
    }
}
