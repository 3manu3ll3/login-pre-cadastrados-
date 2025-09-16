namespace Telas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResultado = new Label();
            chkNadar = new CheckBox();
            chkPedalar = new CheckBox();
            label3 = new Label();
            button1 = new Button();
            chkCorrer = new CheckBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblLolgon = new Label();
            label4 = new Label();
            btnFechar = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 234);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(94, 240);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // chkNadar
            // 
            chkNadar.AutoSize = true;
            chkNadar.Location = new Point(82, 159);
            chkNadar.Name = "chkNadar";
            chkNadar.Size = new Size(58, 19);
            chkNadar.TabIndex = 3;
            chkNadar.Text = "Nadar";
            chkNadar.UseVisualStyleBackColor = true;
            // 
            // chkPedalar
            // 
            chkPedalar.AutoSize = true;
            chkPedalar.Location = new Point(82, 194);
            chkPedalar.Name = "chkPedalar";
            chkPedalar.Size = new Size(65, 19);
            chkPedalar.TabIndex = 4;
            chkPedalar.Text = "Pedalar";
            chkPedalar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 240);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Escolhas";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(219, 120);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chkCorrer
            // 
            chkCorrer.AutoSize = true;
            chkCorrer.Location = new Point(81, 124);
            chkCorrer.Name = "chkCorrer";
            chkCorrer.Size = new Size(59, 19);
            chkCorrer.TabIndex = 7;
            chkCorrer.Text = "Correr";
            chkCorrer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOrchid;
            pictureBox1.Location = new Point(-25, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 78);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkOrchid;
            label2.Location = new Point(7, 45);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 9;
            label2.Text = "Você esta logado como:";
            // 
            // lblLolgon
            // 
            lblLolgon.AutoSize = true;
            lblLolgon.BackColor = Color.DarkOrchid;
            lblLolgon.Location = new Point(146, 45);
            lblLolgon.Name = "lblLolgon";
            lblLolgon.Size = new Size(0, 15);
            lblLolgon.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkOrchid;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(63, 9);
            label4.Name = "label4";
            label4.Size = new Size(194, 32);
            label4.TabIndex = 9;
            label4.Text = "Atividades fisicas";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Crimson;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Location = new Point(126, 320);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LavenderBlush;
            label5.Font = new Font("Segoe UI", 25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(278, 14);
            label5.Name = "label5";
            label5.Size = new Size(35, 46);
            label5.TabIndex = 12;
            label5.Text = "?";
            label5.Click += label5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(325, 355);
            Controls.Add(label5);
            Controls.Add(btnFechar);
            Controls.Add(lblLolgon);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(chkCorrer);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(chkPedalar);
            Controls.Add(chkNadar);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private CheckBox chkNadar;
        private CheckBox chkPedalar;
        private Label label3;
        private Button button1;
        private CheckBox chkCorrer;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblLolgon;
        private Label label4;
        private Button btnFechar;
        private Label label5;
    }
}