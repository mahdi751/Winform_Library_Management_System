namespace Library_Windows_Application.Dashboard_Controls
{
    partial class BookListingControl
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
            BorrowBtn = new Button();
            ReviewBtn = new Button();
            PublishDateLabel = new Label();
            PublisherLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            AvailableLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GenreLabel = new Label();
            TitleLabel = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            AuthorName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BorrowBtn
            // 
            BorrowBtn.AutoSize = true;
            BorrowBtn.BackColor = Color.Orange;
            BorrowBtn.Cursor = Cursors.Hand;
            BorrowBtn.FlatAppearance.BorderSize = 0;
            BorrowBtn.FlatStyle = FlatStyle.Flat;
            BorrowBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowBtn.ForeColor = Color.Blue;
            BorrowBtn.Location = new Point(880, 59);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(94, 31);
            BorrowBtn.TabIndex = 37;
            BorrowBtn.Text = "Borrow";
            BorrowBtn.UseVisualStyleBackColor = false;
            // 
            // ReviewBtn
            // 
            ReviewBtn.BackColor = Color.Aqua;
            ReviewBtn.Cursor = Cursors.Hand;
            ReviewBtn.FlatAppearance.BorderSize = 0;
            ReviewBtn.FlatStyle = FlatStyle.Flat;
            ReviewBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReviewBtn.ForeColor = Color.Blue;
            ReviewBtn.Location = new Point(780, 59);
            ReviewBtn.Name = "ReviewBtn";
            ReviewBtn.Size = new Size(94, 31);
            ReviewBtn.TabIndex = 36;
            ReviewBtn.Text = "Review";
            ReviewBtn.UseVisualStyleBackColor = false;
            // 
            // PublishDateLabel
            // 
            PublishDateLabel.AutoSize = true;
            PublishDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PublishDateLabel.ForeColor = Color.Blue;
            PublishDateLabel.Location = new Point(578, 38);
            PublishDateLabel.Name = "PublishDateLabel";
            PublishDateLabel.Size = new Size(103, 21);
            PublishDateLabel.TabIndex = 35;
            PublishDateLabel.Text = "PublishDate";
            // 
            // PublisherLabel
            // 
            PublisherLabel.AutoSize = true;
            PublisherLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PublisherLabel.ForeColor = Color.Blue;
            PublisherLabel.Location = new Point(578, 11);
            PublisherLabel.Name = "PublisherLabel";
            PublisherLabel.Size = new Size(132, 21);
            PublisherLabel.TabIndex = 34;
            PublisherLabel.Text = "Publisher Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(466, 38);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 33;
            label5.Text = "Published in:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(466, 11);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 32;
            label4.Text = "Published By:";
            // 
            // AvailableLabel
            // 
            AvailableLabel.AutoSize = true;
            AvailableLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AvailableLabel.ForeColor = Color.SeaGreen;
            AvailableLabel.Location = new Point(301, 38);
            AvailableLabel.Name = "AvailableLabel";
            AvailableLabel.Size = new Size(19, 21);
            AvailableLabel.TabIndex = 31;
            AvailableLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(143, 38);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 30;
            label3.Text = "Available Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(143, 66);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 29;
            label2.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(143, 11);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 28;
            label1.Text = "Title:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GenreLabel.ForeColor = Color.Blue;
            GenreLabel.Location = new Point(215, 66);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(55, 21);
            GenreLabel.TabIndex = 27;
            GenreLabel.Text = "Genre";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Blue;
            TitleLabel.Location = new Point(215, 11);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(44, 21);
            TitleLabel.TabIndex = 26;
            TitleLabel.Text = "Title";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BookDisplay1;
            pictureBox1.Location = new Point(14, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(466, 66);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 39;
            label6.Text = "Author :";
            // 
            // AuthorName
            // 
            AuthorName.AutoSize = true;
            AuthorName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AuthorName.ForeColor = Color.Blue;
            AuthorName.Location = new Point(578, 66);
            AuthorName.Name = "AuthorName";
            AuthorName.Size = new Size(110, 21);
            AuthorName.TabIndex = 40;
            AuthorName.Text = "Author name";
            // 
            // BookListingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            Controls.Add(AuthorName);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(BorrowBtn);
            Controls.Add(ReviewBtn);
            Controls.Add(PublishDateLabel);
            Controls.Add(PublisherLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AvailableLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GenreLabel);
            Controls.Add(TitleLabel);
            Name = "BookListingControl";
            Size = new Size(975, 92);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BorrowBtn;
        private Button ReviewBtn;
        private Label PublishDateLabel;
        private Label PublisherLabel;
        private Label label5;
        private Label label4;
        private Label AvailableLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label GenreLabel;
        private Label TitleLabel;
        private PictureBox pictureBox1;
        private Label label6;
        private Label AuthorName;
    }
}
