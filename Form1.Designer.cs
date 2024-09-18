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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Play Sound" }, -1, Color.White, Color.FromArgb(40, 40, 40), new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Launch" }, -1, Color.White, Color.FromArgb(40, 40, 40), new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            textBoxSound1 = new TextBox();
            browseButton1 = new Button();
            panel2 = new Panel();
            label11 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label14 = new Label();
            textBoxA = new TextBox();
            browseProgramButton1 = new Button();
            panel3 = new Panel();
            applyButton = new Button();
            textBoxPort = new TextBox();
            connectButton = new Button();
            connectedLabel = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            label17 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label19 = new Label();
            starScriptBox = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            listView1 = new ListView();
            imageList = new ImageList(components);
            numpad_4 = new PictureBox();
            numpad_5 = new PictureBox();
            numpad_6 = new PictureBox();
            numpad_7 = new PictureBox();
            numpad_8 = new PictureBox();
            numpad_9 = new PictureBox();
            numpad_star = new PictureBox();
            numpad_hashtag = new PictureBox();
            numpad_A = new PictureBox();
            numpad_B = new PictureBox();
            numpad_C = new PictureBox();
            numpad_3 = new PictureBox();
            numpad_2 = new PictureBox();
            numpad_0 = new PictureBox();
            numpad_D = new PictureBox();
            numpad_1 = new PictureBox();
            columnHeader1 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numpad_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_hashtag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_C).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_D).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numpad_1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.numpad_4x4;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 456);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 35, 35);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new Point(863, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 275);
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
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxSound1, 1, 0);
            tableLayoutPanel2.Controls.Add(browseButton1, 2, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableLayoutPanel2.Location = new Point(3, 45);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.Size = new Size(366, 209);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 209);
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
            textBoxSound1.Location = new Point(110, 3);
            textBoxSound1.Name = "textBoxSound1";
            textBoxSound1.Size = new Size(154, 21);
            textBoxSound1.TabIndex = 1;
            // 
            // browseButton1
            // 
            browseButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseButton1.ForeColor = Color.White;
            browseButton1.Location = new Point(293, 3);
            browseButton1.Name = "browseButton1";
            browseButton1.Size = new Size(70, 203);
            browseButton1.TabIndex = 2;
            browseButton1.Text = "Browse";
            browseButton1.UseVisualStyleBackColor = true;
            browseButton1.Click += browseButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 35, 35);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Location = new Point(1257, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 275);
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
            tableLayoutPanel3.Controls.Add(label14, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxA, 1, 0);
            tableLayoutPanel3.Controls.Add(browseProgramButton1, 2, 0);
            tableLayoutPanel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableLayoutPanel3.Location = new Point(3, 45);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(325, 206);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(66, 206);
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
            textBoxA.Location = new Point(83, 3);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(154, 21);
            textBoxA.TabIndex = 1;
            // 
            // browseProgramButton1
            // 
            browseProgramButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            browseProgramButton1.ForeColor = Color.White;
            browseProgramButton1.Location = new Point(252, 3);
            browseProgramButton1.Name = "browseProgramButton1";
            browseProgramButton1.Size = new Size(70, 200);
            browseProgramButton1.TabIndex = 2;
            browseProgramButton1.Text = "Browse";
            browseProgramButton1.UseVisualStyleBackColor = true;
            browseProgramButton1.Click += browseProgramButton1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(applyButton);
            panel3.Controls.Add(textBoxPort);
            panel3.Controls.Add(connectButton);
            panel3.Controls.Add(connectedLabel);
            panel3.Location = new Point(1071, 666);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 273);
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
            applyButton.Location = new Point(292, 217);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(86, 49);
            applyButton.TabIndex = 2;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(3, 228);
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
            connectButton.Location = new Point(3, 166);
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
            connectedLabel.Location = new Point(7, 146);
            connectedLabel.Name = "connectedLabel";
            connectedLabel.Size = new Size(78, 15);
            connectedLabel.TabIndex = 3;
            connectedLabel.Text = "Unconnected";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.commandlist_black;
            pictureBox2.Location = new Point(692, 498);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(328, 453);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 35, 35);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Location = new Point(1448, 395);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 275);
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
            label17.Size = new Size(136, 26);
            label17.TabIndex = 0;
            label17.Text = "Custom Code";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(label19, 0, 0);
            tableLayoutPanel4.Controls.Add(starScriptBox, 1, 0);
            tableLayoutPanel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tableLayoutPanel4.Location = new Point(14, 45);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(342, 203);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(116, 203);
            label19.TabIndex = 0;
            label19.Text = "*";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // starScriptBox
            // 
            starScriptBox.AcceptsTab = true;
            starScriptBox.Location = new Point(125, 3);
            starScriptBox.Multiline = true;
            starScriptBox.Name = "starScriptBox";
            starScriptBox.Size = new Size(210, 197);
            starScriptBox.TabIndex = 2;
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
            // panel5
            // 
            panel5.Controls.Add(listView1);
            panel5.Controls.Add(numpad_4);
            panel5.Controls.Add(numpad_5);
            panel5.Controls.Add(numpad_6);
            panel5.Controls.Add(numpad_7);
            panel5.Controls.Add(numpad_8);
            panel5.Controls.Add(numpad_9);
            panel5.Controls.Add(numpad_star);
            panel5.Controls.Add(numpad_hashtag);
            panel5.Controls.Add(numpad_A);
            panel5.Controls.Add(numpad_B);
            panel5.Controls.Add(numpad_C);
            panel5.Controls.Add(numpad_3);
            panel5.Controls.Add(numpad_2);
            panel5.Controls.Add(numpad_0);
            panel5.Controls.Add(numpad_D);
            panel5.Controls.Add(numpad_1);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(1850, 942);
            panel5.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.BackColor = Color.FromArgb(24, 24, 24);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(334, 3);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(300, 456);
            listView1.StateImageList = imageList;
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.DrawItem += DrawListViewItem;
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "icons8-sound-50.png");
            imageList.Images.SetKeyName(1, "icon_rocket.png");
            // 
            // numpad_4
            // 
            numpad_4.Cursor = Cursors.Hand;
            numpad_4.Image = Properties.Resources._4;
            numpad_4.Location = new Point(44, 180);
            numpad_4.Name = "numpad_4";
            numpad_4.Size = new Size(48, 50);
            numpad_4.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_4.TabIndex = 21;
            numpad_4.TabStop = false;
            numpad_4.MouseClick += numpad_4_Click;
            numpad_4.MouseEnter += numpad_4_hover;
            numpad_4.MouseLeave += numpad_4_leave;
            // 
            // numpad_5
            // 
            numpad_5.Cursor = Cursors.Hand;
            numpad_5.Image = Properties.Resources._5;
            numpad_5.Location = new Point(108, 180);
            numpad_5.Name = "numpad_5";
            numpad_5.Size = new Size(48, 50);
            numpad_5.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_5.TabIndex = 20;
            numpad_5.TabStop = false;
            numpad_5.MouseClick += numpad_5_Click;
            numpad_5.MouseEnter += numpad_5_hover;
            numpad_5.MouseLeave += numpad_5_leave;
            // 
            // numpad_6
            // 
            numpad_6.Cursor = Cursors.Hand;
            numpad_6.Image = Properties.Resources._6;
            numpad_6.Location = new Point(173, 180);
            numpad_6.Name = "numpad_6";
            numpad_6.Size = new Size(48, 50);
            numpad_6.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_6.TabIndex = 19;
            numpad_6.TabStop = false;
            numpad_6.MouseClick += numpad_6_Click;
            numpad_6.MouseEnter += numpad_6_hover;
            numpad_6.MouseLeave += numpad_6_leave;
            // 
            // numpad_7
            // 
            numpad_7.Cursor = Cursors.Hand;
            numpad_7.Image = Properties.Resources._7;
            numpad_7.Location = new Point(44, 241);
            numpad_7.Name = "numpad_7";
            numpad_7.Size = new Size(48, 50);
            numpad_7.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_7.TabIndex = 18;
            numpad_7.TabStop = false;
            numpad_7.MouseClick += numpad_7_Click;
            numpad_7.MouseEnter += numpad_7_hover;
            numpad_7.MouseLeave += numpad_7_leave;
            // 
            // numpad_8
            // 
            numpad_8.Cursor = Cursors.Hand;
            numpad_8.Image = Properties.Resources._8;
            numpad_8.Location = new Point(108, 241);
            numpad_8.Name = "numpad_8";
            numpad_8.Size = new Size(48, 50);
            numpad_8.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_8.TabIndex = 17;
            numpad_8.TabStop = false;
            numpad_8.MouseClick += numpad_8_Click;
            numpad_8.MouseEnter += numpad_8_hover;
            numpad_8.MouseLeave += numpad_8_leave;
            // 
            // numpad_9
            // 
            numpad_9.Cursor = Cursors.Hand;
            numpad_9.Image = Properties.Resources._9;
            numpad_9.Location = new Point(173, 241);
            numpad_9.Name = "numpad_9";
            numpad_9.Size = new Size(48, 50);
            numpad_9.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_9.TabIndex = 16;
            numpad_9.TabStop = false;
            numpad_9.MouseClick += numpad_9_Click;
            numpad_9.MouseEnter += numpad_9_hover;
            numpad_9.MouseLeave += numpad_9_leave;
            // 
            // numpad_star
            // 
            numpad_star.Cursor = Cursors.Hand;
            numpad_star.Image = Properties.Resources.star;
            numpad_star.Location = new Point(44, 301);
            numpad_star.Name = "numpad_star";
            numpad_star.Size = new Size(48, 50);
            numpad_star.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_star.TabIndex = 15;
            numpad_star.TabStop = false;
            numpad_star.MouseClick += numpad_star_Click;
            numpad_star.MouseEnter += numpad_star_hover;
            numpad_star.MouseLeave += numpad_star_leave;
            // 
            // numpad_hashtag
            // 
            numpad_hashtag.Cursor = Cursors.Hand;
            numpad_hashtag.Image = Properties.Resources._;
            numpad_hashtag.Location = new Point(173, 301);
            numpad_hashtag.Name = "numpad_hashtag";
            numpad_hashtag.Size = new Size(48, 50);
            numpad_hashtag.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_hashtag.TabIndex = 14;
            numpad_hashtag.TabStop = false;
            numpad_hashtag.MouseClick += numpad_hashtag_Click;
            numpad_hashtag.MouseEnter += numpad_hashtag_hover;
            numpad_hashtag.MouseLeave += numpad_hashtag_leave;
            // 
            // numpad_A
            // 
            numpad_A.Cursor = Cursors.Hand;
            numpad_A.Image = Properties.Resources.A;
            numpad_A.Location = new Point(236, 120);
            numpad_A.Name = "numpad_A";
            numpad_A.Size = new Size(48, 50);
            numpad_A.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_A.TabIndex = 13;
            numpad_A.TabStop = false;
            numpad_A.MouseClick += numpad_A_Click;
            numpad_A.MouseEnter += numpad_A_hover;
            numpad_A.MouseLeave += numpad_A_leave;
            // 
            // numpad_B
            // 
            numpad_B.Cursor = Cursors.Hand;
            numpad_B.Image = Properties.Resources.B;
            numpad_B.Location = new Point(236, 180);
            numpad_B.Name = "numpad_B";
            numpad_B.Size = new Size(48, 50);
            numpad_B.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_B.TabIndex = 12;
            numpad_B.TabStop = false;
            numpad_B.MouseClick += numpad_B_Click;
            numpad_B.MouseEnter += numpad_B_hover;
            numpad_B.MouseLeave += numpad_B_leave;
            // 
            // numpad_C
            // 
            numpad_C.Cursor = Cursors.Hand;
            numpad_C.Image = Properties.Resources.C;
            numpad_C.Location = new Point(236, 241);
            numpad_C.Name = "numpad_C";
            numpad_C.Size = new Size(48, 50);
            numpad_C.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_C.TabIndex = 11;
            numpad_C.TabStop = false;
            numpad_C.MouseClick += numpad_C_Click;
            numpad_C.MouseEnter += numpad_C_hover;
            numpad_C.MouseLeave += numpad_C_leave;
            // 
            // numpad_3
            // 
            numpad_3.Cursor = Cursors.Hand;
            numpad_3.Image = Properties.Resources._3;
            numpad_3.Location = new Point(173, 120);
            numpad_3.Name = "numpad_3";
            numpad_3.Size = new Size(48, 50);
            numpad_3.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_3.TabIndex = 10;
            numpad_3.TabStop = false;
            numpad_3.MouseClick += numpad_3_Click;
            numpad_3.MouseEnter += numpad_3_hover;
            numpad_3.MouseLeave += numpad_3_leave;
            // 
            // numpad_2
            // 
            numpad_2.Cursor = Cursors.Hand;
            numpad_2.Image = Properties.Resources._2;
            numpad_2.Location = new Point(108, 120);
            numpad_2.Name = "numpad_2";
            numpad_2.Size = new Size(48, 50);
            numpad_2.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_2.TabIndex = 9;
            numpad_2.TabStop = false;
            numpad_2.MouseClick += numpad_2_Click;
            numpad_2.MouseEnter += numpad_2_hover;
            numpad_2.MouseLeave += numpad_2_leave;
            // 
            // numpad_0
            // 
            numpad_0.Cursor = Cursors.Hand;
            numpad_0.Image = Properties.Resources._0;
            numpad_0.Location = new Point(108, 301);
            numpad_0.Name = "numpad_0";
            numpad_0.Size = new Size(48, 50);
            numpad_0.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_0.TabIndex = 9;
            numpad_0.TabStop = false;
            numpad_0.MouseClick += numpad_0_Click;
            numpad_0.MouseEnter += numpad_0_hover;
            numpad_0.MouseLeave += numpad_0_leave;
            // 
            // numpad_D
            // 
            numpad_D.Cursor = Cursors.Hand;
            numpad_D.Image = Properties.Resources.D;
            numpad_D.Location = new Point(236, 301);
            numpad_D.Name = "numpad_D";
            numpad_D.Size = new Size(48, 50);
            numpad_D.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_D.TabIndex = 8;
            numpad_D.TabStop = false;
            numpad_D.MouseClick += numpad_D_Click;
            numpad_D.MouseEnter += numpad_D_hover;
            numpad_D.MouseLeave += numpad_D_leave;
            // 
            // numpad_1
            // 
            numpad_1.Cursor = Cursors.Hand;
            numpad_1.Image = Properties.Resources._1;
            numpad_1.Location = new Point(44, 120);
            numpad_1.Name = "numpad_1";
            numpad_1.Size = new Size(48, 50);
            numpad_1.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_1.TabIndex = 7;
            numpad_1.TabStop = false;
            numpad_1.MouseClick += numpad_1_Click;
            numpad_1.MouseEnter += numpad_1_hover;
            numpad_1.MouseLeave += numpad_1_leave;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 300;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1866, 966);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "CisDeck";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numpad_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_9).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_star).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_hashtag).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_A).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_C).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_0).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_D).EndInit();
            ((System.ComponentModel.ISupportInitialize)numpad_1).EndInit();
            ResumeLayout(false);
        }

        private void DrawListViewItem(object sender, DrawListViewItemEventArgs e)
        {
            // Define the width for each item
            int itemWidth = 300;

            // Get the item and state image index
            ListViewItem item = e.Item;
            int stateImageIndex = item.StateImageIndex;

            // Set the background color (item-specific or default)
            Color backgroundColor = item.BackColor != Color.Empty ? item.BackColor : Color.FromArgb(24, 24, 24);
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            // Draw the state image (if available)
            if (stateImageIndex >= 0 && listView1.StateImageList != null)
            {
                // Calculate where to draw the image
                int imageX = e.Bounds.Left + 4;  // Offset from the left for spacing
                int imageY = e.Bounds.Top + (e.Bounds.Height - listView1.StateImageList.ImageSize.Height) / 2;

                // Draw the image
                listView1.StateImageList.Draw(e.Graphics, new Point(imageX, imageY), stateImageIndex);
            }

            // Adjust text drawing to account for image width (if there's an image)
            int textX = stateImageIndex >= 0 ? e.Bounds.Left + listView1.StateImageList.ImageSize.Width + 8 : e.Bounds.Left + 4;
            int textWidth = itemWidth - (textX - e.Bounds.Left);

            // Draw the item text
            e.Graphics.DrawString(item.Text, item.Font, Brushes.White, new Rectangle(textX, e.Bounds.Top, textWidth, e.Bounds.Height));

            // Draw focus rectangle if the item is focused
            if (e.State.HasFlag(ListViewItemStates.Focused))
            {
                e.DrawFocusRectangle();
            }
        }

        private void Numpad_1_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox textBoxSound1;
        private Button browseButton1;
        private ContextMenuStrip contextMenuStrip2;
        private Panel panel2;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label14;
        private TextBox textBoxA;
        private Button browseProgramButton1;
        private System.Windows.Forms.Timer timer1;
        private TextBox starScriptBox;
        private Panel panel4;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label19;
        private Panel panel3;
        private TextBox textBoxPort;
        private Button connectButton;
        private Label connectedLabel;
        private Button applyButton;
        private PictureBox pictureBox2;
        private Panel panel5;
        private PictureBox numpad_4;
        private PictureBox numpad_5;
        private PictureBox numpad_6;
        private PictureBox numpad_7;
        private PictureBox numpad_8;
        private PictureBox numpad_9;
        private PictureBox numpad_star;
        private PictureBox numpad_hashtag;
        private PictureBox numpad_A;
        private PictureBox numpad_B;
        private PictureBox numpad_C;
        private PictureBox numpad_3;
        private PictureBox numpad_2;
        private PictureBox numpad_0;
        private PictureBox numpad_D;
        private PictureBox numpad_1;
        private ListView listView1;
        private ImageList imageList;
        private ColumnHeader columnHeader1;
    }
}
