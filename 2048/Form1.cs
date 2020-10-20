using System;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private bool _spawned;
        private readonly string[] pole = new string[16];

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
            ReadLabels();
            MoveSquares(e.KeyChar);
            SpawnNewSquare();
            WriteLabels();
            label1.
        }

        private void ReadLabels()
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
        }

        private void WriteLabels()
        {
            label1.Text = pole[0];
            label2.Text = pole[1];
            label3.Text = pole[2];
            label4.Text = pole[3];
            label5.Text = pole[4];
            label6.Text = pole[5];
            label7.Text = pole[6];
            label8.Text = pole[7];
            label9.Text = pole[8];
            label10.Text = pole[9];
            label11.Text = pole[10];
            label12.Text = pole[11];
            label13.Text = pole[12];
            label14.Text = pole[13];
            label15.Text = pole[14];
            label16.Text = pole[15];
        }

        private void SpawnNewSquare()
        {
            var count = 0;
            while (count != 1)
            {
                var rand = new Random();
                var rand1 = rand.Next(1, 16);


                switch (rand1)
                {
                    case 1:
                        if (pole[0] == " ")
                        {
                            pole[0] = "2";
                            count++;
                        }

                        break;
                    case 2:
                        if (pole[1] == " ")
                        {
                            pole[1] = "2";
                            count++;
                        }

                        break;
                    case 3:
                        if (pole[2] == " ")
                        {
                            pole[2] = "2";
                            count++;
                        }

                        break;
                    case 4:
                        if (pole[3] == " ")
                        {
                            pole[3] = "2";
                            count++;
                        }

                        break;
                    case 5:
                        if (pole[4] == " ")
                        {
                            pole[4] = "2";
                            count++;
                        }

                        break;
                    case 6:
                        if (pole[5] == " ")
                        {
                            pole[5] = "2";
                            count++;
                        }

                        break;
                    case 7:
                        if (pole[6] == " ")
                        {
                            pole[6] = "2";
                            count++;
                        }

                        break;
                    case 8:
                        if (pole[7] == " ")
                        {
                            pole[7] = "2";
                            count++;
                        }

                        break;
                    case 9:
                        if (pole[8] == " ")
                        {
                            pole[8] = "2";
                            count++;
                        }

                        break;
                    case 10:
                        if (pole[9] == " ")
                        {
                            pole[9] = "2";
                            count++;
                        }

                        break;
                    case 11:
                        if (pole[10] == " ")
                        {
                            pole[10] = "2";
                            count++;
                        }

                        break;
                    case 12:
                        if (pole[11] == " ")
                        {
                            pole[11] = "2";
                            count++;
                        }

                        break;
                    case 13:
                        if (pole[12] == " ")
                        {
                            pole[12] = "2";
                            count++;
                        }

                        break;
                    case 14:
                        if (pole[13] == " ")
                        {
                            pole[13] = "2";
                            count++;
                        }

                        break;
                    case 15:
                        if (pole[14] == " ")
                        {
                            pole[14] = "2";
                            count++;
                        }

                        break;
                    case 16:
                        if (pole[15] == " ")
                        {
                            pole[15] = "2";
                            count++;
                        }

                        break;
                }
            }
        }
        private void SpawnSquares() //рандомайзер начала игры
        {
            var count = 0;

            while (count != 3)
            {
                var rand = new Random();
                var rand1 = rand.Next(1, 16);

                switch (rand1)
                {
                    case 1:
                        if (label1.Text == " ")
                        {
                            label1.Text = "2";
                            count++;
                        }

                        break;
                    case 2:
                        if (label2.Text == " ")
                        {
                            label2.Text = "2";
                            count++;
                        }

                        break;
                    case 3:
                        if (label3.Text == " ")
                        {
                            label3.Text = "2";
                            count++;
                        }

                        break;
                    case 4:
                        if (label4.Text == " ")
                        {
                            label4.Text = "2";
                            count++;
                        }

                        break;
                    case 5:
                        if (label5.Text == " ")
                        {
                            label5.Text = "2";
                            count++;
                        }

                        break;
                    case 6:
                        if (label6.Text == " ")
                        {
                            label6.Text = "2";
                            count++;
                        }

                        break;
                    case 7:
                        if (label7.Text == " ")
                        {
                            label7.Text = "2";
                            count++;
                        }

                        break;
                    case 8:
                        if (label8.Text == " ")
                        {
                            label8.Text = "2";
                            count++;
                        }

                        break;
                    case 9:
                        if (label9.Text == " ")
                        {
                            label9.Text = "2";
                            count++;
                        }

                        break;
                    case 10:
                        if (label10.Text == " ")
                        {
                            label10.Text = "2";
                            count++;
                        }

                        break;
                    case 11:
                        if (label11.Text == " ")
                        {
                            label11.Text = "2";
                            count++;
                        }

                        break;
                    case 12:
                        if (label12.Text == " ")
                        {
                            label12.Text = "2";
                            count++;
                        }

                        break;
                    case 13:
                        if (label13.Text == " ")
                        {
                            label13.Text = "2";
                            count++;
                        }

                        break;
                    case 14:
                        if (label14.Text == " ")
                        {
                            label14.Text = "2";
                            count++;
                        }

                        break;
                    case 15:
                        if (label15.Text == " ")
                        {
                            label15.Text = "2";
                            count++;
                        }

                        break;
                    case 16:
                        if (label16.Text == " ")
                        {
                            label16.Text = "2";
                            count++;
                        }

                        break;
                }
            }

            _spawned = true;
        }

        private void PushUp()
        {
            for (var j = 0; j < 4; j++)
                for (var i = 3; i >= 1; i--)
                    if (pole[i + j * 4] != " " && pole[i - 1 + j * 4] == " ")
                    {
                        pole[i - 1 + j * 4] = pole[i + j * 4];
                        pole[i + j * 4] = " ";
                    }
        }

        private void PushDown()
        {
            for (var j = 0; j < 4; j++)
                for (var i = 1; i <= 3; i++)
                    if (pole[i - 1 + j * 4] != " " && pole[i + j * 4] == " ")
                    {
                        pole[i + j * 4] = pole[i - 1 + j * 4];
                        pole[i - 1 + j * 4] = " ";
                    }
        }


        private void PushLeft()
        {
            for (var n = 0; n < 2; n++)
            {
                for (var i = 0; i < 4; i++) //Высота
                for (var j = 3; j >= 1; j--) //Ширина
                    if (pole[i + j * 4] != " " && pole[i + (j - 1) * 4] == " ")
                    {
                        pole[i + (j - 1) * 4] = pole[i + j * 4];
                        pole[i + j * 4] = " ";

                    }
            }
        }
        private void PushRight()
        {
            for (var i = 0; i < 4; i++)
                for (var j = 1; j <= 3; j++)
                    if (pole[i + (j - 1) * 4] != " " && pole[i + j * 4] == " ")
                    {
                        pole[i + j * 4] = pole[i + (j - 1) * 4];
                        pole[i + (j - 1) * 4] = " ";
                    }
        }

        private void MoveSquares(int moveKey)
        {
            if (moveKey == 119 || moveKey == 1094) //Up
            {
                PushUp();

                for (var j = 0;
                    j < 4;
                    j++) //проверяет сверху вниз,слева направо соседние в вертикали клетки на наличие одинаковых чисел
                    for (var i = 0; i < 3; i++)
                    {
                        if (pole[i + j * 4] == pole[i + 1 + j * 4])
                        {
                            pole[i + 1 + j * 4] = " ";

                            SumSquare(j, i);
                        }

                        ;
                    }

                PushUp();
            }

            if (moveKey == 115 || moveKey == 1099) //down
            {
                PushDown();
                for (var j = 0; j < 4; j++)
                    for (var i = 0; i < 3; i++)
                        if (pole[i + j * 4] == pole[i + 1 + j * 4])
                        {
                            pole[i + 1 + j * 4] = " ";
                            SumSquare(j, i);
                        }

                PushDown();
            }

            if (moveKey == 1092 || moveKey == 97) //left
            {
                PushLeft();
                for (var i = 0; i < 4; i++)
                    for (var j = 0; j < 3; j++)
                        if (pole[i + j * 4] == pole[i + (j + 1) * 4] && pole[i + j * 4] != " ")
                        {
                            pole[i + (j + 1) * 4] = " ";
                            SumSquare(j, i);
                        }
                PushLeft();
            }

            if (moveKey == 100 || moveKey == 1074) //right
            {
                PushRight();
                for (var i = 0; i < 4; i++)
                    for (var j = 2; j >= 0; j--)
                        if (pole[i + j * 4] == pole[i + (j + 1) * 4])
                        {
                            pole[i + (j) * 4] = " ";
                            SumSquare(j + 1, i);
                        }
                PushRight();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SumSquare(int j, int i)
        {
            switch (pole[i + j * 4])
            {
                case "2":
                    pole[i + j * 4] = "4";
                    break;
                case "4":
                    pole[i + j * 4] = "8";
                    break;
                case "8":
                    pole[i + j * 4] = "16";
                    break;
                case "16":
                    pole[i + j * 4] = "32";
                    break;
                case "32":
                    pole[i + j * 4] = "64";
                    break;
                case "64":
                    pole[i + j * 4] = "128";
                    break;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}