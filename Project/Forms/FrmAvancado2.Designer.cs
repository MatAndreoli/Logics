
namespace TCC.Forms
{
    partial class FrmAvancado2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvancado2));
            this.PnlOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblMultiExp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnExpre = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDivi = new Guna.UI2.WinForms.Guna2Button();
            this.PnlGame = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnStart = new Guna.UI2.WinForms.Guna2Button();
            this.BtnChecar = new Guna.UI2.WinForms.Guna2Button();
            this.LblN1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PrgPontos = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.TbResposta = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.PnlOptions.SuspendLayout();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlOptions
            // 
            this.PnlOptions.BorderRadius = 6;
            this.PnlOptions.BorderThickness = 2;
            this.PnlOptions.Controls.Add(this.guna2HtmlLabel3);
            this.PnlOptions.Controls.Add(this.guna2HtmlLabel1);
            this.PnlOptions.Controls.Add(this.guna2HtmlLabel2);
            this.PnlOptions.Controls.Add(this.LblMultiExp);
            this.PnlOptions.Controls.Add(this.BtnExpre);
            this.PnlOptions.Controls.Add(this.BtnDivi);
            this.Transition.SetDecoration(this.PnlOptions, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PnlOptions.Location = new System.Drawing.Point(21, 12);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.ShadowDecoration.Parent = this.PnlOptions;
            this.PnlOptions.Size = new System.Drawing.Size(611, 432);
            this.PnlOptions.TabIndex = 20;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(395, 153);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(74, 23);
            this.guna2HtmlLabel3.TabIndex = 24;
            this.guna2HtmlLabel3.Text = "Exemplo:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(115, 182);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(128, 23);
            this.guna2HtmlLabel1.TabIndex = 23;
            this.guna2HtmlLabel1.Text = "Divisor de 2 à 10";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel2.IsSelectionEnabled = false;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(388, 182);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(92, 23);
            this.guna2HtmlLabel2.TabIndex = 22;
            this.guna2HtmlLabel2.Text = "3 + 5 + 3 * 9";
            // 
            // LblMultiExp
            // 
            this.LblMultiExp.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.LblMultiExp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LblMultiExp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMultiExp.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblMultiExp.IsSelectionEnabled = false;
            this.LblMultiExp.Location = new System.Drawing.Point(98, 153);
            this.LblMultiExp.Name = "LblMultiExp";
            this.LblMultiExp.Size = new System.Drawing.Size(163, 23);
            this.LblMultiExp.TabIndex = 21;
            this.LblMultiExp.Text = "Dividendo de 2 à 100";
            // 
            // BtnExpre
            // 
            this.BtnExpre.BackColor = System.Drawing.Color.Transparent;
            this.BtnExpre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnExpre.BorderRadius = 14;
            this.BtnExpre.BorderThickness = 3;
            this.BtnExpre.CheckedState.Parent = this.BtnExpre;
            this.BtnExpre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExpre.CustomImages.Parent = this.BtnExpre;
            this.Transition.SetDecoration(this.BtnExpre, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnExpre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExpre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExpre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExpre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExpre.DisabledState.Parent = this.BtnExpre;
            this.BtnExpre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnExpre.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpre.ForeColor = System.Drawing.Color.White;
            this.BtnExpre.HoverState.Parent = this.BtnExpre;
            this.BtnExpre.Location = new System.Drawing.Point(329, 211);
            this.BtnExpre.Name = "BtnExpre";
            this.BtnExpre.ShadowDecoration.Parent = this.BtnExpre;
            this.BtnExpre.Size = new System.Drawing.Size(206, 36);
            this.BtnExpre.TabIndex = 19;
            this.BtnExpre.Text = "Expressão Simples";
            this.BtnExpre.Click += new System.EventHandler(this.BtnExpre_Click);
            this.BtnExpre.MouseEnter += new System.EventHandler(this.BtnExpre_MouseEnter);
            this.BtnExpre.MouseLeave += new System.EventHandler(this.BtnExpre_MouseLeave);
            // 
            // BtnDivi
            // 
            this.BtnDivi.BackColor = System.Drawing.Color.Transparent;
            this.BtnDivi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnDivi.BorderRadius = 14;
            this.BtnDivi.BorderThickness = 3;
            this.BtnDivi.CheckedState.Parent = this.BtnDivi;
            this.BtnDivi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDivi.CustomImages.Parent = this.BtnDivi;
            this.Transition.SetDecoration(this.BtnDivi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnDivi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDivi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDivi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDivi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDivi.DisabledState.Parent = this.BtnDivi;
            this.BtnDivi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnDivi.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivi.ForeColor = System.Drawing.Color.White;
            this.BtnDivi.HoverState.Parent = this.BtnDivi;
            this.BtnDivi.Location = new System.Drawing.Point(96, 211);
            this.BtnDivi.Name = "BtnDivi";
            this.BtnDivi.ShadowDecoration.Parent = this.BtnDivi;
            this.BtnDivi.Size = new System.Drawing.Size(166, 36);
            this.BtnDivi.TabIndex = 18;
            this.BtnDivi.Text = "Divisão";
            this.BtnDivi.Click += new System.EventHandler(this.BtnDivi_Click);
            this.BtnDivi.MouseEnter += new System.EventHandler(this.BtnDivi_MouseEnter);
            this.BtnDivi.MouseLeave += new System.EventHandler(this.BtnDivi_MouseLeave);
            // 
            // PnlGame
            // 
            this.PnlGame.BorderRadius = 6;
            this.PnlGame.BorderThickness = 2;
            this.PnlGame.Controls.Add(this.guna2PictureBox1);
            this.PnlGame.Controls.Add(this.BtnStart);
            this.PnlGame.Controls.Add(this.BtnChecar);
            this.PnlGame.Controls.Add(this.LblN1);
            this.PnlGame.Controls.Add(this.PrgPontos);
            this.PnlGame.Controls.Add(this.TbResposta);
            this.PnlGame.Controls.Add(this.LblTime);
            this.Transition.SetDecoration(this.PnlGame, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PnlGame.Location = new System.Drawing.Point(21, 12);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.ShadowDecoration.Parent = this.PnlGame;
            this.PnlGame.Size = new System.Drawing.Size(611, 432);
            this.PnlGame.TabIndex = 20;
            this.PnlGame.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.Transition.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::TCC.Properties.Resources.Back;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(31, 29);
            this.guna2PictureBox1.TabIndex = 21;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnStart.BorderRadius = 14;
            this.BtnStart.BorderThickness = 3;
            this.BtnStart.CheckedState.Parent = this.BtnStart;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.CustomImages.Parent = this.BtnStart;
            this.Transition.SetDecoration(this.BtnStart, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStart.DisabledState.Parent = this.BtnStart;
            this.BtnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnStart.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.HoverState.Parent = this.BtnStart;
            this.BtnStart.Location = new System.Drawing.Point(334, 272);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.ShadowDecoration.Parent = this.BtnStart;
            this.BtnStart.Size = new System.Drawing.Size(132, 36);
            this.BtnStart.TabIndex = 17;
            this.BtnStart.Text = "Começar";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.BtnStart.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.BtnStart.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // BtnChecar
            // 
            this.BtnChecar.BackColor = System.Drawing.Color.Transparent;
            this.BtnChecar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnChecar.BorderRadius = 14;
            this.BtnChecar.BorderThickness = 3;
            this.BtnChecar.CheckedState.Parent = this.BtnChecar;
            this.BtnChecar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChecar.CustomImages.Parent = this.BtnChecar;
            this.Transition.SetDecoration(this.BtnChecar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BtnChecar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnChecar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnChecar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnChecar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnChecar.DisabledState.Parent = this.BtnChecar;
            this.BtnChecar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnChecar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChecar.ForeColor = System.Drawing.Color.White;
            this.BtnChecar.HoverState.Parent = this.BtnChecar;
            this.BtnChecar.Location = new System.Drawing.Point(135, 272);
            this.BtnChecar.Name = "BtnChecar";
            this.BtnChecar.ShadowDecoration.Parent = this.BtnChecar;
            this.BtnChecar.Size = new System.Drawing.Size(132, 36);
            this.BtnChecar.TabIndex = 16;
            this.BtnChecar.Text = "Checar";
            this.BtnChecar.Click += new System.EventHandler(this.BtnChecar_Click);
            this.BtnChecar.MouseEnter += new System.EventHandler(this.BtnChecar_MouseEnter);
            this.BtnChecar.MouseLeave += new System.EventHandler(this.BtnChecar_MouseLeave);
            // 
            // LblN1
            // 
            this.LblN1.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.LblN1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LblN1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN1.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblN1.IsSelectionEnabled = false;
            this.LblN1.Location = new System.Drawing.Point(214, 65);
            this.LblN1.Name = "LblN1";
            this.LblN1.Size = new System.Drawing.Size(72, 56);
            this.LblN1.TabIndex = 7;
            this.LblN1.Text = "000";
            // 
            // PrgPontos
            // 
            this.PrgPontos.BorderRadius = 15;
            this.Transition.SetDecoration(this.PrgPontos, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PrgPontos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.PrgPontos.ForeColor = System.Drawing.Color.Gainsboro;
            this.PrgPontos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.PrgPontos.Location = new System.Drawing.Point(13, 113);
            this.PrgPontos.Maximum = 10;
            this.PrgPontos.Name = "PrgPontos";
            this.PrgPontos.ProgressColor = System.Drawing.Color.Cyan;
            this.PrgPontos.ProgressColor2 = System.Drawing.Color.Fuchsia;
            this.PrgPontos.ShadowDecoration.Parent = this.PrgPontos;
            this.PrgPontos.ShowPercentage = true;
            this.PrgPontos.Size = new System.Drawing.Size(25, 267);
            this.PrgPontos.TabIndex = 15;
            this.PrgPontos.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.PrgPontos.Value = 5;
            // 
            // TbResposta
            // 
            this.TbResposta.BorderRadius = 14;
            this.TbResposta.BorderThickness = 3;
            this.TbResposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.TbResposta, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TbResposta.DefaultText = "";
            this.TbResposta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbResposta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbResposta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbResposta.DisabledState.Parent = this.TbResposta;
            this.TbResposta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbResposta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbResposta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbResposta.FocusedState.Parent = this.TbResposta;
            this.TbResposta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TbResposta.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbResposta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbResposta.HoverState.Parent = this.TbResposta;
            this.TbResposta.Location = new System.Drawing.Point(214, 182);
            this.TbResposta.Margin = new System.Windows.Forms.Padding(5);
            this.TbResposta.Name = "TbResposta";
            this.TbResposta.PasswordChar = '\0';
            this.TbResposta.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbResposta.PlaceholderText = "Resposta";
            this.TbResposta.SelectedText = "";
            this.TbResposta.ShadowDecoration.Parent = this.TbResposta;
            this.TbResposta.Size = new System.Drawing.Size(177, 27);
            this.TbResposta.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TbResposta.TabIndex = 6;
            this.TbResposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbResposta_KeyDown);
            // 
            // LblTime
            // 
            this.LblTime.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.LblTime, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LblTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTime.IsSelectionEnabled = false;
            this.LblTime.Location = new System.Drawing.Point(470, 14);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(66, 47);
            this.LblTime.TabIndex = 11;
            this.LblTime.Text = "0:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Transition
            // 
            this.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.Transition.Cursor = null;
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
            this.Transition.DefaultAnimation = animation1;
            // 
            // FrmAvancado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(662, 456);
            this.Controls.Add(this.PnlOptions);
            this.Controls.Add(this.PnlGame);
            this.Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAvancado2";
            this.Text = "Avançado 2";
            this.Load += new System.EventHandler(this.FrmAvancado2_Load);
            this.PnlOptions.ResumeLayout(false);
            this.PnlOptions.PerformLayout();
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlOptions;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblMultiExp;
        private Guna.UI2.WinForms.Guna2Button BtnExpre;
        private Guna.UI2.WinForms.Guna2Button BtnDivi;
        private Guna.UI2.WinForms.Guna2Panel PnlGame;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnStart;
        private Guna.UI2.WinForms.Guna2Button BtnChecar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblN1;
        private Guna.UI2.WinForms.Guna2VProgressBar PrgPontos;
        private Guna.UI2.WinForms.Guna2TextBox TbResposta;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTime;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Transition Transition;
    }
}