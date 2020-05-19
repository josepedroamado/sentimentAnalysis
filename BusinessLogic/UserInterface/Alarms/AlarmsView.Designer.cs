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
            this.listBoxEntities = new System.Windows.Forms.ListBox();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAlarmsTitle
            // 
            this.labelAlarmsTitle.AutoSize = true;
            this.labelAlarmsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmsTitle.ForeColor = System.Drawing.Color.White;
            this.labelAlarmsTitle.Location = new System.Drawing.Point(130, 42);
            this.labelAlarmsTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmsTitle.Name = "labelAlarmsTitle";
            this.labelAlarmsTitle.Size = new System.Drawing.Size(113, 36);
            this.labelAlarmsTitle.TabIndex = 9;
            this.labelAlarmsTitle.Text = "Alarmas";
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
            this.listBoxEntities.TabIndex = 10;
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddAlarm.FlatAppearance.BorderSize = 0;
            this.btnAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlarm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAddAlarm.Location = new System.Drawing.Point(976, 31);
            this.btnAddAlarm.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(150, 58);
            this.btnAddAlarm.TabIndex = 11;
            this.btnAddAlarm.Text = "Agregar";
            this.btnAddAlarm.UseVisualStyleBackColor = false;
            this.btnAddAlarm.Click += new System.EventHandler(this.BtnAddAlarm_Click);
            // 
            // AlarmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.listBoxEntities);
            this.Controls.Add(this.labelAlarmsTitle);
            this.Name = "AlarmsView";
            this.Size = new System.Drawing.Size(1348, 869);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlarmsTitle;
        private System.Windows.Forms.ListBox listBoxEntities;
        private System.Windows.Forms.Button btnAddAlarm;
    }
}
