namespace UserInterface
{
    partial class AuthorsView
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
            this.labelAuthorsTitle = new System.Windows.Forms.Label();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelAuthorsTitle
            // 
            this.labelAuthorsTitle.AutoSize = true;
            this.labelAuthorsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorsTitle.ForeColor = System.Drawing.Color.White;
            this.labelAuthorsTitle.Location = new System.Drawing.Point(119, 41);
            this.labelAuthorsTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAuthorsTitle.Name = "labelAuthorsTitle";
            this.labelAuthorsTitle.Size = new System.Drawing.Size(98, 31);
            this.labelAuthorsTitle.TabIndex = 11;
            this.labelAuthorsTitle.Text = "Autores";
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteAuthor.FlatAppearance.BorderSize = 0;
            this.btnDeleteAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(895, 30);
            this.btnDeleteAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(138, 55);
            this.btnDeleteAuthor.TabIndex = 10;
            this.btnDeleteAuthor.Text = "Eliminar";
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.BtnDeleteAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(722, 28);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(138, 55);
            this.btnAddAuthor.TabIndex = 9;
            this.btnAddAuthor.Text = "Agregar";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.BtnAddAuthor_Click);
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxAuthors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAuthors.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAuthors.ForeColor = System.Drawing.Color.White;
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.ItemHeight = 25;
            this.listBoxAuthors.Location = new System.Drawing.Point(121, 116);
            this.listBoxAuthors.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(997, 600);
            this.listBoxAuthors.TabIndex = 8;
            // 
            // AuthorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelAuthorsTitle);
            this.Controls.Add(this.btnDeleteAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.listBoxAuthors);
            this.Name = "AuthorsView";
            this.Size = new System.Drawing.Size(1236, 834);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorsTitle;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.ListBox listBoxAuthors;
    }
}
