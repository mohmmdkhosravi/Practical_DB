namespace Practical_DB
{
    partial class Genes
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 91);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Transcript_id";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(234, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 141);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 4;
            label3.Text = "gene_symbol";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(234, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 193);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 6;
            label4.Text = "biotype";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(135, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 247);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 8;
            label5.Text = "chr";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(135, 292);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(234, 27);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 295);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 10;
            label6.Text = "cytoband";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(135, 338);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(234, 27);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 341);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 12;
            label7.Text = "synonym";
            // 
            // button1
            // 
            button1.Location = new Point(477, 67);
            button1.Name = "button1";
            button1.Size = new Size(202, 73);
            button1.TabIndex = 14;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(477, 155);
            button2.Name = "button2";
            button2.Size = new Size(202, 73);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(477, 244);
            button3.Name = "button3";
            button3.Size = new Size(202, 75);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // Genes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Genes";
            Text = "Genes";
            Load += Genes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}