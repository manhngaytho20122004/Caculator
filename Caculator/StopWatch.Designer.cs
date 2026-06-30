namespace Caculator
{
    partial class StopWatch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch));
            pictureBox1 = new PictureBox();
            btnOnOff = new Button();
            btnSaveFile = new Button();
            btnReset = new Button();
            timer = new System.Windows.Forms.Timer(components);
            txtTime = new Label();
            dataTime = new DataGridView();
            hr = new Label();
            label2 = new Label();
            label3 = new Label();
            cbFile = new ComboBox();
            bntImport = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataTime).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 594);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnOnOff
            // 
            btnOnOff.BackColor = Color.LimeGreen;
            btnOnOff.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnOnOff.ForeColor = Color.White;
            btnOnOff.Location = new Point(142, 479);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(131, 37);
            btnOnOff.TabIndex = 1;
            btnOnOff.Text = "Start";
            btnOnOff.UseVisualStyleBackColor = false;
            btnOnOff.Click += buttonOnOff_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.FromArgb(128, 128, 255);
            btnSaveFile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSaveFile.ForeColor = Color.White;
            btnSaveFile.Location = new Point(369, 535);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(131, 37);
            btnSaveFile.TabIndex = 2;
            btnSaveFile.Text = "💾 Save";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += button_SaveFile_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Highlight;
            btnReset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(577, 479);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 37);
            btnReset.TabIndex = 3;
            btnReset.Text = "🔄 Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += buttonReset_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // txtTime
            // 
            txtTime.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(189, 171);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(445, 142);
            txtTime.TabIndex = 5;
            txtTime.Text = "00:00:00.00";
            txtTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataTime
            // 
            dataTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTime.BackgroundColor = Color.LavenderBlush;
            dataTime.BorderStyle = BorderStyle.None;
            dataTime.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTime.GridColor = Color.White;
            dataTime.Location = new Point(12, 593);
            dataTime.Name = "dataTime";
            dataTime.RowHeadersVisible = false;
            dataTime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTime.Size = new Size(775, 150);
            dataTime.TabIndex = 6;
            // 
            // hr
            // 
            hr.AutoSize = true;
            hr.Location = new Point(271, 279);
            hr.Name = "hr";
            hr.Size = new Size(18, 15);
            hr.TabIndex = 7;
            hr.Text = "hr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 279);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 8;
            label2.Text = "min";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 279);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 9;
            label3.Text = "sec";
            // 
            // cbFile
            // 
            cbFile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFile.FormattingEnabled = true;
            cbFile.Items.AddRange(new object[] { ".txt", ".csv", ".ini", ".json" });
            cbFile.Location = new Point(577, 539);
            cbFile.Name = "cbFile";
            cbFile.Size = new Size(131, 33);
            cbFile.TabIndex = 10;
            // 
            // bntImport
            // 
            bntImport.BackColor = Color.OliveDrab;
            bntImport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            bntImport.ForeColor = Color.White;
            bntImport.Location = new Point(142, 535);
            bntImport.Name = "bntImport";
            bntImport.Size = new Size(131, 37);
            bntImport.TabIndex = 11;
            bntImport.Text = "Open File";
            bntImport.UseVisualStyleBackColor = false;
            bntImport.Click += button_OpenFile_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 0);
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(369, 479);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 37);
            btnSave.TabIndex = 12;
            btnSave.Text = "🚩Flag";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += buttonSaveTime_Click;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(799, 755);
            Controls.Add(btnSave);
            Controls.Add(bntImport);
            Controls.Add(cbFile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(hr);
            Controls.Add(dataTime);
            Controls.Add(txtTime);
            Controls.Add(btnReset);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOnOff);
            Controls.Add(pictureBox1);
            Name = "StopWatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StopWatch";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnOnOff;
        private Button btnSaveFile;
        private Button btnReset;
        private System.Windows.Forms.Timer timer;
        private ListBox listHistory;
        private Label txtTime;
        private DataGridView dataTime;
        private Label hr;
        private Label label2;
        private Label label3;
        private ComboBox cbFile;
        private Button bntImport;
        private Button btnSave;
        //private ListView listHistory;
    }
}