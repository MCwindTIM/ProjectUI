namespace UI.Child_Form
{
    partial class FormPointCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_CPC = new System.Windows.Forms.Button();
            this.btn_SPC = new System.Windows.Forms.Button();
            this.lblStaffTools = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point Card ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_CPC
            // 
            this.btn_CPC.Location = new System.Drawing.Point(15, 139);
            this.btn_CPC.Name = "btn_CPC";
            this.btn_CPC.Size = new System.Drawing.Size(179, 23);
            this.btn_CPC.TabIndex = 3;
            this.btn_CPC.Text = "Create Point Card";
            this.btn_CPC.UseVisualStyleBackColor = true;
            this.btn_CPC.Visible = false;
            // 
            // btn_SPC
            // 
            this.btn_SPC.Location = new System.Drawing.Point(15, 181);
            this.btn_SPC.Name = "btn_SPC";
            this.btn_SPC.Size = new System.Drawing.Size(179, 23);
            this.btn_SPC.TabIndex = 4;
            this.btn_SPC.Text = "Suspend Point Card";
            this.btn_SPC.UseVisualStyleBackColor = true;
            this.btn_SPC.Visible = false;
            // 
            // lblStaffTools
            // 
            this.lblStaffTools.AutoSize = true;
            this.lblStaffTools.Location = new System.Drawing.Point(13, 120);
            this.lblStaffTools.Name = "lblStaffTools";
            this.lblStaffTools.Size = new System.Drawing.Size(66, 13);
            this.lblStaffTools.TabIndex = 5;
            this.lblStaffTools.Text = "Staff tools";
            this.lblStaffTools.Visible = false;
            // 
            // FormPointCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStaffTools);
            this.Controls.Add(this.btn_SPC);
            this.Controls.Add(this.btn_CPC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormPointCard";
            this.Text = "Point Card";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_CPC;
        private System.Windows.Forms.Button btn_SPC;
        private System.Windows.Forms.Label lblStaffTools;
    }
}