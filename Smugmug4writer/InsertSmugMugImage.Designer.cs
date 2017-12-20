namespace SmugMug4writer
{
    partial class InsertSmugMugImageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertSmugMugImageForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPictureCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.smugMugSignup = new System.Windows.Forms.LinkLabel();
            this.imageProcessor = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.albumList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNickName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.retrievedImageList = new System.Windows.Forms.ListView();
            this.imageListing = new System.Windows.Forms.ImageList(this.components);
            this.buttonGet = new System.Windows.Forms.Button();
            this.groupLayout = new System.Windows.Forms.GroupBox();
            this.checkHyperLink = new System.Windows.Forms.CheckBox();
            this.textBoxCssClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.verticalPadding = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.borderThickness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.horizontalPadding = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dropDownAlignment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dropDownImageSizes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.insertImageTabPage = new System.Windows.Forms.TabPage();
            this.insertGalleryTabPage = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbIncludeCSS = new System.Windows.Forms.CheckBox();
            this.cbUseLightBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPadding)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.insertImageTabPage.SuspendLayout();
            this.insertGalleryTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.toolStripStatusLabel1,
            this.statusLabel,
            this.statusPictureCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 838);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(815, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(133, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 21);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(304, 21);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPictureCount
            // 
            this.statusPictureCount.Name = "statusPictureCount";
            this.statusPictureCount.Size = new System.Drawing.Size(304, 21);
            this.statusPictureCount.Spring = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "New to SmugMug?";
            // 
            // smugMugSignup
            // 
            this.smugMugSignup.AutoSize = true;
            this.smugMugSignup.Location = new System.Drawing.Point(728, 11);
            this.smugMugSignup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smugMugSignup.Name = "smugMugSignup";
            this.smugMugSignup.Size = new System.Drawing.Size(64, 17);
            this.smugMugSignup.TabIndex = 2;
            this.smugMugSignup.TabStop = true;
            this.smugMugSignup.Text = "Signup...";
            this.smugMugSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.smugMugSignup_LinkClicked);
            // 
            // imageProcessor
            // 
            this.imageProcessor.WorkerReportsProgress = true;
            this.imageProcessor.WorkerSupportsCancellation = true;
            this.imageProcessor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.imageProcessor_DoWork);
            this.imageProcessor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.imageProcessor_RunWorkerCompleted);
            this.imageProcessor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.imageProcessor_ProgressChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.albumList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNickName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(428, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Source";
            // 
            // albumList
            // 
            this.albumList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumList.FormattingEnabled = true;
            this.albumList.Location = new System.Drawing.Point(96, 64);
            this.albumList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumList.Name = "albumList";
            this.albumList.Size = new System.Drawing.Size(323, 24);
            this.albumList.TabIndex = 3;
            this.albumList.DropDown += new System.EventHandler(this.AlbumComboDropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album:";
            // 
            // textNickName
            // 
            this.textNickName.Location = new System.Drawing.Point(96, 25);
            this.textNickName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNickName.Name = "textNickName";
            this.textNickName.Size = new System.Drawing.Size(323, 22);
            this.textNickName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nickname:";
            // 
            // retrievedImageList
            // 
            this.retrievedImageList.LargeImageList = this.imageListing;
            this.retrievedImageList.Location = new System.Drawing.Point(16, 124);
            this.retrievedImageList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.retrievedImageList.MultiSelect = false;
            this.retrievedImageList.Name = "retrievedImageList";
            this.retrievedImageList.ShowGroups = false;
            this.retrievedImageList.Size = new System.Drawing.Size(784, 493);
            this.retrievedImageList.TabIndex = 4;
            this.retrievedImageList.UseCompatibleStateImageBehavior = false;
            // 
            // imageListing
            // 
            this.imageListing.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListing.ImageSize = new System.Drawing.Size(102, 102);
            this.imageListing.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(452, 31);
            this.buttonGet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(100, 74);
            this.buttonGet.TabIndex = 5;
            this.buttonGet.Text = "Get Images";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // groupLayout
            // 
            this.groupLayout.Controls.Add(this.checkHyperLink);
            this.groupLayout.Controls.Add(this.textBoxCssClass);
            this.groupLayout.Controls.Add(this.label7);
            this.groupLayout.Controls.Add(this.verticalPadding);
            this.groupLayout.Controls.Add(this.label6);
            this.groupLayout.Controls.Add(this.borderThickness);
            this.groupLayout.Controls.Add(this.label5);
            this.groupLayout.Controls.Add(this.horizontalPadding);
            this.groupLayout.Controls.Add(this.label4);
            this.groupLayout.Controls.Add(this.dropDownAlignment);
            this.groupLayout.Controls.Add(this.label8);
            this.groupLayout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLayout.Location = new System.Drawing.Point(10, 7);
            this.groupLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupLayout.Name = "groupLayout";
            this.groupLayout.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupLayout.Size = new System.Drawing.Size(455, 130);
            this.groupLayout.TabIndex = 8;
            this.groupLayout.TabStop = false;
            this.groupLayout.Text = "Layout";
            // 
            // checkHyperLink
            // 
            this.checkHyperLink.Checked = true;
            this.checkHyperLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHyperLink.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHyperLink.Location = new System.Drawing.Point(232, 94);
            this.checkHyperLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkHyperLink.Name = "checkHyperLink";
            this.checkHyperLink.Size = new System.Drawing.Size(191, 21);
            this.checkHyperLink.TabIndex = 6;
            this.checkHyperLink.Text = "Include link to image";
            // 
            // textBoxCssClass
            // 
            this.textBoxCssClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCssClass.Location = new System.Drawing.Point(97, 91);
            this.textBoxCssClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCssClass.Name = "textBoxCssClass";
            this.textBoxCssClass.Size = new System.Drawing.Size(105, 24);
            this.textBoxCssClass.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "CSS Class:";
            // 
            // verticalPadding
            // 
            this.verticalPadding.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalPadding.Location = new System.Drawing.Point(379, 55);
            this.verticalPadding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.verticalPadding.Name = "verticalPadding";
            this.verticalPadding.Size = new System.Drawing.Size(61, 24);
            this.verticalPadding.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vertical spacing:";
            // 
            // borderThickness
            // 
            this.borderThickness.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderThickness.Location = new System.Drawing.Point(137, 55);
            this.borderThickness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borderThickness.Name = "borderThickness";
            this.borderThickness.Size = new System.Drawing.Size(67, 24);
            this.borderThickness.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Border thickness:";
            // 
            // horizontalPadding
            // 
            this.horizontalPadding.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalPadding.Location = new System.Drawing.Point(379, 21);
            this.horizontalPadding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horizontalPadding.Name = "horizontalPadding";
            this.horizontalPadding.Size = new System.Drawing.Size(61, 24);
            this.horizontalPadding.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horizontal spacing:";
            // 
            // dropDownAlignment
            // 
            this.dropDownAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownAlignment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownAlignment.Items.AddRange(new object[] {
            "None",
            "Left",
            "Right",
            "TextTop",
            "Middle",
            "Bottom",
            "Baseline"});
            this.dropDownAlignment.Location = new System.Drawing.Point(97, 21);
            this.dropDownAlignment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropDownAlignment.Name = "dropDownAlignment";
            this.dropDownAlignment.Size = new System.Drawing.Size(105, 25);
            this.dropDownAlignment.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Alignment:";
            // 
            // dropDownImageSizes
            // 
            this.dropDownImageSizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownImageSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownImageSizes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownImageSizes.Items.AddRange(new object[] {
            "Tiny",
            "Thumbnail",
            "Small",
            "Medium",
            "Large",
            "Original"});
            this.dropDownImageSizes.Location = new System.Drawing.Point(609, 22);
            this.dropDownImageSizes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropDownImageSizes.Name = "dropDownImageSizes";
            this.dropDownImageSizes.Size = new System.Drawing.Size(160, 25);
            this.dropDownImageSizes.TabIndex = 15;
            this.dropDownImageSizes.SelectedIndexChanged += new System.EventHandler(this.ImageSizeChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Picture Size:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(685, 806);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 28);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInsert.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(560, 806);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(117, 28);
            this.buttonInsert.TabIndex = 16;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.insertImageTabPage);
            this.tabControl1.Controls.Add(this.insertGalleryTabPage);
            this.tabControl1.Location = new System.Drawing.Point(16, 624);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 173);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // insertImageTabPage
            // 
            this.insertImageTabPage.Controls.Add(this.groupLayout);
            this.insertImageTabPage.Controls.Add(this.dropDownImageSizes);
            this.insertImageTabPage.Controls.Add(this.label9);
            this.insertImageTabPage.Location = new System.Drawing.Point(4, 25);
            this.insertImageTabPage.Name = "insertImageTabPage";
            this.insertImageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertImageTabPage.Size = new System.Drawing.Size(776, 144);
            this.insertImageTabPage.TabIndex = 0;
            this.insertImageTabPage.Text = "Insert Image";
            this.insertImageTabPage.UseVisualStyleBackColor = true;
            // 
            // insertGalleryTabPage
            // 
            this.insertGalleryTabPage.Controls.Add(this.cbUseLightBox);
            this.insertGalleryTabPage.Controls.Add(this.cbIncludeCSS);
            this.insertGalleryTabPage.Location = new System.Drawing.Point(4, 25);
            this.insertGalleryTabPage.Name = "insertGalleryTabPage";
            this.insertGalleryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.insertGalleryTabPage.Size = new System.Drawing.Size(776, 144);
            this.insertGalleryTabPage.TabIndex = 1;
            this.insertGalleryTabPage.Text = "Insert Gallery";
            this.insertGalleryTabPage.UseVisualStyleBackColor = true;
            // 
            // cbIncludeCSS
            // 
            this.cbIncludeCSS.AutoSize = true;
            this.cbIncludeCSS.Location = new System.Drawing.Point(10, 6);
            this.cbIncludeCSS.Name = "cbIncludeCSS";
            this.cbIncludeCSS.Size = new System.Drawing.Size(106, 21);
            this.cbIncludeCSS.TabIndex = 0;
            this.cbIncludeCSS.Text = "Include CSS";
            this.toolTip1.SetToolTip(this.cbIncludeCSS, "Will include the CSS style in the generated html.  You can optionally include the" +
                    " style sheet in your blog header.");
            this.cbIncludeCSS.UseVisualStyleBackColor = true;
            // 
            // cbUseLightBox
            // 
            this.cbUseLightBox.AutoSize = true;
            this.cbUseLightBox.Location = new System.Drawing.Point(10, 33);
            this.cbUseLightBox.Name = "cbUseLightBox";
            this.cbUseLightBox.Size = new System.Drawing.Size(112, 21);
            this.cbUseLightBox.TabIndex = 1;
            this.cbUseLightBox.Text = "Use Lightbox";
            this.toolTip1.SetToolTip(this.cbUseLightBox, resources.GetString("cbUseLightBox.ToolTip"));
            this.cbUseLightBox.UseVisualStyleBackColor = true;
            // 
            // InsertSmugMugImageForm
            // 
            this.AcceptButton = this.buttonInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(815, 864);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.retrievedImageList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.smugMugSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InsertSmugMugImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert SmugMug Image";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupLayout.ResumeLayout(false);
            this.groupLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPadding)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.insertImageTabPage.ResumeLayout(false);
            this.insertImageTabPage.PerformLayout();
            this.insertGalleryTabPage.ResumeLayout(false);
            this.insertGalleryTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel smugMugSignup;
        private System.ComponentModel.BackgroundWorker imageProcessor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNickName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox albumList;
        private System.Windows.Forms.ListView retrievedImageList;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.GroupBox groupLayout;
        private System.Windows.Forms.CheckBox checkHyperLink;
        private System.Windows.Forms.TextBox textBoxCssClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown verticalPadding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown borderThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown horizontalPadding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropDownAlignment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dropDownImageSizes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ImageList imageListing;
        private System.Windows.Forms.ToolStripStatusLabel statusPictureCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage insertImageTabPage;
        private System.Windows.Forms.TabPage insertGalleryTabPage;
        private System.Windows.Forms.CheckBox cbUseLightBox;
        private System.Windows.Forms.CheckBox cbIncludeCSS;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}