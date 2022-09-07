using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class frmSend : MaterialForm
    {
        public frmSend()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Instance.Theme;
            manager.ColorScheme = new ColorScheme(Primary.Brown100, Primary.Brown200, Primary.Brown200, Accent.LightGreen200, TextShade.WHITE);
        
    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("message sent");
        }
    }
}
