namespace UserInterface
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAlarms = new System.Windows.Forms.Button();
            this.btnPhrases = new System.Windows.Forms.Button();
            this.btnEntities = new System.Windows.Forms.Button();
            this.btnSentimentMenu = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.btnAlarms);
            this.panelMenu.Controls.Add(this.btnPhrases);
            this.panelMenu.Controls.Add(this.btnEntities);
            this.panelMenu.Controls.Add(this.btnSentimentMenu);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(121, 452);
            this.panelMenu.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(13, 341);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(93, 30);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reportes";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnAlarms
            // 
            this.btnAlarms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAlarms.FlatAppearance.BorderSize = 0;
            this.btnAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarms.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarms.ForeColor = System.Drawing.Color.White;
            this.btnAlarms.Location = new System.Drawing.Point(13, 296);
            this.btnAlarms.Name = "btnAlarms";
            this.btnAlarms.Size = new System.Drawing.Size(93, 30);
            this.btnAlarms.TabIndex = 3;
            this.btnAlarms.Text = "Alarmas";
            this.btnAlarms.UseVisualStyleBackColor = false;
            this.btnAlarms.Click += new System.EventHandler(this.BtnAlarms_Click);
            // 
            // btnPhrases
            // 
            this.btnPhrases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPhrases.FlatAppearance.BorderSize = 0;
            this.btnPhrases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhrases.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhrases.ForeColor = System.Drawing.Color.White;
            this.btnPhrases.Location = new System.Drawing.Point(13, 249);
            this.btnPhrases.Name = "btnPhrases";
            this.btnPhrases.Size = new System.Drawing.Size(93, 30);
            this.btnPhrases.TabIndex = 2;
            this.btnPhrases.Text = "Frases";
            this.btnPhrases.UseVisualStyleBackColor = false;
            this.btnPhrases.Click += new System.EventHandler(this.BtnPhrases_Click);
            // 
            // btnEntities
            // 
            this.btnEntities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEntities.FlatAppearance.BorderSize = 0;
            this.btnEntities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntities.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntities.ForeColor = System.Drawing.Color.White;
            this.btnEntities.Location = new System.Drawing.Point(13, 203);
            this.btnEntities.Name = "btnEntities";
            this.btnEntities.Size = new System.Drawing.Size(93, 30);
            this.btnEntities.TabIndex = 1;
            this.btnEntities.Text = "Entidades";
            this.btnEntities.UseVisualStyleBackColor = false;
            this.btnEntities.Click += new System.EventHandler(this.BtnEntities_Click);
            // 
            // btnSentimentMenu
            // 
            this.btnSentimentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSentimentMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSentimentMenu.FlatAppearance.BorderSize = 0;
            this.btnSentimentMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentimentMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSentimentMenu.ForeColor = System.Drawing.Color.White;
            this.btnSentimentMenu.Location = new System.Drawing.Point(13, 158);
            this.btnSentimentMenu.Name = "btnSentimentMenu";
            this.btnSentimentMenu.Size = new System.Drawing.Size(93, 30);
            this.btnSentimentMenu.TabIndex = 0;
            this.btnSentimentMenu.Text = "Sentimientos";
            this.btnSentimentMenu.UseVisualStyleBackColor = false;
            this.btnSentimentMenu.Click += new System.EventHandler(this.BtnSentimentMenu_Click);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelView.Location = new System.Drawing.Point(126, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(674, 452);
            this.panelView.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.Image = global::UserInterface.Properties.Resources.SentimentAnalysisLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(93, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogo_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Sentiment Analysis";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnSentimentMenu;
        private System.Windows.Forms.Button btnPhrases;
        private System.Windows.Forms.Button btnEntities;
        private System.Windows.Forms.Button btnAlarms;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnReports;
    }
}

