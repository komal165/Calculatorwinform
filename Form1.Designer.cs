namespace Calculatorwinform
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Sub = new System.Windows.Forms.Button();
            this.Btn_Mul = new System.Windows.Forms.Button();
            this.Btn_Div = new System.Windows.Forms.Button();
            this.Txt_FirstNumber = new System.Windows.Forms.Button();
            this.Txt_SecondNumber = new System.Windows.Forms.Button();
            this.Txt_Result = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(110, 236);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 3;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Btn_Sub
            // 
            this.Btn_Sub.Location = new System.Drawing.Point(267, 235);
            this.Btn_Sub.Name = "Btn_Sub";
            this.Btn_Sub.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sub.TabIndex = 4;
            this.Btn_Sub.Text = "Sub";
            this.Btn_Sub.UseVisualStyleBackColor = true;
            this.Btn_Sub.Click += new System.EventHandler(this.Btn_sub_Click);
            // 
            // Btn_Mul
            // 
            this.Btn_Mul.Location = new System.Drawing.Point(423, 234);
            this.Btn_Mul.Name = "Btn_Mul";
            this.Btn_Mul.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mul.TabIndex = 5;
            this.Btn_Mul.Text = "Mul";
            this.Btn_Mul.UseVisualStyleBackColor = true;
            this.Btn_Mul.Click += new System.EventHandler(this.Btn_mul_Click);
            // 
            // Btn_Div
            // 
            this.Btn_Div.Location = new System.Drawing.Point(576, 235);
            this.Btn_Div.Name = "Btn_Div";
            this.Btn_Div.Size = new System.Drawing.Size(75, 23);
            this.Btn_Div.TabIndex = 6;
            this.Btn_Div.Text = "Div";
            this.Btn_Div.UseVisualStyleBackColor = true;
            this.Btn_Div.Click += new System.EventHandler(this.Btn_div_Click);
            // 
            // Txt_FirstNumber
            // 
            this.Txt_FirstNumber.Location = new System.Drawing.Point(376, 63);
            this.Txt_FirstNumber.Name = "Txt_FirstNumber";
            this.Txt_FirstNumber.Size = new System.Drawing.Size(75, 23);
            this.Txt_FirstNumber.TabIndex = 7;
            this.Txt_FirstNumber.UseVisualStyleBackColor = true;
            // 
            // Txt_SecondNumber
            // 
            this.Txt_SecondNumber.Location = new System.Drawing.Point(376, 112);
            this.Txt_SecondNumber.Name = "Txt_SecondNumber";
            this.Txt_SecondNumber.Size = new System.Drawing.Size(75, 23);
            this.Txt_SecondNumber.TabIndex = 8;
            this.Txt_SecondNumber.UseVisualStyleBackColor = true;
            // 
            // Txt_Result
            // 
            this.Txt_Result.Location = new System.Drawing.Point(376, 169);
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.Size = new System.Drawing.Size(75, 23);
            this.Txt_Result.TabIndex = 9;
            this.Txt_Result.UseVisualStyleBackColor = true;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(708, 235);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 10;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Txt_Result);
            this.Controls.Add(this.Txt_SecondNumber);
            this.Controls.Add(this.Txt_FirstNumber);
            this.Controls.Add(this.Btn_Div);
            this.Controls.Add(this.Btn_Mul);
            this.Controls.Add(this.Btn_Sub);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Sub;
        private System.Windows.Forms.Button Btn_Mul;
        private System.Windows.Forms.Button Btn_Div;
        private System.Windows.Forms.Button Txt_FirstNumber;
        private System.Windows.Forms.Button Txt_SecondNumber;
        private System.Windows.Forms.Button Txt_Result;
        private System.Windows.Forms.Button Btn_Clear;
    }
}

