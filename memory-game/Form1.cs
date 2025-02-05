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
    public partial class Form1 : Form
    {
        int btn_count = 0;
        string[] clicked_buttons = new string[2];
        Image[] card_img = new Image[4]
        {
            Properties.Resources.HondFoto1,
            Properties.Resources.HondFoto1,
            Properties.Resources.HondFoto2,
            Properties.Resources.HondFoto2
        };
        string[] card_tags = new string[4]
        {
            "1",
            "1",
            "2",
            "2"
        };




        public Form1()
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

            card1.Image = card_img[0];
            card1.Tag = card_tags[0];
            card2.Image = card_img[1];
            card2.Tag = card_tags[1];
            card3.Image = card_img[2];
            card3.Tag = card_tags[2];
            card4.Image = card_img[3];
            card4.Tag = card_tags[3];


        }


        //compaire cards
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (btn_count < 2)
            {
                button.FlatAppearance.BorderColor = Color.Red;
                btn_count++;
                button.FlatAppearance.BorderSize = 3;
            }

            if (btn_count == 1)
            {
                clicked_buttons[0] = button.Tag.ToString();
            }
            else if (btn_count == 2)
            {
                btn_count = 3;//zorgt er voor dat er niets gebeurt bij de derde klik
                clicked_buttons[1] = button.Tag.ToString();
                //zelfde detectie
                if (clicked_buttons[0] == clicked_buttons[1])
                {
                    label1.Text = "ze zijn hetzelfde";
                }
                else
                {
                    label1.Text = "ze zijn niet hetzelfde";
                }
            }

        }
    }
}
