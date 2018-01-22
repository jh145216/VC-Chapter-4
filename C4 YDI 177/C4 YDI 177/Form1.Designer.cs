namespace C4_YDI_177
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
            this.dayBox = new System.Windows.Forms.TextBox();
            this.lblEnterADay = new System.Windows.Forms.Label();
            this.btnGetSpecial = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(133, 162);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(50, 20);
            this.dayBox.TabIndex = 0;
            // 
            // lblEnterADay
            // 
            this.lblEnterADay.AutoSize = true;
            this.lblEnterADay.Location = new System.Drawing.Point(71, 75);
            this.lblEnterADay.Name = "lblEnterADay";
            this.lblEnterADay.Size = new System.Drawing.Size(185, 13);
            this.lblEnterADay.TabIndex = 1;
            this.lblEnterADay.Text = "Enter a day number to see our special";
            // 
            // btnGetSpecial
            // 
            this.btnGetSpecial.Location = new System.Drawing.Point(121, 216);
            this.btnGetSpecial.Name = "btnGetSpecial";
            this.btnGetSpecial.Size = new System.Drawing.Size(75, 23);
            this.btnGetSpecial.TabIndex = 2;
            this.btnGetSpecial.Text = "Get Special";
            this.btnGetSpecial.UseVisualStyleBackColor = true;
            this.btnGetSpecial.Click += new System.EventHandler(this.btnGetSpecial_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(101, 114);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(124, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "For example, Sunday = 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 298);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.btnGetSpecial);
            this.Controls.Add(this.lblEnterADay);
            this.Controls.Add(this.dayBox);
            this.Name = "Form1";
            this.Text = "Chatterbox Diner Daily Special";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Label lblEnterADay;
        private System.Windows.Forms.Button btnGetSpecial;
        private System.Windows.Forms.Label outputLabel;
    }
}

