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
            this.barOut = new Caster.Bar();
            this.barMicIn = new Caster.Bar();
            this.volumeIncreaseTimer = new System.Windows.Forms.Timer(this.components);
            this.volumeDecreaseTimer = new System.Windows.Forms.Timer(this.components);
            this.increaseDelayTimer = new System.Windows.Forms.Timer(this.components);
            this.nudMicBoost = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudIncDelay = new System.Windows.Forms.NumericUpDown();
            this.nudMicThreshold = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudDecTime = new System.Windows.Forms.NumericUpDown();
            this.nudIncTime = new System.Windows.Forms.NumericUpDown();
            this.btnUseCurrentMin = new System.Windows.Forms.Button();
            this.btnUseCurrentMax = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMicBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMicThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barOut
            // 
            this.barOut.BackColor = System.Drawing.Color.DeepPink;
            this.barOut.BarColor = System.Drawing.Color.MediumSpringGreen;
            this.barOut.Location = new System.Drawing.Point(19, 77);
            this.barOut.Margin = new System.Windows.Forms.Padding(4);
            this.barOut.Name = "barOut";
            this.barOut.OutlineColor = System.Drawing.Color.Black;
            this.barOut.ShowThresholdValue = true;
            this.barOut.Size = new System.Drawing.Size(35, 297);
            this.barOut.TabIndex = 1;
            this.barOut.ThresholdValue = 0;
            this.barOut.ThresholdValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.barOut.Value = 50;
            // 
            // barMicIn
            // 
            this.barMicIn.BackColor = System.Drawing.Color.DeepPink;
            this.barMicIn.BarColor = System.Drawing.Color.MediumSpringGreen;
            this.barMicIn.Location = new System.Drawing.Point(85, 77);
            this.barMicIn.Margin = new System.Windows.Forms.Padding(4);
            this.barMicIn.Name = "barMicIn";
            this.barMicIn.OutlineColor = System.Drawing.Color.Black;
            this.barMicIn.ShowThresholdValue = true;
            this.barMicIn.Size = new System.Drawing.Size(35, 297);
            this.barMicIn.TabIndex = 0;
            this.barMicIn.ThresholdValue = 20;
            this.barMicIn.ThresholdValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.barMicIn.Value = 50;
            this.barMicIn.ReachedThreshold += new System.EventHandler(this.barMicIn_ReachedThreshold);
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
            this.increaseDelayTimer.Interval = 16;
            this.increaseDelayTimer.Tick += new System.EventHandler(this.increaseDelayTimer_Tick);
            // 
            // nudMicBoost
            // 
            this.nudMicBoost.DecimalPlaces = 1;
            this.nudMicBoost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMicBoost.Location = new System.Drawing.Point(7, 58);
            this.nudMicBoost.Margin = new System.Windows.Forms.Padding(4);
            this.nudMicBoost.Name = "nudMicBoost";
            this.nudMicBoost.Size = new System.Drawing.Size(77, 27);
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
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Master Peak";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(74, 27);
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
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mic boost:";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(7, 121);
            this.nudMax.Margin = new System.Windows.Forms.Padding(4);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(77, 27);
            this.nudMax.TabIndex = 5;
            this.nudMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMax.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(7, 178);
            this.nudMin.Margin = new System.Windows.Forms.Padding(4);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(77, 27);
            this.nudMin.TabIndex = 6;
            this.nudMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMin.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudIncDelay);
            this.groupBox1.Controls.Add(this.nudMicThreshold);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nudDecTime);
            this.groupBox1.Controls.Add(this.nudIncTime);
            this.groupBox1.Controls.Add(this.btnUseCurrentMin);
            this.groupBox1.Controls.Add(this.btnUseCurrentMax);
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
            this.groupBox1.Size = new System.Drawing.Size(275, 381);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // nudIncDelay
            // 
            this.nudIncDelay.Location = new System.Drawing.Point(7, 347);
            this.nudIncDelay.Margin = new System.Windows.Forms.Padding(4);
            this.nudIncDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudIncDelay.Name = "nudIncDelay";
            this.nudIncDelay.Size = new System.Drawing.Size(77, 27);
            this.nudIncDelay.TabIndex = 12;
            this.nudIncDelay.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudIncDelay.ValueChanged += new System.EventHandler(this.nudMicThreshold_ValueChanged);
            // 
            // nudMicThreshold
            // 
            this.nudMicThreshold.Location = new System.Drawing.Point(153, 58);
            this.nudMicThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.nudMicThreshold.Name = "nudMicThreshold";
            this.nudMicThreshold.Size = new System.Drawing.Size(77, 27);
            this.nudMicThreshold.TabIndex = 12;
            this.nudMicThreshold.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMicThreshold.ValueChanged += new System.EventHandler(this.nudMicThreshold_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mic threshold:";
            // 
            // nudDecTime
            // 
            this.nudDecTime.Location = new System.Drawing.Point(7, 289);
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
            this.nudDecTime.Size = new System.Drawing.Size(77, 27);
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
            this.nudIncTime.Location = new System.Drawing.Point(7, 234);
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
            this.nudIncTime.Size = new System.Drawing.Size(77, 27);
            this.nudIncTime.TabIndex = 9;
            this.nudIncTime.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudIncTime.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // btnUseCurrentMin
            // 
            this.btnUseCurrentMin.Location = new System.Drawing.Point(153, 178);
            this.btnUseCurrentMin.Name = "btnUseCurrentMin";
            this.btnUseCurrentMin.Size = new System.Drawing.Size(113, 27);
            this.btnUseCurrentMin.TabIndex = 8;
            this.btnUseCurrentMin.Text = "USE CURRENT";
            this.btnUseCurrentMin.UseVisualStyleBackColor = true;
            this.btnUseCurrentMin.Click += new System.EventHandler(this.btnUseCurrentMin_Click);
            // 
            // btnUseCurrentMax
            // 
            this.btnUseCurrentMax.Location = new System.Drawing.Point(153, 121);
            this.btnUseCurrentMax.Name = "btnUseCurrentMax";
            this.btnUseCurrentMax.Size = new System.Drawing.Size(113, 27);
            this.btnUseCurrentMax.TabIndex = 8;
            this.btnUseCurrentMax.Text = "USE CURRENT";
            this.btnUseCurrentMax.UseVisualStyleBackColor = true;
            this.btnUseCurrentMax.Click += new System.EventHandler(this.btnUseCurrentMax_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Decrease time [ms]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Increase time [ms]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Min volume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max volume:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Increase delay [ms]:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.barMicIn);
            this.groupBox2.Controls.Add(this.barOut);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(293, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 381);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 444);
            this.MinimumSize = new System.Drawing.Size(460, 444);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caster";
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
            this.ResumeLayout(false);

        }

        #endregion
        private Bar barMicIn;
        private Bar barOut;
        private System.Windows.Forms.Timer volumeIncreaseTimer;
        private System.Windows.Forms.Timer volumeDecreaseTimer;
        private System.Windows.Forms.Timer increaseDelayTimer;
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
        private System.Windows.Forms.Button btnUseCurrentMin;
        private System.Windows.Forms.Button btnUseCurrentMax;
        private System.Windows.Forms.NumericUpDown nudIncTime;
        private System.Windows.Forms.NumericUpDown nudDecTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMicThreshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudIncDelay;
        private System.Windows.Forms.Label label9;
    }
}

