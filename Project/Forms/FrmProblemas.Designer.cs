
namespace TCC.Forms
{
    partial class FrmProblemas
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
            this.LblPergunta = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnR1 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnR2 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnR3 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnR4 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // LblPergunta
            // 
            this.LblPergunta.AutoSize = false;
            this.LblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.LblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPergunta.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPergunta.Location = new System.Drawing.Point(12, 12);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(620, 156);
            this.LblPergunta.TabIndex = 0;
            this.LblPergunta.Text = "Cinco homens cavam uma vala de 5 metros em cinco\r\nhoras. Quantos cavadores serão " +
    "necessários para cavar\r\numa vala de 100 metros em 100 horas?\r\n\r\n";
            this.LblPergunta.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnR1
            // 
            this.BtnR1.BackColor = System.Drawing.Color.Transparent;
            this.BtnR1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnR1.BorderRadius = 12;
            this.BtnR1.BorderThickness = 2;
            this.BtnR1.CheckedState.Parent = this.BtnR1;
            this.BtnR1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnR1.CustomImages.Parent = this.BtnR1;
            this.BtnR1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnR1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnR1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnR1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnR1.DisabledState.Parent = this.BtnR1;
            this.BtnR1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnR1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnR1.ForeColor = System.Drawing.Color.White;
            this.BtnR1.HoverState.Parent = this.BtnR1;
            this.BtnR1.Location = new System.Drawing.Point(131, 254);
            this.BtnR1.Name = "BtnR1";
            this.BtnR1.ShadowDecoration.Parent = this.BtnR1;
            this.BtnR1.Size = new System.Drawing.Size(132, 36);
            this.BtnR1.TabIndex = 21;
            this.BtnR1.Tag = "1";
            this.BtnR1.Text = "????";
            this.BtnR1.MouseEnter += new System.EventHandler(this.MudarCor);
            this.BtnR1.MouseLeave += new System.EventHandler(this.TirarFill);
            // 
            // BtnR2
            // 
            this.BtnR2.BackColor = System.Drawing.Color.Transparent;
            this.BtnR2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnR2.BorderRadius = 12;
            this.BtnR2.BorderThickness = 2;
            this.BtnR2.CheckedState.Parent = this.BtnR2;
            this.BtnR2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnR2.CustomImages.Parent = this.BtnR2;
            this.BtnR2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnR2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnR2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnR2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnR2.DisabledState.Parent = this.BtnR2;
            this.BtnR2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnR2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnR2.ForeColor = System.Drawing.Color.White;
            this.BtnR2.HoverState.Parent = this.BtnR2;
            this.BtnR2.Location = new System.Drawing.Point(393, 254);
            this.BtnR2.Name = "BtnR2";
            this.BtnR2.ShadowDecoration.Parent = this.BtnR2;
            this.BtnR2.Size = new System.Drawing.Size(132, 36);
            this.BtnR2.TabIndex = 22;
            this.BtnR2.Tag = "2";
            this.BtnR2.Text = "????";
            this.BtnR2.MouseEnter += new System.EventHandler(this.MudarCor);
            this.BtnR2.MouseLeave += new System.EventHandler(this.TirarFill);
            // 
            // BtnR3
            // 
            this.BtnR3.BackColor = System.Drawing.Color.Transparent;
            this.BtnR3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnR3.BorderRadius = 12;
            this.BtnR3.BorderThickness = 2;
            this.BtnR3.CheckedState.Parent = this.BtnR3;
            this.BtnR3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnR3.CustomImages.Parent = this.BtnR3;
            this.BtnR3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnR3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnR3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnR3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnR3.DisabledState.Parent = this.BtnR3;
            this.BtnR3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnR3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnR3.ForeColor = System.Drawing.Color.White;
            this.BtnR3.HoverState.Parent = this.BtnR3;
            this.BtnR3.Location = new System.Drawing.Point(131, 358);
            this.BtnR3.Name = "BtnR3";
            this.BtnR3.ShadowDecoration.Parent = this.BtnR3;
            this.BtnR3.Size = new System.Drawing.Size(132, 36);
            this.BtnR3.TabIndex = 23;
            this.BtnR3.Tag = "3";
            this.BtnR3.Text = "????";
            this.BtnR3.MouseEnter += new System.EventHandler(this.MudarCor);
            this.BtnR3.MouseLeave += new System.EventHandler(this.TirarFill);
            // 
            // BtnR4
            // 
            this.BtnR4.BackColor = System.Drawing.Color.Transparent;
            this.BtnR4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnR4.BorderRadius = 12;
            this.BtnR4.BorderThickness = 2;
            this.BtnR4.CheckedState.Parent = this.BtnR4;
            this.BtnR4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnR4.CustomImages.Parent = this.BtnR4;
            this.BtnR4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnR4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnR4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnR4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnR4.DisabledState.Parent = this.BtnR4;
            this.BtnR4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.BtnR4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnR4.ForeColor = System.Drawing.Color.White;
            this.BtnR4.HoverState.Parent = this.BtnR4;
            this.BtnR4.Location = new System.Drawing.Point(393, 358);
            this.BtnR4.Name = "BtnR4";
            this.BtnR4.ShadowDecoration.Parent = this.BtnR4;
            this.BtnR4.Size = new System.Drawing.Size(132, 36);
            this.BtnR4.TabIndex = 24;
            this.BtnR4.Tag = "4";
            this.BtnR4.Text = "????";
            this.BtnR4.MouseEnter += new System.EventHandler(this.MudarCor);
            this.BtnR4.MouseLeave += new System.EventHandler(this.TirarFill);
            // 
            // FrmProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(662, 456);
            this.Controls.Add(this.BtnR4);
            this.Controls.Add(this.BtnR3);
            this.Controls.Add(this.BtnR2);
            this.Controls.Add(this.BtnR1);
            this.Controls.Add(this.LblPergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProblemas";
            this.Text = "Problemas Lógicas";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblPergunta;
        private Guna.UI2.WinForms.Guna2Button BtnR1;
        private Guna.UI2.WinForms.Guna2Button BtnR2;
        private Guna.UI2.WinForms.Guna2Button BtnR3;
        private Guna.UI2.WinForms.Guna2Button BtnR4;
    }
}