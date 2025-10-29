namespace WinFormsApp4
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
            textBoxProcent = new TextBox();
            textBoxLiczba = new TextBox();
            textBoxPojemnosc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelWyniklaczna = new Label();
            labelWynikczysta = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(566, 156);
            button1.Name = "button1";
            button1.Size = new Size(141, 105);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxProcent
            // 
            textBoxProcent.Location = new Point(216, 156);
            textBoxProcent.Name = "textBoxProcent";
            textBoxProcent.Size = new Size(125, 27);
            textBoxProcent.TabIndex = 1;
            // 
            // textBoxLiczba
            // 
            textBoxLiczba.Location = new Point(400, 156);
            textBoxLiczba.Name = "textBoxLiczba";
            textBoxLiczba.Size = new Size(125, 27);
            textBoxLiczba.TabIndex = 2;
            // 
            // textBoxPojemnosc
            // 
            textBoxPojemnosc.Location = new Point(34, 156);
            textBoxPojemnosc.Name = "textBoxPojemnosc";
            textBoxPojemnosc.Size = new Size(125, 27);
            textBoxPojemnosc.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 113);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "Pojemnosc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 113);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Persent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 113);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // labelWyniklaczna
            // 
            labelWyniklaczna.AutoSize = true;
            labelWyniklaczna.Location = new Point(34, 198);
            labelWyniklaczna.Name = "labelWyniklaczna";
            labelWyniklaczna.Size = new Size(0, 20);
            labelWyniklaczna.TabIndex = 7;
            labelWyniklaczna.Text = "Łączna objętość płynu:";
			// 
			// labelWynikczysta
			// 
			labelWynikczysta.AutoSize = true;
            labelWynikczysta.Location = new Point(34, 241);
            labelWynikczysta.Name = "labelWynikczysta";
            labelWynikczysta.Size = new Size(50, 20);
            labelWynikczysta.TabIndex = 8;
            labelWynikczysta.Text = "Objętość czystej substancji:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelWynikczysta);
            Controls.Add(labelWyniklaczna);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPojemnosc);
            Controls.Add(textBoxLiczba);
            Controls.Add(textBoxProcent);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxProcent;
        private TextBox textBoxLiczba;
        private TextBox textBoxPojemnosc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelWyniklaczna;
        private Label labelWynikczysta;
    }
}
