namespace _21计科2班_马菁含_010069_期末大作业_
{
    partial class yemian1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yemian1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picImage = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.lstDrawInfo = new System.Windows.Forms.ListBox();
            this.bdsDrawInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dlgSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.btndraw = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.numMin1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.numScale1 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDrawInfo)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(629, 155);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(523, 606);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(7, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(290, 42);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 39);
            this.btnSave.Text = "保存图片";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Checked = true;
            this.btnHelp.CheckOnClick = true;
            this.btnHelp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(143, 39);
            this.btnHelp.Text = "产品说明";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 85);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 85);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyGrid1.Location = new System.Drawing.Point(23, 411);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(580, 350);
            this.propertyGrid1.TabIndex = 13;
            // 
            // lstDrawInfo
            // 
            this.lstDrawInfo.DataSource = this.bdsDrawInfo;
            this.lstDrawInfo.FormattingEnabled = true;
            this.lstDrawInfo.ItemHeight = 27;
            this.lstDrawInfo.Location = new System.Drawing.Point(16, 155);
            this.lstDrawInfo.Margin = new System.Windows.Forms.Padding(7);
            this.lstDrawInfo.Name = "lstDrawInfo";
            this.lstDrawInfo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDrawInfo.Size = new System.Drawing.Size(587, 139);
            this.lstDrawInfo.TabIndex = 14;
            this.lstDrawInfo.SelectedIndexChanged += new System.EventHandler(this.lstDrawInfo_SelectedIndexChanged_1);
            // 
            // bdsDrawInfo
            // 
            this.bdsDrawInfo.DataSource = this.lstDrawInfo.CustomTabOffsets;
            // 
            // dlgSaveImage
            // 
            this.dlgSaveImage.Filter = "PNG图片|*.png|JPG图片|*.jpg|GIF图片|*.gif|BMP图片|*.bmp";
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(495, 323);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(108, 64);
            this.btndraw.TabIndex = 15;
            this.btndraw.Text = "绘制";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.numMin1,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.numScale1});
            this.toolStrip2.Location = new System.Drawing.Point(23, 323);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(355, 42);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(145, 39);
            this.toolStripLabel1.Text = "N的范围：";
            // 
            // numMin1
            // 
            this.numMin1.Name = "numMin1";
            this.numMin1.Size = new System.Drawing.Size(70, 42);
            this.numMin1.Text = "-300";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(96, 39);
            this.toolStripLabel3.Text = "刻度：";
            // 
            // numScale1
            // 
            this.numScale1.Name = "numScale1";
            this.numScale1.Size = new System.Drawing.Size(30, 42);
            this.numScale1.Text = "20";
            // 
            // yemian1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 853);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.lstDrawInfo);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.picImage);
            this.Name = "yemian1";
            this.Text = "32021010069马菁含";
            this.Load += new System.EventHandler(this.yemian1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDrawInfo)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ListBox lstDrawInfo;
        private System.Windows.Forms.BindingSource bdsDrawInfo;
        private System.Windows.Forms.SaveFileDialog dlgSaveImage;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox numMin1;
        private System.Windows.Forms.ToolStripTextBox numScale1;
    }
}