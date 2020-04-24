using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackingSimulator
{
    public partial class frmInicial : Form
    {
        Thread StartGame;
        Thread Options;
        string nome_arquivo = System.Environment.CurrentDirectory;

        private void Start()
        {
            Application.Run(new frmGame());
        }

        private void _Options()
        {
            Application.Run(new frmOptions());
        }

        public frmInicial()
        {
            InitializeComponent();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void lblEgg_Click(object sender, EventArgs e)
        {
            lblEgg2.Text = "© Viper Studios - 2019";            
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            lblEgg.Text = "[using] hackingsimulator v.0.1.1";
        }

        private void lblEgg2_Click(object sender, EventArgs e)
        {
            Random colorandom = new Random();
            Color[] color = { Color.FromKnownColor(KnownColor.White),
                              Color.FromKnownColor(KnownColor.Cyan),
                              Color.FromKnownColor(KnownColor.Pink),
                              Color.FromKnownColor(KnownColor.Brown),
                              Color.FromKnownColor(KnownColor.Red),
                              Color.FromKnownColor(KnownColor.Blue),
                              Color.FromKnownColor(KnownColor.Aqua),
                              Color.FromKnownColor(KnownColor.Yellow),
                              Color.FromKnownColor(KnownColor.Chocolate)
            };
            int colors = colorandom.Next(color.Length);
            lblEgg2.ForeColor = (color[colors]);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer start = new System.Media.SoundPlayer(
            //HackingSimulator.Properties.Resources.Nome_da_Musica);
            //start.Play();
            this.Close();
            StartGame = new Thread(Start);
            StartGame.SetApartmentState(ApartmentState.STA);
            StartGame.Start();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            //start.Play();
            this.Close();
            Options = new Thread(_Options);
            Options.SetApartmentState(ApartmentState.STA);
            Options.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_MouseMove(object sender, MouseEventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(nome_arquivo + "\\Hacking Test\\HackingSimulator\\HackingSimulator\\sound\\soundclick.wav");
           // simpleSound.Play();
            //System.Media.SystemSounds.Beep.Play();
            btnStart.BackColor = Color.FromKnownColor(KnownColor.Gray);
        }
        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.FromKnownColor(KnownColor.Black);
        }

        private void btnOptions_MouseMove(object sender, MouseEventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(nome_arquivo + "\\Hacking Test\\HackingSimulator\\HackingSimulator\\sound\\soundclick.wav");
            //simpleSound.Play();
            //System.Media.SystemSounds.Beep.Play();
            btnOptions.BackColor = Color.FromKnownColor(KnownColor.Gray);
        }
        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            btnOptions.BackColor = Color.FromKnownColor(KnownColor.Black);
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(nome_arquivo + "\\Hacking Test\\HackingSimulator\\HackingSimulator\\sound\\soundclick.wav");
            //simpleSound.Play();
            //System.Media.SystemSounds.Beep.Play();
            btnExit.BackColor = Color.FromKnownColor(KnownColor.Gray);
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromKnownColor(KnownColor.Black);
        }

        
    }
}
