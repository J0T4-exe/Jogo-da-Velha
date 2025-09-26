namespace Projeto2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn11 = new Button();
            btn21 = new Button();
            btn12 = new Button();
            btn13 = new Button();
            btn31 = new Button();
            btn22 = new Button();
            btn23 = new Button();
            btn32 = new Button();
            btn33 = new Button();
            btnReiniciar = new Button();
            lbl_title = new Label();
            lbl_rounds = new Label();
            lbl_rounds1 = new Label();
            SuspendLayout();
            // 
            // btn11
            // 
            btn11.Location = new Point(87, 31);
            btn11.Name = "btn11";
            btn11.Size = new Size(123, 107);
            btn11.TabIndex = 0;
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += button1_Click;
            // 
            // btn21
            // 
            btn21.Location = new Point(88, 144);
            btn21.Name = "btn21";
            btn21.Size = new Size(123, 107);
            btn21.TabIndex = 1;
            btn21.UseVisualStyleBackColor = true;
            btn21.Click += button1_Click_1;
            // 
            // btn12
            // 
            btn12.Location = new Point(216, 31);
            btn12.Name = "btn12";
            btn12.Size = new Size(123, 107);
            btn12.TabIndex = 2;
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn12_Click;
            // 
            // btn13
            // 
            btn13.Location = new Point(345, 31);
            btn13.Name = "btn13";
            btn13.Size = new Size(123, 107);
            btn13.TabIndex = 3;
            btn13.UseVisualStyleBackColor = true;
            btn13.Click += btn13_Click;
            // 
            // btn31
            // 
            btn31.Location = new Point(87, 257);
            btn31.Name = "btn31";
            btn31.Size = new Size(123, 107);
            btn31.TabIndex = 4;
            btn31.UseVisualStyleBackColor = true;
            btn31.Click += btn31_Click;
            // 
            // btn22
            // 
            btn22.Location = new Point(217, 144);
            btn22.Name = "btn22";
            btn22.Size = new Size(123, 107);
            btn22.TabIndex = 5;
            btn22.UseVisualStyleBackColor = true;
            btn22.Click += btn22_Click;
            // 
            // btn23
            // 
            btn23.Location = new Point(346, 144);
            btn23.Name = "btn23";
            btn23.Size = new Size(123, 107);
            btn23.TabIndex = 6;
            btn23.UseVisualStyleBackColor = true;
            btn23.Click += btn23_Click;
            // 
            // btn32
            // 
            btn32.Location = new Point(216, 257);
            btn32.Name = "btn32";
            btn32.Size = new Size(123, 107);
            btn32.TabIndex = 7;
            btn32.UseVisualStyleBackColor = true;
            btn32.Click += btn32_Click;
            // 
            // btn33
            // 
            btn33.Location = new Point(345, 257);
            btn33.Name = "btn33";
            btn33.Size = new Size(123, 107);
            btn33.TabIndex = 8;
            btn33.UseVisualStyleBackColor = true;
            btn33.Click += btn33_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(87, 385);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(380, 46);
            btnReiniciar.TabIndex = 9;
            btnReiniciar.Text = "REINICIAR JOGO";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(228, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(95, 15);
            lbl_title.TabIndex = 10;
            lbl_title.Text = "JOGO DA VELHA";
            // 
            // lbl_rounds
            // 
            lbl_rounds.AutoSize = true;
            lbl_rounds.Location = new Point(87, 473);
            lbl_rounds.Name = "lbl_rounds";
            lbl_rounds.Size = new Size(55, 15);
            lbl_rounds.TabIndex = 11;
            lbl_rounds.Text = "Rodadas:";
            // 
            // lbl_rounds1
            // 
            lbl_rounds1.AutoSize = true;
            lbl_rounds1.Location = new Point(145, 474);
            lbl_rounds1.Name = "lbl_rounds1";
            lbl_rounds1.Size = new Size(13, 15);
            lbl_rounds1.TabIndex = 12;
            lbl_rounds1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 537);
            Controls.Add(lbl_rounds1);
            Controls.Add(lbl_rounds);
            Controls.Add(lbl_title);
            Controls.Add(btnReiniciar);
            Controls.Add(btn33);
            Controls.Add(btn32);
            Controls.Add(btn23);
            Controls.Add(btn22);
            Controls.Add(btn31);
            Controls.Add(btn13);
            Controls.Add(btn12);
            Controls.Add(btn21);
            Controls.Add(btn11);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn11;
        private Button btn21;
        private Button btn12;
        private Button btn13;
        private Button btn31;
        private Button btn22;
        private Button btn23;
        private Button btn32;
        private Button btn33;
        private Button btnReiniciar;
        private Label lbl_title;
        private Label lbl_rounds;
        private Label lbl_rounds1;
    }
}
