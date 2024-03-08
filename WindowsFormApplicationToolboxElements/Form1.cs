using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApplicationToolboxElements
{
    public partial class Form1 : Form
    {


        /*
         *  --++ Windows Form Elementlerin kullanilmasi ++--
         * 
         * [TASARIM]
         * - GroupBox Elementi kullanilacak. Icinde iki Button koyulacak.
         * - LinkLabel Elementi kullanilacak.
         * - NumericUpDown Elementi kullanilacak.
         * - TabControl Elementi kullanilacak. 
         *   Birinci tab icin 1 Button ekle, Ikinci tab icin bir ComboBox ekle
         * 
         * 
         * [KOD]
         * - LinkLabel tiklandiginde "https://vexyverse.com" linki Microsoft Edge'de acilacak.
         *   Process.Start fonksiyonu kullanarak yapabilirsin. 
         * - NumericUpDown yazilan deger her degistiginde MessageBox'ta gosterilecek.
         * - TabControl'un birinci tab'in icindeki button'a 
         *   tiklandiginda ekrana "Merhaba :)" MessageBox'la gosterilecek.
         *   
         * NOT: Anlamadigin bir kisim olursa bana sor mutlaka.
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vexyverse.com");
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba :)");
        }
    }
}
