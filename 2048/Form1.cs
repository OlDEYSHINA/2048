using System;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private bool _spawned;
        /// <summary>
        /// Высота потом ширина
        /// </summary>
        private int?[,] pole = new int?[4, 4];
        public Form1()
        {
            InitializeComponent();
            if (_spawned == false) SpawnSquares();

            KeyPreview = true;
            KeyPress +=
                Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ReadLabels();
            MoveSquares(e.KeyChar);
            SpawnNewSquare();
            WriteLabels();
        }

        /*   private void ReadLabels()
           {
               pole[0] = label1.Text;
               pole[1] = label2.Text;
               pole[2] = label3.Text;
               pole[3] = label4.Text;
               pole[4] = label5.Text;
               pole[5] = label6.Text;
               pole[6] = label7.Text;
               pole[7] = label8.Text;
               pole[8] = label9.Text;
               pole[9] = label10.Text;
               pole[10] = label11.Text;
               pole[11] = label12.Text;
               pole[12] = label13.Text;
               pole[13] = label14.Text;
               pole[14] = label15.Text;
               pole[15] = label16.Text;
           }*/

        private void WriteLabels()
        {
            label1.Text = pole[0, 0].ToString();
            label2.Text = pole[1, 0].ToString();
            label3.Text = pole[2, 0].ToString();
            label4.Text = pole[3, 0].ToString();
            label5.Text = pole[0, 1].ToString();
            label6.Text = pole[1, 1].ToString();
            label7.Text = pole[2, 1].ToString();
            label8.Text = pole[3, 1].ToString();
            label9.Text = pole[0, 2].ToString();
            label10.Text = pole[1, 2].ToString();
            label11.Text = pole[2, 2].ToString();
            label12.Text = pole[3, 2].ToString();
            label13.Text = pole[0, 3].ToString();
            label14.Text = pole[1, 3].ToString();
            label15.Text = pole[2, 3].ToString();
            label16.Text = pole[3, 3].ToString();
        }

        private void SpawnNewSquare()
        {
            var count = 0;
            while (count != 1)
            {
                var rand = new Random();
                var rand1 = rand.Next(0, 3); //y coordinate
                var rand2 = new Random();
                var rand3 = rand2.Next(0, 3); //x coordinate

                if (pole[rand1, rand3] == (null))
                {
                    pole[rand1, rand3] = 2;
                    count += 1;
                }
            }
        }
        private void SpawnSquares() //рандомайзер начала игры
        {
            for (var i = 0; i < 3; i++)
            {
                SpawnNewSquare();
            }
            _spawned = true;
        }

        private void PushUp()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var n = 0; n < 3; n++) //чтобы точно сдвинулись все
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[j, i] == null && pole[j + 1, i] != null)
                        {
                            pole[j, i] = pole[j + 1, i];
                            pole[j + 1, i] = null;
                        }
                    }
                }
            }
        }

        private void PushDown()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var n = 0; n < 3; n++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[j + 1, i] == null && pole[j, i] != null)
                        {
                            pole[j + 1, i] = pole[j, i];
                            pole[j, i] = null;
                        }
                    }
                }
            }
        }


        private void PushLeft()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var n = 0; n < 3; n++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[i, j] == null && pole[i, j + 1] != null)
                        {
                            pole[i, j] = pole[i, j + 1];
                            pole[i, j + 1] = null;
                        }
                    }
                }
            }
        }
        private void PushRight()
        {
            for (var i = 0; i < 4; i++)
            {
                for (var n = 0; n < 3; n++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[i, j + 1] == null && pole[i, j] != null)
                        {
                            pole[i, j + 1] = pole[i, j];
                            pole[i, j] = null;
                        }
                    }
                }
            }
        }

        private void MoveSquares(int moveKey)
        {
            if (moveKey == 119 || moveKey == 1094) //Up
            {
                PushUp();
                for (var i = 0; i < 4; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[j, i] == pole[j + 1, i]&& pole[j,i]!=null)
                        {
                            pole[j, i] += pole[j, i];
                            pole[j + 1, i] = null;
                        }
                    }
                }

                PushUp();
            }

            if (moveKey == 115 || moveKey == 1099) //down
            {
                PushDown();
                for (var i = 0; i < 4; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[j + 1, i] == pole[j, i] && pole[j, i] != null)
                        {
                            pole[j + 1, i] += pole[j + 1, i];
                            pole[j, i] = null;
                        }
                    }
                }

                PushDown();
            }

            if (moveKey == 1092 || moveKey == 97) //left
            {
                PushLeft();
                for (var i = 0; i < 4; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[ i,j] == pole[i, j+1] && pole[i, j+1] != null)
                        {
                            pole[i, j] += pole[i, j];
                            pole[i, j+1] = null;
                        }
                    }
                }
                PushLeft();
            }

            if (moveKey == 100 || moveKey == 1074) //right
            {
                PushRight();
                for (var i = 0; i < 4; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (pole[i, j+1] == pole[i, j] && pole[i, j] != null)
                        {
                            pole[i,j+1] += pole[i,j+1];
                            pole[i,j] = null;
                        }
                    }
                }
                PushRight();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //private void SumSquare(int j, int i)
        //{
        //    switch (pole[i + j * 4])
        //    {
        //        case "2":
        //            pole[i + j * 4] = "4";
        //            break;
        //        case "4":
        //            pole[i + j * 4] = "8";
        //            break;
        //        case "8":
        //            pole[i + j * 4] = "16";
        //            break;
        //        case "16":
        //            pole[i + j * 4] = "32";
        //            break;
        //        case "32":
        //            pole[i + j * 4] = "64";
        //            break;
        //        case "64":
        //            pole[i + j * 4] = "128";
        //            break;
        //    }
        //}

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}