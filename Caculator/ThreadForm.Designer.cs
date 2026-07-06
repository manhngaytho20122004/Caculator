namespace Caculator
{
    partial class ThreadForm
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
            prAW = new ProgressBar();
            prTask = new ProgressBar();
            prThread = new ProgressBar();
            btnStart_Thread = new Button();
            btn_StopThread = new Button();
            btnStartAW = new Button();
            bntStopAW = new Button();
            btnStartTask = new Button();
            btnStopTask = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // prAW
            // 
            prAW.Location = new Point(56, 171);
            prAW.Name = "prAW";
            prAW.Size = new Size(674, 50);
            prAW.TabIndex = 0;
            // 
            // prTask
            // 
            prTask.Location = new Point(56, 325);
            prTask.Name = "prTask";
            prTask.Size = new Size(674, 50);
            prTask.TabIndex = 1;
            // 
            // prThread
            // 
            prThread.Location = new Point(56, 24);
            prThread.Name = "prThread";
            prThread.Size = new Size(674, 50);
            prThread.TabIndex = 2;
            // 
            // btnStart_Thread
            // 
            btnStart_Thread.BackColor = Color.LimeGreen;
            btnStart_Thread.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStart_Thread.ForeColor = Color.White;
            btnStart_Thread.Location = new Point(208, 105);
            btnStart_Thread.Name = "btnStart_Thread";
            btnStart_Thread.Size = new Size(107, 43);
            btnStart_Thread.TabIndex = 3;
            btnStart_Thread.Text = "Start ";
            btnStart_Thread.UseVisualStyleBackColor = false;
            btnStart_Thread.Click += StartThread_Click;
            // 
            // btn_StopThread
            // 
            btn_StopThread.BackColor = Color.Red;
            btn_StopThread.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_StopThread.ForeColor = Color.White;
            btn_StopThread.Location = new Point(441, 105);
            btn_StopThread.Name = "btn_StopThread";
            btn_StopThread.Size = new Size(107, 43);
            btn_StopThread.TabIndex = 4;
            btn_StopThread.Text = "Stop";
            btn_StopThread.UseVisualStyleBackColor = false;
            btn_StopThread.Click += StopThread_Click;
            // 
            // btnStartAW
            // 
            btnStartAW.BackColor = Color.LimeGreen;
            btnStartAW.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStartAW.ForeColor = Color.White;
            btnStartAW.Location = new Point(208, 249);
            btnStartAW.Name = "btnStartAW";
            btnStartAW.Size = new Size(107, 43);
            btnStartAW.TabIndex = 5;
            btnStartAW.Text = "Start";
            btnStartAW.UseVisualStyleBackColor = false;
            btnStartAW.Click += StartAW_Click;
            // 
            // bntStopAW
            // 
            bntStopAW.BackColor = Color.Red;
            bntStopAW.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bntStopAW.ForeColor = Color.White;
            bntStopAW.Location = new Point(441, 249);
            bntStopAW.Name = "bntStopAW";
            bntStopAW.Size = new Size(107, 43);
            bntStopAW.TabIndex = 6;
            bntStopAW.Text = "Stop";
            bntStopAW.UseVisualStyleBackColor = false;
            bntStopAW.Click += StopAW_Click;
            // 
            // btnStartTask
            // 
            btnStartTask.BackColor = Color.LimeGreen;
            btnStartTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStartTask.ForeColor = Color.White;
            btnStartTask.Location = new Point(208, 395);
            btnStartTask.Name = "btnStartTask";
            btnStartTask.Size = new Size(107, 43);
            btnStartTask.TabIndex = 7;
            btnStartTask.Text = "Start";
            btnStartTask.UseVisualStyleBackColor = false;
            btnStartTask.Click += StartTask_Click;
            // 
            // btnStopTask
            // 
            btnStopTask.BackColor = Color.Red;
            btnStopTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStopTask.ForeColor = Color.White;
            btnStopTask.Location = new Point(441, 395);
            btnStopTask.Name = "btnStopTask";
            btnStopTask.Size = new Size(107, 43);
            btnStopTask.TabIndex = 8;
            btnStopTask.Text = "Stop";
            btnStopTask.UseVisualStyleBackColor = false;
            btnStopTask.Click += StopTask_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ThreadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(btnStopTask);
            Controls.Add(btnStartTask);
            Controls.Add(bntStopAW);
            Controls.Add(btnStartAW);
            Controls.Add(btn_StopThread);
            Controls.Add(btnStart_Thread);
            Controls.Add(prThread);
            Controls.Add(prTask);
            Controls.Add(prAW);
            Name = "ThreadForm";
            Text = "ThreadForm";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar prAW;
        private ProgressBar prTask;
        private ProgressBar prThread;
        private Button btnStart_Thread;
        private Button btn_StopThread;
        private Button btnStartAW;
        private Button bntStopAW;
        private Button btnStartTask;
        private Button btnStopTask;
        private FileSystemWatcher fileSystemWatcher1;
    }
}