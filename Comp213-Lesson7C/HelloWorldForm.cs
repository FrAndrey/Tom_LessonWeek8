using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp213_Lesson7C
{
    public partial class HelloWorldForm : Form
    {
        /// <summary>
        /// This is the constuctor for the HelloWorld Form
        /// </summary>
        public HelloWorldForm()
        {
            InitializeComponent();
            Start();
        }
        /// <summary>
        /// This method initializes Form and Control properties
        /// </summary>
        public void Start()
        {
            HelloWorldLabel.Text = "Hello, Andrey!";
            HelloWorldLabel.BackColor = Color.Yellow;
            HelloWorldLabel.ForeColor = Color.Black;
      



        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = (HelloWorldLabel.Text == "Clicked") ? "Unclicked" : "Clicked";
            generateRandomNumber();
          
        }


        private void generateRandomNumber()
        {
            Random rand = new Random();
            int number = rand.Next(1, 99);
            AnotherOneLabel.Text = (AnotherOneLabel.Text == "Clicked") ? $"{number}" : $"{number}";

            //OR
            // Random rand = new Random();
            //int number = rand.Next(1, 99);
            //AnotheOneLabel.Text = number.ToString();




        }









        private void AnotherOneLabel_Click(object sender, EventArgs e)
        {
        
        }
    }
}
