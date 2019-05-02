namespace KathleensParty
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
            this.numberOfPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfPeople = new System.Windows.Forms.Label();
            this.fancyDecorationsCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyDecorationsCheckBox = new System.Windows.Forms.CheckBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfPeopleUpDown
            // 
            this.numberOfPeopleUpDown.Location = new System.Drawing.Point(34, 40);
            this.numberOfPeopleUpDown.Name = "numberOfPeopleUpDown";
            this.numberOfPeopleUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeopleUpDown.TabIndex = 0;
            this.numberOfPeopleUpDown.ValueChanged += new System.EventHandler(this.NumberOfPeopleUpDown_ValueChanged);
            // 
            // numberOfPeople
            // 
            this.numberOfPeople.AutoSize = true;
            this.numberOfPeople.Location = new System.Drawing.Point(34, 24);
            this.numberOfPeople.Name = "numberOfPeople";
            this.numberOfPeople.Size = new System.Drawing.Size(92, 13);
            this.numberOfPeople.TabIndex = 1;
            this.numberOfPeople.Text = "Number of People";
            // 
            // fancyDecorationsCheckBox
            // 
            this.fancyDecorationsCheckBox.AutoSize = true;
            this.fancyDecorationsCheckBox.Location = new System.Drawing.Point(34, 78);
            this.fancyDecorationsCheckBox.Name = "fancyDecorationsCheckBox";
            this.fancyDecorationsCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationsCheckBox.TabIndex = 2;
            this.fancyDecorationsCheckBox.Text = "Fancy Decorations";
            this.fancyDecorationsCheckBox.UseVisualStyleBackColor = true;
            this.fancyDecorationsCheckBox.CheckedChanged += new System.EventHandler(this.FancyDecorations_CheckedChanged);
            // 
            // healthyDecorationsCheckBox
            // 
            this.healthyDecorationsCheckBox.AutoSize = true;
            this.healthyDecorationsCheckBox.Location = new System.Drawing.Point(34, 101);
            this.healthyDecorationsCheckBox.Name = "healthyDecorationsCheckBox";
            this.healthyDecorationsCheckBox.Size = new System.Drawing.Size(122, 17);
            this.healthyDecorationsCheckBox.TabIndex = 3;
            this.healthyDecorationsCheckBox.Text = "Healthy Decorations";
            this.healthyDecorationsCheckBox.UseVisualStyleBackColor = true;
            this.healthyDecorationsCheckBox.CheckedChanged += new System.EventHandler(this.HealthyDecorations_CheckedChanged);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(34, 138);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(32, 13);
            this.totalCostLabel.TabIndex = 4;
            this.totalCostLabel.Text = "Cost";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(98, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 192);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.healthyDecorationsCheckBox);
            this.Controls.Add(this.fancyDecorationsCheckBox);
            this.Controls.Add(this.numberOfPeople);
            this.Controls.Add(this.numberOfPeopleUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberOfPeopleUpDown;
        private System.Windows.Forms.Label numberOfPeople;
        private System.Windows.Forms.CheckBox fancyDecorationsCheckBox;
        private System.Windows.Forms.CheckBox healthyDecorationsCheckBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label3;
    }
}

