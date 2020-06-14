using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Child_Form.Modifly
{
    public partial class FormModiflyDesc : Form
    {

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
        public FormModiflyDesc()
        {
            InitializeComponent();
        }

        private void FormModiflyDesc_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
