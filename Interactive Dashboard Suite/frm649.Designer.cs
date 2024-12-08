namespace FinalProject
{
    partial class frm649
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
            this.Image = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_createNumbers = new System.Windows.Forms.Button();
            this.Label_7digits = new System.Windows.Forms.TextBox();
            this.Label_6numbers = new System.Windows.Forms.TextBox();
            this.btn_Read_Display = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.BackgroundImage = global::FinalProject.Properties.Resources._649Extra;
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image.Location = new System.Drawing.Point(12, 12);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(160, 236);
            this.Image.TabIndex = 7;
            this.Image.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "The generated numbers are:";
            // 
            // btn_createNumbers
            // 
            this.btn_createNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btn_createNumbers.Location = new System.Drawing.Point(199, 64);
            this.btn_createNumbers.Name = "btn_createNumbers";
            this.btn_createNumbers.Size = new System.Drawing.Size(248, 93);
            this.btn_createNumbers.TabIndex = 9;
            this.btn_createNumbers.Text = "Generate 6 + 1 out of 49\r\nunique numbers\r\nand 7 digits for Extra";
            this.btn_createNumbers.UseVisualStyleBackColor = true;
            this.btn_createNumbers.Click += new System.EventHandler(this.btn_createNumbers_Click);
            // 
            // Label_7digits
            // 
            this.Label_7digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Label_7digits.Location = new System.Drawing.Point(188, 183);
            this.Label_7digits.Multiline = true;
            this.Label_7digits.Name = "Label_7digits";
            this.Label_7digits.ReadOnly = true;
            this.Label_7digits.Size = new System.Drawing.Size(159, 39);
            this.Label_7digits.TabIndex = 10;
            // 
            // Label_6numbers
            // 
            this.Label_6numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_6numbers.Location = new System.Drawing.Point(484, 28);
            this.Label_6numbers.Multiline = true;
            this.Label_6numbers.Name = "Label_6numbers";
            this.Label_6numbers.ReadOnly = true;
            this.Label_6numbers.Size = new System.Drawing.Size(61, 265);
            this.Label_6numbers.TabIndex = 11;
            this.Label_6numbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Read_Display
            // 
            this.btn_Read_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read_Display.Location = new System.Drawing.Point(77, 294);
            this.btn_Read_Display.Name = "btn_Read_Display";
            this.btn_Read_Display.Size = new System.Drawing.Size(123, 93);
            this.btn_Read_Display.TabIndex = 12;
            this.btn_Read_Display.Text = "&Read and\r\nDisplay the\r\nText file";
            this.btn_Read_Display.UseVisualStyleBackColor = true;
            this.btn_Read_Display.Click += new System.EventHandler(this.btn_Read_Display_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(386, 325);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(159, 42);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 14;
            // 
            // frm649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Read_Display);
            this.Controls.Add(this.Label_6numbers);
            this.Controls.Add(this.Label_7digits);
            this.Controls.Add(this.btn_createNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Image);
            this.Name = "frm649";
            this.Text = "Lotto646 - Daiane Flores de Oliveira";
            this.Load += new System.EventHandler(this.frm649_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createNumbers;
        private System.Windows.Forms.TextBox Label_7digits;
        private System.Windows.Forms.TextBox Label_6numbers;
        private System.Windows.Forms.Button btn_Read_Display;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
    }
}