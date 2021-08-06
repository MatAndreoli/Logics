
namespace TCC.Forms
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.PbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PbMarca = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnCad = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.TbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.Anima = new Guna.UI2.WinForms.Guna2Transition();
            this.PnlCad = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.TbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbIdade = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbSobre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbConfPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.PbExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TimerEntrar = new System.Windows.Forms.Timer(this.components);
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMarca)).BeginInit();
            this.PnlLogin.SuspendLayout();
            this.PnlCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.PnlLogo.Controls.Add(this.PbLogo);
            this.PnlLogo.Controls.Add(this.PbMarca);
            this.Anima.SetDecoration(this.PnlLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PnlLogo.Location = new System.Drawing.Point(80, 27);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.ShadowDecoration.Parent = this.PnlLogo;
            this.PnlLogo.Size = new System.Drawing.Size(281, 450);
            this.PnlLogo.TabIndex = 0;
            // 
            // PbLogo
            // 
            this.PbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PbLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Anima.SetDecoration(this.PbLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.ImageRotate = 0F;
            this.PbLogo.Location = new System.Drawing.Point(64, 80);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.ShadowDecoration.Parent = this.PbLogo;
            this.PbLogo.Size = new System.Drawing.Size(150, 140);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 11;
            this.PbLogo.TabStop = false;
            // 
            // PbMarca
            // 
            this.PbMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbMarca.BackColor = System.Drawing.Color.Transparent;
            this.PbMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.Anima.SetDecoration(this.PbMarca, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PbMarca.Image = ((System.Drawing.Image)(resources.GetObject("PbMarca.Image")));
            this.PbMarca.ImageRotate = 0F;
            this.PbMarca.Location = new System.Drawing.Point(36, 166);
            this.PbMarca.Name = "PbMarca";
            this.PbMarca.ShadowDecoration.Parent = this.PbMarca;
            this.PbMarca.Size = new System.Drawing.Size(200, 190);
            this.PbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMarca.TabIndex = 12;
            this.PbMarca.TabStop = false;
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.PnlLogin.Controls.Add(this.BtnCad);
            this.PnlLogin.Controls.Add(this.BtnLogin);
            this.PnlLogin.Controls.Add(this.TbPassword);
            this.PnlLogin.Controls.Add(this.TbLogin);
            this.Anima.SetDecoration(this.PnlLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PnlLogin.Location = new System.Drawing.Point(360, 27);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.ShadowDecoration.Parent = this.PnlLogin;
            this.PnlLogin.Size = new System.Drawing.Size(281, 450);
            this.PnlLogin.TabIndex = 1;
            // 
            // BtnCad
            // 
            this.BtnCad.BackColor = System.Drawing.Color.Transparent;
            this.BtnCad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnCad.BorderRadius = 14;
            this.BtnCad.BorderThickness = 3;
            this.BtnCad.CheckedState.Parent = this.BtnCad;
            this.BtnCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCad.CustomImages.Parent = this.BtnCad;
            this.Anima.SetDecoration(this.BtnCad, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnCad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCad.DisabledState.Parent = this.BtnCad;
            this.BtnCad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnCad.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCad.ForeColor = System.Drawing.Color.White;
            this.BtnCad.HoverState.Parent = this.BtnCad;
            this.BtnCad.Location = new System.Drawing.Point(42, 336);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.ShadowDecoration.Parent = this.BtnCad;
            this.BtnCad.Size = new System.Drawing.Size(170, 36);
            this.BtnCad.TabIndex = 3;
            this.BtnCad.Text = "Criar conta";
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            this.BtnCad.MouseEnter += new System.EventHandler(this.BtnCad_MouseEnter);
            this.BtnCad.MouseLeave += new System.EventHandler(this.BtnCad_MouseLeave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnLogin.BorderRadius = 14;
            this.BtnLogin.BorderThickness = 3;
            this.BtnLogin.CheckedState.Parent = this.BtnLogin;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.CustomImages.Parent = this.BtnLogin;
            this.Anima.SetDecoration(this.BtnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.DisabledState.Parent = this.BtnLogin;
            this.BtnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.HoverState.Parent = this.BtnLogin;
            this.BtnLogin.Location = new System.Drawing.Point(58, 276);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.ShadowDecoration.Parent = this.BtnLogin;
            this.BtnLogin.Size = new System.Drawing.Size(132, 36);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // TbPassword
            // 
            this.TbPassword.BorderRadius = 14;
            this.TbPassword.BorderThickness = 3;
            this.TbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbPassword.DefaultText = "";
            this.TbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPassword.DisabledState.Parent = this.TbPassword;
            this.TbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPassword.FocusedState.Parent = this.TbPassword;
            this.TbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPassword.HoverState.Parent = this.TbPassword;
            this.TbPassword.Location = new System.Drawing.Point(33, 138);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '\0';
            this.TbPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbPassword.PlaceholderText = "Senha";
            this.TbPassword.SelectedText = "";
            this.TbPassword.ShadowDecoration.Parent = this.TbPassword;
            this.TbPassword.Size = new System.Drawing.Size(200, 36);
            this.TbPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbPassword.TabIndex = 1;
            this.TbPassword.UseSystemPasswordChar = true;
            this.TbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            this.TbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbPass_KeyDown);
            // 
            // TbLogin
            // 
            this.TbLogin.BorderRadius = 14;
            this.TbLogin.BorderThickness = 3;
            this.TbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbLogin.DefaultText = "";
            this.TbLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbLogin.DisabledState.Parent = this.TbLogin;
            this.TbLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbLogin.FocusedState.Parent = this.TbLogin;
            this.TbLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbLogin.HoverState.Parent = this.TbLogin;
            this.TbLogin.Location = new System.Drawing.Point(33, 72);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.PasswordChar = '\0';
            this.TbLogin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbLogin.PlaceholderText = "Nome de Usuário";
            this.TbLogin.SelectedText = "";
            this.TbLogin.ShadowDecoration.Parent = this.TbLogin;
            this.TbLogin.Size = new System.Drawing.Size(200, 36);
            this.TbLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbLogin.TabIndex = 0;
            this.TbLogin.TextChanged += new System.EventHandler(this.TbLogin_TextChanged);
            // 
            // Anima
            // 
            this.Anima.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.Anima.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Anima.DefaultAnimation = animation1;
            // 
            // PnlCad
            // 
            this.PnlCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.PnlCad.Controls.Add(this.BtnVoltar);
            this.PnlCad.Controls.Add(this.TbEmail);
            this.PnlCad.Controls.Add(this.TbIdade);
            this.PnlCad.Controls.Add(this.TbSobre);
            this.PnlCad.Controls.Add(this.TbNome);
            this.PnlCad.Controls.Add(this.TbConfPass);
            this.PnlCad.Controls.Add(this.TbPass);
            this.PnlCad.Controls.Add(this.TbUser);
            this.PnlCad.Controls.Add(this.BtnCadastrar);
            this.Anima.SetDecoration(this.PnlCad, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PnlCad.Location = new System.Drawing.Point(360, 27);
            this.PnlCad.Name = "PnlCad";
            this.PnlCad.ShadowDecoration.Parent = this.PnlCad;
            this.PnlCad.Size = new System.Drawing.Size(281, 450);
            this.PnlCad.TabIndex = 1;
            this.PnlCad.Visible = false;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnVoltar.BorderRadius = 14;
            this.BtnVoltar.BorderThickness = 3;
            this.BtnVoltar.CheckedState.Parent = this.BtnVoltar;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.CustomImages.Parent = this.BtnVoltar;
            this.Anima.SetDecoration(this.BtnVoltar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVoltar.DisabledState.Parent = this.BtnVoltar;
            this.BtnVoltar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnVoltar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.White;
            this.BtnVoltar.HoverState.Parent = this.BtnVoltar;
            this.BtnVoltar.Location = new System.Drawing.Point(61, 385);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.ShadowDecoration.Parent = this.BtnVoltar;
            this.BtnVoltar.Size = new System.Drawing.Size(132, 36);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            this.BtnVoltar.MouseEnter += new System.EventHandler(this.BtnVoltar_MouseEnter);
            this.BtnVoltar.MouseLeave += new System.EventHandler(this.BtnVoltar_MouseLeave);
            // 
            // TbEmail
            // 
            this.TbEmail.BorderRadius = 14;
            this.TbEmail.BorderThickness = 3;
            this.TbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbEmail.DefaultText = "";
            this.TbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbEmail.DisabledState.Parent = this.TbEmail;
            this.TbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbEmail.FocusedState.Parent = this.TbEmail;
            this.TbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbEmail.HoverState.Parent = this.TbEmail;
            this.TbEmail.Location = new System.Drawing.Point(28, 264);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.PasswordChar = '\0';
            this.TbEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbEmail.PlaceholderText = "E-mail";
            this.TbEmail.SelectedText = "";
            this.TbEmail.ShadowDecoration.Parent = this.TbEmail;
            this.TbEmail.Size = new System.Drawing.Size(200, 36);
            this.TbEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbEmail.TabIndex = 11;
            this.TbEmail.TextChanged += new System.EventHandler(this.TbEmail_TextChanged);
            // 
            // TbIdade
            // 
            this.TbIdade.BorderRadius = 14;
            this.TbIdade.BorderThickness = 3;
            this.TbIdade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbIdade, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbIdade.DefaultText = "";
            this.TbIdade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbIdade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbIdade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbIdade.DisabledState.Parent = this.TbIdade;
            this.TbIdade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbIdade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbIdade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbIdade.FocusedState.Parent = this.TbIdade;
            this.TbIdade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbIdade.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbIdade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbIdade.HoverState.Parent = this.TbIdade;
            this.TbIdade.Location = new System.Drawing.Point(28, 222);
            this.TbIdade.Name = "TbIdade";
            this.TbIdade.PasswordChar = '\0';
            this.TbIdade.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbIdade.PlaceholderText = "Idade";
            this.TbIdade.SelectedText = "";
            this.TbIdade.ShadowDecoration.Parent = this.TbIdade;
            this.TbIdade.Size = new System.Drawing.Size(200, 36);
            this.TbIdade.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbIdade.TabIndex = 10;
            this.TbIdade.TextChanged += new System.EventHandler(this.TbIdade_TextChanged);
            // 
            // TbSobre
            // 
            this.TbSobre.BorderRadius = 14;
            this.TbSobre.BorderThickness = 3;
            this.TbSobre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbSobre, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbSobre.DefaultText = "";
            this.TbSobre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSobre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSobre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSobre.DisabledState.Parent = this.TbSobre;
            this.TbSobre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSobre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbSobre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSobre.FocusedState.Parent = this.TbSobre;
            this.TbSobre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSobre.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbSobre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSobre.HoverState.Parent = this.TbSobre;
            this.TbSobre.Location = new System.Drawing.Point(28, 180);
            this.TbSobre.Name = "TbSobre";
            this.TbSobre.PasswordChar = '\0';
            this.TbSobre.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbSobre.PlaceholderText = "Sobrenome";
            this.TbSobre.SelectedText = "";
            this.TbSobre.ShadowDecoration.Parent = this.TbSobre;
            this.TbSobre.Size = new System.Drawing.Size(200, 36);
            this.TbSobre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbSobre.TabIndex = 9;
            this.TbSobre.TextChanged += new System.EventHandler(this.TbSobre_TextChanged);
            // 
            // TbNome
            // 
            this.TbNome.BorderRadius = 14;
            this.TbNome.BorderThickness = 3;
            this.TbNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbNome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbNome.DefaultText = "";
            this.TbNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbNome.DisabledState.Parent = this.TbNome;
            this.TbNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbNome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbNome.FocusedState.Parent = this.TbNome;
            this.TbNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbNome.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbNome.HoverState.Parent = this.TbNome;
            this.TbNome.Location = new System.Drawing.Point(28, 138);
            this.TbNome.Name = "TbNome";
            this.TbNome.PasswordChar = '\0';
            this.TbNome.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbNome.PlaceholderText = "Primeiro Nome";
            this.TbNome.SelectedText = "";
            this.TbNome.ShadowDecoration.Parent = this.TbNome;
            this.TbNome.Size = new System.Drawing.Size(200, 36);
            this.TbNome.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbNome.TabIndex = 8;
            this.TbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // TbConfPass
            // 
            this.TbConfPass.BorderRadius = 14;
            this.TbConfPass.BorderThickness = 3;
            this.TbConfPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbConfPass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbConfPass.DefaultText = "";
            this.TbConfPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbConfPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbConfPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbConfPass.DisabledState.Parent = this.TbConfPass;
            this.TbConfPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbConfPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbConfPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbConfPass.FocusedState.Parent = this.TbConfPass;
            this.TbConfPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbConfPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbConfPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbConfPass.HoverState.Parent = this.TbConfPass;
            this.TbConfPass.IconRightSize = new System.Drawing.Size(16, 16);
            this.TbConfPass.Location = new System.Drawing.Point(28, 96);
            this.TbConfPass.Name = "TbConfPass";
            this.TbConfPass.PasswordChar = '\0';
            this.TbConfPass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbConfPass.PlaceholderText = "Confirmação Senha";
            this.TbConfPass.SelectedText = "";
            this.TbConfPass.ShadowDecoration.Parent = this.TbConfPass;
            this.TbConfPass.Size = new System.Drawing.Size(200, 36);
            this.TbConfPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbConfPass.TabIndex = 7;
            this.TbConfPass.UseSystemPasswordChar = true;
            this.TbConfPass.TextChanged += new System.EventHandler(this.TbConfPass_TextChanged);
            // 
            // TbPass
            // 
            this.TbPass.BorderRadius = 14;
            this.TbPass.BorderThickness = 3;
            this.TbPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbPass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbPass.DefaultText = "";
            this.TbPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPass.DisabledState.Parent = this.TbPass;
            this.TbPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPass.FocusedState.Parent = this.TbPass;
            this.TbPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPass.HoverState.Parent = this.TbPass;
            this.TbPass.Location = new System.Drawing.Point(28, 54);
            this.TbPass.Name = "TbPass";
            this.TbPass.PasswordChar = '\0';
            this.TbPass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbPass.PlaceholderText = "Senha";
            this.TbPass.SelectedText = "";
            this.TbPass.ShadowDecoration.Parent = this.TbPass;
            this.TbPass.Size = new System.Drawing.Size(200, 36);
            this.TbPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbPass.TabIndex = 6;
            this.TbPass.UseSystemPasswordChar = true;
            this.TbPass.TextChanged += new System.EventHandler(this.TbPass_TextChanged);
            // 
            // TbUser
            // 
            this.TbUser.BorderRadius = 14;
            this.TbUser.BorderThickness = 3;
            this.TbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Anima.SetDecoration(this.TbUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbUser.DefaultText = "";
            this.TbUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUser.DisabledState.Parent = this.TbUser;
            this.TbUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUser.FocusedState.Parent = this.TbUser;
            this.TbUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUser.HoverState.Parent = this.TbUser;
            this.TbUser.Location = new System.Drawing.Point(28, 12);
            this.TbUser.Name = "TbUser";
            this.TbUser.PasswordChar = '\0';
            this.TbUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbUser.PlaceholderText = "Nome de Usuário";
            this.TbUser.SelectedText = "";
            this.TbUser.ShadowDecoration.Parent = this.TbUser;
            this.TbUser.Size = new System.Drawing.Size(200, 36);
            this.TbUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbUser.TabIndex = 5;
            this.TbUser.TextChanged += new System.EventHandler(this.TbUser_TextChanged);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCadastrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnCadastrar.BorderRadius = 14;
            this.BtnCadastrar.BorderThickness = 3;
            this.BtnCadastrar.CheckedState.Parent = this.BtnCadastrar;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.CustomImages.Parent = this.BtnCadastrar;
            this.Anima.SetDecoration(this.BtnCadastrar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCadastrar.DisabledState.Parent = this.BtnCadastrar;
            this.BtnCadastrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnCadastrar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.HoverState.Parent = this.BtnCadastrar;
            this.BtnCadastrar.Location = new System.Drawing.Point(61, 327);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.ShadowDecoration.Parent = this.BtnCadastrar;
            this.BtnCadastrar.Size = new System.Drawing.Size(132, 36);
            this.BtnCadastrar.TabIndex = 4;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            this.BtnCadastrar.MouseEnter += new System.EventHandler(this.BtnCadastrar_MouseEnter);
            this.BtnCadastrar.MouseLeave += new System.EventHandler(this.BtnCadastrar_MouseLeave);
            // 
            // PbExit
            // 
            this.PbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Anima.SetDecoration(this.PbExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PbExit.FillColor = System.Drawing.Color.Transparent;
            this.PbExit.Image = ((System.Drawing.Image)(resources.GetObject("PbExit.Image")));
            this.PbExit.ImageRotate = 0F;
            this.PbExit.Location = new System.Drawing.Point(719, 1);
            this.PbExit.Name = "PbExit";
            this.PbExit.ShadowDecoration.Parent = this.PbExit;
            this.PbExit.Size = new System.Drawing.Size(16, 16);
            this.PbExit.TabIndex = 2;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // TimerEntrar
            // 
            this.TimerEntrar.Interval = 30;
            this.TimerEntrar.Tick += new System.EventHandler(this.TimerEntrar_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(738, 500);
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.PnlCad);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.PnlLogo);
            this.Anima.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMarca)).EndInit();
            this.PnlLogin.ResumeLayout(false);
            this.PnlCad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlLogo;
        private Guna.UI2.WinForms.Guna2Panel PnlLogin;
        private Guna.UI2.WinForms.Guna2TextBox TbPassword;
        private Guna.UI2.WinForms.Guna2TextBox TbLogin;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2Button BtnCad;
        private Guna.UI2.WinForms.Guna2Panel PnlCad;
        private Guna.UI2.WinForms.Guna2Transition Anima;
        private Guna.UI2.WinForms.Guna2Button BtnCadastrar;
        private Guna.UI2.WinForms.Guna2TextBox TbUser;
        private Guna.UI2.WinForms.Guna2TextBox TbEmail;
        private Guna.UI2.WinForms.Guna2TextBox TbIdade;
        private Guna.UI2.WinForms.Guna2TextBox TbSobre;
        private Guna.UI2.WinForms.Guna2TextBox TbNome;
        private Guna.UI2.WinForms.Guna2TextBox TbConfPass;
        private Guna.UI2.WinForms.Guna2TextBox TbPass;
        private Guna.UI2.WinForms.Guna2PictureBox PbMarca;
        private Guna.UI2.WinForms.Guna2PictureBox PbLogo;
        private Guna.UI2.WinForms.Guna2PictureBox PbExit;
        private Guna.UI2.WinForms.Guna2Button BtnVoltar;
        private System.Windows.Forms.Timer TimerEntrar;
    }
}