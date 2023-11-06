namespace _7
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(275, 481);
            button1.Name = "button1";
            button1.Size = new Size(162, 68);
            button1.TabIndex = 0;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(753, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(636, 726);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 39);
            textBox3.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(650, 301);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 356);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 208);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 5;
            label1.Text = "Rango inferior";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 212);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 6;
            label2.Text = "Rango superior";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 89);
            label3.Name = "label3";
            label3.Size = new Size(642, 32);
            label3.TabIndex = 7;
            label3.Text = "Imprime números de un rango específico y calcula la suma";
            // 
            // button2
            // 
            button2.Location = new Point(275, 612);
            button2.Name = "button2";
            button2.Size = new Size(162, 73);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 831);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}