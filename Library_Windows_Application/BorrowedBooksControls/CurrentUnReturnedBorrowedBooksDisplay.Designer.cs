namespace Library_Windows_Application.BorrowedBooksControl_Components
{
    partial class CurrentUnReturnedBorrowedBooksDisplay
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
            BtnPanel = new Panel();
            ReturnBtn = new Button();
            AuthorName = new Label();
            StatusBox = new PictureBox();
            ReturnDetails = new Label();
            GenreType = new Label();
            Title = new Label();
            pictureBox1 = new PictureBox();
            BorrowLabel = new Label();
            BtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StatusBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnPanel
            // 
            BtnPanel.Controls.Add(ReturnBtn);
            BtnPanel.Dock = DockStyle.Bottom;
            BtnPanel.Location = new Point(0, 147);
            BtnPanel.Name = "BtnPanel";
            BtnPanel.Size = new Size(280, 37);
            BtnPanel.TabIndex = 14;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.Orange;
            ReturnBtn.Cursor = Cursors.Hand;
            ReturnBtn.FlatAppearance.BorderSize = 0;
            ReturnBtn.FlatStyle = FlatStyle.Flat;
            ReturnBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBtn.ForeColor = Color.Blue;
            ReturnBtn.Location = new Point(93, 5);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(95, 26);
            ReturnBtn.TabIndex = 9;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            // 
            // AuthorName
            // 
            AuthorName.AutoSize = true;
            AuthorName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AuthorName.ForeColor = Color.Blue;
            AuthorName.Location = new Point(107, 37);
            AuthorName.Name = "AuthorName";
            AuthorName.Size = new Size(105, 20);
            AuthorName.TabIndex = 20;
            AuthorName.Text = "Author Name";
            AuthorName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatusBox
            // 
            StatusBox.Image = Properties.Resources.redcircle;
            StatusBox.Location = new Point(0, 0);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(27, 24);
            StatusBox.SizeMode = PictureBoxSizeMode.Zoom;
            StatusBox.TabIndex = 19;
            StatusBox.TabStop = false;
            // 
            // ReturnDetails
            // 
            ReturnDetails.BackColor = Color.Blue;
            ReturnDetails.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnDetails.ForeColor = Color.White;
            ReturnDetails.Location = new Point(0, 122);
            ReturnDetails.Name = "ReturnDetails";
            ReturnDetails.Size = new Size(280, 20);
            ReturnDetails.TabIndex = 18;
            ReturnDetails.Text = "Return before 05/08";
            ReturnDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GenreType
            // 
            GenreType.AutoSize = true;
            GenreType.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            GenreType.ForeColor = Color.Blue;
            GenreType.Location = new Point(107, 61);
            GenreType.Name = "GenreType";
            GenreType.Size = new Size(51, 20);
            GenreType.TabIndex = 17;
            GenreType.Text = "Genre";
            GenreType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.Blue;
            Title.Location = new Point(107, 13);
            Title.Name = "Title";
            Title.Size = new Size(80, 20);
            Title.TabIndex = 16;
            Title.Text = "Book Title";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BookDisplay1;
            pictureBox1.Location = new Point(19, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // BorrowLabel
            // 
            BorrowLabel.BackColor = Color.Blue;
            BorrowLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowLabel.ForeColor = Color.White;
            BorrowLabel.Location = new Point(0, 94);
            BorrowLabel.Name = "BorrowLabel";
            BorrowLabel.Size = new Size(280, 20);
            BorrowLabel.TabIndex = 21;
            BorrowLabel.Text = "Borrowed in 09/07";
            BorrowLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentUnReturnedBorrowedBooksDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            Controls.Add(BorrowLabel);
            Controls.Add(AuthorName);
            Controls.Add(StatusBox);
            Controls.Add(ReturnDetails);
            Controls.Add(GenreType);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Controls.Add(BtnPanel);
            Name = "CurrentUnReturnedBorrowedBooksDisplay";
            Size = new Size(280, 184);
            BtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StatusBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BtnPanel;
        private Button ReturnBtn;
        private Label AuthorName;
        private PictureBox StatusBox;
        private Label ReturnDetails;
        private Label GenreType;
        private Label Title;
        private PictureBox pictureBox1;
        private Label BorrowLabel;
    }
}
