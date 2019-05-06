namespace KathleenParty2._0
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.healthyDecorationsCheckBox = new System.Windows.Forms.CheckBox();
            this.fancyDecorationsCheckBox = new System.Windows.Forms.CheckBox();
            this.numberOfPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfPeople = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(209, 223);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.totalCostLabel);
            this.tabPage1.Controls.Add(this.healthyDecorationsCheckBox);
            this.tabPage1.Controls.Add(this.fancyDecorationsCheckBox);
            this.tabPage1.Controls.Add(this.numberOfPeopleUpDown);
            this.tabPage1.Controls.Add(this.numberOfPeople);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(201, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(58, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(20, 142);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(32, 13);
            this.totalCostLabel.TabIndex = 6;
            this.totalCostLabel.Text = "Cost";
            // 
            // healthyDecorationsCheckBox
            // 
            this.healthyDecorationsCheckBox.AutoSize = true;
            this.healthyDecorationsCheckBox.Location = new System.Drawing.Point(23, 105);
            this.healthyDecorationsCheckBox.Name = "healthyDecorationsCheckBox";
            this.healthyDecorationsCheckBox.Size = new System.Drawing.Size(122, 17);
            this.healthyDecorationsCheckBox.TabIndex = 5;
            this.healthyDecorationsCheckBox.Text = "Healthy Decorations";
            this.healthyDecorationsCheckBox.UseVisualStyleBackColor = true;
            this.healthyDecorationsCheckBox.CheckedChanged += new System.EventHandler(this.HealthyDecorationsCheckBox_CheckedChanged);
            // 
            // fancyDecorationsCheckBox
            // 
            this.fancyDecorationsCheckBox.AutoSize = true;
            this.fancyDecorationsCheckBox.Location = new System.Drawing.Point(23, 82);
            this.fancyDecorationsCheckBox.Name = "fancyDecorationsCheckBox";
            this.fancyDecorationsCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationsCheckBox.TabIndex = 4;
            this.fancyDecorationsCheckBox.Text = "Fancy Decorations";
            this.fancyDecorationsCheckBox.UseVisualStyleBackColor = true;
            this.fancyDecorationsCheckBox.CheckedChanged += new System.EventHandler(this.FancyDecorationsCheckBox_CheckedChanged);
            // 
            // numberOfPeopleUpDown
            // 
            this.numberOfPeopleUpDown.Location = new System.Drawing.Point(23, 45);
            this.numberOfPeopleUpDown.Name = "numberOfPeopleUpDown";
            this.numberOfPeopleUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberOfPeopleUpDown.TabIndex = 3;
            this.numberOfPeopleUpDown.ValueChanged += new System.EventHandler(this.NumberOfPeopleUpDown_ValueChanged);
            // 
            // numberOfPeople
            // 
            this.numberOfPeople.AutoSize = true;
            this.numberOfPeople.Location = new System.Drawing.Point(20, 18);
            this.numberOfPeople.Name = "numberOfPeople";
            this.numberOfPeople.Size = new System.Drawing.Size(92, 13);
            this.numberOfPeople.TabIndex = 2;
            this.numberOfPeople.Text = "Number of People";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(201, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(104, 114);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 7;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCost.Location = new System.Drawing.Point(82, 157);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(95, 19);
            this.birthdayCost.TabIndex = 6;
            this.birthdayCost.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(22, 131);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(155, 20);
            this.cakeWriting.TabIndex = 4;
            this.cakeWriting.TextChanged += new System.EventHandler(this.CakeWriting_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cake Writing";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(19, 90);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 2;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.FancyBirthday_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(19, 49);
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 20);
            this.numberBirthday.TabIndex = 0;
            this.numberBirthday.ValueChanged += new System.EventHandler(this.NumberBirthday_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 236);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.CheckBox healthyDecorationsCheckBox;
        private System.Windows.Forms.CheckBox fancyDecorationsCheckBox;
        private System.Windows.Forms.NumericUpDown numberOfPeopleUpDown;
        private System.Windows.Forms.Label numberOfPeople;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label tooLongLabel;
    }
}

