namespace Library_Windows_Application.BooksNavigation
{
    partial class ReviewsDisplay
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
            pictureBox1 = new PictureBox();
            Username = new Label();
            CommentText = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            reviewDate = new Label();
            RatingPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(13, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.White;
            Username.Location = new Point(165, 12);
            Username.Name = "Username";
            Username.Size = new Size(87, 21);
            Username.TabIndex = 29;
            Username.Text = "Username";
            // 
            // CommentText
            // 
            CommentText.BackColor = Color.DodgerBlue;
            CommentText.BorderStyle = BorderStyle.None;
            CommentText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CommentText.ForeColor = Color.White;
            CommentText.Location = new Point(509, 39);
            CommentText.Name = "CommentText";
            CommentText.ReadOnly = true;
            CommentText.Size = new Size(450, 70);
            CommentText.TabIndex = 30;
            CommentText.Text = "this was a good book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(165, 53);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 31;
            label2.Text = "Rating :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(504, 4);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 32;
            label3.Text = "Comment:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Blue;
            pictureBox2.Location = new Point(509, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 3);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(165, 95);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 35;
            label4.Text = "Date :";
            // 
            // reviewDate
            // 
            reviewDate.AutoSize = true;
            reviewDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reviewDate.ForeColor = Color.White;
            reviewDate.Location = new Point(236, 95);
            reviewDate.Name = "reviewDate";
            reviewDate.Size = new Size(46, 21);
            reviewDate.TabIndex = 36;
            reviewDate.Text = "Date";
            // 
            // RatingPanel
            // 
            RatingPanel.Location = new Point(237, 49);
            RatingPanel.Name = "RatingPanel";
            RatingPanel.Size = new Size(195, 30);
            RatingPanel.TabIndex = 37;
            // 
            // ReviewsDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            Controls.Add(RatingPanel);
            Controls.Add(reviewDate);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CommentText);
            Controls.Add(Username);
            Controls.Add(pictureBox1);
            Name = "ReviewsDisplay";
            Size = new Size(975, 121);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Username;
        private RichTextBox CommentText;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label reviewDate;
        private FlowLayoutPanel RatingPanel;
    }
}
