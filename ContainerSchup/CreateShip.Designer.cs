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
            this.VisualizeBTN = new System.Windows.Forms.Button();
            this.AmountOfContainersNUM = new System.Windows.Forms.NumericUpDown();
            this.CooledCB = new System.Windows.Forms.CheckBox();
            this.ValuebleCB = new System.Windows.Forms.CheckBox();
            this.AmountOfContainerLBL = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddContainerBTN = new System.Windows.Forms.Button();
            this.MinimumWeightTB = new System.Windows.Forms.TextBox();
            this.MinWeightLBL = new System.Windows.Forms.Label();
            this.CurrentWeightTB = new System.Windows.Forms.TextBox();
            this.CurrentWeightLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfContainersNUM)).BeginInit();
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
            this.LengthNUM.ValueChanged += new System.EventHandler(this.ShipSizeChanged);
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
            this.WidthNUM.ValueChanged += new System.EventHandler(this.ShipSizeChanged);
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
            // VisualizeBTN
            // 
            this.VisualizeBTN.Location = new System.Drawing.Point(493, 357);
            this.VisualizeBTN.Name = "VisualizeBTN";
            this.VisualizeBTN.Size = new System.Drawing.Size(143, 23);
            this.VisualizeBTN.TabIndex = 6;
            this.VisualizeBTN.Text = "Visualize";
            this.VisualizeBTN.UseVisualStyleBackColor = true;
            this.VisualizeBTN.Click += new System.EventHandler(this.VisualizeBTN_Click);
            // 
            // AmountOfContainersNUM
            // 
            this.AmountOfContainersNUM.Location = new System.Drawing.Point(12, 212);
            this.AmountOfContainersNUM.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.AmountOfContainersNUM.Name = "AmountOfContainersNUM";
            this.AmountOfContainersNUM.Size = new System.Drawing.Size(120, 20);
            this.AmountOfContainersNUM.TabIndex = 7;
            // 
            // CooledCB
            // 
            this.CooledCB.AutoSize = true;
            this.CooledCB.Location = new System.Drawing.Point(12, 238);
            this.CooledCB.Name = "CooledCB";
            this.CooledCB.Size = new System.Drawing.Size(59, 17);
            this.CooledCB.TabIndex = 8;
            this.CooledCB.Text = "Cooled";
            this.CooledCB.UseVisualStyleBackColor = true;
            // 
            // ValuebleCB
            // 
            this.ValuebleCB.AutoSize = true;
            this.ValuebleCB.Location = new System.Drawing.Point(12, 261);
            this.ValuebleCB.Name = "ValuebleCB";
            this.ValuebleCB.Size = new System.Drawing.Size(67, 17);
            this.ValuebleCB.TabIndex = 9;
            this.ValuebleCB.Text = "Valueble";
            this.ValuebleCB.UseVisualStyleBackColor = true;
            // 
            // AmountOfContainerLBL
            // 
            this.AmountOfContainerLBL.AutoSize = true;
            this.AmountOfContainerLBL.Location = new System.Drawing.Point(9, 196);
            this.AmountOfContainerLBL.Name = "AmountOfContainerLBL";
            this.AmountOfContainerLBL.Size = new System.Drawing.Size(110, 13);
            this.AmountOfContainerLBL.TabIndex = 10;
            this.AmountOfContainerLBL.Text = "Amount of containers:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(195, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 355);
            this.listBox1.TabIndex = 11;
            // 
            // AddContainerBTN
            // 
            this.AddContainerBTN.Location = new System.Drawing.Point(12, 284);
            this.AddContainerBTN.Name = "AddContainerBTN";
            this.AddContainerBTN.Size = new System.Drawing.Size(120, 23);
            this.AddContainerBTN.TabIndex = 12;
            this.AddContainerBTN.Text = "Add Containers";
            this.AddContainerBTN.UseVisualStyleBackColor = true;
            this.AddContainerBTN.Click += new System.EventHandler(this.AddContainerBTN_Click);
            // 
            // MinimumWeightTB
            // 
            this.MinimumWeightTB.Enabled = false;
            this.MinimumWeightTB.Location = new System.Drawing.Point(493, 41);
            this.MinimumWeightTB.Name = "MinimumWeightTB";
            this.MinimumWeightTB.Size = new System.Drawing.Size(100, 20);
            this.MinimumWeightTB.TabIndex = 13;
            // 
            // MinWeightLBL
            // 
            this.MinWeightLBL.AutoSize = true;
            this.MinWeightLBL.Location = new System.Drawing.Point(490, 25);
            this.MinWeightLBL.Name = "MinWeightLBL";
            this.MinWeightLBL.Size = new System.Drawing.Size(85, 13);
            this.MinWeightLBL.TabIndex = 14;
            this.MinWeightLBL.Text = "Minimum weight:";
            // 
            // CurrentWeightTB
            // 
            this.CurrentWeightTB.Enabled = false;
            this.CurrentWeightTB.Location = new System.Drawing.Point(493, 91);
            this.CurrentWeightTB.Name = "CurrentWeightTB";
            this.CurrentWeightTB.Size = new System.Drawing.Size(100, 20);
            this.CurrentWeightTB.TabIndex = 15;
            // 
            // CurrentWeightLBL
            // 
            this.CurrentWeightLBL.AutoSize = true;
            this.CurrentWeightLBL.Location = new System.Drawing.Point(490, 75);
            this.CurrentWeightLBL.Name = "CurrentWeightLBL";
            this.CurrentWeightLBL.Size = new System.Drawing.Size(78, 13);
            this.CurrentWeightLBL.TabIndex = 16;
            this.CurrentWeightLBL.Text = "Current weight:";
            // 
            // CreateShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 409);
            this.Controls.Add(this.CurrentWeightLBL);
            this.Controls.Add(this.CurrentWeightTB);
            this.Controls.Add(this.MinWeightLBL);
            this.Controls.Add(this.MinimumWeightTB);
            this.Controls.Add(this.AddContainerBTN);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AmountOfContainerLBL);
            this.Controls.Add(this.ValuebleCB);
            this.Controls.Add(this.CooledCB);
            this.Controls.Add(this.AmountOfContainersNUM);
            this.Controls.Add(this.VisualizeBTN);
            this.Controls.Add(this.WidthLBL);
            this.Controls.Add(this.WidthNUM);
            this.Controls.Add(this.LengthLBL);
            this.Controls.Add(this.LengthNUM);
            this.Name = "CreateShip";
            this.Text = "Create Ship";
            ((System.ComponentModel.ISupportInitialize)(this.LengthNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfContainersNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LengthNUM;
        private System.Windows.Forms.Label LengthLBL;
        private System.Windows.Forms.NumericUpDown WidthNUM;
        private System.Windows.Forms.Label WidthLBL;
        private System.Windows.Forms.Button VisualizeBTN;
        private System.Windows.Forms.NumericUpDown AmountOfContainersNUM;
        private System.Windows.Forms.CheckBox CooledCB;
        private System.Windows.Forms.CheckBox ValuebleCB;
        private System.Windows.Forms.Label AmountOfContainerLBL;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddContainerBTN;
        private System.Windows.Forms.TextBox MinimumWeightTB;
        private System.Windows.Forms.Label MinWeightLBL;
        private System.Windows.Forms.TextBox CurrentWeightTB;
        private System.Windows.Forms.Label CurrentWeightLBL;
    }
}

