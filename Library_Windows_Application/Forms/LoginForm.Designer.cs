namespace Library_Windows_Application;

partial class LoginForm
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
        components = new System.ComponentModel.Container();
        panel1 = new Panel();
        pictureBox7 = new PictureBox();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        label = new Label();
        pictureBox1 = new PictureBox();
        panel2 = new Panel();
        loadingLabel = new Label();
        pbar = new CircularProgressBar.CircularProgressBar();
        pictureBox13 = new PictureBox();
        linkLabel1 = new LinkLabel();
        label5 = new Label();
        ErrorLabel = new Label();
        LoginBtn = new Button();
        Forgotps = new LinkLabel();
        PasswordText = new TextBox();
        UsernameText = new TextBox();
        pictureBox6 = new PictureBox();
        pictureBox5 = new PictureBox();
        pictureBox4 = new PictureBox();
        pictureBox3 = new PictureBox();
        button1 = new Button();
        label4 = new Label();
        pictureBox2 = new PictureBox();
        loadingTime = new System.Windows.Forms.Timer(components);
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.Blue;
        panel1.Controls.Add(pictureBox7);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(label);
        panel1.Controls.Add(pictureBox1);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(419, 624);
        panel1.TabIndex = 0;
        panel1.MouseDown += MainForm_MouseDown;
        panel1.MouseMove += onMove;
        panel1.MouseUp += MainForm_MouseUp;
        // 
        // pictureBox7
        // 
        pictureBox7.BackColor = Color.White;
        pictureBox7.Location = new Point(147, 100);
        pictureBox7.Margin = new Padding(4, 3, 4, 3);
        pictureBox7.Name = "pictureBox7";
        pictureBox7.Size = new Size(233, 3);
        pictureBox7.TabIndex = 21;
        pictureBox7.TabStop = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        label3.ForeColor = Color.White;
        label3.Location = new Point(309, 586);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(87, 17);
        label3.TabIndex = 4;
        label3.Text = "IDS FINTECH";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(267, 560);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(126, 21);
        label2.TabIndex = 3;
        label2.Text = "Developped By";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(90, 106);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(186, 45);
        label1.TabIndex = 2;
        label1.Text = "Login Page";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
        label.ForeColor = Color.White;
        label.Location = new Point(31, 28);
        label.Margin = new Padding(4, 0, 4, 0);
        label.Name = "label";
        label.Size = new Size(301, 65);
        label.TabIndex = 1;
        label.Text = "Book Haven";
        label.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.Login_amico;
        pictureBox1.Location = new Point(31, 186);
        pictureBox1.Margin = new Padding(4, 3, 4, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(336, 343);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // panel2
        // 
        panel2.BackColor = Color.White;
        panel2.Controls.Add(loadingLabel);
        panel2.Controls.Add(pbar);
        panel2.Controls.Add(pictureBox13);
        panel2.Controls.Add(linkLabel1);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(ErrorLabel);
        panel2.Controls.Add(LoginBtn);
        panel2.Controls.Add(Forgotps);
        panel2.Controls.Add(PasswordText);
        panel2.Controls.Add(UsernameText);
        panel2.Controls.Add(pictureBox6);
        panel2.Controls.Add(pictureBox5);
        panel2.Controls.Add(pictureBox4);
        panel2.Controls.Add(pictureBox3);
        panel2.Controls.Add(button1);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(pictureBox2);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(419, 0);
        panel2.Margin = new Padding(4, 3, 4, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(574, 624);
        panel2.TabIndex = 1;
        panel2.MouseDown += MainForm_MouseDown;
        panel2.MouseMove += onMove;
        panel2.MouseUp += MainForm_MouseUp;
        // 
        // loadingLabel
        // 
        loadingLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        loadingLabel.ForeColor = Color.Blue;
        loadingLabel.Location = new Point(0, 49);
        loadingLabel.Margin = new Padding(4, 0, 4, 0);
        loadingLabel.Name = "loadingLabel";
        loadingLabel.Size = new Size(574, 20);
        loadingLabel.TabIndex = 46;
        loadingLabel.Text = "Loading...";
        loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
        loadingLabel.Visible = false;
        // 
        // pbar
        // 
        pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
        pbar.AnimationSpeed = 70;
        pbar.BackColor = Color.Transparent;
        pbar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        pbar.ForeColor = Color.Blue;
        pbar.InnerColor = Color.White;
        pbar.InnerMargin = 2;
        pbar.InnerWidth = -1;
        pbar.Location = new Point(259, 0);
        pbar.MarqueeAnimationSpeed = 2000;
        pbar.Name = "pbar";
        pbar.OuterColor = Color.Cyan;
        pbar.OuterMargin = -25;
        pbar.OuterWidth = 26;
        pbar.ProgressColor = Color.Blue;
        pbar.ProgressWidth = 2;
        pbar.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
        pbar.Size = new Size(50, 50);
        pbar.StartAngle = 270;
        pbar.Style = ProgressBarStyle.Continuous;
        pbar.SubscriptColor = Color.FromArgb(166, 166, 166);
        pbar.SubscriptMargin = new Padding(0);
        pbar.SubscriptText = "";
        pbar.SuperscriptColor = Color.FromArgb(166, 166, 166);
        pbar.SuperscriptMargin = new Padding(0);
        pbar.SuperscriptText = "";
        pbar.TabIndex = 45;
        pbar.Text = "25%";
        pbar.TextMargin = new Padding(2, 4, 0, 0);
        pbar.Value = 68;
        pbar.Visible = false;
        // 
        // pictureBox13
        // 
        pictureBox13.Cursor = Cursors.Hand;
        pictureBox13.Image = Properties.Resources.hide;
        pictureBox13.Location = new Point(462, 389);
        pictureBox13.Name = "pictureBox13";
        pictureBox13.Size = new Size(30, 30);
        pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox13.TabIndex = 33;
        pictureBox13.TabStop = false;
        pictureBox13.Click += Visibility_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Cursor = Cursors.Hand;
        linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        linkLabel1.Location = new Point(337, 586);
        linkLabel1.Margin = new Padding(4, 0, 4, 0);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(61, 20);
        linkLabel1.TabIndex = 20;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Sign Up";
        linkLabel1.LinkClicked += SigninCLick;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label5.ForeColor = Color.Black;
        label5.Location = new Point(179, 586);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(163, 20);
        label5.TabIndex = 19;
        label5.Text = "Don't have an account?";
        // 
        // ErrorLabel
        // 
        ErrorLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        ErrorLabel.ForeColor = Color.Red;
        ErrorLabel.Location = new Point(0, 542);
        ErrorLabel.Margin = new Padding(4, 0, 4, 0);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new Size(574, 22);
        ErrorLabel.TabIndex = 18;
        ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginBtn
        // 
        LoginBtn.BackColor = Color.Blue;
        LoginBtn.Cursor = Cursors.Hand;
        LoginBtn.FlatAppearance.BorderColor = Color.White;
        LoginBtn.FlatAppearance.BorderSize = 0;
        LoginBtn.FlatStyle = FlatStyle.Flat;
        LoginBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        LoginBtn.ForeColor = Color.White;
        LoginBtn.Location = new Point(206, 479);
        LoginBtn.Margin = new Padding(4, 3, 4, 3);
        LoginBtn.Name = "LoginBtn";
        LoginBtn.Size = new Size(163, 39);
        LoginBtn.TabIndex = 17;
        LoginBtn.Text = "LOGIN";
        LoginBtn.UseVisualStyleBackColor = false;
        LoginBtn.Click += LoginClick;
        // 
        // Forgotps
        // 
        Forgotps.AutoSize = true;
        Forgotps.Cursor = Cursors.Hand;
        Forgotps.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        Forgotps.Location = new Point(367, 434);
        Forgotps.Margin = new Padding(4, 0, 4, 0);
        Forgotps.Name = "Forgotps";
        Forgotps.Size = new Size(125, 20);
        Forgotps.TabIndex = 16;
        Forgotps.TabStop = true;
        Forgotps.Text = "Forgot Password?";
        // 
        // PasswordText
        // 
        PasswordText.BorderStyle = BorderStyle.None;
        PasswordText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        PasswordText.ForeColor = Color.Gray;
        PasswordText.Location = new Point(115, 391);
        PasswordText.Margin = new Padding(4, 3, 4, 3);
        PasswordText.Name = "PasswordText";
        PasswordText.Size = new Size(336, 22);
        PasswordText.TabIndex = 15;
        PasswordText.Text = "Password";
        PasswordText.Enter += PasswordText_Enter;
        PasswordText.Leave += PasswordText_Leave;
        // 
        // UsernameText
        // 
        UsernameText.BorderStyle = BorderStyle.None;
        UsernameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        UsernameText.ForeColor = Color.Gray;
        UsernameText.Location = new Point(115, 324);
        UsernameText.Margin = new Padding(4, 3, 4, 3);
        UsernameText.Name = "UsernameText";
        UsernameText.Size = new Size(373, 22);
        UsernameText.TabIndex = 14;
        UsernameText.Text = "Username";
        UsernameText.Enter += UsernameText_Enter;
        UsernameText.Leave += UsernameText_Leave;
        // 
        // pictureBox6
        // 
        pictureBox6.BackColor = Color.Blue;
        pictureBox6.Location = new Point(115, 419);
        pictureBox6.Margin = new Padding(4, 3, 4, 3);
        pictureBox6.Name = "pictureBox6";
        pictureBox6.Size = new Size(377, 2);
        pictureBox6.TabIndex = 13;
        pictureBox6.TabStop = false;
        // 
        // pictureBox5
        // 
        pictureBox5.BackColor = Color.Blue;
        pictureBox5.Location = new Point(115, 352);
        pictureBox5.Margin = new Padding(4, 3, 4, 3);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(377, 2);
        pictureBox5.TabIndex = 11;
        pictureBox5.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources._lock;
        pictureBox4.Location = new Point(67, 381);
        pictureBox4.Margin = new Padding(4, 3, 4, 3);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(40, 40);
        pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox4.TabIndex = 8;
        pictureBox4.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.account__1_;
        pictureBox3.Location = new Point(67, 314);
        pictureBox3.Margin = new Padding(4, 3, 4, 3);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(40, 40);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 7;
        pictureBox3.TabStop = false;
        // 
        // button1
        // 
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.Blue;
        button1.Location = new Point(527, 0);
        button1.Margin = new Padding(4, 3, 4, 3);
        button1.Name = "button1";
        button1.Size = new Size(47, 46);
        button1.TabIndex = 0;
        button1.Text = "X";
        button1.UseVisualStyleBackColor = true;
        button1.Click += X_Click;
        // 
        // label4
        // 
        label4.BackColor = Color.White;
        label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
        label4.ForeColor = Color.Blue;
        label4.Location = new Point(0, 54);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(574, 65);
        label4.TabIndex = 2;
        label4.Text = "Welcome Back!";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.Hello_bro;
        pictureBox2.Location = new Point(156, 96);
        pictureBox2.Margin = new Padding(4, 3, 4, 3);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(270, 223);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 6;
        pictureBox2.TabStop = false;
        // 
        // loadingTime
        // 
        loadingTime.Enabled = true;
        loadingTime.Interval = 70;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(993, 624);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 3, 4, 3);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LoginForm";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox6;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.TextBox UsernameText;
    private System.Windows.Forms.TextBox PasswordText;
    private System.Windows.Forms.LinkLabel Forgotps;
    private System.Windows.Forms.Button LoginBtn;
    private System.Windows.Forms.Label ErrorLabel;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox pictureBox7;
    private PictureBox pictureBox13;
    private CircularProgressBar.CircularProgressBar pbar;
    private System.Windows.Forms.Timer loadingTime;
    private Label loadingLabel;
}