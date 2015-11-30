namespace SSProject
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.searchFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.removeObjectButton = new System.Windows.Forms.Button();
            this.addObjectButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TransportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.tankLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.transportTypeLabel = new System.Windows.Forms.Label();
            this.tankTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.transportTypeTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.loadButton);
            this.groupBox2.Controls.Add(this.searchFormButton);
            this.groupBox2.Controls.Add(this.exitButton);
            this.groupBox2.Controls.Add(this.removeObjectButton);
            this.groupBox2.Controls.Add(this.addObjectButton);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transport";
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.Location = new System.Drawing.Point(87, 336);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Location = new System.Drawing.Point(6, 336);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // searchFormButton
            // 
            this.searchFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFormButton.Location = new System.Drawing.Point(391, 48);
            this.searchFormButton.Name = "searchFormButton";
            this.searchFormButton.Size = new System.Drawing.Size(75, 23);
            this.searchFormButton.TabIndex = 14;
            this.searchFormButton.Text = "Search";
            this.searchFormButton.UseVisualStyleBackColor = true;
            this.searchFormButton.Click += new System.EventHandler(this.searchFormButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(391, 336);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // removeObjectButton
            // 
            this.removeObjectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removeObjectButton.Location = new System.Drawing.Point(245, 336);
            this.removeObjectButton.Name = "removeObjectButton";
            this.removeObjectButton.Size = new System.Drawing.Size(75, 23);
            this.removeObjectButton.TabIndex = 6;
            this.removeObjectButton.Text = "Delete";
            this.removeObjectButton.UseVisualStyleBackColor = true;
            this.removeObjectButton.Click += new System.EventHandler(this.removeObjectButton_Click);
            // 
            // addObjectButton
            // 
            this.addObjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addObjectButton.Location = new System.Drawing.Point(391, 19);
            this.addObjectButton.Name = "addObjectButton";
            this.addObjectButton.Size = new System.Drawing.Size(75, 23);
            this.addObjectButton.TabIndex = 5;
            this.addObjectButton.Text = "Add";
            this.addObjectButton.UseVisualStyleBackColor = true;
            this.addObjectButton.Click += new System.EventHandler(this.addObjectButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransportColumn,
            this.distanceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(379, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TransportColumn
            // 
            this.TransportColumn.HeaderText = "Транспорт";
            this.TransportColumn.Name = "TransportColumn";
            this.TransportColumn.ReadOnly = true;
            // 
            // distanceColumn
            // 
            this.distanceColumn.HeaderText = "Расстояние";
            this.distanceColumn.Name = "distanceColumn";
            this.distanceColumn.ReadOnly = true;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoGroupBox.Controls.Add(this.tankLabel);
            this.infoGroupBox.Controls.Add(this.distanceLabel);
            this.infoGroupBox.Controls.Add(this.transportTypeLabel);
            this.infoGroupBox.Controls.Add(this.tankTextBox);
            this.infoGroupBox.Controls.Add(this.distanceTextBox);
            this.infoGroupBox.Controls.Add(this.transportTypeTextBox);
            this.infoGroupBox.Location = new System.Drawing.Point(495, 12);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(232, 372);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Info";
            // 
            // tankLabel
            // 
            this.tankLabel.AutoSize = true;
            this.tankLabel.Location = new System.Drawing.Point(20, 80);
            this.tankLabel.Name = "tankLabel";
            this.tankLabel.Size = new System.Drawing.Size(26, 13);
            this.tankLabel.TabIndex = 5;
            this.tankLabel.Text = "Бак";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(20, 54);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(67, 13);
            this.distanceLabel.TabIndex = 4;
            this.distanceLabel.Text = "Расстояние";
            // 
            // transportTypeLabel
            // 
            this.transportTypeLabel.AutoSize = true;
            this.transportTypeLabel.Location = new System.Drawing.Point(20, 25);
            this.transportTypeLabel.Name = "transportTypeLabel";
            this.transportTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.transportTypeLabel.TabIndex = 3;
            this.transportTypeLabel.Text = "Транспорт";
            // 
            // tankTextBox
            // 
            this.tankTextBox.Location = new System.Drawing.Point(100, 77);
            this.tankTextBox.Name = "tankTextBox";
            this.tankTextBox.ReadOnly = true;
            this.tankTextBox.Size = new System.Drawing.Size(100, 20);
            this.tankTextBox.TabIndex = 2;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(100, 51);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.ReadOnly = true;
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 1;
            // 
            // transportTypeTextBox
            // 
            this.transportTypeTextBox.Location = new System.Drawing.Point(100, 22);
            this.transportTypeTextBox.Name = "transportTypeTextBox";
            this.transportTypeTextBox.ReadOnly = true;
            this.transportTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.transportTypeTextBox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 391);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(606, 358);
            this.Name = "mainForm";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeObjectButton;
        private System.Windows.Forms.Button addObjectButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceColumn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchFormButton;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label tankLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label transportTypeLabel;
        private System.Windows.Forms.TextBox tankTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox transportTypeTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button Save;
    }
}

