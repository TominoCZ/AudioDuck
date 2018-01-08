namespace Caster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudMicBoost = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudIncDelay = new System.Windows.Forms.NumericUpDown();
            this.nudMicThreshold = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudDecTime = new System.Windows.Forms.NumericUpDown();
            this.nudIncTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.barMicIn = new Caster.Bar();
            this.barOut = new Caster.Bar();
            this.volumeIncreaseTimer = new System.Windows.Forms.Timer(this.components);
            this.volumeDecreaseTimer = new System.Windows.Forms.Timer(this.components);
            this.increaseDelayTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddException = new System.Windows.Forms.Button();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.lbExceptions = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMicBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMicThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudMicBoost
            // 
            this.nudMicBoost.DecimalPlaces = 1;
            this.nudMicBoost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMicBoost.Location = new System.Drawing.Point(7, 107);
            this.nudMicBoost.Margin = new System.Windows.Forms.Padding(4);
            this.nudMicBoost.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMicBoost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMicBoost.Name = "nudMicBoost";
            this.nudMicBoost.Size = new System.Drawing.Size(57, 27);
            this.nudMicBoost.TabIndex = 2;
            this.nudMicBoost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMicBoost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMicBoost.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Master Peak";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(74, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mic Peak";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mic boost:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(7, 164);
            this.nudMax.Margin = new System.Windows.Forms.Padding(4);
            this.nudMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(57, 27);
            this.nudMax.TabIndex = 5;
            this.nudMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMax.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(8, 221);
            this.nudMin.Margin = new System.Windows.Forms.Padding(4);
            this.nudMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(57, 27);
            this.nudMin.TabIndex = 6;
            this.nudMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMin.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudIncDelay);
            this.groupBox1.Controls.Add(this.nudMicThreshold);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nudDecTime);
            this.groupBox1.Controls.Add(this.nudIncTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.nudMax);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudMicBoost);
            this.groupBox1.Location = new System.Drawing.Point(192, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 422);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "ms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "ms";
            // 
            // nudIncDelay
            // 
            this.nudIncDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudIncDelay.Location = new System.Drawing.Point(7, 388);
            this.nudIncDelay.Margin = new System.Windows.Forms.Padding(4);
            this.nudIncDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudIncDelay.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudIncDelay.Name = "nudIncDelay";
            this.nudIncDelay.Size = new System.Drawing.Size(57, 27);
            this.nudIncDelay.TabIndex = 12;
            this.nudIncDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIncDelay.Value = new decimal(new int[] {
            1750,
            0,
            0,
            0});
            this.nudIncDelay.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudMicThreshold
            // 
            this.nudMicThreshold.Location = new System.Drawing.Point(7, 50);
            this.nudMicThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.nudMicThreshold.Name = "nudMicThreshold";
            this.nudMicThreshold.Size = new System.Drawing.Size(57, 27);
            this.nudMicThreshold.TabIndex = 12;
            this.nudMicThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMicThreshold.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMicThreshold.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mic threshold:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDecTime
            // 
            this.nudDecTime.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDecTime.Location = new System.Drawing.Point(7, 332);
            this.nudDecTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudDecTime.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDecTime.Name = "nudDecTime";
            this.nudDecTime.Size = new System.Drawing.Size(57, 27);
            this.nudDecTime.TabIndex = 9;
            this.nudDecTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDecTime.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudDecTime.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudIncTime
            // 
            this.nudIncTime.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudIncTime.Location = new System.Drawing.Point(7, 277);
            this.nudIncTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudIncTime.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudIncTime.Name = "nudIncTime";
            this.nudIncTime.Size = new System.Drawing.Size(57, 27);
            this.nudIncTime.TabIndex = 9;
            this.nudIncTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIncTime.Value = new decimal(new int[] {
            1750,
            0,
            0,
            0});
            this.nudIncTime.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Decrease time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Increase time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Min volume:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max volume:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Increase delay:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.barMicIn);
            this.groupBox2.Controls.Add(this.barOut);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(333, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 422);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // barMicIn
            // 
            this.barMicIn.BackColor = System.Drawing.Color.DeepPink;
            this.barMicIn.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.barMicIn.Location = new System.Drawing.Point(85, 73);
            this.barMicIn.Margin = new System.Windows.Forms.Padding(4);
            this.barMicIn.Name = "barMicIn";
            this.barMicIn.OutlineColor = System.Drawing.Color.Black;
            this.barMicIn.ShowThresholdValue = true;
            this.barMicIn.Size = new System.Drawing.Size(35, 342);
            this.barMicIn.TabIndex = 0;
            this.barMicIn.ThresholdValue = 100;
            this.barMicIn.ThresholdValueColor = System.Drawing.Color.Yellow;
            this.barMicIn.Value = 0;
            this.barMicIn.ReachedThreshold += new System.EventHandler(this.barMicIn_ReachedThreshold);
            // 
            // barOut
            // 
            this.barOut.BackColor = System.Drawing.Color.DeepPink;
            this.barOut.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.barOut.Location = new System.Drawing.Point(19, 73);
            this.barOut.Margin = new System.Windows.Forms.Padding(4);
            this.barOut.Name = "barOut";
            this.barOut.OutlineColor = System.Drawing.Color.Black;
            this.barOut.ShowThresholdValue = true;
            this.barOut.Size = new System.Drawing.Size(35, 342);
            this.barOut.TabIndex = 1;
            this.barOut.ThresholdValue = 0;
            this.barOut.ThresholdValueColor = System.Drawing.Color.Yellow;
            this.barOut.Value = 0;
            // 
            // volumeIncreaseTimer
            // 
            this.volumeIncreaseTimer.Tick += new System.EventHandler(this.volumeIncreaseTimer_Tick);
            // 
            // volumeDecreaseTimer
            // 
            this.volumeDecreaseTimer.Tick += new System.EventHandler(this.volumeDecreaseTimer_Tick);
            // 
            // increaseDelayTimer
            // 
            this.increaseDelayTimer.Tick += new System.EventHandler(this.increaseDelayTimer_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnAddException);
            this.groupBox3.Controls.Add(this.tbProcessName);
            this.groupBox3.Controls.Add(this.lbExceptions);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 422);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exceptions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Process name:";
            // 
            // btnAddException
            // 
            this.btnAddException.Enabled = false;
            this.btnAddException.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddException.Location = new System.Drawing.Point(6, 82);
            this.btnAddException.Name = "btnAddException";
            this.btnAddException.Size = new System.Drawing.Size(162, 33);
            this.btnAddException.TabIndex = 2;
            this.btnAddException.Text = "ADD";
            this.btnAddException.UseVisualStyleBackColor = true;
            this.btnAddException.Click += new System.EventHandler(this.btnAddException_Click);
            // 
            // tbProcessName
            // 
            this.tbProcessName.Location = new System.Drawing.Point(6, 49);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(162, 27);
            this.tbProcessName.TabIndex = 1;
            this.tbProcessName.TextChanged += new System.EventHandler(this.tbProcessName_TextChanged);
            this.tbProcessName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProcessName_KeyDown);
            // 
            // lbExceptions
            // 
            this.lbExceptions.FormattingEnabled = true;
            this.lbExceptions.IntegralHeight = false;
            this.lbExceptions.ItemHeight = 19;
            this.lbExceptions.Location = new System.Drawing.Point(6, 121);
            this.lbExceptions.Name = "lbExceptions";
            this.lbExceptions.Size = new System.Drawing.Size(162, 295);
            this.lbExceptions.TabIndex = 0;
            this.lbExceptions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbExceptions_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 485);
            this.MinimumSize = new System.Drawing.Size(500, 485);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caster";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudMicBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMicThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bar barMicIn;
        private Bar barOut;
        private System.Windows.Forms.NumericUpDown nudMicBoost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudIncTime;
        private System.Windows.Forms.NumericUpDown nudDecTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMicThreshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudIncDelay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer volumeIncreaseTimer;
        private System.Windows.Forms.Timer volumeDecreaseTimer;
        private System.Windows.Forms.Timer increaseDelayTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbExceptions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddException;
        private System.Windows.Forms.TextBox tbProcessName;
    }
}

