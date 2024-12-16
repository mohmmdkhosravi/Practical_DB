namespace Practical_DB
{
    partial class Batch
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(652, 44);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Load File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(287, 141);
            button2.Name = "button2";
            button2.Size = new Size(225, 63);
            button2.TabIndex = 1;
            button2.Text = "Insert all records";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(533, 27);
            textBox1.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(139, 271);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(533, 29);
            progressBar1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "text mart file|*.txt";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Batch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Batch";
            Text = "Batch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private OpenFileDialog openFileDialog1;
    }
}