using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Welcome.ActiveForm.Opacity -= 1;
            if (Welcome.ActiveForm.Opacity == 0)
                Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            picOU.Image = Image.FromFile(Application.StartupPath + @"\Images\cntt.png");
        }
    }
}
