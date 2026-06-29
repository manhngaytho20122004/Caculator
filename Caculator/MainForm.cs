using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCaculatorModal_Click(object sender, EventArgs e)
        {
            CaculatorModal ViewCaculatorModal = new CaculatorModal();
            ViewCaculatorModal.ShowDialog();
           
        }

        private void btnCaculatorModelLess_Click(object sender, EventArgs e)
        {
            CaculatorModal ViewCaculatorModal = new CaculatorModal();
            ViewCaculatorModal.Show();
        }
        private void btnStopWatch_Click(object sender, EventArgs e)
        {
           StopWatch ViewStopWatch = new StopWatch();
           ViewStopWatch.ShowDialog();
        }
    }
}
