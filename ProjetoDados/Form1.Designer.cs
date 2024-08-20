namespace ProjetoDados
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
            listViewClientes = new ListView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listViewClientes
            // 
            listViewClientes.Location = new Point(309, 12);
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(479, 355);
            listViewClientes.TabIndex = 0;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            listViewClientes.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(425, 384);
            button1.Name = "button1";
            button1.Size = new Size(251, 44);
            button1.TabIndex = 1;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 105);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Entre com o nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 174);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Entre com o e-mail";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(68, 241);
            button2.Name = "button2";
            button2.Size = new Size(121, 30);
            button2.TabIndex = 6;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listViewClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClientes;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
    }
}