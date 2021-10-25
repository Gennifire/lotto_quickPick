using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto_quickPick
{
    
    public partial class Form1 : Form
    {   
        int[] LottoNum = new int[47]; //creates array to hold numbers 1-47.
        int Btnclicks = 0;
        int Reset_Btnclicks = 0;
        int cost = 1;
        public Form1()
        {
            InitializeComponent();
            Btn_reset.Enabled = false;
        }

        private void clear()
        {
            Line1.Text = "";
            Line2.Text = "";
            Line3.Text = "";
            Line4.Text = "";
            Line5.Text = "";
            Line6.Text = "";
            Line7.Text = "";
            Line8.Text = "";
            Line9.Text = "";
            Line10.Text = "";
            Btn_pick.Enabled = true;
            
        }
        private void Btn_reset_Click(object sender, EventArgs e)
        {
            Reset_Btnclicks++;
            if (Reset_Btnclicks > 0)
            {
                Btn_reset.Enabled = false;
            }
            clear();
            
        }

        private void Btn_pick_Click(object sender, EventArgs e)
        {
            Btnclicks++;
            Random rnd = new Random(); //creates random number generator object.
            
            for (int i = 1; i < LottoNum.Length; i++) //if set to zero goes outside scope of array and breaks, set to 1 works(find out why).

                LottoNum[i - 1] = i; //should fill array "lottoNum" indexes 0-46 with 47 numbers. 

            for (int i = 1; i < LottoNum.Length; i++)//fisher - yates shuffle
            {
                int j = rnd.Next() % LottoNum.Length; //get random number assign to j
                int position = LottoNum[i]; //position = the position of lottoNum[i]
                LottoNum[i] = LottoNum[j]; //lottoNum[i] swapped to lottoNum[j]
                LottoNum[j] = position;  //lottoNum[j] now has lottoNum[i]'s original position 
            }

            //foreach (int number in Enumerable.Range(1, 47).OrderBy(x => rnd.Next()))
            //{
            //    Line1.Text = string.Join("", number, " ", rnd.Next(number), " ", rnd.Next(number), " ", rnd.Next(number), " ", rnd.Next(number), " ", rnd.Next(number));
            //} // not good has repeating numbers

            /*----- this is where i'm trying to get a single button cycle through the sequence
                    and populate the text box with 6 additional random numbers*/

            for (int count = 1; count < 7; count++) // count is each number on the line, if less than 7 (or == 6) 
            {
                
                switch (Btnclicks)//if Btnclick = 1 fill textBox 1 etc.
                {
                    case 1:
                        //Line1.Text = string.Join("", LottoNum[0], "  ", LottoNum[1], "  ", LottoNum[2], "  ", LottoNum[3], "  ", LottoNum[4], "  ", LottoNum[5] );
                        Line1.Text = Line1.Text + string.Join("", LottoNum[count], "  "); 
                        break;

                    case 2:
                        Line2.Text += string.Join("", LottoNum[count], "  "); // += lets the entire string appear in the box instead of just the last index
                        break;

                    case 3:
                        Line3.Text += string.Join("", LottoNum[count], "  ");
                        break;

                    case 4:
                        Line4.Text += string.Join("", LottoNum[count], "  ");
                        break;

                    case 5:
                        Line5.Text += string.Join("", LottoNum[count], "  "); 
                        break;

                    case 6:
                        Line6.Text += string.Join("", LottoNum[count], "  "); 
                        break;

                    case 7:
                        Line7.Text += string.Join("", LottoNum[count], "  "); 
                        break;

                    case 8:
                        Line8.Text += string.Join("", LottoNum[count], "  "); 
                        break;

                    case 9:
                        Line9.Text += string.Join("", LottoNum[count], "  ");
                        break;

                    case 10:
                        Line10.Text += string.Join("", LottoNum[count], "  "); 
                        break;
                };

                if (Btnclicks > 10)
                {
                    MessageBox.Show("You have 10 Quick Picks, please reset to create more lines");
                    Btnclicks = 0; //if the button clicks > than 10, resets button clicks to 0 to allow to repopulate the table after reset
                    Btn_pick.Enabled = false;
                    Btn_reset.Enabled = true;
                }

            }
        }
    }
}
