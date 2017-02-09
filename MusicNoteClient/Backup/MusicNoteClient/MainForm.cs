using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MusicNoteServer;
using System.Runtime.Remoting;



namespace MusicNoteClient
{
    public partial class MainForm : Form
    {
        private IMusicServer ims = null;
        public static string name = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void HighScoresBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ims = (IMusicServer)RemotingServices.Connect(typeof(IMusicServer), "tcp://localhost:6000/MusicServer", null);
                DataSet ds = ims.GetHighScores();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to the server" +ex.Message);
            }

        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTxt.Text.Equals(""))
                {
                    MessageBox.Show("Please enter your name!");  
                }
                else
                {
                    name = NameTxt.Text;
                    new PianoFrm().Show();                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to the server" + ex.Message);
            }
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }

     
    }
}
