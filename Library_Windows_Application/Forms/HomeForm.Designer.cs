namespace Library_Windows_Application.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            navigation = new Panel();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            navigtionMenu1 = new Kimtoo.NavigtionMenu();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            UsernameLabel = new Label();
            pictureBox1 = new PictureBox();
            Channel = new Panel();
            button1 = new Button();
            navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Channel.SuspendLayout();
            SuspendLayout();
            // 
            // navigation
            // 
            navigation.BackColor = Color.Blue;
            navigation.Controls.Add(pictureBox4);
            navigation.Controls.Add(panel1);
            navigation.Controls.Add(label1);
            navigation.Controls.Add(pictureBox2);
            navigation.Controls.Add(UsernameLabel);
            navigation.Controls.Add(pictureBox1);
            navigation.Dock = DockStyle.Left;
            navigation.Location = new Point(0, 0);
            navigation.Name = "navigation";
            navigation.Size = new Size(308, 625);
            navigation.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkOrange;
            pictureBox4.Location = new Point(3, 571);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(160, 3);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(navigtionMenu1);
            panel1.Location = new Point(26, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 300);
            panel1.TabIndex = 5;
            // 
            // navigtionMenu1
            // 
            navigtionMenu1.AutoScroll = true;
            navigtionMenu1.BackColor = Color.Blue;
            navigtionMenu1.BackColor_Click = Color.Blue;
            navigtionMenu1.BackColor_Hover = Color.Blue;
            navigtionMenu1.BackColor_Selected = Color.FromArgb(88, 104, 240);
            navigtionMenu1.Dock = DockStyle.Fill;
            navigtionMenu1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            navigtionMenu1.ForeColor = Color.FromArgb(224, 224, 224);
            navigtionMenu1.ForeColor_Selected = Color.Empty;
            navigtionMenu1.IsExpandable = false;
            navigtionMenu1.IsExpanded = true;
            navigtionMenu1.ItemHeight = 50;
            navigtionMenu1.ItemImageSize = new Size(20, 20);
            navigtionMenu1.ItemPadding = new Padding(8, 0, 0, 0);
            navigtionMenu1.ItemRightImageMargin = 20;
            navigtionMenu1.ItemRightImageSize = new Size(15, 15);
            navigtionMenu1.Items = (new Kimtoo.ButtonItem[] { (Kimtoo.ButtonItem)resources.GetObject("navigtionMenu1.Items"), (Kimtoo.ButtonItem)resources.GetObject("navigtionMenu1.Items1"), (Kimtoo.ButtonItem)resources.GetObject("navigtionMenu1.Items2"), (Kimtoo.ButtonItem)resources.GetObject("navigtionMenu1.Items3"), (Kimtoo.ButtonItem)resources.GetObject("navigtionMenu1.Items4"), (Kimtoo.ButtonItem)resources.GetObject("navigtionMenu1.Items5") });
            navigtionMenu1.ItemTextMargin = 8;
            navigtionMenu1.Location = new Point(0, 0);
            navigtionMenu1.Margin = new Padding(3, 5, 3, 5);
            navigtionMenu1.Name = "navigtionMenu1";
            navigtionMenu1.Size = new Size(255, 300);
            navigtionMenu1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(1, 592);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 4;
            label1.Text = "@idsFintech";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkOrange;
            pictureBox2.Location = new Point(148, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 3);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.White;
            UsernameLabel.Location = new Point(0, 113);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(308, 30);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            UsernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(93, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Channel
            // 
            Channel.AutoScroll = true;
            Channel.Controls.Add(button1);
            Channel.Dock = DockStyle.Fill;
            Channel.Location = new Point(308, 0);
            Channel.Name = "Channel";
            Channel.Size = new Size(1012, 625);
            Channel.TabIndex = 1;
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
            button1.Size = new Size(47, 46);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += X_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1320, 625);
            ControlBox = false;
            Controls.Add(Channel);
            Controls.Add(navigation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            navigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Channel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navigation;
        private Panel Channel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private Label UsernameLabel;
        private Kimtoo.NavigtionMenu navigtionMenu1;
        private PictureBox pictureBox4;
        private Button button1;
    }
}