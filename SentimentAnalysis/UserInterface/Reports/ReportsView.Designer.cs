namespace UserInterface
{
    partial class ReportsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReportsTitle = new System.Windows.Forms.Label();
            this.labelEntity = new System.Windows.Forms.Label();
            this.labelPhrase = new System.Windows.Forms.Label();
            this.labelSentimentType = new System.Windows.Forms.Label();
            this.textBoxSentimentType = new System.Windows.Forms.TextBox();
            this.comboBoxPhrase = new System.Windows.Forms.ComboBox();
            this.textBoxEntity = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReportsTitle
            // 
            this.labelReportsTitle.AutoSize = true;
            this.labelReportsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportsTitle.ForeColor = System.Drawing.Color.White;
            this.labelReportsTitle.Location = new System.Drawing.Point(119, 40);
            this.labelReportsTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReportsTitle.Name = "labelReportsTitle";
            this.labelReportsTitle.Size = new System.Drawing.Size(220, 31);
            this.labelReportsTitle.TabIndex = 9;
            this.labelReportsTitle.Text = "Reporte de Análisis";
            // 
            // labelEntity
            // 
            this.labelEntity.AutoSize = true;
            this.labelEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntity.ForeColor = System.Drawing.Color.White;
            this.labelEntity.Location = new System.Drawing.Point(119, 425);
            this.labelEntity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEntity.Name = "labelEntity";
            this.labelEntity.Size = new System.Drawing.Size(79, 28);
            this.labelEntity.TabIndex = 12;
            this.labelEntity.Text = "Entidad";
            // 
            // labelPhrase
            // 
            this.labelPhrase.AutoSize = true;
            this.labelPhrase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhrase.ForeColor = System.Drawing.Color.White;
            this.labelPhrase.Location = new System.Drawing.Point(119, 145);
            this.labelPhrase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhrase.Name = "labelPhrase";
            this.labelPhrase.Size = new System.Drawing.Size(57, 28);
            this.labelPhrase.TabIndex = 13;
            this.labelPhrase.Text = "Frase";
            // 
            // labelSentimentType
            // 
            this.labelSentimentType.AutoSize = true;
            this.labelSentimentType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentType.ForeColor = System.Drawing.Color.White;
            this.labelSentimentType.Location = new System.Drawing.Point(119, 565);
            this.labelSentimentType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSentimentType.Name = "labelSentimentType";
            this.labelSentimentType.Size = new System.Drawing.Size(189, 28);
            this.labelSentimentType.TabIndex = 14;
            this.labelSentimentType.Text = "Tipo de Sentimiento";
            // 
            // textBoxSentimentType
            // 
            this.textBoxSentimentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxSentimentType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSentimentType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentimentType.ForeColor = System.Drawing.Color.White;
            this.textBoxSentimentType.Location = new System.Drawing.Point(334, 565);
            this.textBoxSentimentType.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSentimentType.MaxLength = 100;
            this.textBoxSentimentType.Multiline = true;
            this.textBoxSentimentType.Name = "textBoxSentimentType";
            this.textBoxSentimentType.ReadOnly = true;
            this.textBoxSentimentType.Size = new System.Drawing.Size(550, 38);
            this.textBoxSentimentType.TabIndex = 15;
            // 
            // comboBoxPhrase
            // 
            this.comboBoxPhrase.FormattingEnabled = true;
            this.comboBoxPhrase.Location = new System.Drawing.Point(334, 145);
            this.comboBoxPhrase.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxPhrase.Name = "comboBoxPhrase";
            this.comboBoxPhrase.Size = new System.Drawing.Size(547, 32);
            this.comboBoxPhrase.TabIndex = 17;
            this.comboBoxPhrase.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxPhrase_SelectionChangeCommitted);
            // 
            // textBoxEntity
            // 
            this.textBoxEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxEntity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntity.ForeColor = System.Drawing.Color.White;
            this.textBoxEntity.Location = new System.Drawing.Point(334, 425);
            this.textBoxEntity.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEntity.MaxLength = 100;
            this.textBoxEntity.Multiline = true;
            this.textBoxEntity.Name = "textBoxEntity";
            this.textBoxEntity.ReadOnly = true;
            this.textBoxEntity.Size = new System.Drawing.Size(550, 38);
            this.textBoxEntity.TabIndex = 18;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.ForeColor = System.Drawing.Color.White;
            this.textBoxAuthor.Location = new System.Drawing.Point(334, 285);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAuthor.MaxLength = 100;
            this.textBoxAuthor.Multiline = true;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(550, 38);
            this.textBoxAuthor.TabIndex = 20;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(119, 285);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(62, 28);
            this.labelAuthor.TabIndex = 19;
            this.labelAuthor.Text = "Autor";
            // 
            // ReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxEntity);
            this.Controls.Add(this.comboBoxPhrase);
            this.Controls.Add(this.textBoxSentimentType);
            this.Controls.Add(this.labelSentimentType);
            this.Controls.Add(this.labelPhrase);
            this.Controls.Add(this.labelEntity);
            this.Controls.Add(this.labelReportsTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(1236, 834);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReportsTitle;
        private System.Windows.Forms.Label labelEntity;
        private System.Windows.Forms.Label labelPhrase;
        private System.Windows.Forms.Label labelSentimentType;
        private System.Windows.Forms.TextBox textBoxSentimentType;
        private System.Windows.Forms.ComboBox comboBoxPhrase;
        private System.Windows.Forms.TextBox textBoxEntity;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
    }
}
