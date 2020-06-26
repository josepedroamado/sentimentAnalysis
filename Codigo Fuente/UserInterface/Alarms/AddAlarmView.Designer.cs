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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxAlarmType = new System.Windows.Forms.ComboBox();
            this.comboBoxPhrasesType = new System.Windows.Forms.ComboBox();
            this.labelPhrasesType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmTime)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddAlarmTitle
            // 
            this.labelAddAlarmTitle.AutoSize = true;
            this.labelAddAlarmTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAlarmTitle.ForeColor = System.Drawing.Color.White;
            this.labelAddAlarmTitle.Location = new System.Drawing.Point(119, 40);
            this.labelAddAlarmTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddAlarmTitle.Name = "labelAddAlarmTitle";
            this.labelAddAlarmTitle.Size = new System.Drawing.Size(209, 31);
            this.labelAddAlarmTitle.TabIndex = 8;
            this.labelAddAlarmTitle.Text = "Ingreso de Alarma";
            // 
            // labelEntity
            // 
            this.labelEntity.AutoSize = true;
            this.labelEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntity.ForeColor = System.Drawing.Color.White;
            this.labelEntity.Location = new System.Drawing.Point(119, 144);
            this.labelEntity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEntity.Name = "labelEntity";
            this.labelEntity.Size = new System.Drawing.Size(79, 28);
            this.labelEntity.TabIndex = 9;
            this.labelEntity.Text = "Entidad";
            // 
            // comboBoxEntity
            // 
            this.comboBoxEntity.BackColor = System.Drawing.Color.White;
            this.comboBoxEntity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEntity.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEntity.FormattingEnabled = true;
            this.comboBoxEntity.Location = new System.Drawing.Point(345, 136);
            this.comboBoxEntity.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxEntity.Name = "comboBoxEntity";
            this.comboBoxEntity.Size = new System.Drawing.Size(367, 33);
            this.comboBoxEntity.TabIndex = 10;
            // 
            // labelAlarmType
            // 
            this.labelAlarmType.AutoSize = true;
            this.labelAlarmType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmType.ForeColor = System.Drawing.Color.White;
            this.labelAlarmType.Location = new System.Drawing.Point(120, 307);
            this.labelAlarmType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmType.Name = "labelAlarmType";
            this.labelAlarmType.Size = new System.Drawing.Size(145, 28);
            this.labelAlarmType.TabIndex = 11;
            this.labelAlarmType.Text = "Tipo de Alarma";
            // 
            // labelPostsQuantity
            // 
            this.labelPostsQuantity.AutoSize = true;
            this.labelPostsQuantity.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostsQuantity.ForeColor = System.Drawing.Color.White;
            this.labelPostsQuantity.Location = new System.Drawing.Point(119, 196);
            this.labelPostsQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPostsQuantity.Name = "labelPostsQuantity";
            this.labelPostsQuantity.Size = new System.Drawing.Size(168, 28);
            this.labelPostsQuantity.TabIndex = 13;
            this.labelPostsQuantity.Text = "Cantidad de Posts";
            // 
            // numericUpDownPosts
            // 
            this.numericUpDownPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownPosts.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPosts.Location = new System.Drawing.Point(343, 190);
            this.numericUpDownPosts.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPosts.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPosts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPosts.Name = "numericUpDownPosts";
            this.numericUpDownPosts.Size = new System.Drawing.Size(367, 32);
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
            this.labelAlarmTime.Location = new System.Drawing.Point(119, 252);
            this.labelAlarmTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmTime.Name = "labelAlarmTime";
            this.labelAlarmTime.Size = new System.Drawing.Size(157, 28);
            this.labelAlarmTime.TabIndex = 15;
            this.labelAlarmTime.Text = "Plazo de Tiempo";
            // 
            // numericUpDownAlarmTime
            // 
            this.numericUpDownAlarmTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAlarmTime.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAlarmTime.Location = new System.Drawing.Point(343, 248);
            this.numericUpDownAlarmTime.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAlarmTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAlarmTime.Name = "numericUpDownAlarmTime";
            this.numericUpDownAlarmTime.Size = new System.Drawing.Size(367, 32);
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
            this.btnAddAlarm.Location = new System.Drawing.Point(378, 450);
            this.btnAddAlarm.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(138, 56);
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
            this.btnCancelAddAlarm.Location = new System.Drawing.Point(574, 450);
            this.btnCancelAddAlarm.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelAddAlarm.Name = "btnCancelAddAlarm";
            this.btnCancelAddAlarm.Size = new System.Drawing.Size(138, 56);
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
            this.radioButtonHours.Location = new System.Drawing.Point(739, 252);
            this.radioButtonHours.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(84, 29);
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
            this.radioButtonDays.Location = new System.Drawing.Point(845, 252);
            this.radioButtonDays.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(71, 29);
            this.radioButtonDays.TabIndex = 21;
            this.radioButtonDays.Text = "días";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // labelAlarmEntityException
            // 
            this.labelAlarmEntityException.AutoSize = true;
            this.labelAlarmEntityException.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmEntityException.ForeColor = System.Drawing.Color.Red;
            this.labelAlarmEntityException.Location = new System.Drawing.Point(120, 423);
            this.labelAlarmEntityException.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlarmEntityException.Name = "labelAlarmEntityException";
            this.labelAlarmEntityException.Size = new System.Drawing.Size(59, 28);
            this.labelAlarmEntityException.TabIndex = 22;
            this.labelAlarmEntityException.Text = "Error";
            this.labelAlarmEntityException.Visible = false;
            // 
            // comboBoxAlarmType
            // 
            this.comboBoxAlarmType.BackColor = System.Drawing.Color.White;
            this.comboBoxAlarmType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlarmType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxAlarmType.FormattingEnabled = true;
            this.comboBoxAlarmType.Location = new System.Drawing.Point(345, 307);
            this.comboBoxAlarmType.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxAlarmType.Name = "comboBoxAlarmType";
            this.comboBoxAlarmType.Size = new System.Drawing.Size(367, 33);
            this.comboBoxAlarmType.TabIndex = 26;
            this.comboBoxAlarmType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAlarmType_SelectedIndexChanged);
            // 
            // comboBoxPhrasesType
            // 
            this.comboBoxPhrasesType.BackColor = System.Drawing.Color.White;
            this.comboBoxPhrasesType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPhrasesType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPhrasesType.FormattingEnabled = true;
            this.comboBoxPhrasesType.Location = new System.Drawing.Point(345, 363);
            this.comboBoxPhrasesType.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxPhrasesType.Name = "comboBoxPhrasesType";
            this.comboBoxPhrasesType.Size = new System.Drawing.Size(367, 33);
            this.comboBoxPhrasesType.TabIndex = 28;
            // 
            // labelPhrasesType
            // 
            this.labelPhrasesType.AutoSize = true;
            this.labelPhrasesType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhrasesType.ForeColor = System.Drawing.Color.White;
            this.labelPhrasesType.Location = new System.Drawing.Point(120, 363);
            this.labelPhrasesType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhrasesType.Name = "labelPhrasesType";
            this.labelPhrasesType.Size = new System.Drawing.Size(136, 28);
            this.labelPhrasesType.TabIndex = 27;
            this.labelPhrasesType.Text = "Tipo de Frases";
            // 
            // AddAlarmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.comboBoxPhrasesType);
            this.Controls.Add(this.labelPhrasesType);
            this.Controls.Add(this.comboBoxAlarmType);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddAlarmView";
            this.Size = new System.Drawing.Size(1236, 834);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmTime)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxAlarmType;
        private System.Windows.Forms.ComboBox comboBoxPhrasesType;
        private System.Windows.Forms.Label labelPhrasesType;
    }
}
