namespace Library_Windows_Application.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            NextBtn = new Button();
            PasswordText = new TextBox();
            UsernameText = new TextBox();
            passwordLine = new PictureBox();
            usernameLine = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox7 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pbar = new CircularProgressBar.CircularProgressBar();
            globalError = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            PasswordError = new Label();
            UsernameError = new Label();
            LastnameError = new Label();
            FirstnameError = new Label();
            PhoneError = new Label();
            EmailError = new Label();
            MismatchError = new Label();
            PhoneText = new TextBox();
            PhoneLine = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            AddressText = new TextBox();
            pictureBox12 = new PictureBox();
            EmailText = new TextBox();
            EmailLine = new PictureBox();
            lastnameText = new TextBox();
            lastnameLine = new PictureBox();
            firstnameText = new TextBox();
            firstnameLine = new PictureBox();
            ReEnterPasswordText = new TextBox();
            reenterLine = new PictureBox();
            label6 = new Label();
            loadingTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)passwordLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhoneLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastnameLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstnameLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reenterLine).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(786, 677);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(54, 20);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.Click += LoginClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(613, 677);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 19;
            label5.Text = "Already have an account?";
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.Blue;
            NextBtn.Cursor = Cursors.Hand;
            NextBtn.FlatAppearance.BorderColor = Color.White;
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(886, 628);
            NextBtn.Margin = new Padding(4, 3, 4, 3);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(94, 41);
            NextBtn.TabIndex = 17;
            NextBtn.Text = "NEXT";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextClick;
            // 
            // PasswordText
            // 
            PasswordText.AutoCompleteMode = AutoCompleteMode.Suggest;
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordText.ForeColor = Color.Gray;
            PasswordText.Location = new Point(531, 318);
            PasswordText.Margin = new Padding(4, 3, 4, 3);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(340, 22);
            PasswordText.TabIndex = 15;
            PasswordText.Text = "Password";
            PasswordText.TextChanged += CheckPs;
            PasswordText.Enter += PasswordText_Enter;
            PasswordText.Leave += PasswordText_Leave;
            // 
            // UsernameText
            // 
            UsernameText.AutoCompleteMode = AutoCompleteMode.Suggest;
            UsernameText.BorderStyle = BorderStyle.None;
            UsernameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameText.ForeColor = Color.Gray;
            UsernameText.Location = new Point(531, 265);
            UsernameText.Margin = new Padding(4, 3, 4, 3);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(373, 22);
            UsernameText.TabIndex = 14;
            UsernameText.Text = "Username";
            UsernameText.Enter += UsernameText_Enter;
            UsernameText.Leave += UsernameText_Leave;
            // 
            // passwordLine
            // 
            passwordLine.BackColor = Color.Blue;
            passwordLine.Location = new Point(531, 346);
            passwordLine.Margin = new Padding(4, 3, 4, 3);
            passwordLine.Name = "passwordLine";
            passwordLine.Size = new Size(377, 2);
            passwordLine.TabIndex = 13;
            passwordLine.TabStop = false;
            // 
            // usernameLine
            // 
            usernameLine.BackColor = Color.Blue;
            usernameLine.Location = new Point(531, 293);
            usernameLine.Margin = new Padding(4, 3, 4, 3);
            usernameLine.Name = "usernameLine";
            usernameLine.Size = new Size(377, 2);
            usernameLine.TabIndex = 11;
            usernameLine.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(56, 381);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(56, 313);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(481, 50);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(467, 32);
            label4.TabIndex = 2;
            label4.Text = "We are delighted that you have decided";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(946, 0);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 46);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += X_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.Hello_bro1;
            pictureBox2.Location = new Point(587, 91);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(272, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
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
            label3.Location = new Point(331, 669);
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
            label2.Location = new Point(289, 643);
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
            label1.Size = new Size(224, 45);
            label1.TabIndex = 2;
            label1.Text = "Register Page";
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
            panel1.Size = new Size(419, 700);
            panel1.TabIndex = 2;
            panel1.MouseDown += MainForm_MouseDown;
            panel1.MouseMove += onMove;
            panel1.MouseUp += MainForm_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Filing_system_pana1;
            pictureBox1.Location = new Point(36, 200);
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
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pbar);
            panel2.Controls.Add(globalError);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(PasswordError);
            panel2.Controls.Add(UsernameError);
            panel2.Controls.Add(LastnameError);
            panel2.Controls.Add(FirstnameError);
            panel2.Controls.Add(PhoneError);
            panel2.Controls.Add(EmailError);
            panel2.Controls.Add(MismatchError);
            panel2.Controls.Add(PhoneText);
            panel2.Controls.Add(PhoneLine);
            panel2.Controls.Add(pictureBox14);
            panel2.Controls.Add(pictureBox13);
            panel2.Controls.Add(AddressText);
            panel2.Controls.Add(pictureBox12);
            panel2.Controls.Add(EmailText);
            panel2.Controls.Add(EmailLine);
            panel2.Controls.Add(lastnameText);
            panel2.Controls.Add(lastnameLine);
            panel2.Controls.Add(firstnameText);
            panel2.Controls.Add(firstnameLine);
            panel2.Controls.Add(ReEnterPasswordText);
            panel2.Controls.Add(reenterLine);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(NextBtn);
            panel2.Controls.Add(PasswordText);
            panel2.Controls.Add(UsernameText);
            panel2.Controls.Add(passwordLine);
            panel2.Controls.Add(usernameLine);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 700);
            panel2.TabIndex = 3;
            panel2.MouseDown += MainForm_MouseDown;
            panel2.MouseMove += onMove;
            panel2.MouseUp += MainForm_MouseUp;
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
            pbar.Location = new Point(698, 2);
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
            pbar.TabIndex = 48;
            pbar.Text = "25%";
            pbar.TextMargin = new Padding(2, 4, 0, 0);
            pbar.Value = 68;
            pbar.Visible = false;
            // 
            // globalError
            // 
            globalError.BackColor = Color.Transparent;
            globalError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            globalError.ForeColor = Color.Red;
            globalError.Location = new Point(454, 9);
            globalError.Margin = new Padding(4, 0, 4, 0);
            globalError.Name = "globalError";
            globalError.Size = new Size(539, 29);
            globalError.TabIndex = 47;
            globalError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(427, 658);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(180, 13);
            label9.TabIndex = 46;
            label9.Text = ". Password must contain numbers";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(427, 643);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(317, 13);
            label8.TabIndex = 45;
            label8.Text = ". Password must contain upper, lower and special characters";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(427, 628);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(210, 13);
            label7.TabIndex = 44;
            label7.Text = ". Password must be at least 8 characters";
            // 
            // PasswordError
            // 
            PasswordError.BackColor = Color.Transparent;
            PasswordError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordError.ForeColor = Color.Red;
            PasswordError.Location = new Point(526, 298);
            PasswordError.Margin = new Padding(4, 0, 4, 0);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(180, 17);
            PasswordError.TabIndex = 43;
            PasswordError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UsernameError
            // 
            UsernameError.BackColor = Color.Transparent;
            UsernameError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameError.ForeColor = Color.Red;
            UsernameError.Location = new Point(526, 240);
            UsernameError.Margin = new Padding(4, 0, 4, 0);
            UsernameError.Name = "UsernameError";
            UsernameError.Size = new Size(180, 17);
            UsernameError.TabIndex = 42;
            UsernameError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LastnameError
            // 
            LastnameError.BackColor = Color.Transparent;
            LastnameError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastnameError.ForeColor = Color.Red;
            LastnameError.Location = new Point(728, 406);
            LastnameError.Margin = new Padding(4, 0, 4, 0);
            LastnameError.Name = "LastnameError";
            LastnameError.Size = new Size(180, 17);
            LastnameError.TabIndex = 41;
            LastnameError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FirstnameError
            // 
            FirstnameError.BackColor = Color.Transparent;
            FirstnameError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstnameError.ForeColor = Color.Red;
            FirstnameError.Location = new Point(526, 406);
            FirstnameError.Margin = new Padding(4, 0, 4, 0);
            FirstnameError.Name = "FirstnameError";
            FirstnameError.Size = new Size(180, 17);
            FirstnameError.TabIndex = 40;
            FirstnameError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PhoneError
            // 
            PhoneError.BackColor = Color.Transparent;
            PhoneError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneError.ForeColor = Color.Red;
            PhoneError.Location = new Point(526, 563);
            PhoneError.Margin = new Padding(4, 0, 4, 0);
            PhoneError.Name = "PhoneError";
            PhoneError.Size = new Size(180, 17);
            PhoneError.TabIndex = 39;
            PhoneError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmailError
            // 
            EmailError.BackColor = Color.Transparent;
            EmailError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailError.ForeColor = Color.Red;
            EmailError.Location = new Point(526, 457);
            EmailError.Margin = new Padding(4, 0, 4, 0);
            EmailError.Name = "EmailError";
            EmailError.Size = new Size(180, 17);
            EmailError.TabIndex = 38;
            EmailError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MismatchError
            // 
            MismatchError.BackColor = Color.Transparent;
            MismatchError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MismatchError.ForeColor = Color.Red;
            MismatchError.Location = new Point(526, 351);
            MismatchError.Margin = new Padding(4, 0, 4, 0);
            MismatchError.Name = "MismatchError";
            MismatchError.Size = new Size(180, 17);
            MismatchError.TabIndex = 37;
            MismatchError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PhoneText
            // 
            PhoneText.AutoCompleteMode = AutoCompleteMode.Suggest;
            PhoneText.BorderStyle = BorderStyle.None;
            PhoneText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneText.ForeColor = Color.Gray;
            PhoneText.Location = new Point(531, 583);
            PhoneText.Margin = new Padding(4, 3, 4, 3);
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(373, 22);
            PhoneText.TabIndex = 35;
            PhoneText.Text = "Phone";
            PhoneText.TextChanged += PhoneCheck;
            PhoneText.Enter += Phone_Enter;
            PhoneText.Leave += Phone_Leave;
            // 
            // PhoneLine
            // 
            PhoneLine.BackColor = Color.Blue;
            PhoneLine.Location = new Point(531, 611);
            PhoneLine.Margin = new Padding(4, 3, 4, 3);
            PhoneLine.Name = "PhoneLine";
            PhoneLine.Size = new Size(377, 2);
            PhoneLine.TabIndex = 34;
            PhoneLine.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Cursor = Cursors.Hand;
            pictureBox14.Image = Properties.Resources.hide;
            pictureBox14.Location = new Point(878, 371);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(30, 30);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 33;
            pictureBox14.TabStop = false;
            pictureBox14.Click += Visibility_click2;
            // 
            // pictureBox13
            // 
            pictureBox13.Cursor = Cursors.Hand;
            pictureBox13.Image = Properties.Resources.hide;
            pictureBox13.Location = new Point(878, 318);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(30, 30);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 32;
            pictureBox13.TabStop = false;
            pictureBox13.Click += Visibility_click1;
            // 
            // AddressText
            // 
            AddressText.AutoCompleteMode = AutoCompleteMode.Suggest;
            AddressText.BorderStyle = BorderStyle.None;
            AddressText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressText.ForeColor = Color.Gray;
            AddressText.Location = new Point(531, 530);
            AddressText.Margin = new Padding(4, 3, 4, 3);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(373, 22);
            AddressText.TabIndex = 31;
            AddressText.Text = "Address";
            AddressText.Enter += Address_Enter;
            AddressText.Leave += Address_Leave;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Blue;
            pictureBox12.Location = new Point(531, 558);
            pictureBox12.Margin = new Padding(4, 3, 4, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(377, 2);
            pictureBox12.TabIndex = 30;
            pictureBox12.TabStop = false;
            // 
            // EmailText
            // 
            EmailText.AutoCompleteMode = AutoCompleteMode.Suggest;
            EmailText.BorderStyle = BorderStyle.None;
            EmailText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailText.ForeColor = Color.Gray;
            EmailText.Location = new Point(531, 477);
            EmailText.Margin = new Padding(4, 3, 4, 3);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(373, 22);
            EmailText.TabIndex = 29;
            EmailText.Text = "Email";
            EmailText.TextChanged += EmailChange;
            EmailText.Enter += Email_Enter;
            EmailText.Leave += Email_Leave;
            // 
            // EmailLine
            // 
            EmailLine.BackColor = Color.Blue;
            EmailLine.Location = new Point(531, 505);
            EmailLine.Margin = new Padding(4, 3, 4, 3);
            EmailLine.Name = "EmailLine";
            EmailLine.Size = new Size(377, 2);
            EmailLine.TabIndex = 28;
            EmailLine.TabStop = false;
            // 
            // lastnameText
            // 
            lastnameText.AutoCompleteMode = AutoCompleteMode.Suggest;
            lastnameText.BorderStyle = BorderStyle.None;
            lastnameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastnameText.ForeColor = Color.Gray;
            lastnameText.Location = new Point(728, 424);
            lastnameText.Margin = new Padding(4, 3, 4, 3);
            lastnameText.Name = "lastnameText";
            lastnameText.Size = new Size(180, 22);
            lastnameText.TabIndex = 27;
            lastnameText.Text = "Lastname";
            lastnameText.Enter += Lastname_Enter;
            lastnameText.Leave += Lastname_Leave;
            // 
            // lastnameLine
            // 
            lastnameLine.BackColor = Color.Blue;
            lastnameLine.Location = new Point(728, 452);
            lastnameLine.Margin = new Padding(4, 3, 4, 3);
            lastnameLine.Name = "lastnameLine";
            lastnameLine.Size = new Size(180, 2);
            lastnameLine.TabIndex = 26;
            lastnameLine.TabStop = false;
            // 
            // firstnameText
            // 
            firstnameText.AutoCompleteMode = AutoCompleteMode.Suggest;
            firstnameText.BorderStyle = BorderStyle.None;
            firstnameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstnameText.ForeColor = Color.Gray;
            firstnameText.Location = new Point(531, 424);
            firstnameText.Margin = new Padding(4, 3, 4, 3);
            firstnameText.Name = "firstnameText";
            firstnameText.Size = new Size(180, 22);
            firstnameText.TabIndex = 25;
            firstnameText.Text = "Firstname";
            firstnameText.Enter += Firstname_Enter;
            firstnameText.Leave += Firstname_Leave;
            // 
            // firstnameLine
            // 
            firstnameLine.BackColor = Color.Blue;
            firstnameLine.Location = new Point(531, 452);
            firstnameLine.Margin = new Padding(4, 3, 4, 3);
            firstnameLine.Name = "firstnameLine";
            firstnameLine.Size = new Size(180, 2);
            firstnameLine.TabIndex = 24;
            firstnameLine.TabStop = false;
            // 
            // ReEnterPasswordText
            // 
            ReEnterPasswordText.AutoCompleteMode = AutoCompleteMode.Suggest;
            ReEnterPasswordText.BorderStyle = BorderStyle.None;
            ReEnterPasswordText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReEnterPasswordText.ForeColor = Color.Gray;
            ReEnterPasswordText.Location = new Point(531, 371);
            ReEnterPasswordText.Margin = new Padding(4, 3, 4, 3);
            ReEnterPasswordText.Name = "ReEnterPasswordText";
            ReEnterPasswordText.Size = new Size(340, 22);
            ReEnterPasswordText.TabIndex = 23;
            ReEnterPasswordText.Text = "Re-Enter Password";
            ReEnterPasswordText.TextChanged += PsCheck;
            ReEnterPasswordText.Enter += ReEnterPasswordText_Enter;
            ReEnterPasswordText.Leave += ReEnterPasswordText_Leave;
            // 
            // reenterLine
            // 
            reenterLine.BackColor = Color.Blue;
            reenterLine.Location = new Point(531, 399);
            reenterLine.Margin = new Padding(4, 3, 4, 3);
            reenterLine.Name = "reenterLine";
            reenterLine.Size = new Size(377, 2);
            reenterLine.TabIndex = 22;
            reenterLine.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(661, 83);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 32);
            label6.TabIndex = 21;
            label6.Text = "to join us!";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loadingTime
            // 
            loadingTime.Enabled = true;
            loadingTime.Interval = 70;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += onRegisterLoad;
            MouseDown += MainForm_MouseDown;
            MouseMove += onMove;
            MouseUp += MainForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)passwordLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhoneLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastnameLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstnameLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)reenterLine).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label5;
        private Button NextBtn;
        private TextBox PasswordText;
        private TextBox UsernameText;
        private PictureBox passwordLine;
        private PictureBox usernameLine;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
        private TextBox ReEnterPasswordText;
        private PictureBox reenterLine;
        private TextBox firstnameText;
        private PictureBox firstnameLine;
        private TextBox lastnameText;
        private PictureBox lastnameLine;
        private TextBox AddressText;
        private PictureBox pictureBox12;
        private TextBox EmailText;
        private PictureBox EmailLine;
        private TextBox PhoneText;
        private PictureBox PhoneLine;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private Label PhoneError;
        private Label EmailError;
        private Label MismatchError;
        private Label LastnameError;
        private Label FirstnameError;
        private Label UsernameError;
        private Label PasswordError;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label globalError;
        private CircularProgressBar.CircularProgressBar pbar;
        private System.Windows.Forms.Timer loadingTime;
    }
}