
namespace TCC.Forms
{
    partial class FrmAdicao
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
            this.TbResposta = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblN1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnStart = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // TbResposta
            // 
            this.TbResposta.BorderRadius = 14;
            this.TbResposta.BorderThickness = 3;
            this.TbResposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbResposta.DefaultText = "";
            this.TbResposta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbResposta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbResposta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbResposta.DisabledState.Parent = this.TbResposta;
            this.TbResposta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbResposta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.TbResposta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbResposta.FocusedState.Parent = this.TbResposta;
            this.TbResposta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbResposta.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbResposta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbResposta.HoverState.Parent = this.TbResposta;
            this.TbResposta.Location = new System.Drawing.Point(269, 248);
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
            // 
            // LblN1
            // 
            this.LblN1.BackColor = System.Drawing.Color.Transparent;
            this.LblN1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN1.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblN1.Location = new System.Drawing.Point(291, 98);
            this.LblN1.Name = "LblN1";
            this.LblN1.Size = new System.Drawing.Size(21, 56);
            this.LblN1.TabIndex = 7;
            this.LblN1.Text = "?";
            // 
            // BtnCheck
            // 
            this.BtnCheck.CheckedState.Parent = this.BtnCheck;
            this.BtnCheck.CustomImages.Parent = this.BtnCheck;
            this.BtnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCheck.DisabledState.Parent = this.BtnCheck;
            this.BtnCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCheck.ForeColor = System.Drawing.Color.White;
            this.BtnCheck.HoverState.Parent = this.BtnCheck;
            this.BtnCheck.Location = new System.Drawing.Point(269, 335);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.ShadowDecoration.Parent = this.BtnCheck;
            this.BtnCheck.Size = new System.Drawing.Size(154, 43);
            this.BtnCheck.TabIndex = 10;
            this.BtnCheck.Text = "Checar";
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblTime
            // 
            this.LblTime.BackColor = System.Drawing.Color.Transparent;
            this.LblTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTime.Location = new System.Drawing.Point(56, 22);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(17, 47);
            this.LblTime.TabIndex = 11;
            this.LblTime.Text = "?";
            // 
            // BtnStart
            // 
            this.BtnStart.CheckedState.Parent = this.BtnStart;
            this.BtnStart.CustomImages.Parent = this.BtnStart;
            this.BtnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnStart.DisabledState.Parent = this.BtnStart;
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.HoverState.Parent = this.BtnStart;
            this.BtnStart.Location = new System.Drawing.Point(541, 22);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.ShadowDecoration.Parent = this.BtnStart;
            this.BtnStart.Size = new System.Drawing.Size(103, 27);
            this.BtnStart.TabIndex = 12;
            this.BtnStart.Text = "Começar";
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FrmAdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblN1);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TbResposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdicao";
            this.Text = "Adição";
            this.Load += new System.EventHandler(this.FrmAdicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TbResposta;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblN1;
        private Guna.UI2.WinForms.Guna2Button BtnCheck;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTime;
        private Guna.UI2.WinForms.Guna2Button BtnStart;
    }
}