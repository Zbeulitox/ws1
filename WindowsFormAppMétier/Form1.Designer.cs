
namespace WindowsFormAppMétier
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
            this.Uppercase = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_entercode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Uppercase
            // 
            this.Uppercase.Location = new System.Drawing.Point(306, 52);
            this.Uppercase.Name = "Uppercase";
            this.Uppercase.Size = new System.Drawing.Size(90, 30);
            this.Uppercase.TabIndex = 0;
            this.Uppercase.Text = "Uppercase";
            this.Uppercase.UseVisualStyleBackColor = true;
            this.Uppercase.Click += new System.EventHandler(this.Uppercase_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(108, 152);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(0, 15);
            this.lb_result.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_entercode
            // 
            this.lb_entercode.AutoSize = true;
            this.lb_entercode.Location = new System.Drawing.Point(108, 39);
            this.lb_entercode.Name = "lb_entercode";
            this.lb_entercode.Size = new System.Drawing.Size(91, 15);
            this.lb_entercode.TabIndex = 3;
            this.lb_entercode.Text = "Enter your word\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 410);
            this.Controls.Add(this.lb_entercode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.Uppercase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Uppercase;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_entercode;
    }
}

