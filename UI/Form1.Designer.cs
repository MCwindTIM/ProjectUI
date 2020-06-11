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
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Games = new System.Windows.Forms.Button();
            this.btn_Cart = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_expand = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_closeChildForm = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_DesktopPane = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel_DesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_Setting);
            this.panelMenu.Controls.Add(this.btn_Games);
            this.panelMenu.Controls.Add(this.btn_Cart);
            this.panelMenu.Controls.Add(this.btn_Products);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(283, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Setting.Image")));
            this.btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.Location = new System.Drawing.Point(0, 509);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Setting.Size = new System.Drawing.Size(283, 72);
            this.btn_Setting.TabIndex = 6;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Games
            // 
            this.btn_Games.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Games.FlatAppearance.BorderSize = 0;
            this.btn_Games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Games.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Games.Image = ((System.Drawing.Image)(resources.GetObject("btn_Games.Image")));
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
            // btn_Cart
            // 
            this.btn_Cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cart.FlatAppearance.BorderSize = 0;
            this.btn_Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Cart.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cart.Image")));
            this.btn_Cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cart.Location = new System.Drawing.Point(0, 168);
            this.btn_Cart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cart.Name = "btn_Cart";
            this.btn_Cart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Cart.Size = new System.Drawing.Size(283, 72);
            this.btn_Cart.TabIndex = 2;
            this.btn_Cart.Text = "Cart";
            this.btn_Cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cart.UseVisualStyleBackColor = true;
            this.btn_Cart.Click += new System.EventHandler(this.btn_Cart_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Products.FlatAppearance.BorderSize = 0;
            this.btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Products.Image = ((System.Drawing.Image)(resources.GetObject("btn_Products.Image")));
            this.btn_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Products.Location = new System.Drawing.Point(0, 96);
            this.btn_Products.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_Products.Size = new System.Drawing.Size(283, 72);
            this.btn_Products.TabIndex = 1;
            this.btn_Products.Text = "Products";
            this.btn_Products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(283, 96);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(109, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MCwind";
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
            // btn_move
            // 
            this.btn_move.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_move.FlatAppearance.BorderSize = 0;
            this.btn_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move.Image = ((System.Drawing.Image)(resources.GetObject("btn_move.Image")));
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
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
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
            this.btn_expand.Image = ((System.Drawing.Image)(resources.GetObject("btn_expand.Image")));
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
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
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
            this.btn_closeChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeChildForm.Image")));
            this.btn_closeChildForm.Location = new System.Drawing.Point(0, 0);
            this.btn_closeChildForm.Name = "btn_closeChildForm";
            this.btn_closeChildForm.Size = new System.Drawing.Size(75, 96);
            this.btn_closeChildForm.TabIndex = 0;
            this.btn_closeChildForm.UseVisualStyleBackColor = true;
            this.btn_closeChildForm.Visible = false;
            this.btn_closeChildForm.Click += new System.EventHandler(this.btn_closeChildForm_Click);
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
            this.panel_DesktopPane.Controls.Add(this.label2);
            this.panel_DesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DesktopPane.Location = new System.Drawing.Point(283, 96);
            this.panel_DesktopPane.Name = "panel_DesktopPane";
            this.panel_DesktopPane.Size = new System.Drawing.Size(901, 485);
            this.panel_DesktopPane.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 111);
            this.label2.TabIndex = 0;
            this.label2.Text = "Test Home Page";
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
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Games;
        private System.Windows.Forms.Button btn_Cart;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_DesktopPane;
        private System.Windows.Forms.Button btn_closeChildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_expand;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_move;
    }
}

