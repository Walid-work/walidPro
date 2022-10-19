namespace Report_Pro.PL
{
    partial class frm_ScanToPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ScanToPDF));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Scan = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_CreatPDF = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Open = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_DefaultScan = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_About = new System.Windows.Forms.ToolStripButton();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pdf_v = new AxAcroPDFLib.AxAcroPDF();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btn_Clear1 = new System.Windows.Forms.ToolStripButton();
            this.btn_Delete1 = new System.Windows.Forms.ToolStripButton();
            this.btn_Sort = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteAtAll = new System.Windows.Forms.ToolStripButton();
            this.btn_OpenPathOFImage = new System.Windows.Forms.ToolStripButton();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Pb = new System.Windows.Forms.PictureBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btn_ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btn_ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btn_MoveLeft = new System.Windows.Forms.ToolStripButton();
            this.btn_MoveRight = new System.Windows.Forms.ToolStripButton();
            this.btn_RightRotate = new System.Windows.Forms.ToolStripButton();
            this.btn_LeftRotate = new System.Windows.Forms.ToolStripButton();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.ToolStrip1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.Panel9.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.ToolStrip3.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb)).BeginInit();
            this.Panel3.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Scan,
            this.ToolStripSeparator1,
            this.btn_CreatPDF,
            this.ToolStripSeparator6,
            this.btn_Open,
            this.ToolStripSeparator7,
            this.btn_DefaultScan,
            this.ToolStripSeparator2,
            this.btn_About});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(1049, 36);
            this.ToolStrip1.TabIndex = 20;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btn_Scan
            // 
            this.btn_Scan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scan.ForeColor = System.Drawing.Color.White;
            this.btn_Scan.Image = global::Report_Pro.Properties.Resources.scan16;
            this.btn_Scan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(63, 33);
            this.btn_Scan.Text = "Scan ";
            this.btn_Scan.ToolTipText = "مسح بواسطة الاسكنر";
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btn_CreatPDF
            // 
            this.btn_CreatPDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreatPDF.ForeColor = System.Drawing.Color.White;
            this.btn_CreatPDF.Image = global::Report_Pro.Properties.Resources.Action_Export_ToPDF__2_;
            this.btn_CreatPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CreatPDF.Name = "btn_CreatPDF";
            this.btn_CreatPDF.Size = new System.Drawing.Size(102, 33);
            this.btn_CreatPDF.Text = "Create PDF";
            this.btn_CreatPDF.ToolTipText = "تحويل الى ملف PDF";
            this.btn_CreatPDF.Click += new System.EventHandler(this.btn_CreatPDF_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 36);
            // 
            // btn_Open
            // 
            this.btn_Open.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.ForeColor = System.Drawing.Color.White;
            this.btn_Open.Image = global::Report_Pro.Properties.Resources.iconfinder_Open_file_132300;
            this.btn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(61, 33);
            this.btn_Open.Text = "Open";
            this.btn_Open.ToolTipText = "استيراد صور من مجلد";
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 36);
            // 
            // btn_DefaultScan
            // 
            this.btn_DefaultScan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DefaultScan.ForeColor = System.Drawing.Color.White;
            this.btn_DefaultScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DefaultScan.Name = "btn_DefaultScan";
            this.btn_DefaultScan.Size = new System.Drawing.Size(94, 33);
            this.btn_DefaultScan.Text = "Defualt Scan";
            this.btn_DefaultScan.ToolTipText = "حفظ اسم جهاز الاسكنر\r\n       في الاعدادات";
            this.btn_DefaultScan.Click += new System.EventHandler(this.btn_DefaultScan_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // btn_About
            // 
            this.btn_About.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.White;
            this.btn_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(49, 33);
            this.btn_About.Text = "About";
            this.btn_About.ToolTipText = "حول البرنامج";
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.lbDevices);
            this.Panel2.Controls.Add(this.label5);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.comboBox2);
            this.Panel2.Controls.Add(this.textBox3);
            this.Panel2.Controls.Add(this.textBox2);
            this.Panel2.Controls.Add(this.TextBox1);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 36);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1049, 92);
            this.Panel2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Image format";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "TIFF"});
            this.comboBox2.Location = new System.Drawing.Point(431, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(736, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(736, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 3;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(525, 5);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(205, 23);
            this.TextBox1.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(375, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(155, 33);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Name of Created PDF:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 88);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "> List of Images";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pdf_v
            // 
            this.pdf_v.Enabled = true;
            this.pdf_v.Location = new System.Drawing.Point(0, 0);
            this.pdf_v.Name = "pdf_v";
            this.pdf_v.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_v.OcxState")));
            this.pdf_v.Size = new System.Drawing.Size(532, 569);
            this.pdf_v.TabIndex = 12;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 128);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Panel9);
            this.SplitContainer1.Panel1.Controls.Add(this.Panel8);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.Panel4);
            this.SplitContainer1.Panel2.Controls.Add(this.Panel3);
            this.SplitContainer1.Size = new System.Drawing.Size(1049, 606);
            this.SplitContainer1.SplitterDistance = 348;
            this.SplitContainer1.TabIndex = 28;
            // 
            // Panel9
            // 
            this.Panel9.Controls.Add(this.ListBox1);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel9.Location = new System.Drawing.Point(0, 30);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(346, 574);
            this.Panel9.TabIndex = 2;
            // 
            // ListBox1
            // 
            this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.HorizontalScrollbar = true;
            this.ListBox1.ItemHeight = 15;
            this.ListBox1.Location = new System.Drawing.Point(0, 0);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox1.Size = new System.Drawing.Size(346, 574);
            this.ListBox1.TabIndex = 26;
            this.ListBox1.Click += new System.EventHandler(this.ListBox1_Click);
            this.ListBox1.SelectedValueChanged += new System.EventHandler(this.ListBox1_SelectedValueChanged);
            // 
            // Panel8
            // 
            this.Panel8.Controls.Add(this.ToolStrip3);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(346, 30);
            this.Panel8.TabIndex = 1;
            // 
            // ToolStrip3
            // 
            this.ToolStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Clear1,
            this.btn_Delete1,
            this.btn_Sort,
            this.btn_DeleteAtAll,
            this.btn_OpenPathOFImage});
            this.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip3.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip3.Name = "ToolStrip3";
            this.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip3.Size = new System.Drawing.Size(346, 30);
            this.ToolStrip3.TabIndex = 26;
            this.ToolStrip3.Text = "ToolStrip3";
            // 
            // btn_Clear1
            // 
            this.btn_Clear1.AutoSize = false;
            this.btn_Clear1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Clear1.Image = global::Report_Pro.Properties.Resources.Action_Clear_12x12;
            this.btn_Clear1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clear1.Name = "btn_Clear1";
            this.btn_Clear1.Size = new System.Drawing.Size(30, 27);
            this.btn_Clear1.Text = "Clear List";
            this.btn_Clear1.ToolTipText = "مسح محتوى القائمة";
            // 
            // btn_Delete1
            // 
            this.btn_Delete1.AutoSize = false;
            this.btn_Delete1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Delete1.Image = global::Report_Pro.Properties.Resources.Exit_icon;
            this.btn_Delete1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delete1.Name = "btn_Delete1";
            this.btn_Delete1.Size = new System.Drawing.Size(30, 27);
            this.btn_Delete1.Text = "Delete";
            this.btn_Delete1.ToolTipText = "مسح العنصر المحدد\r\n     من القائمة";
            this.btn_Delete1.Click += new System.EventHandler(this.btn_Delete1_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.AutoSize = false;
            this.btn_Sort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Sort.Image = global::Report_Pro.Properties.Resources.Sorting16;
            this.btn_Sort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(30, 27);
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.ToolTipText = "ترتيب تلقائي";
            // 
            // btn_DeleteAtAll
            // 
            this.btn_DeleteAtAll.AutoSize = false;
            this.btn_DeleteAtAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteAtAll.Image = global::Report_Pro.Properties.Resources.deleteAttach_icon;
            this.btn_DeleteAtAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteAtAll.Name = "btn_DeleteAtAll";
            this.btn_DeleteAtAll.Size = new System.Drawing.Size(30, 27);
            this.btn_DeleteAtAll.Text = "حذف العنصر المحدد من الجهاز بشكل نهائي";
            this.btn_DeleteAtAll.ToolTipText = "حذف العنصر المحدد من\r\n  الجهاز بشكل نهائي";
            // 
            // btn_OpenPathOFImage
            // 
            this.btn_OpenPathOFImage.AutoSize = false;
            this.btn_OpenPathOFImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_OpenPathOFImage.Image = global::Report_Pro.Properties.Resources.folder_delete;
            this.btn_OpenPathOFImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OpenPathOFImage.Name = "btn_OpenPathOFImage";
            this.btn_OpenPathOFImage.Size = new System.Drawing.Size(30, 27);
            this.btn_OpenPathOFImage.Text = "Delete All From Device";
            this.btn_OpenPathOFImage.ToolTipText = "حذف جميع عناصر القائمه \r\nبشكل نهائي من الجهاز   ";
            // 
            // Panel4
            // 
            this.Panel4.AutoScroll = true;
            this.Panel4.Controls.Add(this.pdf_v);
            this.Panel4.Controls.Add(this.Pb);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(0, 35);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(695, 569);
            this.Panel4.TabIndex = 1;
            // 
            // Pb
            // 
            this.Pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pb.Location = new System.Drawing.Point(0, 0);
            this.Pb.Name = "Pb";
            this.Pb.Size = new System.Drawing.Size(695, 569);
            this.Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb.TabIndex = 23;
            this.Pb.TabStop = false;
            this.Pb.WaitOnLoad = true;
            this.Pb.Click += new System.EventHandler(this.Pb_Click);
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Panel7);
            this.Panel3.Controls.Add(this.Panel6);
            this.Panel3.Controls.Add(this.Panel5);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(695, 35);
            this.Panel3.TabIndex = 0;
            // 
            // Panel7
            // 
            this.Panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel7.Controls.Add(this.ToolStrip2);
            this.Panel7.Location = new System.Drawing.Point(209, 0);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(241, 30);
            this.Panel7.TabIndex = 2;
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ZoomIn,
            this.btn_ZoomOut,
            this.btn_MoveLeft,
            this.btn_MoveRight,
            this.btn_RightRotate,
            this.btn_LeftRotate,
            this.btn_Print});
            this.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip2.Size = new System.Drawing.Size(241, 30);
            this.ToolStrip2.TabIndex = 27;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.AutoSize = false;
            this.btn_ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ZoomIn.Image = global::Report_Pro.Properties.Resources.Zoom_In_16x16;
            this.btn_ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.Size = new System.Drawing.Size(30, 27);
            this.btn_ZoomIn.ToolTipText = "تكبير";
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.AutoSize = false;
            this.btn_ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ZoomOut.Image = global::Report_Pro.Properties.Resources.Zoom_Out_16x16;
            this.btn_ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.Size = new System.Drawing.Size(30, 27);
            this.btn_ZoomOut.ToolTipText = "تصغير";
            // 
            // btn_MoveLeft
            // 
            this.btn_MoveLeft.AutoSize = false;
            this.btn_MoveLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_MoveLeft.Image = global::Report_Pro.Properties.Resources.left_arrow24;
            this.btn_MoveLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_MoveLeft.Name = "btn_MoveLeft";
            this.btn_MoveLeft.Size = new System.Drawing.Size(30, 27);
            this.btn_MoveLeft.Text = "Sort";
            this.btn_MoveLeft.ToolTipText = "السابق";
            // 
            // btn_MoveRight
            // 
            this.btn_MoveRight.AutoSize = false;
            this.btn_MoveRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_MoveRight.Image = global::Report_Pro.Properties.Resources.right_arrow24;
            this.btn_MoveRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_MoveRight.Name = "btn_MoveRight";
            this.btn_MoveRight.Size = new System.Drawing.Size(30, 27);
            this.btn_MoveRight.ToolTipText = "التالي";
            // 
            // btn_RightRotate
            // 
            this.btn_RightRotate.AutoSize = false;
            this.btn_RightRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RightRotate.Image = global::Report_Pro.Properties.Resources.rotate_right241;
            this.btn_RightRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RightRotate.Name = "btn_RightRotate";
            this.btn_RightRotate.Size = new System.Drawing.Size(30, 27);
            this.btn_RightRotate.ToolTipText = "تدوير الى اليسار";
            // 
            // btn_LeftRotate
            // 
            this.btn_LeftRotate.AutoSize = false;
            this.btn_LeftRotate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_LeftRotate.Image = global::Report_Pro.Properties.Resources.rotate_left24;
            this.btn_LeftRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_LeftRotate.Name = "btn_LeftRotate";
            this.btn_LeftRotate.Size = new System.Drawing.Size(30, 27);
            this.btn_LeftRotate.ToolTipText = "تدوير نحو اليمين";
            // 
            // btn_Print
            // 
            this.btn_Print.AutoSize = false;
            this.btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(30, 27);
            this.btn_Print.ToolTipText = "طباعة";
            // 
            // Panel6
            // 
            this.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Panel6.Controls.Add(this.ComboBox1);
            this.Panel6.Controls.Add(this.Label4);
            this.Panel6.Location = new System.Drawing.Point(466, 2);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(229, 30);
            this.Panel6.TabIndex = 1;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Normal",
            "StretchImage",
            "AutoSize ",
            "CenterImage",
            "Zoom"});
            this.ComboBox1.Location = new System.Drawing.Point(116, 5);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(111, 20);
            this.ComboBox1.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(0, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(108, 30);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Size Mode of Image:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel5
            // 
            this.Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel5.Location = new System.Drawing.Point(3, 3);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(208, 27);
            this.Panel5.TabIndex = 0;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(74, 3);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(273, 82);
            this.lbDevices.TabIndex = 12;
            // 
            // frm_ScanToPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 734);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frm_ScanToPDF";
            this.Text = "frm_ScanToPDF";
            this.Load += new System.EventHandler(this.frm_ScanToPDF_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_v)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.Panel9.ResumeLayout(false);
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.ToolStrip3.ResumeLayout(false);
            this.ToolStrip3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_Scan;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btn_CreatPDF;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripButton btn_Open;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.ToolStripButton btn_DefaultScan;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btn_About;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Panel Panel9;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.ToolStrip ToolStrip3;
        internal System.Windows.Forms.ToolStripButton btn_Clear1;
        internal System.Windows.Forms.ToolStripButton btn_Delete1;
        internal System.Windows.Forms.ToolStripButton btn_Sort;
        internal System.Windows.Forms.ToolStripButton btn_DeleteAtAll;
        internal System.Windows.Forms.ToolStripButton btn_OpenPathOFImage;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.PictureBox Pb;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel7;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton btn_ZoomIn;
        internal System.Windows.Forms.ToolStripButton btn_ZoomOut;
        internal System.Windows.Forms.ToolStripButton btn_MoveLeft;
        internal System.Windows.Forms.ToolStripButton btn_MoveRight;
        internal System.Windows.Forms.ToolStripButton btn_RightRotate;
        internal System.Windows.Forms.ToolStripButton btn_LeftRotate;
        internal System.Windows.Forms.ToolStripButton btn_Print;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel Panel5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private AxAcroPDFLib.AxAcroPDF pdf_v;
        private System.Windows.Forms.ListBox lbDevices;
    }
}