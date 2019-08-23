namespace File_Encryption
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEnableQuick = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOverride = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLocalEn = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewEn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDown = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemIns = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TextB_OpenPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFolderBrowse = new System.Windows.Forms.Button();
            this.TextBdestinationPath = new System.Windows.Forms.TextBox();
            this.RadioBencryption = new System.Windows.Forms.RadioButton();
            this.RadioBdecryption = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDo = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "新的密钥行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ToolStripMenuItemNewEn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "测试";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.功能FToolStripMenuItem,
            this.设置SToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(573, 34);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEncryptionToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveEncryptionToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // newEncryptionToolStripMenuItem
            // 
            this.newEncryptionToolStripMenuItem.Name = "newEncryptionToolStripMenuItem";
            this.newEncryptionToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.newEncryptionToolStripMenuItem.Text = "New Secret key";
            this.newEncryptionToolStripMenuItem.Click += new System.EventHandler(this.newEncryptionToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.openFileToolStripMenuItem.Text = "Open Secret key";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveEncryptionToolStripMenuItem
            // 
            this.saveEncryptionToolStripMenuItem.Name = "saveEncryptionToolStripMenuItem";
            this.saveEncryptionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveEncryptionToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.saveEncryptionToolStripMenuItem.Text = "Save Secret key";
            this.saveEncryptionToolStripMenuItem.Click += new System.EventHandler(this.saveEncryptionToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(287, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 功能FToolStripMenuItem
            // 
            this.功能FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEnableQuick});
            this.功能FToolStripMenuItem.Name = "功能FToolStripMenuItem";
            this.功能FToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.功能FToolStripMenuItem.Text = "功能(&F)";
            // 
            // ToolStripMenuItemEnableQuick
            // 
            this.ToolStripMenuItemEnableQuick.Name = "ToolStripMenuItemEnableQuick";
            this.ToolStripMenuItemEnableQuick.Size = new System.Drawing.Size(232, 28);
            this.ToolStripMenuItemEnableQuick.Text = "启用/禁用快速加密";
            this.ToolStripMenuItemEnableQuick.Click += new System.EventHandler(this.ToolStripMenuItemEnableQuick_Click);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOverride,
            this.ToolStripMenuItemLocalEn});
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            // 
            // ToolStripMenuItemOverride
            // 
            this.ToolStripMenuItemOverride.Name = "ToolStripMenuItemOverride";
            this.ToolStripMenuItemOverride.Size = new System.Drawing.Size(368, 28);
            this.ToolStripMenuItemOverride.Text = "覆盖原文件";
            this.ToolStripMenuItemOverride.Click += new System.EventHandler(this.ToolStripMenuItemOverride_Click);
            // 
            // ToolStripMenuItemLocalEn
            // 
            this.ToolStripMenuItemLocalEn.Name = "ToolStripMenuItemLocalEn";
            this.ToolStripMenuItemLocalEn.Size = new System.Drawing.Size(368, 28);
            this.ToolStripMenuItemLocalEn.Text = "使用本机码加密（只能在本机解密）";
            this.ToolStripMenuItemLocalEn.Click += new System.EventHandler(this.ToolStripMenuItemLocalEn_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewEn,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.ToolStripMenuItemClear,
            this.toolStripMenuItem4});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // ToolStripMenuItemNewEn
            // 
            this.ToolStripMenuItemNewEn.Name = "ToolStripMenuItemNewEn";
            this.ToolStripMenuItemNewEn.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.ToolStripMenuItemNewEn.Size = new System.Drawing.Size(201, 28);
            this.ToolStripMenuItemNewEn.Text = "新的密钥行";
            this.ToolStripMenuItemNewEn.Click += new System.EventHandler(this.ToolStripMenuItemNewEn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 28);
            this.toolStripMenuItem2.Text = "上移↑";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItemUp_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 28);
            this.toolStripMenuItem3.Text = "下移↓";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItemDown_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(201, 28);
            this.toolStripMenuItem5.Text = "插入密钥行";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItemIns_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(201, 28);
            this.toolStripMenuItem6.Text = "删除密钥行";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ToolStripMenuDel_Click);
            // 
            // ToolStripMenuItemClear
            // 
            this.ToolStripMenuItemClear.Name = "ToolStripMenuItemClear";
            this.ToolStripMenuItemClear.Size = new System.Drawing.Size(201, 28);
            this.ToolStripMenuItemClear.Text = "清空密钥行";
            this.ToolStripMenuItemClear.Click += new System.EventHandler(this.ToolStripMenuItemClear_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(201, 28);
            this.toolStripMenuItem4.Text = "编辑密钥行";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItemEdit_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(84, 28);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(191, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(195, 102);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 130);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.ToolStripMenuItemEdit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUp,
            this.ToolStripMenuItemDown,
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemIns,
            this.ToolStripMenuDel,
            this.ToolStripMenuItemEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 172);
            // 
            // ToolStripMenuItemUp
            // 
            this.ToolStripMenuItemUp.Name = "ToolStripMenuItemUp";
            this.ToolStripMenuItemUp.Size = new System.Drawing.Size(170, 28);
            this.ToolStripMenuItemUp.Text = "上移↑";
            this.ToolStripMenuItemUp.Click += new System.EventHandler(this.ToolStripMenuItemUp_Click);
            // 
            // ToolStripMenuItemDown
            // 
            this.ToolStripMenuItemDown.Name = "ToolStripMenuItemDown";
            this.ToolStripMenuItemDown.Size = new System.Drawing.Size(170, 28);
            this.ToolStripMenuItemDown.Text = "下移↓";
            this.ToolStripMenuItemDown.Click += new System.EventHandler(this.ToolStripMenuItemDown_Click);
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(170, 28);
            this.ToolStripMenuItemNew.Text = "新的密钥行";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNewEn_Click);
            // 
            // ToolStripMenuItemIns
            // 
            this.ToolStripMenuItemIns.Name = "ToolStripMenuItemIns";
            this.ToolStripMenuItemIns.Size = new System.Drawing.Size(170, 28);
            this.ToolStripMenuItemIns.Text = "插入密钥行";
            this.ToolStripMenuItemIns.Click += new System.EventHandler(this.ToolStripMenuItemIns_Click);
            // 
            // ToolStripMenuDel
            // 
            this.ToolStripMenuDel.Name = "ToolStripMenuDel";
            this.ToolStripMenuDel.Size = new System.Drawing.Size(170, 28);
            this.ToolStripMenuDel.Text = "删除密钥行";
            this.ToolStripMenuDel.Click += new System.EventHandler(this.ToolStripMenuDel_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(170, 28);
            this.ToolStripMenuItemEdit.Text = "编辑密钥行";
            this.ToolStripMenuItemEdit.Click += new System.EventHandler(this.ToolStripMenuItemEdit_Click);
            // 
            // TextB_OpenPath
            // 
            this.TextB_OpenPath.Location = new System.Drawing.Point(100, 266);
            this.TextB_OpenPath.Margin = new System.Windows.Forms.Padding(4);
            this.TextB_OpenPath.Name = "TextB_OpenPath";
            this.TextB_OpenPath.ReadOnly = true;
            this.TextB_OpenPath.Size = new System.Drawing.Size(338, 28);
            this.TextB_OpenPath.TabIndex = 4;
            this.TextB_OpenPath.TextChanged += new System.EventHandler(this.TextB_OpenPath_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 262);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "原文件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "保存为：";
            // 
            // BtnFolderBrowse
            // 
            this.BtnFolderBrowse.Location = new System.Drawing.Point(444, 320);
            this.BtnFolderBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFolderBrowse.Name = "BtnFolderBrowse";
            this.BtnFolderBrowse.Size = new System.Drawing.Size(112, 34);
            this.BtnFolderBrowse.TabIndex = 8;
            this.BtnFolderBrowse.Text = "Browse";
            this.BtnFolderBrowse.UseVisualStyleBackColor = true;
            this.BtnFolderBrowse.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextBdestinationPath
            // 
            this.TextBdestinationPath.Location = new System.Drawing.Point(100, 322);
            this.TextBdestinationPath.Margin = new System.Windows.Forms.Padding(4);
            this.TextBdestinationPath.Name = "TextBdestinationPath";
            this.TextBdestinationPath.Size = new System.Drawing.Size(338, 28);
            this.TextBdestinationPath.TabIndex = 7;
            this.TextBdestinationPath.TextChanged += new System.EventHandler(this.TextBdestinationPath_TextChanged);
            // 
            // RadioBencryption
            // 
            this.RadioBencryption.AutoSize = true;
            this.RadioBencryption.Checked = true;
            this.RadioBencryption.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioBencryption.Location = new System.Drawing.Point(56, 130);
            this.RadioBencryption.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBencryption.Name = "RadioBencryption";
            this.RadioBencryption.Size = new System.Drawing.Size(83, 28);
            this.RadioBencryption.TabIndex = 10;
            this.RadioBencryption.TabStop = true;
            this.RadioBencryption.Text = "加密";
            this.RadioBencryption.UseVisualStyleBackColor = true;
            this.RadioBencryption.CheckedChanged += new System.EventHandler(this.RadioBencryption_CheckedChanged);
            // 
            // RadioBdecryption
            // 
            this.RadioBdecryption.AutoSize = true;
            this.RadioBdecryption.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioBdecryption.Location = new System.Drawing.Point(56, 164);
            this.RadioBdecryption.Margin = new System.Windows.Forms.Padding(4);
            this.RadioBdecryption.Name = "RadioBdecryption";
            this.RadioBdecryption.Size = new System.Drawing.Size(83, 28);
            this.RadioBdecryption.TabIndex = 10;
            this.RadioBdecryption.Text = "解密";
            this.RadioBdecryption.UseVisualStyleBackColor = true;
            this.RadioBdecryption.CheckedChanged += new System.EventHandler(this.RadioBencryption_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(38, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(112, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模式";
            // 
            // BtnDo
            // 
            this.BtnDo.Location = new System.Drawing.Point(226, 387);
            this.BtnDo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDo.Name = "BtnDo";
            this.BtnDo.Size = new System.Drawing.Size(116, 33);
            this.BtnDo.TabIndex = 12;
            this.BtnDo.Text = "加密";
            this.BtnDo.UseVisualStyleBackColor = true;
            this.BtnDo.Click += new System.EventHandler(this.BtnDo_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(444, 126);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(112, 34);
            this.BtnDel.TabIndex = 13;
            this.BtnDel.Text = "删除密钥行";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.ToolStripMenuDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "加密方式：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnDo);
            this.Controls.Add(this.RadioBdecryption);
            this.Controls.Add(this.RadioBencryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFolderBrowse);
            this.Controls.Add(this.TextBdestinationPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TextB_OpenPath);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件加密器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClear;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewEn;
        private System.Windows.Forms.TextBox TextB_OpenPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFolderBrowse;
        private System.Windows.Forms.TextBox TextBdestinationPath;
        private System.Windows.Forms.RadioButton RadioBencryption;
        private System.Windows.Forms.RadioButton RadioBdecryption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDo;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOverride;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDown;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemIns;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuDel;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLocalEn;
        private System.Windows.Forms.ToolStripMenuItem 功能FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEnableQuick;
    }
}

