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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listBoxApps.DisplayMember = "Name";
            LoadXML(Environment.CurrentDirectory);
        }

        private void butAddProgram_Click(object sender, EventArgs e)
        {
            AddEditForm add = new AddEditForm(this);
            add.ShowDialog();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            try
            {
                AddEditForm edit = new AddEditForm((Application)listBoxApps.SelectedItem, this);
                edit.ShowDialog();
            }
            catch { MessageBox.Show("Select a program to Edit"); }
        }
        
        private void butRemoveApp_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveApplication();
                WriteXML(System.Environment.CurrentDirectory);
            }
            catch { MessageBox.Show("Select an application to remove"); }
        }

        public void AddEditApplication(string name, string loc)
        {
            listBoxApps.Items.Add(new Application(name, loc));
            WriteXML(Environment.CurrentDirectory);
        }

        public void RemoveApplication()
        {
            listBoxApps.Items.Remove(listBoxApps.SelectedItem);
        }

        private void sAveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteXML();
        }
        
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadXML();
        }

        // Writes XML Serialization
        private void WriteXML() {
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(List<Application>));
            try
            {
                SaveFileDialog saveFD = new SaveFileDialog();
                saveFD.Filter = "XML|*.xml";
                saveFD.Title = "Save Program List";
                DialogResult dr = saveFD.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(saveFD.FileName);
                    List<Application> list = new List<Application>();
                    foreach (Application app in listBoxApps.Items)
                    {
                        list.Add(app);
                    }

                    xml.Serialize(file, list);
                    file.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteXML(string filepath) { 
                System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(List<Application>));
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(filepath + "\\Default.xml");
                List<Application> list = new List<Application>();
                foreach (Application app in listBoxApps.Items)
                {
                    list.Add(app);
                }

                xml.Serialize(file, list);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Loads List of applications from XML
        private void LoadXML()
        {
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(List<Application>));
            listBoxApps.Items.Clear();
            try
            {
                OpenFileDialog openFD = new OpenFileDialog();
                openFD.Filter = "XML|*.xml";
                openFD.Title = "Load Program List";
                openFD.InitialDirectory = @Environment.CurrentDirectory;
                DialogResult dr = openFD.ShowDialog();
                if(dr == DialogResult.OK){
                    System.IO.StreamReader file = new System.IO.StreamReader(openFD.FileName);
                    List<Application> list = (List<Application>)xml.Deserialize(file);
                    foreach (Application item in list)
                    {
                        listBoxApps.Items.Add(item);
                    }
                    file.Close();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadXML(string filepath)
        {
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(typeof(List<Application>));
            System.IO.StreamReader file = null;
            try
            {
                // create the default file if it does nto exist
                if (!System.IO.File.Exists(filepath + "\\Default.XML"))
                {
                    System.IO.FileStream temp = System.IO.File.Create(filepath + "\\Default.XML");
                    temp.Close();
                }

                // parse the xml and add to the list
                file = new System.IO.StreamReader(filepath + "\\Default.XML");
                List<Application> list = (List<Application>)xml.Deserialize(file);
                foreach (Application item in list)
                {
                    listBoxApps.Items.Add(item);
                }


            }
            catch
            {
                MessageBox.Show("Error reading default file");
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butRun_Click(object sender, EventArgs e)
        {
            // grab the app to run
            Application AppToRun = (Application)listBoxApps.SelectedItem;
            if (@AppToRun.Filepath.Contains(","))
            {
                string[] temp = @AppToRun.Filepath.Split(',');
                string file = temp[0];
                string parameters = temp[1];

                System.Diagnostics.Process.Start(@file, @parameters);
            }
            else
            {
                System.Diagnostics.Process.Start(@AppToRun.Filepath);
            }
        }
        
    }
}
