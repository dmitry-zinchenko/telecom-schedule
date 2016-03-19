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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUniform_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uniformWindow = new UniformScheduleWindow();
            uniformWindow.Show();
        }

        private void buttonIrregular_Click(object sender, EventArgs e)
        {
            this.Hide();
            var irregularWindow = new IrregularScheduleWindow();
            irregularWindow.Show();
        }
    }
}
