namespace ZorkBuilder
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.fileMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.roomsListBox = new System.Windows.Forms.ListBox();
			this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.lookNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.neighborsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.deleteButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.startingLocationTextbox = new System.Windows.Forms.TextBox();
			this.welcomeMessageBox = new System.Windows.Forms.TextBox();
			this.WelcomeMessage = new System.Windows.Forms.Label();
			this.nLabel = new System.Windows.Forms.Label();
			this.neighborsBox = new System.Windows.Forms.GroupBox();
			this.northTextBox = new System.Windows.Forms.TextBox();
			this.eastTextBox = new System.Windows.Forms.TextBox();
			this.eastLabel = new System.Windows.Forms.Label();
			this.southTextBox = new System.Windows.Forms.TextBox();
			this.South = new System.Windows.Forms.Label();
			this.westTextBox = new System.Windows.Forms.TextBox();
			this.westLabel = new System.Windows.Forms.Label();
			this.fileMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).BeginInit();
			this.neighborsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileMenu
			// 
			this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.fileMenu.Location = new System.Drawing.Point(0, 0);
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(800, 24);
			this.fileMenu.TabIndex = 0;
			this.fileMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Zork Files (*.json)|*.json";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
			// 
			// worldViewModelBindingSource
			// 
			this.worldViewModelBindingSource.DataSource = typeof(ZorkBuilder.ViewModels.WorldViewModel);
			this.worldViewModelBindingSource.CurrentChanged += new System.EventHandler(this.WorldViewModelBindingSource_CurrentChanged);
			// 
			// roomsListBox
			// 
			this.roomsListBox.DataSource = this.roomsBindingSource;
			this.roomsListBox.DisplayMember = "Name";
			this.roomsListBox.FormattingEnabled = true;
			this.roomsListBox.Location = new System.Drawing.Point(13, 28);
			this.roomsListBox.Name = "roomsListBox";
			this.roomsListBox.Size = new System.Drawing.Size(223, 394);
			this.roomsListBox.TabIndex = 0;
			this.roomsListBox.ValueMember = "Description";
			this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
			// 
			// roomsBindingSource
			// 
			this.roomsBindingSource.DataMember = "Rooms";
			this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(262, 38);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(35, 13);
			this.nameLabel.TabIndex = 2;
			this.nameLabel.Text = "Name";
			this.nameLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.nameTextBox.Location = new System.Drawing.Point(265, 55);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(140, 20);
			this.nameTextBox.TabIndex = 3;
			// 
			// lookNameTextBox
			// 
			this.lookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "LookName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lookNameTextBox.Location = new System.Drawing.Point(265, 106);
			this.lookNameTextBox.Name = "lookNameTextBox";
			this.lookNameTextBox.Size = new System.Drawing.Size(140, 20);
			this.lookNameTextBox.TabIndex = 5;
			this.lookNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(262, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "LookName";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.descriptionTextBox.Location = new System.Drawing.Point(265, 156);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(509, 20);
			this.descriptionTextBox.TabIndex = 7;
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(262, 139);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
			this.descriptionLabel.TabIndex = 6;
			this.descriptionLabel.Text = "Description";
			// 
			// neighborsBindingSource
			// 
			this.neighborsBindingSource.DataMember = "Neighbors";
			this.neighborsBindingSource.DataSource = this.roomsBindingSource;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(96, 428);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 17;
			this.deleteButton.Text = "&Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(13, 428);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 16;
			this.addButton.Text = "&Add...";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Zork files (*json)|*.json";
			this.saveFileDialog.Title = "Save world file";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(262, 391);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "StartingLocation";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// startingLocationTextbox
			// 
			this.startingLocationTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "StartingLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.startingLocationTextbox.Location = new System.Drawing.Point(364, 388);
			this.startingLocationTextbox.Name = "startingLocationTextbox";
			this.startingLocationTextbox.Size = new System.Drawing.Size(328, 20);
			this.startingLocationTextbox.TabIndex = 19;
			// 
			// welcomeMessageBox
			// 
			this.welcomeMessageBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.welcomeMessageBox.Location = new System.Drawing.Point(364, 425);
			this.welcomeMessageBox.Name = "welcomeMessageBox";
			this.welcomeMessageBox.Size = new System.Drawing.Size(328, 20);
			this.welcomeMessageBox.TabIndex = 21;
			// 
			// WelcomeMessage
			// 
			this.WelcomeMessage.AutoSize = true;
			this.WelcomeMessage.Location = new System.Drawing.Point(262, 428);
			this.WelcomeMessage.Name = "WelcomeMessage";
			this.WelcomeMessage.Size = new System.Drawing.Size(95, 13);
			this.WelcomeMessage.TabIndex = 20;
			this.WelcomeMessage.Text = "WelcomeMessage";
			// 
			// nLabel
			// 
			this.nLabel.AutoSize = true;
			this.nLabel.Location = new System.Drawing.Point(6, 39);
			this.nLabel.Name = "nLabel";
			this.nLabel.Size = new System.Drawing.Size(33, 13);
			this.nLabel.TabIndex = 24;
			this.nLabel.Text = "North";
			// 
			// neighborsBox
			// 
			this.neighborsBox.Controls.Add(this.westTextBox);
			this.neighborsBox.Controls.Add(this.westLabel);
			this.neighborsBox.Controls.Add(this.southTextBox);
			this.neighborsBox.Controls.Add(this.South);
			this.neighborsBox.Controls.Add(this.eastTextBox);
			this.neighborsBox.Controls.Add(this.eastLabel);
			this.neighborsBox.Controls.Add(this.northTextBox);
			this.neighborsBox.Controls.Add(this.nLabel);
			this.neighborsBox.Location = new System.Drawing.Point(265, 182);
			this.neighborsBox.Name = "neighborsBox";
			this.neighborsBox.Size = new System.Drawing.Size(469, 187);
			this.neighborsBox.TabIndex = 25;
			this.neighborsBox.TabStop = false;
			this.neighborsBox.Text = "Neighbors";
			// 
			// northTextBox
			// 
			this.northTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "North", true));
			this.northTextBox.Location = new System.Drawing.Point(46, 39);
			this.northTextBox.Name = "northTextBox";
			this.northTextBox.Size = new System.Drawing.Size(381, 20);
			this.northTextBox.TabIndex = 25;
			this.northTextBox.TextChanged += new System.EventHandler(this.NorthTextBox_TextChanged);
			// 
			// eastTextBox
			// 
			this.eastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "East", true));
			this.eastTextBox.Location = new System.Drawing.Point(46, 67);
			this.eastTextBox.Name = "eastTextBox";
			this.eastTextBox.Size = new System.Drawing.Size(381, 20);
			this.eastTextBox.TabIndex = 27;
			this.eastTextBox.TextChanged += new System.EventHandler(this.EastTextBox_TextChanged);
			// 
			// eastLabel
			// 
			this.eastLabel.AutoSize = true;
			this.eastLabel.Location = new System.Drawing.Point(6, 67);
			this.eastLabel.Name = "eastLabel";
			this.eastLabel.Size = new System.Drawing.Size(28, 13);
			this.eastLabel.TabIndex = 26;
			this.eastLabel.Text = "East";
			// 
			// southTextBox
			// 
			this.southTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "South", true));
			this.southTextBox.Location = new System.Drawing.Point(46, 96);
			this.southTextBox.Name = "southTextBox";
			this.southTextBox.Size = new System.Drawing.Size(381, 20);
			this.southTextBox.TabIndex = 29;
			this.southTextBox.TextChanged += new System.EventHandler(this.SouthTextBox_TextChanged);
			// 
			// South
			// 
			this.South.AutoSize = true;
			this.South.Location = new System.Drawing.Point(6, 96);
			this.South.Name = "South";
			this.South.Size = new System.Drawing.Size(35, 13);
			this.South.TabIndex = 28;
			this.South.Text = "South";
			// 
			// westTextBox
			// 
			this.westTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "West", true));
			this.westTextBox.Location = new System.Drawing.Point(46, 124);
			this.westTextBox.Name = "westTextBox";
			this.westTextBox.Size = new System.Drawing.Size(381, 20);
			this.westTextBox.TabIndex = 31;
			this.westTextBox.TextChanged += new System.EventHandler(this.WestTextBox_TextChanged);
			// 
			// westLabel
			// 
			this.westLabel.AutoSize = true;
			this.westLabel.Location = new System.Drawing.Point(6, 124);
			this.westLabel.Name = "westLabel";
			this.westLabel.Size = new System.Drawing.Size(32, 13);
			this.westLabel.TabIndex = 30;
			this.westLabel.Text = "West";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 467);
			this.Controls.Add(this.neighborsBox);
			this.Controls.Add(this.welcomeMessageBox);
			this.Controls.Add(this.WelcomeMessage);
			this.Controls.Add(this.startingLocationTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.lookNameTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.roomsListBox);
			this.Controls.Add(this.fileMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.fileMenu;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Zork Builder";
			this.fileMenu.ResumeLayout(false);
			this.fileMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.neighborsBindingSource)).EndInit();
			this.neighborsBox.ResumeLayout(false);
			this.neighborsBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip fileMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lookNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox startingLocationTextbox;
		private System.Windows.Forms.TextBox welcomeMessageBox;
		private System.Windows.Forms.Label WelcomeMessage;
		private System.Windows.Forms.BindingSource neighborsBindingSource;
		private System.Windows.Forms.Label nLabel;
		private System.Windows.Forms.GroupBox neighborsBox;
		private System.Windows.Forms.TextBox northTextBox;
		private System.Windows.Forms.TextBox westTextBox;
		private System.Windows.Forms.Label westLabel;
		private System.Windows.Forms.TextBox southTextBox;
		private System.Windows.Forms.Label South;
		private System.Windows.Forms.TextBox eastTextBox;
		private System.Windows.Forms.Label eastLabel;
	}
}

