using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_game
{
    public partial class form1 : Form
    {
        int btn_count = 0;
        string[] clicked_buttons_tag = new string[2];
        Image[] card_img = new Image[16]
        {
            Properties.Resources.HondFoto1,
            Properties.Resources.HondFoto1,
            Properties.Resources.HondFoto2,
            Properties.Resources.HondFoto2,
            Properties.Resources.HondFoto3,
            Properties.Resources.HondFoto3,
            Properties.Resources.HondFoto4,
            Properties.Resources.HondFoto4,
            Properties.Resources.HondFoto5,
            Properties.Resources.HondFoto5,
            Properties.Resources.HondFoto6,
            Properties.Resources.HondFoto6,
            Properties.Resources.HondFoto7,
            Properties.Resources.HondFoto7,
            Properties.Resources.HondFoto8,
            Properties.Resources.HondFoto8
        };
        string[] card_tags = new string[16]
        {
            "1",
            "1",
            "2",
            "2",
            "3",
            "3",
            "4",
            "4",
            "5",
            "5",
            "6",
            "6",
            "7",
            "7",
            "8",
            "8"
        };




        public form1()
        {
            InitializeComponent();
        }

        //asign images to buttons
        private void Form1_Load(object sender, EventArgs e)
        {
            //shuffle cards using fisher-yates shuffle (learned from chatgpt creatued by typing for and tab and that made whole code)
            for (int i = card_img.Length - 1; i > 0; i--)
            {
                int j = new Random().Next(i + 1);

                Image temp = card_img[i];
                card_img[i] = card_img[j];
                card_img[j] = temp;

                string temp_tag = card_tags[i];
                card_tags[i] = card_tags[j];
                card_tags[j] = temp_tag;
            }

            //de tags en fots toevoegen aan de buttons
            card1.Image = card_img[0];
            card1.Tag = card_tags[0];
            card2.Image = card_img[1];
            card2.Tag = card_tags[1];
            card3.Image = card_img[2];
            card3.Tag = card_tags[2];
            card4.Image = card_img[3];
            card4.Tag = card_tags[3];
            card5.Image = card_img[4];
            card5.Tag = card_tags[4];
            card6.Image = card_img[5];
            card6.Tag = card_tags[5];
            card7.Image = card_img[6];
            card7.Tag = card_tags[6];
            card8.Image = card_img[7];
            card8.Tag = card_tags[7];
            card9.Image = card_img[8];
            card9.Tag = card_tags[8];
            card10.Image = card_img[9];
            card10.Tag = card_tags[9];
            card11.Image = card_img[10];
            card11.Tag = card_tags[10];
            card12.Image = card_img[11];
            card12.Tag = card_tags[11];
            card13.Image = card_img[12];
            card13.Tag = card_tags[12];
            card14.Image = card_img[13];
            card14.Tag = card_tags[13];
            card15.Image = card_img[14];
            card15.Tag = card_tags[14];
            card16.Image = card_img[15];
            card16.Tag = card_tags[15];
        }


        //compaire cards
        private void Card_Click(object sender, EventArgs e)
        {
            Button card = sender as Button;

            if (btn_count < 2)
            {
                card.FlatAppearance.BorderColor = Color.Red;
                btn_count++;
                card.FlatAppearance.BorderSize = 3;
            }

            if (btn_count == 1)
            {
                clicked_buttons_tag[0] = card.Tag.ToString();
            }
            else if (btn_count == 2)
            {
                btn_count = 3;//zorgt er voor dat er niets gebeurt bij de derde klik
                clicked_buttons_tag[1] = card.Tag.ToString();
                //zelfde detectie
                if (clicked_buttons_tag[0] == clicked_buttons_tag[1])
                {
                    Console.WriteLine("ze zijn hetzelfde");
                }
                else
                {
                    Console.WriteLine("ze zijn niet hetzelfde");
                }
            }

        }
    }
}
