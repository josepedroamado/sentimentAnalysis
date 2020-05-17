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
            this.btnReportsView = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnAlarmsView = new System.Windows.Forms.Button();
            this.btnPhrasesView = new System.Windows.Forms.Button();
            this.btnEntitiesView = new System.Windows.Forms.Button();
            this.btnSentimentView = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelMenu.Controls.Add(this.btnReportsView);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.btnAlarmsView);
            this.panelMenu.Controls.Add(this.btnPhrasesView);
            this.panelMenu.Controls.Add(this.btnEntitiesView);
            this.panelMenu.Controls.Add(this.btnSentimentView);
            this.panelMenu.Location = new System.Drawing.Point(-2, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(242, 869);
            this.panelMenu.TabIndex = 0;
            // 
            // btnReportsView
            // 
            this.btnReportsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReportsView.FlatAppearance.BorderSize = 0;
            this.btnReportsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportsView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsView.ForeColor = System.Drawing.Color.White;
            this.btnReportsView.Location = new System.Drawing.Point(26, 656);
            this.btnReportsView.Margin = new System.Windows.Forms.Padding(6);
            this.btnReportsView.Name = "btnReportsView";
            this.btnReportsView.Size = new System.Drawing.Size(186, 58);
            this.btnReportsView.TabIndex = 5;
            this.btnReportsView.Text = "Reportes";
            this.btnReportsView.UseVisualStyleBackColor = false;
            this.btnReportsView.Click += new System.EventHandler(this.BtnReportsView_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.Image = global::UserInterface.Properties.Resources.SentimentAnalysisLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(26, 23);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(186, 179);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogo_Click);
            // 
            // btnAlarmsView
            // 
            this.btnAlarmsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAlarmsView.FlatAppearance.BorderSize = 0;
            this.btnAlarmsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmsView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmsView.ForeColor = System.Drawing.Color.White;
            this.btnAlarmsView.Location = new System.Drawing.Point(26, 569);
            this.btnAlarmsView.Margin = new System.Windows.Forms.Padding(6);
            this.btnAlarmsView.Name = "btnAlarmsView";
            this.btnAlarmsView.Size = new System.Drawing.Size(186, 58);
            this.btnAlarmsView.TabIndex = 3;
            this.btnAlarmsView.Text = "Alarmas";
            this.btnAlarmsView.UseVisualStyleBackColor = false;
            this.btnAlarmsView.Click += new System.EventHandler(this.BtnAlarmsView_Click);
            // 
            // btnPhrasesView
            // 
            this.btnPhrasesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPhrasesView.FlatAppearance.BorderSize = 0;
            this.btnPhrasesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhrasesView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhrasesView.ForeColor = System.Drawing.Color.White;
            this.btnPhrasesView.Location = new System.Drawing.Point(26, 479);
            this.btnPhrasesView.Margin = new System.Windows.Forms.Padding(6);
            this.btnPhrasesView.Name = "btnPhrasesView";
            this.btnPhrasesView.Size = new System.Drawing.Size(186, 58);
            this.btnPhrasesView.TabIndex = 2;
            this.btnPhrasesView.Text = "Frases";
            this.btnPhrasesView.UseVisualStyleBackColor = false;
            this.btnPhrasesView.Click += new System.EventHandler(this.BtnPhrasesView_Click);
            // 
            // btnEntitiesView
            // 
            this.btnEntitiesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEntitiesView.FlatAppearance.BorderSize = 0;
            this.btnEntitiesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntitiesView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntitiesView.ForeColor = System.Drawing.Color.White;
            this.btnEntitiesView.Location = new System.Drawing.Point(26, 390);
            this.btnEntitiesView.Margin = new System.Windows.Forms.Padding(6);
            this.btnEntitiesView.Name = "btnEntitiesView";
            this.btnEntitiesView.Size = new System.Drawing.Size(186, 58);
            this.btnEntitiesView.TabIndex = 1;
            this.btnEntitiesView.Text = "Entidades";
            this.btnEntitiesView.UseVisualStyleBackColor = false;
            this.btnEntitiesView.Click += new System.EventHandler(this.BtnEntitiesView_Click);
            // 
            // btnSentimentView
            // 
            this.btnSentimentView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSentimentView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSentimentView.FlatAppearance.BorderSize = 0;
            this.btnSentimentView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentimentView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSentimentView.ForeColor = System.Drawing.Color.White;
            this.btnSentimentView.Location = new System.Drawing.Point(26, 304);
            this.btnSentimentView.Margin = new System.Windows.Forms.Padding(6);
            this.btnSentimentView.Name = "btnSentimentView";
            this.btnSentimentView.Size = new System.Drawing.Size(186, 58);
            this.btnSentimentView.TabIndex = 0;
            this.btnSentimentView.Text = "Sentimientos";
            this.btnSentimentView.UseVisualStyleBackColor = false;
            this.btnSentimentView.Click += new System.EventHandler(this.BtnSentimentView_Click);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelView.Location = new System.Drawing.Point(252, 0);
            this.panelView.Margin = new System.Windows.Forms.Padding(6);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1348, 869);
            this.panelView.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Sentiment Analysis";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnSentimentView;
        private System.Windows.Forms.Button btnPhrasesView;
        private System.Windows.Forms.Button btnEntitiesView;
        private System.Windows.Forms.Button btnAlarmsView;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnReportsView;
    }
}

