namespace DeColor
{
    partial class DeColorForm
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
            this._directoryLabel = new System.Windows.Forms.Label();
            this._directoryTextBox = new System.Windows.Forms.TextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._turnLabel = new System.Windows.Forms.Label();
            this._turnComboBox = new System.Windows.Forms.ComboBox();
            this._intoLabel = new System.Windows.Forms.Label();
            this._intoComboBox = new System.Windows.Forms.ComboBox();
            this._recursiveCheckBox = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // _directoryLabel
            // 
            this._directoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._directoryLabel.AutoSize = true;
            this._directoryLabel.Location = new System.Drawing.Point(13, 125);
            this._directoryLabel.Name = "_directoryLabel";
            this._directoryLabel.Size = new System.Drawing.Size(49, 13);
            this._directoryLabel.TabIndex = 0;
            this._directoryLabel.Text = "Directory";
            // 
            // _directoryTextBox
            // 
            this._directoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._directoryTextBox.Location = new System.Drawing.Point(16, 151);
            this._directoryTextBox.Name = "_directoryTextBox";
            this._directoryTextBox.Size = new System.Drawing.Size(459, 20);
            this._directoryTextBox.TabIndex = 1;
            // 
            // _browseButton
            // 
            this._browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._browseButton.Location = new System.Drawing.Point(481, 151);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(59, 20);
            this._browseButton.TabIndex = 2;
            this._browseButton.Text = "Browse";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this._browseButton_Click);
            // 
            // _turnLabel
            // 
            this._turnLabel.AutoSize = true;
            this._turnLabel.Location = new System.Drawing.Point(13, 22);
            this._turnLabel.Name = "_turnLabel";
            this._turnLabel.Size = new System.Drawing.Size(77, 13);
            this._turnLabel.TabIndex = 3;
            this._turnLabel.Text = "Turn all except";
            // 
            // _turnComboBox
            // 
            this._turnComboBox.FormattingEnabled = true;
            this._turnComboBox.Location = new System.Drawing.Point(116, 19);
            this._turnComboBox.Name = "_turnComboBox";
            this._turnComboBox.Size = new System.Drawing.Size(186, 21);
            this._turnComboBox.TabIndex = 4;
            // 
            // _intoLabel
            // 
            this._intoLabel.AutoSize = true;
            this._intoLabel.Location = new System.Drawing.Point(60, 58);
            this._intoLabel.Name = "_intoLabel";
            this._intoLabel.Size = new System.Drawing.Size(24, 13);
            this._intoLabel.TabIndex = 5;
            this._intoLabel.Text = "into";
            // 
            // _intoComboBox
            // 
            this._intoComboBox.FormattingEnabled = true;
            this._intoComboBox.Location = new System.Drawing.Point(116, 58);
            this._intoComboBox.Name = "_intoComboBox";
            this._intoComboBox.Size = new System.Drawing.Size(186, 21);
            this._intoComboBox.TabIndex = 6;
            // 
            // _recursiveCheckBox
            // 
            this._recursiveCheckBox.AutoSize = true;
            this._recursiveCheckBox.Location = new System.Drawing.Point(466, 181);
            this._recursiveCheckBox.Name = "_recursiveCheckBox";
            this._recursiveCheckBox.Size = new System.Drawing.Size(74, 17);
            this._recursiveCheckBox.TabIndex = 7;
            this._recursiveCheckBox.Text = "Recursive";
            this._recursiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 210);
            this.Controls.Add(this._recursiveCheckBox);
            this.Controls.Add(this._intoComboBox);
            this.Controls.Add(this._intoLabel);
            this.Controls.Add(this._turnComboBox);
            this.Controls.Add(this._turnLabel);
            this.Controls.Add(this._browseButton);
            this.Controls.Add(this._directoryTextBox);
            this.Controls.Add(this._directoryLabel);
            this.Name = "DeColorForm";
            this.Text = "DeColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _directoryLabel;
        private System.Windows.Forms.TextBox _directoryTextBox;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.Label _turnLabel;
        private System.Windows.Forms.ComboBox _turnComboBox;
        private System.Windows.Forms.Label _intoLabel;
        private System.Windows.Forms.ComboBox _intoComboBox;
        private System.Windows.Forms.CheckBox _recursiveCheckBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

