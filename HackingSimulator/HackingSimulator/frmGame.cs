using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackingSimulator
{
    public partial class frmGame : Form
    {
        Thread Initial;
        int resClone,
            resFalso, 
            resBanco, 
            resInfect, 
            resMalware, 
            resInvasion, 
            resTotalBanco, 
            resTotalFalso, 
            resTotalClone, 
            resTotal,
            mtpc2 = 2,
            mtpc3 = 3,
            mtpc5 = 5
            ;
        string nome_arquivo = System.Environment.CurrentDirectory;

        private void Voltar()
        {
            Application.Run(new frmInicial());
        }

/*===========================================================================================*/
                                    // INICIALIZAÇÃO //
/*===========================================================================================*/

        public frmGame()
        {
            InitializeComponent();

            // Botões Primários
            btnFalsificar.Visible = false;
            btnAcessar.Visible = false;
            btnClonar.Visible = false;
            btnDesativar.Visible = false;

            // Botões de Habilidade
            btnComprarPerk1.Visible = false;
            btnComprarPerk2.Visible = false;
            btnComprarPerk3.Visible = false;
            btnComprarPerk4.Visible = false;
            btnComprarPerk5.Visible = false;
            btnComprarPerk6.Visible = false;
            btnComprarPerk7.Visible = false;
            btnComprarPerk8.Visible = false;
            btnComprarPerk9.Visible = false;
            btnComprarPerk0.Visible = false;

            // Labels Informativas
            lblHabilidades.Visible = false;

            // Timers
            Temporizer();

            // Botões de Janela
            btnMenuOn.Visible = false;
            btnSalvar.Visible = false;
            btnSair.Visible = false;

            //btnBuyJanela1.Visible = false;
            //btnBuyJanela2.Visible = false;
            //btnBuyJanela3.Visible = false;
        }

/*===========================================================================================*/
                                        // BOTÕES //
/*===========================================================================================*/

        private void btnClonar_Click(object sender, EventArgs e)
        {
            barClonagem.PerformStep();
            if (barClonagem.Value == 1000)
            {
                resClone = 1 + resClone;
                lblQntdClone.Text = Convert.ToString(1);
                lblQntdClone.Text = Convert.ToString(resClone);
                ClonadoMais();
            }
            Metodo();

            if (resClone >= 50)
            {
                btnFalsificar.Visible = true;
            }
            Clonando();

            resTotalClone = resClone * 5;
        }

        public void ClonadoMais()
        {
            barClonagem.Value = 0;
        }

/*===========================================================================================*/

        private void btnFalsificar_Click(object sender, EventArgs e)
        {
            barFalsificacao.PerformStep();
            if (barFalsificacao.Value == 10000)
            {
                resFalso = 1 + resFalso;
                lblQntdFalso.Text = Convert.ToString(1);
                lblQntdFalso.Text = Convert.ToString(resFalso);
                FalsificadoMais();
            }
            Metodo();

            if (resFalso >= 75)
            {
                btnAcessar.Visible = true;
            }
            Falsificando();

            resTotalFalso = resFalso * 3;
        }

        public void FalsificadoMais()
        {
            barFalsificacao.Value = 0;
        }

/*===========================================================================================*/

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            barBancos.PerformStep();
            if (barBancos.Value == 100000)
            {
                resBanco = 1 + resBanco;
                lblQntdBanco.Text = Convert.ToString(1);
                lblQntdBanco.Text = Convert.ToString(resBanco);
                AcessadoMais();
            }                
            Acessando();
            Metodo();

            if (resBanco >= 100)
            {
                grpBoxComputers.Visible = true;
            }

            resTotalBanco = resBanco * 2;
        }

        public void AcessadoMais()
        {
            barBancos.Value = 0;
        }

/*===========================================================================================*/

        private void btnInfectar_Click(object sender, EventArgs e)
        {
            barDistribution1.PerformStep();
            if (barDistribution1.Value == 200)
            {
                barDistribution2.PerformStep();
            }

            if (barDistribution2.Value == 300)
            {
                barDistribution3.PerformStep();
            }

            if (barDistribution3.Value == 400)
            {
                resInfect = 1 + resInfect;
                lblQntdDistribution.Text = Convert.ToString(1);
                lblQntdDistribution.Text = Convert.ToString(resInfect);
                InfectandoMais();
            }
            Infectando();

            if (resInfect == 125)
            {
                grpBoxMalware.Visible = true;
            }

            if (resInfect == 250)
            {
                grpBoxInvasion.Visible = true;
            }
        }

        public void InfectandoMais()
        {
            barDistribution1.Value = 0;
            barDistribution2.Value = 0;
            barDistribution3.Value = 0;
        }

/*===========================================================================================*/

        private void btnCriar_Click(object sender, EventArgs e)
        {
            barMalware.PerformStep();
            if (barMalware.Value == 50000)
            {
                resMalware = 1 + resMalware;
                lblQntdMalware.Text = Convert.ToString(1);
                lblQntdMalware.Text = Convert.ToString(resMalware);
                Malwarize();
            }
            Criando();

            if (resMalware >= 1)
            {
                lblHabilidades.Visible = true;
            }

            if (resMalware >= 40)
            {
                btnComprarPerk1.Visible = true;
            }

            if (resMalware >= 50)
            {
                btnComprarPerk2.Visible = true;
            }

            if (resMalware >= 60)
            {
                btnComprarPerk3.Visible = true;
            }

            if (resMalware >= 70)
            {
                btnComprarPerk4.Visible = true;
            }

            if (resMalware >= 80)
            {
                btnComprarPerk5.Visible = true;
            }

            if (resMalware >= 10)
            {
                btnComprarPerk6.Visible = true;
            }

            if (resMalware >= 20)
            {
                btnComprarPerk7.Visible = true;
            }

            if (resMalware >= 30)
            {
                btnComprarPerk8.Visible = true;
            }

            if (resMalware >= 90)
            {
                btnComprarPerk9.Visible = true;
            }

            if (resMalware == 100)
            {
                btnComprarPerk0.Visible = true;
                Criado();
            }
        }

        public void Malwarize()
        {
            barMalware.Value = 0;
        }

/*===========================================================================================*/
                                     // FUNÇÕES //
/*===========================================================================================*/

        public void Clonando()
        {
            if (barClonagem.Value < 1000)
            {
                lblPorcentagemClone.Text = "Clonando...";
            }
        }

        public void Falsificando()
        {

            if (barFalsificacao.Value < 10000)
            {
                lblFalsificar.Text = "Falsificando...";
            }
        }

        public void Acessando()
        {
            if (barBancos.Value < 100000)
            {
                lblAcessar.Text = "Acessando...";
            }
        }

        public void Infectando()
        {
            if (barDistribution1.Value < 200)
            {
                lblDistribution.Text = "Infectando...";
            }
            if (barDistribution2.Value > 0)
            {
                lblDistribution.Text = "Infectando mais...";
            }
            if (barDistribution3.Value > 0)
            {
                lblDistribution.Text = "Infectando muito...";
            }
        }

        public void Criando()
        {
            if (barMalware.Value < 500000)
            {
                lblMalware.Text = "Criando...";
            }
        }

        public void Criado()
        {
            if (resMalware == 100)
            {
                btnCriar.Visible = false;
                lblMalware.Text = "Criado!";
            }
        }

/*===========================================================================================*/
                                 // FUNCIONALIDADES //
/*===========================================================================================*/

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

/*===========================================================================================*/

        private void btnMenuOff_Click(object sender, EventArgs e)
        {
            btnMenuOff.Visible = false;
            btnMenuOn.Visible = true;
            btnSalvar.Visible = false;
            picHack1.Visible = true;
            picHack11.Visible = false;
            btnSair.Visible = false;
        }

        private void btnMenuOn_Click(object sender, EventArgs e)
        {
            btnMenuOn.Visible = false;
            btnMenuOff.Visible = true;
            btnSalvar.Visible = true;
            picHack1.Visible = false;
            picHack11.Visible = true;
            btnSair.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Initial = new Thread(Voltar);
            Initial.SetApartmentState(ApartmentState.STA);
            Initial.Start();
        }

/*===========================================================================================*/
        private void btnClonar_MouseMove(object sender, MouseEventArgs e)
        {
            btnClonar.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }
        private void btnClonar_MouseLeave(object sender, EventArgs e)
        {
            btnClonar.BackColor = Color.FromKnownColor(KnownColor.Black);
        }
/*===========================================================================================*/
        private void btnFalsificar_MouseMove(object sender, MouseEventArgs e)
        {
            btnFalsificar.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }
        private void btnFalsificar_MouseLeave(object sender, EventArgs e)
        {
            btnFalsificar.BackColor = Color.FromKnownColor(KnownColor.Black);
        }
/*===========================================================================================*/
        private void btnAtivar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAtivar.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }
        private void btnAtivar_MouseLeave(object sender, EventArgs e)
        {
            btnAtivar.BackColor = Color.FromKnownColor(KnownColor.Black);
        }
