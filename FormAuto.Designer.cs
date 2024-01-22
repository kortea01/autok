namespace _2024_jan_21_autok_kortea
{
    partial class FormAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.auto_rendszam = new System.Windows.Forms.Label();
            this.textBox_auto_rendszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_marka = new System.Windows.Forms.TextBox();
            this.textBox_modell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUp_vetelar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_hengerurt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_tomeg = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_teljesitmeny = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTime_forgalmi_erv = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown_kmora = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.button_Muvelet = new System.Windows.Forms.Button();
            this.numup_gyartasi_ev = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_vetelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hengerurt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tomeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teljesitmeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kmora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numup_gyartasi_ev)).BeginInit();
            this.SuspendLayout();
            // 
            // auto_rendszam
            // 
            this.auto_rendszam.AutoSize = true;
            this.auto_rendszam.Location = new System.Drawing.Point(13, 9);
            this.auto_rendszam.Name = "auto_rendszam";
            this.auto_rendszam.Size = new System.Drawing.Size(100, 16);
            this.auto_rendszam.TabIndex = 0;
            this.auto_rendszam.Text = "Auto_rendszam";
            this.auto_rendszam.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_auto_rendszam
            // 
            this.textBox_auto_rendszam.Location = new System.Drawing.Point(16, 32);
            this.textBox_auto_rendszam.Name = "textBox_auto_rendszam";
            this.textBox_auto_rendszam.Size = new System.Drawing.Size(149, 22);
            this.textBox_auto_rendszam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Márka";
            // 
            // textBox_marka
            // 
            this.textBox_marka.Location = new System.Drawing.Point(222, 57);
            this.textBox_marka.Name = "textBox_marka";
            this.textBox_marka.Size = new System.Drawing.Size(144, 22);
            this.textBox_marka.TabIndex = 3;
            // 
            // textBox_modell
            // 
            this.textBox_modell.Location = new System.Drawing.Point(398, 58);
            this.textBox_modell.Name = "textBox_modell";
            this.textBox_modell.Size = new System.Drawing.Size(144, 22);
            this.textBox_modell.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gyártási év";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vételár";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUp_vetelar
            // 
            this.numericUp_vetelar.Location = new System.Drawing.Point(458, 128);
            this.numericUp_vetelar.Name = "numericUp_vetelar";
            this.numericUp_vetelar.Size = new System.Drawing.Size(121, 22);
            this.numericUp_vetelar.TabIndex = 9;
            this.numericUp_vetelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "EUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "cm3";
            // 
            // numericUpDown_hengerurt
            // 
            this.numericUpDown_hengerurt.Location = new System.Drawing.Point(222, 182);
            this.numericUpDown_hengerurt.Name = "numericUpDown_hengerurt";
            this.numericUpDown_hengerurt.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_hengerurt.TabIndex = 12;
            this.numericUpDown_hengerurt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hengerűrtartalom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "kg";
            // 
            // numericUpDown_tomeg
            // 
            this.numericUpDown_tomeg.Location = new System.Drawing.Point(398, 182);
            this.numericUpDown_tomeg.Name = "numericUpDown_tomeg";
            this.numericUpDown_tomeg.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_tomeg.TabIndex = 15;
            this.numericUpDown_tomeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tömeg";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "LE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // numericUpDown_teljesitmeny
            // 
            this.numericUpDown_teljesitmeny.Location = new System.Drawing.Point(219, 247);
            this.numericUpDown_teljesitmeny.Name = "numericUpDown_teljesitmeny";
            this.numericUpDown_teljesitmeny.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_teljesitmeny.TabIndex = 18;
            this.numericUpDown_teljesitmeny.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Teljesítmény";
            // 
            // dateTime_forgalmi_erv
            // 
            this.dateTime_forgalmi_erv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_forgalmi_erv.Location = new System.Drawing.Point(222, 127);
            this.dateTime_forgalmi_erv.Name = "dateTime_forgalmi_erv";
            this.dateTime_forgalmi_erv.Size = new System.Drawing.Size(200, 22);
            this.dateTime_forgalmi_erv.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Forgalmi igazolvány érvényessége";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(758, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "km";
            // 
            // numericUpDown_kmora
            // 
            this.numericUpDown_kmora.Location = new System.Drawing.Point(630, 128);
            this.numericUpDown_kmora.Name = "numericUpDown_kmora";
            this.numericUpDown_kmora.Size = new System.Drawing.Size(121, 22);
            this.numericUpDown_kmora.TabIndex = 24;
            this.numericUpDown_kmora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(633, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Km óra állás";
            // 
            // button_Muvelet
            // 
            this.button_Muvelet.Location = new System.Drawing.Point(16, 127);
            this.button_Muvelet.Name = "button_Muvelet";
            this.button_Muvelet.Size = new System.Drawing.Size(149, 52);
            this.button_Muvelet.TabIndex = 26;
            this.button_Muvelet.Text = "gomb";
            this.button_Muvelet.UseVisualStyleBackColor = true;
            this.button_Muvelet.Click += new System.EventHandler(this.button_Muvelet_Click);
            // 
            // numup_gyartasi_ev
            // 
            this.numup_gyartasi_ev.Location = new System.Drawing.Point(589, 57);
            this.numup_gyartasi_ev.Name = "numup_gyartasi_ev";
            this.numup_gyartasi_ev.Size = new System.Drawing.Size(121, 22);
            this.numup_gyartasi_ev.TabIndex = 27;
            this.numup_gyartasi_ev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 462);
            this.Controls.Add(this.numup_gyartasi_ev);
            this.Controls.Add(this.button_Muvelet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericUpDown_kmora);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTime_forgalmi_erv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown_teljesitmeny);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_tomeg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_hengerurt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUp_vetelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_modell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_marka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_auto_rendszam);
            this.Controls.Add(this.auto_rendszam);
            this.Name = "FormAuto";
            this.Text = "FormAuto";
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_vetelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hengerurt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tomeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teljesitmeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kmora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numup_gyartasi_ev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label auto_rendszam;
        private System.Windows.Forms.TextBox textBox_auto_rendszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_marka;
        private System.Windows.Forms.TextBox textBox_modell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUp_vetelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_hengerurt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_tomeg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_teljesitmeny;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTime_forgalmi_erv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown_kmora;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_Muvelet;
        private System.Windows.Forms.NumericUpDown numup_gyartasi_ev;
    }
}