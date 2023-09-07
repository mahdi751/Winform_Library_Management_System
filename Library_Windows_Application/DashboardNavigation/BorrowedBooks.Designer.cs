namespace Library_Windows_Application.Dashboard_Controls
{
    partial class BorrowedBooks
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
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            CurrentBorrowPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            BorrowHistoryPanel = new FlowLayoutPanel();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 247, 255);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 75);
            panel2.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.refresh_page_option;
            pictureBox5.Location = new Point(13, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Blue;
            pictureBox1.Location = new Point(-35, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 3);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Blue;
            pictureBox2.Location = new Point(619, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(390, 3);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(0, 42);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1009, 33);
            label1.TabIndex = 0;
            label1.Text = "Membership Borrowed Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(965, 1);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 43);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += X_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(1012, 23);
            label2.TabIndex = 34;
            label2.Text = "Borrowed Books Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentBorrowPanel
            // 
            CurrentBorrowPanel.AutoScroll = true;
            CurrentBorrowPanel.BackColor = Color.White;
            CurrentBorrowPanel.Dock = DockStyle.Top;
            CurrentBorrowPanel.Location = new Point(0, 75);
            CurrentBorrowPanel.Name = "CurrentBorrowPanel";
            CurrentBorrowPanel.Size = new Size(1012, 209);
            CurrentBorrowPanel.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(BorrowHistoryPanel);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 341);
            panel1.TabIndex = 24;
            // 
            // BorrowHistoryPanel
            // 
            BorrowHistoryPanel.AutoScroll = true;
            BorrowHistoryPanel.AutoSize = true;
            BorrowHistoryPanel.Dock = DockStyle.Fill;
            BorrowHistoryPanel.Location = new Point(0, 32);
            BorrowHistoryPanel.Name = "BorrowHistoryPanel";
            BorrowHistoryPanel.Size = new Size(1012, 309);
            BorrowHistoryPanel.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 10, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1012, 32);
            panel3.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Blue;
            pictureBox4.Location = new Point(0, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(430, 3);
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Blue;
            pictureBox3.Location = new Point(581, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(430, 3);
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(3, 10, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(1009, 33);
            label3.TabIndex = 1;
            label3.Text = "Borrow History";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BorrowedBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(CurrentBorrowPanel);
            Controls.Add(panel2);
            Name = "BorrowedBooks";
            Size = new Size(1012, 625);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button Back;
        private Button button1;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel CurrentBorrowPanel;
        private Panel panel1;
        private FlowLayoutPanel BorrowHistoryPanel;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private BorrowedBooksControl_Components.BorrowedBooksDisplay borrowedBooksDisplay1;
        private BorrowedBooksControl_Components.BorrowedBooksDisplay borrowedBooksDisplay2;
        private PictureBox pictureBox5;
    }
}
