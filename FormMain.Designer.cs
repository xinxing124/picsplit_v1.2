namespace PicSplit
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonText = new System.Windows.Forms.Button();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonActualSize = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSrcPic = new System.Windows.Forms.TextBox();
            this.buttonOpenPic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelSaveDir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOutPicWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOutFileName = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSplitWidth = new System.Windows.Forms.TextBox();
            this.textBoxSaveDir = new System.Windows.Forms.TextBox();
            this.textBoxStartY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSplitHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSplite = new System.Windows.Forms.Button();
            this.pictureBoxSrc = new System.Windows.Forms.PictureBox();
            this.contextMenuStripSplit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDeleteLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddHor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSplitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).BeginInit();
            this.contextMenuStripSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel1.Controls.Add(this.buttonText);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxTest);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonActualSize);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonZoomIn);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonZoomOut);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSrcPic);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonOpenPic);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonSplite);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainerMain.Panel2.Controls.Add(this.pictureBoxSrc);
            this.splitContainerMain.Size = new System.Drawing.Size(897, 540);
            this.splitContainerMain.SplitterDistance = 355;
            this.splitContainerMain.SplitterWidth = 6;
            this.splitContainerMain.TabIndex = 0;
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(24, 464);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(103, 26);
            this.buttonText.TabIndex = 15;
            this.buttonText.Text = "测试";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Visible = false;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(22, 427);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(183, 21);
            this.textBoxTest.TabIndex = 14;
            this.textBoxTest.Visible = false;
            // 
            // buttonActualSize
            // 
            this.buttonActualSize.Location = new System.Drawing.Point(204, 57);
            this.buttonActualSize.Name = "buttonActualSize";
            this.buttonActualSize.Size = new System.Drawing.Size(75, 31);
            this.buttonActualSize.TabIndex = 6;
            this.buttonActualSize.Text = "1：1";
            this.buttonActualSize.UseVisualStyleBackColor = true;
            this.buttonActualSize.Click += new System.EventHandler(this.buttonActualSize_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Location = new System.Drawing.Point(109, 57);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(75, 31);
            this.buttonZoomIn.TabIndex = 5;
            this.buttonZoomIn.Text = "缩小";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Location = new System.Drawing.Point(14, 57);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(75, 31);
            this.buttonZoomOut.TabIndex = 4;
            this.buttonZoomOut.Text = "放大";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "图片文件:";
            // 
            // textBoxSrcPic
            // 
            this.textBoxSrcPic.AllowDrop = true;
            this.textBoxSrcPic.Location = new System.Drawing.Point(68, 21);
            this.textBoxSrcPic.Name = "textBoxSrcPic";
            this.textBoxSrcPic.Size = new System.Drawing.Size(174, 21);
            this.textBoxSrcPic.TabIndex = 1;
            this.textBoxSrcPic.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxSrcPic_DragDrop);
            this.textBoxSrcPic.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxSrcPic_DragEnter);
            // 
            // buttonOpenPic
            // 
            this.buttonOpenPic.Location = new System.Drawing.Point(250, 16);
            this.buttonOpenPic.Name = "buttonOpenPic";
            this.buttonOpenPic.Size = new System.Drawing.Size(88, 30);
            this.buttonOpenPic.TabIndex = 0;
            this.buttonOpenPic.Text = "打开文件...";
            this.buttonOpenPic.UseVisualStyleBackColor = true;
            this.buttonOpenPic.Click += new System.EventHandler(this.buttonOpenPic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxDel);
            this.groupBox1.Controls.Add(this.buttonSelSaveDir);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxOutPicWidth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxOutFileName);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.comboBoxFileType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSplitWidth);
            this.groupBox1.Controls.Add(this.textBoxSaveDir);
            this.groupBox1.Controls.Add(this.textBoxStartY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxStartX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSplitHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 189);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "切割设置";
            // 
            // buttonSelSaveDir
            // 
            this.buttonSelSaveDir.Location = new System.Drawing.Point(255, 92);
            this.buttonSelSaveDir.Name = "buttonSelSaveDir";
            this.buttonSelSaveDir.Size = new System.Drawing.Size(60, 23);
            this.buttonSelSaveDir.TabIndex = 23;
            this.buttonSelSaveDir.Text = "选择";
            this.buttonSelSaveDir.UseVisualStyleBackColor = true;
            this.buttonSelSaveDir.Click += new System.EventHandler(this.buttonSelSaveDir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "输出图片宽度";
            // 
            // textBoxOutPicWidth
            // 
            this.textBoxOutPicWidth.Location = new System.Drawing.Point(87, 149);
            this.textBoxOutPicWidth.Name = "textBoxOutPicWidth";
            this.textBoxOutPicWidth.Size = new System.Drawing.Size(75, 21);
            this.textBoxOutPicWidth.TabIndex = 22;
            this.textBoxOutPicWidth.Text = "0";
            this.textBoxOutPicWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "输出文件名前缀";
            // 
            // textBoxOutFileName
            // 
            this.textBoxOutFileName.Location = new System.Drawing.Point(176, 149);
            this.textBoxOutFileName.Name = "textBoxOutFileName";
            this.textBoxOutFileName.Size = new System.Drawing.Size(139, 21);
            this.textBoxOutFileName.TabIndex = 20;
            this.textBoxOutFileName.Text = "tb";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(270, 44);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(45, 23);
            this.buttonReset.TabIndex = 18;
            this.buttonReset.Text = "重置";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Location = new System.Drawing.Point(6, 149);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(67, 20);
            this.comboBoxFileType.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "文件格式:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "宽度";
            // 
            // textBoxSplitWidth
            // 
            this.textBoxSplitWidth.Location = new System.Drawing.Point(6, 44);
            this.textBoxSplitWidth.Name = "textBoxSplitWidth";
            this.textBoxSplitWidth.Size = new System.Drawing.Size(50, 21);
            this.textBoxSplitWidth.TabIndex = 8;
            this.textBoxSplitWidth.Text = "750";
            this.textBoxSplitWidth.TextChanged += new System.EventHandler(this.textBoxSplitWidth_TextChanged);
            this.textBoxSplitWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // textBoxSaveDir
            // 
            this.textBoxSaveDir.Location = new System.Drawing.Point(6, 94);
            this.textBoxSaveDir.Name = "textBoxSaveDir";
            this.textBoxSaveDir.Size = new System.Drawing.Size(243, 21);
            this.textBoxSaveDir.TabIndex = 12;
            this.textBoxSaveDir.Text = "e:\\taobao_pic";
            // 
            // textBoxStartY
            // 
            this.textBoxStartY.Location = new System.Drawing.Point(164, 44);
            this.textBoxStartY.Name = "textBoxStartY";
            this.textBoxStartY.Size = new System.Drawing.Size(50, 21);
            this.textBoxStartY.TabIndex = 13;
            this.textBoxStartY.Text = "300";
            this.textBoxStartY.TextChanged += new System.EventHandler(this.textBoxStartX_TextChanged);
            this.textBoxStartY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "存放路径";
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Location = new System.Drawing.Point(112, 44);
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(50, 21);
            this.textBoxStartX.TabIndex = 12;
            this.textBoxStartX.Text = "300";
            this.textBoxStartX.TextChanged += new System.EventHandler(this.textBoxStartX_TextChanged);
            this.textBoxStartX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "切割起点(x:y)";
            // 
            // textBoxSplitHeight
            // 
            this.textBoxSplitHeight.Location = new System.Drawing.Point(58, 44);
            this.textBoxSplitHeight.Name = "textBoxSplitHeight";
            this.textBoxSplitHeight.Size = new System.Drawing.Size(50, 21);
            this.textBoxSplitHeight.TabIndex = 10;
            this.textBoxSplitHeight.Text = "600";
            this.textBoxSplitHeight.TextChanged += new System.EventHandler(this.textBoxSplitWidth_TextChanged);
            this.textBoxSplitHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSplitWidth_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "高度";
            // 
            // buttonSplite
            // 
            this.buttonSplite.Location = new System.Drawing.Point(159, 310);
            this.buttonSplite.Name = "buttonSplite";
            this.buttonSplite.Size = new System.Drawing.Size(162, 37);
            this.buttonSplite.TabIndex = 3;
            this.buttonSplite.Text = "切割";
            this.buttonSplite.UseVisualStyleBackColor = true;
            this.buttonSplite.Click += new System.EventHandler(this.buttonSplite_Click);
            // 
            // pictureBoxSrc
            // 
            this.pictureBoxSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxSrc.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSrc.Name = "pictureBoxSrc";
            this.pictureBoxSrc.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSrc.TabIndex = 0;
            this.pictureBoxSrc.TabStop = false;
            this.pictureBoxSrc.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSrc_Paint);
            this.pictureBoxSrc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseDown);
            this.pictureBoxSrc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseMove);
            this.pictureBoxSrc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSrc_MouseUp);
            // 
            // contextMenuStripSplit
            // 
            this.contextMenuStripSplit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDeleteLine,
            this.ToolStripMenuItemAddHor,
            this.ToolStripMenuItemSplitOption});
            this.contextMenuStripSplit.Name = "contextMenuStripSplit";
            this.contextMenuStripSplit.Size = new System.Drawing.Size(149, 70);
            // 
            // ToolStripMenuItemDeleteLine
            // 
            this.ToolStripMenuItemDeleteLine.Name = "ToolStripMenuItemDeleteLine";
            this.ToolStripMenuItemDeleteLine.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemDeleteLine.Text = "删除此水平线";
            this.ToolStripMenuItemDeleteLine.Click += new System.EventHandler(this.ToolStripMenuItemDeleteLine_Click);
            // 
            // ToolStripMenuItemAddHor
            // 
            this.ToolStripMenuItemAddHor.Name = "ToolStripMenuItemAddHor";
            this.ToolStripMenuItemAddHor.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemAddHor.Text = "增加水平线";
            this.ToolStripMenuItemAddHor.Click += new System.EventHandler(this.ToolStripMenuItemAddHor_Click);
            // 
            // ToolStripMenuItemSplitOption
            // 
            this.ToolStripMenuItemSplitOption.Name = "ToolStripMenuItemSplitOption";
            this.ToolStripMenuItemSplitOption.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemSplitOption.Text = "不参与切割";
            this.ToolStripMenuItemSplitOption.Click += new System.EventHandler(this.ToolStripMenuItemSplitOption_Click);
            // 
            // textBoxDel
            // 
            this.textBoxDel.Location = new System.Drawing.Point(216, 44);
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(50, 21);
            this.textBoxDel.TabIndex = 24;
            this.textBoxDel.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "删除高度";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 540);
            this.Controls.Add(this.splitContainerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "图片快速分割工具--济南临在淘宝--QQ13712486";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSrc)).EndInit();
            this.contextMenuStripSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSrcPic;
        private System.Windows.Forms.Button buttonOpenPic;
        private System.Windows.Forms.PictureBox pictureBoxSrc;
        private System.Windows.Forms.Button buttonSplite;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonActualSize;
        private System.Windows.Forms.TextBox textBoxSaveDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSplitHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSplitWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStartY;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSplit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDeleteLine;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddHor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOutPicWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOutFileName;
        private System.Windows.Forms.Button buttonSelSaveDir;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSplitOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDel;
    }
}

