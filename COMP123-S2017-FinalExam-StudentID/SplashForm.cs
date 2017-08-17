using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {

        public PickHighestCardForm PickHighestCardForm
        {

            get
            {
                return Program.pickHighestCardForm;
            }

        }
        public SplashForm()
        {
            InitializeComponent();
            
        }

        private void tickHandler(object sender, EventArgs e)
        {

            this.PickHighestCardForm.Show();

            this.Hide();

            timer1.Enabled = false;
        }
    }
}
