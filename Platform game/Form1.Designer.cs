
namespace Platform_game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.ObjectUp = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.Object = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Object)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(680, 28);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(35, 13);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score";
            // 
            // ObjectUp
            // 
            this.ObjectUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ObjectUp.Location = new System.Drawing.Point(330, 238);
            this.ObjectUp.Name = "ObjectUp";
            this.ObjectUp.Size = new System.Drawing.Size(651, 23);
            this.ObjectUp.TabIndex = 4;
            this.ObjectUp.TabStop = false;
            this.ObjectUp.Tag = "platformUp";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Platform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Platform.BackgroundImage")));
            this.Platform.Image = ((System.Drawing.Image)(resources.GetObject("Platform.Image")));
            this.Platform.Location = new System.Drawing.Point(-477, 414);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(6000, 22);
            this.Platform.TabIndex = 0;
            this.Platform.TabStop = false;
            this.Platform.Tag = "platform";
            // 
            // Object
            // 
            this.Object.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Object.Location = new System.Drawing.Point(607, 377);
            this.Object.Name = "Object";
            this.Object.Size = new System.Drawing.Size(26, 42);
            this.Object.TabIndex = 3;
            this.Object.TabStop = false;
            this.Object.Tag = "platformFront";
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Red;
            this.Enemy.Image = global::Platform_game.Properties.Resources.img1;
            this.Enemy.Location = new System.Drawing.Point(1209, 369);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(70, 50);
            this.Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy.TabIndex = 5;
            this.Enemy.TabStop = false;
            this.Enemy.Tag = "Enemy";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.SystemColors.Highlight;
            this.Player.Location = new System.Drawing.Point(330, 344);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(37, 75);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1798, 631);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.ObjectUp);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Object);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Object)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
        public System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.Label txtScore;
        public System.Windows.Forms.PictureBox Object;
        private System.Windows.Forms.PictureBox ObjectUp;
        private System.Windows.Forms.PictureBox Enemy;
    }
}

