namespace UserInterface
{
    partial class AddEntityView
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
            this.labelAddEntityTitle = new System.Windows.Forms.Label();
            this.labelEntityName = new System.Windows.Forms.Label();
            this.textBoxEntityName = new System.Windows.Forms.TextBox();
            this.btnAddEntity = new System.Windows.Forms.Button();
            this.btnCancelAddEntity = new System.Windows.Forms.Button();
            this.labelEntityNameException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddEntityTitle
            // 
            this.labelAddEntityTitle.AutoSize = true;
            this.labelAddEntityTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEntityTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddEntityTitle.Location = new System.Drawing.Point(65, 22);
            this.labelAddEntityTitle.Name = "labelAddEntityTitle";
            this.labelAddEntityTitle.Size = new System.Drawing.Size(124, 17);
            this.labelAddEntityTitle.TabIndex = 10;
            this.labelAddEntityTitle.Text = "Ingreso de Entidad";
            // 
            // labelEntityName
            // 
            this.labelEntityName.AutoSize = true;
            this.labelEntityName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntityName.ForeColor = System.Drawing.Color.White;
            this.labelEntityName.Location = new System.Drawing.Point(65, 78);
            this.labelEntityName.Name = "labelEntityName";
            this.labelEntityName.Size = new System.Drawing.Size(48, 13);
            this.labelEntityName.TabIndex = 11;
            this.labelEntityName.Text = "Nombre";
            // 
            // textBoxEntityName
            // 
            this.textBoxEntityName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxEntityName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEntityName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntityName.ForeColor = System.Drawing.Color.White;
            this.textBoxEntityName.Location = new System.Drawing.Point(182, 78);
            this.textBoxEntityName.MaxLength = 100;
            this.textBoxEntityName.Multiline = true;
            this.textBoxEntityName.Name = "textBoxEntityName";
            this.textBoxEntityName.Size = new System.Drawing.Size(300, 79);
            this.textBoxEntityName.TabIndex = 12;
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddEntity.FlatAppearance.BorderSize = 0;
            this.btnAddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntity.ForeColor = System.Drawing.Color.White;
            this.btnAddEntity.Location = new System.Drawing.Point(206, 244);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(75, 30);
            this.btnAddEntity.TabIndex = 16;
            this.btnAddEntity.Text = "Ingresar";
            this.btnAddEntity.UseVisualStyleBackColor = false;
            // 
            // btnCancelAddEntity
            // 
            this.btnCancelAddEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancelAddEntity.FlatAppearance.BorderSize = 0;
            this.btnCancelAddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddEntity.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddEntity.Location = new System.Drawing.Point(313, 244);
            this.btnCancelAddEntity.Name = "btnCancelAddEntity";
            this.btnCancelAddEntity.Size = new System.Drawing.Size(75, 30);
            this.btnCancelAddEntity.TabIndex = 17;
            this.btnCancelAddEntity.Text = "Cancelar";
            this.btnCancelAddEntity.UseVisualStyleBackColor = false;
            this.btnCancelAddEntity.Click += new System.EventHandler(this.BtnCancelAddEntity_Click);
            // 
            // labelEntityNameException
            // 
            this.labelEntityNameException.AutoSize = true;
            this.labelEntityNameException.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntityNameException.ForeColor = System.Drawing.Color.Red;
            this.labelEntityNameException.Location = new System.Drawing.Point(497, 78);
            this.labelEntityNameException.Name = "labelEntityNameException";
            this.labelEntityNameException.Size = new System.Drawing.Size(32, 13);
            this.labelEntityNameException.TabIndex = 18;
            this.labelEntityNameException.Text = "Error";
            this.labelEntityNameException.Visible = false;
            // 
            // AddEntityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelEntityNameException);
            this.Controls.Add(this.btnCancelAddEntity);
            this.Controls.Add(this.btnAddEntity);
            this.Controls.Add(this.textBoxEntityName);
            this.Controls.Add(this.labelEntityName);
            this.Controls.Add(this.labelAddEntityTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEntityView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddEntityTitle;
        private System.Windows.Forms.Label labelEntityName;
        private System.Windows.Forms.TextBox textBoxEntityName;
        private System.Windows.Forms.Button btnAddEntity;
        private System.Windows.Forms.Button btnCancelAddEntity;
        private System.Windows.Forms.Label labelEntityNameException;
    }
}
