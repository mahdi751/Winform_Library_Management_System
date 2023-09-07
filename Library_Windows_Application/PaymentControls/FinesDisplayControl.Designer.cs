namespace Library_Windows_Application.PaymentControls
{
    partial class FinesDisplayControl
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
            AuthorName = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            PayFineBtn = new Button();
            DetailsBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            GenreLabel = new Label();
            TitleLabel = new Label();
            panel1 = new Panel();
            FineLabel = new Label();
            DetailsPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AuthorName
            // 
            AuthorName.AutoSize = true;
            AuthorName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AuthorName.ForeColor = Color.Blue;
            AuthorName.Location = new Point(187, 38);
            AuthorName.Name = "AuthorName";
            AuthorName.Size = new Size(110, 21);
            AuthorName.TabIndex = 55;
            AuthorName.Text = "Author name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(115, 38);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 54;
            label6.Text = "Author :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BookDisplay1;
            pictureBox1.Location = new Point(0, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // PayFineBtn
            // 
            PayFineBtn.AutoSize = true;
            PayFineBtn.BackColor = Color.Blue;
            PayFineBtn.Cursor = Cursors.Hand;
            PayFineBtn.FlatAppearance.BorderSize = 0;
            PayFineBtn.FlatStyle = FlatStyle.Flat;
            PayFineBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PayFineBtn.ForeColor = Color.White;
            PayFineBtn.Location = new Point(192, 143);
            PayFineBtn.Name = "PayFineBtn";
            PayFineBtn.Size = new Size(94, 31);
            PayFineBtn.TabIndex = 52;
            PayFineBtn.Text = "Pay fine";
            PayFineBtn.UseVisualStyleBackColor = false;
            // 
            // DetailsBtn
            // 
            DetailsBtn.BackColor = Color.Aqua;
            DetailsBtn.Cursor = Cursors.Hand;
            DetailsBtn.FlatAppearance.BorderSize = 0;
            DetailsBtn.FlatStyle = FlatStyle.Flat;
            DetailsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DetailsBtn.ForeColor = Color.Blue;
            DetailsBtn.Location = new Point(92, 143);
            DetailsBtn.Name = "DetailsBtn";
            DetailsBtn.Size = new Size(94, 31);
            DetailsBtn.TabIndex = 51;
            DetailsBtn.Text = "Details";
            DetailsBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(115, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 44;
            label2.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 43;
            label1.Text = "Title:";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GenreLabel.ForeColor = Color.Blue;
            GenreLabel.Location = new Point(187, 69);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(55, 21);
            GenreLabel.TabIndex = 42;
            GenreLabel.Text = "Genre";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Blue;
            TitleLabel.Location = new Point(187, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(44, 21);
            TitleLabel.TabIndex = 41;
            TitleLabel.Text = "Title";
            // 
            // panel1
            // 
            panel1.Controls.Add(FineLabel);
            panel1.Controls.Add(AuthorName);
            panel1.Controls.Add(DetailsBtn);
            panel1.Controls.Add(TitleLabel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(PayFineBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(GenreLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 193);
            panel1.TabIndex = 58;
            // 
            // FineLabel
            // 
            FineLabel.BackColor = Color.Maroon;
            FineLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            FineLabel.ForeColor = Color.White;
            FineLabel.Location = new Point(0, 104);
            FineLabel.Name = "FineLabel";
            FineLabel.Size = new Size(370, 20);
            FineLabel.TabIndex = 58;
            FineLabel.Text = "Fine to pay : 20$";
            FineLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DetailsPanel
            // 
            DetailsPanel.AutoSize = true;
            DetailsPanel.BackColor = Color.Linen;
            DetailsPanel.Dock = DockStyle.Fill;
            DetailsPanel.Location = new Point(0, 193);
            DetailsPanel.Margin = new Padding(0);
            DetailsPanel.Name = "DetailsPanel";
            DetailsPanel.Size = new Size(370, 0);
            DetailsPanel.TabIndex = 53;
            // 
            // FinesDisplayControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            Controls.Add(DetailsPanel);
            Controls.Add(panel1);
            Margin = new Padding(15);
            Name = "FinesDisplayControl";
            Size = new Size(370, 180);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AuthorName;
        private Label label6;
        private PictureBox pictureBox1;
        private Button PayFineBtn;
        private Button DetailsBtn;
        private Label label2;
        private Label label1;
        private Label GenreLabel;
        private Label TitleLabel;
        private Panel panel1;
        private FlowLayoutPanel DetailsPanel;
        private Label FineLabel;
    }
}
