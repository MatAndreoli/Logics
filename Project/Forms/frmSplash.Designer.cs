
namespace APP.Forms
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TimerEntrar = new System.Windows.Forms.Timer(this.components);
            this.TimerSaida = new System.Windows.Forms.Timer(this.components);
            this.Guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblWelcome.Location = new System.Drawing.Point(365, 9);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(167, 39);
            this.LblWelcome.TabIndex = 1;
            this.LblWelcome.Text = "Welcome";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblUsername.Location = new System.Drawing.Point(315, 279);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(174, 39);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "Username";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerEntrar
            // 
            this.TimerEntrar.Interval = 30;
            this.TimerEntrar.Tick += new System.EventHandler(this.TimerEntrar_Tick);
            // 
            // TimerSaida
            // 
            this.TimerSaida.Interval = 30;
            this.TimerSaida.Tick += new System.EventHandler(this.TimerSaida_Tick);
            // 
            // Guna2ProgressBar1
            // 
            this.Guna2ProgressBar1.BorderRadius = 15;
            this.Guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.Guna2ProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ProgressBar1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Guna2ProgressBar1.Location = new System.Drawing.Point(102, 333);
            this.Guna2ProgressBar1.Name = "Guna2ProgressBar1";
            this.Guna2ProgressBar1.ProgressColor = System.Drawing.Color.Cyan;
            this.Guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.Fuchsia;
            this.Guna2ProgressBar1.ShadowDecoration.Parent = this.Guna2ProgressBar1;
            this.Guna2ProgressBar1.ShowPercentage = true;
            this.Guna2ProgressBar1.Size = new System.Drawing.Size(689, 24);
            this.Guna2ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Guna2ProgressBar1.TabIndex = 4;
            this.Guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Guna2ProgressBar1.Value = 100;
            // 
            // Guna2PictureBox2
            // 
            this.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox2.Image")));
            this.Guna2PictureBox2.ImageRotate = 0F;
            this.Guna2PictureBox2.Location = new System.Drawing.Point(341, 128);
            this.Guna2PictureBox2.Name = "Guna2PictureBox2";
            this.Guna2PictureBox2.ShadowDecoration.Parent = this.Guna2PictureBox2;
            this.Guna2PictureBox2.Size = new System.Drawing.Size(200, 190);
            this.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox2.TabIndex = 9;
            this.Guna2PictureBox2.TabStop = false;
            // 
            // Guna2PictureBox1
            // 
            this.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Guna2PictureBox1.Image")));
            this.Guna2PictureBox1.ImageRotate = 0F;
            this.Guna2PictureBox1.Location = new System.Drawing.Point(389, 93);
            this.Guna2PictureBox1.Name = "Guna2PictureBox1";
            this.Guna2PictureBox1.ShadowDecoration.Parent = this.Guna2PictureBox1;
            this.Guna2PictureBox1.Size = new System.Drawing.Size(100, 90);
            this.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Guna2PictureBox1.TabIndex = 10;
            this.Guna2PictureBox1.TabStop = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(899, 517);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.Guna2PictureBox1);
            this.Controls.Add(this.Guna2PictureBox2);
            this.Controls.Add(this.Guna2ProgressBar1);
            this.Controls.Add(this.LblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplash";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Timer TimerEntrar;
        private System.Windows.Forms.Timer TimerSaida;
        private Guna.UI2.WinForms.Guna2ProgressBar Guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
    }
}