/*===========================================================================================*/
        private void btnDesativar_MouseMove(object sender, MouseEventArgs e)
        {
            btnDesativar.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }
        private void btnDesativar_MouseLeave(object sender, EventArgs e)
        {
            btnDesativar.BackColor = Color.FromKnownColor(KnownColor.Black);
        }
/*===========================================================================================*/
        private void btnInfectar_MouseMove(object sender, MouseEventArgs e)
        {
            btnInfectar.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }
        private void btnInfectar_MouseLeave(object sender, EventArgs e)
        {
            btnInfectar.BackColor = Color.FromKnownColor(KnownColor.Black);
        }
/*===========================================================================================*/
        private void btnCriar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCriar.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }
        private void btnCriar_MouseLeave(object sender, EventArgs e)
        {
            btnCriar.BackColor = Color.FromKnownColor(KnownColor.Black);
        }
/*===========================================================================================*/
        private void btnInvadir_MouseMove(object sender, MouseEventArgs e)
        {
            btnInvadir.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }
        private void btnInvadir_MouseLeave(object sender, EventArgs e)
        {
            btnInvadir.BackColor = Color.FromKnownColor(KnownColor.Black);
        }

/*===========================================================================================*/
                            // ATIVAÇÕES E DESATIVAÇÕES //
