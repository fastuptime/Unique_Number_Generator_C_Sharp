namespace WinFormsApp3
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
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label2 = new Label();
            trackBar3 = new TrackBar();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("OCR A Std", 12F);
            button1.Location = new Point(484, 329);
            button1.Name = "button1";
            button1.Size = new Size(277, 82);
            button1.TabIndex = 0;
            button1.Text = "Rasgele Sayı Üret";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(427, 424);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Std", 9F);
            label1.Location = new Point(484, 39);
            label1.Name = "label1";
            label1.Size = new Size(216, 16);
            label1.TabIndex = 2;
            label1.Text = "Kaç Adet Üretilsin?";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(488, 74);
            trackBar1.Maximum = 1000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(273, 56);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(488, 152);
            trackBar2.Maximum = 1000;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(273, 56);
            trackBar2.TabIndex = 5;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Std", 9F);
            label2.Location = new Point(484, 117);
            label2.Name = "label2";
            label2.Size = new Size(62, 16);
            label2.TabIndex = 4;
            label2.Text = "En az";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(488, 236);
            trackBar3.Maximum = 1000;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(273, 56);
            trackBar3.TabIndex = 7;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Std", 9F);
            label3.Location = new Point(484, 201);
            label3.Name = "label3";
            label3.Size = new Size(95, 16);
            label3.TabIndex = 6;
            label3.Text = "En fazla";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar3);
            Controls.Add(label3);
            Controls.Add(trackBar2);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Opacity = 0.95D;
            ShowIcon = false;
            Text = "github.com/fastuptime - Can";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label2;
        private TrackBar trackBar3;
        private Label label3;
    }
}
