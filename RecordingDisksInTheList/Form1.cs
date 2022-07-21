using System;
using System.IO;
using System.Windows.Forms;

namespace RecordingDisksInTheList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // запис всіх існуючих дисків у системі в список
            DriveInfo[] ListDrives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in ListDrives)
                if (driveInfo.IsReady)
                    comboBox1.Items.Add(driveInfo.Name);
            comboBox1.SelectedIndex = 0;
        }
    }
}
