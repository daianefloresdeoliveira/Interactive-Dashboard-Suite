namespace FinalProject
{
    partial class Temperature
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
            this.radio_C_F = new System.Windows.Forms.RadioButton();
            this.radio_F_C = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_TempTo = new System.Windows.Forms.Label();
            this.label_TempConv = new System.Windows.Forms.Label();
            this.text_msn = new System.Windows.Forms.TextBox();
            this.label_message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_ReadFile = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_C_F
            // 
            this.radio_C_F.AutoSize = true;
            this.radio_C_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_C_F.Location = new System.Drawing.Point(156, 22);
            this.radio_C_F.Name = "radio_C_F";
            this.radio_C_F.Size = new System.Drawing.Size(123, 28);
            this.radio_C_F.TabIndex = 0;
            this.radio_C_F.Text = "from C to F";
            this.radio_C_F.UseVisualStyleBackColor = true;
            // 
            // radio_F_C
            // 
            this.radio_F_C.AutoSize = true;
            this.radio_F_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_F_C.Location = new System.Drawing.Point(156, 76);
            this.radio_F_C.Name = "radio_F_C";
            this.radio_F_C.Size = new System.Drawing.Size(123, 28);
            this.radio_F_C.TabIndex = 1;
            this.radio_F_C.Text = "from F to C";
            this.radio_F_C.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(300, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(128, 28);
            this.textBox2.TabIndex = 3;
            // 
            // label_TempTo
            // 
            this.label_TempTo.AutoSize = true;
            this.label_TempTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TempTo.Location = new System.Drawing.Point(83, 171);
            this.label_TempTo.Name = "label_TempTo";
            this.label_TempTo.Size = new System.Drawing.Size(23, 24);
            this.label_TempTo.TabIndex = 4;
            this.label_TempTo.Text = "C";
            // 
            // label_TempConv
            // 
            this.label_TempConv.AutoSize = true;
            this.label_TempConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TempConv.Location = new System.Drawing.Point(357, 171);
            this.label_TempConv.Name = "label_TempConv";
            this.label_TempConv.Size = new System.Drawing.Size(22, 24);
            this.label_TempConv.TabIndex = 5;
            this.label_TempConv.Text = "F";
            // 
            // text_msn
            // 
            this.text_msn.Location = new System.Drawing.Point(32, 248);
            this.text_msn.Multiline = true;
            this.text_msn.Name = "text_msn";
            this.text_msn.ReadOnly = true;
            this.text_msn.Size = new System.Drawing.Size(396, 93);
            this.text_msn.TabIndex = 6;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.Location = new System.Drawing.Point(28, 221);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(92, 24);
            this.label_message.TabIndex = 7;
            this.label_message.Text = "Message:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "to";
            // 
            // btn_Convert
            // 
            this.btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.Location = new System.Drawing.Point(32, 363);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(128, 49);
            this.btn_Convert.TabIndex = 9;
            this.btn_Convert.Text = "&Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_ReadFile
            // 
            this.btn_ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadFile.Location = new System.Drawing.Point(166, 363);
            this.btn_ReadFile.Name = "btn_ReadFile";
            this.btn_ReadFile.Size = new System.Drawing.Size(128, 49);
            this.btn_ReadFile.TabIndex = 10;
            this.btn_ReadFile.Text = "&Read File";
            this.btn_ReadFile.UseVisualStyleBackColor = true;
            this.btn_ReadFile.Click += new System.EventHandler(this.btn_ReadFile_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(300, 363);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(128, 49);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "E&xit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 429);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ReadFile);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.text_msn);
            this.Controls.Add(this.label_TempConv);
            this.Controls.Add(this.label_TempTo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radio_F_C);
            this.Controls.Add(this.radio_C_F);
            this.Name = "Temperature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature - Daiane Flores de Oliveira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_C_F;
        private System.Windows.Forms.RadioButton radio_F_C;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_TempTo;
        private System.Windows.Forms.Label label_TempConv;
        private System.Windows.Forms.TextBox text_msn;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_ReadFile;
        private System.Windows.Forms.Button btn_Exit;
    }
}