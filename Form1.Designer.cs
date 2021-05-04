namespace Kontroliranje_gimbala
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Select_port = new System.Windows.Forms.ComboBox();
            this.Pretrazi = new System.Windows.Forms.Button();
            this.gore = new System.Windows.Forms.Button();
            this.lijevo = new System.Windows.Forms.Button();
            this.dole = new System.Windows.Forms.Button();
            this.desno = new System.Windows.Forms.Button();
            this.Zapocni = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Select_port
            // 
            this.Select_port.AllowDrop = true;
            this.Select_port.FormattingEnabled = true;
            this.Select_port.Location = new System.Drawing.Point(147, 24);
            this.Select_port.Name = "Select_port";
            this.Select_port.Size = new System.Drawing.Size(121, 21);
            this.Select_port.TabIndex = 0;
            this.Select_port.SelectedIndexChanged += new System.EventHandler(this.Select_port_SelectedIndexChanged);
            // 
            // Pretrazi
            // 
            this.Pretrazi.Location = new System.Drawing.Point(43, 24);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(75, 23);
            this.Pretrazi.TabIndex = 1;
            this.Pretrazi.Text = "Pretrazi";
            this.Pretrazi.UseVisualStyleBackColor = true;
            this.Pretrazi.Click += new System.EventHandler(this.Pretrazi_Click);
            // 
            // gore
            // 
            this.gore.Location = new System.Drawing.Point(333, 112);
            this.gore.Name = "gore";
            this.gore.Size = new System.Drawing.Size(75, 23);
            this.gore.TabIndex = 2;
            this.gore.Text = "gore";
            this.gore.UseVisualStyleBackColor = true;
            this.gore.Click += new System.EventHandler(this.gore_Click);
            // 
            // lijevo
            // 
            this.lijevo.Location = new System.Drawing.Point(247, 155);
            this.lijevo.Name = "lijevo";
            this.lijevo.Size = new System.Drawing.Size(75, 23);
            this.lijevo.TabIndex = 3;
            this.lijevo.Text = "lijevo";
            this.lijevo.UseVisualStyleBackColor = true;
            this.lijevo.Click += new System.EventHandler(this.lijevo_Click);
            // 
            // dole
            // 
            this.dole.Location = new System.Drawing.Point(333, 198);
            this.dole.Name = "dole";
            this.dole.Size = new System.Drawing.Size(75, 23);
            this.dole.TabIndex = 4;
            this.dole.Text = "dole";
            this.dole.UseVisualStyleBackColor = true;
            this.dole.Click += new System.EventHandler(this.dole_Click);
            // 
            // desno
            // 
            this.desno.Location = new System.Drawing.Point(417, 155);
            this.desno.Name = "desno";
            this.desno.Size = new System.Drawing.Size(75, 23);
            this.desno.TabIndex = 5;
            this.desno.Text = "desno";
            this.desno.UseVisualStyleBackColor = true;
            this.desno.Click += new System.EventHandler(this.desno_Click);
            // 
            // Zapocni
            // 
            this.Zapocni.Location = new System.Drawing.Point(43, 98);
            this.Zapocni.Name = "Zapocni";
            this.Zapocni.Size = new System.Drawing.Size(75, 23);
            this.Zapocni.TabIndex = 6;
            this.Zapocni.Text = "Zapocni";
            this.Zapocni.UseVisualStyleBackColor = true;
            this.Zapocni.Click += new System.EventHandler(this.Zapocni_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 268);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Zapocni);
            this.Controls.Add(this.desno);
            this.Controls.Add(this.dole);
            this.Controls.Add(this.lijevo);
            this.Controls.Add(this.gore);
            this.Controls.Add(this.Pretrazi);
            this.Controls.Add(this.Select_port);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Select_port;
        private System.Windows.Forms.Button Pretrazi;
        private System.Windows.Forms.Button gore;
        private System.Windows.Forms.Button lijevo;
        private System.Windows.Forms.Button dole;
        private System.Windows.Forms.Button desno;
        private System.Windows.Forms.Button Zapocni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

