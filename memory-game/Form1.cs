using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_game
{
    public partial class game : Form
    {
        int btn_count = 0;
        int Score = 0;
        int Beurten = 0;
        Button[] clicked_buttons = new Button[2];
        int time = 0;
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

         void reset_cards()
        {
            card1.Image = Properties.Resources.card_back;
            card2.Image = Properties.Resources.card_back;
            card3.Image = Properties.Resources.card_back;
            card4.Image = Properties.Resources.card_back;
            card5.Image = Properties.Resources.card_back;
            card6.Image = Properties.Resources.card_back;
            card7.Image = Properties.Resources.card_back;
            card8.Image = Properties.Resources.card_back;
            card9.Image = Properties.Resources.card_back;
            card10.Image = Properties.Resources.card_back;
            card11.Image = Properties.Resources.card_back;
            card12.Image = Properties.Resources.card_back;
            card13.Image = Properties.Resources.card_back;
            card14.Image = Properties.Resources.card_back;
            card15.Image = Properties.Resources.card_back;
            card16.Image = Properties.Resources.card_back;
        }




        public game()
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

            //de tags en fotos toevoegen aan de button
            reset_cards();
            card1.Tag = card_tags[0];
            card2.Tag = card_tags[1];
            card3.Tag = card_tags[2];
            card4.Tag = card_tags[3];
            card5.Tag = card_tags[4];
            card6.Tag = card_tags[5];
            card7.Tag = card_tags[6];
            card8.Tag = card_tags[7];
            card9.Tag = card_tags[8];
            card10.Tag = card_tags[9];
            card11.Tag = card_tags[10];
            card12.Tag = card_tags[11];
            card13.Tag = card_tags[12];
            card14.Tag = card_tags[13];
            card15.Tag = card_tags[14];
            card16.Tag = card_tags[15];
        }


        //compaire cards
        private async void Card_Click(object sender, EventArgs e)
        {
            Button card = sender as Button;

            if (btn_count < 2)
            {
                btn_count++;
            }


            if (btn_count == 1)
            {

                if (timer.Enabled == false)
                {
                    timer.Start();
                }
                clicked_buttons[0] = card;
                card.Image = card_img[int.Parse(card.Name.Substring(4)) -1];
            }
            else if (btn_count == 2)
            {
                btn_count = 3;//zorgt er voor dat er niets gebeurt bij de derde klik
                card.Image = card_img[int.Parse(card.Name.Substring(4)) - 1];
                clicked_buttons[1] = card;
                //zelfde detectie
                await Task.Delay(1000); // 1000 ms = 1 second //veranderen met timer
                reset_cards();
                btn_count = 0;
                if (clicked_buttons[0].Tag == clicked_buttons[1].Tag)
                {
                    //Console.WriteLine("ze zijn hetzelfde");
                    clicked_buttons[0].Visible = false;
                    clicked_buttons[1].Visible = false;
                    Score += 10;
                    if (Score >= 80)
                    {
                        timer.Stop();
                    }
                }
                Beurten++;
                txtScore.Text = "Score: " + Score.ToString();
                txtBeurten.Text = "Beurten: " + Beurten.ToString();
                clicked_buttons = new Button[2];
                //else
                //{
                //    //Console.WriteLine("ze zijn niet hetzelfde");
                //    await Task.Delay(1000); // 1000 ms = 1 second    
                //}

            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            int minutes = time / 60;
            int seconds = time % 60;
            string time_text = "";
            if (minutes < 10)
            {
                time_text += "0" + minutes.ToString() + ":";
            }
            else
            {
                time_text += minutes.ToString() + ":";
            }
            if (seconds < 10)
            {
                time_text += "0" + seconds.ToString();
            }
            else
            {
                time_text += seconds.ToString();
            }
            txtTimer.Text = "Timer: " + time_text;
        }
    }
}
