namespace UI
{
    partial class FormMainMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_DesktopPane = new System.Windows.Forms.Panel();
            this.lbl_ann = new System.Windows.Forms.Label();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_expand = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_closeChildForm = new System.Windows.Forms.Button();
            this.btn_PA = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_RPStaff = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_RP = new System.Windows.Forms.Button();
            this.btn_Games = new System.Windows.Forms.Button();
            this.btn_PointCard = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel_DesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_PA);
            this.panelMenu.Controls.Add(this.btn_logout);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btn_Games);
            this.panelMenu.Controls.Add(this.btn_PointCard);
            this.panelMenu.Controls.Add(this.btn_Profile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(283, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_RPStaff);
            this.panel1.Controls.Add(this.btn_Setting);
            this.panel1.Controls.Add(this.btn_RP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 71);
            this.panel1.TabIndex = 8;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(283, 96);
            this.panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(84, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btn_move);
            this.panelTitleBar.Controls.Add(this.btn_minimize);
            this.panelTitleBar.Controls.Add(this.btn_expand);
            this.panelTitleBar.Controls.Add(this.btn_exit);
            this.panelTitleBar.Controls.Add(this.btn_closeChildForm);
            this.panelTitleBar.Controls.Add(this.lbl_title);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(283, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(901, 96);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(376, 37);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(64, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Home";
            // 
            // panel_DesktopPane
            // 
            this.panel_DesktopPane.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_DesktopPane.Controls.Add(this.lbl_ann);
            this.panel_DesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DesktopPane.Location = new System.Drawing.Point(283, 96);
            this.panel_DesktopPane.Name = "panel_DesktopPane";
            this.panel_DesktopPane.Size = new System.Drawing.Size(901, 485);
            this.panel_DesktopPane.TabIndex = 2;
            // 
            // lbl_ann
            // 
            this.lbl_ann.AutoSize = true;
            this.lbl_ann.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ann.Location = new System.Drawing.Point(0, 0);
            this.lbl_ann.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ann.Name = "lbl_ann";
            this.lbl_ann.Size = new System.Drawing.Size(262, 41);
            this.lbl_ann.TabIndex = 0;
            this.lbl_ann.Text = "Announcement";
            // 
            // btn_move
            // 
            this.btn_move.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_move.FlatAppearance.BorderSize = 0;
            this.btn_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move.Image = global::UI.Properties.Resources.app_move_icon;
            this.btn_move.Location = new System.Drawing.Point(601, 0);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(75, 96);
            this.btn_move.TabIndex = 4;
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_move_MouseDown);
            this.btn_move.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_move_MouseMove);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = global::UI.Properties.Resources.app_minimize_icon;
            this.btn_minimize.Location = new System.Drawing.Point(676, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(75, 96);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_expand
            // 
            this.btn_expand.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_expand.FlatAppearance.BorderSize = 0;
            this.btn_expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expand.Image = global::UI.Properties.Resources.app_expand_icon;
            this.btn_expand.Location = new System.Drawing.Point(751, 0);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(75, 96);
            this.btn_expand.TabIndex = 2;
            this.btn_expand.UseVisualStyleBackColor = true;
            this.btn_expand.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::UI.Properties.Resources.app_close_icon;
            this.btn_exit.Location = new System.Drawing.Point(826, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 96);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_closeChildForm
            // 
            this.btn_closeChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_closeChildForm.FlatAppearance.BorderSize = 0;
            this.btn_closeChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeChildForm.Image = global::UI.Properties.Resources.app_exit_icon;
            this.btn_closeChildForm.Location = new System.Drawing.Point(0, 0);
            this.btn_closeChildForm.Name = "btn_closeChildForm";
            this.btn_closeChildForm.Size = new System.Drawing.Size(75, 96);
            this.btn_closeChildForm.TabIndex = 0;
            this.btn_closeChildForm.UseVisualStyleBackColor = true;
            this.btn_closeChildForm.Visible = false;
            this.btn_closeChildForm.Click += new System.EventHandler(this.btn_closeChildForm_Click);
            // 
            // btn_PA
            // 
            this.btn_PA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PA.FlatAppearance.BorderSize = 0;
            this.btn_PA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PA.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_PA.Image = global::UI.Properties.Resources.app_list_icon;
            this.btn_PA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PA.Location = new System.Drawing.Point(0, 312);
            this.btn_PA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_PA.Name = "btn_PA";
            this.btn_PA.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_PA.Size = new System.Drawing.Size(283, 72);
            this.btn_PA.TabIndex = 10;
            this.btn_PA.Text = "Player Account";
            this.btn_PA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PA.UseVisualStyleBackColor = true;
            this.btn_PA.Visible = false;
            this.btn_PA.Click += new System.EventHandler(this.btn_PA_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.Image = global::UI.Properties.Resources.app_exit_icon;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 438);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(283, 72);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_RPStaff
            // 
            this.btn_RPStaff.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_RPStaff.FlatAppearance.BorderSize = 0;
            this.btn_RPStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RPStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_RPStaff.Image = ((System.Drawing.Image)(resources.GetObject("btn_RPStaff.Image")));
            this.btn_RPStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RPStaff.Location = new System.Drawing.Point(1, 0);
            this.btn_RPStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_RPStaff.Name = "btn_RPStaff";
            this.btn_RPStaff.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_RPStaff.Size = new System.Drawing.Size(141, 71);
            this.btn_RPStaff.TabIndex = 10;
            this.btn_RPStaff.Text = "Receive Problems";
            this.btn_RPStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RPStaff.UseVisualStyleBackColor = true;
            this.btn_RPStaff.Visible = false;
            this.btn_RPStaff.Click += new System.EventHandler(this.btn_RPStaff_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Setting.Image = global::UI.Properties.Resources.app_setting_icon;
            this.btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Location = new System.Drawing.Point(0, 0);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Setting.Size = new System.Drawing.Size(141, 71);
            this.btn_Setting.TabIndex = 9;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_RP
            // 
            this.btn_RP.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_RP.FlatAppearance.BorderSize = 0;
            this.btn_RP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_RP.Image = ((System.Drawing.Image)(resources.GetObject("btn_RP.Image")));
            this.btn_RP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RP.Location = new System.Drawing.Point(142, 0);
            this.btn_RP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_RP.Name = "btn_RP";
            this.btn_RP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_RP.Size = new System.Drawing.Size(141, 71);
            this.btn_RP.TabIndex = 8;
            this.btn_RP.Text = "Reflect Problems";
            this.btn_RP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RP.UseVisualStyleBackColor = true;
            this.btn_RP.Click += new System.EventHandler(this.btn_RP_Click);
            // 
            // btn_Games
            // 
            this.btn_Games.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Games.FlatAppearance.BorderSize = 0;
            this.btn_Games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Games.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Games.Image = global::UI.Properties.Resources.app_game_icon;
            this.btn_Games.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Games.Location = new System.Drawing.Point(0, 240);
            this.btn_Games.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Games.Name = "btn_Games";
            this.btn_Games.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Games.Size = new System.Drawing.Size(283, 72);
            this.btn_Games.TabIndex = 3;
            this.btn_Games.Text = "Games";
            this.btn_Games.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Games.UseVisualStyleBackColor = true;
            this.btn_Games.Click += new System.EventHandler(this.btn_Games_Click);
            // 
            // btn_PointCard
            // 
            this.btn_PointCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PointCard.FlatAppearance.BorderSize = 0;
            this.btn_PointCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PointCard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_PointCard.Image = global::UI.Properties.Resources.app_cart_icon;
            this.btn_PointCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PointCard.Location = new System.Drawing.Point(0, 168);
            this.btn_PointCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_PointCard.Name = "btn_PointCard";
            this.btn_PointCard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_PointCard.Size = new System.Drawing.Size(283, 72);
            this.btn_PointCard.TabIndex = 2;
            this.btn_PointCard.Text = "Point Card";
            this.btn_PointCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PointCard.UseVisualStyleBackColor = true;
            this.btn_PointCard.Click += new System.EventHandler(this.btn_Cart_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Profile.Image = global::UI.Properties.Resources.app_list_icon;
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Location = new System.Drawing.Point(0, 96);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Profile.Size = new System.Drawing.Size(283, 72);
            this.btn_Profile.TabIndex = 1;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 581);
            this.Controls.Add(this.panel_DesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1200, 620);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel_DesktopPane.ResumeLayout(false);
            this.panel_DesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_Games;
        private System.Windows.Forms.Button btn_PointCard;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_DesktopPane;
        private System.Windows.Forms.Button btn_closeChildForm;
        private System.Windows.Forms.Label lbl_ann;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_expand;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_RP;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_PA;
        private System.Windows.Forms.Button btn_RPStaff;
    }
}

