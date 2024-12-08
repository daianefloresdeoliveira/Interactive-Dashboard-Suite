namespace FinalProject
{
    partial class IP_Validator
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
            this.label_Date = new System.Windows.Forms.Label();
            this.label_IPv4 = new System.Windows.Forms.Label();
            this.label_IPv6 = new System.Windows.Forms.Label();
            this.txt_v4 = new System.Windows.Forms.TextBox();
            this.txt_v6 = new System.Windows.Forms.TextBox();
            this.btn_ValidateIP = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Read_Display = new System.Windows.Forms.Button();
            this.btn_ExitValidator = new System.Windows.Forms.Button();
            this.label_today = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(182, 21);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(0, 24);
            this.label_Date.TabIndex = 0;
            this.label_Date.Click += new System.EventHandler(this.label_Date_Click);
            // 
            // label_IPv4
            // 
            this.label_IPv4.AutoSize = true;
            this.label_IPv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IPv4.Location = new System.Drawing.Point(25, 84);
            this.label_IPv4.Name = "label_IPv4";
            this.label_IPv4.Size = new System.Drawing.Size(180, 24);
            this.label_IPv4.TabIndex = 1;
            this.label_IPv4.Text = "Enter IP v4 Address:";
            // 
            // label_IPv6
            // 
            this.label_IPv6.AutoSize = true;
            this.label_IPv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IPv6.Location = new System.Drawing.Point(25, 144);
            this.label_IPv6.Name = "label_IPv6";
            this.label_IPv6.Size = new System.Drawing.Size(180, 24);
            this.label_IPv6.TabIndex = 2;
            this.label_IPv6.Text = "Enter IP v6 Address:";
            // 
            // txt_v4
            // 
            this.txt_v4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_v4.Location = new System.Drawing.Point(226, 80);
            this.txt_v4.Name = "txt_v4";
            this.txt_v4.Size = new System.Drawing.Size(236, 28);
            this.txt_v4.TabIndex = 3;
//            this.txt_v4.TextChanged += new System.EventHandler(this.txt_v4_TextChanged);
            // 
            // txt_v6
            // 
            this.txt_v6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_v6.Location = new System.Drawing.Point(226, 140);
            this.txt_v6.Name = "txt_v6";
            this.txt_v6.Size = new System.Drawing.Size(236, 28);
            this.txt_v6.TabIndex = 4;
            // 
            // btn_ValidateIP
            // 
            this.btn_ValidateIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValidateIP.Location = new System.Drawing.Point(42, 231);
            this.btn_ValidateIP.Name = "btn_ValidateIP";
            this.btn_ValidateIP.Size = new System.Drawing.Size(126, 35);
            this.btn_ValidateIP.TabIndex = 5;
            this.btn_ValidateIP.Text = "Validate IP";
            this.btn_ValidateIP.UseVisualStyleBackColor = true;
            this.btn_ValidateIP.Click += new System.EventHandler(this.btn_ValidateIP_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(226, 197);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(105, 35);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Read_Display
            // 
            this.btn_Read_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read_Display.Location = new System.Drawing.Point(186, 267);
            this.btn_Read_Display.Name = "btn_Read_Display";
            this.btn_Read_Display.Size = new System.Drawing.Size(196, 35);
            this.btn_Read_Display.TabIndex = 7;
            this.btn_Read_Display.Text = "Read and Display";
            this.btn_Read_Display.UseVisualStyleBackColor = true;
            this.btn_Read_Display.Click += new System.EventHandler(this.btn_Read_Display_Click);
            // 
            // btn_ExitValidator
            // 
            this.btn_ExitValidator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitValidator.Location = new System.Drawing.Point(406, 231);
            this.btn_ExitValidator.Name = "btn_ExitValidator";
            this.btn_ExitValidator.Size = new System.Drawing.Size(75, 35);
            this.btn_ExitValidator.TabIndex = 8;
            this.btn_ExitValidator.Text = "Exit";
            this.btn_ExitValidator.UseVisualStyleBackColor = true;
            this.btn_ExitValidator.Click += new System.EventHandler(this.btn_ExitValidator_Click);
            // 
            // label_today
            // 
            this.label_today.AutoSize = true;
            this.label_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_today.Location = new System.Drawing.Point(100, 21);
            this.label_today.Name = "label_today";
            this.label_today.Size = new System.Drawing.Size(68, 24);
            this.label_today.TabIndex = 9;
            this.label_today.Text = "Today:";
            // 
            // IP_Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 349);
            this.Controls.Add(this.label_today);
            this.Controls.Add(this.btn_ExitValidator);
            this.Controls.Add(this.btn_Read_Display);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_ValidateIP);
            this.Controls.Add(this.txt_v6);
            this.Controls.Add(this.txt_v4);
            this.Controls.Add(this.label_IPv6);
            this.Controls.Add(this.label_IPv4);
            this.Controls.Add(this.label_Date);
            this.Name = "IP_Validator";
            this.Text = "IP_Validator - Daiane Flores de Oliveira";
            this.Load += new System.EventHandler(this.IP_Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_IPv4;
        private System.Windows.Forms.Label label_IPv6;
        private System.Windows.Forms.TextBox txt_v4;
        private System.Windows.Forms.TextBox txt_v6;
        private System.Windows.Forms.Button btn_ValidateIP;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Read_Display;
        private System.Windows.Forms.Button btn_ExitValidator;
        private System.Windows.Forms.Label label_today;
    }
}