using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telecom_schedule
{
    public partial class IrregularScheduleWindow : Form
    {
        public IrregularScheduleWindow()
        {
            InitializeComponent();
        }

        private void IrregularScheduleWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
