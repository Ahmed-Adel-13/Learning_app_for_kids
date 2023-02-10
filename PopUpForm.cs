using cs_learning_app.Properties;
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

namespace cs_learning_app
{
    public partial class PopUpForm : Form
    {
        private string _language;
        public string Language
        {
            get { return _language; }
            set
            {
                _language = value;
                ChooseInstruction();
            }
        }
        public void ChooseInstruction()
        {
            string instructions = "Press the letter from your keyboard";
            if (Language == "FR")
                instructions = "Tapez une lettre sur votre clavier";
            else if (Language == "AR")
                instructions = "اكتب شيئا ما على لوحة المفاتيح";
            InstructionsLabel.Text = instructions;

        }
        public PopUpForm()
        {
            InitializeComponent();
            ShowBtn.Hide();
        }
        public void timerdef() 
        {
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                this.Invoke(new Action(() =>
                {
                    ShowBtn.Hide();
                    InstructionsLabel.Show();
                }));
            });
        }
        public async Task timerdeffAsync() {
            await Task.Delay(3000);
            
            ShowBtn.Hide();
            InstructionsLabel.Show();

        }
        public async Task PlaySoundAsync(string input)
        {
            string valToBeTested = input.ToUpper();
            var soundLocation = Resources.vide;
            //FOR ENGLISH ALPHABET
            if (valToBeTested == "A" && Language == "EN")
                soundLocation = Resources.A;
            else if (valToBeTested == "B" && Language == "EN")
                soundLocation = Resources.B;
            else if (valToBeTested == "C" && Language == "EN")
                soundLocation = Resources.C;
            else if (valToBeTested == "D" && Language == "EN")
                soundLocation = Resources.D;
            else if (valToBeTested == "E" && Language == "EN")
                soundLocation = Resources.E;
            else if (valToBeTested == "F" && Language == "EN")
                soundLocation = Resources.F;
            else if (valToBeTested == "G" && Language == "EN")
                soundLocation = Resources.G;
            else if (valToBeTested == "H" && Language == "EN")
                soundLocation = Resources.H;
            else if (valToBeTested == "I" && Language == "EN")
                soundLocation = Resources.I;
            else if (valToBeTested == "J" && Language == "EN")
                soundLocation = Resources.J;
            else if (valToBeTested == "K" && Language == "EN")
                soundLocation = Resources.K;
            else if (valToBeTested == "L" && Language == "EN")
                soundLocation = Resources.L;
            else if (valToBeTested == "M" && Language == "EN")
                soundLocation = Resources.M;
            else if (valToBeTested == "N" && Language == "EN")
                soundLocation = Resources.N;
            else if (valToBeTested == "O" && Language == "EN")
                soundLocation = Resources.O;
            else if (valToBeTested == "P" && Language == "EN")
                soundLocation = Resources.P;
            else if (valToBeTested == "Q" && Language == "EN")
                soundLocation = Resources.Q;
            else if (valToBeTested == "R" && Language == "EN")
                soundLocation = Resources.R;
            else if (valToBeTested == "S" && Language == "EN")
                soundLocation = Resources.S;
            else if (valToBeTested == "T" && Language == "EN")
                soundLocation = Resources.T;
            else if (valToBeTested == "U" && Language == "EN")
                soundLocation = Resources.U;
            else if (valToBeTested == "V" && Language == "EN")
                soundLocation = Resources.V;
            else if (valToBeTested == "W" && Language == "EN")
                soundLocation = Resources.W;
            else if (valToBeTested == "X" && Language == "EN")
                soundLocation = Resources.X;
            else if (valToBeTested == "Y" && Language == "EN")
                soundLocation = Resources.Y;
            else if (valToBeTested == "Z" && Language == "EN")
                soundLocation = Resources.Z;
            //FOR ENGLISH NUMBRS
            if (valToBeTested == "0" && Language == "EN")
                soundLocation = Resources._0;
            if (valToBeTested == "1" && Language == "EN")
                soundLocation = Resources._1;
            if (valToBeTested == "2" && Language == "EN")
                soundLocation = Resources._2;
            if (valToBeTested == "3" && Language == "EN")
                soundLocation = Resources._3;
            if (valToBeTested == "4" && Language == "EN")
                soundLocation = Resources._4;
            if (valToBeTested == "5" && Language == "EN")
                soundLocation = Resources._5;
            if (valToBeTested == "6" && Language == "EN")
                soundLocation = Resources._6;
            if (valToBeTested == "7" && Language == "EN")
                soundLocation = Resources._7;
            if (valToBeTested == "8" && Language == "EN")
                soundLocation = Resources._8;
            if (valToBeTested == "9" && Language == "EN")
                soundLocation = Resources._9;   
            //FOR FRENCH ALPHABET
            if (valToBeTested == "A" && Language == "FR")
                soundLocation = Resources.A1;
            else if (valToBeTested == "B" && Language == "FR")
                soundLocation = Resources.B1;
            else if (valToBeTested == "C" && Language == "FR")
                soundLocation = Resources.C1;
            else if (valToBeTested == "D" && Language == "FR")
                soundLocation = Resources.D1;
            else if (valToBeTested == "E" && Language == "FR")
                soundLocation = Resources.E1;
            else if (valToBeTested == "F" && Language == "FR")
                soundLocation = Resources.F1;
            else if (valToBeTested == "G" && Language == "FR")
                soundLocation = Resources.G1;
            else if (valToBeTested == "H" && Language == "FR")
                soundLocation = Resources.H1;
            else if (valToBeTested == "I" && Language == "FR")
                soundLocation = Resources.I1;
            else if (valToBeTested == "J" && Language == "FR")
                soundLocation = Resources.J1;
            else if (valToBeTested == "K" && Language == "FR")
                soundLocation = Resources.K1;
            else if (valToBeTested == "L" && Language == "FR")
                soundLocation = Resources.L1;
            else if (valToBeTested == "M" && Language == "FR")
                soundLocation = Resources.M1;
            else if (valToBeTested == "N" && Language == "FR")
                soundLocation = Resources.N1;
            else if (valToBeTested == "O" && Language == "FR")
                soundLocation = Resources.O1;
            else if (valToBeTested == "P" && Language == "FR")
                soundLocation = Resources.P1;
            else if (valToBeTested == "Q" && Language == "FR")
                soundLocation = Resources.Q1;
            else if (valToBeTested == "R" && Language == "FR")
                soundLocation = Resources.R1;
            else if (valToBeTested == "S" && Language == "FR")
                soundLocation = Resources.S1;
            else if (valToBeTested == "T" && Language == "FR")
                soundLocation = Resources.T1;
            else if (valToBeTested == "U" && Language == "FR")
                soundLocation = Resources.U1;
            else if (valToBeTested == "V" && Language == "FR")
                soundLocation = Resources.V1;
            else if (valToBeTested == "W" && Language == "FR")
                soundLocation = Resources.W1;
            else if (valToBeTested == "X" && Language == "FR")
                soundLocation = Resources.X1;
            else if (valToBeTested == "Y" && Language == "FR")
                soundLocation = Resources.Y1;
            else if (valToBeTested == "Z" && Language == "FR")
                soundLocation = Resources.Z1;
            //FOR ENGLISH NUMBRS
            if (valToBeTested == "0" && Language == "FR")
                soundLocation = Resources._000;
            if (valToBeTested == "1" && Language == "FR")
                soundLocation = Resources._1_un_une;
            if (valToBeTested == "2" && Language == "FR")
                soundLocation = Resources._2_deux ;
            if (valToBeTested == "3" && Language == "FR")
                soundLocation = Resources._3_trois ;
            if (valToBeTested == "4" && Language == "FR")
                soundLocation = Resources._4_quatre;
            if (valToBeTested == "5" && Language == "FR")
                soundLocation = Resources._5_cinq;
            if (valToBeTested == "6" && Language == "FR")
                soundLocation = Resources._6_six;
            if (valToBeTested == "7" && Language == "FR")
                soundLocation = Resources._7_sept;
            if (valToBeTested == "8" && Language == "FR")
                soundLocation = Resources._8_huit;
            if (valToBeTested == "9" && Language == "FR")
                soundLocation = Resources._9_neuf;
            //FOR ARABIC ALPHABET
            if (valToBeTested == "أ" && Language == "AR")
                soundLocation = Resources._001_alif;
            else if (valToBeTested == "ب" && Language == "AR")
                soundLocation = Resources._002_ba;
            else if (valToBeTested == "ت" && Language == "AR")
                soundLocation = Resources._003_taa;
            else if (valToBeTested =="ث" && Language == "AR")
                soundLocation = Resources._004_tha;
            else if (valToBeTested == "ج" && Language == "AR")
                soundLocation = Resources._005_jeem;
            else if (valToBeTested == "ح" && Language == "AR")
                soundLocation = Resources._006_haa;
            else if (valToBeTested == "خ" && Language == "AR")
                soundLocation = Resources._007_khaa;
            else if (valToBeTested == "د" && Language == "AR")
                soundLocation = Resources._008_dal;
            else if (valToBeTested == "ذ" && Language == "AR")
                soundLocation = Resources._009_dhal;
            else if (valToBeTested == "ر" && Language == "AR")
                soundLocation = Resources._010_raa;
            else if (valToBeTested == "ز" && Language == "AR")
                soundLocation = Resources._011_jaa;
            else if (valToBeTested == "س" && Language == "AR")
                soundLocation = Resources._012_seen;
            else if (valToBeTested == "ش" && Language == "AR")
                soundLocation = Resources._013_sheen;
            else if (valToBeTested == "ص" && Language == "AR")
                soundLocation = Resources._014_saad;
            else if (valToBeTested == "ض" && Language == "AR")
                soundLocation = Resources._015_dhaad;
            else if (valToBeTested == "ط" && Language == "AR")
                soundLocation = Resources._016_toa;
            else if (valToBeTested == "ظ" && Language == "AR")
                soundLocation = Resources._017_dhaa;
            else if (valToBeTested == "ع" && Language == "AR")
                soundLocation = Resources._018_ain;
            else if (valToBeTested == "غ" && Language == "AR")
                soundLocation = Resources._019_ghain;
            else if (valToBeTested == "ف"&& Language == "AR")
                soundLocation = Resources._020_faa;
            else if (valToBeTested == "ق" && Language == "AR")
                soundLocation = Resources._021_qaaf;
            else if (valToBeTested == "ك" && Language == "AR")
                soundLocation = Resources._022_kaaf;
            else if (valToBeTested == "ل" && Language == "AR")
                soundLocation = Resources._023_laam;
            else if (valToBeTested == "م" && Language == "AR")
                soundLocation = Resources._024_meem;
            else if (valToBeTested == "ن" && Language == "AR")
                soundLocation = Resources._025_noon;
            else if (valToBeTested == "و" && Language == "AR")
                soundLocation = Resources._026_waw;
            else if (valToBeTested == "ه" && Language == "AR")
                soundLocation = Resources._027_ha;
            else if (valToBeTested == "ء" && Language == "AR")
                soundLocation = Resources._028_hamza;
            else if (valToBeTested == "ي" && Language == "AR")
                soundLocation = Resources._029_yaa;
            //FOR ENGLISH NUMBRS
            if (valToBeTested == "0" && Language == "AR")
                soundLocation = Resources._00;
            if (valToBeTested == "1" && Language == "AR")
                soundLocation = Resources._11;
            if (valToBeTested == "2" && Language == "AR")
                soundLocation = Resources._22;
            if (valToBeTested == "3" && Language == "AR")
                soundLocation = Resources._33;
            if (valToBeTested == "4" && Language == "AR")
                soundLocation = Resources._44;
            if (valToBeTested == "5" && Language == "AR")
                soundLocation = Resources._55;
            if (valToBeTested == "6" && Language == "AR")
                soundLocation = Resources._66;
            if (valToBeTested == "7" && Language == "AR")
                soundLocation = Resources._77;
            if (valToBeTested == "8" && Language == "AR")
                soundLocation = Resources._88;
            if (valToBeTested == "9" && Language == "AR")
                soundLocation = Resources._99;

            SoundPlayer player = new SoundPlayer(soundLocation);
            player.Play();

            await timerdeffAsync();  
        }
        public void DisplayTypedCharacter(string input)
        {
            InstructionsLabel.Hide();
            ShowBtn.Show();
            ShowBtn.Text = input;
            PlaySoundAsync(input);
        }

        private void PopUpForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisplayTypedCharacter(e.KeyChar.ToString());

        }
    }
}
