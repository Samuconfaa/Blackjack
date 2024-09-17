using System.Threading.Tasks;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool started = false;
        bool puntato = false;
        int saldo = 20;
        int puntataAttuale = 0;
        int randomN;
        int valorePlayer = 0;
        int valoreOpponent = 0;
        int punteggioTu = 0;
        int punteggioAvv = 0;
        



        private async void btnCarta_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Random random = new Random();
                randomN = random.Next(1, 11);
                valorePlayer += randomN;
                txtBox.Text = valorePlayer.ToString();
                if (valorePlayer < 21)
                {
                    txtBoxMessaggi.Text = "Hai preso altri " + valorePlayer + " punti. Vuoi prendere un'altra carta o fermarti?";
                }
                else if (valorePlayer == 21)
                {
                    txtBoxMessaggi.Text = "Hai fatto 21 ed hai vinto. Bravo!";
                    punteggioTu++;
                    reloadScore();
                    await Task.Delay(2000);
                    txtBox.Clear();
                    txtBoxMessaggi.Clear();
                    started = false;
                    vittoria();
                    txtPuntata.Clear();
                }
                else
                {
                    txtBoxMessaggi.Text = "Hai fatto più di 21 ed hai perso";
                    punteggioAvv++;
                    reloadScore();
                    await Task.Delay(2000);
                    txtBox.Clear();
                    txtBoxMessaggi.Clear();
                    started = false;
                    txtPuntata.Clear();
                }
            }
            else
            {
                txtBoxMessaggi.Text = "Gioco non avviato, clicca su AVVIA per iniziare";
            }
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            if (started)
            {
                txtBoxMessaggi.Text = "Ora tocca al tuo opponente giocare! Deve fare più di " + valorePlayer + " punti per vincere";
                await Task.Delay(2000);
                while (valoreOpponent < 17)
                {
                    Random random = new Random();
                    randomN = random.Next(1, 11);
                    valoreOpponent += randomN;
                    txtBoxOpp.Text = valoreOpponent.ToString();
                    if (valoreOpponent < valorePlayer)
                    {
                        txtBoxMessaggi.Text = "Il tuo avversario è a " + valoreOpponent + " punti. Nell'ultima giocata ha fatto " + randomN + " punti.";
                    }
                    else if (valoreOpponent == valorePlayer)
                    {
                        txtBoxMessaggi.Text = "Avete pareggiato con " + valoreOpponent + " punti.";
                        await Task.Delay(2000);
                        txtBox.Clear();
                        txtBoxMessaggi.Clear();
                        txtBoxOpp.Clear();
                        pareggio();
                        txtPuntata.Clear();
                        break;
                        
                    }
                    else if ((valoreOpponent > valorePlayer) && (valoreOpponent < 22))
                    {
                        txtBoxMessaggi.Text = "Il tuo avversario ha vinto con " + valoreOpponent + " punti.";
                        punteggioAvv++;
                        reloadScore();
                        await Task.Delay(2000);
                        txtBox.Clear();
                        txtBoxMessaggi.Clear();
                        txtBoxOpp.Clear();
                        txtPuntata.Clear();
                        break;

                    }
                    else
                    {
                        txtBoxMessaggi.Text = "Il tuo avversario ha fatto più di 21 punti ed ha perso.";
                        punteggioTu++;
                        reloadScore();
                        await Task.Delay(2000);
                        txtBox.Clear();
                        txtBoxMessaggi.Clear();
                        txtBoxOpp.Clear();
                        txtPuntata.Clear();
                        break;
                    }
                    await Task.Delay(2000);
                }
                if ((valorePlayer > valoreOpponent) && (valoreOpponent >= 17))
                {
                    txtBoxMessaggi.Text = "Complimenti! Hai fatto più punti e hai vinto";
                    punteggioTu++;
                    reloadScore();
                    await Task.Delay(2000);
                    txtBox.Clear();
                    txtBoxMessaggi.Clear();
                    txtBoxOpp.Clear();
                    vittoria();
                    txtPuntata.Clear();


                }
                else
                {
                    txtBoxMessaggi.Text = "Gioco non avviato, clicca su AVVIA per iniziare";
                }
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (puntato)
            {
                started = true;
                reloadScore();
                valorePlayer = 0;
                valoreOpponent = 0;
                Random random = new Random();
                randomN = random.Next(1, 11);
                valorePlayer = randomN;
                txtBox.Text = valorePlayer.ToString();
                txtBoxMessaggi.Text = "Nella prima giocata hai totalizzato un punteggio di " + valorePlayer;
                await Task.Delay(2000);
                randomN = random.Next(1, 11);
                valorePlayer += randomN;
                txtBox.Text = valorePlayer.ToString();
                txtBoxMessaggi.Text = "Nella seconda giocata hai totalizzato un punteggio di " + randomN;
                await Task.Delay(2000);
                txtBoxMessaggi.Text = "Vuoi prendere un'altra carta o vuoi fermarti?";
            }
            else if (checkSaldo())
            {
                txtBoxMessaggi.Text = "Devi fare una puntata prima di giocare";
            }
            else
            {
                txtBoxMessaggi.Text = "Hai finito il saldo e non puoi più giocare. Premi RESET per avviare una nuova partita";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            punteggioTu = 0;
            punteggioAvv = 0;
            saldo = 20;
            
            reloadScore();
            txtPuntata.Clear();


        }

        public void reloadScore()
        {
            txtAvv.Text = punteggioAvv.ToString();
            txtYou.Text = punteggioTu.ToString();
            txtSaldo.Text = saldo.ToString();
            
            puntato = false;


        }

        public bool checkSaldo()
        {
            if (saldo >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void vittoria()
        {
            saldo += puntataAttuale * 2;
            txtSaldo.Text = saldo.ToString();
            
        }

        public void pareggio()
        {
            saldo += puntataAttuale;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (saldo >= 5)
            {
                if (!(puntato))
                {
                    puntataAttuale = 5;
                    saldo -= 5;
                    txtPuntata.Text = puntataAttuale.ToString();
                    txtSaldo.Text = saldo.ToString();
                    puntato = true;
                }
                else
                {
                    txtBoxMessaggi.Text = "Hai già fatto una puntata";
                }
            }
            else
            {
                txtBoxMessaggi.Text = "Non hai abbastanza soldi";
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (saldo >= 10)
            {
                if (!(puntato))
                {
                    puntataAttuale = 10;
                    saldo -= 10;
                    txtPuntata.Text = puntataAttuale.ToString();
                    txtSaldo.Text = saldo.ToString();
                    puntato = true;
                }
                else
                {
                    txtBoxMessaggi.Text = "Hai già fatto una puntata";
                }
            }
            else
            {
                txtBoxMessaggi.Text = "Non hai abbastanza soldi";
            }
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (saldo >= 50)
            {
                if (!(puntato))
                {
                    puntataAttuale = 50;
                    saldo -= 50;
                    txtPuntata.Text = puntataAttuale.ToString();
                    txtSaldo.Text = saldo.ToString();
                    puntato = true;
                }
                else
                {
                    txtBoxMessaggi.Text = "Hai già fatto una puntata";
                }
            }
            else
            {
                txtBoxMessaggi.Text = "Non hai abbastanza soldi";
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (saldo >= 100)
            {
                if (!(puntato))
                {
                    puntataAttuale = 100;
                    saldo -= 100;
                    txtPuntata.Text = puntataAttuale.ToString();
                    txtSaldo.Text = saldo.ToString();
                    puntato = true;
                }
                else
                {
                    txtBoxMessaggi.Text = "Hai già fatto una puntata";
                }
            }
            else
            {
                txtBoxMessaggi.Text = "Non hai abbastanza soldi";
            }
        }
    }
}

