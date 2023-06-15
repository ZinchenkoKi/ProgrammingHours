using System.Windows.Forms;

namespace HoursOfProgramming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            HoursLabel = new Label();
            MinutesLabel = new Label();
            SecondsLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            this.AllHours = new Label();
            ButtonStart = new Button();
            ButtonClose = new Button();
            Timer = new Timer(components);
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(484, 261);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.555555F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.22222F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.22222F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.22222F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.555555F));
            tableLayoutPanel2.Controls.Add(HoursLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(MinutesLabel, 3, 0);
            tableLayoutPanel2.Controls.Add(SecondsLabel, 5, 0);
            tableLayoutPanel2.Controls.Add(label4, 2, 0);
            tableLayoutPanel2.Controls.Add(label5, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(478, 124);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // HoursLabel
            // 
            HoursLabel.AutoSize = true;
            HoursLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            HoursLabel.Dock = DockStyle.Fill;
            HoursLabel.Font = new System.Drawing.Font("Agency FB", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            HoursLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            HoursLabel.Location = new System.Drawing.Point(29, 0);
            HoursLabel.Name = "HoursLabel";
            HoursLabel.Size = new System.Drawing.Size(100, 124);
            HoursLabel.TabIndex = 0;
            HoursLabel.Text = "00";
            HoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinutesLabel
            // 
            MinutesLabel.AutoSize = true;
            MinutesLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            MinutesLabel.Dock = DockStyle.Fill;
            MinutesLabel.Font = new System.Drawing.Font("Agency FB", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MinutesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            MinutesLabel.Location = new System.Drawing.Point(188, 0);
            MinutesLabel.Name = "MinutesLabel";
            MinutesLabel.Size = new System.Drawing.Size(100, 124);
            MinutesLabel.TabIndex = 1;
            MinutesLabel.Text = "00";
            MinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondsLabel
            // 
            SecondsLabel.AutoSize = true;
            SecondsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            SecondsLabel.Dock = DockStyle.Fill;
            SecondsLabel.Font = new System.Drawing.Font("Agency FB", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SecondsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            SecondsLabel.Location = new System.Drawing.Point(347, 0);
            SecondsLabel.Name = "SecondsLabel";
            SecondsLabel.Size = new System.Drawing.Size(100, 124);
            SecondsLabel.TabIndex = 2;
            SecondsLabel.Text = "00";
            SecondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Dock = DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label4.Location = new System.Drawing.Point(135, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 124);
            label4.TabIndex = 3;
            label4.Text = "~";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label5.Dock = DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label5.Location = new System.Drawing.Point(294, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 124);
            label5.TabIndex = 4;
            label5.Text = "~";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Controls.Add(ButtonStart, 0, 0);
            tableLayoutPanel3.Controls.Add(ButtonClose, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 133);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(478, 125);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(this.AllHours, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(162, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(153, 119);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label6.Dock = DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(147, 59);
            label6.TabIndex = 0;
            label6.Text = "HOP";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaximumHours
            // 
            this.AllHours.AutoSize = true;
            this.AllHours.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllHours.Dock = DockStyle.Fill;
            this.AllHours.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllHours.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllHours.Location = new System.Drawing.Point(3, 59);
            this.AllHours.Name = "MaximumHours";
            this.AllHours.Size = new System.Drawing.Size(147, 60);
            this.AllHours.TabIndex = 1;
            this.AllHours.Text = "00";
            this.AllHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            ButtonStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ButtonStart.Dock = DockStyle.Fill;
            ButtonStart.FlatAppearance.BorderSize = 0;
            ButtonStart.FlatStyle = FlatStyle.Flat;
            ButtonStart.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ButtonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ButtonStart.Location = new System.Drawing.Point(3, 3);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new System.Drawing.Size(153, 119);
            ButtonStart.TabIndex = 1;
            ButtonStart.Text = "START";
            ButtonStart.UseVisualStyleBackColor = false;
            ButtonStart.Click += StopwatchStart;
            // 
            // ButtonClose
            // 
            ButtonClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ButtonClose.Dock = DockStyle.Fill;
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ButtonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            ButtonClose.Location = new System.Drawing.Point(321, 3);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new System.Drawing.Size(154, 119);
            ButtonClose.TabIndex = 2;
            ButtonClose.Text = "EXIT";
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += CloseApplication;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += TimerTick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(484, 261);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(500, 300);
            Name = "Form1";
            Text = "HOP";
            Load += FormLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label HoursLabel;
        private Label MinutesLabel;
        private Label SecondsLabel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label AllHours;
        private Button ButtonStart;
        private Button ButtonClose;
        private System.Windows.Forms.Timer Timer;
        private OpenFileDialog openFileDialog1;
    }
}