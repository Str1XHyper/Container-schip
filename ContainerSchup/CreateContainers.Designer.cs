namespace ContainerSchup
{
    partial class CreateContainers
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
            this.NormalNUM = new System.Windows.Forms.NumericUpDown();
            this.NormalContainerLBL = new System.Windows.Forms.Label();
            this.ValuebleContainerLBL = new System.Windows.Forms.Label();
            this.ValuebleNUM = new System.Windows.Forms.NumericUpDown();
            this.CooledContainerLBL = new System.Windows.Forms.Label();
            this.CooledNUM = new System.Windows.Forms.NumericUpDown();
            this.LoadShipBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NormalNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValuebleNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooledNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // NormalNUM
            // 
            this.NormalNUM.Location = new System.Drawing.Point(15, 25);
            this.NormalNUM.Name = "NormalNUM";
            this.NormalNUM.Size = new System.Drawing.Size(155, 20);
            this.NormalNUM.TabIndex = 0;
            // 
            // NormalContainerLBL
            // 
            this.NormalContainerLBL.AutoSize = true;
            this.NormalContainerLBL.Location = new System.Drawing.Point(12, 9);
            this.NormalContainerLBL.Name = "NormalContainerLBL";
            this.NormalContainerLBL.Size = new System.Drawing.Size(43, 13);
            this.NormalContainerLBL.TabIndex = 1;
            this.NormalContainerLBL.Text = "Normal:";
            // 
            // ValuebleContainerLBL
            // 
            this.ValuebleContainerLBL.AutoSize = true;
            this.ValuebleContainerLBL.Location = new System.Drawing.Point(12, 48);
            this.ValuebleContainerLBL.Name = "ValuebleContainerLBL";
            this.ValuebleContainerLBL.Size = new System.Drawing.Size(51, 13);
            this.ValuebleContainerLBL.TabIndex = 3;
            this.ValuebleContainerLBL.Text = "Valueble:";
            // 
            // ValuebleNUM
            // 
            this.ValuebleNUM.Location = new System.Drawing.Point(15, 64);
            this.ValuebleNUM.Name = "ValuebleNUM";
            this.ValuebleNUM.Size = new System.Drawing.Size(155, 20);
            this.ValuebleNUM.TabIndex = 2;
            // 
            // CooledContainerLBL
            // 
            this.CooledContainerLBL.AutoSize = true;
            this.CooledContainerLBL.Location = new System.Drawing.Point(12, 87);
            this.CooledContainerLBL.Name = "CooledContainerLBL";
            this.CooledContainerLBL.Size = new System.Drawing.Size(43, 13);
            this.CooledContainerLBL.TabIndex = 5;
            this.CooledContainerLBL.Text = "Cooled:";
            // 
            // CooledNUM
            // 
            this.CooledNUM.Location = new System.Drawing.Point(15, 103);
            this.CooledNUM.Name = "CooledNUM";
            this.CooledNUM.Size = new System.Drawing.Size(155, 20);
            this.CooledNUM.TabIndex = 4;
            // 
            // LoadShipBTN
            // 
            this.LoadShipBTN.Location = new System.Drawing.Point(12, 130);
            this.LoadShipBTN.Name = "LoadShipBTN";
            this.LoadShipBTN.Size = new System.Drawing.Size(158, 23);
            this.LoadShipBTN.TabIndex = 7;
            this.LoadShipBTN.Text = "Load ship";
            this.LoadShipBTN.UseVisualStyleBackColor = true;
            this.LoadShipBTN.Click += new System.EventHandler(this.LoadShipBTN_Click);
            // 
            // CreateContainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 165);
            this.Controls.Add(this.LoadShipBTN);
            this.Controls.Add(this.CooledContainerLBL);
            this.Controls.Add(this.CooledNUM);
            this.Controls.Add(this.ValuebleContainerLBL);
            this.Controls.Add(this.ValuebleNUM);
            this.Controls.Add(this.NormalContainerLBL);
            this.Controls.Add(this.NormalNUM);
            this.Name = "CreateContainers";
            this.Text = "CreateContainers";
            ((System.ComponentModel.ISupportInitialize)(this.NormalNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValuebleNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooledNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NormalNUM;
        private System.Windows.Forms.Label NormalContainerLBL;
        private System.Windows.Forms.Label ValuebleContainerLBL;
        private System.Windows.Forms.NumericUpDown ValuebleNUM;
        private System.Windows.Forms.Label CooledContainerLBL;
        private System.Windows.Forms.NumericUpDown CooledNUM;
        private System.Windows.Forms.Button LoadShipBTN;
    }
}