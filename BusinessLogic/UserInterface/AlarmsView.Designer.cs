namespace UserInterface
{
    partial class AlarmsView
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
            this.labelAlarmsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAlarmsTitle
            // 
            this.labelAlarmsTitle.AutoSize = true;
            this.labelAlarmsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmsTitle.ForeColor = System.Drawing.Color.White;
            this.labelAlarmsTitle.Location = new System.Drawing.Point(65, 22);
            this.labelAlarmsTitle.Name = "labelAlarmsTitle";
            this.labelAlarmsTitle.Size = new System.Drawing.Size(121, 17);
            this.labelAlarmsTitle.TabIndex = 8;
            this.labelAlarmsTitle.Text = "Ingreso de Alarma";
            // 
            // AlarmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelAlarmsTitle);
            this.Name = "AlarmsView";
            this.Size = new System.Drawing.Size(674, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlarmsTitle;
    }
}
