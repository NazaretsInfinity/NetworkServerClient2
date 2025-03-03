using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_HW4
{
    public partial class MainForm : Form
    {
        TcpClient client = null;
        StreamReader sr = null; StreamWriter sw = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 1302);
                NetworkStream stream = client.GetStream();
                sr = new StreamReader(stream); sw = new StreamWriter(stream) { AutoFlush = true };

                StartGameButton.Enabled = true;
                ConnectButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK);
            }
        }

        private async void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Enabled = false;
            sw.WriteLine(StartGameButton.Text);
            try
            {
                while (true)
                {
                    RockButton.Enabled = PapperButton.Enabled = ScissorButton.Enabled = true;
                    string servmess = await sr.ReadLineAsync(); if (servmess == "End") break;

                    while (ClientChoice.Text == "...") await Task.Delay(2000);
                    ServerChoice.Text = servmess;

                    await Task.Delay(1000);
                    ClientChoice.Text = ServerChoice.Text = "...";
                    ScoreLabel.Text = await sr.ReadLineAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
            }


            StartGameButton.Enabled = true;
        }

        private void RockButton_Click(object sender, EventArgs e) => Choice(sender);

        private void PapperButton_Click(object sender, EventArgs e) => Choice(sender);

        private void ScissorButton_Click(object sender, EventArgs e) => Choice(sender);

        private void Choice(object sender)
        {
            ClientChoice.Text = (sender as Button).Text;
            sw.WriteLine(ClientChoice.Text);
            ScissorButton.Enabled = PapperButton.Enabled = RockButton.Enabled = false;
        }

        Random rnd = new Random();
        private void autobutton_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>() { RockButton, PapperButton, ScissorButton};
            Choice(buttons[rnd.Next(3)]);
        }

        private void DrawButton_Click(object sender, EventArgs e) =>sw.WriteLine("draw");
    }
}
