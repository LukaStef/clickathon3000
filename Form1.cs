using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace clickathon3000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        string aktivanFajl = @"komande.txt";

        #region definisanje dogadjaja za mis
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
        #endregion
        #region komande
        //move: 587, 47
        //leftclick
        //rightclick
        //text: aaa
        //date: format
        //date: -n
        //enter
        //ctrla
        //curl: http://zeastim.com/log.php?id=officebanking
        //pause: n seconds
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int interval = int.Parse(numericUpDown1.Text);
                switch (cmbInterval.Text)
                {
                    case "Sati":
                        interval *= 1000 * 3600;
                        break;
                    case "Minuta":
                        interval *= 1000 * 60;
                        break;
                    case "Sekundi":
                        interval *= 1000;
                        break;
                }
                btnPocni.Enabled = false;
                btnPocniOdmah.Enabled = false;
                btnZaustavi.Enabled = true;
                cmbInterval.Enabled = false;
                timer1.Interval = interval;
                desilaSeGreska = false;
                timer1.Start();
            }
            catch { MessageBox.Show("Interval mora biti ceo broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int interval = int.Parse(numericUpDown1.Text);
                switch (cmbInterval.Text)
                {
                    case "Sati":
                        interval *= 1000 * 3600;
                        break;
                    case "Minuta":
                        interval *= 1000 * 60;
                        break;
                    case "Sekundi":
                        interval *= 1000;
                        break;
                }
                btnPocni.Enabled = false;
                btnPocniOdmah.Enabled = false;
                btnZaustavi.Enabled = true;
                cmbInterval.Enabled = false;
                timer1.Interval = interval;
                desilaSeGreska = false;
                IzvrsiKomande();
                timer1.Start();
            }
            catch { MessageBox.Show("Interval mora biti ceo broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }
        bool desilaSeGreska = false;
        bool continueTimer = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!continueTimer)
            {
                return; // Exit the method early if continueTimer is false
            }

            timer1.Stop();
            IzvrsiKomande();

            if (desilaSeGreska == false)
            {
                timer1.Start();
            }
            else
            {
                continueTimer = false; // Set the flag to prevent further ticks
            }
        }

        // Helper function to simulate mouse events
        public static void MouseEvent(uint dwFlags)
        {
            int dx = Cursor.Position.X;
            int dy = Cursor.Position.Y;
            mouse_event(dwFlags, dx, dy, 0, 0);
        }

        private void IzvrsiKomande()
        {
            if (desilaSeGreska)
            {
                return;
            }
            string niz = File.ReadAllText(aktivanFajl);
            if (niz == "")
                return;
            string[] komande = niz.Split("\r\n");
            foreach (string trenutnaKomanda in komande)
            {
                if (desilaSeGreska)
                {
                    return; // If an error occurred, don't execute further
                }
                bool dalje = true;
                if (trenutnaKomanda == "")
                {
                    dalje = false;
                }
                if (dalje)
                {
                    if (trenutnaKomanda.Contains(": "))
                    {
                        IzvrsiKomanduSaArg(trenutnaKomanda);
                    }
                    else
                    {
                        IzvrsiKomanduBezArg(trenutnaKomanda);
                    }
                    Thread.Sleep(1000);
                    Refresh();
                    lblTrenutnaKomanda.Text = $"Trenutna komanda: {trenutnaKomanda}";
                }
                
            }
        }
        private void IzvrsiKomanduSaArg(string trenutnaKomanda)
        {
            string[] celaKomanda = trenutnaKomanda.Split(": ");
            string samaKomanda = celaKomanda[0];
            string argument = celaKomanda[1];
            lblTrenutnaKomanda.Text = $"Trenutna komanda: {trenutnaKomanda}";
            switch (samaKomanda)
            {
                case "move":
                    PomeriMis(argument);
                    break;
                case "text":
                    UnesiTekst(argument);
                    break;
                case "pause":
                    Pauziraj(argument);
                    break;
                case "date":
                    UnesiDatum(argument);
                    break;
                case "curl":
                    Curl(argument);
                    break;
                case "rem": break;
                default:
                    MessageBox.Show("Komanda ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ZaustaviTajmer();
                    break;
            }
            Refresh();
            lblTrenutnaKomanda.Text = $"Trenutna komanda: {trenutnaKomanda}";
        }

        private void IzvrsiKomanduBezArg(string trenutnaKomanda)
        {
            lblTrenutnaKomanda.Text = $"Trenutna komanda: {trenutnaKomanda}";
            switch (trenutnaKomanda)
            {
                case "leftclick":
                    LeviKlik();
                    break;
                case "rightclick":
                    DesniKlik();
                    break;
                case "enter":
                    SendKeys.SendWait("{ENTER}");
                    break;
                case "ctrla":
                    SendKeys.SendWait("^(a)");
                    break;
                default:
                    MessageBox.Show("Komanda ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ZaustaviTajmer();
                    break;
            }
            Refresh();
            lblTrenutnaKomanda.Text = $"Trenutna komanda: {trenutnaKomanda}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            cmbInterval.SelectedIndex = 2;

        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnZaustavi.Enabled = false;
            btnPocni.Enabled = true;
            btnPocniOdmah.Enabled = true;
            cmbInterval.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = "Pozicija miša (X, Y): " + Cursor.Position.X + ", " + Cursor.Position.Y;
        }

        private void komandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prenos.Naslov = "Komande";
            Prenos.Tekst = "Sve komande: \n" +
                "move: X,Y - pomera miša na koordinate\n" +
                "leftclick - simulira levi klik\n" +
                "rightclick - simulira desni klik\n" +
                "text: <tekst> - unosi tekst\n" +
                "date: format;n - ispisuje trenutni datum i dodaje mu n dana (deo za dodavanje dana nije neophodan, broj dana može biti manji od nule)\n" +
                "enter - simulira pritiskanje dugmeta enter\n" +
                "ctrla - simulira selektovanje svega (ctrl + a)\n" +
                "curl: <url> - gađa uneti url sa praznim postom\n" +
                "pause: n - zaustavlja rad za n sekundi\n" +
                "rem: <tekst> - ova komande predstavlja komentar i nema funkciju\n";
            i.ShowDialog();
        }
        private static void LeviKlik()
        {
            MouseEvent(MOUSEEVENTF_LEFTDOWN);
            MouseEvent(MOUSEEVENTF_LEFTUP);
        }
        private static void DesniKlik()
        {
            MouseEvent(MOUSEEVENTF_RIGHTDOWN);
            MouseEvent(MOUSEEVENTF_RIGHTUP);
        }

        private void PomeriMis(string argument)
        {
            try
            {
                //argument = argument.Replace(' ', '\0');
                string[] podela = argument.Split(",");
                int X = int.Parse(podela[0]);
                int Y = int.Parse(podela[1]);
                Cursor.Position = new Point(X, Y);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Greška: {e.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZaustaviTajmer();
                return;
            }
        }

        private void UnesiTekst(string argument)
        {
            try
            {
                foreach (char c in argument)
                {
                    SendKeys.Send(c.ToString());
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Greška: {e.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZaustaviTajmer();
                return;
            }
        }

        private void Pauziraj(string argument)
        {
            try
            {
                Thread.Sleep(int.Parse(argument) * 1000);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Greška: {e.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZaustaviTajmer();
                return;
            }

        }

        private void UnesiDatum(string argument)
        {
            try
            {
                argument = argument.Replace(' ', '\0');
                if (!argument.Contains(';'))
                    SendKeys.SendWait(DateTime.Now.ToString(argument));
                else
                {
                    string[] podela = argument.Split(';');
                    string format = podela[0];
                    int dani = int.Parse(podela[1]);
                    DateTime datum = DateTime.Now.AddDays(dani);
                    SendKeys.SendWait(datum.ToString(format));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Greška: {e.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ZaustaviTajmer();
                return;
            }
        }

        private async void Curl(string argument)
        {
            using HttpClient httpClient = new();
            try
            {
                // Define the URL to send the POST request to
                string url = argument;

                // Create an empty HttpContent for the POST request
                HttpContent content = new StringContent(File.ReadAllText(aktivanFajl));

                // Send the POST request
                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                // Check the response status
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Slanje POST zahteva nije uspelo. Status: {response.StatusCode}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ZaustaviTajmer();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ZaustaviTajmer()
        {
            timer1.Stop();
            desilaSeGreska = true;
            btnPocni.Enabled = true;
            btnPocniOdmah.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        readonly Informacija i = new();
        private void uputstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prenos.Naslov = "Uputstvo";
            Prenos.Tekst = "Ova aplikacija služi za pravljenje prostih skripti za automatske simulacije pritiskanja miša, tastera na tastaturi i unosa teksta. Sama skripta se piše u komande.txt fajlu. Sve komande moraju biti u posebnim redovima i u identičnom formatu kao što je napisano u spisku svih komandi.";
            i.ShowDialog();
        }

        private void informacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prenos.Naslov = "Informacija";
            Prenos.Tekst = "Autor: Luka Stefanović\n\nVerzija: 1.0\n\nlukastef42@gmail.com";
            i.ShowDialog();
        }
        private void otvoriFajlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"notepad.exe", aktivanFajl);
        }
        private void izaberiAktivniFajlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Title = "Otvori fajl";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                aktivanFajl = openFileDialog1.FileName;
            }
        }
    }
}