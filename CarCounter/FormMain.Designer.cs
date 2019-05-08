namespace CarCounter
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("发卡管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("挂失");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("监控统计");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("信息查询");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.msCloseSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msAnnounce = new System.Windows.Forms.ToolStripMenuItem();
            this.msAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslabSerial1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslabSerial2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbSerial = new System.Windows.Forms.GroupBox();
            this.btnSerialOpen = new System.Windows.Forms.Button();
            this.btnSerialClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSerial = new System.Windows.Forms.ComboBox();
            this.gpEdit = new System.Windows.Forms.GroupBox();
            this.panelNewCard = new System.Windows.Forms.Panel();
            this.btnCardSave = new System.Windows.Forms.Button();
            this.cmbCardNo = new System.Windows.Forms.ComboBox();
            this.labCardNo = new System.Windows.Forms.Label();
            this.panelLost = new System.Windows.Forms.Panel();
            this.pllabCardNo = new System.Windows.Forms.Label();
            this.panelMonitor = new System.Windows.Forms.Panel();
            this.pmbtnMonitorClose = new System.Windows.Forms.Button();
            this.pmbtnMonitorStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.psbtnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbOperate = new System.Windows.Forms.GroupBox();
            this.tvOperate = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbSerial.SuspendLayout();
            this.gpEdit.SuspendLayout();
            this.panelNewCard.SuspendLayout();
            this.panelLost.SuspendLayout();
            this.panelMonitor.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.gbOperate.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOpenSerial,
            this.msCloseSerial,
            this.toolStripSeparator1,
            this.msQuit});
            this.msMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(76, 24);
            this.msMenu.Text = "菜单(&M)";
            // 
            // msOpenSerial
            // 
            this.msOpenSerial.Name = "msOpenSerial";
            this.msOpenSerial.Size = new System.Drawing.Size(216, 26);
            this.msOpenSerial.Text = "打开串口(&O)";
            this.msOpenSerial.Click += new System.EventHandler(this.msOpenSerial_Click);
            // 
            // msCloseSerial
            // 
            this.msCloseSerial.Name = "msCloseSerial";
            this.msCloseSerial.Size = new System.Drawing.Size(216, 26);
            this.msCloseSerial.Text = "关闭串口(&C)";
            this.msCloseSerial.Click += new System.EventHandler(this.msCloseSerial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // msQuit
            // 
            this.msQuit.Name = "msQuit";
            this.msQuit.Size = new System.Drawing.Size(216, 26);
            this.msQuit.Text = "退出(&Q)";
            this.msQuit.Click += new System.EventHandler(this.msQuit_Click);
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAnnounce,
            this.msAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(73, 24);
            this.msHelp.Text = "帮助(&H)";
            // 
            // msAnnounce
            // 
            this.msAnnounce.Name = "msAnnounce";
            this.msAnnounce.Size = new System.Drawing.Size(216, 26);
            this.msAnnounce.Text = "使用说明";
            // 
            // msAbout
            // 
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(216, 26);
            this.msAbout.Text = "关于本系统(&A)";
            this.msAbout.Click += new System.EventHandler(this.msAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenu,
            this.msHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabSerial1,
            this.tsslabSerial2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(869, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslabSerial1
            // 
            this.tsslabSerial1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsslabSerial1.Name = "tsslabSerial1";
            this.tsslabSerial1.Size = new System.Drawing.Size(43, 20);
            this.tsslabSerial1.Text = "串口:";
            // 
            // tsslabSerial2
            // 
            this.tsslabSerial2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsslabSerial2.Name = "tsslabSerial2";
            this.tsslabSerial2.Size = new System.Drawing.Size(54, 20);
            this.tsslabSerial2.Text = "未打开";
            // 
            // gbSerial
            // 
            this.gbSerial.Controls.Add(this.btnSerialOpen);
            this.gbSerial.Controls.Add(this.btnSerialClose);
            this.gbSerial.Controls.Add(this.label1);
            this.gbSerial.Controls.Add(this.cmbSerial);
            this.gbSerial.Location = new System.Drawing.Point(16, 35);
            this.gbSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSerial.Name = "gbSerial";
            this.gbSerial.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSerial.Size = new System.Drawing.Size(231, 134);
            this.gbSerial.TabIndex = 2;
            this.gbSerial.TabStop = false;
            this.gbSerial.Text = "串口设置";
            // 
            // btnSerialOpen
            // 
            this.btnSerialOpen.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialOpen.Location = new System.Drawing.Point(12, 81);
            this.btnSerialOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerialOpen.Name = "btnSerialOpen";
            this.btnSerialOpen.Size = new System.Drawing.Size(80, 31);
            this.btnSerialOpen.TabIndex = 3;
            this.btnSerialOpen.Text = "打开";
            this.btnSerialOpen.UseVisualStyleBackColor = true;
            this.btnSerialOpen.Click += new System.EventHandler(this.btnSerialOpen_Click);
            // 
            // btnSerialClose
            // 
            this.btnSerialClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialClose.Location = new System.Drawing.Point(137, 81);
            this.btnSerialClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSerialClose.Name = "btnSerialClose";
            this.btnSerialClose.Size = new System.Drawing.Size(80, 31);
            this.btnSerialClose.TabIndex = 2;
            this.btnSerialClose.Text = "关闭";
            this.btnSerialClose.UseVisualStyleBackColor = true;
            this.btnSerialClose.Click += new System.EventHandler(this.btnSerialClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号：";
            // 
            // cmbSerial
            // 
            this.cmbSerial.FormattingEnabled = true;
            this.cmbSerial.Location = new System.Drawing.Point(88, 30);
            this.cmbSerial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSerial.Name = "cmbSerial";
            this.cmbSerial.Size = new System.Drawing.Size(128, 23);
            this.cmbSerial.TabIndex = 0;
            // 
            // gpEdit
            // 
            this.gpEdit.Controls.Add(this.panelNewCard);
            this.gpEdit.Controls.Add(this.panelLost);
            this.gpEdit.Controls.Add(this.panelMonitor);
            this.gpEdit.Controls.Add(this.panelSearch);
            this.gpEdit.Location = new System.Drawing.Point(255, 35);
            this.gpEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpEdit.Name = "gpEdit";
            this.gpEdit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpEdit.Size = new System.Drawing.Size(601, 485);
            this.gpEdit.TabIndex = 3;
            this.gpEdit.TabStop = false;
            this.gpEdit.Text = "编辑";
            // 
            // panelNewCard
            // 
            this.panelNewCard.Controls.Add(this.btnCardSave);
            this.panelNewCard.Controls.Add(this.cmbCardNo);
            this.panelNewCard.Controls.Add(this.labCardNo);
            this.panelNewCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewCard.Location = new System.Drawing.Point(4, 22);
            this.panelNewCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNewCard.Name = "panelNewCard";
            this.panelNewCard.Size = new System.Drawing.Size(593, 459);
            this.panelNewCard.TabIndex = 0;
            this.panelNewCard.Visible = false;
            // 
            // btnCardSave
            // 
            this.btnCardSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCardSave.Location = new System.Drawing.Point(483, 408);
            this.btnCardSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCardSave.Name = "btnCardSave";
            this.btnCardSave.Size = new System.Drawing.Size(87, 31);
            this.btnCardSave.TabIndex = 2;
            this.btnCardSave.Text = "保存";
            this.btnCardSave.UseVisualStyleBackColor = true;
            // 
            // cmbCardNo
            // 
            this.cmbCardNo.FormattingEnabled = true;
            this.cmbCardNo.Location = new System.Drawing.Point(85, 12);
            this.cmbCardNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCardNo.Name = "cmbCardNo";
            this.cmbCardNo.Size = new System.Drawing.Size(160, 23);
            this.cmbCardNo.TabIndex = 1;
            // 
            // labCardNo
            // 
            this.labCardNo.AutoSize = true;
            this.labCardNo.Location = new System.Drawing.Point(23, 18);
            this.labCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCardNo.Name = "labCardNo";
            this.labCardNo.Size = new System.Drawing.Size(52, 15);
            this.labCardNo.TabIndex = 0;
            this.labCardNo.Text = "卡号：";
            // 
            // panelLost
            // 
            this.panelLost.Controls.Add(this.pllabCardNo);
            this.panelLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLost.Location = new System.Drawing.Point(4, 22);
            this.panelLost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLost.Name = "panelLost";
            this.panelLost.Size = new System.Drawing.Size(593, 459);
            this.panelLost.TabIndex = 3;
            this.panelLost.Visible = false;
            // 
            // pllabCardNo
            // 
            this.pllabCardNo.AutoSize = true;
            this.pllabCardNo.Location = new System.Drawing.Point(25, 18);
            this.pllabCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pllabCardNo.Name = "pllabCardNo";
            this.pllabCardNo.Size = new System.Drawing.Size(52, 15);
            this.pllabCardNo.TabIndex = 0;
            this.pllabCardNo.Text = "卡号：";
            // 
            // panelMonitor
            // 
            this.panelMonitor.Controls.Add(this.pmbtnMonitorClose);
            this.panelMonitor.Controls.Add(this.pmbtnMonitorStart);
            this.panelMonitor.Controls.Add(this.label2);
            this.panelMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonitor.Location = new System.Drawing.Point(4, 22);
            this.panelMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMonitor.Name = "panelMonitor";
            this.panelMonitor.Size = new System.Drawing.Size(593, 459);
            this.panelMonitor.TabIndex = 3;
            this.panelMonitor.Visible = false;
            // 
            // pmbtnMonitorClose
            // 
            this.pmbtnMonitorClose.Location = new System.Drawing.Point(469, 412);
            this.pmbtnMonitorClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pmbtnMonitorClose.Name = "pmbtnMonitorClose";
            this.pmbtnMonitorClose.Size = new System.Drawing.Size(87, 31);
            this.pmbtnMonitorClose.TabIndex = 2;
            this.pmbtnMonitorClose.Text = "关闭监控";
            this.pmbtnMonitorClose.UseVisualStyleBackColor = true;
            // 
            // pmbtnMonitorStart
            // 
            this.pmbtnMonitorStart.Location = new System.Drawing.Point(28, 410);
            this.pmbtnMonitorStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pmbtnMonitorStart.Name = "pmbtnMonitorStart";
            this.pmbtnMonitorStart.Size = new System.Drawing.Size(87, 31);
            this.pmbtnMonitorStart.TabIndex = 1;
            this.pmbtnMonitorStart.Text = "开始监控";
            this.pmbtnMonitorStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.psbtnSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(4, 22);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(593, 459);
            this.panelSearch.TabIndex = 3;
            this.panelSearch.Visible = false;
            // 
            // psbtnSearch
            // 
            this.psbtnSearch.Location = new System.Drawing.Point(483, 408);
            this.psbtnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psbtnSearch.Name = "psbtnSearch";
            this.psbtnSearch.Size = new System.Drawing.Size(87, 31);
            this.psbtnSearch.TabIndex = 0;
            this.psbtnSearch.Text = "查询";
            this.psbtnSearch.UseVisualStyleBackColor = true;
            // 
            // gbOperate
            // 
            this.gbOperate.Controls.Add(this.tvOperate);
            this.gbOperate.Location = new System.Drawing.Point(16, 178);
            this.gbOperate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOperate.Name = "gbOperate";
            this.gbOperate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOperate.Size = new System.Drawing.Size(231, 342);
            this.gbOperate.TabIndex = 4;
            this.gbOperate.TabStop = false;
            this.gbOperate.Text = "操作";
            // 
            // tvOperate
            // 
            this.tvOperate.Indent = 10;
            this.tvOperate.ItemHeight = 20;
            this.tvOperate.Location = new System.Drawing.Point(12, 26);
            this.tvOperate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvOperate.Name = "tvOperate";
            treeNode1.Name = "tvnNewCard";
            treeNode1.Text = "发卡管理";
            treeNode2.Name = "tvnLost";
            treeNode2.Text = "挂失";
            treeNode3.Name = "tvnMonitor";
            treeNode3.Text = "监控统计";
            treeNode4.Name = "tvnSearch";
            treeNode4.Text = "信息查询";
            this.tvOperate.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.tvOperate.Size = new System.Drawing.Size(204, 308);
            this.tvOperate.TabIndex = 0;
            this.tvOperate.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 541);
            this.Controls.Add(this.gbOperate);
            this.Controls.Add(this.gpEdit);
            this.Controls.Add(this.gbSerial);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(887, 588);
            this.MinimumSize = new System.Drawing.Size(887, 588);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆计数系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbSerial.ResumeLayout(false);
            this.gbSerial.PerformLayout();
            this.gpEdit.ResumeLayout(false);
            this.panelNewCard.ResumeLayout(false);
            this.panelNewCard.PerformLayout();
            this.panelLost.ResumeLayout(false);
            this.panelLost.PerformLayout();
            this.panelMonitor.ResumeLayout(false);
            this.panelMonitor.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.gbOperate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem msMenu;
        private System.Windows.Forms.ToolStripMenuItem msOpenSerial;
        private System.Windows.Forms.ToolStripMenuItem msCloseSerial;
        private System.Windows.Forms.ToolStripMenuItem msQuit;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msAnnounce;
        private System.Windows.Forms.ToolStripMenuItem msAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabSerial1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabSerial2;
        private System.Windows.Forms.GroupBox gbSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.Button btnSerialOpen;
        private System.Windows.Forms.Button btnSerialClose;
        private System.Windows.Forms.GroupBox gpEdit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbOperate;
        private System.Windows.Forms.TreeView tvOperate;
        private System.Windows.Forms.Panel panelNewCard;
        private System.Windows.Forms.Button btnCardSave;
        private System.Windows.Forms.ComboBox cmbCardNo;
        private System.Windows.Forms.Label labCardNo;
        private System.Windows.Forms.Panel panelLost;
        private System.Windows.Forms.Label pllabCardNo;
        private System.Windows.Forms.Panel panelMonitor;
        private System.Windows.Forms.Button pmbtnMonitorClose;
        private System.Windows.Forms.Button pmbtnMonitorStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button psbtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

