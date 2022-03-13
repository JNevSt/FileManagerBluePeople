namespace FileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnGo = new System.Windows.Forms.Button();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.LblPlaceFileType = new System.Windows.Forms.Label();
            this.LblFileName = new System.Windows.Forms.Label();
            this.LblPlaceFileName = new System.Windows.Forms.Label();
            this.LblFileType = new System.Windows.Forms.Label();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddFile = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 108);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(842, 109);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(93, 109);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(743, 23);
            this.TxtFilePath.TabIndex = 3;
            // 
            // LblPlaceFileType
            // 
            this.LblPlaceFileType.AutoSize = true;
            this.LblPlaceFileType.Location = new System.Drawing.Point(865, 647);
            this.LblPlaceFileType.Name = "LblPlaceFileType";
            this.LblPlaceFileType.Size = new System.Drawing.Size(52, 15);
            this.LblPlaceFileType.TabIndex = 4;
            this.LblPlaceFileType.Text = "File Type";
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(81, 505);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(17, 15);
            this.LblFileName.TabIndex = 5;
            this.LblFileName.Text = "--";
            // 
            // LblPlaceFileName
            // 
            this.LblPlaceFileName.AutoSize = true;
            this.LblPlaceFileName.Location = new System.Drawing.Point(696, 647);
            this.LblPlaceFileName.Name = "LblPlaceFileName";
            this.LblPlaceFileName.Size = new System.Drawing.Size(60, 15);
            this.LblPlaceFileName.TabIndex = 6;
            this.LblPlaceFileName.Text = "File Name";
            // 
            // LblFileType
            // 
            this.LblFileType.AutoSize = true;
            this.LblFileType.Location = new System.Drawing.Point(713, 505);
            this.LblFileType.Name = "LblFileType";
            this.LblFileType.Size = new System.Drawing.Size(0, 15);
            this.LblFileType.TabIndex = 7;
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "icons8-txt-file-48.png");
            this.iconList.Images.SetKeyName(1, "icons8-carpeta-48.png");
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 138);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(905, 496);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // BtnAddFile
            // 
            this.BtnAddFile.Location = new System.Drawing.Point(12, -1);
            this.BtnAddFile.Name = "BtnAddFile";
            this.BtnAddFile.Size = new System.Drawing.Size(219, 55);
            this.BtnAddFile.TabIndex = 9;
            this.BtnAddFile.Text = "Add new File";
            this.BtnAddFile.UseVisualStyleBackColor = true;
            this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 676);
            this.Controls.Add(this.BtnAddFile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LblFileType);
            this.Controls.Add(this.LblPlaceFileName);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.LblPlaceFileType);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.BtnBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnBack;
        private Button BtnGo;
        private TextBox TxtFilePath;
        private Label LblPlaceFileType;
        private Label LblFileName;
        private Label LblPlaceFileName;
        private Label LblFileType;
        private ImageList iconList;
        private ListView listView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button BtnAddFile;
    }
}