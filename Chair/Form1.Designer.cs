namespace Chair
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
            this.button1 = new System.Windows.Forms.Button();
            this.TopDiaTextBox1 = new System.Windows.Forms.TextBox();
            this.TopDiameter = new System.Windows.Forms.Label();
            this.BottomDiaTextBox2 = new System.Windows.Forms.TextBox();
            this.BottomDiameter = new System.Windows.Forms.Label();
            this.StiffCountTextBox1 = new System.Windows.Forms.TextBox();
            this.StiffCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Chair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TopDiaTextBox1
            // 
            this.TopDiaTextBox1.Location = new System.Drawing.Point(129, 35);
            this.TopDiaTextBox1.Name = "TopDiaTextBox1";
            this.TopDiaTextBox1.Size = new System.Drawing.Size(100, 22);
            this.TopDiaTextBox1.TabIndex = 1;
            this.TopDiaTextBox1.Text = "3520";
            // 
            // TopDia
            // 
            this.TopDiameter.AutoSize = true;
            this.TopDiameter.Location = new System.Drawing.Point(35, 41);
            this.TopDiameter.Name = "TopDia";
            this.TopDiameter.Size = new System.Drawing.Size(56, 16);
            this.TopDiameter.TabIndex = 2;
            this.TopDiameter.Text = "Top Dia";
            // 
            // BottomDiaTextBox2
            // 
            this.BottomDiaTextBox2.Location = new System.Drawing.Point(129, 87);
            this.BottomDiaTextBox2.Name = "BottomDiaTextBox2";
            this.BottomDiaTextBox2.Size = new System.Drawing.Size(100, 22);
            this.BottomDiaTextBox2.TabIndex = 3;
            this.BottomDiaTextBox2.Text = "3520";
            // 
            // BottomDia
            // 
            this.BottomDiameter.AutoSize = true;
            this.BottomDiameter.Location = new System.Drawing.Point(35, 93);
            this.BottomDiameter.Name = "BottomDia";
            this.BottomDiameter.Size = new System.Drawing.Size(73, 16);
            this.BottomDiameter.TabIndex = 4;
            this.BottomDiameter.Text = "Bottom Dia";
            // 
            // StiffCountTextBox1
            // 
            this.StiffCountTextBox1.Location = new System.Drawing.Point(129, 146);
            this.StiffCountTextBox1.Name = "StiffCountTextBox1";
            this.StiffCountTextBox1.Size = new System.Drawing.Size(100, 22);
            this.StiffCountTextBox1.TabIndex = 5;
            this.StiffCountTextBox1.Text = "2";
            // 
            // StiffCount
            // 
            this.StiffCount.AutoSize = true;
            this.StiffCount.Location = new System.Drawing.Point(35, 149);
            this.StiffCount.Name = "StiffCount";
            this.StiffCount.Size = new System.Drawing.Size(90, 16);
            this.StiffCount.TabIndex = 6;
            this.StiffCount.Text = "Stiffener count";
            this.StiffCount.Click += new System.EventHandler(this.StiffCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 283);
            this.Controls.Add(this.StiffCount);
            this.Controls.Add(this.StiffCountTextBox1);
            this.Controls.Add(this.BottomDiameter);
            this.Controls.Add(this.BottomDiaTextBox2);
            this.Controls.Add(this.TopDiameter);
            this.Controls.Add(this.TopDiaTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TopDiaTextBox1;
        private System.Windows.Forms.Label TopDiameter;
        private System.Windows.Forms.TextBox BottomDiaTextBox2;
        private System.Windows.Forms.Label BottomDiameter;
        private System.Windows.Forms.TextBox StiffCountTextBox1;
        private System.Windows.Forms.Label StiffCount;
    }
}

