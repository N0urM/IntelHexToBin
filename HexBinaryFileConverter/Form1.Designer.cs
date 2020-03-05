namespace HexBinaryFileConverter
{
    partial class HexToBinary
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathtxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalPacketstextBox = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileSizetxtBox = new System.Windows.Forms.TextBox();
            this.ExtraBytesTextBox = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose file to convert : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilePathtxtbox
            // 
            this.FilePathtxtbox.Location = new System.Drawing.Point(206, 28);
            this.FilePathtxtbox.Name = "FilePathtxtbox";
            this.FilePathtxtbox.ReadOnly = true;
            this.FilePathtxtbox.Size = new System.Drawing.Size(215, 20);
            this.FilePathtxtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(101, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Size :  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(48, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Packets no. :";
            // 
            // TotalPacketstextBox
            // 
            this.TotalPacketstextBox.Location = new System.Drawing.Point(206, 132);
            this.TotalPacketstextBox.Name = "TotalPacketstextBox";
            this.TotalPacketstextBox.ReadOnly = true;
            this.TotalPacketstextBox.Size = new System.Drawing.Size(215, 20);
            this.TotalPacketstextBox.TabIndex = 6;
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.Color.White;
            this.Convert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Convert.Location = new System.Drawing.Point(35, 90);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(109, 31);
            this.Convert.TabIndex = 7;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(87, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Extra Bytes :";
            // 
            // FileSizetxtBox
            // 
            this.FileSizetxtBox.Location = new System.Drawing.Point(206, 79);
            this.FileSizetxtBox.Name = "FileSizetxtBox";
            this.FileSizetxtBox.ReadOnly = true;
            this.FileSizetxtBox.Size = new System.Drawing.Size(215, 20);
            this.FileSizetxtBox.TabIndex = 4;
            // 
            // ExtraBytesTextBox
            // 
            this.ExtraBytesTextBox.Location = new System.Drawing.Point(206, 179);
            this.ExtraBytesTextBox.Name = "ExtraBytesTextBox";
            this.ExtraBytesTextBox.ReadOnly = true;
            this.ExtraBytesTextBox.Size = new System.Drawing.Size(215, 20);
            this.ExtraBytesTextBox.TabIndex = 9;
            this.ExtraBytesTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.White;
            this.Output.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Output.Location = new System.Drawing.Point(35, 139);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(109, 32);
            this.Output.TabIndex = 10;
            this.Output.Text = "Open Output";
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.Color.White;
            this.Select.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Select.Location = new System.Drawing.Point(35, 38);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(109, 32);
            this.Select.TabIndex = 11;
            this.Select.Text = "Select File";
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Select);
            this.groupBox1.Controls.Add(this.Output);
            this.groupBox1.Controls.Add(this.Convert);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(458, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "3:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "1:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // HexToBinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(622, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExtraBytesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalPacketstextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileSizetxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilePathtxtbox);
            this.Controls.Add(this.label1);
            this.Name = "HexToBinary";
            this.Text = "HexToBinary";
            this.Load += new System.EventHandler(this.HexToBinary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathtxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalPacketstextBox;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileSizetxtBox;
        private System.Windows.Forms.TextBox ExtraBytesTextBox;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

