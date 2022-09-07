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
    public partial class frmMain : MaterialForm
    {
        private static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager manager =  MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme=MaterialSkinManager.Instance.Theme;
            manager.ColorScheme = new ColorScheme(Primary.Brown100,Primary.Brown200,Primary.Brown200,Accent.LightGreen200,TextShade.WHITE);
        }

        private void MainContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        public Panel Content
        {
            get { return MainContainer; }
            set { MainContainer = value; }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _instance = this;
            MainContainer.Controls.Add(new ucLogin() { Dock = DockStyle.Fill});   
        }
    }   
}
