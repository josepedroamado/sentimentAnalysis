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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAlarmsTitle = new System.Windows.Forms.Label();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.dataGridViewAlarms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlarmsTitle
            // 
            this.labelAlarmsTitle.AutoSize = true;
            this.labelAlarmsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmsTitle.ForeColor = System.Drawing.Color.White;
            this.labelAlarmsTitle.Location = new System.Drawing.Point(119, 41);
            this.labelAlarmsTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmsTitle.Name = "labelAlarmsTitle";
            this.labelAlarmsTitle.Size = new System.Drawing.Size(101, 31);
            this.labelAlarmsTitle.TabIndex = 9;
            this.labelAlarmsTitle.Text = "Alarmas";
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddAlarm.FlatAppearance.BorderSize = 0;
            this.btnAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlarm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAddAlarm.Location = new System.Drawing.Point(895, 30);
            this.btnAddAlarm.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(138, 55);
            this.btnAddAlarm.TabIndex = 11;
            this.btnAddAlarm.Text = "Agregar";
            this.btnAddAlarm.UseVisualStyleBackColor = false;
            this.btnAddAlarm.Click += new System.EventHandler(this.BtnAddAlarm_Click);
            // 
            // dataGridViewAlarms
            // 
            this.dataGridViewAlarms.AllowUserToAddRows = false;
            this.dataGridViewAlarms.AllowUserToDeleteRows = false;
            this.dataGridViewAlarms.AllowUserToResizeColumns = false;
            this.dataGridViewAlarms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlarms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlarms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridViewAlarms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAlarms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlarms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlarms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAlarms.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewAlarms.Location = new System.Drawing.Point(121, 116);
            this.dataGridViewAlarms.MultiSelect = false;
            this.dataGridViewAlarms.Name = "dataGridViewAlarms";
            this.dataGridViewAlarms.ReadOnly = true;
            this.dataGridViewAlarms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlarms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlarms.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAlarms.RowTemplate.Height = 31;
            this.dataGridViewAlarms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlarms.Size = new System.Drawing.Size(1021, 600);
            this.dataGridViewAlarms.TabIndex = 12;
            // 
            // AlarmsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.dataGridViewAlarms);
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.labelAlarmsTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlarmsView";
            this.Size = new System.Drawing.Size(1236, 834);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlarmsTitle;
        private System.Windows.Forms.Button btnAddAlarm;
        private System.Windows.Forms.DataGridView dataGridViewAlarms;
    }
}