/*===========================================================================================*/

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            // Botões Principais
            btnDesativar.Visible = true;
            btnAtivar.Visible = false;

            // Texto das Labels Principais
            lblUser.Text = "<C:\\Tabelinha\\fakeuser>ipconfig:";
            lblIP.Text = "123.456.789.0";

            // Botões Secundários
            btnClonar.Visible = true;
            if (resClone >= 50)
            {
                btnFalsificar.Visible = true;
            }

            if (resFalso >= 75)
            {
                btnAcessar.Visible = true;
            }

            if (resBanco >= 100)
            {
                btnInfectar.Visible = true;
            }

            if (resInfect >= 125)
            {
                btnCriar.Visible = true;
            }
            Criado();
        }

/*===========================================================================================*/

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            // Botões Principais
            btnDesativar.Visible = false;
            btnAtivar.Visible = true;

            // Texto das Labels Principais
            lblUser.Text = "<C:\\Usuário1\\userlogado>ipconfig:";
            lblIP.Text = "401.289.169.2";

            // Botões Secundários
            btnClonar.Visible = false;
            btnFalsificar.Visible = false;
            btnAcessar.Visible = false;
            btnInfectar.Visible = false;
            btnCriar.Visible = false;
            btnInvadir.Visible = false;

            // Barras de Loading...
            barClonagem.Value = 0;
            barFalsificacao.Value = 0;
            barBancos.Value = 0;
            barDistribution1.Value = 0;
            barDistribution2.Value = 0;
            barDistribution3.Value = 0;
            barMalware.Value = 0;

            // Texto das Labels
            if (resClone > 0)
            {
                lblPorcentagemClone.Text = "Clonado!";
            }

            if (resFalso > 0)
            {
                lblFalsificar.Text = "Falsificado!";
            }

            if (resBanco > 0)
            {
                lblAcessar.Text = "Acessado!";
            }

            if (resInfect > 0)
            {
                lblDistribution.Text = "Infectado!";
            }

            if (resMalware > 0)
            {
                lblMalware.Text = "Criado!";
            }

            if (resInvasion > 0)
            {
                lblInvasion.Text = "Invadido!";
            }
        }

/*===========================================================================================*/
                                        // Timers //
