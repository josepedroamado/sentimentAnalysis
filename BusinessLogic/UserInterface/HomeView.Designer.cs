namespace UserInterface
{
    partial class HomeView
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
            this.labelMainWindowTitle = new System.Windows.Forms.Label();
            this.labelMainWindowBody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMainWindowTitle
            // 
            this.labelMainWindowTitle.AutoSize = true;
            this.labelMainWindowTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowTitle.ForeColor = System.Drawing.Color.White;
            this.labelMainWindowTitle.Location = new System.Drawing.Point(169, 62);
            this.labelMainWindowTitle.Name = "labelMainWindowTitle";
            this.labelMainWindowTitle.Size = new System.Drawing.Size(333, 30);
            this.labelMainWindowTitle.TabIndex = 1;
            this.labelMainWindowTitle.Text = "Bienvenido a Sentiment Analysis";
            // 
            // labelMainWindowBody
            // 
            this.labelMainWindowBody.AutoSize = true;
            this.labelMainWindowBody.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowBody.ForeColor = System.Drawing.Color.White;
            this.labelMainWindowBody.Location = new System.Drawing.Point(146, 189);
            this.labelMainWindowBody.Name = "labelMainWindowBody";
            this.labelMainWindowBody.Size = new System.Drawing.Size(373, 13);
            this.labelMainWindowBody.TabIndex = 2;
            this.labelMainWindowBody.Text = "Seleccione una opcion del menu ubicado a la izquierda para continuar.\r\n";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelMainWindowBody);
            this.Controls.Add(this.labelMainWindowTitle);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainWindowTitle;
        private System.Windows.Forms.Label labelMainWindowBody;
    }
}
