namespace OpenPasswordManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.youtube = new System.Windows.Forms.ToolStripMenuItem();
            this.facebook = new System.Windows.Forms.ToolStripMenuItem();
            this.google = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youtube,
            this.facebook,
            this.google,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // youtube
            // 
            this.youtube.Image = ((System.Drawing.Image)(resources.GetObject("youtube.Image")));
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(180, 22);
            this.youtube.Text = "Youtube";
            this.youtube.Click += new System.EventHandler(this.youtube_Click);
            // 
            // facebook
            // 
            this.facebook.Image = ((System.Drawing.Image)(resources.GetObject("facebook.Image")));
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(180, 22);
            this.facebook.Text = "Facebook";
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // google
            // 
            this.google.Image = ((System.Drawing.Image)(resources.GetObject("google.Image")));
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(180, 22);
            this.google.Text = "Google";
            this.google.Click += new System.EventHandler(this.google_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 234);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem youtube;
        private System.Windows.Forms.ToolStripMenuItem facebook;
        private System.Windows.Forms.ToolStripMenuItem google;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

