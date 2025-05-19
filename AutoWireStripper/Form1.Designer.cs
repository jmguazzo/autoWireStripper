namespace AutoWireStripper
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
            cmboSerial = new ComboBox();
            label1 = new Label();
            cmboSpeed = new ComboBox();
            label2 = new Label();
            txtLog = new TextBox();
            btnConnect = new Button();
            leftStripping = new NumericUpDown();
            wireLength = new NumericUpDown();
            rightStripping = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            btnAutoStrip = new Button();
            ((System.ComponentModel.ISupportInitialize)leftStripping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wireLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightStripping).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cmboSerial
            // 
            cmboSerial.FormattingEnabled = true;
            cmboSerial.Location = new Point(78, 6);
            cmboSerial.Name = "cmboSerial";
            cmboSerial.Size = new Size(121, 23);
            cmboSerial.TabIndex = 0;
            cmboSerial.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Port COM";
            // 
            // cmboSpeed
            // 
            cmboSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboSpeed.FormattingEnabled = true;
            cmboSpeed.Items.AddRange(new object[] { "115200", "230400", "250000" });
            cmboSpeed.Location = new Point(303, 6);
            cmboSpeed.Name = "cmboSpeed";
            cmboSpeed.Size = new Size(121, 23);
            cmboSpeed.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 9);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Bauds";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 35);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Both;
            txtLog.Size = new Size(412, 173);
            txtLog.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(509, 5);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // leftStripping
            // 
            leftStripping.Location = new Point(12, 257);
            leftStripping.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            leftStripping.Name = "leftStripping";
            leftStripping.Size = new Size(120, 23);
            leftStripping.TabIndex = 6;
            leftStripping.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // wireLength
            // 
            wireLength.Location = new Point(138, 257);
            wireLength.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            wireLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            wireLength.Name = "wireLength";
            wireLength.Size = new Size(120, 23);
            wireLength.TabIndex = 7;
            wireLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // rightStripping
            // 
            rightStripping.Location = new Point(264, 257);
            rightStripping.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rightStripping.Name = "rightStripping";
            rightStripping.Size = new Size(120, 23);
            rightStripping.TabIndex = 8;
            rightStripping.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 239);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 9;
            label3.Text = "Left stripping (mm)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 239);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 10;
            label4.Text = "Total wire length (mm)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 239);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 11;
            label5.Text = "Right stripping (mm)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 309);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 291);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 13;
            label6.Text = "Quantity";
            // 
            // btnAutoStrip
            // 
            btnAutoStrip.Location = new Point(264, 309);
            btnAutoStrip.Name = "btnAutoStrip";
            btnAutoStrip.Size = new Size(75, 23);
            btnAutoStrip.TabIndex = 14;
            btnAutoStrip.Text = "AutoStrip!";
            btnAutoStrip.UseVisualStyleBackColor = true;
            btnAutoStrip.Click += btnAutoStrip_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAutoStrip);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rightStripping);
            Controls.Add(wireLength);
            Controls.Add(leftStripping);
            Controls.Add(btnConnect);
            Controls.Add(txtLog);
            Controls.Add(label2);
            Controls.Add(cmboSpeed);
            Controls.Add(label1);
            Controls.Add(cmboSerial);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)leftStripping).EndInit();
            ((System.ComponentModel.ISupportInitialize)wireLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightStripping).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmboSerial;
        private Label label1;
        private ComboBox cmboSpeed;
        private Label label2;
        private TextBox txtLog;
        private Button btnConnect;
        private NumericUpDown leftStripping;
        private NumericUpDown wireLength;
        private NumericUpDown rightStripping;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Button btnAutoStrip;
    }
}