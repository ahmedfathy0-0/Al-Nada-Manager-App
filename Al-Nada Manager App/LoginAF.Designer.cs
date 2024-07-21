namespace Al_Nada_Manager_App
{
    partial class LoginAF
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAF));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            Usertxt = new Guna.UI2.WinForms.Guna2TextBox();
            Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            Passtxt = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            guna2vSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(98, 102);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(203, 207);
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(489, 102);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // Usertxt
            // 
            Usertxt.AutoRoundedCorners = true;
            Usertxt.BorderRadius = 21;
            Usertxt.CustomizableEdges = customizableEdges3;
            Usertxt.DefaultText = "";
            Usertxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Usertxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Usertxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Usertxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Usertxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Usertxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Usertxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Usertxt.Location = new Point(476, 125);
            Usertxt.Name = "Usertxt";
            Usertxt.PasswordChar = '\0';
            Usertxt.PlaceholderText = "";
            Usertxt.SelectedText = "";
            Usertxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Usertxt.Size = new Size(250, 45);
            Usertxt.TabIndex = 0;
            // 
            // Loginbtn
            // 
            Loginbtn.Animated = true;
            Loginbtn.AutoRoundedCorners = true;
            Loginbtn.BorderRadius = 27;
            Loginbtn.CustomizableEdges = customizableEdges5;
            Loginbtn.DisabledState.BorderColor = Color.DarkGray;
            Loginbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Loginbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Loginbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Loginbtn.FillColor = Color.MidnightBlue;
            Loginbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Loginbtn.ForeColor = Color.White;
            Loginbtn.Location = new Point(487, 292);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Loginbtn.Size = new Size(225, 56);
            Loginbtn.TabIndex = 2;
            Loginbtn.Text = "Login";
            Loginbtn.Click += Loginbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Magneto", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(466, 51);
            label2.Name = "label2";
            label2.Size = new Size(234, 32);
            label2.TabIndex = 5;
            label2.Text = "Welcome Back";
            label2.Click += label2_Click;
            // 
            // Passtxt
            // 
            Passtxt.AutoRoundedCorners = true;
            Passtxt.BorderRadius = 21;
            Passtxt.CustomizableEdges = customizableEdges7;
            Passtxt.DefaultText = "";
            Passtxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Passtxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Passtxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Passtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Passtxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Passtxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Passtxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Passtxt.Location = new Point(476, 216);
            Passtxt.Name = "Passtxt";
            Passtxt.PasswordChar = '●';
            Passtxt.PlaceholderText = "";
            Passtxt.SelectedText = "";
            Passtxt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Passtxt.Size = new Size(250, 45);
            Passtxt.TabIndex = 1;
            Passtxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(489, 193);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // guna2vSeparator1
            // 
            guna2vSeparator1.Location = new Point(334, 51);
            guna2vSeparator1.Name = "guna2vSeparator1";
            guna2vSeparator1.Size = new Size(37, 297);
            guna2vSeparator1.TabIndex = 6;
            // 
            // LoginAF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2vSeparator1);
            Controls.Add(Passtxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Loginbtn);
            Controls.Add(Usertxt);
            Controls.Add(label1);
            Controls.Add(guna2PictureBox1);
            Name = "LoginAF";
            Text = "LoginAF";
            Load += LoginAF_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Usertxt;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Passtxt;
        private Label label3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2vSeparator1;
    }
}