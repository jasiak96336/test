using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jak_się_czujesz_xd
{
    

    public partial class Form1 : Form
    {
        int nastroj = 0;
        int pyt =0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pytanie_Click(object sender, EventArgs e)
        {
            

        }

        private void odp1_Click(object sender, EventArgs e)
        {
            pyt++;
            if (pyt > 0)
            {
                odp1.Text = "Tak";
                odp2.Text = "Nie";
            }

            if (pyt ==1)
            {
                pytanie.Text = "Wyspałeś/aś się dziś?";
                nastroj++;
            }

            if (pyt == 2)
            {
                pytanie.Text = "Zjadłeś/aś śniadanie?";
                nastroj++;
                
            }

            if (pyt == 3)
            {
                pytanie.Text = "Spotkało Cię coś miłego?";
                nastroj++;
            }

            if (pyt == 4)
            {
                pytanie.Text = "Odczuwasz jakiś ból?";
            }

            if (pyt == 5)
            {
                pytanie.Text = "Zobaczyłeś/aś dziś coś śmiesznego?";
                nastroj++;
            }

            if (pyt == 6)
            {
                pytanie.Text = "Obiadek był smaczny?";
                nastroj++;
            }

            if (pyt == 7)
            {
                pytanie.Text = "Zdenerwował Cię ktoś dzisiaj?";
            }

            if (pyt == 8)
            {
                pytanie.Text = "Powiedział Ci ktoś coś miłego?";
                nastroj++;
            }

            if (pyt == 9)
            {
                pytanie.Text = "Słuchałeś/aś swojej ulubionej muzyki?";
                nastroj++;
            }

            if (pyt == 10)
            {
                pytanie.Text = "Zostałeś/aś do czegoś zmuszony/a?";
                
            }

            if (pyt > 10)
            {
                odp1.Text = "Podsumuj ankietę!";
                if (nastroj > 5)
                {
                    Form3 f = new Form3();
                    f.ShowDialog();
                }
                odp2.Text = "Nie chcę znać wyniku";
              
            }
        }


        private void odp2_Click(object sender, EventArgs e)
        {
            pyt++;
            if (pyt > 0)
            {
                odp1.Text = "Tak";
                odp2.Text = "Nie";
            }

            if (pyt == 1)
            {
                pytanie.Text = "Wyspałeś/aś się dziś?";
            }

            if (pyt == 2)
            {
                pytanie.Text = "Zjadłeś/aś śniadanie?";
            }

            if (pyt == 3)
            {
                pytanie.Text = "Spotkało Cię coś miłego?";
            }

            if (pyt == 4)
            {
                pytanie.Text = "Odczuwasz jakiś ból?";
            }

            if (pyt == 5)
            {
                pytanie.Text = "Zobaczyłeś/aś dziś coś śmiesznego?";
            }

            if (pyt == 6)
            {
                pytanie.Text = "Obiadek był smaczny?";
            }

            if (pyt == 7)
            {
                pytanie.Text = "Zdenerwował Cię ktoś dzisiaj?";
            }

            if (pyt == 8)
            {
                pytanie.Text = "Powiedział Ci ktoś coś miłego?";
            }

            if (pyt == 9)
            {
                pytanie.Text = "Słuchałeś/aś swojej ulubionej muzyki?";
            }

            if (pyt == 10)
            {
                pytanie.Text = "Zostałeś/aś do czegoś zmuszony/a?";

            }

            if (pyt > 10)
            {
                odp1.Text = "Podsumuj ankietę!";
                odp2.Text = "Nie chcę znać wyniku";
            }

           

        }
          
      



}
}
