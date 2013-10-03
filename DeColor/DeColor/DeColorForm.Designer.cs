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
            this._colorComboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._colorPanel = new System.Windows.Forms.Panel();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this._groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _directoryLabel
            // 
            this._directoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._directoryLabel.AutoSize = true;
            this._directoryLabel.Location = new System.Drawing.Point(17, 65);
            this._directoryLabel.Name = "_directoryLabel";
            this._directoryLabel.Size = new System.Drawing.Size(49, 13);
            this._directoryLabel.TabIndex = 0;
            this._directoryLabel.Text = "Directory";
            // 
            // _directoryTextBox
            // 
            this._directoryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._directoryTextBox.Location = new System.Drawing.Point(20, 91);
            this._directoryTextBox.Name = "_directoryTextBox";
            this._directoryTextBox.Size = new System.Drawing.Size(474, 20);
            this._directoryTextBox.TabIndex = 1;
            // 
            // _browseButton
            // 
            this._browseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._browseButton.Location = new System.Drawing.Point(518, 91);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(53, 20);
            this._browseButton.TabIndex = 2;
            this._browseButton.Text = "Browse";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this._browseButton_Click);
            // 
            // _turnLabel
            // 
            this._turnLabel.AutoSize = true;
            this._turnLabel.Location = new System.Drawing.Point(17, 27);
            this._turnLabel.Name = "_turnLabel";
            this._turnLabel.Size = new System.Drawing.Size(278, 13);
            this._turnLabel.TabIndex = 3;
            this._turnLabel.Text = "Take all pixels that are not transperent and turn them into:";
            // 
            // _colorComboBox
            // 
            this._colorComboBox.FormattingEnabled = true;
            this._colorComboBox.Location = new System.Drawing.Point(318, 24);
            this._colorComboBox.Name = "_colorComboBox";
            this._colorComboBox.Size = new System.Drawing.Size(176, 21);
            this._colorComboBox.TabIndex = 6;
            this._colorComboBox.SelectedIndexChanged += new System.EventHandler(this._colorComboBox_SelectedIndexChanged);
            // 
            // _colorPanel
            // 
            this._colorPanel.BackColor = System.Drawing.Color.White;
            this._colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._colorPanel.Location = new System.Drawing.Point(518, 25);
            this._colorPanel.Name = "_colorPanel";
            this._colorPanel.Size = new System.Drawing.Size(53, 20);
            this._colorPanel.TabIndex = 7;
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._browseButton);
            this._groupBox.Controls.Add(this._colorPanel);
            this._groupBox.Controls.Add(this._directoryLabel);
            this._groupBox.Controls.Add(this._colorComboBox);
            this._groupBox.Controls.Add(this._directoryTextBox);
            this._groupBox.Controls.Add(this._turnLabel);
            this._groupBox.Location = new System.Drawing.Point(12, 12);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(592, 134);
            this._groupBox.TabIndex = 8;
            this._groupBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(530, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "DeColorize!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._groupBox);
            this.MaximumSize = new System.Drawing.Size(634, 232);
            this.MinimumSize = new System.Drawing.Size(634, 232);
            this.Name = "DeColorForm";
            this.Text = "DeColor";
            this._groupBox.ResumeLayout(false);
            this._groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _directoryLabel;
        private System.Windows.Forms.TextBox _directoryTextBox;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.Label _turnLabel;
        private System.Windows.Forms.ComboBox _colorComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel _colorPanel;
        private System.Windows.Forms.GroupBox _groupBox;
        private System.Windows.Forms.Button button1;
    }
}

