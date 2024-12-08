namespace FinalProject
{
    partial class frmMax
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
            this.btn_createNumbers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Read_Display = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Label7digits = new System.Windows.Forms.TextBox();
            this.Label7numbers = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Image = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_createNumbers
            // 
            this.btn_createNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btn_createNumbers.Location = new System.Drawing.Point(230, 45);
            this.btn_createNumbers.Name = "btn_createNumbers";
            this.btn_createNumbers.Size = new System.Drawing.Size(191, 91);
            this.btn_createNumbers.TabIndex = 1;
            this.btn_createNumbers.Text = "Generate 7 + 1 out of 50\r\nunique numbers\r\nand 7 digits for Extra";
            this.btn_createNumbers.UseVisualStyleBackColor = true;
            this.btn_createNumbers.Click += new System.EventHandler(this.btn_createNumbers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "The generated numbers are:";
            // 
            // btn_Read_Display
            // 
            this.btn_Read_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read_Display.Location = new System.Drawing.Point(55, 246);
            this.btn_Read_Display.Name = "btn_Read_Display";
            this.btn_Read_Display.Size = new System.Drawing.Size(123, 93);
            this.btn_Read_Display.TabIndex = 4;
            this.btn_Read_Display.Text = "&Read and\r\nDisplay the\r\nText file";
            this.btn_Read_Display.UseVisualStyleBackColor = true;
            this.btn_Read_Display.Click += new System.EventHandler(this.btn_Read_Display_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(427, 299);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(123, 40);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Label7digits
            // 
            this.Label7digits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7digits.Location = new System.Drawing.Point(209, 175);
            this.Label7digits.Name = "Label7digits";
            this.Label7digits.ReadOnly = true;
            this.Label7digits.Size = new System.Drawing.Size(171, 28);
            this.Label7digits.TabIndex = 7;
            // 
            // Label7numbers
            // 
            this.Label7numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7numbers.Location = new System.Drawing.Point(489, 12);
            this.Label7numbers.Multiline = true;
            this.Label7numbers.Name = "Label7numbers";
            this.Label7numbers.ReadOnly = true;
            this.Label7numbers.Size = new System.Drawing.Size(41, 265);
            this.Label7numbers.TabIndex = 8;
            this.Label7numbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Image
            // 
            this.Image.BackgroundImage = global::FinalProject.Properties.Resources.MaxExtra;
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image.Location = new System.Drawing.Point(12, 12);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(181, 202);
            this.Image.TabIndex = 6;
            this.Image.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.Location = new System.Drawing.Point(489, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.Location = new System.Drawing.Point(489, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 11;
            // 
            // frmMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Label7numbers);
            this.Controls.Add(this.Label7digits);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Read_Display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_createNumbers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Name = "frmMax";
            this.Text = "LottoMax - Daiane Flores de Oliveira";
            this.Load += new System.EventHandler(this.frmMax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_createNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Read_Display;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button Image;
        private System.Windows.Forms.TextBox Label7digits;
        private System.Windows.Forms.TextBox Label7numbers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}