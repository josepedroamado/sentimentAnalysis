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
            this.comboBoxEntity = new System.Windows.Forms.ComboBox();
            this.comboBoxPhrase = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelReportsTitle
            // 
            this.labelReportsTitle.AutoSize = true;
            this.labelReportsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportsTitle.ForeColor = System.Drawing.Color.White;
            this.labelReportsTitle.Location = new System.Drawing.Point(65, 22);
            this.labelReportsTitle.Name = "labelReportsTitle";
            this.labelReportsTitle.Size = new System.Drawing.Size(127, 17);
            this.labelReportsTitle.TabIndex = 9;
            this.labelReportsTitle.Text = "Reporte de Análisis";
            // 
            // labelEntity
            // 
            this.labelEntity.AutoSize = true;
            this.labelEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntity.ForeColor = System.Drawing.Color.White;
            this.labelEntity.Location = new System.Drawing.Point(65, 78);
            this.labelEntity.Name = "labelEntity";
            this.labelEntity.Size = new System.Drawing.Size(47, 13);
            this.labelEntity.TabIndex = 12;
            this.labelEntity.Text = "Entidad";
            // 
            // labelPhrase
            // 
            this.labelPhrase.AutoSize = true;
            this.labelPhrase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhrase.ForeColor = System.Drawing.Color.White;
            this.labelPhrase.Location = new System.Drawing.Point(65, 187);
            this.labelPhrase.Name = "labelPhrase";
            this.labelPhrase.Size = new System.Drawing.Size(34, 13);
            this.labelPhrase.TabIndex = 13;
            this.labelPhrase.Text = "Frase";
            // 
            // labelSentimentType
            // 
            this.labelSentimentType.AutoSize = true;
            this.labelSentimentType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentType.ForeColor = System.Drawing.Color.White;
            this.labelSentimentType.Location = new System.Drawing.Point(65, 317);
            this.labelSentimentType.Name = "labelSentimentType";
            this.labelSentimentType.Size = new System.Drawing.Size(111, 13);
            this.labelSentimentType.TabIndex = 14;
            this.labelSentimentType.Text = "Tipo de Sentimiento";
            // 
            // textBoxSentimentType
            // 
            this.textBoxSentimentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxSentimentType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSentimentType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentimentType.ForeColor = System.Drawing.Color.White;
            this.textBoxSentimentType.Location = new System.Drawing.Point(182, 317);
            this.textBoxSentimentType.MaxLength = 100;
            this.textBoxSentimentType.Multiline = true;
            this.textBoxSentimentType.Name = "textBoxSentimentType";
            this.textBoxSentimentType.ReadOnly = true;
            this.textBoxSentimentType.Size = new System.Drawing.Size(300, 21);
            this.textBoxSentimentType.TabIndex = 15;
            // 
            // comboBoxEntity
            // 
            this.comboBoxEntity.FormattingEnabled = true;
            this.comboBoxEntity.Location = new System.Drawing.Point(182, 78);
            this.comboBoxEntity.Name = "comboBoxEntity";
            this.comboBoxEntity.Size = new System.Drawing.Size(300, 21);
            this.comboBoxEntity.TabIndex = 16;
            // 
            // comboBoxPhrase
            // 
            this.comboBoxPhrase.FormattingEnabled = true;
            this.comboBoxPhrase.Location = new System.Drawing.Point(182, 187);
            this.comboBoxPhrase.Name = "comboBoxPhrase";
            this.comboBoxPhrase.Size = new System.Drawing.Size(300, 21);
            this.comboBoxPhrase.TabIndex = 17;
            // 
            // ReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.comboBoxPhrase);
            this.Controls.Add(this.comboBoxEntity);
            this.Controls.Add(this.textBoxSentimentType);
            this.Controls.Add(this.labelSentimentType);
            this.Controls.Add(this.labelPhrase);
            this.Controls.Add(this.labelEntity);
            this.Controls.Add(this.labelReportsTitle);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReportsTitle;
        private System.Windows.Forms.Label labelEntity;
        private System.Windows.Forms.Label labelPhrase;
        private System.Windows.Forms.Label labelSentimentType;
        private System.Windows.Forms.TextBox textBoxSentimentType;
        private System.Windows.Forms.ComboBox comboBoxEntity;
        private System.Windows.Forms.ComboBox comboBoxPhrase;
    }
}
