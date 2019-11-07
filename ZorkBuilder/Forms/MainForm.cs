using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using ZorkBuilder.Data;
using ZorkBuilder.ViewModels;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZorkBuilder.Forms;

namespace ZorkBuilder
{
	public partial class MainForm : Form
	{
		public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

		private WorldViewModel ViewModel
		{
			get => mViewModel;
			set
			{
				if (mViewModel != value)
				{
					mViewModel = value;
					worldViewModelBindingSource.DataSource = mViewModel;
				}
			}
		}

		private bool IsWorldLoaded
		{
			get => mIsWorldLoaded;
			set
			{
				mIsWorldLoaded = value;
			}
		}

		public MainForm()
		{
			InitializeComponent();
			ViewModel = new WorldViewModel();
			IsWorldLoaded = false;
		}

		private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private WorldViewModel mViewModel;
		private bool mIsWorldLoaded;


		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
				ViewModel.Filename = openFileDialog.FileName;
				IsWorldLoaded = true;
				northTextBox.Text = "";
				westTextBox.Text = "";
				southTextBox.Text = "";
				eastTextBox.Text = "";
			}
		}

		private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			deleteButton.Enabled = roomsListBox.SelectedItem != null;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (AddRoomForm addRoomForm = new AddRoomForm())
			{
				if (addRoomForm.ShowDialog() == DialogResult.OK)
				{
					Room room = new Room { Name = addRoomForm.RoomName };
					ViewModel.Rooms.Add(room);
				}
			}
		}


		private void StartingMessageToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld();
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ViewModel.Filename = saveFileDialog.FileName;
				ViewModel.SaveWorld();
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
				roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
			}
		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void WorldViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void NorthTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void EastTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void SouthTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void WestTextBox_TextChanged(object sender, EventArgs e)
		{

		}

	}
}
