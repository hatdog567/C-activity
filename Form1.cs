using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elementary_School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grade1btn_CheckedChanged(object sender, EventArgs e)
        {
            if (grade1btn.Checked)
                txtboxgrade.Text = "Grade I";
        }

        private void grade2btn_CheckedChanged(object sender, EventArgs e)
        {
            if (grade2btn.Checked)
                txtboxgrade.Text = "Grade II";
        }

        private void grade3btn_CheckedChanged(object sender, EventArgs e)
        {
            if (grade3btn.Checked)
                txtboxgrade.Text = "Grade III";
        }

        private void grade4btn_CheckedChanged(object sender, EventArgs e)
        {
            if (grade4btn.Checked)
                txtboxgrade.Text = "Grade IV";
        }

        private void grade5btn_CheckedChanged(object sender, EventArgs e)
        {
            if (grade5btn.Checked)
                txtboxgrade.Text = "Grade V";
        }

        private void grade6btn_CheckedChanged(object sender, EventArgs e)
        {
            if (grade6btn.Checked)
                txtboxgrade.Text = "Grade VI";
        }
    }
}
