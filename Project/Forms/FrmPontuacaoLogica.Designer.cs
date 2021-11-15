
namespace TCC.Forms
{
    partial class FrmPontuacaoLogica
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblPoints = new System.Windows.Forms.Label();
            this.CbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pontuação:";
            // 
            // LblPoints
            // 
            this.LblPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPoints.AutoSize = true;
            this.LblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoints.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblPoints.Location = new System.Drawing.Point(57, 86);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(20, 24);
            this.LblPoints.TabIndex = 17;
            this.LblPoints.Text = "0";
            // 
            // CbClose
            // 
            this.CbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbClose.BorderRadius = 5;
            this.CbClose.FillColor = System.Drawing.Color.Transparent;
            this.CbClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.CbClose.HoverState.Parent = this.CbClose;
            this.CbClose.IconColor = System.Drawing.Color.White;
            this.CbClose.Location = new System.Drawing.Point(119, 0);
            this.CbClose.Name = "CbClose";
            this.CbClose.ShadowDecoration.Parent = this.CbClose;
            this.CbClose.Size = new System.Drawing.Size(30, 30);
            this.CbClose.TabIndex = 18;
            this.CbClose.Click += new System.EventHandler(this.CbClose_Click);
            // 
            // FrmPontuacaoLogica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(150, 150);
            this.Controls.Add(this.CbClose);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPontuacaoLogica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPontuacaoLogica";
            this.Load += new System.EventHandler(this.FrmPontuacaoLogica_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPontuacaoLogica_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPoints;
        private Guna.UI2.WinForms.Guna2ControlBox CbClose;
    }
}