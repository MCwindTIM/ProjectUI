using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Child_Form.Modifly;

namespace UI.Child_Form
{
    public partial class FormProfile : Form
    {

        private FormMainMenu topMenu;

        public FormProfile(FormMainMenu MainMenu)
        {
            InitializeComponent();
            topMenu = MainMenu;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Label lbls in this.Controls.OfType<Label>())
            {
                Label lbl = (Label)lbls;
                lbl.ForeColor = ThemeColor.SecondaryColor;
            }
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btn_ChangeName_Click(object sender, EventArgs e)
        {
            topMenu.OpenChildForm(new FormModiflyName(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topMenu.OpenChildForm(new FormModiflyPassword(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topMenu.OpenChildForm(new FormModiflyEmail(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topMenu.OpenChildForm(new FormModiflyDesc(), sender);
        }
    }
}
