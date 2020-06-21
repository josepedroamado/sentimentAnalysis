namespace UserInterface
{
    partial class AddAuthorView
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
            this.labelAuthorException = new System.Windows.Forms.Label();
            this.btnCancelAddAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.textBoxAuthorUsername = new System.Windows.Forms.TextBox();
            this.labelAuthorUsername = new System.Windows.Forms.Label();
            this.labelAddAuthorTitle = new System.Windows.Forms.Label();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.textBoxAuthorLastname = new System.Windows.Forms.TextBox();
            this.labelAuthorLastname = new System.Windows.Forms.Label();
            this.dateTimePickerAuthorBirthdate = new System.Windows.Forms.DateTimePicker();
            this.labelAuthorBirthdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAuthorException
            // 
            this.labelAuthorException.AutoSize = true;
            this.labelAuthorException.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorException.ForeColor = System.Drawing.Color.Red;
            this.labelAuthorException.Location = new System.Drawing.Point(120, 419);
            this.labelAuthorException.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthorException.Name = "labelAuthorException";
            this.labelAuthorException.Size = new System.Drawing.Size(59, 28);
            this.labelAuthorException.TabIndex = 24;
            this.labelAuthorException.Text = "Error";
            this.labelAuthorException.Visible = false;
            // 
            // btnCancelAddAuthor
            // 
            this.btnCancelAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancelAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnCancelAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddAuthor.Location = new System.Drawing.Point(574, 467);
            this.btnCancelAddAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelAddAuthor.Name = "btnCancelAddAuthor";
            this.btnCancelAddAuthor.Size = new System.Drawing.Size(138, 55);
            this.btnCancelAddAuthor.TabIndex = 23;
            this.btnCancelAddAuthor.Text = "Cancelar";
            this.btnCancelAddAuthor.UseVisualStyleBackColor = false;
            this.btnCancelAddAuthor.Click += new System.EventHandler(this.BtnCancelAddAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(378, 467);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(138, 55);
            this.btnAddAuthor.TabIndex = 22;
            this.btnAddAuthor.Text = "Ingresar";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.BtnAddAuthor_Click);
            // 
            // textBoxAuthorUsername
            // 
            this.textBoxAuthorUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxAuthorUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAuthorUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxAuthorUsername.Location = new System.Drawing.Point(334, 144);
            this.textBoxAuthorUsername.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAuthorUsername.MaxLength = 10;
            this.textBoxAuthorUsername.Multiline = true;
            this.textBoxAuthorUsername.Name = "textBoxAuthorUsername";
            this.textBoxAuthorUsername.Size = new System.Drawing.Size(550, 46);
            this.textBoxAuthorUsername.TabIndex = 21;
            // 
            // labelAuthorUsername
            // 
            this.labelAuthorUsername.AutoSize = true;
            this.labelAuthorUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorUsername.ForeColor = System.Drawing.Color.White;
            this.labelAuthorUsername.Location = new System.Drawing.Point(119, 144);
            this.labelAuthorUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthorUsername.Name = "labelAuthorUsername";
            this.labelAuthorUsername.Size = new System.Drawing.Size(184, 28);
            this.labelAuthorUsername.TabIndex = 20;
            this.labelAuthorUsername.Text = "Nombre de Usuario";
            // 
            // labelAddAuthorTitle
            // 
            this.labelAddAuthorTitle.AutoSize = true;
            this.labelAddAuthorTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAuthorTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddAuthorTitle.Location = new System.Drawing.Point(119, 41);
            this.labelAddAuthorTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddAuthorTitle.Name = "labelAddAuthorTitle";
            this.labelAddAuthorTitle.Size = new System.Drawing.Size(194, 31);
            this.labelAddAuthorTitle.TabIndex = 19;
            this.labelAddAuthorTitle.Text = "Ingreso de Autor";
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAuthorName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorName.ForeColor = System.Drawing.Color.White;
            this.textBoxAuthorName.Location = new System.Drawing.Point(334, 217);
            this.textBoxAuthorName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAuthorName.MaxLength = 15;
            this.textBoxAuthorName.Multiline = true;
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(550, 46);
            this.textBoxAuthorName.TabIndex = 26;
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorName.ForeColor = System.Drawing.Color.White;
            this.labelAuthorName.Location = new System.Drawing.Point(119, 217);
            this.labelAuthorName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(172, 28);
            this.labelAuthorName.TabIndex = 25;
            this.labelAuthorName.Text = "Nombre del Autor";
            // 
            // textBoxAuthorLastname
            // 
            this.textBoxAuthorLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxAuthorLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAuthorLastname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorLastname.ForeColor = System.Drawing.Color.White;
            this.textBoxAuthorLastname.Location = new System.Drawing.Point(334, 289);
            this.textBoxAuthorLastname.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAuthorLastname.MaxLength = 15;
            this.textBoxAuthorLastname.Multiline = true;
            this.textBoxAuthorLastname.Name = "textBoxAuthorLastname";
            this.textBoxAuthorLastname.Size = new System.Drawing.Size(550, 46);
            this.textBoxAuthorLastname.TabIndex = 28;
            // 
            // labelAuthorLastname
            // 
            this.labelAuthorLastname.AutoSize = true;
            this.labelAuthorLastname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorLastname.ForeColor = System.Drawing.Color.White;
            this.labelAuthorLastname.Location = new System.Drawing.Point(119, 289);
            this.labelAuthorLastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthorLastname.Name = "labelAuthorLastname";
            this.labelAuthorLastname.Size = new System.Drawing.Size(173, 28);
            this.labelAuthorLastname.TabIndex = 27;
            this.labelAuthorLastname.Text = "Apellido del Autor";
            // 
            // dateTimePickerAuthorBirthdate
            // 
            this.dateTimePickerAuthorBirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAuthorBirthdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAuthorBirthdate.Location = new System.Drawing.Point(334, 364);
            this.dateTimePickerAuthorBirthdate.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerAuthorBirthdate.MaxDate = new System.DateTime(2107, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAuthorBirthdate.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAuthorBirthdate.Name = "dateTimePickerAuthorBirthdate";
            this.dateTimePickerAuthorBirthdate.Size = new System.Drawing.Size(547, 33);
            this.dateTimePickerAuthorBirthdate.TabIndex = 30;
            // 
            // labelAuthorBirthdate
            // 
            this.labelAuthorBirthdate.AutoSize = true;
            this.labelAuthorBirthdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorBirthdate.ForeColor = System.Drawing.Color.White;
            this.labelAuthorBirthdate.Location = new System.Drawing.Point(120, 364);
            this.labelAuthorBirthdate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthorBirthdate.Name = "labelAuthorBirthdate";
            this.labelAuthorBirthdate.Size = new System.Drawing.Size(191, 28);
            this.labelAuthorBirthdate.TabIndex = 29;
            this.labelAuthorBirthdate.Text = "Fecha de nacimiento";
            // 
            // AddAuthorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.dateTimePickerAuthorBirthdate);
            this.Controls.Add(this.labelAuthorBirthdate);
            this.Controls.Add(this.textBoxAuthorLastname);
            this.Controls.Add(this.labelAuthorLastname);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelAuthorException);
            this.Controls.Add(this.btnCancelAddAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.textBoxAuthorUsername);
            this.Controls.Add(this.labelAuthorUsername);
            this.Controls.Add(this.labelAddAuthorTitle);
            this.Name = "AddAuthorView";
            this.Size = new System.Drawing.Size(1236, 834);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorException;
        private System.Windows.Forms.Button btnCancelAddAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.TextBox textBoxAuthorUsername;
        private System.Windows.Forms.Label labelAuthorUsername;
        private System.Windows.Forms.Label labelAddAuthorTitle;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.TextBox textBoxAuthorLastname;
        private System.Windows.Forms.Label labelAuthorLastname;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuthorBirthdate;
        private System.Windows.Forms.Label labelAuthorBirthdate;
    }
}
