using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_jan_21_autok_kortea
{
    public partial class Form_nyito : Form
    {
        public Form_nyito()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string marka in Program.autok.Select(a => a.Marka).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = marka;
                cb.Checked = true;
                cb.Location = new Point(10, panel_marka.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(marka_valtozott);
                panel_marka.Controls.Add(cb);
            }
            updateAutoLista();
            
        }

        private void marka_valtozott(object sender, EventArgs e)
        {
            updateAutoLista();
        }

        private void updateAutoLista()
        {

            listBox_autok.Items.Clear();
            List<string> kivalasztottak = new List<string>();
            foreach (CheckBox item in panel_marka.Controls)
            {
                if (item.Checked) { kivalasztottak.Add(item.Text); };
            }
            foreach (Autok item in Program.autok)
            {
                if (kivalasztottak.Contains(item.Marka))
                {
                    listBox_autok.Items.Add(item);
                }
            }
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuto formAutok = new FormAuto("add");
            formAutok.ShowDialog();
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormAuto formAutok = new FormAuto("edit");
            formAutok.ShowDialog();
        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_autok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormAuto formAutok = new FormAuto("delete");
            formAutok.ShowDialog();

        }
    }
}