/*===========================================================================================*/

        public void Temporizer()
        {
            System.Windows.Forms.Timer Tempo = new System.Windows.Forms.Timer();
            Tempo.Interval = 1000;
            Tempo.Tick += new EventHandler(Tempo_Tick);
            Tempo.Start();
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////
            //-=-=-=-=-=-=-=-=-=-=-=-HiDOX v1.00-=-=-=-=-=-=-=-=-=-=-=//
            ////////////////////////////////////////////////////////////

            if(lblHabilidades.ForeColor == Color.Lime)
            {
                lblHabilidades.ForeColor = Color.Red;
            }

            else if(lblHabilidades.ForeColor == Color.Red)
            {
                lblHabilidades.ForeColor = Color.Violet;
            }

            else if(lblHabilidades.ForeColor == Color.Violet)
            {
            lblHabilidades.ForeColor = Color.Blue;
            }

            else if(lblHabilidades.ForeColor == Color.Blue)
            {
                lblHabilidades.ForeColor = Color.Olive;
            }

            else if(lblHabilidades.ForeColor == Color.Olive)
            {
                lblHabilidades.ForeColor = Color.DarkOrange;
            }

            else if(lblHabilidades.ForeColor == Color.DarkOrange)
            {
                lblHabilidades.ForeColor = Color.Green;
            }

            else if(lblHabilidades.ForeColor == Color.Green)
            {
                lblHabilidades.ForeColor = Color.Cyan;
            }

            else if(lblHabilidades.ForeColor == Color.Cyan)
            {
                lblHabilidades.ForeColor = Color.White;
            }

            else
            {
                lblHabilidades.ForeColor = Color.Lime;
            }

            ////////////////////////////////////////////////////////////
            //++++++++++++++++++++++   BOTÕES   ++++++++++++++++++++++//
            ////////////////////////////////////////////////////////////

            if (btnComprarPerk1.ForeColor == Color.Lime)
            {
                btnComprarPerk1.ForeColor = Color.Yellow;
            }

            else
            {
                btnComprarPerk1.ForeColor = Color.Lime;
            }

/////////////////////////////////////////////////////////////////////////
            
            if (btnComprarPerk2.ForeColor == Color.Lime)
            {
                btnComprarPerk2.ForeColor = Color.OrangeRed;
            }

            else
            {
                btnComprarPerk2.ForeColor = Color.Lime;
            }

/////////////////////////////////////////////////////////////////////////

            if (btnComprarPerk3.ForeColor == Color.Lime)
            {
                btnComprarPerk3.ForeColor = Color.Red;
            }

            else
            {
                btnComprarPerk3.ForeColor = Color.Lime;
            }

/////////////////////////////////////////////////////////////////////////

            if (btnComprarPerk4.ForeColor == Color.Lime)
            {
                btnComprarPerk4.ForeColor = Color.Blue;
            }

            else
            {
                btnComprarPerk4.ForeColor = Color.Lime;
            }

/////////////////////////////////////////////////////////////////////////

            if (btnComprarPerk5.ForeColor == Color.Lime)
            {
                btnComprarPerk5.ForeColor = Color.Purple;
            }

            else
            {
                btnComprarPerk5.ForeColor = Color.Lime;
            }

/////////////////////////////////////////////////////////////////////////

            if (btnComprarPerk9.ForeColor == Color.Lime)
            {
                btnComprarPerk9.ForeColor = Color.Blue;
            }

            else if (btnComprarPerk9.ForeColor == Color.Blue)
            {
                btnComprarPerk9.ForeColor = Color.White;
            }

            else if (btnComprarPerk9.ForeColor == Color.White)
            {
                btnComprarPerk9.ForeColor = Color.Red;
            }

            else
            {
                btnComprarPerk9.ForeColor = Color.Lime;
            }

/////////////////////////////////////////////////////////////////////////

            if (btnComprarPerk0.ForeColor == Color.Lime)
            {
                btnComprarPerk0.ForeColor = Color.Red;
            }

            else if (btnComprarPerk0.ForeColor == Color.Red)
            {
                btnComprarPerk0.ForeColor = Color.White;
            }

            else if (btnComprarPerk0.ForeColor == Color.White)
            {
                btnComprarPerk0.ForeColor = Color.Blue;
            }

            else
            {
                btnComprarPerk0.ForeColor = Color.Lime;
            }

/////////////////////////////////////////////////////////////////////////
            if (lblHabilidades.ForeColor == Color.Lime)
            {
                lblHabilidades.ForeColor = Color.Red;
            }

            else if (lblHabilidades.ForeColor == Color.Red)
            {
                lblHabilidades.ForeColor = Color.Violet;
            }

            else if (lblHabilidades.ForeColor == Color.Violet)
            {
                lblHabilidades.ForeColor = Color.Blue;
            }

            else if (lblHabilidades.ForeColor == Color.Blue)
            {
                lblHabilidades.ForeColor = Color.Olive;
            }

            else if (lblHabilidades.ForeColor == Color.Olive)
            {
                lblHabilidades.ForeColor = Color.DarkOrange;
            }

            else if (lblHabilidades.ForeColor == Color.DarkOrange)
            {
                lblHabilidades.ForeColor = Color.Green;
            }

            else if (lblHabilidades.ForeColor == Color.Green)
            {
                lblHabilidades.ForeColor = Color.Cyan;
            }

            else if (lblHabilidades.ForeColor == Color.Cyan)
            {
                lblHabilidades.ForeColor = Color.White;
            }

            else
            {
                lblHabilidades.ForeColor = Color.Lime;
            }

            //


        }

