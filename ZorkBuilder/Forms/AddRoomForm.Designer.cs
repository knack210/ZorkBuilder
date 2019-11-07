namespace ZorkBuilder.Forms
{
    partial class AddRoomForm
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
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.roomNameLabel = new System.Windows.Forms.Label();
			this.roomNameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Enabled = false;
			this.okButton.Location = new System.Drawing.Point(114, 52);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "&Ok...";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(197, 52);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// roomNameLabel
			// 
			this.roomNameLabel.AutoSize = true;
			this.roomNameLabel.Location = new System.Drawing.Point(12, 9);
			this.roomNameLabel.Name = "roomNameLabel";
			this.roomNameLabel.Size = new System.Drawing.Size(35, 13);
			this.roomNameLabel.TabIndex = 2;
			this.roomNameLabel.Text = "Name";
			this.roomNameLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// roomNameTextBox
			// 
			this.roomNameTextBox.Location = new System.Drawing.Point(13, 26);
			this.roomNameTextBox.Name = "roomNameTextBox";
			this.roomNameTextBox.Size = new System.Drawing.Size(259, 20);
			this.roomNameTextBox.TabIndex = 3;
			this.roomNameTextBox.TextChanged += new System.EventHandler(this.RoomNameTextBox_TextChanged);
			// 
			// AddRoomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 78);
			this.Controls.Add(this.roomNameTextBox);
			this.Controls.Add(this.roomNameLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Name = "AddRoomForm";
			this.Text = "Add Room";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
    }
}