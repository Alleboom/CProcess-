using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CProcess_
{
    public partial class AddEditForm : Form
    {
        private MainForm mainForm;
        private bool add;

        public AddEditForm()
        {
            InitializeComponent();
        }

        public AddEditForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            add = true;
            InitializeComponent();
        }

        public AddEditForm(Application application, MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            textLocation.Text = application.Filepath;
            textName.Text = application.Name;
            butAdd.Text = "Save";
            add = false;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            mainForm.AddEditApplication(textName.Text,textLocation.Text);
            if (!add)
            {
                mainForm.RemoveApplication();
            }
            this.Close();
        }

        private void butBrowse_Click(object sender, EventArgs e)
        {
            AddFilePath();
        }

        private void AddFilePath()
        {
            OpenFileDialog FileDial = new OpenFileDialog();
            FileDial.Filter = "Executables|*.exe|All files|*.*";
            FileDial.InitialDirectory = @"C:\Program Files";
            DialogResult dr = FileDial.ShowDialog();
            if (dr == DialogResult.OK) { textLocation.Text = FileDial.FileName; }
        }
    }
}
