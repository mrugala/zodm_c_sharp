namespace ZODMokienko
{
    partial class Okienko
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.suwX = new System.Windows.Forms.HScrollBar();
            this.suwY = new System.Windows.Forms.HScrollBar();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.numAlfa = new System.Windows.Forms.NumericUpDown();
            this.numBeta = new System.Windows.Forms.NumericUpDown();
            this.numGamma = new System.Windows.Forms.NumericUpDown();
            this.suwZ = new System.Windows.Forms.HScrollBar();
            this.suwAlfa = new System.Windows.Forms.HScrollBar();
            this.suwBeta = new System.Windows.Forms.HScrollBar();
            this.suwGamma = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // suwX
            // 
            this.suwX.Location = new System.Drawing.Point(155, 9);
            this.suwX.Maximum = 30;
            this.suwX.Minimum = -30;
            this.suwX.Name = "suwX";
            this.suwX.Size = new System.Drawing.Size(120, 20);
            this.suwX.TabIndex = 7;
            this.suwX.Value = 10;
            this.suwX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.suwX_Scroll);
            // 
            // suwY
            // 
            this.suwY.Location = new System.Drawing.Point(155, 35);
            this.suwY.Maximum = 30;
            this.suwY.Minimum = -30;
            this.suwY.Name = "suwY";
            this.suwY.Size = new System.Drawing.Size(120, 20);
            this.suwY.TabIndex = 8;
            this.suwY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.suwY_Scroll);
            // 
            // numX
            // 
            this.numX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numX.Location = new System.Drawing.Point(32, 9);
            this.numX.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 20);
            this.numX.TabIndex = 9;
            this.numX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numX.ValueChanged += new System.EventHandler(this.numX_ValueChanged);
            // 
            // numY
            // 
            this.numY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numY.Location = new System.Drawing.Point(32, 35);
            this.numY.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 20);
            this.numY.TabIndex = 10;
            this.numY.ValueChanged += new System.EventHandler(this.numY_ValueChanged);
            // 
            // numZ
            // 
            this.numZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numZ.Location = new System.Drawing.Point(32, 61);
            this.numZ.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(120, 20);
            this.numZ.TabIndex = 11;
            this.numZ.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numZ.ValueChanged += new System.EventHandler(this.numZ_ValueChanged);
            // 
            // numAlfa
            // 
            this.numAlfa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numAlfa.Location = new System.Drawing.Point(32, 87);
            this.numAlfa.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numAlfa.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numAlfa.Name = "numAlfa";
            this.numAlfa.Size = new System.Drawing.Size(120, 20);
            this.numAlfa.TabIndex = 12;
            this.numAlfa.ValueChanged += new System.EventHandler(this.numAlfa_ValueChanged);
            // 
            // numBeta
            // 
            this.numBeta.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numBeta.Location = new System.Drawing.Point(32, 113);
            this.numBeta.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numBeta.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numBeta.Name = "numBeta";
            this.numBeta.Size = new System.Drawing.Size(120, 20);
            this.numBeta.TabIndex = 13;
            this.numBeta.ValueChanged += new System.EventHandler(this.numBeta_ValueChanged);
            // 
            // numGamma
            // 
            this.numGamma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numGamma.Location = new System.Drawing.Point(32, 139);
            this.numGamma.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numGamma.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numGamma.Name = "numGamma";
            this.numGamma.Size = new System.Drawing.Size(120, 20);
            this.numGamma.TabIndex = 14;
            this.numGamma.ValueChanged += new System.EventHandler(this.numGamma_ValueChanged);
            // 
            // suwZ
            // 
            this.suwZ.Location = new System.Drawing.Point(155, 61);
            this.suwZ.Maximum = 30;
            this.suwZ.Name = "suwZ";
            this.suwZ.Size = new System.Drawing.Size(120, 20);
            this.suwZ.TabIndex = 15;
            this.suwZ.Value = 12;
            this.suwZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.suwZ_Scroll);
            // 
            // suwAlfa
            // 
            this.suwAlfa.Location = new System.Drawing.Point(155, 87);
            this.suwAlfa.Maximum = 180;
            this.suwAlfa.Minimum = -180;
            this.suwAlfa.Name = "suwAlfa";
            this.suwAlfa.Size = new System.Drawing.Size(120, 20);
            this.suwAlfa.TabIndex = 16;
            this.suwAlfa.Scroll += new System.Windows.Forms.ScrollEventHandler(this.suwAlfa_Scroll);
            // 
            // suwBeta
            // 
            this.suwBeta.Location = new System.Drawing.Point(155, 113);
            this.suwBeta.Maximum = 180;
            this.suwBeta.Minimum = -180;
            this.suwBeta.Name = "suwBeta";
            this.suwBeta.Size = new System.Drawing.Size(120, 20);
            this.suwBeta.TabIndex = 17;
            this.suwBeta.Scroll += new System.Windows.Forms.ScrollEventHandler(this.suwBeta_Scroll);
            // 
            // suwGamma
            // 
            this.suwGamma.Location = new System.Drawing.Point(155, 139);
            this.suwGamma.Maximum = 180;
            this.suwGamma.Minimum = -180;
            this.suwGamma.Name = "suwGamma";
            this.suwGamma.Size = new System.Drawing.Size(120, 20);
            this.suwGamma.TabIndex = 18;
            this.suwGamma.Scroll += new System.Windows.Forms.ScrollEventHandler(this.suwGamma_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 20);
            this.textBox2.TabIndex = 20;
            // 
            // Okienko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.suwGamma);
            this.Controls.Add(this.suwBeta);
            this.Controls.Add(this.suwAlfa);
            this.Controls.Add(this.suwZ);
            this.Controls.Add(this.numGamma);
            this.Controls.Add(this.numBeta);
            this.Controls.Add(this.numAlfa);
            this.Controls.Add(this.numZ);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.suwY);
            this.Controls.Add(this.suwX);
            this.Name = "Okienko";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HScrollBar suwX;
        private System.Windows.Forms.HScrollBar suwY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numZ;
        private System.Windows.Forms.NumericUpDown numAlfa;
        private System.Windows.Forms.NumericUpDown numBeta;
        private System.Windows.Forms.NumericUpDown numGamma;
        private System.Windows.Forms.HScrollBar suwZ;
        private System.Windows.Forms.HScrollBar suwAlfa;
        private System.Windows.Forms.HScrollBar suwBeta;
        private System.Windows.Forms.HScrollBar suwGamma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

