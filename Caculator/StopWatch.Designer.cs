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
            btnSave = new Button();
            btnReset = new Button();
            timer = new System.Windows.Forms.Timer(components);
            txtTime = new Label();
            dataTime = new DataGridView();
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
            btnOnOff.BackColor = Color.Red;
            btnOnOff.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOnOff.ForeColor = Color.White;
            btnOnOff.Location = new Point(12, 482);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(147, 47);
            btnOnOff.TabIndex = 1;
            btnOnOff.Text = "OFF";
            btnOnOff.UseVisualStyleBackColor = false;
            btnOnOff.Click += buttonOnOff_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 128, 255);
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(348, 482);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 47);
            btnSave.TabIndex = 2;
            btnSave.Text = "💾 Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += buttonSaveTime_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Highlight;
            btnReset.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(640, 482);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(147, 47);
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
            dataTime.Location = new Point(20, 559);
            dataTime.Name = "dataTime";
            dataTime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTime.Size = new Size(767, 150);
            dataTime.TabIndex = 6;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(799, 755);
            Controls.Add(dataTime);
            Controls.Add(txtTime);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(btnOnOff);
            Controls.Add(pictureBox1);
            Name = "StopWatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StopWatch";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnOnOff;
        private Button btnSave;
        private Button btnReset;
        private System.Windows.Forms.Timer timer;
        private ListBox listHistory;
        private Label txtTime;
        private DataGridView dataTime;
        //private ListView listHistory;
    }
}