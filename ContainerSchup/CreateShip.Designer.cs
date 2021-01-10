namespace ContainerSchup
{
    partial class CreateShip
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
            this.LengthNUM = new System.Windows.Forms.NumericUpDown();
            this.LengthLBL = new System.Windows.Forms.Label();
            this.WidthNUM = new System.Windows.Forms.NumericUpDown();
            this.WidthLBL = new System.Windows.Forms.Label();
            this.WeigthLBL = new System.Windows.Forms.Label();
            this.WeightNUM = new System.Windows.Forms.NumericUpDown();
            this.CreateBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // LengthNUM
            // 
            this.LengthNUM.Location = new System.Drawing.Point(12, 25);
            this.LengthNUM.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.LengthNUM.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LengthNUM.Name = "LengthNUM";
            this.LengthNUM.Size = new System.Drawing.Size(143, 20);
            this.LengthNUM.TabIndex = 0;
            this.LengthNUM.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LengthLBL
            // 
            this.LengthLBL.AutoSize = true;
            this.LengthLBL.Location = new System.Drawing.Point(9, 9);
            this.LengthLBL.Name = "LengthLBL";
            this.LengthLBL.Size = new System.Drawing.Size(43, 13);
            this.LengthLBL.TabIndex = 1;
            this.LengthLBL.Text = "Length:";
            // 
            // WidthNUM
            // 
            this.WidthNUM.Location = new System.Drawing.Point(12, 64);
            this.WidthNUM.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.WidthNUM.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.WidthNUM.Name = "WidthNUM";
            this.WidthNUM.Size = new System.Drawing.Size(143, 20);
            this.WidthNUM.TabIndex = 2;
            this.WidthNUM.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // WidthLBL
            // 
            this.WidthLBL.AutoSize = true;
            this.WidthLBL.Location = new System.Drawing.Point(9, 48);
            this.WidthLBL.Name = "WidthLBL";
            this.WidthLBL.Size = new System.Drawing.Size(38, 13);
            this.WidthLBL.TabIndex = 3;
            this.WidthLBL.Text = "Width:";
            // 
            // WeigthLBL
            // 
            this.WeigthLBL.AutoSize = true;
            this.WeigthLBL.Location = new System.Drawing.Point(9, 87);
            this.WeigthLBL.Name = "WeigthLBL";
            this.WeigthLBL.Size = new System.Drawing.Size(98, 13);
            this.WeigthLBL.TabIndex = 5;
            this.WeigthLBL.Text = "Max weight in tons:";
            // 
            // WeightNUM
            // 
            this.WeightNUM.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.WeightNUM.Location = new System.Drawing.Point(12, 103);
            this.WeightNUM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WeightNUM.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.WeightNUM.Name = "WeightNUM";
            this.WeightNUM.Size = new System.Drawing.Size(143, 20);
            this.WeightNUM.TabIndex = 4;
            this.WeightNUM.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // CreateBTN
            // 
            this.CreateBTN.Location = new System.Drawing.Point(12, 134);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(143, 23);
            this.CreateBTN.TabIndex = 6;
            this.CreateBTN.Text = "Create";
            this.CreateBTN.UseVisualStyleBackColor = true;
            this.CreateBTN.Click += new System.EventHandler(this.CreateBTN_Click);
            // 
            // CreateShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 169);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.WeigthLBL);
            this.Controls.Add(this.WeightNUM);
            this.Controls.Add(this.WidthLBL);
            this.Controls.Add(this.WidthNUM);
            this.Controls.Add(this.LengthLBL);
            this.Controls.Add(this.LengthNUM);
            this.Name = "CreateShip";
            this.Text = "Create Ship";
            ((System.ComponentModel.ISupportInitialize)(this.LengthNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LengthNUM;
        private System.Windows.Forms.Label LengthLBL;
        private System.Windows.Forms.NumericUpDown WidthNUM;
        private System.Windows.Forms.Label WidthLBL;
        private System.Windows.Forms.Label WeigthLBL;
        private System.Windows.Forms.NumericUpDown WeightNUM;
        private System.Windows.Forms.Button CreateBTN;
    }
}

