namespace Crud_C_
{
    partial class Form2
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
            listViewClientes = new ListView();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listViewClientes
            // 
            listViewClientes.Location = new Point(366, 12);
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(398, 413);
            listViewClientes.TabIndex = 0;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            listViewClientes.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Himalaya", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(74, 261);
            button1.Name = "button1";
            button1.Size = new Size(174, 40);
            button1.TabIndex = 1;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(130, 184);
            label1.Name = "label1";
            label1.Size = new Size(59, 29);
            label1.TabIndex = 2;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Himalaya", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(74, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 36);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Himalaya", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(74, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 36);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 112);
            label2.Name = "label2";
            label2.Size = new Size(61, 29);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listViewClientes);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClientes;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}