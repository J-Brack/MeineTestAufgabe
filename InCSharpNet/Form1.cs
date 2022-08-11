using System;
using System.Drawing;
using System.Windows.Forms;

namespace InCSharpNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float A = 1;
        public float B = 0;
        public float C = 0;
        public float D = 0;
        public float E = 0;
        public float height = 0;
        public int valueCounter = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            string aText = textBoxA.Text;
            string bText = textBoxB.Text;
            string cText = textBoxC.Text;
            string dText = textBoxD.Text;
            string eText = textBoxE.Text;

            bool aIsTrue = false;
            bool bIsTrue = false;
            bool cIsTrue = false;
            bool dIsTrue = false;
            bool eIsTrue = false;

            int valueCounter = 0;

            if (Single.TryParse(aText, out A))
            {
                aIsTrue = true;
                valueCounter++;
            }

            if (Single.TryParse(bText, out B))
            {
                bIsTrue = true;
                valueCounter++;
            }

            if (Single.TryParse(cText, out C))
            {
                cIsTrue = true;
                valueCounter++;
            }

            if (Single.TryParse(dText, out D))
            {
                dIsTrue = true;
                valueCounter++;
            }

            if (Single.TryParse(eText, out E))
            {
                eIsTrue = true;
                valueCounter++;
            }

            if (A < 0 || A > 360)
            {
                labelWarning2.Visible = true;
            }

            if (A > 0 && A < 360)
            {
                labelWarning2.Visible = false;
            }

            if (valueCounter != 2)
            {
                labelWarning1.Visible = true;
            }

            if (valueCounter == 2 && A > 0 && A < 360)
            {
                button2.Visible = true;
                labelWarning1.Visible = false;

                if (aIsTrue && bIsTrue)
                {
                    C = B * (float)Math.PI * (A / 180);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxC.Text = C.ToString();
                    textBoxD.Text = D.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (aIsTrue && cIsTrue)
                {
                    B = (C * 180) / (A * (float)Math.PI);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxB.Text = B.ToString();
                    textBoxD.Text = D.ToString();
                    textBoxE.Text = E.ToString();

                }
                else if (aIsTrue && dIsTrue)
                {
                    B = D / (2 * (float)Math.Sin((A / 2) * (Math.PI / 180)));
                    C = B * (float)Math.PI * (A / 180);
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxB.Text = B.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (aIsTrue && eIsTrue)
                {
                    B = (float)Math.Sqrt(E / Math.PI / 360 * A);
                    C = B * (float)Math.PI * (A / 180);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));

                    textBoxB.Text = B.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxD.Text = D.ToString();
                }
                else if (bIsTrue && cIsTrue)
                {
                    A = C / B * (180 / (float)Math.PI);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxA.Text = A.ToString();
                    textBoxD.Text = D.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (bIsTrue && dIsTrue)
                {
                    A = (2 * B - (float)Math.Sqrt((4 * B * B) - D * D)) / 2;
                    C = B * (float)Math.PI * (A / 180);
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxA.Text = A.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (bIsTrue && eIsTrue)
                {
                    A = E / (B * B) / (float)Math.PI * 360;
                    C = B * (float)Math.PI * (A / 180);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));

                    textBoxA.Text = A.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxD.Text = D.ToString();
                }
                else if (cIsTrue && dIsTrue)
                {
                    height = C - D;
                    B = ((4 * height * height) + (D * D)) / (8 * height);
                    A = C / B * (180 / (float)Math.PI);
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxA.Text = A.ToString();
                    textBoxB.Text = B.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (cIsTrue && eIsTrue)
                {

                    textBoxA.Text = A.ToString();
                    textBoxB.Text = B.ToString();
                    textBoxD.Text = D.ToString();
                }
                else if (dIsTrue && eIsTrue)
                {

                    textBoxA.Text = A.ToString();
                    textBoxB.Text = B.ToString();
                    textBoxC.Text = C.ToString();
                }
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Point p1, p2;
            Pen myPen = new Pen(Color.Black, 1);
            p1 = new Point();
            p2 = new Point();
            p1.X = 500;
            p1.Y = 180;
            p2.X = 650;
            p2.Y = 180;
            float p3X = ((float)Math.Cos(A * (Math.PI / 180))) * 150;
            float p3Y = ((float)Math.Sin(A * (Math.PI / 180))) * 150;
            Graphics g = this.CreateGraphics();
            g.DrawLine(myPen, p1, p2);
            g.DrawLine(myPen, p1.X, p1.Y, p3X+p1.X, -p3Y+p1.Y);
            g.DrawArc(myPen, 350, 30, 300, 300, 0, -A);
        }
    }
}
