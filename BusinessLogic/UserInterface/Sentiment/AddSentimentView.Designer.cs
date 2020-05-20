namespace UserInterface
{
    partial class AddSentimentView
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
            this.labelAddSentimentTitle = new System.Windows.Forms.Label();
            this.labelSentimentText = new System.Windows.Forms.Label();
            this.textBoxSentimentText = new System.Windows.Forms.TextBox();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.labelSentimentType = new System.Windows.Forms.Label();
            this.btnAddSentiment = new System.Windows.Forms.Button();
            this.btnCancelAddSentiment = new System.Windows.Forms.Button();
            this.labelSentimentTextException = new System.Windows.Forms.Label();
            this.labelSentimentTypeException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddSentimentTitle
            // 
            this.labelAddSentimentTitle.AutoSize = true;
            this.labelAddSentimentTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSentimentTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddSentimentTitle.Location = new System.Drawing.Point(65, 22);
            this.labelAddSentimentTitle.Name = "labelAddSentimentTitle";
            this.labelAddSentimentTitle.Size = new System.Drawing.Size(152, 17);
            this.labelAddSentimentTitle.TabIndex = 9;
            this.labelAddSentimentTitle.Text = "Ingreso de Sentimiento";
            // 
            // labelSentimentText
            // 
            this.labelSentimentText.AutoSize = true;
            this.labelSentimentText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentText.ForeColor = System.Drawing.Color.White;
            this.labelSentimentText.Location = new System.Drawing.Point(65, 78);
            this.labelSentimentText.Name = "labelSentimentText";
            this.labelSentimentText.Size = new System.Drawing.Size(85, 13);
            this.labelSentimentText.TabIndex = 10;
            this.labelSentimentText.Text = "Palabra o Frase";
            // 
            // textBoxSentimentText
            // 
            this.textBoxSentimentText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxSentimentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSentimentText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentimentText.ForeColor = System.Drawing.Color.White;
            this.textBoxSentimentText.Location = new System.Drawing.Point(182, 78);
            this.textBoxSentimentText.MaxLength = 100;
            this.textBoxSentimentText.Multiline = true;
            this.textBoxSentimentText.Name = "textBoxSentimentText";
            this.textBoxSentimentText.Size = new System.Drawing.Size(300, 79);
            this.textBoxSentimentText.TabIndex = 11;
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPositive.ForeColor = System.Drawing.Color.White;
            this.radioButtonPositive.Location = new System.Drawing.Point(182, 190);
            this.radioButtonPositive.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(65, 17);
            this.radioButtonPositive.TabIndex = 12;
            this.radioButtonPositive.Text = "Positivo";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNegative.ForeColor = System.Drawing.Color.White;
            this.radioButtonNegative.Location = new System.Drawing.Point(251, 189);
            this.radioButtonNegative.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(71, 17);
            this.radioButtonNegative.TabIndex = 13;
            this.radioButtonNegative.Text = "Negativo";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            // 
            // labelSentimentType
            // 
            this.labelSentimentType.AutoSize = true;
            this.labelSentimentType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentType.ForeColor = System.Drawing.Color.White;
            this.labelSentimentType.Location = new System.Drawing.Point(66, 190);
            this.labelSentimentType.Name = "labelSentimentType";
            this.labelSentimentType.Size = new System.Drawing.Size(111, 13);
            this.labelSentimentType.TabIndex = 14;
            this.labelSentimentType.Text = "Tipo de Sentimiento";
            // 
            // btnAddSentiment
            // 
            this.btnAddSentiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddSentiment.FlatAppearance.BorderSize = 0;
            this.btnAddSentiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSentiment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSentiment.ForeColor = System.Drawing.Color.White;
            this.btnAddSentiment.Location = new System.Drawing.Point(206, 244);
            this.btnAddSentiment.Name = "btnAddSentiment";
            this.btnAddSentiment.Size = new System.Drawing.Size(75, 30);
            this.btnAddSentiment.TabIndex = 15;
            this.btnAddSentiment.Text = "Ingresar";
            this.btnAddSentiment.UseVisualStyleBackColor = false;
            this.btnAddSentiment.Click += new System.EventHandler(this.btnAddSentiment_Click);
            // 
            // btnCancelAddSentiment
            // 
            this.btnCancelAddSentiment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancelAddSentiment.FlatAppearance.BorderSize = 0;
            this.btnCancelAddSentiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddSentiment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddSentiment.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddSentiment.Location = new System.Drawing.Point(313, 244);
            this.btnCancelAddSentiment.Name = "btnCancelAddSentiment";
            this.btnCancelAddSentiment.Size = new System.Drawing.Size(75, 30);
            this.btnCancelAddSentiment.TabIndex = 16;
            this.btnCancelAddSentiment.Text = "Cancelar";
            this.btnCancelAddSentiment.UseVisualStyleBackColor = false;
            this.btnCancelAddSentiment.Click += new System.EventHandler(this.BtnCancelAddSentiment_Click);
            // 
            // labelSentimentTextException
            // 
            this.labelSentimentTextException.AutoSize = true;
            this.labelSentimentTextException.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentTextException.ForeColor = System.Drawing.Color.Red;
            this.labelSentimentTextException.Location = new System.Drawing.Point(66, 225);
            this.labelSentimentTextException.Name = "labelSentimentTextException";
            this.labelSentimentTextException.Size = new System.Drawing.Size(32, 13);
            this.labelSentimentTextException.TabIndex = 17;
            this.labelSentimentTextException.Text = "Error";
            this.labelSentimentTextException.Visible = false;
            // 
            // labelSentimentTypeException
            // 
            this.labelSentimentTypeException.AutoSize = true;
            this.labelSentimentTypeException.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentTypeException.ForeColor = System.Drawing.Color.Red;
            this.labelSentimentTypeException.Location = new System.Drawing.Point(498, 194);
            this.labelSentimentTypeException.Name = "labelSentimentTypeException";
            this.labelSentimentTypeException.Size = new System.Drawing.Size(32, 13);
            this.labelSentimentTypeException.TabIndex = 18;
            this.labelSentimentTypeException.Text = "Error";
            this.labelSentimentTypeException.Visible = false;
            // 
            // AddSentimentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelSentimentTypeException);
            this.Controls.Add(this.labelSentimentTextException);
            this.Controls.Add(this.btnCancelAddSentiment);
            this.Controls.Add(this.btnAddSentiment);
            this.Controls.Add(this.labelSentimentType);
            this.Controls.Add(this.radioButtonNegative);
            this.Controls.Add(this.radioButtonPositive);
            this.Controls.Add(this.textBoxSentimentText);
            this.Controls.Add(this.labelSentimentText);
            this.Controls.Add(this.labelAddSentimentTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddSentimentView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddSentimentTitle;
        private System.Windows.Forms.Label labelSentimentText;
        private System.Windows.Forms.TextBox textBoxSentimentText;
        private System.Windows.Forms.RadioButton radioButtonPositive;
        private System.Windows.Forms.RadioButton radioButtonNegative;
        private System.Windows.Forms.Label labelSentimentType;
        private System.Windows.Forms.Button btnAddSentiment;
        private System.Windows.Forms.Button btnCancelAddSentiment;
        private System.Windows.Forms.Label labelSentimentTextException;
        private System.Windows.Forms.Label labelSentimentTypeException;
    }
}
