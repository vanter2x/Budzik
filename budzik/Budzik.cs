using System;
using System.Media;
using System.Windows.Forms;

namespace budzik
{
    public partial class Budzik : Form
    {
        
        private int HH = 0, MM = 0, SS = 0;
        private DateTime dtTime = new DateTime();
        bool _blAlarm = false, ustAlarm = false, ustClose = false, ustRem = false;
        public SoundPlayer spAlarm = new SoundPlayer("../../alarm/alarm.wav");

        //sprawdza zmianę zmiennej
        private bool BlAlarm
        {
            get { return _blAlarm; }
            set
            {
                _blAlarm = value;
                if (_blAlarm == true) spAlarm.PlayLooping();
                else spAlarm.Stop();
            }
        }



        public Budzik()
        {
            InitializeComponent();
            btnH.MouseWheel += new MouseEventHandler(TimeChange);
            btnM.MouseWheel += new MouseEventHandler(TimeChange);
            btnS.MouseWheel += new MouseEventHandler(TimeChange);
         }
        

     

        private void Form1_Load(object sender, EventArgs e)
        {
            //początkowe wartości button.text i zmiennych przechowujących czas
            btnH.Text = DateTime.Now.Hour.ToString();
            btnM.Text = DateTime.Now.Minute.ToString();
            btnS.Text = DateTime.Now.Second.ToString();
            HH = DateTime.Now.Hour;
            MM = DateTime.Now.Minute;
            SS = DateTime.Now.Second;
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            //wyświetlenie aktualnego czasu systemowego
            dtTime = DateTime.Now;
            lblTime.Text = dtTime.ToString("T");
        }

        // Ustawianie i wyłączanie alarmu...
        private void bAlarm(string x)
        {
            switch(x)
                {
                    case "1" :
                        if (ustAlarm == false)
                        {
                            lblAlarm.Text = btnH.Text + ":" + btnM.Text + ":" + btnS.Text;
                            ustAlarm = true;
                            btnStart.Text = "Stop";
                            //mnuStop.Enabled = true;
                        }
                        else
                        {
                            lblAlarm.Text = "--:--:--";
                            ustAlarm = false;
                            BlAlarm = false;
                            btnStart.Text = "Start";
                            //mnuStop.Enabled = false;
                        }
                        break;
                    case "2" :
                        if (ustClose == false)
                        {
                        DialogResult msgClose = MessageBox.Show("Uwaga zamknięcie systemu może spowodować utratę danych w niezapisanych dokumentach.", "Uwaga!", MessageBoxButtons.OKCancel);
                        if (msgClose == DialogResult.Cancel) break;
                            lblClose.Text = btnH.Text + ":" + btnM.Text + ":" + btnS.Text;
                            ustClose = true;
                            btnStart.Text = "Stop";
                            //mnuStop.Enabled = true;
                        }
                        else
                        {
                            lblClose.Text = "--:--:--";
                            ustClose = false;
                            btnStart.Text = "Zamknij...";
                            //mnuStop.Enabled = false;
                        }
                        break;
                    case "3":
                        if (ustRem == false)
                        {   
                            if(txtRem.Text.Trim()=="")
                        {
                            MessageBox.Show("Musisz wprowadzić tekst przypomnienia...");
                            break;
                        }
                            lblRem.Text = btnH.Text + ":" + btnM.Text + ":" + btnS.Text;
                            ustRem = true;
                            btnStart.Text = "Stop";
                            txtRem.Visible = false;
                            //mnuStop.Enabled = true;
                        }
                        else
                        {
                            lblRem.Text = "--:--:--";
                            ustRem = false;
                            btnStart.Text = "Ustaw";
                            txtRem.Visible = true;
                        //mnuStop.Enabled = false;
                    }
                        break;
            }
        }

        // Obsługa przycisku ustawiającego alarm
        private void btnStart_Click(object sender, EventArgs e)
        {
            bAlarm(btnStart.Tag.ToString());
            
        }

