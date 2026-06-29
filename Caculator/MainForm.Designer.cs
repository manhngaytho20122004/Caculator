namespace Caculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Orchid;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 111);
            label1.TabIndex = 3;
            label1.Text = "Caculator Modal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += btnCaculatorModal_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Orchid;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 149);
            label2.Name = "label2";
            label2.Size = new Size(430, 111);
            label2.TabIndex = 4;
            label2.Text = "Caculator ModeLess";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += btnCaculatorModelLess_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Orchid;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 291);
            label3.Name = "label3";
            label3.Size = new Size(430, 111);
            label3.TabIndex = 5;
            label3.Text = "StopWatch";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += btnStopWatch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 429);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
    }
}