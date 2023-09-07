namespace Library_Windows_Application.Forms
{
    partial class MembershipForm
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
            label4 = new Label();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            PlanA = new Panel();
            label10 = new Label();
            pictureBox10 = new PictureBox();
            label21 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox4 = new PictureBox();
            PlanASelected = new Button();
            label15 = new Label();
            label5 = new Label();
            label3 = new Label();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            PlanC = new Panel();
            label22 = new Label();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox12 = new PictureBox();
            label2 = new Label();
            PlanCSelected = new Button();
            label17 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label18 = new Label();
            PlanB = new Panel();
            label6 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox9 = new PictureBox();
            PlanBSelected = new Button();
            label20 = new Label();
            label19 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            CompletePayment = new Button();
            button5 = new Button();
            pictureBox6 = new PictureBox();
            Back = new Button();
            priceDetail1 = new Label();
            priceTag = new Label();
            priceDetail2 = new Label();
            globalError = new Label();
            pbar = new CircularProgressBar.CircularProgressBar();
            loadingLabel = new Label();
            loadingTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            PlanA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PlanC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PlanB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(-1, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(995, 65);
            label4.TabIndex = 3;
            label4.Text = "Memberships Plans";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.MouseDown += MainForm_MouseDown;
            label4.MouseMove += onMove;
            label4.MouseUp += MainForm_MouseUp;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(-1, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(995, 65);
            label1.TabIndex = 4;
            label1.Text = "Choose your suitable plan to begin your journey";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Blue;
            pictureBox7.Location = new Point(570, 72);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(300, 3);
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // PlanA
            // 
            PlanA.BackColor = Color.Blue;
            PlanA.Controls.Add(label10);
            PlanA.Controls.Add(pictureBox10);
            PlanA.Controls.Add(label21);
            PlanA.Controls.Add(pictureBox11);
            PlanA.Controls.Add(pictureBox4);
            PlanA.Controls.Add(PlanASelected);
            PlanA.Controls.Add(label15);
            PlanA.Controls.Add(label5);
            PlanA.Controls.Add(label3);
            PlanA.Controls.Add(label16);
            PlanA.Controls.Add(pictureBox1);
            PlanA.Location = new Point(27, 197);
            PlanA.Name = "PlanA";
            PlanA.Size = new Size(284, 335);
            PlanA.TabIndex = 23;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DodgerBlue;
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(130, 172);
            label10.Name = "label10";
            label10.Size = new Size(103, 36);
            label10.TabIndex = 32;
            label10.Text = "/month";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.shape;
            pictureBox10.Location = new Point(250, 102);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 96);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 30;
            pictureBox10.TabStop = false;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(0, 102);
            label21.Name = "label21";
            label21.Size = new Size(284, 53);
            label21.TabIndex = 31;
            label21.Text = "Plan A";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.shape;
            pictureBox11.Location = new Point(-62, 243);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(100, 96);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 30;
            pictureBox11.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.shape;
            pictureBox4.Location = new Point(-40, -13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 96);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // PlanASelected
            // 
            PlanASelected.BackColor = Color.Aqua;
            PlanASelected.BackgroundImageLayout = ImageLayout.None;
            PlanASelected.Cursor = Cursors.Hand;
            PlanASelected.FlatAppearance.BorderColor = Color.White;
            PlanASelected.FlatAppearance.BorderSize = 0;
            PlanASelected.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            PlanASelected.FlatStyle = FlatStyle.Flat;
            PlanASelected.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            PlanASelected.ForeColor = Color.Blue;
            PlanASelected.Location = new Point(77, 290);
            PlanASelected.Name = "PlanASelected";
            PlanASelected.Size = new Size(143, 46);
            PlanASelected.TabIndex = 28;
            PlanASelected.Text = "Select Plan";
            PlanASelected.UseVisualStyleBackColor = false;
            PlanASelected.Click += PlanAisSelected;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(0, 218);
            label15.Name = "label15";
            label15.Size = new Size(284, 36);
            label15.TabIndex = 28;
            label15.Text = "You can borrow up to:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(90, 176);
            label5.Name = "label5";
            label5.Size = new Size(53, 36);
            label5.TabIndex = 28;
            label5.Text = ".99";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 160);
            label3.Name = "label3";
            label3.Size = new Size(37, 58);
            label3.TabIndex = 27;
            label3.Text = "9";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DodgerBlue;
            label16.Location = new Point(0, 241);
            label16.Name = "label16";
            label16.Size = new Size(284, 36);
            label16.TabIndex = 30;
            label16.Text = "3 Books";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.Regular_Plan;
            pictureBox1.Location = new Point(0, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += MainForm_MouseDown;
            pictureBox1.MouseMove += onMove;
            pictureBox1.MouseUp += MainForm_MouseUp;
            // 
            // PlanC
            // 
            PlanC.BackColor = Color.MediumBlue;
            PlanC.Controls.Add(label22);
            PlanC.Controls.Add(pictureBox14);
            PlanC.Controls.Add(pictureBox13);
            PlanC.Controls.Add(pictureBox12);
            PlanC.Controls.Add(label2);
            PlanC.Controls.Add(PlanCSelected);
            PlanC.Controls.Add(label17);
            PlanC.Controls.Add(label8);
            PlanC.Controls.Add(pictureBox3);
            PlanC.Controls.Add(label9);
            PlanC.Controls.Add(label18);
            PlanC.Location = new Point(683, 197);
            PlanC.Name = "PlanC";
            PlanC.Size = new Size(284, 335);
            PlanC.TabIndex = 24;
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.DodgerBlue;
            label22.ImageAlign = ContentAlignment.MiddleLeft;
            label22.Location = new Point(145, 172);
            label22.Name = "label22";
            label22.Size = new Size(103, 36);
            label22.TabIndex = 33;
            label22.Text = "/month";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.shape;
            pictureBox14.Location = new Point(238, 106);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(100, 96);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 30;
            pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.shape;
            pictureBox13.Location = new Point(189, -57);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(100, 96);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 30;
            pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.shape;
            pictureBox12.Location = new Point(-54, 25);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 96);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 30;
            pictureBox12.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 102);
            label2.Name = "label2";
            label2.Size = new Size(284, 53);
            label2.TabIndex = 35;
            label2.Text = "Plan C";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlanCSelected
            // 
            PlanCSelected.BackColor = Color.Aqua;
            PlanCSelected.BackgroundImageLayout = ImageLayout.None;
            PlanCSelected.Cursor = Cursors.Hand;
            PlanCSelected.FlatAppearance.BorderColor = Color.White;
            PlanCSelected.FlatAppearance.BorderSize = 0;
            PlanCSelected.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            PlanCSelected.FlatStyle = FlatStyle.Flat;
            PlanCSelected.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            PlanCSelected.ForeColor = Color.Blue;
            PlanCSelected.Location = new Point(75, 290);
            PlanCSelected.Name = "PlanCSelected";
            PlanCSelected.Size = new Size(143, 46);
            PlanCSelected.TabIndex = 34;
            PlanCSelected.Text = "Select Plan";
            PlanCSelected.UseVisualStyleBackColor = false;
            PlanCSelected.Click += PlanCisSelected;
            PlanCSelected.MouseDown += MainForm_MouseDown;
            PlanCSelected.MouseMove += onMove;
            PlanCSelected.MouseUp += MainForm_MouseUp;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(0, 218);
            label17.Name = "label17";
            label17.Size = new Size(284, 36);
            label17.TabIndex = 31;
            label17.Text = "You can borrow up to:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(105, 176);
            label8.Name = "label8";
            label8.Size = new Size(53, 36);
            label8.TabIndex = 32;
            label8.Text = ".99";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Enabled = false;
            pictureBox3.Image = Properties.Resources.Mega_Plan;
            pictureBox3.Location = new Point(0, -13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(284, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += MainForm_MouseDown;
            pictureBox3.MouseMove += onMove;
            pictureBox3.MouseUp += MainForm_MouseUp;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(52, 161);
            label9.Name = "label9";
            label9.Size = new Size(73, 58);
            label9.TabIndex = 31;
            label9.Text = "25";
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.DodgerBlue;
            label18.Location = new Point(0, 241);
            label18.Name = "label18";
            label18.Size = new Size(284, 36);
            label18.TabIndex = 31;
            label18.Text = "9 Books";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlanB
            // 
            PlanB.BackColor = Color.Navy;
            PlanB.Controls.Add(label6);
            PlanB.Controls.Add(pictureBox8);
            PlanB.Controls.Add(pictureBox5);
            PlanB.Controls.Add(pictureBox15);
            PlanB.Controls.Add(pictureBox9);
            PlanB.Controls.Add(PlanBSelected);
            PlanB.Controls.Add(label20);
            PlanB.Controls.Add(label19);
            PlanB.Controls.Add(label12);
            PlanB.Controls.Add(label13);
            PlanB.Controls.Add(label14);
            PlanB.Controls.Add(pictureBox2);
            PlanB.Location = new Point(361, 146);
            PlanB.Name = "PlanB";
            PlanB.Size = new Size(284, 421);
            PlanB.TabIndex = 24;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(144, 201);
            label6.Name = "label6";
            label6.Size = new Size(143, 44);
            label6.TabIndex = 34;
            label6.Text = "/month";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.shape;
            pictureBox8.Location = new Point(-54, 72);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 96);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 30;
            pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.best;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.shape;
            pictureBox15.Location = new Point(216, -26);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(100, 96);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 30;
            pictureBox15.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.shape;
            pictureBox9.Location = new Point(249, 299);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 96);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 30;
            pictureBox9.TabStop = false;
            // 
            // PlanBSelected
            // 
            PlanBSelected.BackColor = Color.Aqua;
            PlanBSelected.BackgroundImageLayout = ImageLayout.None;
            PlanBSelected.Cursor = Cursors.Hand;
            PlanBSelected.FlatAppearance.BorderColor = Color.White;
            PlanBSelected.FlatAppearance.BorderSize = 0;
            PlanBSelected.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            PlanBSelected.FlatStyle = FlatStyle.Flat;
            PlanBSelected.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            PlanBSelected.ForeColor = Color.Blue;
            PlanBSelected.Location = new Point(72, 375);
            PlanBSelected.Name = "PlanBSelected";
            PlanBSelected.Size = new Size(143, 46);
            PlanBSelected.TabIndex = 35;
            PlanBSelected.Text = "Select Plan";
            PlanBSelected.UseVisualStyleBackColor = false;
            PlanBSelected.Click += PlanBisSelected;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.DodgerBlue;
            label20.Location = new Point(0, 293);
            label20.Name = "label20";
            label20.Size = new Size(284, 36);
            label20.TabIndex = 34;
            label20.Text = "6 Books";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(0, 266);
            label19.Name = "label19";
            label19.Size = new Size(284, 36);
            label19.TabIndex = 29;
            label19.Text = "You can borrow up to:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(90, 202);
            label12.Name = "label12";
            label12.Size = new Size(69, 64);
            label12.TabIndex = 32;
            label12.Text = ".99";
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(17, 185);
            label13.Name = "label13";
            label13.Size = new Size(97, 81);
            label13.TabIndex = 31;
            label13.Text = "18";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(0, 119);
            label14.Name = "label14";
            label14.Size = new Size(284, 53);
            label14.TabIndex = 30;
            label14.Text = "Plan B";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.Premium_Plan;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += MainForm_MouseDown;
            pictureBox2.MouseMove += onMove;
            pictureBox2.MouseUp += MainForm_MouseUp;
            // 
            // CompletePayment
            // 
            CompletePayment.BackColor = Color.Blue;
            CompletePayment.Cursor = Cursors.Hand;
            CompletePayment.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            CompletePayment.ForeColor = Color.White;
            CompletePayment.Location = new Point(402, 634);
            CompletePayment.Name = "CompletePayment";
            CompletePayment.Size = new Size(206, 56);
            CompletePayment.TabIndex = 27;
            CompletePayment.Text = "Complete Payment";
            CompletePayment.UseVisualStyleBackColor = false;
            CompletePayment.Visible = false;
            CompletePayment.Click += PaymentClick;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Blue;
            button5.Location = new Point(947, 0);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(47, 46);
            button5.TabIndex = 28;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += X_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.shape;
            pictureBox6.Location = new Point(-145, -197);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(302, 388);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            pictureBox6.MouseDown += MainForm_MouseDown;
            pictureBox6.MouseMove += onMove;
            pictureBox6.MouseUp += MainForm_MouseUp;
            // 
            // Back
            // 
            Back.BackColor = Color.Blue;
            Back.Cursor = Cursors.Hand;
            Back.FlatAppearance.BorderSize = 0;
            Back.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Back.ForeColor = Color.White;
            Back.Location = new Point(27, 9);
            Back.Name = "Back";
            Back.Size = new Size(82, 37);
            Back.TabIndex = 32;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // priceDetail1
            // 
            priceDetail1.BackColor = Color.Transparent;
            priceDetail1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            priceDetail1.ForeColor = Color.Black;
            priceDetail1.Location = new Point(339, 584);
            priceDetail1.Name = "priceDetail1";
            priceDetail1.Size = new Size(157, 36);
            priceDetail1.TabIndex = 33;
            priceDetail1.Text = "Your need to pay";
            priceDetail1.TextAlign = ContentAlignment.MiddleLeft;
            priceDetail1.Visible = false;
            // 
            // priceTag
            // 
            priceTag.BackColor = Color.Transparent;
            priceTag.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            priceTag.ForeColor = Color.Black;
            priceTag.Location = new Point(492, 585);
            priceTag.Name = "priceTag";
            priceTag.Size = new Size(67, 36);
            priceTag.TabIndex = 34;
            priceTag.Text = "25.99$";
            priceTag.TextAlign = ContentAlignment.MiddleCenter;
            priceTag.Visible = false;
            // 
            // priceDetail2
            // 
            priceDetail2.BackColor = Color.Transparent;
            priceDetail2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            priceDetail2.ForeColor = Color.Black;
            priceDetail2.Location = new Point(555, 584);
            priceDetail2.Name = "priceDetail2";
            priceDetail2.Size = new Size(114, 36);
            priceDetail2.TabIndex = 35;
            priceDetail2.Text = "to procceed";
            priceDetail2.TextAlign = ContentAlignment.MiddleLeft;
            priceDetail2.Visible = false;
            // 
            // globalError
            // 
            globalError.BackColor = Color.Transparent;
            globalError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            globalError.ForeColor = Color.Red;
            globalError.Location = new Point(735, 654);
            globalError.Margin = new Padding(4, 0, 4, 0);
            globalError.Name = "globalError";
            globalError.Size = new Size(232, 26);
            globalError.TabIndex = 43;
            globalError.TextAlign = ContentAlignment.MiddleLeft;
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
            pbar.Location = new Point(629, 638);
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
            pbar.TabIndex = 46;
            pbar.Text = "25%";
            pbar.TextMargin = new Padding(2, 4, 0, 0);
            pbar.Value = 68;
            pbar.Visible = false;
            // 
            // loadingLabel
            // 
            loadingLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loadingLabel.ForeColor = Color.Blue;
            loadingLabel.Location = new Point(686, 654);
            loadingLabel.Margin = new Padding(4, 0, 4, 0);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(83, 20);
            loadingLabel.TabIndex = 47;
            loadingLabel.Text = "Loading...";
            loadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            loadingLabel.Visible = false;
            // 
            // loadingTime
            // 
            loadingTime.Enabled = true;
            loadingTime.Interval = 70;
            // MembershipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(993, 700);
            ControlBox = false;
            Controls.Add(loadingLabel);
            Controls.Add(pbar);
            Controls.Add(globalError);
            Controls.Add(priceTag);
            Controls.Add(priceDetail1);
            Controls.Add(Back);
            Controls.Add(pictureBox6);
            Controls.Add(button5);
            Controls.Add(CompletePayment);
            Controls.Add(PlanC);
            Controls.Add(PlanB);
            Controls.Add(PlanA);
            Controls.Add(pictureBox7);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(priceDetail2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MembershipForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MembershipForm";
            MouseDown += MainForm_MouseDown;
            MouseMove += onMove;
            MouseUp += MainForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            PlanA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PlanC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PlanB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label1;
        private PictureBox pictureBox7;
        private Panel PlanA;
        private Panel PlanC;
        private Panel PlanB;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label label3;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button CompletePayment;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label21;
        private Button PlanCSelected;
        private Button PlanBSelected;
        private Label label20;
        private Label label19;
        private Label label2;
        private Button button5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox15;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox6;
        private Button PlanASelected;
        private Label label10;
        private Label label22;
        private Label label6;
        private Button Back;
        private Label priceDetail1;
        private Label priceTag;
        private Label priceDetail2;
        private Label globalError;
        private CircularProgressBar.CircularProgressBar pbar;
        private Label loadingLabel;
        private System.Windows.Forms.Timer loadingTime;
    }
}