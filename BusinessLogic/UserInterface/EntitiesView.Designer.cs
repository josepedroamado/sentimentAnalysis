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
            this.btnDeleteEntity = new System.Windows.Forms.Button();
            this.btnAddEntity = new System.Windows.Forms.Button();
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
            this.listBoxEntities.ItemHeight = 30;
            this.listBoxEntities.Location = new System.Drawing.Point(132, 121);
            this.listBoxEntities.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxEntities.Name = "listBoxEntities";
            this.listBoxEntities.Size = new System.Drawing.Size(1088, 660);
            this.listBoxEntities.TabIndex = 3;
            // 
            // btnDeleteEntity
            // 
            this.btnDeleteEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteEntity.Enabled = false;
            this.btnDeleteEntity.FlatAppearance.BorderSize = 0;
            this.btnDeleteEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntity.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEntity.Location = new System.Drawing.Point(976, 31);
            this.btnDeleteEntity.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteEntity.Name = "btnDeleteEntity";
            this.btnDeleteEntity.Size = new System.Drawing.Size(150, 58);
            this.btnDeleteEntity.TabIndex = 6;
            this.btnDeleteEntity.Text = "Eliminar";
            this.btnDeleteEntity.UseVisualStyleBackColor = false;
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddEntity.FlatAppearance.BorderSize = 0;
            this.btnAddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntity.ForeColor = System.Drawing.Color.White;
            this.btnAddEntity.Location = new System.Drawing.Point(788, 29);
            this.btnAddEntity.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(150, 58);
            this.btnAddEntity.TabIndex = 5;
            this.btnAddEntity.Text = "Agregar";
            this.btnAddEntity.UseVisualStyleBackColor = false;
            this.btnAddEntity.Click += new System.EventHandler(this.BtnAddEntity_Click);
            // 
            // labelEntitiesTitle
            // 
            this.labelEntitiesTitle.AutoSize = true;
            this.labelEntitiesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntitiesTitle.ForeColor = System.Drawing.Color.White;
            this.labelEntitiesTitle.Location = new System.Drawing.Point(130, 42);
            this.labelEntitiesTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEntitiesTitle.Name = "labelEntitiesTitle";
            this.labelEntitiesTitle.Size = new System.Drawing.Size(133, 36);
            this.labelEntitiesTitle.TabIndex = 7;
            this.labelEntitiesTitle.Text = "Entidades";
            // 
            // EntitiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelEntitiesTitle);
            this.Controls.Add(this.btnDeleteEntity);
            this.Controls.Add(this.btnAddEntity);
            this.Controls.Add(this.listBoxEntities);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EntitiesView";
            this.Size = new System.Drawing.Size(1348, 869);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEntities;
        private System.Windows.Forms.Button btnDeleteEntity;
        private System.Windows.Forms.Button btnAddEntity;
        private System.Windows.Forms.Label labelEntitiesTitle;
    }
}
