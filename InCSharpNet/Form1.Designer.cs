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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelWarning3 = new System.Windows.Forms.Label();
            this.labelNotification1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(36, 60);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 2;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(33, 44);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 13);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "Winkel (α)";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(33, 94);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(90, 13);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "Schenkellänge (r)";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(36, 110);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 56);
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
            this.labelWarning1.Location = new System.Drawing.Point(33, 303);
            this.labelWarning1.Name = "labelWarning1";
            this.labelWarning1.Size = new System.Drawing.Size(148, 13);
            this.labelWarning1.TabIndex = 7;
            this.labelWarning1.Text = "Geben Sie genau 2 Werte ein";
            this.labelWarning1.Visible = false;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(33, 144);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(79, 13);
            this.labelC.TabIndex = 8;
            this.labelC.Text = "Bogenlänge (b)";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(36, 160);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 9;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(36, 210);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 20);
            this.textBoxD.TabIndex = 10;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(36, 260);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 20);
            this.textBoxE.TabIndex = 11;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(33, 194);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(93, 13);
            this.labelD.TabIndex = 12;
            this.labelD.Text = "Sekantenlänge (s)";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(33, 244);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(86, 13);
            this.labelE.TabIndex = 13;
            this.labelE.Text = "Flächeninhalt (A)";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(172, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Skizziere";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelWarning2
            // 
            this.labelWarning2.AutoSize = true;
            this.labelWarning2.ForeColor = System.Drawing.Color.Red;
            this.labelWarning2.Location = new System.Drawing.Point(33, 316);
            this.labelWarning2.Name = "labelWarning2";
            this.labelWarning2.Size = new System.Drawing.Size(216, 13);
            this.labelWarning2.TabIndex = 15;
            this.labelWarning2.Text = "Der Winkel muss zwischen 0 und 180 liegen";
            this.labelWarning2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Geben Sie zwei Größen eines Kreisauschnitts an, um die Restlichen berechnen zu la" +
    "ssen!";
            // 
            // labelWarning3
            // 
            this.labelWarning3.AutoSize = true;
            this.labelWarning3.ForeColor = System.Drawing.Color.Red;
            this.labelWarning3.Location = new System.Drawing.Point(33, 329);
            this.labelWarning3.Name = "labelWarning3";
            this.labelWarning3.Size = new System.Drawing.Size(174, 13);
            this.labelWarning3.TabIndex = 17;
            this.labelWarning3.Text = "Die Werte dürfen nicht negativ sein";
            this.labelWarning3.Visible = false;
            // 
            // labelNotification1
            // 
            this.labelNotification1.AutoSize = true;
            this.labelNotification1.Location = new System.Drawing.Point(33, 290);
            this.labelNotification1.Name = "labelNotification1";
            this.labelNotification1.Size = new System.Drawing.Size(301, 13);
            this.labelNotification1.TabIndex = 18;
            this.labelNotification1.Text = "Hinweiß: Bei dem Ergebnis handelt es sich um eine Schätzung";
            this.labelNotification1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Leeren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(685, 358);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelNotification1);
            this.Controls.Add(this.labelWarning3);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rechner für Kreisausschnitt";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWarning3;
        private System.Windows.Forms.Label labelNotification1;
        private System.Windows.Forms.Button button3;
    }
}

