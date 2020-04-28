namespace UserInterface
{
    partial class EntitiesView
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
            this.listBoxEntities = new System.Windows.Forms.ListBox();
            this.btnDeleteSentiment = new System.Windows.Forms.Button();
            this.btnAddSentiment = new System.Windows.Forms.Button();
            this.labelEntitiesTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEntities
            // 
            this.listBoxEntities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxEntities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxEntities.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEntities.ForeColor = System.Drawing.Color.White;
            this.listBoxEntities.FormattingEnabled = true;
            this.listBoxEntities.Location = new System.Drawing.Point(66, 63);
            this.listBoxEntities.Name = "listBoxEntities";
            this.listBoxEntities.Size = new System.Drawing.Size(544, 351);
            this.listBoxEntities.TabIndex = 3;
            // 
            // btnDeleteSentiment
            // 
            this.btnDeleteSentiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteSentiment.Enabled = false;
            this.btnDeleteSentiment.FlatAppearance.BorderSize = 0;
            this.btnDeleteSentiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSentiment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSentiment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSentiment.Location = new System.Drawing.Point(488, 16);
            this.btnDeleteSentiment.Name = "btnDeleteSentiment";
            this.btnDeleteSentiment.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteSentiment.TabIndex = 6;
            this.btnDeleteSentiment.Text = "Eliminar";
            this.btnDeleteSentiment.UseVisualStyleBackColor = false;
            // 
            // btnAddSentiment
            // 
            this.btnAddSentiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddSentiment.FlatAppearance.BorderSize = 0;
            this.btnAddSentiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSentiment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSentiment.ForeColor = System.Drawing.Color.White;
            this.btnAddSentiment.Location = new System.Drawing.Point(394, 15);
            this.btnAddSentiment.Name = "btnAddSentiment";
            this.btnAddSentiment.Size = new System.Drawing.Size(75, 30);
            this.btnAddSentiment.TabIndex = 5;
            this.btnAddSentiment.Text = "Agregar";
            this.btnAddSentiment.UseVisualStyleBackColor = false;
            // 
            // labelEntitiesTitle
            // 
            this.labelEntitiesTitle.AutoSize = true;
            this.labelEntitiesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntitiesTitle.ForeColor = System.Drawing.Color.White;
            this.labelEntitiesTitle.Location = new System.Drawing.Point(65, 22);
            this.labelEntitiesTitle.Name = "labelEntitiesTitle";
            this.labelEntitiesTitle.Size = new System.Drawing.Size(68, 17);
            this.labelEntitiesTitle.TabIndex = 7;
            this.labelEntitiesTitle.Text = "Entidades";
            // 
            // EntitiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelEntitiesTitle);
            this.Controls.Add(this.btnDeleteSentiment);
            this.Controls.Add(this.btnAddSentiment);
            this.Controls.Add(this.listBoxEntities);
            this.Name = "EntitiesView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEntities;
        private System.Windows.Forms.Button btnDeleteSentiment;
        private System.Windows.Forms.Button btnAddSentiment;
        private System.Windows.Forms.Label labelEntitiesTitle;
    }
}
