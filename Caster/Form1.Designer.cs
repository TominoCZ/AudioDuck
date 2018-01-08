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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudMicBoost = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMicThreshold = new System.Windows.Forms.TrackBar();
            this.tbMicBoost = new System.Windows.Forms.TrackBar();
            this.tbMax = new System.Windows.Forms.TrackBar();
            this.tbMin = new System.Windows.Forms.TrackBar();
            this.tbIncTime = new System.Windows.Forms.TrackBar();
            this.tbDecTime = new System.Windows.Forms.TrackBar();
            this.tbIncDelay = new System.Windows.Forms.TrackBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudMicBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMicThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMicBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDecTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMicThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncTime)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.nudMicBoost.Location = new System.Drawing.Point(7, 113);
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
            this.nudMicBoost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMicBoost.ValueChanged += new System.EventHandler(this.valueChanged);
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
            this.label3.Location = new System.Drawing.Point(68, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mic boost:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(7, 170);
            this.nudMax.Margin = new System.Windows.Forms.Padding(4);
            this.nudMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(57, 27);
            this.nudMax.TabIndex = 5;
            this.nudMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMax.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(7, 227);
            this.nudMin.Margin = new System.Windows.Forms.Padding(4);
            this.nudMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(57, 27);
            this.nudMin.TabIndex = 6;
            this.nudMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMin.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMicThreshold);
            this.groupBox1.Controls.Add(this.tbMicBoost);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Controls.Add(this.tbIncTime);
            this.groupBox1.Controls.Add(this.tbDecTime);
            this.groupBox1.Controls.Add(this.tbIncDelay);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 437);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tbMicThreshold
            // 
            this.tbMicThreshold.AutoSize = false;
            this.tbMicThreshold.Location = new System.Drawing.Point(72, 58);
            this.tbMicThreshold.Maximum = 100;
            this.tbMicThreshold.Name = "tbMicThreshold";
            this.tbMicThreshold.Size = new System.Drawing.Size(194, 27);
            this.tbMicThreshold.TabIndex = 13;
            this.tbMicThreshold.TickFrequency = 25;
            this.tbMicThreshold.Value = 25;
            this.tbMicThreshold.Scroll += new System.EventHandler(this.tbMicThreshold_Scroll);
            this.tbMicThreshold.ValueChanged += new System.EventHandler(this.tbMax_ValueChanged);
            // 
            // tbMicBoost
            // 
            this.tbMicBoost.AutoSize = false;
            this.tbMicBoost.LargeChange = 10;
            this.tbMicBoost.Location = new System.Drawing.Point(72, 113);
            this.tbMicBoost.Maximum = 50;
            this.tbMicBoost.Minimum = 10;
            this.tbMicBoost.Name = "tbMicBoost";
            this.tbMicBoost.Size = new System.Drawing.Size(194, 27);
            this.tbMicBoost.TabIndex = 13;
            this.tbMicBoost.TickFrequency = 10;
            this.tbMicBoost.Value = 10;
            this.tbMicBoost.Scroll += new System.EventHandler(this.tbMicBoost_Scroll);
            this.tbMicBoost.ValueChanged += new System.EventHandler(this.tbMax_ValueChanged);
            // 
            // tbMax
            // 
            this.tbMax.AutoSize = false;
            this.tbMax.Location = new System.Drawing.Point(72, 165);
            this.tbMax.Maximum = 100;
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(194, 27);
            this.tbMax.TabIndex = 13;
            this.tbMax.TickFrequency = 25;
            this.tbMax.Value = 100;
            this.tbMax.ValueChanged += new System.EventHandler(this.tbMax_ValueChanged);
            // 
            // tbMin
            // 
            this.tbMin.AutoSize = false;
            this.tbMin.Location = new System.Drawing.Point(72, 222);
            this.tbMin.Maximum = 100;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(194, 27);
            this.tbMin.TabIndex = 13;
            this.tbMin.TickFrequency = 25;
            this.tbMin.Value = 25;
            this.tbMin.ValueChanged += new System.EventHandler(this.tbMin_ValueChanged);
            // 
            // tbIncTime
            // 
            this.tbIncTime.AutoSize = false;
            this.tbIncTime.LargeChange = 50;
            this.tbIncTime.Location = new System.Drawing.Point(72, 278);
            this.tbIncTime.Maximum = 5000;
            this.tbIncTime.Minimum = 150;
            this.tbIncTime.Name = "tbIncTime";
            this.tbIncTime.Size = new System.Drawing.Size(194, 27);
            this.tbIncTime.SmallChange = 10;
            this.tbIncTime.TabIndex = 13;
            this.tbIncTime.TickFrequency = 1225;
            this.tbIncTime.Value = 2000;
            this.tbIncTime.ValueChanged += new System.EventHandler(this.ibIncTime_ValueChanged);
            // 
            // tbDecTime
            // 
            this.tbDecTime.AutoSize = false;
            this.tbDecTime.LargeChange = 50;
            this.tbDecTime.Location = new System.Drawing.Point(72, 333);
            this.tbDecTime.Maximum = 5000;
            this.tbDecTime.Minimum = 150;
            this.tbDecTime.Name = "tbDecTime";
            this.tbDecTime.Size = new System.Drawing.Size(194, 27);
            this.tbDecTime.SmallChange = 10;
            this.tbDecTime.TabIndex = 13;
            this.tbDecTime.TickFrequency = 1225;
            this.tbDecTime.Value = 150;
            this.tbDecTime.ValueChanged += new System.EventHandler(this.tbDecTime_ValueChanged);
            // 
            // tbIncDelay
            // 
            this.tbIncDelay.AutoSize = false;
            this.tbIncDelay.LargeChange = 50;
            this.tbIncDelay.Location = new System.Drawing.Point(72, 391);
            this.tbIncDelay.Maximum = 5000;
            this.tbIncDelay.Minimum = 150;
            this.tbIncDelay.Name = "tbIncDelay";
            this.tbIncDelay.Size = new System.Drawing.Size(194, 27);
            this.tbIncDelay.SmallChange = 500;
            this.tbIncDelay.TabIndex = 13;
            this.tbIncDelay.TickFrequency = 1225;
            this.tbIncDelay.Value = 150;
            this.tbIncDelay.ValueChanged += new System.EventHandler(this.tbIncDelay_ValueChanged);
            // 
            // nudIncDelay
            // 
            this.nudIncDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudIncDelay.Location = new System.Drawing.Point(7, 396);
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
            this.nudIncDelay.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudIncDelay.ValueChanged += new System.EventHandler(this.nudMicThreshold_ValueChanged);
            // 
            // nudMicThreshold
            // 
            this.nudMicThreshold.Location = new System.Drawing.Point(7, 58);
            this.nudMicThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.nudMicThreshold.Name = "nudMicThreshold";
            this.nudMicThreshold.Size = new System.Drawing.Size(57, 27);
            this.nudMicThreshold.TabIndex = 12;
            this.nudMicThreshold.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudMicThreshold.ValueChanged += new System.EventHandler(this.nudMicThreshold_ValueChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(72, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 19);
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
            this.nudDecTime.Location = new System.Drawing.Point(7, 338);
            this.nudDecTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudDecTime.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudDecTime.Name = "nudDecTime";
            this.nudDecTime.Size = new System.Drawing.Size(57, 27);
            this.nudDecTime.TabIndex = 9;
            this.nudDecTime.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudDecTime.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // nudIncTime
            // 
            this.nudIncTime.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudIncTime.Location = new System.Drawing.Point(7, 283);
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
            this.nudIncTime.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudIncTime.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(72, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Decrease time [ms]:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(72, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Increase time [ms]:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(72, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Min volume:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(72, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max volume:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(72, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Increase delay [ms]:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.barMicIn);
            this.groupBox2.Controls.Add(this.barOut);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(293, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 437);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // barMicIn
            // 
            this.barMicIn.BackColor = System.Drawing.Color.DeepPink;
            this.barMicIn.BarColor = System.Drawing.Color.MediumSpringGreen;
            this.barMicIn.Location = new System.Drawing.Point(85, 73);
            this.barMicIn.Margin = new System.Windows.Forms.Padding(4);
            this.barMicIn.Name = "barMicIn";
            this.barMicIn.OutlineColor = System.Drawing.Color.Black;
            this.barMicIn.ShowThresholdValue = true;
            this.barMicIn.Size = new System.Drawing.Size(35, 357);
            this.barMicIn.TabIndex = 0;
            this.barMicIn.ThresholdValue = 25;
            this.barMicIn.ThresholdValueColor = System.Drawing.Color.Yellow;
            this.barMicIn.Value = 50;
            this.barMicIn.ReachedThreshold += new System.EventHandler(this.barMicIn_ReachedThreshold);
            // 
            // barOut
            // 
            this.barOut.BackColor = System.Drawing.Color.DeepPink;
            this.barOut.BarColor = System.Drawing.Color.MediumSpringGreen;
            this.barOut.Location = new System.Drawing.Point(19, 73);
            this.barOut.Margin = new System.Windows.Forms.Padding(4);
            this.barOut.Name = "barOut";
            this.barOut.OutlineColor = System.Drawing.Color.Black;
            this.barOut.ShowThresholdValue = true;
            this.barOut.Size = new System.Drawing.Size(35, 357);
            this.barOut.TabIndex = 1;
            this.barOut.ThresholdValue = 0;
            this.barOut.ThresholdValueColor = System.Drawing.Color.Yellow;
            this.barOut.Value = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 500);
            this.MinimumSize = new System.Drawing.Size(460, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caster";
            ((System.ComponentModel.ISupportInitialize)(this.nudMicBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMicThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMicBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDecTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIncDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMicThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.TrackBar tbMax;
        private System.Windows.Forms.TrackBar tbMin;
        private System.Windows.Forms.TrackBar tbIncTime;
        private System.Windows.Forms.TrackBar tbDecTime;
        private System.Windows.Forms.TrackBar tbIncDelay;
        private System.Windows.Forms.TrackBar tbMicThreshold;
        private System.Windows.Forms.TrackBar tbMicBoost;
    }
}

