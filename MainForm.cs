using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_learning_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Englishbtn_Click(object sender, EventArgs e)
        {
            var PopUpForm = new PopUpForm();
            PopUpForm.Language = "EN";
            PopUpForm.Show();

        }

        private void Arbicbtn_Click(object sender, EventArgs e)
        {
            var PopUpForm = new PopUpForm();
            PopUpForm.Language = "AR";
            PopUpForm.Show();
        }

        private void Franchbtn_Click(object sender, EventArgs e)
        {
            var PopUpForm = new PopUpForm();
            PopUpForm.Language = "FR";
            PopUpForm.Show();
        }
    }
}
