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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPhraseDate = new System.Windows.Forms.Label();
            this.dateTimePickerPhraseDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddPhrase = new System.Windows.Forms.Button();
            this.btnCancelAddPhrase = new System.Windows.Forms.Button();
            this.labelPhraseTextException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPhrasesTitle
            // 
            this.labelPhrasesTitle.AutoSize = true;
            this.labelPhrasesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhrasesTitle.ForeColor = System.Drawing.Color.White;
            this.labelPhrasesTitle.Location = new System.Drawing.Point(65, 22);
            this.labelPhrasesTitle.Name = "labelPhrasesTitle";
            this.labelPhrasesTitle.Size = new System.Drawing.Size(109, 17);
            this.labelPhrasesTitle.TabIndex = 8;
            this.labelPhrasesTitle.Text = "Ingreso de Frase";
            // 
            // textBoxPhraseText
            // 
            this.textBoxPhraseText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxPhraseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhraseText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhraseText.ForeColor = System.Drawing.Color.White;
            this.textBoxPhraseText.Location = new System.Drawing.Point(169, 78);
            this.textBoxPhraseText.MaxLength = 100;
            this.textBoxPhraseText.Multiline = true;
            this.textBoxPhraseText.Name = "textBoxPhraseText";
            this.textBoxPhraseText.Size = new System.Drawing.Size(300, 79);
            this.textBoxPhraseText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Texto de la Frase:";
            // 
            // labelPhraseDate
            // 
            this.labelPhraseDate.AutoSize = true;
            this.labelPhraseDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhraseDate.ForeColor = System.Drawing.Color.White;
            this.labelPhraseDate.Location = new System.Drawing.Point(66, 184);
            this.labelPhraseDate.Name = "labelPhraseDate";
            this.labelPhraseDate.Size = new System.Drawing.Size(98, 13);
            this.labelPhraseDate.TabIndex = 12;
            this.labelPhraseDate.Text = "Fecha de ingreso:";
            // 
            // dateTimePickerPhraseDate
            // 
            this.dateTimePickerPhraseDate.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPhraseDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPhraseDate.Location = new System.Drawing.Point(169, 184);
            this.dateTimePickerPhraseDate.Name = "dateTimePickerPhraseDate";
            this.dateTimePickerPhraseDate.Size = new System.Drawing.Size(300, 22);
            this.dateTimePickerPhraseDate.TabIndex = 13;
            // 
            // btnAddPhrase
            // 
            this.btnAddPhrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddPhrase.FlatAppearance.BorderSize = 0;
            this.btnAddPhrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhrase.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhrase.ForeColor = System.Drawing.Color.White;
            this.btnAddPhrase.Location = new System.Drawing.Point(206, 244);
            this.btnAddPhrase.Name = "btnAddPhrase";
            this.btnAddPhrase.Size = new System.Drawing.Size(75, 30);
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
            this.btnCancelAddPhrase.Location = new System.Drawing.Point(313, 244);
            this.btnCancelAddPhrase.Name = "btnCancelAddPhrase";
            this.btnCancelAddPhrase.Size = new System.Drawing.Size(75, 30);
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
            this.labelPhraseTextException.Location = new System.Drawing.Point(66, 219);
            this.labelPhraseTextException.Name = "labelPhraseTextException";
            this.labelPhraseTextException.Size = new System.Drawing.Size(32, 13);
            this.labelPhraseTextException.TabIndex = 19;
            this.labelPhraseTextException.Text = "Error";
            this.labelPhraseTextException.Visible = false;
            // 
            // PhrasesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelPhraseTextException);
            this.Controls.Add(this.btnCancelAddPhrase);
            this.Controls.Add(this.btnAddPhrase);
            this.Controls.Add(this.dateTimePickerPhraseDate);
            this.Controls.Add(this.labelPhraseDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhraseText);
            this.Controls.Add(this.labelPhrasesTitle);
            this.Name = "PhrasesView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPhrasesTitle;
        private System.Windows.Forms.TextBox textBoxPhraseText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPhraseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPhraseDate;
        private System.Windows.Forms.Button btnAddPhrase;
        private System.Windows.Forms.Button btnCancelAddPhrase;
        private System.Windows.Forms.Label labelPhraseTextException;
    }
}
