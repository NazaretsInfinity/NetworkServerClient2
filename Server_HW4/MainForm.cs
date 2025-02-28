using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;


namespace Server_HW4
{
    public partial class MainForm : Form
    {
        TcpClient client = null;
        StreamReader sr = null; StreamWriter sw = null;



        public MainForm()
        {

            InitializeComponent();
            TcpListener server = new TcpListener(IPAddress.Any, 1302);
            server.Start();
            ThreadPool.QueueUserWorkItem(new WaitCallback(ClientAcceptor), server);
        }

        private void Game()
        {
            int clientwin = 0; int serverwin = 0;
            SetScoreLabel("Score 0 : 0");

            for (int rounds = 1; rounds <= 3; ++rounds)
            {
                this.Invoke(new Action(() => RockButton.Enabled = PapperButton.Enabled = ScissorButton.Enabled = true));
                SetRoundLabel("Round: " + rounds.ToString());

                while (ServerChoice.Text == "...") Thread.Sleep(3000); // to wait before user choose smth 
                this.Invoke(new Action(() => ClientChoice.Text = sr.ReadLine()));

                if (ClientChoice.Text != ServerChoice.Text)
                    switch (ServerChoice.Text)
                    {
                        case "Scissor":
                            if (ClientChoice.Text == "Paper") ++serverwin;
                            else ++clientwin;
                            break;
                        case "Papper":
                            if (ClientChoice.Text == "Rock") ++serverwin;
                            else ++clientwin;
                            break;
                        case "Rock":
                            if (ClientChoice.Text == "Scissor") ++serverwin;
                            else ++clientwin;
                            break;
                    }
                SetScoreLabel($"Score {serverwin} : {clientwin}"); Thread.Sleep(1000);

                sw.WriteLine(ScoreLabel.Text);
                this.Invoke(new Action(() => ClientChoice.Text = ServerChoice.Text = "..."));
            }

            //setting who's the winner
            if (clientwin == serverwin) SetRoundLabel("Draw");
            else SetRoundLabel($"Winner: " + (clientwin > serverwin ? "Client" : "Server"));

            sw.WriteLine("End"); // to end client method  
        }

        private void SetRoundLabel(string text) => this.Invoke(new Action(() => RoundLabel.Text = text));
        private void SetScoreLabel(string text) => this.Invoke(new Action(() => ScoreLabel.Text = text));
        private void ClientAcceptor(object a)
        {

            client = (a as TcpListener).AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            sr = new StreamReader(stream); sw = new StreamWriter(stream) { AutoFlush = true };
            while (true)
            {
                string message = sr.ReadLine();
                if (message == "Start")
                {
                    Thread game = new Thread(Game);
                    game.Start(); game.Join();
                }
            }
        }

        // BUTTONS EVEMT
        private void RockButton_Click(object sender, EventArgs e) => Choice(sender);
        private void PapperButton_Click(object sender, EventArgs e) => Choice(sender);
        private void ScissorButton_Click(object sender, EventArgs e) => Choice(sender);
        private void Choice(object sender)
        {
            ServerChoice.Text = (sender as Button).Text;
            sw.WriteLine(ServerChoice.Text);
            ScissorButton.Enabled = PapperButton.Enabled = RockButton.Enabled = false;
        }
    }
}

