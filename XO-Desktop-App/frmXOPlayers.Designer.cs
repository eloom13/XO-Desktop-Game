namespace XO_Desktop_App
{
    partial class frmXOPlayers
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnStart = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtIgrac1 = new Guna.UI2.WinForms.Guna2TextBox();
            txtIgrac2 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 146);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "1 player name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 243);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 3;
            label2.Text = "2 player name:";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnStart
            // 
            btnStart.BorderRadius = 20;
            btnStart.CustomizableEdges = customizableEdges5;
            btnStart.DisabledState.BorderColor = Color.DarkGray;
            btnStart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStart.FillColor = Color.Orange;
            btnStart.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(111, 377);
            btnStart.Name = "btnStart";
            btnStart.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnStart.Size = new Size(225, 56);
            btnStart.TabIndex = 5;
            btnStart.Text = "START";
            btnStart.Click += btnStart_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(44, 23);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(381, 61);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Player Information";
            // 
            // txtIgrac1
            // 
            txtIgrac1.CustomizableEdges = customizableEdges3;
            txtIgrac1.DefaultText = "";
            txtIgrac1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtIgrac1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtIgrac1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtIgrac1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtIgrac1.FocusedState.BorderColor = Color.Transparent;
            txtIgrac1.FocusedState.ForeColor = Color.Black;
            txtIgrac1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIgrac1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIgrac1.Location = new Point(44, 174);
            txtIgrac1.Name = "txtIgrac1";
            txtIgrac1.PasswordChar = '\0';
            txtIgrac1.PlaceholderForeColor = Color.Black;
            txtIgrac1.PlaceholderText = "";
            txtIgrac1.SelectedText = "";
            txtIgrac1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtIgrac1.Size = new Size(381, 36);
            txtIgrac1.TabIndex = 7;
            // 
            // txtIgrac2
            // 
            txtIgrac2.CustomizableEdges = customizableEdges1;
            txtIgrac2.DefaultText = "";
            txtIgrac2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtIgrac2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtIgrac2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtIgrac2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtIgrac2.FocusedState.BorderColor = Color.Transparent;
            txtIgrac2.FocusedState.ForeColor = Color.Black;
            txtIgrac2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIgrac2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtIgrac2.Location = new Point(44, 271);
            txtIgrac2.Name = "txtIgrac2";
            txtIgrac2.PasswordChar = '\0';
            txtIgrac2.PlaceholderForeColor = Color.Black;
            txtIgrac2.PlaceholderText = "";
            txtIgrac2.SelectedText = "";
            txtIgrac2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtIgrac2.Size = new Size(381, 36);
            txtIgrac2.TabIndex = 8;
            // 
            // frmXOPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 43, 62);
            ClientSize = new Size(459, 455);
            Controls.Add(txtIgrac2);
            Controls.Add(txtIgrac1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmXOPlayers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Players";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtIgrac1;
        private Guna.UI2.WinForms.Guna2TextBox txtIgrac2;
    }
}