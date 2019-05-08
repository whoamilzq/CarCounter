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
            this.panelLost = new System.Windows.Forms.Panel();
            this.pllabName = new System.Windows.Forms.Label();
            this.panelMonitor = new System.Windows.Forms.Panel();
            this.pmbtnMonitorClose = new System.Windows.Forms.Button();
            this.pmbtnMonitorStart = new System.Windows.Forms.Button();
            this.pmlabCount = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.psbtnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbOperate = new System.Windows.Forms.GroupBox();
            this.tvOperate = new System.Windows.Forms.TreeView();
            this.pltbName = new System.Windows.Forms.TextBox();
            this.pmcmbCarType = new System.Windows.Forms.ComboBox();
            this.pmlabCarType = new System.Windows.Forms.Label();
            this.pmtbCarNo = new System.Windows.Forms.TextBox();
            this.pmtbPhone = new System.Windows.Forms.TextBox();
            this.pmlabCarNo = new System.Windows.Forms.Label();
            this.pmlabPhone = new System.Windows.Forms.Label();
            this.pmlabSex = new System.Windows.Forms.Label();
            this.pmcmbSex = new System.Windows.Forms.ComboBox();
            this.pmtbName = new System.Windows.Forms.TextBox();
            this.pmlabName = new System.Windows.Forms.Label();
            this.pmcmbCardNo = new System.Windows.Forms.ComboBox();
            this.pmlabCardNO = new System.Windows.Forms.Label();
            this.pmlabIdNo = new System.Windows.Forms.Label();
            this.pmtbIdNo = new System.Windows.Forms.TextBox();
            this.potbIdNo = new System.Windows.Forms.TextBox();
            this.polabIdNo = new System.Windows.Forms.Label();
            this.pocmbCarType = new System.Windows.Forms.ComboBox();
            this.polabCarType = new System.Windows.Forms.Label();
            this.potbCarNo = new System.Windows.Forms.TextBox();
            this.potbPhone = new System.Windows.Forms.TextBox();
            this.polabCarNo = new System.Windows.Forms.Label();
            this.polabPhone = new System.Windows.Forms.Label();
            this.polabSex = new System.Windows.Forms.Label();
            this.pocmbSex = new System.Windows.Forms.ComboBox();
            this.potbName = new System.Windows.Forms.TextBox();
            this.polabName = new System.Windows.Forms.Label();
            this.poCardNo = new System.Windows.Forms.ComboBox();
            this.polabCardNo = new System.Windows.Forms.Label();
            this.pmtbCount = new System.Windows.Forms.TextBox();
            this.pslabCardNo = new System.Windows.Forms.Label();
            this.pstbCardNo = new System.Windows.Forms.TextBox();
            this.pslabIdNo = new System.Windows.Forms.Label();
            this.pslabName = new System.Windows.Forms.Label();
            this.pslabCarNo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.plbtnSearch = new System.Windows.Forms.Button();
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
            this.msOpenSerial.Size = new System.Drawing.Size(166, 26);
            this.msOpenSerial.Text = "打开串口(&O)";
            this.msOpenSerial.Click += new System.EventHandler(this.msOpenSerial_Click);
            // 
            // msCloseSerial
            // 
            this.msCloseSerial.Name = "msCloseSerial";
            this.msCloseSerial.Size = new System.Drawing.Size(166, 26);
            this.msCloseSerial.Text = "关闭串口(&C)";
            this.msCloseSerial.Click += new System.EventHandler(this.msCloseSerial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // msQuit
            // 
            this.msQuit.Name = "msQuit";
            this.msQuit.Size = new System.Drawing.Size(166, 26);
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
            this.msAnnounce.Size = new System.Drawing.Size(180, 26);
            this.msAnnounce.Text = "使用说明";
            // 
            // msAbout
            // 
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(180, 26);
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
            this.gbSerial.Margin = new System.Windows.Forms.Padding(4);
            this.gbSerial.Name = "gbSerial";
            this.gbSerial.Padding = new System.Windows.Forms.Padding(4);
            this.gbSerial.Size = new System.Drawing.Size(231, 134);
            this.gbSerial.TabIndex = 2;
            this.gbSerial.TabStop = false;
            this.gbSerial.Text = "串口设置";
            // 
            // btnSerialOpen
            // 
            this.btnSerialOpen.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialOpen.Location = new System.Drawing.Point(12, 81);
            this.btnSerialOpen.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSerialClose.Margin = new System.Windows.Forms.Padding(4);
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
            this.cmbSerial.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSerial.Name = "cmbSerial";
            this.cmbSerial.Size = new System.Drawing.Size(128, 23);
            this.cmbSerial.TabIndex = 0;
            // 
            // gpEdit
            // 
            this.gpEdit.Controls.Add(this.panelLost);
            this.gpEdit.Controls.Add(this.panelMonitor);
            this.gpEdit.Controls.Add(this.panelSearch);
            this.gpEdit.Controls.Add(this.panelNewCard);
            this.gpEdit.Location = new System.Drawing.Point(255, 35);
            this.gpEdit.Margin = new System.Windows.Forms.Padding(4);
            this.gpEdit.Name = "gpEdit";
            this.gpEdit.Padding = new System.Windows.Forms.Padding(4);
            this.gpEdit.Size = new System.Drawing.Size(601, 485);
            this.gpEdit.TabIndex = 3;
            this.gpEdit.TabStop = false;
            this.gpEdit.Text = "编辑";
            // 
            // panelNewCard
            // 
            this.panelNewCard.Controls.Add(this.potbIdNo);
            this.panelNewCard.Controls.Add(this.polabIdNo);
            this.panelNewCard.Controls.Add(this.pocmbCarType);
            this.panelNewCard.Controls.Add(this.polabCarType);
            this.panelNewCard.Controls.Add(this.potbCarNo);
            this.panelNewCard.Controls.Add(this.potbPhone);
            this.panelNewCard.Controls.Add(this.polabCarNo);
            this.panelNewCard.Controls.Add(this.polabPhone);
            this.panelNewCard.Controls.Add(this.polabSex);
            this.panelNewCard.Controls.Add(this.pocmbSex);
            this.panelNewCard.Controls.Add(this.potbName);
            this.panelNewCard.Controls.Add(this.polabName);
            this.panelNewCard.Controls.Add(this.poCardNo);
            this.panelNewCard.Controls.Add(this.polabCardNo);
            this.panelNewCard.Controls.Add(this.btnCardSave);
            this.panelNewCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewCard.Location = new System.Drawing.Point(4, 22);
            this.panelNewCard.Margin = new System.Windows.Forms.Padding(4);
            this.panelNewCard.Name = "panelNewCard";
            this.panelNewCard.Size = new System.Drawing.Size(593, 459);
            this.panelNewCard.TabIndex = 0;
            this.panelNewCard.Visible = false;
            // 
            // btnCardSave
            // 
            this.btnCardSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCardSave.Location = new System.Drawing.Point(483, 408);
            this.btnCardSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCardSave.Name = "btnCardSave";
            this.btnCardSave.Size = new System.Drawing.Size(87, 31);
            this.btnCardSave.TabIndex = 2;
            this.btnCardSave.Text = "保存";
            this.btnCardSave.UseVisualStyleBackColor = true;
            // 
            // panelLost
            // 
            this.panelLost.Controls.Add(this.plbtnSearch);
            this.panelLost.Controls.Add(this.pltbName);
            this.panelLost.Controls.Add(this.pllabName);
            this.panelLost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLost.Location = new System.Drawing.Point(4, 22);
            this.panelLost.Margin = new System.Windows.Forms.Padding(4);
            this.panelLost.Name = "panelLost";
            this.panelLost.Size = new System.Drawing.Size(593, 459);
            this.panelLost.TabIndex = 3;
            this.panelLost.Visible = false;
            // 
            // pllabName
            // 
            this.pllabName.AutoSize = true;
            this.pllabName.Location = new System.Drawing.Point(23, 18);
            this.pllabName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pllabName.Name = "pllabName";
            this.pllabName.Size = new System.Drawing.Size(84, 15);
            this.pllabName.TabIndex = 0;
            this.pllabName.Text = "姓    名：";
            // 
            // panelMonitor
            // 
            this.panelMonitor.Controls.Add(this.pmtbCount);
            this.panelMonitor.Controls.Add(this.pmtbIdNo);
            this.panelMonitor.Controls.Add(this.pmlabIdNo);
            this.panelMonitor.Controls.Add(this.pmcmbCarType);
            this.panelMonitor.Controls.Add(this.pmlabCarType);
            this.panelMonitor.Controls.Add(this.pmtbCarNo);
            this.panelMonitor.Controls.Add(this.pmtbPhone);
            this.panelMonitor.Controls.Add(this.pmlabCarNo);
            this.panelMonitor.Controls.Add(this.pmlabPhone);
            this.panelMonitor.Controls.Add(this.pmlabSex);
            this.panelMonitor.Controls.Add(this.pmcmbSex);
            this.panelMonitor.Controls.Add(this.pmtbName);
            this.panelMonitor.Controls.Add(this.pmlabName);
            this.panelMonitor.Controls.Add(this.pmcmbCardNo);
            this.panelMonitor.Controls.Add(this.pmlabCardNO);
            this.panelMonitor.Controls.Add(this.pmbtnMonitorClose);
            this.panelMonitor.Controls.Add(this.pmbtnMonitorStart);
            this.panelMonitor.Controls.Add(this.pmlabCount);
            this.panelMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonitor.Location = new System.Drawing.Point(4, 22);
            this.panelMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.panelMonitor.Name = "panelMonitor";
            this.panelMonitor.Size = new System.Drawing.Size(593, 459);
            this.panelMonitor.TabIndex = 3;
            this.panelMonitor.Visible = false;
            // 
            // pmbtnMonitorClose
            // 
            this.pmbtnMonitorClose.Location = new System.Drawing.Point(469, 412);
            this.pmbtnMonitorClose.Margin = new System.Windows.Forms.Padding(4);
            this.pmbtnMonitorClose.Name = "pmbtnMonitorClose";
            this.pmbtnMonitorClose.Size = new System.Drawing.Size(87, 31);
            this.pmbtnMonitorClose.TabIndex = 2;
            this.pmbtnMonitorClose.Text = "关闭监控";
            this.pmbtnMonitorClose.UseVisualStyleBackColor = true;
            // 
            // pmbtnMonitorStart
            // 
            this.pmbtnMonitorStart.Location = new System.Drawing.Point(28, 410);
            this.pmbtnMonitorStart.Margin = new System.Windows.Forms.Padding(4);
            this.pmbtnMonitorStart.Name = "pmbtnMonitorStart";
            this.pmbtnMonitorStart.Size = new System.Drawing.Size(87, 31);
            this.pmbtnMonitorStart.TabIndex = 1;
            this.pmbtnMonitorStart.Text = "开始监控";
            this.pmbtnMonitorStart.UseVisualStyleBackColor = true;
            // 
            // pmlabCount
            // 
            this.pmlabCount.AutoSize = true;
            this.pmlabCount.Location = new System.Drawing.Point(23, 323);
            this.pmlabCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pmlabCount.Name = "pmlabCount";
            this.pmlabCount.Size = new System.Drawing.Size(82, 15);
            this.pmlabCount.TabIndex = 0;
            this.pmlabCount.Text = "进出次数：";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.textBox3);
            this.panelSearch.Controls.Add(this.textBox2);
            this.panelSearch.Controls.Add(this.textBox1);
            this.panelSearch.Controls.Add(this.pslabCarNo);
            this.panelSearch.Controls.Add(this.pslabName);
            this.panelSearch.Controls.Add(this.pslabIdNo);
            this.panelSearch.Controls.Add(this.pstbCardNo);
            this.panelSearch.Controls.Add(this.pslabCardNo);
            this.panelSearch.Controls.Add(this.psbtnSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(4, 22);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(593, 459);
            this.panelSearch.TabIndex = 3;
            this.panelSearch.Visible = false;
            // 
            // psbtnSearch
            // 
            this.psbtnSearch.Location = new System.Drawing.Point(483, 116);
            this.psbtnSearch.Margin = new System.Windows.Forms.Padding(4);
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
            this.gbOperate.Margin = new System.Windows.Forms.Padding(4);
            this.gbOperate.Name = "gbOperate";
            this.gbOperate.Padding = new System.Windows.Forms.Padding(4);
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
            this.tvOperate.Margin = new System.Windows.Forms.Padding(4);
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
            // pltbName
            // 
            this.pltbName.Location = new System.Drawing.Point(114, 15);
            this.pltbName.Name = "pltbName";
            this.pltbName.Size = new System.Drawing.Size(158, 25);
            this.pltbName.TabIndex = 1;
            // 
            // pmcmbCarType
            // 
            this.pmcmbCarType.FormattingEnabled = true;
            this.pmcmbCarType.Location = new System.Drawing.Point(410, 315);
            this.pmcmbCarType.Name = "pmcmbCarType";
            this.pmcmbCarType.Size = new System.Drawing.Size(160, 23);
            this.pmcmbCarType.TabIndex = 24;
            // 
            // pmlabCarType
            // 
            this.pmlabCarType.AutoSize = true;
            this.pmlabCarType.Location = new System.Drawing.Point(322, 318);
            this.pmlabCarType.Name = "pmlabCarType";
            this.pmlabCarType.Size = new System.Drawing.Size(82, 15);
            this.pmlabCarType.TabIndex = 23;
            this.pmlabCarType.Text = "车辆类型：";
            // 
            // pmtbCarNo
            // 
            this.pmtbCarNo.Location = new System.Drawing.Point(410, 265);
            this.pmtbCarNo.Name = "pmtbCarNo";
            this.pmtbCarNo.Size = new System.Drawing.Size(160, 25);
            this.pmtbCarNo.TabIndex = 22;
            // 
            // pmtbPhone
            // 
            this.pmtbPhone.Location = new System.Drawing.Point(410, 165);
            this.pmtbPhone.Name = "pmtbPhone";
            this.pmtbPhone.Size = new System.Drawing.Size(160, 25);
            this.pmtbPhone.TabIndex = 21;
            // 
            // pmlabCarNo
            // 
            this.pmlabCarNo.AutoSize = true;
            this.pmlabCarNo.Location = new System.Drawing.Point(322, 268);
            this.pmlabCarNo.Name = "pmlabCarNo";
            this.pmlabCarNo.Size = new System.Drawing.Size(83, 15);
            this.pmlabCarNo.TabIndex = 20;
            this.pmlabCarNo.Text = "车 牌 号：";
            // 
            // pmlabPhone
            // 
            this.pmlabPhone.AutoSize = true;
            this.pmlabPhone.Location = new System.Drawing.Point(321, 168);
            this.pmlabPhone.Name = "pmlabPhone";
            this.pmlabPhone.Size = new System.Drawing.Size(84, 15);
            this.pmlabPhone.TabIndex = 19;
            this.pmlabPhone.Text = "电    话：";
            // 
            // pmlabSex
            // 
            this.pmlabSex.AutoSize = true;
            this.pmlabSex.Location = new System.Drawing.Point(321, 118);
            this.pmlabSex.Name = "pmlabSex";
            this.pmlabSex.Size = new System.Drawing.Size(84, 15);
            this.pmlabSex.TabIndex = 18;
            this.pmlabSex.Text = "性    别：";
            // 
            // pmcmbSex
            // 
            this.pmcmbSex.FormattingEnabled = true;
            this.pmcmbSex.Location = new System.Drawing.Point(410, 116);
            this.pmcmbSex.Name = "pmcmbSex";
            this.pmcmbSex.Size = new System.Drawing.Size(160, 23);
            this.pmcmbSex.TabIndex = 17;
            // 
            // pmtbName
            // 
            this.pmtbName.Location = new System.Drawing.Point(410, 66);
            this.pmtbName.Name = "pmtbName";
            this.pmtbName.Size = new System.Drawing.Size(160, 25);
            this.pmtbName.TabIndex = 16;
            // 
            // pmlabName
            // 
            this.pmlabName.AutoSize = true;
            this.pmlabName.Location = new System.Drawing.Point(321, 68);
            this.pmlabName.Name = "pmlabName";
            this.pmlabName.Size = new System.Drawing.Size(84, 15);
            this.pmlabName.TabIndex = 15;
            this.pmlabName.Text = "姓    名：";
            // 
            // pmcmbCardNo
            // 
            this.pmcmbCardNo.FormattingEnabled = true;
            this.pmcmbCardNo.Location = new System.Drawing.Point(410, 15);
            this.pmcmbCardNo.Margin = new System.Windows.Forms.Padding(4);
            this.pmcmbCardNo.Name = "pmcmbCardNo";
            this.pmcmbCardNo.Size = new System.Drawing.Size(160, 23);
            this.pmcmbCardNo.TabIndex = 14;
            // 
            // pmlabCardNO
            // 
            this.pmlabCardNO.AutoSize = true;
            this.pmlabCardNO.Location = new System.Drawing.Point(321, 18);
            this.pmlabCardNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pmlabCardNO.Name = "pmlabCardNO";
            this.pmlabCardNO.Size = new System.Drawing.Size(84, 15);
            this.pmlabCardNO.TabIndex = 13;
            this.pmlabCardNO.Text = "卡    号：";
            // 
            // pmlabIdNo
            // 
            this.pmlabIdNo.AutoSize = true;
            this.pmlabIdNo.Location = new System.Drawing.Point(325, 218);
            this.pmlabIdNo.Name = "pmlabIdNo";
            this.pmlabIdNo.Size = new System.Drawing.Size(82, 15);
            this.pmlabIdNo.TabIndex = 25;
            this.pmlabIdNo.Text = "身份证号：";
            // 
            // pmtbIdNo
            // 
            this.pmtbIdNo.Location = new System.Drawing.Point(410, 215);
            this.pmtbIdNo.Name = "pmtbIdNo";
            this.pmtbIdNo.Size = new System.Drawing.Size(160, 25);
            this.pmtbIdNo.TabIndex = 26;
            // 
            // potbIdNo
            // 
            this.potbIdNo.Location = new System.Drawing.Point(112, 215);
            this.potbIdNo.Name = "potbIdNo";
            this.potbIdNo.Size = new System.Drawing.Size(160, 25);
            this.potbIdNo.TabIndex = 40;
            // 
            // polabIdNo
            // 
            this.polabIdNo.AutoSize = true;
            this.polabIdNo.Location = new System.Drawing.Point(27, 219);
            this.polabIdNo.Name = "polabIdNo";
            this.polabIdNo.Size = new System.Drawing.Size(82, 15);
            this.polabIdNo.TabIndex = 39;
            this.polabIdNo.Text = "身份证号：";
            // 
            // pocmbCarType
            // 
            this.pocmbCarType.FormattingEnabled = true;
            this.pocmbCarType.Location = new System.Drawing.Point(112, 315);
            this.pocmbCarType.Name = "pocmbCarType";
            this.pocmbCarType.Size = new System.Drawing.Size(160, 23);
            this.pocmbCarType.TabIndex = 38;
            // 
            // polabCarType
            // 
            this.polabCarType.AutoSize = true;
            this.polabCarType.Location = new System.Drawing.Point(24, 319);
            this.polabCarType.Name = "polabCarType";
            this.polabCarType.Size = new System.Drawing.Size(82, 15);
            this.polabCarType.TabIndex = 37;
            this.polabCarType.Text = "车辆类型：";
            // 
            // potbCarNo
            // 
            this.potbCarNo.Location = new System.Drawing.Point(112, 266);
            this.potbCarNo.Name = "potbCarNo";
            this.potbCarNo.Size = new System.Drawing.Size(160, 25);
            this.potbCarNo.TabIndex = 36;
            // 
            // potbPhone
            // 
            this.potbPhone.Location = new System.Drawing.Point(112, 166);
            this.potbPhone.Name = "potbPhone";
            this.potbPhone.Size = new System.Drawing.Size(160, 25);
            this.potbPhone.TabIndex = 35;
            // 
            // polabCarNo
            // 
            this.polabCarNo.AutoSize = true;
            this.polabCarNo.Location = new System.Drawing.Point(24, 269);
            this.polabCarNo.Name = "polabCarNo";
            this.polabCarNo.Size = new System.Drawing.Size(83, 15);
            this.polabCarNo.TabIndex = 34;
            this.polabCarNo.Text = "车 牌 号：";
            // 
            // polabPhone
            // 
            this.polabPhone.AutoSize = true;
            this.polabPhone.Location = new System.Drawing.Point(23, 169);
            this.polabPhone.Name = "polabPhone";
            this.polabPhone.Size = new System.Drawing.Size(84, 15);
            this.polabPhone.TabIndex = 33;
            this.polabPhone.Text = "电    话：";
            // 
            // polabSex
            // 
            this.polabSex.AutoSize = true;
            this.polabSex.Location = new System.Drawing.Point(23, 119);
            this.polabSex.Name = "polabSex";
            this.polabSex.Size = new System.Drawing.Size(84, 15);
            this.polabSex.TabIndex = 32;
            this.polabSex.Text = "性    别：";
            // 
            // pocmbSex
            // 
            this.pocmbSex.FormattingEnabled = true;
            this.pocmbSex.Location = new System.Drawing.Point(112, 116);
            this.pocmbSex.Name = "pocmbSex";
            this.pocmbSex.Size = new System.Drawing.Size(160, 23);
            this.pocmbSex.TabIndex = 31;
            // 
            // potbName
            // 
            this.potbName.Location = new System.Drawing.Point(112, 65);
            this.potbName.Name = "potbName";
            this.potbName.Size = new System.Drawing.Size(160, 25);
            this.potbName.TabIndex = 30;
            // 
            // polabName
            // 
            this.polabName.AutoSize = true;
            this.polabName.Location = new System.Drawing.Point(23, 69);
            this.polabName.Name = "polabName";
            this.polabName.Size = new System.Drawing.Size(84, 15);
            this.polabName.TabIndex = 29;
            this.polabName.Text = "姓    名：";
            // 
            // poCardNo
            // 
            this.poCardNo.FormattingEnabled = true;
            this.poCardNo.Location = new System.Drawing.Point(112, 15);
            this.poCardNo.Margin = new System.Windows.Forms.Padding(4);
            this.poCardNo.Name = "poCardNo";
            this.poCardNo.Size = new System.Drawing.Size(160, 23);
            this.poCardNo.TabIndex = 28;
            // 
            // polabCardNo
            // 
            this.polabCardNo.AutoSize = true;
            this.polabCardNo.Location = new System.Drawing.Point(23, 19);
            this.polabCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.polabCardNo.Name = "polabCardNo";
            this.polabCardNo.Size = new System.Drawing.Size(84, 15);
            this.polabCardNo.TabIndex = 27;
            this.polabCardNo.Text = "卡    号：";
            // 
            // pmtbCount
            // 
            this.pmtbCount.Location = new System.Drawing.Point(112, 316);
            this.pmtbCount.Name = "pmtbCount";
            this.pmtbCount.Size = new System.Drawing.Size(100, 25);
            this.pmtbCount.TabIndex = 27;
            // 
            // pslabCardNo
            // 
            this.pslabCardNo.AutoSize = true;
            this.pslabCardNo.Location = new System.Drawing.Point(27, 18);
            this.pslabCardNo.Name = "pslabCardNo";
            this.pslabCardNo.Size = new System.Drawing.Size(84, 15);
            this.pslabCardNo.TabIndex = 1;
            this.pslabCardNo.Text = "卡    号：";
            // 
            // pstbCardNo
            // 
            this.pstbCardNo.Location = new System.Drawing.Point(117, 15);
            this.pstbCardNo.Name = "pstbCardNo";
            this.pstbCardNo.Size = new System.Drawing.Size(155, 25);
            this.pstbCardNo.TabIndex = 2;
            // 
            // pslabIdNo
            // 
            this.pslabIdNo.AutoSize = true;
            this.pslabIdNo.Location = new System.Drawing.Point(27, 68);
            this.pslabIdNo.Name = "pslabIdNo";
            this.pslabIdNo.Size = new System.Drawing.Size(82, 15);
            this.pslabIdNo.TabIndex = 3;
            this.pslabIdNo.Text = "身份证号：";
            // 
            // pslabName
            // 
            this.pslabName.AutoSize = true;
            this.pslabName.Location = new System.Drawing.Point(303, 18);
            this.pslabName.Name = "pslabName";
            this.pslabName.Size = new System.Drawing.Size(84, 15);
            this.pslabName.TabIndex = 4;
            this.pslabName.Text = "姓    名：";
            // 
            // pslabCarNo
            // 
            this.pslabCarNo.AutoSize = true;
            this.pslabCarNo.Location = new System.Drawing.Point(306, 68);
            this.pslabCarNo.Name = "pslabCarNo";
            this.pslabCarNo.Size = new System.Drawing.Size(83, 15);
            this.pslabCarNo.TabIndex = 5;
            this.pslabCarNo.Text = "车 牌 号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 25);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(396, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 25);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(396, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 25);
            this.textBox3.TabIndex = 8;
            // 
            // plbtnSearch
            // 
            this.plbtnSearch.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plbtnSearch.Location = new System.Drawing.Point(490, 59);
            this.plbtnSearch.Name = "plbtnSearch";
            this.plbtnSearch.Size = new System.Drawing.Size(80, 31);
            this.plbtnSearch.TabIndex = 2;
            this.plbtnSearch.Text = "查询";
            this.plbtnSearch.UseVisualStyleBackColor = true;
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
            this.panelSearch.PerformLayout();
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
        private System.Windows.Forms.Panel panelLost;
        private System.Windows.Forms.Label pllabName;
        private System.Windows.Forms.Panel panelMonitor;
        private System.Windows.Forms.Button pmbtnMonitorClose;
        private System.Windows.Forms.Button pmbtnMonitorStart;
        private System.Windows.Forms.Label pmlabCount;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button psbtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox pltbName;
        private System.Windows.Forms.TextBox potbIdNo;
        private System.Windows.Forms.Label polabIdNo;
        private System.Windows.Forms.ComboBox pocmbCarType;
        private System.Windows.Forms.Label polabCarType;
        private System.Windows.Forms.TextBox potbCarNo;
        private System.Windows.Forms.TextBox potbPhone;
        private System.Windows.Forms.Label polabCarNo;
        private System.Windows.Forms.Label polabPhone;
        private System.Windows.Forms.Label polabSex;
        private System.Windows.Forms.ComboBox pocmbSex;
        private System.Windows.Forms.TextBox potbName;
        private System.Windows.Forms.Label polabName;
        private System.Windows.Forms.ComboBox poCardNo;
        private System.Windows.Forms.Label polabCardNo;
        private System.Windows.Forms.TextBox pmtbIdNo;
        private System.Windows.Forms.Label pmlabIdNo;
        private System.Windows.Forms.ComboBox pmcmbCarType;
        private System.Windows.Forms.Label pmlabCarType;
        private System.Windows.Forms.TextBox pmtbCarNo;
        private System.Windows.Forms.TextBox pmtbPhone;
        private System.Windows.Forms.Label pmlabCarNo;
        private System.Windows.Forms.Label pmlabPhone;
        private System.Windows.Forms.Label pmlabSex;
        private System.Windows.Forms.ComboBox pmcmbSex;
        private System.Windows.Forms.TextBox pmtbName;
        private System.Windows.Forms.Label pmlabName;
        private System.Windows.Forms.ComboBox pmcmbCardNo;
        private System.Windows.Forms.Label pmlabCardNO;
        private System.Windows.Forms.TextBox pmtbCount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pslabCarNo;
        private System.Windows.Forms.Label pslabName;
        private System.Windows.Forms.Label pslabIdNo;
        private System.Windows.Forms.TextBox pstbCardNo;
        private System.Windows.Forms.Label pslabCardNo;
        private System.Windows.Forms.Button plbtnSearch;
    }
}

