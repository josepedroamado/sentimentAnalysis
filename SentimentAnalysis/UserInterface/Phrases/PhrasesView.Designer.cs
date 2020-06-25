namespace UserInterface
{
    partial class PhrasesView
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
            this.labelPhrasesTitle = new System.Windows.Forms.Label();
            this.textBoxPhraseText = new System.Windows.Forms.TextBox();
            this.labelPhraseText = new System.Windows.Forms.Label();
            this.labelPhraseDate = new System.Windows.Forms.Label();
            this.dateTimePickerPhraseDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddPhrase = new System.Windows.Forms.Button();
            this.btnCancelAddPhrase = new System.Windows.Forms.Button();
            this.labelPhraseTextException = new System.Windows.Forms.Label();
            this.comboBoxPhraseAuthor = new System.Windows.Forms.ComboBox();
            this.labelPhraseAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPhrasesTitle
            // 
            this.labelPhrasesTitle.AutoSize = true;
            this.labelPhrasesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhrasesTitle.ForeColor = System.Drawing.Color.White;
            this.labelPhrasesTitle.Location = new System.Drawing.Point(119, 41);
            this.labelPhrasesTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhrasesTitle.Name = "labelPhrasesTitle";
            this.labelPhrasesTitle.Size = new System.Drawing.Size(187, 31);
            this.labelPhrasesTitle.TabIndex = 8;
            this.labelPhrasesTitle.Text = "Ingreso de Frase";
            // 
            // textBoxPhraseText
            // 
            this.textBoxPhraseText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxPhraseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhraseText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhraseText.ForeColor = System.Drawing.Color.White;
            this.textBoxPhraseText.Location = new System.Drawing.Point(310, 176);
            this.textBoxPhraseText.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPhraseText.MaxLength = 100;
            this.textBoxPhraseText.Multiline = true;
            this.textBoxPhraseText.Name = "textBoxPhraseText";
            this.textBoxPhraseText.Size = new System.Drawing.Size(550, 146);
            this.textBoxPhraseText.TabIndex = 9;
            // 
            // labelPhraseText
            // 
            this.labelPhraseText.AutoSize = true;
            this.labelPhraseText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhraseText.ForeColor = System.Drawing.Color.White;
            this.labelPhraseText.Location = new System.Drawing.Point(119, 176);
            this.labelPhraseText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhraseText.Name = "labelPhraseText";
            this.labelPhraseText.Size = new System.Drawing.Size(159, 28);
            this.labelPhraseText.TabIndex = 10;
            this.labelPhraseText.Text = "Texto de la Frase:";
            // 
            // labelPhraseDate
            // 
            this.labelPhraseDate.AutoSize = true;
            this.labelPhraseDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhraseDate.ForeColor = System.Drawing.Color.White;
            this.labelPhraseDate.Location = new System.Drawing.Point(121, 360);
            this.labelPhraseDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhraseDate.Name = "labelPhraseDate";
            this.labelPhraseDate.Size = new System.Drawing.Size(163, 28);
            this.labelPhraseDate.TabIndex = 12;
            this.labelPhraseDate.Text = "Fecha de ingreso:";
            // 
            // dateTimePickerPhraseDate
            // 
            this.dateTimePickerPhraseDate.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPhraseDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPhraseDate.Location = new System.Drawing.Point(310, 360);
            this.dateTimePickerPhraseDate.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerPhraseDate.Name = "dateTimePickerPhraseDate";
            this.dateTimePickerPhraseDate.Size = new System.Drawing.Size(547, 33);
            this.dateTimePickerPhraseDate.TabIndex = 13;
            // 
            // btnAddPhrase
            // 
            this.btnAddPhrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddPhrase.FlatAppearance.BorderSize = 0;
            this.btnAddPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhrase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhrase.ForeColor = System.Drawing.Color.White;
            this.btnAddPhrase.Location = new System.Drawing.Point(378, 470);
            this.btnAddPhrase.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddPhrase.Name = "btnAddPhrase";
            this.btnAddPhrase.Size = new System.Drawing.Size(138, 55);
            this.btnAddPhrase.TabIndex = 14;
            this.btnAddPhrase.Text = "Ingresar";
            this.btnAddPhrase.UseVisualStyleBackColor = false;
            this.btnAddPhrase.Click += new System.EventHandler(this.BtnAddPhrase_Click);
            // 
            // btnCancelAddPhrase
            // 
            this.btnCancelAddPhrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancelAddPhrase.FlatAppearance.BorderSize = 0;
            this.btnCancelAddPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddPhrase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddPhrase.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddPhrase.Location = new System.Drawing.Point(574, 470);
            this.btnCancelAddPhrase.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelAddPhrase.Name = "btnCancelAddPhrase";
            this.btnCancelAddPhrase.Size = new System.Drawing.Size(138, 55);
            this.btnCancelAddPhrase.TabIndex = 15;
            this.btnCancelAddPhrase.Text = "Cancelar";
            this.btnCancelAddPhrase.UseVisualStyleBackColor = false;
            this.btnCancelAddPhrase.Click += new System.EventHandler(this.BtnCancelAddPhrase_Click);
            // 
            // labelPhraseTextException
            // 
            this.labelPhraseTextException.AutoSize = true;
            this.labelPhraseTextException.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhraseTextException.ForeColor = System.Drawing.Color.Red;
            this.labelPhraseTextException.Location = new System.Drawing.Point(121, 424);
            this.labelPhraseTextException.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhraseTextException.Name = "labelPhraseTextException";
            this.labelPhraseTextException.Size = new System.Drawing.Size(59, 28);
            this.labelPhraseTextException.TabIndex = 19;
            this.labelPhraseTextException.Text = "Error";
            this.labelPhraseTextException.Visible = false;
            // 
            // comboBoxPhraseAuthor
            // 
            this.comboBoxPhraseAuthor.FormattingEnabled = true;
            this.comboBoxPhraseAuthor.Location = new System.Drawing.Point(310, 109);
            this.comboBoxPhraseAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxPhraseAuthor.Name = "comboBoxPhraseAuthor";
            this.comboBoxPhraseAuthor.Size = new System.Drawing.Size(547, 32);
            this.comboBoxPhraseAuthor.TabIndex = 21;
            // 
            // labelPhraseAuthor
            // 
            this.labelPhraseAuthor.AutoSize = true;
            this.labelPhraseAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhraseAuthor.ForeColor = System.Drawing.Color.White;
            this.labelPhraseAuthor.Location = new System.Drawing.Point(119, 109);
            this.labelPhraseAuthor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhraseAuthor.Name = "labelPhraseAuthor";
            this.labelPhraseAuthor.Size = new System.Drawing.Size(73, 28);
            this.labelPhraseAuthor.TabIndex = 20;
            this.labelPhraseAuthor.Text = "Author";
            // 
            // PhrasesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.comboBoxPhraseAuthor);
            this.Controls.Add(this.labelPhraseAuthor);
            this.Controls.Add(this.labelPhraseTextException);
            this.Controls.Add(this.btnCancelAddPhrase);
            this.Controls.Add(this.btnAddPhrase);
            this.Controls.Add(this.dateTimePickerPhraseDate);
            this.Controls.Add(this.labelPhraseDate);
            this.Controls.Add(this.labelPhraseText);
            this.Controls.Add(this.textBoxPhraseText);
            this.Controls.Add(this.labelPhrasesTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PhrasesView";
            this.Size = new System.Drawing.Size(1236, 834);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPhrasesTitle;
        private System.Windows.Forms.TextBox textBoxPhraseText;
        private System.Windows.Forms.Label labelPhraseText;
        private System.Windows.Forms.Label labelPhraseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPhraseDate;
        private System.Windows.Forms.Button btnAddPhrase;
        private System.Windows.Forms.Button btnCancelAddPhrase;
        private System.Windows.Forms.Label labelPhraseTextException;
        private System.Windows.Forms.ComboBox comboBoxPhraseAuthor;
        private System.Windows.Forms.Label labelPhraseAuthor;
    }
}
