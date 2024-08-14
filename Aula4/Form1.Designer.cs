namespace Aula4
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
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(248, 254);
            button1.Name = "button1";
            button1.Size = new Size(284, 63);
            button1.TabIndex = 0;
            button1.Text = "Transpor!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(729, 254);
            button2.Name = "button2";
            button2.Size = new Size(251, 56);
            button2.TabIndex = 1;
            button2.Text = "Apagar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(386, 48);
            label1.Name = "label1";
            label1.Size = new Size(538, 89);
            label1.TabIndex = 2;
            label1.Text = "Escreva um texto";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.GradientActiveCaption;
            textBox1.Location = new Point(729, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Texto Transposto";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(248, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Texto 1";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(573, 370);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 5;
            label2.Text = "Resultado";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(386, 440);
            button3.Name = "button3";
            button3.Size = new Size(473, 54);
            button3.TabIndex = 6;
            button3.Text = "Sei la";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(515, 411);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 23);
            textBox3.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(248, 500);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(732, 109);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 644);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private TextBox textBox3;
        private ListBox listBox1;
    }
}