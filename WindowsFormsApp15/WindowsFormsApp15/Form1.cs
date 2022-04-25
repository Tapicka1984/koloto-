using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text_od_uzivatele = textBox1.Text;
            if(Text_od_uzivatele.Contains("  "))
            {
                Text_od_uzivatele.Replace("  "," ");
            }
            int pocitadlo_nejcastejsiho_znaku = 0;
            int pismeno = 97;
            int testovaci_promena = 0;
            char pismeno2 = 'a';
            char nejcastejsi_pismeno = ' ';
            for(int i = 0; i < 26; i++)
            {
                foreach (char x in Text_od_uzivatele)
                {
                    if(x == pismeno)
                    {
                        pocitadlo_nejcastejsiho_znaku++;
                        pismeno2 = x;
                    }
                }
                if(pocitadlo_nejcastejsiho_znaku > testovaci_promena)
                {
                    testovaci_promena = pocitadlo_nejcastejsiho_znaku;
                    nejcastejsi_pismeno = pismeno2;
                }
                pismeno++;
                pocitadlo_nejcastejsiho_znaku = 0;
            }
            label2.Text = nejcastejsi_pismeno.ToString();
            label4.Text = testovaci_promena.ToString();
            //tohle funguje - nesahat; abecade - abcdefghijklmnopqrstuvwxyz;
            char testovaci_pismeno = 'a';
            char[] pole = new char[26];
            int pismeno5 = 0;
            for (int i = 0; i < 26; i++)
            {
                foreach(char y in Text_od_uzivatele)
                {
                    if(y == testovaci_pismeno)
                    {
                        pole[pismeno5] = ' ';
                    }
                    else if (y != testovaci_pismeno)
                    {
                        pole[pismeno5] = testovaci_pismeno;
                    }    
                }
                testovaci_pismeno++;
                pismeno++;
            }
            label6.Text = new string(pole);
        }
    }
}
