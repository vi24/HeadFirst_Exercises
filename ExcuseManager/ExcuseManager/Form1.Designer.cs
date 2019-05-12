namespace ExcuseManager
{
    partial class _excuse_manager_form
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
            this._excuse_textBox = new System.Windows.Forms.TextBox();
            this._excuse_label = new System.Windows.Forms.Label();
            this._results_label = new System.Windows.Forms.Label();
            this._last_used_label = new System.Windows.Forms.Label();
            this._file_date_label = new System.Windows.Forms.Label();
            this._results_textBox = new System.Windows.Forms.TextBox();
            this._file_date_time_label = new System.Windows.Forms.Label();
            this._last_used_date_picker = new System.Windows.Forms.DateTimePicker();
            this._folder_button = new System.Windows.Forms.Button();
            this._save_button = new System.Windows.Forms.Button();
            this._open_button = new System.Windows.Forms.Button();
            this._random_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _excuse_textBox
            // 
            this._excuse_textBox.Location = new System.Drawing.Point(131, 37);
            this._excuse_textBox.Name = "_excuse_textBox";
            this._excuse_textBox.Size = new System.Drawing.Size(249, 20);
            this._excuse_textBox.TabIndex = 0;
            // 
            // _excuse_label
            // 
            this._excuse_label.AutoSize = true;
            this._excuse_label.Location = new System.Drawing.Point(29, 37);
            this._excuse_label.Name = "_excuse_label";
            this._excuse_label.Size = new System.Drawing.Size(42, 13);
            this._excuse_label.TabIndex = 1;
            this._excuse_label.Text = "Excuse";
            // 
            // _results_label
            // 
            this._results_label.AutoSize = true;
            this._results_label.Location = new System.Drawing.Point(29, 85);
            this._results_label.Name = "_results_label";
            this._results_label.Size = new System.Drawing.Size(42, 13);
            this._results_label.TabIndex = 2;
            this._results_label.Text = "Results";
            // 
            // _last_used_label
            // 
            this._last_used_label.AutoSize = true;
            this._last_used_label.Location = new System.Drawing.Point(29, 132);
            this._last_used_label.Name = "_last_used_label";
            this._last_used_label.Size = new System.Drawing.Size(55, 13);
            this._last_used_label.TabIndex = 3;
            this._last_used_label.Text = "Last Used";
            // 
            // _file_date_label
            // 
            this._file_date_label.AutoSize = true;
            this._file_date_label.Location = new System.Drawing.Point(29, 177);
            this._file_date_label.Name = "_file_date_label";
            this._file_date_label.Size = new System.Drawing.Size(47, 13);
            this._file_date_label.TabIndex = 4;
            this._file_date_label.Text = "File date";
            // 
            // _results_textBox
            // 
            this._results_textBox.Location = new System.Drawing.Point(131, 85);
            this._results_textBox.Name = "_results_textBox";
            this._results_textBox.Size = new System.Drawing.Size(249, 20);
            this._results_textBox.TabIndex = 5;
            // 
            // _file_date_time_label
            // 
            this._file_date_time_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._file_date_time_label.Location = new System.Drawing.Point(131, 176);
            this._file_date_time_label.Name = "_file_date_time_label";
            this._file_date_time_label.Size = new System.Drawing.Size(249, 14);
            this._file_date_time_label.TabIndex = 6;
            // 
            // _last_used_date_picker
            // 
            this._last_used_date_picker.Location = new System.Drawing.Point(131, 132);
            this._last_used_date_picker.Name = "_last_used_date_picker";
            this._last_used_date_picker.Size = new System.Drawing.Size(249, 20);
            this._last_used_date_picker.TabIndex = 7;
            // 
            // _folder_button
            // 
            this._folder_button.Location = new System.Drawing.Point(32, 228);
            this._folder_button.Name = "_folder_button";
            this._folder_button.Size = new System.Drawing.Size(75, 23);
            this._folder_button.TabIndex = 8;
            this._folder_button.Text = "Folder";
            this._folder_button.UseVisualStyleBackColor = true;
            // 
            // _save_button
            // 
            this._save_button.Location = new System.Drawing.Point(113, 228);
            this._save_button.Name = "_save_button";
            this._save_button.Size = new System.Drawing.Size(75, 23);
            this._save_button.TabIndex = 9;
            this._save_button.Text = "Save";
            this._save_button.UseVisualStyleBackColor = true;
            // 
            // _open_button
            // 
            this._open_button.Location = new System.Drawing.Point(194, 228);
            this._open_button.Name = "_open_button";
            this._open_button.Size = new System.Drawing.Size(75, 23);
            this._open_button.TabIndex = 10;
            this._open_button.Text = "Open";
            this._open_button.UseVisualStyleBackColor = true;
            // 
            // _random_button
            // 
            this._random_button.Location = new System.Drawing.Point(284, 228);
            this._random_button.Name = "_random_button";
            this._random_button.Size = new System.Drawing.Size(96, 23);
            this._random_button.TabIndex = 11;
            this._random_button.Text = "Random";
            this._random_button.UseVisualStyleBackColor = true;
            // 
            // _excuse_manager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 281);
            this.Controls.Add(this._random_button);
            this.Controls.Add(this._open_button);
            this.Controls.Add(this._save_button);
            this.Controls.Add(this._folder_button);
            this.Controls.Add(this._last_used_date_picker);
            this.Controls.Add(this._file_date_time_label);
            this.Controls.Add(this._results_textBox);
            this.Controls.Add(this._file_date_label);
            this.Controls.Add(this._last_used_label);
            this.Controls.Add(this._results_label);
            this.Controls.Add(this._excuse_label);
            this.Controls.Add(this._excuse_textBox);
            this.Name = "_excuse_manager_form";
            this.Text = "Excuse Manager";
            this.Load += new System.EventHandler(this.ExcuseManagerFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _excuse_textBox;
        private System.Windows.Forms.Label _excuse_label;
        private System.Windows.Forms.Label _results_label;
        private System.Windows.Forms.Label _last_used_label;
        private System.Windows.Forms.Label _file_date_label;
        private System.Windows.Forms.TextBox _results_textBox;
        private System.Windows.Forms.Label _file_date_time_label;
        private System.Windows.Forms.DateTimePicker _last_used_date_picker;
        private System.Windows.Forms.Button _folder_button;
        private System.Windows.Forms.Button _save_button;
        private System.Windows.Forms.Button _open_button;
        private System.Windows.Forms.Button _random_button;
    }
}

