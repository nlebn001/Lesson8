
namespace Lesson8Task4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rbRemainder = new System.Windows.Forms.RadioButton();
            this.rbExp = new System.Windows.Forms.RadioButton();
            this.rbConcat = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbClear = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // rbRemainder
            // 
            this.rbRemainder.AutoSize = true;
            this.rbRemainder.Location = new System.Drawing.Point(393, 87);
            this.rbRemainder.Name = "rbRemainder";
            this.rbRemainder.Size = new System.Drawing.Size(175, 24);
            this.rbRemainder.TabIndex = 3;
            this.rbRemainder.TabStop = true;
            this.rbRemainder.Text = "Remainder of division";
            this.rbRemainder.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbRemainder.UseVisualStyleBackColor = true;
            // 
            // rbExp
            // 
            this.rbExp.AutoSize = true;
            this.rbExp.Location = new System.Drawing.Point(393, 118);
            this.rbExp.Name = "rbExp";
            this.rbExp.Size = new System.Drawing.Size(130, 24);
            this.rbExp.TabIndex = 4;
            this.rbExp.TabStop = true;
            this.rbExp.Text = "Exponentiation";
            this.rbExp.UseVisualStyleBackColor = true;
            // 
            // rbConcat
            // 
            this.rbConcat.AutoSize = true;
            this.rbConcat.Location = new System.Drawing.Point(393, 150);
            this.rbConcat.Name = "rbConcat";
            this.rbConcat.Size = new System.Drawing.Size(76, 24);
            this.rbConcat.TabIndex = 5;
            this.rbConcat.TabStop = true;
            this.rbConcat.Text = "Concat";
            this.rbConcat.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(393, 180);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(83, 24);
            this.rbDiv.TabIndex = 6;
            this.rbDiv.TabStop = true;
            this.rbDiv.Text = "Division";
            this.rbDiv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Use only Int romat of numbers";
            // 
            // rbClear
            // 
            this.rbClear.AutoSize = true;
            this.rbClear.Location = new System.Drawing.Point(393, 211);
            this.rbClear.Name = "rbClear";
            this.rbClear.Size = new System.Drawing.Size(95, 24);
            this.rbClear.TabIndex = 9;
            this.rbClear.TabStop = true;
            this.rbClear.Text = "Clear Text";
            this.rbClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbDiv);
            this.Controls.Add(this.rbConcat);
            this.Controls.Add(this.rbExp);
            this.Controls.Add(this.rbRemainder);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rbRemainder;
        private System.Windows.Forms.RadioButton rbExp;
        private System.Windows.Forms.RadioButton rbConcat;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbClear;
    }
}

