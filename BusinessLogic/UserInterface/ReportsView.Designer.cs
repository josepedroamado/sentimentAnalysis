namespace UserInterface
{
    partial class ReportsView
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
            this.labelReportsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReportsTitle
            // 
            this.labelReportsTitle.AutoSize = true;
            this.labelReportsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportsTitle.ForeColor = System.Drawing.Color.White;
            this.labelReportsTitle.Location = new System.Drawing.Point(65, 22);
            this.labelReportsTitle.Name = "labelReportsTitle";
            this.labelReportsTitle.Size = new System.Drawing.Size(62, 17);
            this.labelReportsTitle.TabIndex = 9;
            this.labelReportsTitle.Text = "Reportes";
            // 
            // ReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelReportsTitle);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReportsTitle;
    }
}
