namespace Carros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EuroRoman", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 160);
            label1.Name = "label1";
            label1.Size = new Size(332, 40);
            label1.TabIndex = 0;
            label1.Text = "Simulador De Seguro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 228);
            label2.Name = "label2";
            label2.Size = new Size(78, 37);
            label2.TabIndex = 1;
            label2.Text = "Valor";
            label2.Click += label2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Felix Titling", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(82, 292);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(301, 36);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Recém Habilitado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Felix Titling", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(82, 339);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(305, 36);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Menor de 25 anos";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(164, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 43);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(82, 398);
            button1.Name = "button1";
            button1.Size = new Size(297, 48);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(507, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EuroRoman", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(164, 62);
            label4.Name = "label4";
            label4.Size = new Size(0, 40);
            label4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(813, 539);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}