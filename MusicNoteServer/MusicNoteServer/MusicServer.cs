using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;
using System.Data.OleDb;
using System.Data;
using System.IO;


namespace MusicNoteServer
{
    public interface IMusicServer
    {   
        byte[] GetRandomNote();
        bool CheckNoteMatch(string notename);
        DataSet GetHighScores();
        void SaveHighScore(string username, int score);
        
    }
    
    class MusicServer : MarshalByRefObject,IMusicServer
    {
        private static string filepath = null;
        public byte[] GetRandomNote()
        {
            Random randomint = new Random();
            int noteid = randomint.Next(1, 13);             // generate a random note id
            

            SqlConnection con = new SqlConnection(MusicNoteServer.Properties.Settings.Default.MusicNotesConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT File_path FROM Notes WHERE File_id="+ noteid, con);
            filepath = (string)cmd.ExecuteScalar();

            byte[] temp=File.ReadAllBytes(filepath);
            return temp;     
                       
            
        }
        public bool CheckNoteMatch(string notename)
        {
            filepath = filepath.TrimEnd();
            char[] file = filepath.ToCharArray();
            char delimiter = (char)92;          // backslash character 
            string filename = null;
            string revfilename = null;

            for (int i = filepath.Length-5; i > 0; i--)
            {
                if ( file[i].Equals(delimiter))
                    break;
                filename = filename + file[i];  
            }
            // reversal of filename

            char[]reverse = filename.ToCharArray();
            
            for (int i = reverse.Length-1 ; i>=0 ; i--)
            {                
                revfilename = revfilename + reverse[i];
            }
            //revfilename = revfilename.Trim();
            //revfilename = revfilename + ".mp3";
            if (notename == revfilename)
                return true;
            else
                return false;
        }
        public DataSet GetHighScores()
        {
            DataTable scoretable = new DataTable();
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(MusicNoteServer.Properties.Settings.Default.MusicNotesConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Scores;", con);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(ds);

            return ds;
        }
        public void SaveHighScore(string username, int score)
        {
            SqlConnection con = new SqlConnection(MusicNoteServer.Properties.Settings.Default.MusicNotesConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Scores VALUES ('"+username+ "'," +score +");", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        static void Main(string[] args)
        {
            try
            {
                TcpChannel channel = new TcpChannel(6000);
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(MusicServer), "MusicServer", WellKnownObjectMode.SingleCall);
                Console.WriteLine("Music Note Server is up and running...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