/*===========================================================================================*/
                                // COMPRAS DE HABILIDADE //
/*===========================================================================================*/

/*$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$*/

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            resTotal = resTotalFalso + resTotalClone + resTotalBanco;
            txtMoney.Text = Convert.ToString(resTotal);
        }

        private void btnMoneyCash_Click(object sender, EventArgs e)
        {
            //resTotalBanco = resBanco * mtpc2;
            //resTotalClone = resClone * mtpc3;
            //resTotalFalso = resFalso * mtpc5;
            //resTotal = resTotalFalso + resTotalClone + resTotalBanco;
            //txtMoney.Text = Convert.ToString(resTotal);
        }

        public void Metodo()
        {
            resTotalBanco = resBanco * mtpc5;
            resTotalClone = resClone * mtpc2;
            resTotalFalso = resFalso * mtpc3;
            resTotal = resTotalFalso + resTotalClone + resTotalBanco;
            txtMoney.Text = Convert.ToString(resTotal);
        }
        
/*$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$*/


        private void btnComprarPerk1_Click(object sender, EventArgs e)
        {
            mtpc2 = mtpc2 + 2;
            mtpc3 = mtpc3 + 3;
            mtpc5 = mtpc5 + 10;
            btnComprarPerk1.Visible = false;
        }

        private void btnComprarPerk2_Click(object sender, EventArgs e)
        {
            mtpc2 = mtpc2 + 4;
            mtpc3 = mtpc3 + 6;
            mtpc5 = mtpc5 + 20;
            btnComprarPerk2.Visible = false;
        }

        private void btnComprarPerk6_Click(object sender, EventArgs e)
        {
            if (resTotal >= 100000)
            {
                resTotal = 100000 - resTotal;
                txtMoney.Text = Convert.ToString(resTotal);
                resClone = 0;
                resFalso = 0;
                resBanco = 0;
                resInfect = 0;
                picBox1.Visible = false;
                btnComprarPerk6.Visible = false;
                lblQntdClone.Text = Convert.ToString(resClone);
                lblQntdFalso.Text = Convert.ToString(resFalso);
                lblQntdBanco.Text = Convert.ToString(resBanco);
                lblQntdDistribution.Text = Convert.ToString(resInfect);
            }
            else
            {

            }
        }

        private void btnComprarPerk3_Click(object sender, EventArgs e)
        {
            mtpc2 = mtpc2 + 6;
            mtpc3 = mtpc3 + 9;
            mtpc5 = mtpc5 + 30;
            btnComprarPerk3.Visible = false;
        }

        private void btnComprarPerk4_Click(object sender, EventArgs e)
        {
            mtpc2 = mtpc2 + 8;
            mtpc3 = mtpc3 + 12;
            mtpc5 = mtpc5 + 40;
            btnComprarPerk4.Visible = false;
        }

        private void btnComprarPerk5_Click(object sender, EventArgs e)
        {
            mtpc2 = mtpc2 + 10;
            mtpc3 = mtpc3 + 15;
            mtpc5 = mtpc5 + 50;
            btnComprarPerk5.Visible = false;
        }

/*===========================================================================================*/
                                // SEM USO ATÉ AGORA //
/*===========================================================================================*/
        
        private void lblQntdClone_Click(object sender, EventArgs e)
        {

        }

        private void lblQntdMalware_Click(object sender, EventArgs e)
        {

        }

        private void grpBoxClonagem_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarPerk9_Click(object sender, EventArgs e)
        {

        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        private void picHack1_Click(object sender, EventArgs e)
        {

        }

        private void picGlitch_Click(object sender, EventArgs e)
        {

        }

        private void picHack2_Click(object sender, EventArgs e)
        {

        }

        private void barDistribution1_Click(object sender, EventArgs e)
        {

        }
    }
}
