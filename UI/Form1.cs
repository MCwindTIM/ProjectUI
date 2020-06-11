using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentBtn;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Mouse LOC
        public Point mouseloc;

        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateBtn(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentBtn != (Button)btnSender)
                {
                    DisableBtn();
                    Color color = SelectThemeColor();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btn_closeChildForm.Visible = true;

                }
            }
        }

        private void DisableBtn()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateBtn(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_DesktopPane.Controls.Add(childForm);
            this.panel_DesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_title.Text = childForm.Text;
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Form.FormProducts(), sender);
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Form.FormCart(), sender);
        }

        private void btn_Games_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Form.FormGames(), sender);
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Form.FormSetting(), sender);
        }

        private void btn_closeChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableBtn();
            lbl_title.Text = "Home";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentBtn = null;
            btn_closeChildForm.Visible = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            this.Show();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_move_MouseDown(object sender, MouseEventArgs e)
        {
            mouseloc = e.Location;
        }

        private void btn_move_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    (this.Location.X - mouseloc.X) + e.X, (this.Location.Y - mouseloc.Y) + e.Y);
                this.Update();
            }
        }
    }
}
