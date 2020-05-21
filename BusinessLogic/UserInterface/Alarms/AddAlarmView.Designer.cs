namespace UserInterface
{
    partial class AddAlarmView
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
            this.labelAddAlarmTitle = new System.Windows.Forms.Label();
            this.labelEntity = new System.Windows.Forms.Label();
            this.comboBoxEntity = new System.Windows.Forms.ComboBox();
            this.labelAlarmType = new System.Windows.Forms.Label();
            this.labelPostsQuantity = new System.Windows.Forms.Label();
            this.numericUpDownPosts = new System.Windows.Forms.NumericUpDown();
            this.labelAlarmTime = new System.Windows.Forms.Label();
            this.numericUpDownAlarmTime = new System.Windows.Forms.NumericUpDown();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.btnCancelAddAlarm = new System.Windows.Forms.Button();
            this.radioButtonHours = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.labelAlarmEntityException = new System.Windows.Forms.Label();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.groupBoxAlarmType = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmTime)).BeginInit();
            this.groupBoxAlarmType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAddAlarmTitle
            // 
            this.labelAddAlarmTitle.AutoSize = true;
            this.labelAddAlarmTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAlarmTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddAlarmTitle.Location = new System.Drawing.Point(130, 42);
            this.labelAddAlarmTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddAlarmTitle.Name = "labelAddAlarmTitle";
            this.labelAddAlarmTitle.Size = new System.Drawing.Size(237, 36);
            this.labelAddAlarmTitle.TabIndex = 8;
            this.labelAddAlarmTitle.Text = "Ingreso de Alarma";
            // 
            // labelEntity
            // 
            this.labelEntity.AutoSize = true;
            this.labelEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntity.ForeColor = System.Drawing.Color.White;
            this.labelEntity.Location = new System.Drawing.Point(130, 150);
            this.labelEntity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEntity.Name = "labelEntity";
            this.labelEntity.Size = new System.Drawing.Size(85, 30);
            this.labelEntity.TabIndex = 9;
            this.labelEntity.Text = "Entidad";
            // 
            // comboBoxEntity
            // 
            this.comboBoxEntity.BackColor = System.Drawing.Color.White;
            this.comboBoxEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEntity.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEntity.FormattingEnabled = true;
            this.comboBoxEntity.Location = new System.Drawing.Point(376, 142);
            this.comboBoxEntity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxEntity.Name = "comboBoxEntity";
            this.comboBoxEntity.Size = new System.Drawing.Size(400, 38);
            this.comboBoxEntity.TabIndex = 10;
            // 
            // labelAlarmType
            // 
            this.labelAlarmType.AutoSize = true;
            this.labelAlarmType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmType.ForeColor = System.Drawing.Color.White;
            this.labelAlarmType.Location = new System.Drawing.Point(131, 320);
            this.labelAlarmType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmType.Name = "labelAlarmType";
            this.labelAlarmType.Size = new System.Drawing.Size(161, 30);
            this.labelAlarmType.TabIndex = 11;
            this.labelAlarmType.Text = "Tipo de Alarma";
            // 
            // labelPostsQuantity
            // 
            this.labelPostsQuantity.AutoSize = true;
            this.labelPostsQuantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostsQuantity.ForeColor = System.Drawing.Color.White;
            this.labelPostsQuantity.Location = new System.Drawing.Point(130, 204);
            this.labelPostsQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPostsQuantity.Name = "labelPostsQuantity";
            this.labelPostsQuantity.Size = new System.Drawing.Size(185, 30);
            this.labelPostsQuantity.TabIndex = 13;
            this.labelPostsQuantity.Text = "Cantidad de Posts";
            // 
            // numericUpDownPosts
            // 
            this.numericUpDownPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownPosts.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPosts.Location = new System.Drawing.Point(374, 198);
            this.numericUpDownPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPosts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPosts.Name = "numericUpDownPosts";
            this.numericUpDownPosts.Size = new System.Drawing.Size(400, 35);
            this.numericUpDownPosts.TabIndex = 14;
            this.numericUpDownPosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPosts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAlarmTime
            // 
            this.labelAlarmTime.AutoSize = true;
            this.labelAlarmTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmTime.ForeColor = System.Drawing.Color.White;
            this.labelAlarmTime.Location = new System.Drawing.Point(130, 263);
            this.labelAlarmTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmTime.Name = "labelAlarmTime";
            this.labelAlarmTime.Size = new System.Drawing.Size(175, 30);
            this.labelAlarmTime.TabIndex = 15;
            this.labelAlarmTime.Text = "Plazo de Tiempo";
            // 
            // numericUpDownAlarmTime
            // 
            this.numericUpDownAlarmTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAlarmTime.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAlarmTime.Location = new System.Drawing.Point(374, 258);
            this.numericUpDownAlarmTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownAlarmTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAlarmTime.Name = "numericUpDownAlarmTime";
            this.numericUpDownAlarmTime.Size = new System.Drawing.Size(400, 35);
            this.numericUpDownAlarmTime.TabIndex = 16;
            this.numericUpDownAlarmTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAlarmTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddAlarm.FlatAppearance.BorderSize = 0;
            this.btnAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlarm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAddAlarm.Location = new System.Drawing.Point(412, 469);
            this.btnAddAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(150, 58);
            this.btnAddAlarm.TabIndex = 18;
            this.btnAddAlarm.Text = "Ingresar";
            this.btnAddAlarm.UseVisualStyleBackColor = false;
            this.btnAddAlarm.Click += new System.EventHandler(this.BtnAddAlarm_Click);
            // 
            // btnCancelAddAlarm
            // 
            this.btnCancelAddAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancelAddAlarm.FlatAppearance.BorderSize = 0;
            this.btnCancelAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAddAlarm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddAlarm.ForeColor = System.Drawing.Color.White;
            this.btnCancelAddAlarm.Location = new System.Drawing.Point(626, 469);
            this.btnCancelAddAlarm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelAddAlarm.Name = "btnCancelAddAlarm";
            this.btnCancelAddAlarm.Size = new System.Drawing.Size(150, 58);
            this.btnCancelAddAlarm.TabIndex = 19;
            this.btnCancelAddAlarm.Text = "Cancelar";
            this.btnCancelAddAlarm.UseVisualStyleBackColor = false;
            this.btnCancelAddAlarm.Click += new System.EventHandler(this.BtnCancelAddAlarm_Click);
            // 
            // radioButtonHours
            // 
            this.radioButtonHours.AutoSize = true;
            this.radioButtonHours.Checked = true;
            this.radioButtonHours.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHours.ForeColor = System.Drawing.Color.White;
            this.radioButtonHours.Location = new System.Drawing.Point(806, 263);
            this.radioButtonHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(95, 34);
            this.radioButtonHours.TabIndex = 20;
            this.radioButtonHours.TabStop = true;
            this.radioButtonHours.Text = "horas";
            this.radioButtonHours.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDays.ForeColor = System.Drawing.Color.White;
            this.radioButtonDays.Location = new System.Drawing.Point(922, 262);
            this.radioButtonDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(81, 34);
            this.radioButtonDays.TabIndex = 21;
            this.radioButtonDays.Text = "días";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // labelAlarmEntityException
            // 
            this.labelAlarmEntityException.AutoSize = true;
            this.labelAlarmEntityException.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmEntityException.ForeColor = System.Drawing.Color.Red;
            this.labelAlarmEntityException.Location = new System.Drawing.Point(802, 150);
            this.labelAlarmEntityException.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmEntityException.Name = "labelAlarmEntityException";
            this.labelAlarmEntityException.Size = new System.Drawing.Size(65, 30);
            this.labelAlarmEntityException.TabIndex = 22;
            this.labelAlarmEntityException.Text = "Error";
            this.labelAlarmEntityException.Visible = false;
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Checked = true;
            this.radioButtonPositive.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonPositive.Location = new System.Drawing.Point(52, 25);
            this.radioButtonPositive.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(119, 29);
            this.radioButtonPositive.TabIndex = 23;
            this.radioButtonPositive.TabStop = true;
            this.radioButtonPositive.Text = "Positiva";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonNegative.Location = new System.Drawing.Point(229, 25);
            this.radioButtonNegative.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonNegative.Size = new System.Drawing.Size(128, 29);
            this.radioButtonNegative.TabIndex = 24;
            this.radioButtonNegative.TabStop = true;
            this.radioButtonNegative.Text = "Negativa";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            // 
            // groupBoxAlarmType
            // 
            this.groupBoxAlarmType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAlarmType.Controls.Add(this.radioButtonPositive);
            this.groupBoxAlarmType.Controls.Add(this.radioButtonNegative);
            this.groupBoxAlarmType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAlarmType.Location = new System.Drawing.Point(374, 307);
            this.groupBoxAlarmType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAlarmType.Name = "groupBoxAlarmType";
            this.groupBoxAlarmType.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBoxAlarmType.Size = new System.Drawing.Size(400, 66);
            this.groupBoxAlarmType.TabIndex = 25;
            this.groupBoxAlarmType.TabStop = false;
            // 
            // AddAlarmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.groupBoxAlarmType);
            this.Controls.Add(this.labelAlarmEntityException);
            this.Controls.Add(this.radioButtonDays);
            this.Controls.Add(this.radioButtonHours);
            this.Controls.Add(this.btnCancelAddAlarm);
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.numericUpDownAlarmTime);
            this.Controls.Add(this.labelAlarmTime);
            this.Controls.Add(this.numericUpDownPosts);
            this.Controls.Add(this.labelPostsQuantity);
            this.Controls.Add(this.labelAlarmType);
            this.Controls.Add(this.comboBoxEntity);
            this.Controls.Add(this.labelEntity);
            this.Controls.Add(this.labelAddAlarmTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddAlarmView";
            this.Size = new System.Drawing.Size(1348, 869);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmTime)).EndInit();
            this.groupBoxAlarmType.ResumeLayout(false);
            this.groupBoxAlarmType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddAlarmTitle;
        private System.Windows.Forms.Label labelEntity;
        private System.Windows.Forms.ComboBox comboBoxEntity;
        private System.Windows.Forms.Label labelAlarmType;
        private System.Windows.Forms.Label labelPostsQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownPosts;
        private System.Windows.Forms.Label labelAlarmTime;
        private System.Windows.Forms.NumericUpDown numericUpDownAlarmTime;
        private System.Windows.Forms.Button btnAddAlarm;
        private System.Windows.Forms.Button btnCancelAddAlarm;
        private System.Windows.Forms.RadioButton radioButtonHours;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.Label labelAlarmEntityException;
        private System.Windows.Forms.RadioButton radioButtonPositive;
        private System.Windows.Forms.RadioButton radioButtonNegative;
        private System.Windows.Forms.GroupBox groupBoxAlarmType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
