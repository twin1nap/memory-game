using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory_game
{
    public partial class game : Form
    {
        Random Random = new Random(); // random voor het randomize van de kaart pozities
        int Score = 0; // spreekt voor zich
        int Beurten = 0; // spreekt voor zich
        int time = 0; // spreekt voor zich
        int card_clicked_count = 0; // aantal kaarten ingedrukt
        Button[] clicked_buttons = new Button[2]; // welke kaarten ingedrukt
        Image[] card_img = new Image[16] //lijst met gesorteerde fotos
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
        string[] card_tags = new string[16] //lijst met gesorteerde tags
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

         void reset_cards() //funtie om alle kaarten om te draaien naar de achterkant.
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

        private void Form1_Load(object sender, EventArgs e)
        { 
            //shuffle cards using fisher-yates shuffle (learned from chatgpt creatued by typing for and tab and that made whole code)
            for (int i = card_img.Length - 1; i > 0; i--) //gaat elke kaart langs van rechts naar links
            {
                int j = Random.Next(i + 1); // de random index waarmee wordt geswapt

                Image temp = card_img[i]; //1e foto van het swappen onthouden
                card_img[i] = card_img[j]; // i swappen met j
                card_img[j] = temp; // j de 1e foto maken om het swappen helemaal te doen

                //hetzelfde als met de fotos aleen dan met de tags
                string temp_tag = card_tags[i]; 
                card_tags[i] = card_tags[j];
                card_tags[j] = temp_tag;
            }

            reset_cards(); //alle kaarten omdraaien aan het begin ban het spel

            //de tagstoevoegen aan de kaarten
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


        //game code
        private async void Card_Click(object sender, EventArgs e) //als er op een kaart wordt geklikt
        {
            Button card = sender as Button; //maar variabel van de geklikte kaart.

            SoundPlayer sp = new SoundPlayer(Properties.Resources.CardFlip); // sound sp(soundplayer) het geluid van kaartflip maken
            sp.Play(); // audio afspelen

            if (card_clicked_count < 2) //als je 0 of 1 kaart heb ingedrukt
            {
                card_clicked_count++; //1 bij het aantal geklikte kaarten
            }

            if (card_clicked_count == 1) // als het de eerste ingedrukte kaart os
            {

                if (timer.Enabled == false) //als de timer uit staat
                {
                    timer.Start(); //start de timer
                }

                clicked_buttons[0] = card;//onthou de eerste kaart

                //1e kaart omdraaien
                card.Image = card_img[int.Parse(card.Name.Substring(4)) -1]; //maak de foto van de eerste kaart de foto in de aray, de index is de naam van de knop min de eerste 4 letters, daar komt een nummer uit en daar wordt 1 vanaf gehaald want een array begint bij 0
            }
            else if (card_clicked_count == 2) // als je 2 kaarten heb ingedrukt
            {
                card_clicked_count = 3;//zorgt er voor dat er niets gebeurt bij de derde klik
                card.Image = card_img[int.Parse(card.Name.Substring(4)) - 1]; // 2e kaart omdraaien
                
                if (card != clicked_buttons[0]) // kijken of de eerste omgedraaide kaart niet dezelfde kaart is(dezelfde knop niet zelfde foto)
                {
                    clicked_buttons[1] = card; // 2e kaart opslaan


                    await Task.Delay(1000); // 1000 ms = 1 second //veranderen met timer //1 seconde wachten voor einde beurd
                    reset_cards(); // kaarten terug draaien
                

                    if (clicked_buttons[0].Tag == clicked_buttons[1].Tag) // na kaarten terug draaien kijken of ze dezelfde tag(en dus ook foto) hebben
                    {
                        //als ze hetzelfde zijn
                        //Console.WriteLine("ze zijn hetzelfde");
                        clicked_buttons[0].Visible = false; //1e geklikte kaard laten verdwijnen
                        clicked_buttons[1].Visible = false; //2e geklikte kaard laten verdwijnen
                        
                        Score += 10; // score verhogen wegens goede combo

                        if (Score >= 80) // kijken of de speler gewonnen heeft
                        {
                            timer.Stop(); //timer stoppen
                        }
                    }
                    Beurten++; // berut optellen

                    //beurt reseten
                    card_clicked_count = 0; // er voor zorgen dat je 
                    txtScore.Text = "Score: " + Score.ToString(); //score text updaten
                    txtBeurten.Text = "Beurten: " + Beurten.ToString(); // beruten text updaten
                    clicked_buttons = new Button[2]; // array met geklikte knoppen resetten

                    //else // als het niet dezelfde kaarten zijn
                    //{
                    //    //Console.WriteLine("ze zijn niet hetzelfde");
                    //    await Task.Delay(1000); // 1000 ms = 1 second    
                    //}
                }
                else // als de 1e en tweede geklikte kaart dezelfde kaatr is(dus dezelfde knop niet dezelfde foto)
                {
                    card_clicked_count = 1; // een beurt terug zodat de speler weer de 2e kaart kan kiezen
                }

            }

        }

        private void timer_Tick(object sender, EventArgs e) //elke seconden vam de timer
        {
            time++; // tijd met 1 verhogen
            int minutes = time / 60; //secondes delen door 60 voor minuten
            int seconds = time % 60; // alles wat over blijft na het delen door 60( dus als je 62 heb dan blijft er 2 over)
            string time_text = ""; // timer text leeg maken
            if (minutes < 10) // als er minder dan 10 minuten zijn
            {
                time_text += "0" + minutes.ToString() + ":"; // 0 zetten voor de voor de minuten en minuten text toevoegen aan tijd
            }
            else
            {
                time_text += minutes.ToString() + ":"; // minuten text(zonder 0 ervoor) toevoegen aan tijd
            }
            if (seconds < 10) // als er minder dan 10 seconden zijn
            {
                time_text += "0" + seconds.ToString(); // 0 zetten voor de voor de seconden en seconden text toevoegen aan tijd
            }
            else
            {
                time_text += seconds.ToString(); // seconden text(zonder 0 ervoor) toevoegen aan tijd
            }
            txtTimer.Text = "Timer: " + time_text; //timer updaten
        }
    }
}