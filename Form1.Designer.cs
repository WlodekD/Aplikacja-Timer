namespace Timer3._0
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.LabelSec = new System.Windows.Forms.Label();
            this.LabelMin = new System.Windows.Forms.Label();
            this.LabelHours = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCzasTrwaniaProjektu = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.buttonRaportExcel = new System.Windows.Forms.Button();
            this.buttonResetuj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(275, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 36);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(275, 165);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 36);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // LabelSec
            // 
            this.LabelSec.AutoSize = true;
            this.LabelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSec.Location = new System.Drawing.Point(121, 305);
            this.LabelSec.Name = "LabelSec";
            this.LabelSec.Size = new System.Drawing.Size(44, 31);
            this.LabelSec.TabIndex = 2;
            this.LabelSec.Text = "00";
            // 
            // LabelMin
            // 
            this.LabelMin.AutoSize = true;
            this.LabelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMin.Location = new System.Drawing.Point(71, 305);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.Size = new System.Drawing.Size(44, 31);
            this.LabelMin.TabIndex = 3;
            this.LabelMin.Text = "00";
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelHours.Location = new System.Drawing.Point(21, 305);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(44, 31);
            this.LabelHours.TabIndex = 4;
            this.LabelHours.Text = "00";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(27, 99);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(33, 20);
            this.textBoxHours.TabIndex = 5;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(72, 99);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(33, 20);
            this.textBoxMinutes.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwa projektu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Przewidywany czas projektu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "godz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "min";
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(115, 99);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(33, 20);
            this.textBoxSeconds.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "sek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(24, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Odliczany czas do zakończenia\r\nprojektu:";
            // 
            // labelCzasTrwaniaProjektu
            // 
            this.labelCzasTrwaniaProjektu.AutoSize = true;
            this.labelCzasTrwaniaProjektu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCzasTrwaniaProjektu.Location = new System.Drawing.Point(24, 165);
            this.labelCzasTrwaniaProjektu.Name = "labelCzasTrwaniaProjektu";
            this.labelCzasTrwaniaProjektu.Size = new System.Drawing.Size(137, 16);
            this.labelCzasTrwaniaProjektu.TabIndex = 15;
            this.labelCzasTrwaniaProjektu.Text = "Czas trwania projektu:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHP.Location = new System.Drawing.Point(22, 181);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(27, 20);
            this.labelHP.TabIndex = 16;
            this.labelHP.Text = "00";
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMP.Location = new System.Drawing.Point(55, 181);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(27, 20);
            this.labelMP.TabIndex = 17;
            this.labelMP.Text = "00";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSP.Location = new System.Drawing.Point(88, 181);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(27, 20);
            this.labelSP.TabIndex = 18;
            this.labelSP.Text = "00";
            // 
            // buttonRaportExcel
            // 
            this.buttonRaportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRaportExcel.Location = new System.Drawing.Point(275, 273);
            this.buttonRaportExcel.Name = "buttonRaportExcel";
            this.buttonRaportExcel.Size = new System.Drawing.Size(75, 36);
            this.buttonRaportExcel.TabIndex = 19;
            this.buttonRaportExcel.Text = "Raport\r\n Excel";
            this.buttonRaportExcel.UseVisualStyleBackColor = true;
            this.buttonRaportExcel.Click += new System.EventHandler(this.buttonRaportExcel_Click);
            // 
            // buttonResetuj
            // 
            this.buttonResetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResetuj.Location = new System.Drawing.Point(27, 204);
            this.buttonResetuj.Name = "buttonResetuj";
            this.buttonResetuj.Size = new System.Drawing.Size(88, 28);
            this.buttonResetuj.TabIndex = 20;
            this.buttonResetuj.Text = "Resetuj";
            this.buttonResetuj.UseVisualStyleBackColor = true;
            this.buttonResetuj.Click += new System.EventHandler(this.buttonResetuj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(110, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(62, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(80, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(47, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 355);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonResetuj);
            this.Controls.Add(this.buttonRaportExcel);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelCzasTrwaniaProjektu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.LabelMin);
            this.Controls.Add(this.LabelSec);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label LabelSec;
        private System.Windows.Forms.Label LabelMin;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCzasTrwaniaProjektu;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Button buttonRaportExcel;
        private System.Windows.Forms.Button buttonResetuj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

