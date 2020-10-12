using System;
using System.Windows.Forms;

namespace zmeyka
{
    public partial class Form1 : Form
    {
        Boolean spawned = false;
        
        public Form1()
        {
            InitializeComponent();

            if (spawned==false) SpawnSquare();

        }

        private void SpawnSquare()
        {
           
            
                int count = 0;

                while (count != 3)
                {
                    Random rand = new Random();
                    int rand1 = rand.Next(1, 16);
                    switch (rand1)
                    {
                        case 1:
                            if (label1.Text == " ") label1.Text = "2"; count++;
                            break;
                        case 2:
                            if (label2.Text == " ") label2.Text = "2"; count++;
                            break;
                        case 3:
                            if (label3.Text == " ") label3.Text = "2"; count++;
                            break;
                        case 4:
                            if (label4.Text == " ") label4.Text = "2"; count++;
                            break;
                        case 5:
                            if (label5.Text == " ") label5.Text = "2"; count++;
                            break;
                        case 6:
                            if (label6.Text == " ") label6.Text = "2"; count++;
                            break;
                        case 7:
                            if (label7.Text == " ") label7.Text = "2"; count++;
                            break;
                        case 8:
                            if (label8.Text == " ") label8.Text = "2"; count++;
                            break;
                        case 9:
                            if (label9.Text == " ") label9.Text = "2"; count++;
                            break;
                        case 10:
                            if (label10.Text == " ") label10.Text = "2"; count++;
                            break;
                        case 11:
                            if (label11.Text == " ") label11.Text = "2"; count++;
                            break;
                        case 12:
                            if (label12.Text == " ") label12.Text = "2"; count++;
                            break;
                        case 13:
                            if (label13.Text == " ") label13.Text = "2"; count++;
                            break;
                        case 14:
                            if (label14.Text == " ") label14.Text = "2"; count++;
                            break;
                        case 15:
                            if (label15.Text == " ") label15.Text = "2"; count++;
                            break;
                        case 16:
                            if (label16.Text == " ") label16.Text = "2"; count++;
                            break;
                        default:
                            break;
                    }
                
            }
            spawned = true;
        }
        private void MoveSquare(char moveKey)
        {
            if (moveKey == 'u')
            {

            }
            if (moveKey == 'd')
            {

            }
            if (moveKey == 'l')
            {

            }
            if (moveKey == 'r')
            {

            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            char key = 'n';
            if (e.KeyCode == Keys.Up) key = 'u';
            if (e.KeyCode == Keys.Down) key = 'd';
            if (e.KeyCode == Keys.Left) key = 'l';
            if (e.KeyCode == Keys.Right) key = 'r';
            MoveSquare(key);
        }
    }
}
