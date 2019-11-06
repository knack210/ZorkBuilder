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
                //mainTabControl.Enabled = mIsWorldLoaded;
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

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                IsWorldLoaded = true;
            }
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
