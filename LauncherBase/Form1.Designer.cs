namespace LauncherBase
{
    partial class Form_Main
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
            this.Panel_BG = new System.Windows.Forms.Panel();
            this.Panel_SBar = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Label();
            this.Btn_Minimize = new System.Windows.Forms.Label();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Panel_BG.SuspendLayout();
            this.Panel_SBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_BG
            // 
            this.Panel_BG.BackColor = System.Drawing.Color.Transparent;
            this.Panel_BG.Controls.Add(this.Btn_Connect);
            this.Panel_BG.Controls.Add(this.Panel_SBar);
            this.Panel_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_BG.Location = new System.Drawing.Point(0, 0);
            this.Panel_BG.Name = "Panel_BG";
            this.Panel_BG.Size = new System.Drawing.Size(800, 450);
            this.Panel_BG.TabIndex = 0;
            // 
            // Panel_SBar
            // 
            this.Panel_SBar.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_SBar.Controls.Add(this.Btn_Minimize);
            this.Panel_SBar.Controls.Add(this.Btn_Exit);
            this.Panel_SBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_SBar.Name = "Panel_SBar";
            this.Panel_SBar.Size = new System.Drawing.Size(800, 34);
            this.Panel_SBar.TabIndex = 0;
            this.Panel_SBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_SBar_MouseDown);
            this.Panel_SBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_SBar_MouseMove);
            this.Panel_SBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_SBar_MouseUp);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoSize = true;
            this.Btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.Font = new System.Drawing.Font("Skranji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Location = new System.Drawing.Point(760, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(28, 29);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.Text = "X";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.AutoSize = true;
            this.Btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimize.Font = new System.Drawing.Font("Skranji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Minimize.ForeColor = System.Drawing.Color.Black;
            this.Btn_Minimize.Location = new System.Drawing.Point(721, 3);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(22, 29);
            this.Btn_Minimize.TabIndex = 1;
            this.Btn_Minimize.Text = "-";
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Connect.BackColor = System.Drawing.Color.Lime;
            this.Btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Connect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Connect.FlatAppearance.BorderSize = 3;
            this.Btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Connect.ForeColor = System.Drawing.Color.Black;
            this.Btn_Connect.Location = new System.Drawing.Point(270, 232);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(279, 61);
            this.Btn_Connect.TabIndex = 1;
            this.Btn_Connect.Text = "CONNECT ";
            this.Btn_Connect.UseVisualStyleBackColor = false;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_BG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LauncherBase";
            this.Panel_BG.ResumeLayout(false);
            this.Panel_SBar.ResumeLayout(false);
            this.Panel_SBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_BG;
        private System.Windows.Forms.Panel Panel_SBar;
        private System.Windows.Forms.Label Btn_Exit;
        private System.Windows.Forms.Label Btn_Minimize;
        private System.Windows.Forms.Button Btn_Connect;
    }
}

