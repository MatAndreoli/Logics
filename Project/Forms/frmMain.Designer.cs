
namespace APP
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.IbtnLogout = new FontAwesome.Sharp.IconButton();
            this.IbtnConfig = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.IbtnMultiplicacao = new FontAwesome.Sharp.IconButton();
            this.IbtnSubtracao = new FontAwesome.Sharp.IconButton();
            this.IBtnAdicao = new FontAwesome.Sharp.IconButton();
            this.PnLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnUpper = new Guna.UI2.WinForms.Guna2Panel();
            this.CbMini = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.IpbPage = new FontAwesome.Sharp.IconPictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnPai = new Guna.UI2.WinForms.Guna2Panel();
            this.LblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblHour = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PbMarca = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TimerHora = new System.Windows.Forms.Timer(this.components);
            this.TimerEntrar = new System.Windows.Forms.Timer(this.components);
            this.ElipseFrmMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PnMenu.SuspendLayout();
            this.PnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).BeginInit();
            this.PnUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpbPage)).BeginInit();
            this.PnPai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnMenu
            // 
            this.PnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PnMenu.Controls.Add(this.IbtnLogout);
            this.PnMenu.Controls.Add(this.IbtnConfig);
            this.PnMenu.Controls.Add(this.iconButton5);
            this.PnMenu.Controls.Add(this.iconButton4);
            this.PnMenu.Controls.Add(this.IbtnMultiplicacao);
            this.PnMenu.Controls.Add(this.IbtnSubtracao);
            this.PnMenu.Controls.Add(this.IBtnAdicao);
            this.PnMenu.Controls.Add(this.PnLogo);
            this.PnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenu.Location = new System.Drawing.Point(0, 0);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.ShadowDecoration.Parent = this.PnMenu;
            this.PnMenu.Size = new System.Drawing.Size(209, 518);
            this.PnMenu.TabIndex = 6;
            // 
            // IbtnLogout
            // 
            this.IbtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.IbtnLogout.FlatAppearance.BorderSize = 0;
            this.IbtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.IbtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.IbtnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.IbtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnLogout.IconSize = 32;
            this.IbtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnLogout.Location = new System.Drawing.Point(0, 457);
            this.IbtnLogout.Name = "IbtnLogout";
            this.IbtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IbtnLogout.Size = new System.Drawing.Size(209, 60);
            this.IbtnLogout.TabIndex = 14;
            this.IbtnLogout.Text = "Logout";
            this.IbtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnLogout.UseVisualStyleBackColor = true;
            this.IbtnLogout.Click += new System.EventHandler(this.IbtnLogout_Click);
            // 
            // IbtnConfig
            // 
            this.IbtnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.IbtnConfig.FlatAppearance.BorderSize = 0;
            this.IbtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.IbtnConfig.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.IbtnConfig.IconColor = System.Drawing.Color.Gainsboro;
            this.IbtnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnConfig.IconSize = 32;
            this.IbtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnConfig.Location = new System.Drawing.Point(0, 397);
            this.IbtnConfig.Name = "IbtnConfig";
            this.IbtnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IbtnConfig.Size = new System.Drawing.Size(209, 60);
            this.IbtnConfig.TabIndex = 13;
            this.IbtnConfig.Text = "Configurações";
            this.IbtnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnConfig.UseVisualStyleBackColor = true;
            this.IbtnConfig.Click += new System.EventHandler(this.IbtnConfig_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 337);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(209, 60);
            this.iconButton5.TabIndex = 12;
            this.iconButton5.Text = "iconButton5";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 277);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(209, 60);
            this.iconButton4.TabIndex = 11;
            this.iconButton4.Text = "iconButton4";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // IbtnMultiplicacao
            // 
            this.IbtnMultiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnMultiplicacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.IbtnMultiplicacao.FlatAppearance.BorderSize = 0;
            this.IbtnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnMultiplicacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnMultiplicacao.ForeColor = System.Drawing.Color.Gainsboro;
            this.IbtnMultiplicacao.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.IbtnMultiplicacao.IconColor = System.Drawing.Color.Gainsboro;
            this.IbtnMultiplicacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnMultiplicacao.IconSize = 32;
            this.IbtnMultiplicacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnMultiplicacao.Location = new System.Drawing.Point(0, 217);
            this.IbtnMultiplicacao.Name = "IbtnMultiplicacao";
            this.IbtnMultiplicacao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IbtnMultiplicacao.Size = new System.Drawing.Size(209, 60);
            this.IbtnMultiplicacao.TabIndex = 10;
            this.IbtnMultiplicacao.Text = "Multiplicação";
            this.IbtnMultiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnMultiplicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnMultiplicacao.UseVisualStyleBackColor = true;
            this.IbtnMultiplicacao.Click += new System.EventHandler(this.IbtnMultiplicacao_Click);
            // 
            // IbtnSubtracao
            // 
            this.IbtnSubtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IbtnSubtracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.IbtnSubtracao.FlatAppearance.BorderSize = 0;
            this.IbtnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbtnSubtracao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnSubtracao.ForeColor = System.Drawing.Color.Gainsboro;
            this.IbtnSubtracao.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IbtnSubtracao.IconColor = System.Drawing.Color.Gainsboro;
            this.IbtnSubtracao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSubtracao.IconSize = 32;
            this.IbtnSubtracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnSubtracao.Location = new System.Drawing.Point(0, 157);
            this.IbtnSubtracao.Name = "IbtnSubtracao";
            this.IbtnSubtracao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IbtnSubtracao.Size = new System.Drawing.Size(209, 60);
            this.IbtnSubtracao.TabIndex = 9;
            this.IbtnSubtracao.Text = "Subtração";
            this.IbtnSubtracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IbtnSubtracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnSubtracao.UseVisualStyleBackColor = true;
            this.IbtnSubtracao.Click += new System.EventHandler(this.IbtnSubtracao_Click);
            // 
            // IBtnAdicao
            // 
            this.IBtnAdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IBtnAdicao.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnAdicao.FlatAppearance.BorderSize = 0;
            this.IBtnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnAdicao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnAdicao.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnAdicao.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IBtnAdicao.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnAdicao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnAdicao.IconSize = 32;
            this.IBtnAdicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnAdicao.Location = new System.Drawing.Point(0, 97);
            this.IBtnAdicao.Name = "IBtnAdicao";
            this.IBtnAdicao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnAdicao.Size = new System.Drawing.Size(209, 60);
            this.IBtnAdicao.TabIndex = 8;
            this.IBtnAdicao.Text = "Adição";
            this.IBtnAdicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnAdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnAdicao.UseVisualStyleBackColor = true;
            this.IBtnAdicao.Click += new System.EventHandler(this.IBtnAdicao_Click);
            // 
            // PnLogo
            // 
            this.PnLogo.Controls.Add(this.Guna2PictureBox2);
            this.PnLogo.Controls.Add(this.Guna2PictureBox1);
            this.PnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLogo.Location = new System.Drawing.Point(0, 0);
            this.PnLogo.Name = "PnLogo";
            this.PnLogo.ShadowDecoration.Parent = this.PnLogo;
            this.PnLogo.Size = new System.Drawing.Size(209, 97);
            this.PnLogo.TabIndex = 7;
            // 
            // Guna2PictureBox2
            // 
            this.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2PictureBox2.Image = global::TCC.Properties.Resources.Logics_Logotipo;
            this.Guna2PictureBox2.ImageRotate = 0F;
            this.Guna2PictureBox2.Location = new System.Drawing.Point(104, 0);
            this.Guna2PictureBox2.Name = "Guna2PictureBox2";
            this.Guna2PictureBox2.ShadowDecoration.Parent = this.Guna2PictureBox2;
            this.Guna2PictureBox2.Size = new System.Drawing.Size(100, 90);
            this.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox2.TabIndex = 8;
            this.Guna2PictureBox2.TabStop = false;
            this.Guna2PictureBox2.Click += new System.EventHandler(this.Guna2PictureBox2_Click);
            // 
            // Guna2PictureBox1
            // 
            this.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2PictureBox1.Image = global::TCC.Properties.Resources.GradiLogics_Logotipo;
            this.Guna2PictureBox1.ImageRotate = 0F;
            this.Guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.Guna2PictureBox1.Name = "Guna2PictureBox1";
            this.Guna2PictureBox1.ShadowDecoration.Parent = this.Guna2PictureBox1;
            this.Guna2PictureBox1.Size = new System.Drawing.Size(100, 90);
            this.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox1.TabIndex = 7;
            this.Guna2PictureBox1.TabStop = false;
            this.Guna2PictureBox1.Click += new System.EventHandler(this.Guna2PictureBox1_Click);
            // 
            // PnUpper
            // 
            this.PnUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PnUpper.Controls.Add(this.CbMini);
            this.PnUpper.Controls.Add(this.CbClose);
            this.PnUpper.Controls.Add(this.IpbPage);
            this.PnUpper.Controls.Add(this.LblTitle);
            this.PnUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnUpper.Location = new System.Drawing.Point(209, 0);
            this.PnUpper.Name = "PnUpper";
            this.PnUpper.ShadowDecoration.Parent = this.PnUpper;
            this.PnUpper.Size = new System.Drawing.Size(662, 62);
            this.PnUpper.TabIndex = 7;
            this.PnUpper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnUpper_MouseDown);
            // 
            // CbMini
            // 
            this.CbMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbMini.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.CbMini.FillColor = System.Drawing.Color.Transparent;
            this.CbMini.HoverState.Parent = this.CbMini;
            this.CbMini.IconColor = System.Drawing.Color.White;
            this.CbMini.Location = new System.Drawing.Point(601, 0);
            this.CbMini.Name = "CbMini";
            this.CbMini.ShadowDecoration.Parent = this.CbMini;
            this.CbMini.Size = new System.Drawing.Size(30, 30);
            this.CbMini.TabIndex = 7;
            // 
            // CbClose
            // 
            this.CbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbClose.BorderRadius = 5;
            this.CbClose.FillColor = System.Drawing.Color.Transparent;
            this.CbClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.CbClose.HoverState.Parent = this.CbClose;
            this.CbClose.IconColor = System.Drawing.Color.White;
            this.CbClose.Location = new System.Drawing.Point(631, 0);
            this.CbClose.Name = "CbClose";
            this.CbClose.ShadowDecoration.Parent = this.CbClose;
            this.CbClose.Size = new System.Drawing.Size(30, 30);
            this.CbClose.TabIndex = 6;
            this.CbClose.Click += new System.EventHandler(this.CbClose_Click);
            // 
            // IpbPage
            // 
            this.IpbPage.BackColor = System.Drawing.Color.Transparent;
            this.IpbPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.IpbPage.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IpbPage.IconColor = System.Drawing.Color.Gainsboro;
            this.IpbPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IpbPage.IconSize = 24;
            this.IpbPage.Location = new System.Drawing.Point(6, 19);
            this.IpbPage.Name = "IpbPage";
            this.IpbPage.Size = new System.Drawing.Size(24, 24);
            this.IpbPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IpbPage.TabIndex = 5;
            this.IpbPage.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTitle.Location = new System.Drawing.Point(32, 17);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(56, 21);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Home";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnPai
            // 
            this.PnPai.Controls.Add(this.LblDate);
            this.PnPai.Controls.Add(this.LblHour);
            this.PnPai.Controls.Add(this.PbMarca);
            this.PnPai.Controls.Add(this.PbLogo);
            this.PnPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPai.Location = new System.Drawing.Point(209, 62);
            this.PnPai.Name = "PnPai";
            this.PnPai.ShadowDecoration.Parent = this.PnPai;
            this.PnPai.Size = new System.Drawing.Size(662, 456);
            this.PnPai.TabIndex = 8;
            // 
            // LblDate
            // 
            this.LblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Enabled = false;
            this.LblDate.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblDate.Location = new System.Drawing.Point(103, 237);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(452, 38);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "sexta-feira, 23 de junho de 2021";
            // 
            // LblHour
            // 
            this.LblHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblHour.BackColor = System.Drawing.Color.Transparent;
            this.LblHour.Enabled = false;
            this.LblHour.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHour.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblHour.Location = new System.Drawing.Point(254, 192);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(113, 38);
            this.LblHour.TabIndex = 11;
            this.LblHour.Text = "00:00:00";
            // 
            // PbMarca
            // 
            this.PbMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbMarca.BackColor = System.Drawing.Color.Transparent;
            this.PbMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.PbMarca.Image = global::TCC.Properties.Resources.Logics;
            this.PbMarca.ImageRotate = 0F;
            this.PbMarca.Location = new System.Drawing.Point(313, 96);
            this.PbMarca.Name = "PbMarca";
            this.PbMarca.ShadowDecoration.Parent = this.PbMarca;
            this.PbMarca.Size = new System.Drawing.Size(100, 90);
            this.PbMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMarca.TabIndex = 10;
            this.PbMarca.TabStop = false;
            // 
            // PbLogo
            // 
            this.PbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PbLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.PbLogo.Image = global::TCC.Properties.Resources.Logotipo;
            this.PbLogo.ImageRotate = 0F;
            this.PbLogo.Location = new System.Drawing.Point(209, 96);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.ShadowDecoration.Parent = this.PbLogo;
            this.PbLogo.Size = new System.Drawing.Size(100, 90);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 9;
            this.PbLogo.TabStop = false;
            // 
            // TimerHora
            // 
            this.TimerHora.Interval = 1000;
            this.TimerHora.Tick += new System.EventHandler(this.TimerHora_Tick);
            // 
            // TimerEntrar
            // 
            this.TimerEntrar.Interval = 30;
            this.TimerEntrar.Tick += new System.EventHandler(this.TimerEntrar_Tick);
            // 
            // ElipseFrmMain
            // 
            this.ElipseFrmMain.BorderRadius = 12;
            this.ElipseFrmMain.TargetControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(871, 518);
            this.Controls.Add(this.PnPai);
            this.Controls.Add(this.PnUpper);
            this.Controls.Add(this.PnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnMenu.ResumeLayout(false);
            this.PnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).EndInit();
            this.PnUpper.ResumeLayout(false);
            this.PnUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpbPage)).EndInit();
            this.PnPai.ResumeLayout(false);
            this.PnPai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel PnMenu;
        private Guna.UI2.WinForms.Guna2Panel PnLogo;
        private Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        private FontAwesome.Sharp.IconButton IBtnAdicao;
        private Guna.UI2.WinForms.Guna2Panel PnUpper;
        private System.Windows.Forms.Label LblTitle;
        private FontAwesome.Sharp.IconButton IbtnLogout;
        private FontAwesome.Sharp.IconButton IbtnConfig;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton IbtnMultiplicacao;
        private FontAwesome.Sharp.IconButton IbtnSubtracao;
        private Guna.UI2.WinForms.Guna2Panel PnPai;
        private FontAwesome.Sharp.IconPictureBox IpbPage;
        private Guna.UI2.WinForms.Guna2PictureBox PbMarca;
        private Guna.UI2.WinForms.Guna2PictureBox PbLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHour;
        private System.Windows.Forms.Timer TimerHora;
        private System.Windows.Forms.Timer TimerEntrar;
        private Guna.UI2.WinForms.Guna2ControlBox CbClose;
        private Guna.UI2.WinForms.Guna2ControlBox CbMini;
        private Guna.UI2.WinForms.Guna2Elipse ElipseFrmMain;
    }
}

