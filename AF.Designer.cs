namespace Al_Nada_Manager
{
    partial class AF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            SuspendLayout();
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = "Al Nada Manager";
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = null;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog1.Text = null;
            // 
            // AF
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(130, 202, 255);
            ClientSize = new Size(800, 450);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AF";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}
