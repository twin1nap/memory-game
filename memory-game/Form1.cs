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
        Button[] clicked_buttons = new Button[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.FlatAppearance.BorderColor = Color.Red;

            if (btn_count < 2)
            {
                btn_count++;
                button.FlatAppearance.BorderSize = 3;
            }

            clicked_buttons.Append(button);
            if (btn_count == 2)
            {
                if (clicked_buttons[0].Image == clicked_buttons[1].Image)
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
