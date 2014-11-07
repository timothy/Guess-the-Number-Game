using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_number_game
{
    public partial class Form1 : Form
    {


        static Random ranNum = new Random(); //this creats a random object
        public int CurrentGuess { get; set; }
        public int PreviousGuess { get; set; }
        public int RandomValue { get; set; }
       // This takes the number in the variable num and assigns RandomValue a random number inbeetween num and 0


        public Form1()
        {
            InitializeComponent();
            CurrentGuess = 0;
            PreviousGuess = 0;
            RandomValue = ranNum.Next(1000);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int number = 10000;

            //if (Convert.ToInt32(textBox1.Text) == number)
            //    number = Convert.ToInt32(textBox1.Text);

            //if (Convert.ToInt32(textBox1.Text) < RandomValue)
            //{

            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                PreviousGuess = CurrentGuess;
                CurrentGuess = Convert.ToInt32(textBox1.Text);

                if (RandomValue < CurrentGuess)
                label4.Text = "To High!!";

                else if (RandomValue > CurrentGuess)
                    label4.Text = "To Low!!";

                else if (RandomValue == CurrentGuess)
                    label4.Text = "^_^ You Did It!!!";


                if (Math.Abs(RandomValue - PreviousGuess) >  Math.Abs(RandomValue - CurrentGuess))
                {
                    this.BackColor = Color.Red;
                    // Your getting wormer
                }
                else if (Math.Abs(RandomValue - PreviousGuess) < Math.Abs(RandomValue - CurrentGuess))
                {
                    this.BackColor = Color.Blue;
                    // Your Getting coulder
                }
                else if (CurrentGuess == RandomValue)
                {
                    this.BackColor = Color.Green;
                    //You did it!!
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomValue = ranNum.Next(1000);
            label4.Text = "";
            this.BackColor = SystemColors.Control;
        }
    }
}
