namespace RSA_app_2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            receive_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(526, 27);
            textBox2.TabIndex = 1;
            // 
            // receive_btn
            // 
            receive_btn.Location = new Point(132, 260);
            receive_btn.Name = "receive_btn";
            receive_btn.Size = new Size(526, 54);
            receive_btn.TabIndex = 2;
            receive_btn.Text = "Gauti";
            receive_btn.UseVisualStyleBackColor = true;
            receive_btn.Click += receive_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 41);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 3;
            label1.Text = "Gautas Tekstas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 144);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Gautas Parašas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 380);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(receive_btn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Verification";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button receive_btn;
        private Label label1;
        private Label label2;
    }
}