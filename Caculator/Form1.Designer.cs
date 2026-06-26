namespace Caculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnExit = new Button();
            button4 = new Button();
            btnPow = new Button();
            btnSqrt = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            btn8 = new Button();
            btn4 = new Button();
            btnSum = new Button();
            btnSuv = new Button();
            btnDelete = new Button();
            btnResult = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnNegative = new Button();
            btnDeleteAll = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            txtInput = new Label();
            txtHistory = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnPow);
            panel1.Controls.Add(btnSqrt);
            panel1.Controls.Add(btnMulti);
            panel1.Controls.Add(btnDiv);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btnSum);
            panel1.Controls.Add(btnSuv);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btnDot);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btnNegative);
            panel1.Controls.Add(btnDeleteAll);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 506);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI", 24F);
            btnExit.Location = new Point(351, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 76);
            btnExit.TabIndex = 23;
            btnExit.Text = " ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Font = new Font("Segoe UI", 24F);
            button4.Location = new Point(237, 85);
            button4.Name = "button4";
            button4.Size = new Size(108, 76);
            button4.TabIndex = 22;
            button4.Text = "1/x";
            button4.UseVisualStyleBackColor = false;
            button4.Click += ButtonResult_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Transparent;
            btnPow.BackgroundImageLayout = ImageLayout.Zoom;
            btnPow.Font = new Font("Segoe UI", 24F);
            btnPow.Location = new Point(123, 85);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(108, 76);
            btnPow.TabIndex = 21;
            btnPow.Text = "x^2";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += ButtonResult_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Transparent;
            btnSqrt.BackgroundImageLayout = ImageLayout.Zoom;
            btnSqrt.Font = new Font("Segoe UI", 24F);
            btnSqrt.Location = new Point(9, 85);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(108, 76);
            btnSqrt.TabIndex = 20;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += ButtonResult_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.Transparent;
            btnMulti.Font = new Font("Segoe UI", 24F);
            btnMulti.Location = new Point(351, 331);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(108, 76);
            btnMulti.TabIndex = 19;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += Button_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Transparent;
            btnDiv.Font = new Font("Segoe UI", 24F);
            btnDiv.Location = new Point(351, 413);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(108, 76);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += Button_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Transparent;
            btn8.Font = new Font("Segoe UI", 24F);
            btn8.Location = new Point(123, 331);
            btn8.Name = "btn8";
            btn8.Size = new Size(108, 76);
            btn8.TabIndex = 17;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Button_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Transparent;
            btn4.Font = new Font("Segoe UI", 24F);
            btn4.Location = new Point(9, 249);
            btn4.Name = "btn4";
            btn4.Size = new Size(108, 76);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Button_Click;
            // 
            // btnSum
            // 
            btnSum.BackColor = Color.Transparent;
            btnSum.Font = new Font("Segoe UI", 24F);
            btnSum.Location = new Point(351, 167);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(108, 76);
            btnSum.TabIndex = 12;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = false;
            btnSum.Click += Button_Click;
            // 
            // btnSuv
            // 
            btnSuv.BackColor = Color.Transparent;
            btnSuv.Font = new Font("Segoe UI", 24F);
            btnSuv.Location = new Point(351, 249);
            btnSuv.Name = "btnSuv";
            btnSuv.Size = new Size(108, 76);
            btnSuv.TabIndex = 9;
            btnSuv.Text = "-";
            btnSuv.UseVisualStyleBackColor = false;
            btnSuv.Click += Button_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Segoe UI", 24F);
            btnDelete.Location = new Point(351, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 76);
            btnDelete.TabIndex = 18;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += ButtonDelete_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Transparent;
            btnResult.Font = new Font("Segoe UI", 24F);
            btnResult.Location = new Point(237, 413);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(108, 76);
            btnResult.TabIndex = 15;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += ButtonResult_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Transparent;
            btn7.Font = new Font("Segoe UI", 24F);
            btn7.Location = new Point(9, 331);
            btn7.Name = "btn7";
            btn7.Size = new Size(108, 76);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Button_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Transparent;
            btn9.Font = new Font("Segoe UI", 24F);
            btn9.Location = new Point(237, 331);
            btn9.Name = "btn9";
            btn9.Size = new Size(108, 76);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Button_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Transparent;
            btnDot.Font = new Font("Segoe UI", 24F);
            btnDot.Location = new Point(123, 413);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(108, 76);
            btnDot.TabIndex = 10;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += Button_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Transparent;
            btn0.Font = new Font("Segoe UI", 24F);
            btn0.Location = new Point(9, 413);
            btn0.Name = "btn0";
            btn0.Size = new Size(108, 76);
            btn0.TabIndex = 8;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Button_Click;
            // 
            // btnNegative
            // 
            btnNegative.BackColor = Color.Transparent;
            btnNegative.Font = new Font("Segoe UI", 24F);
            btnNegative.Location = new Point(123, 3);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(108, 76);
            btnNegative.TabIndex = 7;
            btnNegative.Text = "+/-";
            btnNegative.UseVisualStyleBackColor = false;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Transparent;
            btnDeleteAll.Font = new Font("Segoe UI", 24F);
            btnDeleteAll.Location = new Point(237, 3);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(108, 76);
            btnDeleteAll.TabIndex = 6;
            btnDeleteAll.Text = "C";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += ButtonClear_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Transparent;
            btn1.Font = new Font("Segoe UI", 24F);
            btn1.Location = new Point(9, 167);
            btn1.Name = "btn1";
            btn1.Size = new Size(108, 76);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Button_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Transparent;
            btn2.Font = new Font("Segoe UI", 24F);
            btn2.Location = new Point(123, 167);
            btn2.Name = "btn2";
            btn2.Size = new Size(108, 76);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Button_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Transparent;
            btn3.Font = new Font("Segoe UI", 24F);
            btn3.Location = new Point(237, 167);
            btn3.Name = "btn3";
            btn3.Size = new Size(108, 76);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Button_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Transparent;
            btn5.Font = new Font("Segoe UI", 24F);
            btn5.Location = new Point(123, 249);
            btn5.Name = "btn5";
            btn5.Size = new Size(108, 76);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Button_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Transparent;
            btn6.Font = new Font("Segoe UI", 24F);
            btn6.Location = new Point(237, 249);
            btn6.Name = "btn6";
            btn6.Size = new Size(108, 76);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI", 24F);
            button1.Location = new Point(9, 3);
            button1.Name = "button1";
            button1.Size = new Size(108, 76);
            button1.TabIndex = 0;
            button1.Text = "%";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtInput);
            panel2.Controls.Add(txtHistory);
            panel2.Location = new Point(21, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 143);
            panel2.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.Transparent;
            txtInput.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtInput.Location = new Point(29, 70);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(392, 53);
            txtInput.TabIndex = 1;
            txtInput.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.Transparent;
            txtHistory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHistory.ForeColor = SystemColors.AppWorkspace;
            txtHistory.Location = new Point(29, 16);
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(392, 42);
            txtHistory.TabIndex = 0;
            txtHistory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(492, 775);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMulti;
        private Button btnDelete;
        private Button btn8;
        private Button btn4;
        private Button btnResult;
        private Button btn7;
        private Button btn9;
        private Button btnSum;
        private Button btnDiv;
        private Button btnDot;
        private Button btnSuv;
        private Button btn0;
        private Button btnNegative;
        private Button btnDeleteAll;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn5;
        private Button btn6;
        private Button button1;
        private Panel panel2;
        private Label txtInput;
        private Label txtHistory;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button button4;
        private Button btnPow;
        private Button btnSqrt;
    }
}
