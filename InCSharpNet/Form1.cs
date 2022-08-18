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

        public float A = 0;
        public float B = 0;
        public float C = 0;
        public float D = 0;
        public float E = 0;
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

            if (A < 0 || A > 180)
            {
                labelWarning2.Visible = true;
            }

            if (A >= 0 && A <= 180)
            {
                labelWarning2.Visible = false;
            }

            if (B < 0 || C < 0 || D < 0 || E < 0 )
            {
                labelWarning3.Visible = true;
            }
            else
            {
                labelWarning3.Visible = false;
            }

            if (valueCounter != 2)
            {
                labelWarning1.Visible = true;
            }

            if (valueCounter == 2 && (A >= 0 && A <= 180))
            {
                button2.Enabled = true;
                labelWarning1.Visible = false;

                if (aIsTrue && bIsTrue && B >= 0)
                {
                    C = B * (float)Math.PI * (A / 180);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxC.Text = C.ToString();
                    textBoxD.Text = D.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (aIsTrue && cIsTrue && C >= 0)
                {
                    B = (C * 180) / (A * (float)Math.PI);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxB.Text = B.ToString();
                    textBoxD.Text = D.ToString();
                    textBoxE.Text = E.ToString();

                }
                else if (aIsTrue && dIsTrue && D >= 0)
                {
                    B = D / (2 * (float)Math.Sin((A / 2) * (Math.PI / 180)));
                    C = B * (float)Math.PI * (A / 180);
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxB.Text = B.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (aIsTrue && eIsTrue && E >= 0)
                {
                    B = (float)Math.Sqrt((E * 360) / ((float)Math.PI * A));
                    C = B * (float)Math.PI * (A / 180);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));

                    textBoxB.Text = B.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxD.Text = D.ToString();
                }
                else if (bIsTrue && cIsTrue && B >= 0 && C >= 0)
                {
                    A = C / B * (180 / (float)Math.PI);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxA.Text = A.ToString();
                    textBoxD.Text = D.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (bIsTrue && dIsTrue && B >= 0 && D >= 0)
                {
                    A = 2 * (float)Math.Asin(D / (2 * B)) * (180 / (float)Math.PI);
                    C = B * (float)Math.PI * (A / 180);
                    E = B * B * (float)Math.PI * (A / 360);

                    textBoxA.Text = A.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (bIsTrue && eIsTrue && B >= 0 && E >= 0)
                {
                    A = E / (B * B) / (float)Math.PI * 360;
                    C = B * (float)Math.PI * (A / 180);
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));

                    textBoxA.Text = A.ToString();
                    textBoxC.Text = C.ToString();
                    textBoxD.Text = D.ToString();
                }
                else if (cIsTrue && dIsTrue && C >= 0 && D >= 0)
                {
                    float temp1 = 0;
                    float temp2 = 100;
                    for(double i = 1; i < 181; i = i + 0.1)
                    {
                        temp1 = (C * 2 * (float)Math.Sin(((float)i/2) * (Math.PI / 180))) - ((float)i * ((float)Math.PI / 180) * D);
                        if (temp1 < 0)
                        {
                            temp1 = temp1 * -1;
                        }
                        if(temp1 < temp2)
                        {
                            temp2 = temp1;
                            A = (float)i;
                        }
                    }

                    B = (C * 180) / (A * (float)Math.PI);
                    E = B * B * (float)Math.PI * (A / 360);

                    labelNotification1.Visible = true;

                    textBoxA.Text = A.ToString();
                    textBoxB.Text = B.ToString();
                    textBoxE.Text = E.ToString();
                }
                else if (cIsTrue && eIsTrue && C >= 0 && E >= 0)
                {
                    B = (E * 2) / C;
                    A = E / (B * B) / (float)Math.PI * 360;
                    D = 2 * B * (float)Math.Sin((A / 2) * (Math.PI / 180));

                    textBoxA.Text = A.ToString();
                    textBoxB.Text = B.ToString();
                    textBoxD.Text = D.ToString();
                }
                else if (dIsTrue && eIsTrue && D >= 0 && E >= 0)
                {
                    float temp1 = 0;
                    float temp2 = 100;
                    for(double i = 1; i < 181 ; i = i + 0.1)
                    {
                        temp1 = (D / (2 * (float)Math.Sin((i / 2) * (Math.PI / 180)))) - ((float)Math.Sqrt((E * 360) / ((float)Math.PI * i)));
                        if (temp1 < 0)
                        {
                            temp1 = temp1 * -1;
                        }
                        if(temp1 < temp2)
                        {
                            temp2 = temp1;
                            A = (float)i;
                        }
                    }

                    B = (float)Math.Sqrt((E * 360) / ((float)Math.PI * A));
                    C = B * (float)Math.PI * (A / 180);

                    labelNotification1.Visible = true;

                    textBoxA.Text = A.ToString();
                    textBoxB.Text = B.ToString();
                    textBoxC.Text = C.ToString();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string aText = textBoxA.Text;
            Single.TryParse(aText, out A);

            if (A >= 0 && A <= 180)
            {
                Point p1, p2;
                Pen myPen1 = new Pen(Color.Black, 1);
                Pen myPen2 = new Pen(Color.OrangeRed, 2);
                Pen myPen3 = new Pen(Color.Blue, 2);
                Pen myPen4 = new Pen(Color.DarkOrchid, 2);
                Pen myPen5 = new Pen(Color.ForestGreen, 2);

                Font drawFont = new Font("Arial", 15);

                SolidBrush drawBrush2 = new SolidBrush(Color.OrangeRed);
                SolidBrush drawBrush3 = new SolidBrush(Color.Blue);
                SolidBrush drawBrush4 = new SolidBrush(Color.DarkOrchid);
                SolidBrush drawBrush5 = new SolidBrush(Color.ForestGreen);

                StringFormat drawFormat = new StringFormat();
                drawFormat.Alignment = StringAlignment.Center;

                p1 = new Point();
                p2 = new Point();

                p1.X = 500;
                p1.Y = 180;
                p2.X = 650;
                p2.Y = 180;

                float p3X = ((float)Math.Cos(A * (Math.PI / 180))) * 150;
                float p3Y = ((float)Math.Sin(A * (Math.PI / 180))) * 150;

                Graphics g = this.CreateGraphics();
                g.Clear(Color.Linen);
                g.DrawLine(myPen2, p1, p2);
                g.DrawLine(myPen2, p1.X, p1.Y, p3X + p1.X, -p3Y + p1.Y);
                g.DrawLine(myPen5, p2.X, p2.Y, p3X + p1.X, -p3Y + p1.Y);
                g.DrawArc(myPen3, 350, 30, 300, 300, 0, -A);
                g.DrawArc(myPen4, 470, 150, 60, 60, 0, -A);
                g.DrawArc(myPen1, 350, 30, 300, 300, 0, 360);
                g.DrawString("r", drawFont, drawBrush2, p2.X - 90, p2.Y - 3, drawFormat);
                g.DrawString("α", drawFont, drawBrush4, p1.X + 20, p1.Y - 21, drawFormat);
                g.DrawString("s", drawFont, drawBrush5, p2.X + 10, p2.Y - 16, drawFormat);
                g.DrawString("b", drawFont, drawBrush3, p3X + p1.X - 17, -p3Y + p1.Y - 23, drawFormat);
            }

            if (A < 0 || A > 180)
            {
                labelWarning2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A = 0;
            B = 0;
            C = 0;
            D = 0;
            E = 0;

            textBoxA.Text = null;
            textBoxB.Text = null;
            textBoxC.Text = null;
            textBoxD.Text = null;
            textBoxE.Text = null;
        }
    }
}
