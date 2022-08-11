namespace InCSharpNet
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code
        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWarning1 = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(70, 41);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 2;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(70, 22);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 13);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "Winkel (A)";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(67, 94);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(94, 13);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "Schenkellänge (B)";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(70, 110);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Berechne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWarning1
            // 
            this.labelWarning1.AutoSize = true;
            this.labelWarning1.ForeColor = System.Drawing.Color.Red;
            this.labelWarning1.Location = new System.Drawing.Point(67, 266);
            this.labelWarning1.Name = "labelWarning1";
            this.labelWarning1.Size = new System.Drawing.Size(152, 13);
            this.labelWarning1.TabIndex = 7;
            this.labelWarning1.Text = "Geben Sie genau 2 Zahlen ein";
            this.labelWarning1.Visible = false;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(70, 165);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(80, 13);
            this.labelC.TabIndex = 8;
            this.labelC.Text = "Bogenlänge (C)";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(70, 181);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 9;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(218, 41);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 20);
            this.textBoxD.TabIndex = 10;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(218, 110);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 20);
            this.textBoxE.TabIndex = 11;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(215, 22);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(96, 13);
            this.labelD.TabIndex = 12;
            this.labelD.Text = "Sekantenlänge (D)";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(215, 94);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(86, 13);
            this.labelE.TabIndex = 13;
            this.labelE.Text = "Flächeninhalt (E)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Skizziere";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelWarning2
            // 
            this.labelWarning2.AutoSize = true;
            this.labelWarning2.ForeColor = System.Drawing.Color.Red;
            this.labelWarning2.Location = new System.Drawing.Point(67, 279);
            this.labelWarning2.Name = "labelWarning2";
            this.labelWarning2.Size = new System.Drawing.Size(216, 13);
            this.labelWarning2.TabIndex = 15;
            this.labelWarning2.Text = "Der Winkel muss zwischen 0 und 360 liegen";
            this.labelWarning2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWarning2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelWarning1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWarning1;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelWarning2;
    }
}

