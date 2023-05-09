using System.Media;

namespace SpaceInvaders
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSkins = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStart.BackgroundImage")));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Rockwell Extra Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStart.Location = new System.Drawing.Point(235, 132);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(194, 56);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.MouseEnter += new System.EventHandler(this.button_mouseenter);
            this.buttonStart.MouseLeave += new System.EventHandler(this.button_mouseleave);
            // 
            // buttonSkins
            // 
            this.buttonSkins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSkins.BackgroundImage")));
            this.buttonSkins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSkins.Font = new System.Drawing.Font("Rockwell Extra Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkins.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSkins.Location = new System.Drawing.Point(235, 204);
            this.buttonSkins.Name = "buttonSkins";
            this.buttonSkins.Size = new System.Drawing.Size(194, 56);
            this.buttonSkins.TabIndex = 1;
            this.buttonSkins.Text = "SKINS";
            this.buttonSkins.UseVisualStyleBackColor = true;
            this.buttonSkins.Click += new System.EventHandler(this.buttonSkins_Click);
            this.buttonSkins.MouseEnter += new System.EventHandler(this.button_mouseenter);
            this.buttonSkins.MouseLeave += new System.EventHandler(this.button_mouseleave);
            // 
            // buttonShop
            // 
            this.buttonShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonShop.BackgroundImage")));
            this.buttonShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShop.Font = new System.Drawing.Font("Rockwell Extra Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShop.Location = new System.Drawing.Point(245, 276);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(177, 56);
            this.buttonShop.TabIndex = 2;
            this.buttonShop.Text = "SHOP";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            this.buttonShop.MouseEnter += new System.EventHandler(this.button_mouseenter);
            this.buttonShop.MouseLeave += new System.EventHandler(this.button_mouseleave);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuit.BackgroundImage")));
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuit.Font = new System.Drawing.Font("Rockwell Extra Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.White;
            this.buttonQuit.Location = new System.Drawing.Point(262, 348);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(141, 56);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            this.buttonQuit.MouseEnter += new System.EventHandler(this.button_mouseenter);
            this.buttonQuit.MouseLeave += new System.EventHandler(this.button_mouseleave);
            //
            // Soundplayer
            //

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonSkins);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSkins;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonQuit;
        private SoundPlayer soundmaker = new SoundPlayer();
    }
}

