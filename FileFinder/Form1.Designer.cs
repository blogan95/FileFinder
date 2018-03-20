namespace FileFinder
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
            this.ResultsBox = new System.Windows.Forms.ListBox();
            this.PathInput = new System.Windows.Forms.TextBox();
            this.StringInput = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.StringLabel = new System.Windows.Forms.Label();
            this.FileExtLabel = new System.Windows.Forms.Label();
            this.ExtInput = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsBox
            // 
            this.ResultsBox.FormattingEnabled = true;
            this.ResultsBox.HorizontalScrollbar = true;
            this.ResultsBox.ItemHeight = 16;
            this.ResultsBox.Location = new System.Drawing.Point(414, 88);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(411, 212);
            this.ResultsBox.TabIndex = 0;
            // 
            // PathInput
            // 
            this.PathInput.Location = new System.Drawing.Point(39, 30);
            this.PathInput.Name = "PathInput";
            this.PathInput.Size = new System.Drawing.Size(239, 22);
            this.PathInput.TabIndex = 1;
            this.PathInput.Text = "C:\\Users\\";
            // 
            // StringInput
            // 
            this.StringInput.Location = new System.Drawing.Point(39, 108);
            this.StringInput.Name = "StringInput";
            this.StringInput.Size = new System.Drawing.Size(239, 22);
            this.StringInput.TabIndex = 2;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.BackColor = System.Drawing.Color.Black;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PathLabel.Location = new System.Drawing.Point(38, 10);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(67, 17);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "File Path:";
            // 
            // StringLabel
            // 
            this.StringLabel.AutoSize = true;
            this.StringLabel.BackColor = System.Drawing.Color.Black;
            this.StringLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StringLabel.Location = new System.Drawing.Point(38, 88);
            this.StringLabel.Name = "StringLabel";
            this.StringLabel.Size = new System.Drawing.Size(98, 17);
            this.StringLabel.TabIndex = 5;
            this.StringLabel.Text = "Search String:";
            // 
            // FileExtLabel
            // 
            this.FileExtLabel.AutoSize = true;
            this.FileExtLabel.BackColor = System.Drawing.Color.Black;
            this.FileExtLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileExtLabel.Location = new System.Drawing.Point(38, 158);
            this.FileExtLabel.Name = "FileExtLabel";
            this.FileExtLabel.Size = new System.Drawing.Size(65, 17);
            this.FileExtLabel.TabIndex = 6;
            this.FileExtLabel.Text = "File Ext. :";
            // 
            // ExtInput
            // 
            this.ExtInput.FormattingEnabled = true;
            this.ExtInput.Items.AddRange(new object[] {
            ".JSON",
            ".TXT",
            ".XML",
            ".CONFIG"});
            this.ExtInput.Location = new System.Drawing.Point(39, 178);
            this.ExtInput.Name = "ExtInput";
            this.ExtInput.Size = new System.Drawing.Size(154, 24);
            this.ExtInput.TabIndex = 7;
            this.ExtInput.SelectedIndexChanged += new System.EventHandler(this.ExtInput_SelectChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(233, 170);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 32);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search File";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FileFinder.Properties.Resources.tumblr_oybs2s9suy1rrnmb0o1_500;
            this.ClientSize = new System.Drawing.Size(851, 484);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ExtInput);
            this.Controls.Add(this.FileExtLabel);
            this.Controls.Add(this.StringLabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.StringInput);
            this.Controls.Add(this.PathInput);
            this.Controls.Add(this.ResultsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ResultsBox;
        private System.Windows.Forms.TextBox PathInput;
        private System.Windows.Forms.TextBox StringInput;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label StringLabel;
        private System.Windows.Forms.Label FileExtLabel;
        private System.Windows.Forms.ComboBox ExtInput;
        private System.Windows.Forms.Button SearchButton;
    }
}

