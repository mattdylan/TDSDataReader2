namespace TDSDataReader2.TestBuild
{
    partial class fileRenameForm
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
            this.browseButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.newIdentifierTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drivesComboBox = new System.Windows.Forms.ComboBox();
            this.chooseDriveRadio = new System.Windows.Forms.RadioButton();
            this.BrowseRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentIdentifierTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(26, 135);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Enabled = false;
            this.renameButton.Location = new System.Drawing.Point(380, 273);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 36);
            this.renameButton.TabIndex = 1;
            this.renameButton.Text = "Rename Files";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // newIdentifierTextBox
            // 
            this.newIdentifierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIdentifierTextBox.Location = new System.Drawing.Point(26, 215);
            this.newIdentifierTextBox.MaxLength = 5;
            this.newIdentifierTextBox.Name = "newIdentifierTextBox";
            this.newIdentifierTextBox.Size = new System.Drawing.Size(75, 20);
            this.newIdentifierTextBox.TabIndex = 4;
            this.newIdentifierTextBox.TextChanged += new System.EventHandler(this.newIdentifierTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input NEW 5 letter TDS Company/Mill/Type/Boiler/Date Identifier";
            // 
            // drivesComboBox
            // 
            this.drivesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drivesComboBox.FormattingEnabled = true;
            this.drivesComboBox.Location = new System.Drawing.Point(26, 47);
            this.drivesComboBox.Name = "drivesComboBox";
            this.drivesComboBox.Size = new System.Drawing.Size(75, 21);
            this.drivesComboBox.TabIndex = 5;
            this.drivesComboBox.SelectedIndexChanged += new System.EventHandler(this.drivesComboBox_SelectedIndexChanged);
            // 
            // chooseDriveRadio
            // 
            this.chooseDriveRadio.AutoSize = true;
            this.chooseDriveRadio.Checked = true;
            this.chooseDriveRadio.Location = new System.Drawing.Point(26, 24);
            this.chooseDriveRadio.Name = "chooseDriveRadio";
            this.chooseDriveRadio.Size = new System.Drawing.Size(90, 17);
            this.chooseDriveRadio.TabIndex = 7;
            this.chooseDriveRadio.TabStop = true;
            this.chooseDriveRadio.Text = "Choose drive:";
            this.chooseDriveRadio.UseVisualStyleBackColor = true;
            this.chooseDriveRadio.CheckedChanged += new System.EventHandler(this.chooseDriveRadio_CheckedChanged);
            // 
            // BrowseRadio
            // 
            this.BrowseRadio.AutoSize = true;
            this.BrowseRadio.Location = new System.Drawing.Point(26, 86);
            this.BrowseRadio.Name = "BrowseRadio";
            this.BrowseRadio.Size = new System.Drawing.Size(196, 17);
            this.BrowseRadio.TabIndex = 8;
            this.BrowseRadio.Text = "Choose folder where files are stored:";
            this.BrowseRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "*** Data must be stored on the root of the drive";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(26, 109);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(308, 20);
            this.pathTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Input CURRENT 5 letter TDS Company/Mill/Type/Boiler/Date Identifier";
            // 
            // currentIdentifierTextBox
            // 
            this.currentIdentifierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIdentifierTextBox.Location = new System.Drawing.Point(26, 189);
            this.currentIdentifierTextBox.MaxLength = 5;
            this.currentIdentifierTextBox.Name = "currentIdentifierTextBox";
            this.currentIdentifierTextBox.Size = new System.Drawing.Size(75, 20);
            this.currentIdentifierTextBox.TabIndex = 3;
            this.currentIdentifierTextBox.TextChanged += new System.EventHandler(this.currentIndentifierTextBox_TextChanged);
            // 
            // fileRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentIdentifierTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseRadio);
            this.Controls.Add(this.chooseDriveRadio);
            this.Controls.Add(this.drivesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newIdentifierTextBox);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.browseButton);
            this.Name = "fileRenameForm";
            this.Text = "Rename TDS Data Files";
            this.Load += new System.EventHandler(this.fileRenameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.TextBox newIdentifierTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drivesComboBox;
        private System.Windows.Forms.RadioButton chooseDriveRadio;
        private System.Windows.Forms.RadioButton BrowseRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentIdentifierTextBox;
    }
}