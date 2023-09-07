namespace Library_Windows_Application.Dashboard_Controls
{
    partial class BooksControl
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            FilterBox = new ComboBox();
            label1 = new Label();
            SearchBox = new TextBox();
            pictureBox1 = new PictureBox();
            ErrorLabel = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            memberhsipLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(965, 0);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 43);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += X_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1012, 512);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // FilterBox
            // 
            FilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FilterBox.ForeColor = Color.Blue;
            FilterBox.FormattingEnabled = true;
            FilterBox.Items.AddRange(new object[] { "Author", "Genre", "Title" });
            FilterBox.Location = new Point(102, 55);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(86, 25);
            FilterBox.Sorted = true;
            FilterBox.TabIndex = 4;
            FilterBox.SelectedIndexChanged += OnFilterChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(13, 58);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 5;
            label1.Text = "Search by :";
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.ForeColor = Color.Gray;
            SearchBox.Location = new Point(296, 54);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(416, 25);
            SearchBox.TabIndex = 6;
            SearchBox.Text = "Search";
            SearchBox.TextAlign = HorizontalAlignment.Center;
            SearchBox.Enter += SearchEnter;
            SearchBox.KeyPress += OnEnterPress;
            SearchBox.Leave += SearchLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(718, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += SearchClick;
            // 
            // ErrorLabel
            // 
            ErrorLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLabel.ForeColor = Color.Blue;
            ErrorLabel.Location = new Point(4, 87);
            ErrorLabel.Margin = new Padding(4, 0, 4, 0);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(1008, 20);
            ErrorLabel.TabIndex = 19;
            ErrorLabel.Text = "No Books have been found!";
            ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            ErrorLabel.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 247, 255);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 43);
            panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.refresh_page_option;
            pictureBox2.Location = new Point(13, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(1012, 23);
            label2.TabIndex = 34;
            label2.Text = "Books Page";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memberhsipLabel
            // 
            memberhsipLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            memberhsipLabel.ForeColor = Color.Blue;
            memberhsipLabel.Location = new Point(4, 90);
            memberhsipLabel.Margin = new Padding(4, 0, 4, 0);
            memberhsipLabel.Name = "memberhsipLabel";
            memberhsipLabel.Size = new Size(1008, 20);
            memberhsipLabel.TabIndex = 21;
            memberhsipLabel.TextAlign = ContentAlignment.MiddleCenter;
            memberhsipLabel.Visible = false;
            // 
            // BooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(memberhsipLabel);
            Controls.Add(panel2);
            Controls.Add(ErrorLabel);
            Controls.Add(pictureBox1);
            Controls.Add(SearchBox);
            Controls.Add(label1);
            Controls.Add(FilterBox);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "BooksControl";
            Size = new Size(1012, 625);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private BookListingControl bookListingControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox FilterBox;
        private Label label1;
        private TextBox SearchBox;
        private PictureBox pictureBox1;
        private Label ErrorLabel;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Label memberhsipLabel;
    }
}
