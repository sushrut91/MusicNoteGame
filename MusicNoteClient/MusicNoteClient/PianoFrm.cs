using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using MusicNoteServer;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;
using System.Threading;

namespace MusicNoteClient
{
    public partial class PianoFrm : Form
    {
        private IMusicServer ims = null;
        private bool playbuttonflag = false;
        private int score = 0;
        private int attempt = 1;
     
        public PianoFrm()
        {
            InitializeComponent();
        }

        private void PianoFrm_Load(object sender, EventArgs e)
        {
            try
            {
                ims = (IMusicServer)RemotingServices.Connect(typeof(IMusicServer), "tcp://localhost:6000/MusicServer", null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Connect to Server.."+ex.Message);
            }
        }    

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (!playbuttonflag)
            {
                byte[] temp = ims.GetRandomNote();
                File.WriteAllBytes(MusicNoteClient.Properties.Settings.Default.FilePath, temp);
            }
            Audio tempsound = Audio.FromFile(MusicNoteClient.Properties.Settings.Default.FilePath);            
            tempsound.Play();
            Thread.Sleep(2000);
            tempsound.Dispose();
            playbuttonflag = true;
        }

        private void CNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.CNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." +ex.Message);
            }
        }

        private void CSharpNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.CSharpNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
                   
        }
        private void DNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.DNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
           
        }

        private void DSharpNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.DSharpNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }

        private void ENote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.ENote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
            
        }

        private void FNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.FNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }

        private void FSharpNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.FSharpNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }

        private void GNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.GNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }

        private void GSharpNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.GSharpNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }

        private void ANote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.ANote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }

        private void ASharpNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.ASharpNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }

        private void BNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (playbuttonflag)
                {
                    if (attempt < 10)
                    {
                        File.Delete(MusicNoteClient.Properties.Settings.Default.FilePath);
                        bool ans = ims.CheckNoteMatch(this.BNote.Name);
                        if (ans)
                            score = score + 5;
                        else
                            score = score - 5;
                        ScoreLbl.Text = score.ToString();
                        playbuttonflag = false;
                        QuestionNoLbl.Text = attempt.ToString();
                        attempt++;

                    }
                    else
                    {
                        ims.SaveHighScore(MainForm.name, score);
                        MessageBox.Show("Game over");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Click the play button first !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Lost..." + ex.Message);
            }
            
        }
    }
}
