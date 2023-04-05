namespace kalkulator_wielomianowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.WspolczynnikATextBox = new System.Windows.Forms.TextBox();
            this.WspolczynnikCTextBox = new System.Windows.Forms.TextBox();
            this.WspolczynnikBTextBox = new System.Windows.Forms.TextBox();
            this.X2TextBox = new System.Windows.Forms.TextBox();
            this.X1TextBox = new System.Windows.Forms.TextBox();
            this.DeltaTextBox = new System.Windows.Forms.TextBox();
            this.ObliczButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WspolczynnikFTextBox = new System.Windows.Forms.TextBox();
            this.WspolczynnikGTextBox = new System.Windows.Forms.TextBox();
            this.WspolczynnikDTextBox = new System.Windows.Forms.TextBox();
            this.DodajButton = new System.Windows.Forms.Button();
            this.OdejmijButton = new System.Windows.Forms.Button();
            this.WynikTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DzialanieTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ObliczButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // WspolczynnikATextBox
            // 
            this.WspolczynnikATextBox.Location = new System.Drawing.Point(26, 68);
            this.WspolczynnikATextBox.Name = "WspolczynnikATextBox";
            this.WspolczynnikATextBox.Size = new System.Drawing.Size(202, 20);
            this.WspolczynnikATextBox.TabIndex = 0;
            this.WspolczynnikATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WspolczynnikCTextBox
            // 
            this.WspolczynnikCTextBox.Location = new System.Drawing.Point(26, 143);
            this.WspolczynnikCTextBox.Name = "WspolczynnikCTextBox";
            this.WspolczynnikCTextBox.Size = new System.Drawing.Size(202, 20);
            this.WspolczynnikCTextBox.TabIndex = 1;
            this.WspolczynnikCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WspolczynnikBTextBox
            // 
            this.WspolczynnikBTextBox.Location = new System.Drawing.Point(26, 105);
            this.WspolczynnikBTextBox.Name = "WspolczynnikBTextBox";
            this.WspolczynnikBTextBox.Size = new System.Drawing.Size(202, 20);
            this.WspolczynnikBTextBox.TabIndex = 2;
            this.WspolczynnikBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // X2TextBox
            // 
            this.X2TextBox.Location = new System.Drawing.Point(274, 143);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.Size = new System.Drawing.Size(202, 20);
            this.X2TextBox.TabIndex = 3;
            // 
            // X1TextBox
            // 
            this.X1TextBox.Location = new System.Drawing.Point(274, 105);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.Size = new System.Drawing.Size(202, 20);
            this.X1TextBox.TabIndex = 4;
            // 
            // DeltaTextBox
            // 
            this.DeltaTextBox.Location = new System.Drawing.Point(274, 68);
            this.DeltaTextBox.Name = "DeltaTextBox";
            this.DeltaTextBox.Size = new System.Drawing.Size(202, 20);
            this.DeltaTextBox.TabIndex = 5;
            // 
            // ObliczButton1
            // 
            this.ObliczButton1.Location = new System.Drawing.Point(401, 44);
            this.ObliczButton1.Name = "ObliczButton1";
            this.ObliczButton1.Size = new System.Drawing.Size(75, 23);
            this.ObliczButton1.TabIndex = 6;
            this.ObliczButton1.Text = "Oblicz Delte";
            this.ObliczButton1.UseVisualStyleBackColor = true;
            this.ObliczButton1.Click += new System.EventHandler(this.ObliczButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "WspółczynnikA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "WspółczynnikB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "WspółczynnikC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(271, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(271, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(271, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "X2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(26, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wielomian1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(26, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Wielomian2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(26, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "WspółczynnikF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(26, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "WspółczynnikE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(26, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "WspółczynnikD";
            // 
            // WspolczynnikFTextBox
            // 
            this.WspolczynnikFTextBox.Location = new System.Drawing.Point(26, 278);
            this.WspolczynnikFTextBox.Name = "WspolczynnikFTextBox";
            this.WspolczynnikFTextBox.Size = new System.Drawing.Size(202, 20);
            this.WspolczynnikFTextBox.TabIndex = 16;
            this.WspolczynnikFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WspolczynnikGTextBox
            // 
            this.WspolczynnikGTextBox.Location = new System.Drawing.Point(26, 316);
            this.WspolczynnikGTextBox.Name = "WspolczynnikGTextBox";
            this.WspolczynnikGTextBox.Size = new System.Drawing.Size(202, 20);
            this.WspolczynnikGTextBox.TabIndex = 15;
            this.WspolczynnikGTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WspolczynnikDTextBox
            // 
            this.WspolczynnikDTextBox.Location = new System.Drawing.Point(26, 241);
            this.WspolczynnikDTextBox.Name = "WspolczynnikDTextBox";
            this.WspolczynnikDTextBox.Size = new System.Drawing.Size(202, 20);
            this.WspolczynnikDTextBox.TabIndex = 14;
            this.WspolczynnikDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(308, 241);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(154, 23);
            this.DodajButton.TabIndex = 21;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // OdejmijButton
            // 
            this.OdejmijButton.Location = new System.Drawing.Point(308, 275);
            this.OdejmijButton.Name = "OdejmijButton";
            this.OdejmijButton.Size = new System.Drawing.Size(154, 23);
            this.OdejmijButton.TabIndex = 22;
            this.OdejmijButton.Text = "Odejmij";
            this.OdejmijButton.UseVisualStyleBackColor = true;
            this.OdejmijButton.Click += new System.EventHandler(this.OdejmijButton_Click);
            // 
            // WynikTextBox
            // 
            this.WynikTextBox.Location = new System.Drawing.Point(26, 491);
            this.WynikTextBox.Name = "WynikTextBox";
            this.WynikTextBox.Size = new System.Drawing.Size(450, 20);
            this.WynikTextBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(26, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Wynik";
            // 
            // DzialanieTextBox
            // 
            this.DzialanieTextBox.Location = new System.Drawing.Point(26, 418);
            this.DzialanieTextBox.Name = "DzialanieTextBox";
            this.DzialanieTextBox.Size = new System.Drawing.Size(450, 20);
            this.DzialanieTextBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(26, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Działanie";
            // 
            // ObliczButton2
            // 
            this.ObliczButton2.Location = new System.Drawing.Point(337, 444);
            this.ObliczButton2.Name = "ObliczButton2";
            this.ObliczButton2.Size = new System.Drawing.Size(139, 23);
            this.ObliczButton2.TabIndex = 27;
            this.ObliczButton2.Text = "Oblicz";
            this.ObliczButton2.UseVisualStyleBackColor = true;
            this.ObliczButton2.Click += new System.EventHandler(this.ObliczButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(508, 572);
            this.Controls.Add(this.ObliczButton2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DzialanieTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.WynikTextBox);
            this.Controls.Add(this.OdejmijButton);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.WspolczynnikFTextBox);
            this.Controls.Add(this.WspolczynnikGTextBox);
            this.Controls.Add(this.WspolczynnikDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObliczButton1);
            this.Controls.Add(this.DeltaTextBox);
            this.Controls.Add(this.X1TextBox);
            this.Controls.Add(this.X2TextBox);
            this.Controls.Add(this.WspolczynnikBTextBox);
            this.Controls.Add(this.WspolczynnikCTextBox);
            this.Controls.Add(this.WspolczynnikATextBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator Wielomianowy";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ObliczButton1;
        private System.Windows.Forms.TextBox DeltaTextBox;
        private System.Windows.Forms.TextBox X1TextBox;
        private System.Windows.Forms.TextBox X2TextBox;
        private System.Windows.Forms.TextBox WspolczynnikBTextBox;
        private System.Windows.Forms.TextBox WspolczynnikCTextBox;
        private System.Windows.Forms.TextBox WspolczynnikATextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OdejmijButton;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox WspolczynnikFTextBox;
        private System.Windows.Forms.TextBox WspolczynnikGTextBox;
        private System.Windows.Forms.TextBox WspolczynnikDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox WynikTextBox;
        private System.Windows.Forms.Button ObliczButton2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DzialanieTextBox;
    }
}

