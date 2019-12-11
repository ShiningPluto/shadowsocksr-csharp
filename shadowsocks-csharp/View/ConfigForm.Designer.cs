namespace Shadowsocks.View
{
    partial class ConfigForm
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.picQRcode = new System.Windows.Forms.PictureBox();
			this.lstServers = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.llbUpdate = new System.Windows.Forms.LinkLabel();
			this.ServerGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cmbObfs = new System.Windows.Forms.ComboBox();
			this.lblObfs = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtLink = new System.Windows.Forms.TextBox();
			this.lblObfsUdp = new System.Windows.Forms.Label();
			this.chkObfsUDP = new System.Windows.Forms.CheckBox();
			this.lblTCPProtocol = new System.Windows.Forms.Label();
			this.LabelNote = new System.Windows.Forms.Label();
			this.chkPassword = new System.Windows.Forms.CheckBox();
			this.lblTcpOverUdp = new System.Windows.Forms.Label();
			this.chkTcpOverUdp = new System.Windows.Forms.CheckBox();
			this.cmbTcpProtocol = new System.Windows.Forms.ComboBox();
			this.chkAdvSetting = new System.Windows.Forms.CheckBox();
			this.lblUDPPort = new System.Windows.Forms.Label();
			this.nudUdpPort = new System.Windows.Forms.NumericUpDown();
			this.chkSSRLink = new System.Windows.Forms.CheckBox();
			this.chkIP = new System.Windows.Forms.CheckBox();
			this.lblGroup = new System.Windows.Forms.Label();
			this.txtGroup = new System.Windows.Forms.TextBox();
			this.lblServerPort = new System.Windows.Forms.Label();
			this.nudServerPort = new System.Windows.Forms.NumericUpDown();
			this.lblEncryption = new System.Windows.Forms.Label();
			this.cmbEncryption = new System.Windows.Forms.ComboBox();
			this.lblProtocolParam = new System.Windows.Forms.Label();
			this.txtProtocolParam = new System.Windows.Forms.TextBox();
			this.lblObfsParam = new System.Windows.Forms.Label();
			this.txtObfsParam = new System.Windows.Forms.TextBox();
			this.lblRemarks = new System.Windows.Forms.Label();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.lblUdpOverTcp = new System.Windows.Forms.Label();
			this.chkUdpOverTcp = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.picQRcode)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.ServerGroupBox.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudUdpPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnDelete.Location = new System.Drawing.Point(255, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 34);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnAdd.Location = new System.Drawing.Point(381, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 34);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// picQRcode
			// 
			this.picQRcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.picQRcode.BackColor = System.Drawing.SystemColors.Control;
			this.picQRcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picQRcode.Location = new System.Drawing.Point(32, 442);
			this.picQRcode.Margin = new System.Windows.Forms.Padding(8);
			this.picQRcode.Name = "picQRcode";
			this.picQRcode.Size = new System.Drawing.Size(250, 234);
			this.picQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picQRcode.TabIndex = 13;
			this.picQRcode.TabStop = false;
			// 
			// lstServers
			// 
			this.lstServers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstServers.Font = new System.Drawing.Font("宋体", 9F);
			this.lstServers.HorizontalScrollbar = true;
			this.lstServers.ItemHeight = 12;
			this.lstServers.Location = new System.Drawing.Point(0, 0);
			this.lstServers.Margin = new System.Windows.Forms.Padding(0);
			this.lstServers.Name = "lstServers";
			this.lstServers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstServers.Size = new System.Drawing.Size(632, 627);
			this.lstServers.TabIndex = 0;
			this.lstServers.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ServerGroupBox, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(200, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 651);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.AutoSize = true;
			this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel7.ColumnCount = 1;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel7.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel7.Controls.Add(this.llbUpdate, 0, 2);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel7.MinimumSize = new System.Drawing.Size(200, 0);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 3;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(638, 701);
			this.tableLayoutPanel7.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.lstServers);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 627);
			this.panel1.TabIndex = 8;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.btnDown);
			this.flowLayoutPanel1.Controls.Add(this.btnUp);
			this.flowLayoutPanel1.Controls.Add(this.btnDelete);
			this.flowLayoutPanel1.Controls.Add(this.btnAdd);
			this.flowLayoutPanel1.Controls.Add(this.btnOK);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 636);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(632, 40);
			this.flowLayoutPanel1.TabIndex = 40;
			// 
			// btnDown
			// 
			this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnDown.BackColor = System.Drawing.SystemColors.Control;
			this.btnDown.FlatAppearance.BorderSize = 0;
			this.btnDown.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDown.Location = new System.Drawing.Point(3, 3);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(120, 34);
			this.btnDown.TabIndex = 4;
			this.btnDown.Text = "Down";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.DownButton_Click);
			// 
			// btnUp
			// 
			this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnUp.Location = new System.Drawing.Point(129, 3);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(120, 34);
			this.btnUp.TabIndex = 3;
			this.btnUp.Text = "Up";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.UpButton_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(507, 3);
			this.btnOK.MinimumSize = new System.Drawing.Size(80, 0);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(120, 34);
			this.btnOK.TabIndex = 38;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// llbUpdate
			// 
			this.llbUpdate.AutoSize = true;
			this.llbUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.llbUpdate.Location = new System.Drawing.Point(5, 684);
			this.llbUpdate.Margin = new System.Windows.Forms.Padding(5);
			this.llbUpdate.Name = "llbUpdate";
			this.llbUpdate.Size = new System.Drawing.Size(628, 12);
			this.llbUpdate.TabIndex = 5;
			this.llbUpdate.TabStop = true;
			this.llbUpdate.Text = "New version available";
			this.llbUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUpdate_LinkClicked);
			// 
			// ServerGroupBox
			// 
			this.ServerGroupBox.AutoSize = true;
			this.ServerGroupBox.Controls.Add(this.tableLayoutPanel3);
			this.ServerGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ServerGroupBox.Location = new System.Drawing.Point(644, 0);
			this.ServerGroupBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.ServerGroupBox.Name = "ServerGroupBox";
			this.ServerGroupBox.Size = new System.Drawing.Size(320, 704);
			this.ServerGroupBox.TabIndex = 20;
			this.ServerGroupBox.TabStop = false;
			this.ServerGroupBox.Text = "Server";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.picQRcode, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(314, 684);
			this.tableLayoutPanel3.TabIndex = 14;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.cmbObfs, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.lblObfs, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.txtIP, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtLink, 1, 10);
			this.tableLayoutPanel1.Controls.Add(this.lblObfsUdp, 0, 15);
			this.tableLayoutPanel1.Controls.Add(this.chkObfsUDP, 1, 15);
			this.tableLayoutPanel1.Controls.Add(this.lblTCPProtocol, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.LabelNote, 1, 11);
			this.tableLayoutPanel1.Controls.Add(this.chkPassword, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblTcpOverUdp, 0, 13);
			this.tableLayoutPanel1.Controls.Add(this.chkTcpOverUdp, 1, 13);
			this.tableLayoutPanel1.Controls.Add(this.cmbTcpProtocol, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.chkAdvSetting, 0, 11);
			this.tableLayoutPanel1.Controls.Add(this.lblUDPPort, 0, 12);
			this.tableLayoutPanel1.Controls.Add(this.nudUdpPort, 1, 12);
			this.tableLayoutPanel1.Controls.Add(this.chkSSRLink, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.chkIP, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblGroup, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.txtGroup, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.lblServerPort, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.nudServerPort, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblEncryption, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.cmbEncryption, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblProtocolParam, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.txtProtocolParam, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.lblObfsParam, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.txtObfsParam, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.lblRemarks, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.txtRemarks, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.lblUdpOverTcp, 0, 16);
			this.tableLayoutPanel1.Controls.Add(this.chkUdpOverTcp, 1, 16);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 8);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
			this.tableLayoutPanel1.RowCount = 17;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 426);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// cmbObfs
			// 
			this.cmbObfs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbObfs.FormattingEnabled = true;
			this.cmbObfs.Items.AddRange(new object[] {
            "plain",
            "http_simple",
            "http_post",
            "random_head",
            "tls1.2_ticket_auth",
            "tls1.2_ticket_fastauth"});
			this.cmbObfs.Location = new System.Drawing.Point(102, 176);
			this.cmbObfs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
			this.cmbObfs.Name = "cmbObfs";
			this.cmbObfs.Size = new System.Drawing.Size(198, 20);
			this.cmbObfs.TabIndex = 19;
			this.cmbObfs.TextChanged += new System.EventHandler(this.ObfsCombo_TextChanged);
			// 
			// lblObfs
			// 
			this.lblObfs.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblObfs.AutoSize = true;
			this.lblObfs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblObfs.Location = new System.Drawing.Point(6, 182);
			this.lblObfs.Margin = new System.Windows.Forms.Padding(3);
			this.lblObfs.Name = "lblObfs";
			this.lblObfs.Size = new System.Drawing.Size(29, 12);
			this.lblObfs.TabIndex = 18;
			this.lblObfs.Text = "Obfs";
			// 
			// txtIP
			// 
			this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIP.Location = new System.Drawing.Point(102, 6);
			this.txtIP.MaxLength = 512;
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(198, 21);
			this.txtIP.TabIndex = 7;
			this.txtIP.UseSystemPasswordChar = true;
			this.txtIP.WordWrap = false;
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(102, 60);
			this.txtPassword.MaxLength = 256;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(198, 21);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.WordWrap = false;
			// 
			// txtLink
			// 
			this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLink.Location = new System.Drawing.Point(102, 288);
			this.txtLink.Name = "txtLink";
			this.txtLink.ReadOnly = true;
			this.txtLink.Size = new System.Drawing.Size(198, 21);
			this.txtLink.TabIndex = 27;
			this.txtLink.WordWrap = false;
			this.txtLink.Enter += new System.EventHandler(this.TextBox_Enter);
			this.txtLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseUp);
			// 
			// lblObfsUdp
			// 
			this.lblObfsUdp.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblObfsUdp.AutoSize = true;
			this.lblObfsUdp.Location = new System.Drawing.Point(6, 384);
			this.lblObfsUdp.Margin = new System.Windows.Forms.Padding(3);
			this.lblObfsUdp.Name = "lblObfsUdp";
			this.lblObfsUdp.Size = new System.Drawing.Size(53, 12);
			this.lblObfsUdp.TabIndex = 36;
			this.lblObfsUdp.Text = "Obfs UDP";
			this.lblObfsUdp.Visible = false;
			// 
			// chkObfsUDP
			// 
			this.chkObfsUDP.AutoSize = true;
			this.chkObfsUDP.Location = new System.Drawing.Point(102, 382);
			this.chkObfsUDP.Name = "chkObfsUDP";
			this.chkObfsUDP.Size = new System.Drawing.Size(126, 16);
			this.chkObfsUDP.TabIndex = 37;
			this.chkObfsUDP.Text = "Recommend checked";
			this.chkObfsUDP.UseVisualStyleBackColor = true;
			this.chkObfsUDP.Visible = false;
			// 
			// lblTCPProtocol
			// 
			this.lblTCPProtocol.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTCPProtocol.AutoSize = true;
			this.lblTCPProtocol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblTCPProtocol.Location = new System.Drawing.Point(6, 124);
			this.lblTCPProtocol.Margin = new System.Windows.Forms.Padding(3);
			this.lblTCPProtocol.Name = "lblTCPProtocol";
			this.lblTCPProtocol.Size = new System.Drawing.Size(53, 12);
			this.lblTCPProtocol.TabIndex = 14;
			this.lblTCPProtocol.Text = "Protocol";
			// 
			// LabelNote
			// 
			this.LabelNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.LabelNote.AutoSize = true;
			this.LabelNote.Location = new System.Drawing.Point(99, 315);
			this.LabelNote.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.LabelNote.Name = "LabelNote";
			this.LabelNote.Size = new System.Drawing.Size(179, 12);
			this.LabelNote.TabIndex = 29;
			this.LabelNote.Text = "NOT all server support belows";
			// 
			// chkPassword
			// 
			this.chkPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkPassword.AutoSize = true;
			this.chkPassword.Location = new System.Drawing.Point(3, 62);
			this.chkPassword.Margin = new System.Windows.Forms.Padding(0);
			this.chkPassword.Name = "chkPassword";
			this.chkPassword.Size = new System.Drawing.Size(72, 16);
			this.chkPassword.TabIndex = 10;
			this.chkPassword.Text = "Password";
			this.chkPassword.UseVisualStyleBackColor = true;
			this.chkPassword.CheckedChanged += new System.EventHandler(this.PasswordLabel_CheckedChanged);
			// 
			// lblTcpOverUdp
			// 
			this.lblTcpOverUdp.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTcpOverUdp.AutoSize = true;
			this.lblTcpOverUdp.Location = new System.Drawing.Point(6, 362);
			this.lblTcpOverUdp.Margin = new System.Windows.Forms.Padding(3);
			this.lblTcpOverUdp.Name = "lblTcpOverUdp";
			this.lblTcpOverUdp.Size = new System.Drawing.Size(77, 12);
			this.lblTcpOverUdp.TabIndex = 32;
			this.lblTcpOverUdp.Text = "TCP over UDP";
			this.lblTcpOverUdp.Visible = false;
			// 
			// chkTcpOverUdp
			// 
			this.chkTcpOverUdp.AutoSize = true;
			this.chkTcpOverUdp.Location = new System.Drawing.Point(102, 360);
			this.chkTcpOverUdp.Name = "chkTcpOverUdp";
			this.chkTcpOverUdp.Size = new System.Drawing.Size(186, 16);
			this.chkTcpOverUdp.TabIndex = 33;
			this.chkTcpOverUdp.Text = "TCP over UDP if not checked";
			this.chkTcpOverUdp.UseVisualStyleBackColor = true;
			this.chkTcpOverUdp.Visible = false;
			// 
			// cmbTcpProtocol
			// 
			this.cmbTcpProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbTcpProtocol.FormattingEnabled = true;
			this.cmbTcpProtocol.Items.AddRange(new object[] {
            "origin",
            "verify_deflate",
            "auth_sha1_v4",
            "auth_aes128_md5",
            "auth_aes128_sha1",
            "auth_chain_a",
            "auth_chain_b",
            "auth_chain_c",
            "auth_chain_d",
            "auth_chain_e",
            "auth_chain_f",
            "auth_akarin_rand",
            "auth_akarin_spec_a"});
			this.cmbTcpProtocol.Location = new System.Drawing.Point(102, 118);
			this.cmbTcpProtocol.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
			this.cmbTcpProtocol.Name = "cmbTcpProtocol";
			this.cmbTcpProtocol.Size = new System.Drawing.Size(198, 20);
			this.cmbTcpProtocol.TabIndex = 15;
			// 
			// chkAdvSetting
			// 
			this.chkAdvSetting.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkAdvSetting.AutoSize = true;
			this.chkAdvSetting.Location = new System.Drawing.Point(3, 313);
			this.chkAdvSetting.Margin = new System.Windows.Forms.Padding(0);
			this.chkAdvSetting.Name = "chkAdvSetting";
			this.chkAdvSetting.Size = new System.Drawing.Size(96, 16);
			this.chkAdvSetting.TabIndex = 28;
			this.chkAdvSetting.Text = "Adv. Setting";
			this.chkAdvSetting.UseVisualStyleBackColor = true;
			this.chkAdvSetting.CheckedChanged += new System.EventHandler(this.checkAdvSetting_CheckedChanged);
			// 
			// lblUDPPort
			// 
			this.lblUDPPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblUDPPort.AutoSize = true;
			this.lblUDPPort.Location = new System.Drawing.Point(6, 337);
			this.lblUDPPort.Margin = new System.Windows.Forms.Padding(3);
			this.lblUDPPort.Name = "lblUDPPort";
			this.lblUDPPort.Size = new System.Drawing.Size(53, 12);
			this.lblUDPPort.TabIndex = 30;
			this.lblUDPPort.Text = "UDP Port";
			this.lblUDPPort.Visible = false;
			// 
			// nudUdpPort
			// 
			this.nudUdpPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudUdpPort.Location = new System.Drawing.Point(102, 333);
			this.nudUdpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudUdpPort.Name = "nudUdpPort";
			this.nudUdpPort.Size = new System.Drawing.Size(198, 21);
			this.nudUdpPort.TabIndex = 31;
			this.nudUdpPort.Visible = false;
			// 
			// chkSSRLink
			// 
			this.chkSSRLink.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkSSRLink.AutoSize = true;
			this.chkSSRLink.Checked = true;
			this.chkSSRLink.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSSRLink.Location = new System.Drawing.Point(3, 290);
			this.chkSSRLink.Margin = new System.Windows.Forms.Padding(0);
			this.chkSSRLink.Name = "chkSSRLink";
			this.chkSSRLink.Size = new System.Drawing.Size(72, 16);
			this.chkSSRLink.TabIndex = 26;
			this.chkSSRLink.Text = "SSR Link";
			this.chkSSRLink.UseVisualStyleBackColor = true;
			this.chkSSRLink.CheckedChanged += new System.EventHandler(this.checkSSRLink_CheckedChanged);
			// 
			// chkIP
			// 
			this.chkIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkIP.AutoSize = true;
			this.chkIP.Location = new System.Drawing.Point(3, 8);
			this.chkIP.Margin = new System.Windows.Forms.Padding(0);
			this.chkIP.Name = "chkIP";
			this.chkIP.Size = new System.Drawing.Size(78, 16);
			this.chkIP.TabIndex = 38;
			this.chkIP.Text = "Server IP";
			this.chkIP.UseVisualStyleBackColor = true;
			this.chkIP.CheckedChanged += new System.EventHandler(this.IPLabel_CheckedChanged);
			// 
			// lblGroup
			// 
			this.lblGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblGroup.AutoSize = true;
			this.lblGroup.Location = new System.Drawing.Point(6, 238);
			this.lblGroup.Margin = new System.Windows.Forms.Padding(3);
			this.lblGroup.Name = "lblGroup";
			this.lblGroup.Size = new System.Drawing.Size(35, 12);
			this.lblGroup.TabIndex = 24;
			this.lblGroup.Text = "Group";
			// 
			// txtGroup
			// 
			this.txtGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGroup.Location = new System.Drawing.Point(102, 234);
			this.txtGroup.MaxLength = 64;
			this.txtGroup.Name = "txtGroup";
			this.txtGroup.Size = new System.Drawing.Size(198, 21);
			this.txtGroup.TabIndex = 25;
			this.txtGroup.WordWrap = false;
			// 
			// lblServerPort
			// 
			this.lblServerPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblServerPort.AutoSize = true;
			this.lblServerPort.Location = new System.Drawing.Point(6, 37);
			this.lblServerPort.Margin = new System.Windows.Forms.Padding(3);
			this.lblServerPort.Name = "lblServerPort";
			this.lblServerPort.Size = new System.Drawing.Size(71, 12);
			this.lblServerPort.TabIndex = 8;
			this.lblServerPort.Text = "Server Port";
			this.lblServerPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nudServerPort
			// 
			this.nudServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nudServerPort.Location = new System.Drawing.Point(102, 33);
			this.nudServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudServerPort.Name = "nudServerPort";
			this.nudServerPort.Size = new System.Drawing.Size(198, 21);
			this.nudServerPort.TabIndex = 9;
			// 
			// lblEncryption
			// 
			this.lblEncryption.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEncryption.AutoSize = true;
			this.lblEncryption.Location = new System.Drawing.Point(6, 93);
			this.lblEncryption.Margin = new System.Windows.Forms.Padding(3);
			this.lblEncryption.Name = "lblEncryption";
			this.lblEncryption.Size = new System.Drawing.Size(65, 12);
			this.lblEncryption.TabIndex = 12;
			this.lblEncryption.Text = "Encryption";
			this.lblEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbEncryption
			// 
			this.cmbEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbEncryption.FormattingEnabled = true;
			this.cmbEncryption.Location = new System.Drawing.Point(102, 87);
			this.cmbEncryption.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
			this.cmbEncryption.Name = "cmbEncryption";
			this.cmbEncryption.Size = new System.Drawing.Size(198, 20);
			this.cmbEncryption.TabIndex = 13;
			// 
			// lblProtocolParam
			// 
			this.lblProtocolParam.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblProtocolParam.AutoSize = true;
			this.lblProtocolParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblProtocolParam.Location = new System.Drawing.Point(6, 153);
			this.lblProtocolParam.Margin = new System.Windows.Forms.Padding(3);
			this.lblProtocolParam.Name = "lblProtocolParam";
			this.lblProtocolParam.Size = new System.Drawing.Size(89, 12);
			this.lblProtocolParam.TabIndex = 16;
			this.lblProtocolParam.Text = "Protocol param";
			// 
			// txtProtocolParam
			// 
			this.txtProtocolParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProtocolParam.Location = new System.Drawing.Point(102, 149);
			this.txtProtocolParam.Name = "txtProtocolParam";
			this.txtProtocolParam.Size = new System.Drawing.Size(198, 21);
			this.txtProtocolParam.TabIndex = 17;
			// 
			// lblObfsParam
			// 
			this.lblObfsParam.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblObfsParam.AutoSize = true;
			this.lblObfsParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblObfsParam.Location = new System.Drawing.Point(6, 211);
			this.lblObfsParam.Margin = new System.Windows.Forms.Padding(3);
			this.lblObfsParam.Name = "lblObfsParam";
			this.lblObfsParam.Size = new System.Drawing.Size(65, 12);
			this.lblObfsParam.TabIndex = 20;
			this.lblObfsParam.Text = "Obfs param";
			// 
			// txtObfsParam
			// 
			this.txtObfsParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtObfsParam.Location = new System.Drawing.Point(102, 207);
			this.txtObfsParam.Name = "txtObfsParam";
			this.txtObfsParam.Size = new System.Drawing.Size(198, 21);
			this.txtObfsParam.TabIndex = 21;
			// 
			// lblRemarks
			// 
			this.lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblRemarks.AutoSize = true;
			this.lblRemarks.Location = new System.Drawing.Point(6, 265);
			this.lblRemarks.Margin = new System.Windows.Forms.Padding(3);
			this.lblRemarks.Name = "lblRemarks";
			this.lblRemarks.Size = new System.Drawing.Size(47, 12);
			this.lblRemarks.TabIndex = 22;
			this.lblRemarks.Text = "Remarks";
			// 
			// txtRemarks
			// 
			this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRemarks.Location = new System.Drawing.Point(102, 261);
			this.txtRemarks.MaxLength = 256;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(198, 21);
			this.txtRemarks.TabIndex = 23;
			this.txtRemarks.WordWrap = false;
			// 
			// lblUdpOverTcp
			// 
			this.lblUdpOverTcp.AutoSize = true;
			this.lblUdpOverTcp.Location = new System.Drawing.Point(6, 404);
			this.lblUdpOverTcp.Margin = new System.Windows.Forms.Padding(3);
			this.lblUdpOverTcp.Name = "lblUdpOverTcp";
			this.lblUdpOverTcp.Size = new System.Drawing.Size(77, 12);
			this.lblUdpOverTcp.TabIndex = 34;
			this.lblUdpOverTcp.Text = "UDP over TCP";
			this.lblUdpOverTcp.Visible = false;
			// 
			// chkUdpOverTcp
			// 
			this.chkUdpOverTcp.AutoSize = true;
			this.chkUdpOverTcp.Location = new System.Drawing.Point(102, 404);
			this.chkUdpOverTcp.Name = "chkUdpOverTcp";
			this.chkUdpOverTcp.Size = new System.Drawing.Size(186, 16);
			this.chkUdpOverTcp.TabIndex = 35;
			this.chkUdpOverTcp.Text = "UDP over TCP if not checked";
			this.chkUdpOverTcp.UseVisualStyleBackColor = true;
			this.chkUdpOverTcp.Visible = false;
			// 
			// ConfigForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.tableLayoutPanel2);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "ConfigForm";
			this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Servers";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
			this.Shown += new System.EventHandler(this.ConfigForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.picQRcode)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ServerGroupBox.ResumeLayout(false);
			this.ServerGroupBox.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudUdpPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstServers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.PictureBox picQRcode;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox ServerGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbObfs;
        private System.Windows.Forms.Label lblObfs;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.NumericUpDown nudServerPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEncryption;
        private System.Windows.Forms.ComboBox cmbEncryption;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblObfsUdp;
        private System.Windows.Forms.CheckBox chkObfsUDP;
        private System.Windows.Forms.Label lblTCPProtocol;
        private System.Windows.Forms.Label lblUdpOverTcp;
        private System.Windows.Forms.CheckBox chkUdpOverTcp;
        private System.Windows.Forms.Label LabelNote;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.Label lblTcpOverUdp;
        private System.Windows.Forms.CheckBox chkTcpOverUdp;
        private System.Windows.Forms.ComboBox cmbTcpProtocol;
        private System.Windows.Forms.Label lblObfsParam;
        private System.Windows.Forms.TextBox txtObfsParam;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.CheckBox chkAdvSetting;
        private System.Windows.Forms.Label lblUDPPort;
        private System.Windows.Forms.NumericUpDown nudUdpPort;
        private System.Windows.Forms.CheckBox chkSSRLink;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblProtocolParam;
        private System.Windows.Forms.TextBox txtProtocolParam;
        private System.Windows.Forms.CheckBox chkIP;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Panel panel1;
	}
}

