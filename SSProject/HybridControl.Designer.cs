﻿namespace SSProject
{
    partial class HybridControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fuelTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capacitorTextBox = new System.Windows.Forms.TextBox();
            this.fuelLevelTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.fuelOnKillometersTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // fuelTrackBar
            // 
            this.fuelTrackBar.LargeChange = 1;
            this.fuelTrackBar.Location = new System.Drawing.Point(147, 107);
            this.fuelTrackBar.Maximum = 400;
            this.fuelTrackBar.Name = "fuelTrackBar";
            this.fuelTrackBar.Size = new System.Drawing.Size(100, 42);
            this.fuelTrackBar.TabIndex = 15;
            this.fuelTrackBar.Scroll += new System.EventHandler(this.fuelTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Конденсатор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Заполненность бака(л)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Расстояние(км)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Затраты топлива(л/100км)";
            // 
            // capacitorTextBox
            // 
            this.capacitorTextBox.Location = new System.Drawing.Point(147, 55);
            this.capacitorTextBox.Name = "capacitorTextBox";
            this.capacitorTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacitorTextBox.TabIndex = 14;
            this.capacitorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacitorTextBox_KeyPress);
            // 
            // fuelLevelTextBox
            // 
            this.fuelLevelTextBox.Location = new System.Drawing.Point(147, 81);
            this.fuelLevelTextBox.Name = "fuelLevelTextBox";
            this.fuelLevelTextBox.ReadOnly = true;
            this.fuelLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelLevelTextBox.TabIndex = 13;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(147, 29);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 12;
            this.distanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distanceTextBox_KeyPress);
            // 
            // fuelOnKillometersTextBox
            // 
            this.fuelOnKillometersTextBox.Location = new System.Drawing.Point(147, 3);
            this.fuelOnKillometersTextBox.Name = "fuelOnKillometersTextBox";
            this.fuelOnKillometersTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelOnKillometersTextBox.TabIndex = 11;
            this.fuelOnKillometersTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fuelOnKillometersTextBox_KeyPress);
            // 
            // HybridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fuelTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capacitorTextBox);
            this.Controls.Add(this.fuelLevelTextBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.fuelOnKillometersTextBox);
            this.Name = "HybridControl";
            this.Size = new System.Drawing.Size(251, 140);
            ((System.ComponentModel.ISupportInitialize)(this.fuelTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar fuelTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacitorTextBox;
        private System.Windows.Forms.TextBox fuelLevelTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox fuelOnKillometersTextBox;
    }
}
