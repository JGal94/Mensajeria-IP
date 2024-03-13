namespace Gramip
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            setear = new Button();
            panel1 = new Panel();
            label7 = new Label();
            textBoxCl = new TextBox();
            label4 = new Label();
            textBoxIp = new TextBox();
            textBoxPu = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            enviardat = new Button();
            textBoxNo = new TextBox();
            textBoxMe = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            textBoxCh = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "IP del receptor: \r\n";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 1;
            label2.Text = "Puerto de comunicacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(20, 36);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            label3.Click += label3_Click;
            // 
            // setear
            // 
            setear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setear.Location = new Point(119, 151);
            setear.Name = "setear";
            setear.Size = new Size(162, 35);
            setear.TabIndex = 3;
            setear.Text = "Set";
            setear.UseVisualStyleBackColor = true;
            setear.Click += button1_Click;
            setear.MouseClick += button1_MouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBoxCl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxIp);
            panel1.Controls.Add(textBoxPu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(setear);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 189);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(25, 101);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 9;
            label7.Text = "Clave";
            label7.Click += label7_Click;
            // 
            // textBoxCl
            // 
            textBoxCl.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxCl.Location = new Point(226, 101);
            textBoxCl.MaxLength = 4;
            textBoxCl.Name = "textBoxCl";
            textBoxCl.Size = new Size(86, 21);
            textBoxCl.TabIndex = 8;
            textBoxCl.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(159, 4);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Ajustes\r\n";
            label4.Click += label4_Click;
            // 
            // textBoxIp
            // 
            textBoxIp.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIp.Location = new Point(226, 36);
            textBoxIp.MaxLength = 15;
            textBoxIp.Name = "textBoxIp";
            textBoxIp.Size = new Size(148, 21);
            textBoxIp.TabIndex = 5;
            // 
            // textBoxPu
            // 
            textBoxPu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPu.Location = new Point(226, 70);
            textBoxPu.MaxLength = 4;
            textBoxPu.Name = "textBoxPu";
            textBoxPu.Size = new Size(86, 21);
            textBoxPu.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(enviardat);
            panel2.Controls.Add(textBoxNo);
            panel2.Controls.Add(textBoxMe);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 238);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(159, 11);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 7;
            label5.Text = "Mensaje";
            label5.Click += label5_Click;
            // 
            // enviardat
            // 
            enviardat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enviardat.Location = new Point(119, 209);
            enviardat.Name = "enviardat";
            enviardat.Size = new Size(162, 26);
            enviardat.TabIndex = 5;
            enviardat.Text = "Enviar";
            enviardat.UseVisualStyleBackColor = true;
            enviardat.Click += button2_Click;
            // 
            // textBoxNo
            // 
            textBoxNo.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxNo.Location = new Point(101, 36);
            textBoxNo.MaxLength = 9;
            textBoxNo.Name = "textBoxNo";
            textBoxNo.Size = new Size(100, 21);
            textBoxNo.TabIndex = 4;
            // 
            // textBoxMe
            // 
            textBoxMe.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxMe.Location = new Point(25, 72);
            textBoxMe.MaxLength = 200;
            textBoxMe.Multiline = true;
            textBoxMe.Name = "textBoxMe";
            textBoxMe.Size = new Size(349, 134);
            textBoxMe.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBoxCh);
            panel3.Location = new Point(441, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 433);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(145, 4);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 7;
            label6.Text = "Chat";
            // 
            // textBoxCh
            // 
            textBoxCh.Enabled = false;
            textBoxCh.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxCh.Location = new Point(20, 29);
            textBoxCh.Multiline = true;
            textBoxCh.Name = "textBoxCh";
            textBoxCh.ReadOnly = true;
            textBoxCh.Size = new Size(290, 372);
            textBoxCh.TabIndex = 4;
            textBoxCh.TextChanged += textBoxCh_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Gramip";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button setear;
        private Panel panel1;
        private TextBox textBoxIp;
        private TextBox textBoxPu;
        private Panel panel2;
        private TextBox textBoxNo;
        private TextBox textBoxMe;
        private Button enviardat;
        private Label label4;
        private Panel panel3;
        private TextBox textBoxCh;
        private Label label5;
        private Label label6;
        private TextBox textBoxCl;
        private Label label7;
    }
}
