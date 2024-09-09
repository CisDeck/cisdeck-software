namespace Streamdeck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxSound9 = new TextBox();
            label10 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBoxSound1 = new TextBox();
            browseButton1 = new Button();
            label3 = new Label();
            browseButton2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxSound3 = new TextBox();
            label9 = new Label();
            browseButton3 = new Button();
            browseButton4 = new Button();
            browseButton5 = new Button();
            browseButton6 = new Button();
            browseButton7 = new Button();
            browseButton8 = new Button();
            browseButton9 = new Button();
            textBoxSound2 = new TextBox();
            textBoxSound4 = new TextBox();
            textBoxSound5 = new TextBox();
            textBoxSound6 = new TextBox();
            textBoxSound7 = new TextBox();
            textBoxSound8 = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            textBoxA = new TextBox();
            browseProgramButton1 = new Button();
            label15 = new Label();
            browseProgramButton2 = new Button();
            label16 = new Label();
            textBoxC = new TextBox();
            browseProgramButton3 = new Button();
            browseProgramButton4 = new Button();
            textBoxB = new TextBox();
            textBoxD = new TextBox();
            panel4 = new Panel();
            label17 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            starScriptBox = new TextBox();
            panel3 = new Panel();
            applyButton = new Button();
            textBoxPort = new TextBox();
            connectButton = new Button();
            connectedLabel = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.numpad_4x4;
            pictureBox1.Location = new Point(327, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.3353043F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.6646957F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 312F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 378F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 3, 0);
            tableLayoutPanel1.Controls.Add(panel3, 5, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 4, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1840, 462);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 35, 35);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 456);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 26);
            label1.TabIndex = 0;
            label1.Text = "Sounds Allocation";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9156628F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.0843353F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.Controls.Add(textBoxSound9, 0, 8);
            tableLayoutPanel2.Controls.Add(label10, 0, 8);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxSound1, 1, 0);
            tableLayoutPanel2.Controls.Add(browseButton1, 2, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(browseButton2, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 5);
            tableLayoutPanel2.Controls.Add(label8, 0, 6);
            tableLayoutPanel2.Controls.Add(textBoxSound3, 1, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 7);
            tableLayoutPanel2.Controls.Add(browseButton3, 2, 2);
            tableLayoutPanel2.Controls.Add(browseButton4, 2, 3);
            tableLayoutPanel2.Controls.Add(browseButton5, 2, 4);
            tableLayoutPanel2.Controls.Add(browseButton6, 2, 5);
            tableLayoutPanel2.Controls.Add(browseButton7, 2, 6);
            tableLayoutPanel2.Controls.Add(browseButton8, 2, 7);
            tableLayoutPanel2.Controls.Add(browseButton9, 2, 8);
            tableLayoutPanel2.Controls.Add(textBoxSound2, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxSound4, 1, 3);
            tableLayoutPanel2.Controls.Add(textBoxSound5, 1, 4);
            tableLayoutPanel2.Controls.Add(textBoxSound6, 1, 5);
            tableLayoutPanel2.Controls.Add(textBoxSound7, 1, 6);
            tableLayoutPanel2.Controls.Add(textBoxSound8, 1, 7);
            tableLayoutPanel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableLayoutPanel2.Location = new Point(3, 52);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.Size = new Size(301, 404);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxSound9
            // 
            textBoxSound9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound9.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound9.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound9.Font = new Font("Arial", 9F);
            textBoxSound9.ForeColor = Color.White;
            textBoxSound9.Location = new Point(68, 355);
            textBoxSound9.Name = "textBoxSound9";
            textBoxSound9.Size = new Size(154, 21);
            textBoxSound9.TabIndex = 26;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 352);
            label10.Name = "label10";
            label10.Size = new Size(59, 52);
            label10.TabIndex = 12;
            label10.Text = "9";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 88);
            label4.Name = "label4";
            label4.Size = new Size(59, 44);
            label4.TabIndex = 6;
            label4.Text = "3";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 44);
            label2.TabIndex = 0;
            label2.Text = "1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSound1
            // 
            textBoxSound1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound1.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound1.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound1.Font = new Font("Arial", 9F);
            textBoxSound1.ForeColor = Color.White;
            textBoxSound1.Location = new Point(68, 3);
            textBoxSound1.Name = "textBoxSound1";
            textBoxSound1.Size = new Size(154, 21);
            textBoxSound1.TabIndex = 1;
            // 
            // browseButton1
            // 
            browseButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton1.ForeColor = Color.White;
            browseButton1.Location = new Point(228, 3);
            browseButton1.Name = "browseButton1";
            browseButton1.Size = new Size(70, 38);
            browseButton1.TabIndex = 2;
            browseButton1.Text = "Browse";
            browseButton1.UseVisualStyleBackColor = true;
            browseButton1.Click += browseButton1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(59, 44);
            label3.TabIndex = 3;
            label3.Text = "2";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // browseButton2
            // 
            browseButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton2.ForeColor = Color.White;
            browseButton2.Location = new Point(228, 47);
            browseButton2.Name = "browseButton2";
            browseButton2.Size = new Size(70, 38);
            browseButton2.TabIndex = 5;
            browseButton2.Text = "Browse";
            browseButton2.UseVisualStyleBackColor = true;
            browseButton2.Click += browseButton2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(59, 44);
            label5.TabIndex = 7;
            label5.Text = "4";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 176);
            label6.Name = "label6";
            label6.Size = new Size(59, 44);
            label6.TabIndex = 8;
            label6.Text = "5";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 220);
            label7.Name = "label7";
            label7.Size = new Size(59, 44);
            label7.TabIndex = 9;
            label7.Text = "6";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 264);
            label8.Name = "label8";
            label8.Size = new Size(59, 44);
            label8.TabIndex = 10;
            label8.Text = "7";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSound3
            // 
            textBoxSound3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound3.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound3.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound3.Font = new Font("Arial", 9F);
            textBoxSound3.ForeColor = Color.White;
            textBoxSound3.Location = new Point(68, 91);
            textBoxSound3.Name = "textBoxSound3";
            textBoxSound3.Size = new Size(154, 21);
            textBoxSound3.TabIndex = 4;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 308);
            label9.Name = "label9";
            label9.Size = new Size(59, 44);
            label9.TabIndex = 11;
            label9.Text = "8";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // browseButton3
            // 
            browseButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton3.ForeColor = Color.White;
            browseButton3.Location = new Point(228, 91);
            browseButton3.Name = "browseButton3";
            browseButton3.Size = new Size(70, 38);
            browseButton3.TabIndex = 13;
            browseButton3.Text = "Browse";
            browseButton3.UseVisualStyleBackColor = true;
            browseButton3.Click += browseButton3_Click;
            // 
            // browseButton4
            // 
            browseButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton4.ForeColor = Color.White;
            browseButton4.Location = new Point(228, 135);
            browseButton4.Name = "browseButton4";
            browseButton4.Size = new Size(70, 38);
            browseButton4.TabIndex = 14;
            browseButton4.Text = "Browse";
            browseButton4.UseVisualStyleBackColor = true;
            browseButton4.Click += browseButton4_Click;
            // 
            // browseButton5
            // 
            browseButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton5.ForeColor = Color.White;
            browseButton5.Location = new Point(228, 179);
            browseButton5.Name = "browseButton5";
            browseButton5.Size = new Size(70, 38);
            browseButton5.TabIndex = 15;
            browseButton5.Text = "Browse";
            browseButton5.UseVisualStyleBackColor = true;
            browseButton5.Click += browseButton5_Click;
            // 
            // browseButton6
            // 
            browseButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton6.ForeColor = Color.White;
            browseButton6.Location = new Point(228, 223);
            browseButton6.Name = "browseButton6";
            browseButton6.Size = new Size(70, 38);
            browseButton6.TabIndex = 16;
            browseButton6.Text = "Browse";
            browseButton6.UseVisualStyleBackColor = true;
            browseButton6.Click += browseButton6_Click;
            // 
            // browseButton7
            // 
            browseButton7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton7.ForeColor = Color.White;
            browseButton7.Location = new Point(228, 267);
            browseButton7.Name = "browseButton7";
            browseButton7.Size = new Size(70, 38);
            browseButton7.TabIndex = 17;
            browseButton7.Text = "Browse";
            browseButton7.UseVisualStyleBackColor = true;
            browseButton7.Click += browseButton7_Click;
            // 
            // browseButton8
            // 
            browseButton8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton8.ForeColor = Color.White;
            browseButton8.Location = new Point(228, 311);
            browseButton8.Name = "browseButton8";
            browseButton8.Size = new Size(70, 38);
            browseButton8.TabIndex = 18;
            browseButton8.Text = "Browse";
            browseButton8.UseVisualStyleBackColor = true;
            browseButton8.Click += browseButton8_Click;
            // 
            // browseButton9
            // 
            browseButton9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton9.ForeColor = Color.White;
            browseButton9.Location = new Point(228, 355);
            browseButton9.Name = "browseButton9";
            browseButton9.Size = new Size(70, 46);
            browseButton9.TabIndex = 19;
            browseButton9.Text = "Browse";
            browseButton9.UseVisualStyleBackColor = true;
            browseButton9.Click += browseButton9_Click;
            // 
            // textBoxSound2
            // 
            textBoxSound2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound2.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound2.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound2.Font = new Font("Arial", 9F);
            textBoxSound2.ForeColor = Color.White;
            textBoxSound2.Location = new Point(68, 47);
            textBoxSound2.Name = "textBoxSound2";
            textBoxSound2.Size = new Size(154, 21);
            textBoxSound2.TabIndex = 20;
            // 
            // textBoxSound4
            // 
            textBoxSound4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound4.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound4.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound4.Font = new Font("Arial", 9F);
            textBoxSound4.ForeColor = Color.White;
            textBoxSound4.Location = new Point(68, 135);
            textBoxSound4.Name = "textBoxSound4";
            textBoxSound4.Size = new Size(154, 21);
            textBoxSound4.TabIndex = 21;
            // 
            // textBoxSound5
            // 
            textBoxSound5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound5.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound5.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound5.Font = new Font("Arial", 9F);
            textBoxSound5.ForeColor = Color.White;
            textBoxSound5.Location = new Point(68, 179);
            textBoxSound5.Name = "textBoxSound5";
            textBoxSound5.Size = new Size(154, 21);
            textBoxSound5.TabIndex = 22;
            // 
            // textBoxSound6
            // 
            textBoxSound6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound6.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound6.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound6.Font = new Font("Arial", 9F);
            textBoxSound6.ForeColor = Color.White;
            textBoxSound6.Location = new Point(68, 223);
            textBoxSound6.Name = "textBoxSound6";
            textBoxSound6.Size = new Size(154, 21);
            textBoxSound6.TabIndex = 23;
            // 
            // textBoxSound7
            // 
            textBoxSound7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound7.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound7.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound7.Font = new Font("Arial", 9F);
            textBoxSound7.ForeColor = Color.White;
            textBoxSound7.Location = new Point(68, 267);
            textBoxSound7.Name = "textBoxSound7";
            textBoxSound7.Size = new Size(154, 21);
            textBoxSound7.TabIndex = 24;
            // 
            // textBoxSound8
            // 
            textBoxSound8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxSound8.BackColor = Color.FromArgb(35, 35, 35);
            textBoxSound8.BorderStyle = BorderStyle.FixedSingle;
            textBoxSound8.Font = new Font("Arial", 9F);
            textBoxSound8.ForeColor = Color.White;
            textBoxSound8.Location = new Point(68, 311);
            textBoxSound8.Name = "textBoxSound8";
            textBoxSound8.Size = new Size(154, 21);
            textBoxSound8.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 35, 35);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Location = new Point(660, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 456);
            panel2.TabIndex = 3;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(202, 26);
            label11.TabIndex = 0;
            label11.Text = "Programs Allocation";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9156628F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.0843353F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel3.Controls.Add(label13, 0, 2);
            tableLayoutPanel3.Controls.Add(label14, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxA, 1, 0);
            tableLayoutPanel3.Controls.Add(browseProgramButton1, 2, 0);
            tableLayoutPanel3.Controls.Add(label15, 0, 1);
            tableLayoutPanel3.Controls.Add(browseProgramButton2, 2, 1);
            tableLayoutPanel3.Controls.Add(label16, 0, 3);
            tableLayoutPanel3.Controls.Add(textBoxC, 1, 2);
            tableLayoutPanel3.Controls.Add(browseProgramButton3, 2, 2);
            tableLayoutPanel3.Controls.Add(browseProgramButton4, 2, 3);
            tableLayoutPanel3.Controls.Add(textBoxB, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxD, 1, 3);
            tableLayoutPanel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableLayoutPanel3.Location = new Point(3, 52);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(301, 176);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 88);
            label13.Name = "label13";
            label13.Size = new Size(59, 44);
            label13.TabIndex = 6;
            label13.Text = "C";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(59, 44);
            label14.TabIndex = 0;
            label14.Text = "A";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxA
            // 
            textBoxA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxA.BackColor = Color.FromArgb(35, 35, 35);
            textBoxA.BorderStyle = BorderStyle.FixedSingle;
            textBoxA.Font = new Font("Arial", 9F);
            textBoxA.ForeColor = Color.White;
            textBoxA.Location = new Point(68, 3);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(154, 21);
            textBoxA.TabIndex = 1;
            // 
            // browseProgramButton1
            // 
            browseProgramButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseProgramButton1.ForeColor = Color.White;
            browseProgramButton1.Location = new Point(228, 3);
            browseProgramButton1.Name = "browseProgramButton1";
            browseProgramButton1.Size = new Size(70, 38);
            browseProgramButton1.TabIndex = 2;
            browseProgramButton1.Text = "Browse";
            browseProgramButton1.UseVisualStyleBackColor = true;
            browseProgramButton1.Click += browseProgramButton1_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(3, 44);
            label15.Name = "label15";
            label15.Size = new Size(59, 44);
            label15.TabIndex = 3;
            label15.Text = "B";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // browseProgramButton2
            // 
            browseProgramButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseProgramButton2.ForeColor = Color.White;
            browseProgramButton2.Location = new Point(228, 47);
            browseProgramButton2.Name = "browseProgramButton2";
            browseProgramButton2.Size = new Size(70, 38);
            browseProgramButton2.TabIndex = 5;
            browseProgramButton2.Text = "Browse";
            browseProgramButton2.UseVisualStyleBackColor = true;
            browseProgramButton2.Click += browseProgramButton2_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(3, 132);
            label16.Name = "label16";
            label16.Size = new Size(59, 44);
            label16.TabIndex = 7;
            label16.Text = "D";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxC
            // 
            textBoxC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxC.BackColor = Color.FromArgb(35, 35, 35);
            textBoxC.BorderStyle = BorderStyle.FixedSingle;
            textBoxC.Font = new Font("Arial", 9F);
            textBoxC.ForeColor = Color.White;
            textBoxC.Location = new Point(68, 91);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(154, 21);
            textBoxC.TabIndex = 4;
            // 
            // browseProgramButton3
            // 
            browseProgramButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseProgramButton3.ForeColor = Color.White;
            browseProgramButton3.Location = new Point(228, 91);
            browseProgramButton3.Name = "browseProgramButton3";
            browseProgramButton3.Size = new Size(70, 38);
            browseProgramButton3.TabIndex = 13;
            browseProgramButton3.Text = "Browse";
            browseProgramButton3.UseVisualStyleBackColor = true;
            browseProgramButton3.Click += browseProgramButton3_Click;
            // 
            // browseProgramButton4
            // 
            browseProgramButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseProgramButton4.ForeColor = Color.White;
            browseProgramButton4.Location = new Point(228, 135);
            browseProgramButton4.Name = "browseProgramButton4";
            browseProgramButton4.Size = new Size(70, 38);
            browseProgramButton4.TabIndex = 14;
            browseProgramButton4.Text = "Browse";
            browseProgramButton4.UseVisualStyleBackColor = true;
            browseProgramButton4.Click += browseProgramButton4_Click;
            // 
            // textBoxB
            // 
            textBoxB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxB.BackColor = Color.FromArgb(35, 35, 35);
            textBoxB.BorderStyle = BorderStyle.FixedSingle;
            textBoxB.Font = new Font("Arial", 9F);
            textBoxB.ForeColor = Color.White;
            textBoxB.Location = new Point(68, 47);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(154, 21);
            textBoxB.TabIndex = 20;
            // 
            // textBoxD
            // 
            textBoxD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxD.BackColor = Color.FromArgb(35, 35, 35);
            textBoxD.BorderStyle = BorderStyle.FixedSingle;
            textBoxD.Font = new Font("Arial", 9F);
            textBoxD.ForeColor = Color.White;
            textBoxD.Location = new Point(68, 135);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(154, 21);
            textBoxD.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 35, 35);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Location = new Point(972, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 456);
            panel4.TabIndex = 5;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(189, 26);
            label17.TabIndex = 0;
            label17.Text = "Specials Allocation";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel4.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel4.Controls.Add(label18, 0, 2);
            tableLayoutPanel4.Controls.Add(label19, 0, 0);
            tableLayoutPanel4.Controls.Add(label20, 0, 1);
            tableLayoutPanel4.Controls.Add(starScriptBox, 1, 0);
            tableLayoutPanel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableLayoutPanel4.Location = new Point(14, 52);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(342, 384);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.AcceptsTab = true;
            textBox2.Location = new Point(125, 259);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 109);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Location = new Point(125, 131);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 109);
            textBox1.TabIndex = 7;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(3, 256);
            label18.Name = "label18";
            label18.Size = new Size(116, 128);
            label18.TabIndex = 6;
            label18.Text = "0";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(116, 128);
            label19.TabIndex = 0;
            label19.Text = "*";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(3, 128);
            label20.Name = "label20";
            label20.Size = new Size(116, 128);
            label20.TabIndex = 3;
            label20.Text = "#";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // starScriptBox
            // 
            starScriptBox.AcceptsTab = true;
            starScriptBox.Location = new Point(125, 3);
            starScriptBox.Multiline = true;
            starScriptBox.Name = "starScriptBox";
            starScriptBox.Size = new Size(210, 109);
            starScriptBox.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(applyButton);
            panel3.Controls.Add(textBoxPort);
            panel3.Controls.Add(connectButton);
            panel3.Controls.Add(connectedLabel);
            panel3.Location = new Point(1684, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 453);
            panel3.TabIndex = 4;
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyButton.BackColor = Color.Gray;
            applyButton.FlatAppearance.BorderColor = Color.Black;
            applyButton.FlatAppearance.MouseDownBackColor = Color.Black;
            applyButton.FlatAppearance.MouseOverBackColor = Color.Black;
            applyButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applyButton.ForeColor = Color.White;
            applyButton.Location = new Point(7, 391);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(86, 49);
            applyButton.TabIndex = 2;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(7, 72);
            textBoxPort.Multiline = true;
            textBoxPort.Name = "textBoxPort";
            textBoxPort.PlaceholderText = "Serial Port";
            textBoxPort.Size = new Size(86, 38);
            textBoxPort.TabIndex = 5;
            textBoxPort.TextAlign = HorizontalAlignment.Center;
            // 
            // connectButton
            // 
            connectButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            connectButton.BackColor = Color.Gray;
            connectButton.FlatAppearance.BorderColor = Color.Black;
            connectButton.FlatAppearance.MouseDownBackColor = Color.Black;
            connectButton.FlatAppearance.MouseOverBackColor = Color.Black;
            connectButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connectButton.ForeColor = Color.White;
            connectButton.Location = new Point(7, 13);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(86, 49);
            connectButton.TabIndex = 4;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = false;
            connectButton.Click += connectButton_Click;
            // 
            // connectedLabel
            // 
            connectedLabel.AutoSize = true;
            connectedLabel.ForeColor = Color.Red;
            connectedLabel.Location = new Point(10, 120);
            connectedLabel.Name = "connectedLabel";
            connectedLabel.Size = new Size(78, 15);
            connectedLabel.TabIndex = 3;
            connectedLabel.Text = "Unconnected";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1350, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 453);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1884, 491);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "CisDeck";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox1_MouseClick1(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox1_MouseLeave1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label4;
        private TextBox textBoxSound3;
        private TextBox textBoxSound1;
        private Button browseButton1;
        private Label label3;
        private Button browseButton2;
        private Label label5;
        private Label label6;
        private Label label7;
        private ContextMenuStrip contextMenuStrip2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button browseButton3;
        private Button browseButton4;
        private Button browseButton5;
        private Button browseButton6;
        private Button browseButton7;
        private Button browseButton8;
        private Button browseButton9;
        private TextBox textBoxSound9;
        private TextBox textBoxSound2;
        private TextBox textBoxSound4;
        private TextBox textBoxSound5;
        private TextBox textBoxSound6;
        private TextBox textBoxSound7;
        private TextBox textBoxSound8;
        private Panel panel2;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label13;
        private Label label14;
        private TextBox textBoxA;
        private Button browseProgramButton1;
        private Label label15;
        private Button browseProgramButton2;
        private Label label16;
        private TextBox textBoxC;
        private Button browseProgramButton3;
        private Button browseProgramButton4;
        private TextBox textBoxB;
        private TextBox textBoxD;
        private System.Windows.Forms.Timer timer1;
        private TextBox starScriptBox;
        private Panel panel4;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label18;
        private Label label19;
        private Label label20;
        private Panel panel3;
        private TextBox textBoxPort;
        private Button connectButton;
        private Label connectedLabel;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button applyButton;
        private PictureBox pictureBox2;
    }
}
