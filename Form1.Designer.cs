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
            ListViewGroup listViewGroup1 = new ListViewGroup("System", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Sound", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Play Sound" }, -1, Color.White, Color.FromArgb(40, 40, 40), new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Launch" }, -1, Color.White, Color.FromArgb(40, 40, 40), new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Open Website" }, -1, Color.White, Color.FromArgb(40, 40, 40), new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0));
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Trigger Hotkey" }, -1, Color.White, Color.FromArgb(40, 40, 40), new Font("Segoe UI", 12F));
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Adjust Volume" }, -1, Color.White, Color.FromArgb(40, 40, 40), new Font("Segoe UI", 12F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            configurePanelDefault = new Panel();
            reusablePanel = new Panel();
            selectedKeyImage = new PictureBox();
            textBoxConfig = new TextBox();
            connectedLabel = new Label();
            applyButton = new Button();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            labelNameA = new Label();
            label2 = new Label();
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
            configurePanelDefault.SuspendLayout();
            reusablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedKeyImage).BeginInit();
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
            pictureBox1.Image = Cisdeck.Properties.Resources.numpad_4x4;
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
            // configurePanelDefault
            // 
            configurePanelDefault.BackColor = Color.FromArgb(35, 35, 35);
            configurePanelDefault.Controls.Add(reusablePanel);
            configurePanelDefault.Controls.Add(label2);
            configurePanelDefault.Location = new Point(3, 465);
            configurePanelDefault.Name = "configurePanelDefault";
            configurePanelDefault.Size = new Size(631, 275);
            configurePanelDefault.TabIndex = 1;
            // 
            // reusablePanel
            // 
            reusablePanel.BackColor = Color.FromArgb(35, 35, 35);
            reusablePanel.Controls.Add(selectedKeyImage);
            reusablePanel.Controls.Add(textBoxConfig);
            reusablePanel.Controls.Add(connectedLabel);
            reusablePanel.Controls.Add(applyButton);
            reusablePanel.Controls.Add(label4);
            reusablePanel.Controls.Add(textBoxName);
            reusablePanel.Controls.Add(label3);
            reusablePanel.Controls.Add(labelNameA);
            reusablePanel.Location = new Point(3, 3);
            reusablePanel.Name = "reusablePanel";
            reusablePanel.Size = new Size(631, 275);
            reusablePanel.TabIndex = 2;
            // 
            // selectedKeyImage
            // 
            selectedKeyImage.Location = new Point(19, 75);
            selectedKeyImage.Name = "selectedKeyImage";
            selectedKeyImage.Size = new Size(48, 50);
            selectedKeyImage.SizeMode = PictureBoxSizeMode.Zoom;
            selectedKeyImage.TabIndex = 5;
            selectedKeyImage.TabStop = false;
            // 
            // textBoxConfig
            // 
            textBoxConfig.BackColor = Color.FromArgb(20, 20, 20);
            textBoxConfig.BorderStyle = BorderStyle.FixedSingle;
            textBoxConfig.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxConfig.ForeColor = Color.White;
            textBoxConfig.Location = new Point(186, 109);
            textBoxConfig.Name = "textBoxConfig";
            textBoxConfig.Size = new Size(169, 23);
            textBoxConfig.TabIndex = 4;
            textBoxConfig.Text = "Click here to browse";
            textBoxConfig.MouseClick += textBoxConfig_MouseClick;
            textBoxConfig.TextChanged += textBoxConfig_TextChanged;
            textBoxConfig.Leave += textBoxConfig_Leave;
            textBoxConfig.MouseMove += textBoxConfig_MouseMove;
            // 
            // connectedLabel
            // 
            connectedLabel.AutoSize = true;
            connectedLabel.ForeColor = Color.Red;
            connectedLabel.Location = new Point(19, 241);
            connectedLabel.Name = "connectedLabel";
            connectedLabel.Size = new Size(78, 15);
            connectedLabel.TabIndex = 3;
            connectedLabel.Text = "Unconnected";
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyButton.BackColor = Color.Gray;
            applyButton.FlatAppearance.BorderColor = Color.White;
            applyButton.FlatAppearance.BorderSize = 3;
            applyButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            applyButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            applyButton.ForeColor = Color.White;
            applyButton.Location = new Point(542, 223);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(86, 49);
            applyButton.TabIndex = 2;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            applyButton.MouseMove += applyButton_MouseMove;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(132, 109);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 3;
            label4.Text = "Path:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(20, 20, 20);
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(186, 75);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(169, 23);
            textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(132, 76);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // labelNameA
            // 
            labelNameA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelNameA.AutoSize = true;
            labelNameA.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNameA.ForeColor = Color.White;
            labelNameA.Location = new Point(19, 16);
            labelNameA.Name = "labelNameA";
            labelNameA.Size = new Size(116, 26);
            labelNameA.TabIndex = 0;
            labelNameA.Text = "Play Sound";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(209, 124);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 0;
            label2.Text = "Select a key to configure its action.";
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
            panel5.Controls.Add(configurePanelDefault);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(1850, 942);
            panel5.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Alignment = ListViewAlignment.Left;
            listView1.BackColor = Color.FromArgb(24, 24, 24);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.FullRowSelect = true;
            listViewGroup1.Header = "System";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Sound";
            listViewGroup2.Name = "listViewGroup2";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listViewItem1.Checked = true;
            listViewItem1.Group = listViewGroup2;
            listViewItem1.StateImageIndex = 4;
            listViewItem1.Tag = "playsound";
            listViewItem2.Checked = true;
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 1;
            listViewItem2.Tag = "launch";
            listViewItem3.Checked = true;
            listViewItem3.Group = listViewGroup1;
            listViewItem3.StateImageIndex = 2;
            listViewItem3.Tag = "openwebsite";
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 3;
            listViewItem4.Tag = "triggerhotkey";
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 4;
            listViewItem5.Tag = "adjustvolume";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
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
            listView1.MouseClick += ListView1_MouseClick;
            listView1.MouseMove += ListView1_MouseMove;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "icons8-sound-50.png");
            imageList.Images.SetKeyName(1, "icon_rocket.png");
            imageList.Images.SetKeyName(2, "icons8-internet-50.png");
            imageList.Images.SetKeyName(3, "icons8-autohotkey-48.png");
            imageList.Images.SetKeyName(4, "icons8-sound-50.png");
            // 
            // numpad_4
            // 
            numpad_4.Cursor = Cursors.Hand;
            numpad_4.Image = Cisdeck.Properties.Resources._4;
            numpad_4.Location = new Point(44, 180);
            numpad_4.Name = "numpad_4";
            numpad_4.Size = new Size(48, 50);
            numpad_4.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_4.TabIndex = 21;
            numpad_4.TabStop = false;
            numpad_4.Tag = "4";
            numpad_4.MouseClick += numpad_4_Click;
            numpad_4.MouseEnter += numpad_4_hover;
            numpad_4.MouseLeave += numpad_4_leave;
            // 
            // numpad_5
            // 
            numpad_5.Cursor = Cursors.Hand;
            numpad_5.Image = Cisdeck.Properties.Resources._5;
            numpad_5.Location = new Point(108, 180);
            numpad_5.Name = "numpad_5";
            numpad_5.Size = new Size(48, 50);
            numpad_5.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_5.TabIndex = 20;
            numpad_5.TabStop = false;
            numpad_5.Tag = "5";
            numpad_5.MouseClick += numpad_5_Click;
            numpad_5.MouseEnter += numpad_5_hover;
            numpad_5.MouseLeave += numpad_5_leave;
            // 
            // numpad_6
            // 
            numpad_6.Cursor = Cursors.Hand;
            numpad_6.Image = Cisdeck.Properties.Resources._6;
            numpad_6.Location = new Point(173, 180);
            numpad_6.Name = "numpad_6";
            numpad_6.Size = new Size(48, 50);
            numpad_6.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_6.TabIndex = 19;
            numpad_6.TabStop = false;
            numpad_6.Tag = "6";
            numpad_6.MouseClick += numpad_6_Click;
            numpad_6.MouseEnter += numpad_6_hover;
            numpad_6.MouseLeave += numpad_6_leave;
            // 
            // numpad_7
            // 
            numpad_7.Cursor = Cursors.Hand;
            numpad_7.Image = Cisdeck.Properties.Resources._7;
            numpad_7.Location = new Point(44, 241);
            numpad_7.Name = "numpad_7";
            numpad_7.Size = new Size(48, 50);
            numpad_7.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_7.TabIndex = 18;
            numpad_7.TabStop = false;
            numpad_7.Tag = "7";
            numpad_7.MouseClick += numpad_7_Click;
            numpad_7.MouseEnter += numpad_7_hover;
            numpad_7.MouseLeave += numpad_7_leave;
            // 
            // numpad_8
            // 
            numpad_8.Cursor = Cursors.Hand;
            numpad_8.Image = Cisdeck.Properties.Resources._8;
            numpad_8.Location = new Point(108, 241);
            numpad_8.Name = "numpad_8";
            numpad_8.Size = new Size(48, 50);
            numpad_8.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_8.TabIndex = 17;
            numpad_8.TabStop = false;
            numpad_8.Tag = "8";
            numpad_8.MouseClick += numpad_8_Click;
            numpad_8.MouseEnter += numpad_8_hover;
            numpad_8.MouseLeave += numpad_8_leave;
            // 
            // numpad_9
            // 
            numpad_9.Cursor = Cursors.Hand;
            numpad_9.Image = Cisdeck.Properties.Resources._9;
            numpad_9.Location = new Point(173, 241);
            numpad_9.Name = "numpad_9";
            numpad_9.Size = new Size(48, 50);
            numpad_9.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_9.TabIndex = 16;
            numpad_9.TabStop = false;
            numpad_9.Tag = "9";
            numpad_9.MouseClick += numpad_9_Click;
            numpad_9.MouseEnter += numpad_9_hover;
            numpad_9.MouseLeave += numpad_9_leave;
            // 
            // numpad_star
            // 
            numpad_star.Cursor = Cursors.Hand;
            numpad_star.Image = Cisdeck.Properties.Resources.star;
            numpad_star.Location = new Point(44, 301);
            numpad_star.Name = "numpad_star";
            numpad_star.Size = new Size(48, 50);
            numpad_star.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_star.TabIndex = 15;
            numpad_star.TabStop = false;
            numpad_star.Tag = "star";
            numpad_star.MouseClick += numpad_star_Click;
            numpad_star.MouseEnter += numpad_star_hover;
            numpad_star.MouseLeave += numpad_star_leave;
            // 
            // numpad_hashtag
            // 
            numpad_hashtag.Cursor = Cursors.Hand;
            numpad_hashtag.Image = Cisdeck.Properties.Resources._;
            numpad_hashtag.Location = new Point(173, 301);
            numpad_hashtag.Name = "numpad_hashtag";
            numpad_hashtag.Size = new Size(48, 50);
            numpad_hashtag.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_hashtag.TabIndex = 14;
            numpad_hashtag.TabStop = false;
            numpad_hashtag.Tag = "hashtag";
            numpad_hashtag.MouseClick += numpad_hashtag_Click;
            numpad_hashtag.MouseEnter += numpad_hashtag_hover;
            numpad_hashtag.MouseLeave += numpad_hashtag_leave;
            // 
            // numpad_A
            // 
            numpad_A.Cursor = Cursors.Hand;
            numpad_A.Image = Cisdeck.Properties.Resources.A;
            numpad_A.Location = new Point(236, 120);
            numpad_A.Name = "numpad_A";
            numpad_A.Size = new Size(48, 50);
            numpad_A.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_A.TabIndex = 13;
            numpad_A.TabStop = false;
            numpad_A.Tag = "A";
            numpad_A.MouseClick += numpad_A_Click;
            numpad_A.MouseEnter += numpad_A_hover;
            numpad_A.MouseLeave += numpad_A_leave;
            // 
            // numpad_B
            // 
            numpad_B.Cursor = Cursors.Hand;
            numpad_B.Image = Cisdeck.Properties.Resources.B;
            numpad_B.Location = new Point(236, 180);
            numpad_B.Name = "numpad_B";
            numpad_B.Size = new Size(48, 50);
            numpad_B.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_B.TabIndex = 12;
            numpad_B.TabStop = false;
            numpad_B.Tag = "B";
            numpad_B.MouseClick += numpad_B_Click;
            numpad_B.MouseEnter += numpad_B_hover;
            numpad_B.MouseLeave += numpad_B_leave;
            // 
            // numpad_C
            // 
            numpad_C.Cursor = Cursors.Hand;
            numpad_C.Image = Cisdeck.Properties.Resources.C;
            numpad_C.Location = new Point(236, 241);
            numpad_C.Name = "numpad_C";
            numpad_C.Size = new Size(48, 50);
            numpad_C.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_C.TabIndex = 11;
            numpad_C.TabStop = false;
            numpad_C.Tag = "C";
            numpad_C.MouseClick += numpad_C_Click;
            numpad_C.MouseEnter += numpad_C_hover;
            numpad_C.MouseLeave += numpad_C_leave;
            // 
            // numpad_3
            // 
            numpad_3.Cursor = Cursors.Hand;
            numpad_3.Image = Cisdeck.Properties.Resources._3;
            numpad_3.Location = new Point(173, 120);
            numpad_3.Name = "numpad_3";
            numpad_3.Size = new Size(48, 50);
            numpad_3.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_3.TabIndex = 10;
            numpad_3.TabStop = false;
            numpad_3.Tag = "3";
            numpad_3.MouseClick += numpad_3_Click;
            numpad_3.MouseEnter += numpad_3_hover;
            numpad_3.MouseLeave += numpad_3_leave;
            // 
            // numpad_2
            // 
            numpad_2.Cursor = Cursors.Hand;
            numpad_2.Image = Cisdeck.Properties.Resources._2;
            numpad_2.Location = new Point(108, 120);
            numpad_2.Name = "numpad_2";
            numpad_2.Size = new Size(48, 50);
            numpad_2.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_2.TabIndex = 9;
            numpad_2.TabStop = false;
            numpad_2.Tag = "2";
            numpad_2.MouseClick += numpad_2_Click;
            numpad_2.MouseEnter += numpad_2_hover;
            numpad_2.MouseLeave += numpad_2_leave;
            // 
            // numpad_0
            // 
            numpad_0.Cursor = Cursors.Hand;
            numpad_0.Image = Cisdeck.Properties.Resources._0;
            numpad_0.Location = new Point(108, 301);
            numpad_0.Name = "numpad_0";
            numpad_0.Size = new Size(48, 50);
            numpad_0.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_0.TabIndex = 9;
            numpad_0.TabStop = false;
            numpad_0.Tag = "0";
            numpad_0.MouseClick += numpad_0_Click;
            numpad_0.MouseEnter += numpad_0_hover;
            numpad_0.MouseLeave += numpad_0_leave;
            // 
            // numpad_D
            // 
            numpad_D.Cursor = Cursors.Hand;
            numpad_D.Image = Cisdeck.Properties.Resources.D;
            numpad_D.Location = new Point(236, 301);
            numpad_D.Name = "numpad_D";
            numpad_D.Size = new Size(48, 50);
            numpad_D.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_D.TabIndex = 8;
            numpad_D.TabStop = false;
            numpad_D.Tag = "D";
            numpad_D.MouseClick += numpad_D_Click;
            numpad_D.MouseEnter += numpad_D_hover;
            numpad_D.MouseLeave += numpad_D_leave;
            // 
            // numpad_1
            // 
            numpad_1.Cursor = Cursors.Hand;
            numpad_1.Image = Cisdeck.Properties.Resources._1;
            numpad_1.Location = new Point(44, 120);
            numpad_1.Name = "numpad_1";
            numpad_1.Size = new Size(48, 50);
            numpad_1.SizeMode = PictureBoxSizeMode.Zoom;
            numpad_1.TabIndex = 7;
            numpad_1.TabStop = false;
            numpad_1.Tag = "1";
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
            ClientSize = new Size(657, 766);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "CisDeck";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            configurePanelDefault.ResumeLayout(false);
            configurePanelDefault.PerformLayout();
            reusablePanel.ResumeLayout(false);
            reusablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedKeyImage).EndInit();
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
            // Define the width for each item to fill the entire ListView width
            int itemWidth = listView1.ClientSize.Width;

            // Get the item and state image index
            ListViewItem item = e.Item;
            int stateImageIndex = item.StateImageIndex;

            // Set the background color (item-specific or default)
            Color backgroundColor = item.BackColor != Color.Empty ? item.BackColor : Color.FromArgb(24, 24, 24);
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), new Rectangle(e.Bounds.Left, e.Bounds.Top, itemWidth, e.Bounds.Height));

            // Define the image offsets
            int imageOffset = 8; // 8-pixel offset on both sides

            // Draw the state image (if available)
            if (stateImageIndex >= 0 && listView1.StateImageList != null)
            {
                // Get the image from the ImageList
                Image image = listView1.StateImageList.Images[stateImageIndex];

                if (image != null)
                {
                    // Calculate where to draw the image with offset
                    int imageX = e.Bounds.Left + imageOffset;  // Left offset
                    int imageY = e.Bounds.Top + (e.Bounds.Height - image.Height) / 2;

                    // Draw the image with transparency handling
                    e.Graphics.DrawImage(image, new Rectangle(imageX, imageY, image.Width, image.Height));
                }
            }

            // Adjust text drawing to account for image width and add right offset
            int textX = stateImageIndex >= 0 ? e.Bounds.Left + listView1.StateImageList.ImageSize.Width + 2 * imageOffset : e.Bounds.Left + imageOffset;
            int textWidth = itemWidth - (textX - e.Bounds.Left) - imageOffset;  // Subtract right offset

            // Draw the item text
            e.Graphics.DrawString(item.Text, item.Font, Brushes.White, new Rectangle(textX, e.Bounds.Top, textWidth, e.Bounds.Height));
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
        private Panel configurePanelDefault;
        private Label labelNameA;
        private ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Timer timer1;
        private Label connectedLabel;
        private Button applyButton;
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
        private Label label2;
        private Panel reusablePanel;
        private Label label4;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxConfig;
        private PictureBox selectedKeyImage;
    }
}
