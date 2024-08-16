namespace App_de_desconto
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(631, 251);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(231, 32);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Ja fez um outro curso ?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(631, 289);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(199, 32);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Pagamento a vista?";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(631, 327);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(146, 32);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Valor de 70%";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(367, 64);
            label1.Name = "label1";
            label1.Size = new Size(731, 89);
            label1.TabIndex = 3;
            label1.Text = "Calculador de desconto";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(576, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 30);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(576, 370);
            button1.Name = "button1";
            button1.Size = new Size(337, 47);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(576, 501);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuText;
            label3.Location = new Point(469, 188);
            label3.Name = "label3";
            label3.Size = new Size(101, 45);
            label3.TabIndex = 7;
            label3.Text = "Valor ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 642);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}