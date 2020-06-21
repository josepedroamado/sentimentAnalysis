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
            this.listBoxSentiment = new System.Windows.Forms.ListBox();
            this.btnAddSentiment = new System.Windows.Forms.Button();
            this.btnDeleteSentiment = new System.Windows.Forms.Button();
            this.labelSentimentTitle = new System.Windows.Forms.Label();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
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
            this.listBoxSentiment.Size = new System.Drawing.Size(544, 338);
            this.listBoxSentiment.TabIndex = 2;
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
            this.btnAddSentiment.TabIndex = 3;
            this.btnAddSentiment.Text = "Agregar";
            this.btnAddSentiment.UseVisualStyleBackColor = false;
            this.btnAddSentiment.Click += new System.EventHandler(this.BtnAddSentiment_Click);
            // 
            // btnDeleteSentiment
            // 
            this.btnDeleteSentiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteSentiment.FlatAppearance.BorderSize = 0;
            this.btnDeleteSentiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSentiment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSentiment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSentiment.Location = new System.Drawing.Point(488, 16);
            this.btnDeleteSentiment.Name = "btnDeleteSentiment";
            this.btnDeleteSentiment.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteSentiment.TabIndex = 4;
            this.btnDeleteSentiment.Text = "Eliminar";
            this.btnDeleteSentiment.UseVisualStyleBackColor = false;
            this.btnDeleteSentiment.Click += new System.EventHandler(this.BtnDeleteSentiment_Click);
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
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Checked = true;
            this.radioButtonPositive.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPositive.ForeColor = System.Drawing.Color.White;
            this.radioButtonPositive.Location = new System.Drawing.Point(218, 23);
            this.radioButtonPositive.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPositive.TabIndex = 6;
            this.radioButtonPositive.TabStop = true;
            this.radioButtonPositive.Text = "Positivos";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            this.radioButtonPositive.CheckedChanged += new System.EventHandler(this.RadioButtonPositive_CheckedChanged);
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNegative.ForeColor = System.Drawing.Color.White;
            this.radioButtonNegative.Location = new System.Drawing.Point(291, 23);
            this.radioButtonNegative.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(76, 17);
            this.radioButtonNegative.TabIndex = 7;
            this.radioButtonNegative.Text = "Negativos";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            // 
            // SentimentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.radioButtonNegative);
            this.Controls.Add(this.radioButtonPositive);
            this.Controls.Add(this.labelSentimentTitle);
            this.Controls.Add(this.btnDeleteSentiment);
            this.Controls.Add(this.btnAddSentiment);
            this.Controls.Add(this.listBoxSentiment);
            this.Name = "SentimentView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSentiment;
        private System.Windows.Forms.Button btnAddSentiment;
        private System.Windows.Forms.Button btnDeleteSentiment;
        private System.Windows.Forms.Label labelSentimentTitle;
        private System.Windows.Forms.RadioButton radioButtonPositive;
        private System.Windows.Forms.RadioButton radioButtonNegative;
    }
}