        // Wyświetlenie menu kontekstowego 
        private void ShowMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) cmsMenu.Show(MousePosition);
        }

        // Klikniecie "Pokaz" w menu kontekstowym cmsMenu
        private void mnuShow_Click(object sender, EventArgs e)
        {
            cmsMenu.Close();
            trIcon.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //Wyświetlenie menu do zmiany przycisku btnStart
        private void cmcZmiana(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsStart.Show(MousePosition);
        }

        //Zmiana tekstu przycisku btnStart w zależności od wyboru użytkownika
        private void procZmiana(object sender, EventArgs e)
        {
            if (sender == cAlarm) //alarm
            {
                btnStart.Tag = 1;
                if (ustAlarm == true) btnStart.Text = "Stop";
                else btnStart.Text = "Alarm";
            }
            else if(sender == cClose) //zamknięcie systemu
            {
                btnStart.Tag = 2;
                if (ustClose == true) btnStart.Text = "Stop";
                else btnStart.Text = "Zamknij...";
            }
            else // przypomnienie
            {
                btnStart.Tag = 3;
                if (ustRem == true) btnStart.Text = "Stop";
                else btnStart.Text = "Ustaw";
            }
        }

        // Minimalizowanie aplikacji do traya
        private void TrayIcon(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                trIcon.Visible = true;
                this.ShowInTaskbar = false;
            }
            
        }

        
        // Kliknięcie "Zamknij" w menu cmsMenu
        private void mnuClose_Click(object sender, EventArgs e)
        {
            trIcon.Visible = false;
            Application.Exit();
        }


        // Wywołanie ustawionego alarmu 
        private void Alarm(object sender, EventArgs e)
        {
            
            if (lblTime.Text == lblAlarm.Text) BlAlarm=true ;
            if (lblTime.Text == lblClose.Text) System.Diagnostics.Process.Start("Shutdown", "-s -f -t 00");
            if (lblTime.Text == lblRem.Text)
            {
                if (this.WindowState == FormWindowState.Minimized) mnuShow_Click(sender, e);
                MessageBox.Show(txtRem.Text);
                txtRem.Text = "";
                txtRem.Visible = true;
                ustRem = false;
                lblRem.Text = "--:--:--";
                if (btnStart.Tag.ToString() == "3") btnStart.Text = "Ustaw";
            }

        }
        
        // Dodawanie "zera" przed pojedyńczymi znakami na przyciskach
        private void btnChange(object sender, EventArgs e)
        {
            if (btnH.Text.Length == 1) btnH.Text= btnH.Text.Insert(0,"0");
            if (btnM.Text.Length == 1) btnM.Text = btnM.Text.Insert(0, "0");
            if (btnS.Text.Length == 1) btnS.Text = btnS.Text.Insert(0, "0");
        }

        // Obsługa ustawiania czasu alarmów
        private void TimeChange (object sender, MouseEventArgs e)
        {
            if(e.Delta > 0 || e.Button== MouseButtons.Right)
            {
                if (sender == btnH)
                {
                    if (HH < 23) HH++;
                    else HH = 0;
                }
                else if(sender == btnM)
                {
                    if (MM < 59) MM++;
                    else MM = 0;
                }
                else
                {
                    if (SS < 59) SS++;
                    else SS = 0;
                }
                btnH.Text = HH.ToString();
                btnM.Text = MM.ToString();
                btnS.Text = SS.ToString();
            }
            else if (e.Delta < 0 || e.Button == MouseButtons.Left)
            {
                if (sender == btnH)
                {
                    if (HH >0) HH--;
                    else HH = 23;
                }
                else if (sender == btnM)
                {
                    if (MM > 0) MM--;
                    else MM = 59;
                }
                else
                {
                    if (SS > 0) SS--;
                    else SS = 59;
                }
                btnH.Text = HH.ToString();
                btnM.Text = MM.ToString();
                btnS.Text = SS.ToString();
            }
        }

      
    }
}
