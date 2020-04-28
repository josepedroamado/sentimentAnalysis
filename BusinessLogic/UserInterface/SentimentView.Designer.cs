namespace UserInterface
{
    partial class SentimentView
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
            this.labelSentimentType = new System.Windows.Forms.Label();
            this.comboBoxSentimentType = new System.Windows.Forms.ComboBox();
            this.listBoxSentiment = new System.Windows.Forms.ListBox();
            this.btnAddEntity = new System.Windows.Forms.Button();
            this.btnDeleteEntity = new System.Windows.Forms.Button();
            this.labelSentimentTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSentimentType
            // 
            this.labelSentimentType.AutoSize = true;
            this.labelSentimentType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentType.ForeColor = System.Drawing.Color.White;
            this.labelSentimentType.Location = new System.Drawing.Point(220, 25);
            this.labelSentimentType.Name = "labelSentimentType";
            this.labelSentimentType.Size = new System.Drawing.Size(30, 13);
            this.labelSentimentType.TabIndex = 0;
            this.labelSentimentType.Text = "Tipo";
            // 
            // comboBoxSentimentType
            // 
            this.comboBoxSentimentType.BackColor = System.Drawing.Color.White;
            this.comboBoxSentimentType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSentimentType.ForeColor = System.Drawing.Color.White;
            this.comboBoxSentimentType.FormattingEnabled = true;
            this.comboBoxSentimentType.Location = new System.Drawing.Point(256, 21);
            this.comboBoxSentimentType.Name = "comboBoxSentimentType";
            this.comboBoxSentimentType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSentimentType.TabIndex = 1;
            this.comboBoxSentimentType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSentimentType_SelectedIndexChanged);
            // 
            // listBoxSentiment
            // 
            this.listBoxSentiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listBoxSentiment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSentiment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSentiment.ForeColor = System.Drawing.Color.White;
            this.listBoxSentiment.FormattingEnabled = true;
            this.listBoxSentiment.Location = new System.Drawing.Point(66, 63);
            this.listBoxSentiment.Name = "listBoxSentiment";
            this.listBoxSentiment.Size = new System.Drawing.Size(544, 351);
            this.listBoxSentiment.TabIndex = 2;
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddEntity.FlatAppearance.BorderSize = 0;
            this.btnAddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntity.ForeColor = System.Drawing.Color.White;
            this.btnAddEntity.Location = new System.Drawing.Point(394, 15);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(75, 30);
            this.btnAddEntity.TabIndex = 3;
            this.btnAddEntity.Text = "Agregar";
            this.btnAddEntity.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEntity
            // 
            this.btnDeleteEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteEntity.Enabled = false;
            this.btnDeleteEntity.FlatAppearance.BorderSize = 0;
            this.btnDeleteEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntity.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEntity.Location = new System.Drawing.Point(488, 16);
            this.btnDeleteEntity.Name = "btnDeleteEntity";
            this.btnDeleteEntity.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteEntity.TabIndex = 4;
            this.btnDeleteEntity.Text = "Eliminar";
            this.btnDeleteEntity.UseVisualStyleBackColor = false;
            // 
            // labelSentimentTitle
            // 
            this.labelSentimentTitle.AutoSize = true;
            this.labelSentimentTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentTitle.ForeColor = System.Drawing.Color.White;
            this.labelSentimentTitle.Location = new System.Drawing.Point(65, 22);
            this.labelSentimentTitle.Name = "labelSentimentTitle";
            this.labelSentimentTitle.Size = new System.Drawing.Size(89, 17);
            this.labelSentimentTitle.TabIndex = 5;
            this.labelSentimentTitle.Text = "Sentimientos";
            // 
            // SentimentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelSentimentTitle);
            this.Controls.Add(this.btnDeleteEntity);
            this.Controls.Add(this.btnAddEntity);
            this.Controls.Add(this.listBoxSentiment);
            this.Controls.Add(this.comboBoxSentimentType);
            this.Controls.Add(this.labelSentimentType);
            this.Name = "SentimentView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSentimentType;
        private System.Windows.Forms.ComboBox comboBoxSentimentType;
        private System.Windows.Forms.ListBox listBoxSentiment;
        private System.Windows.Forms.Button btnAddEntity;
        private System.Windows.Forms.Button btnDeleteEntity;
        private System.Windows.Forms.Label labelSentimentTitle;
    }
}
