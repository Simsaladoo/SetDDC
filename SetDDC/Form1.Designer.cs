namespace SetDDC
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2_SetSharedDDC = new System.Windows.Forms.Button();
            this.button3_SetLocalDDC = new System.Windows.Forms.Button();
            this.button4_OpenSys = new System.Windows.Forms.Button();
            this.button5_readENV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(151, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(650, 411);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2_SetSharedDDC
            // 
            this.button2_SetSharedDDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_SetSharedDDC.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_SetSharedDDC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2_SetSharedDDC.Location = new System.Drawing.Point(0, 80);
            this.button2_SetSharedDDC.Name = "button2_SetSharedDDC";
            this.button2_SetSharedDDC.Size = new System.Drawing.Size(151, 41);
            this.button2_SetSharedDDC.TabIndex = 2;
            this.button2_SetSharedDDC.Text = "Set Shared DDC";
            this.button2_SetSharedDDC.UseVisualStyleBackColor = true;
            this.button2_SetSharedDDC.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_SetLocalDDC
            // 
            this.button3_SetLocalDDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_SetLocalDDC.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_SetLocalDDC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3_SetLocalDDC.Location = new System.Drawing.Point(0, 120);
            this.button3_SetLocalDDC.Name = "button3_SetLocalDDC";
            this.button3_SetLocalDDC.Size = new System.Drawing.Size(151, 41);
            this.button3_SetLocalDDC.TabIndex = 3;
            this.button3_SetLocalDDC.Text = "Use Local DDC";
            this.button3_SetLocalDDC.UseVisualStyleBackColor = true;
            this.button3_SetLocalDDC.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4_OpenSys
            // 
            this.button4_OpenSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_OpenSys.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_OpenSys.ForeColor = System.Drawing.Color.Red;
            this.button4_OpenSys.Location = new System.Drawing.Point(0, 370);
            this.button4_OpenSys.Name = "button4_OpenSys";
            this.button4_OpenSys.Size = new System.Drawing.Size(151, 41);
            this.button4_OpenSys.TabIndex = 4;
            this.button4_OpenSys.Text = "Open System";
            this.button4_OpenSys.UseVisualStyleBackColor = true;
            this.button4_OpenSys.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5_readENV
            // 
            this.button5_readENV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5_readENV.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_readENV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5_readENV.Location = new System.Drawing.Point(0, 40);
            this.button5_readENV.Name = "button5_readENV";
            this.button5_readENV.Size = new System.Drawing.Size(151, 41);
            this.button5_readENV.TabIndex = 5;
            this.button5_readENV.Text = "Show Env Variables";
            this.button5_readENV.UseVisualStyleBackColor = true;
            this.button5_readENV.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.button5_readENV);
            this.Controls.Add(this.button4_OpenSys);
            this.Controls.Add(this.button3_SetLocalDDC);
            this.Controls.Add(this.button2_SetSharedDDC);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Set DDC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2_SetSharedDDC;
        private System.Windows.Forms.Button button3_SetLocalDDC;
        private System.Windows.Forms.Button button4_OpenSys;
        private System.Windows.Forms.Button button5_readENV;
    }
}

