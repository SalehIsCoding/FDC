namespace FileDateChanger
{
    partial class Main
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.day = new System.Windows.Forms.NumericUpDown();
            this.sec = new System.Windows.Forms.NumericUpDown();
            this.minute = new System.Windows.Forms.NumericUpDown();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_Creation = new System.Windows.Forms.CheckBox();
            this.check_LastAccess = new System.Windows.Forms.CheckBox();
            this.check_LastWrite = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(20, 19);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(270, 31);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.month);
            this.groupBox1.Controls.Add(this.day);
            this.groupBox1.Controls.Add(this.sec);
            this.groupBox1.Controls.Add(this.minute);
            this.groupBox1.Controls.Add(this.hour);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(270, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DateTime";
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(136, 28);
            this.month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(45, 20);
            this.month.TabIndex = 1;
            this.month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(220, 28);
            this.day.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(45, 20);
            this.day.TabIndex = 1;
            this.day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(220, 59);
            this.sec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sec.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(45, 20);
            this.sec.TabIndex = 1;
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(136, 58);
            this.minute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(45, 20);
            this.minute.TabIndex = 1;
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(42, 58);
            this.hour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(45, 20);
            this.hour.TabIndex = 1;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(42, 28);
            this.year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.year.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(45, 20);
            this.year.TabIndex = 1;
            this.year.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hour:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sec:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Minute:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Day: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Month:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(20, 222);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(270, 31);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_LastWrite);
            this.groupBox2.Controls.Add(this.check_LastAccess);
            this.groupBox2.Controls.Add(this.check_Creation);
            this.groupBox2.Location = new System.Drawing.Point(20, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // check_Creation
            // 
            this.check_Creation.AutoSize = true;
            this.check_Creation.Location = new System.Drawing.Point(8, 19);
            this.check_Creation.Name = "check_Creation";
            this.check_Creation.Size = new System.Drawing.Size(91, 17);
            this.check_Creation.TabIndex = 0;
            this.check_Creation.Text = "Creation Time";
            this.check_Creation.UseVisualStyleBackColor = true;
            // 
            // check_LastAccess
            // 
            this.check_LastAccess.AutoSize = true;
            this.check_LastAccess.Location = new System.Drawing.Point(8, 44);
            this.check_LastAccess.Name = "check_LastAccess";
            this.check_LastAccess.Size = new System.Drawing.Size(110, 17);
            this.check_LastAccess.TabIndex = 0;
            this.check_LastAccess.Text = "Last Access Time";
            this.check_LastAccess.UseVisualStyleBackColor = true;
            // 
            // check_LastWrite
            // 
            this.check_LastWrite.AutoSize = true;
            this.check_LastWrite.Location = new System.Drawing.Point(136, 29);
            this.check_LastWrite.Name = "check_LastWrite";
            this.check_LastWrite.Size = new System.Drawing.Size(100, 17);
            this.check_LastWrite.TabIndex = 0;
            this.check_LastWrite.Text = "Last Write Time";
            this.check_LastWrite.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDC V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.NumericUpDown sec;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_LastAccess;
        private System.Windows.Forms.CheckBox check_Creation;
        private System.Windows.Forms.CheckBox check_LastWrite;
    }
}

