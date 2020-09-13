namespace YildizGroundStation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel_status = new MetroFramework.Controls.MetroPanel();
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.cBox_ports = new MetroFramework.Controls.MetroComboBox();
            this.cBox_baudrate = new MetroFramework.Controls.MetroComboBox();
            this.lbl_BaudRate = new MetroFramework.Controls.MetroLabel();
            this.lbl_port = new MetroFramework.Controls.MetroLabel();
            this.btn_connect = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroTile14 = new MetroFramework.Controls.MetroTile();
            this.metroTile13 = new MetroFramework.Controls.MetroTile();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabControl_main = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_home = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.textBox_missions = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBox_speed = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_sendmission = new MetroFramework.Controls.MetroButton();
            this.btn_setpoint = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox_altitude = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.textBox_lat = new MetroFramework.Controls.MetroTextBox();
            this.textBox_lon = new MetroFramework.Controls.MetroTextBox();
            this.btn_deletelastmission = new MetroFramework.Controls.MetroButton();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_incoming = new MetroFramework.Controls.MetroTextBox();
            this.btn_stop_mission = new MetroFramework.Controls.MetroButton();
            this.btn_start_mission = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.attitudeIndicatorInstrumentControl1 = new YildizGroundStation.AttitudeIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new YildizGroundStation.HeadingIndicatorInstrumentControl();
            this.textBox_Log = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.timer_livechart = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.trackPitchAngle = new System.Windows.Forms.TrackBar();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.send_mission_timer = new System.Windows.Forms.Timer(this.components);
            this.metroPanel_status.SuspendLayout();
            this.metroTabControl_main.SuspendLayout();
            this.metroTabPage_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.metroTabPage8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPitchAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel_status
            // 
            this.metroPanel_status.Controls.Add(this.lbl_status);
            this.metroPanel_status.Controls.Add(this.cBox_ports);
            this.metroPanel_status.Controls.Add(this.cBox_baudrate);
            this.metroPanel_status.Controls.Add(this.lbl_BaudRate);
            this.metroPanel_status.Controls.Add(this.lbl_port);
            this.metroPanel_status.Controls.Add(this.btn_connect);
            this.metroPanel_status.Controls.Add(this.metroButton8);
            this.metroPanel_status.Controls.Add(this.metroButton7);
            this.metroPanel_status.Controls.Add(this.metroTile14);
            this.metroPanel_status.Controls.Add(this.metroTile13);
            this.metroPanel_status.Controls.Add(this.metroTile12);
            this.metroPanel_status.Controls.Add(this.metroTile11);
            this.metroPanel_status.Controls.Add(this.metroTile10);
            this.metroPanel_status.Controls.Add(this.metroTile9);
            this.metroPanel_status.Controls.Add(this.metroTile8);
            this.metroPanel_status.Controls.Add(this.metroTile7);
            this.metroPanel_status.Controls.Add(this.metroTile6);
            this.metroPanel_status.Controls.Add(this.metroTile5);
            this.metroPanel_status.Controls.Add(this.metroTile4);
            this.metroPanel_status.Controls.Add(this.metroTile3);
            this.metroPanel_status.Controls.Add(this.metroTile2);
            this.metroPanel_status.Controls.Add(this.metroTile1);
            this.metroPanel_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel_status.HorizontalScrollbarBarColor = true;
            this.metroPanel_status.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_status.HorizontalScrollbarSize = 10;
            this.metroPanel_status.Location = new System.Drawing.Point(23, 65);
            this.metroPanel_status.Name = "metroPanel_status";
            this.metroPanel_status.Size = new System.Drawing.Size(1654, 50);
            this.metroPanel_status.TabIndex = 0;
            this.metroPanel_status.VerticalScrollbarBarColor = true;
            this.metroPanel_status.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_status.VerticalScrollbarSize = 10;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(14, 18);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 19);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status";
            // 
            // cBox_ports
            // 
            this.cBox_ports.FormattingEnabled = true;
            this.cBox_ports.ItemHeight = 23;
            this.cBox_ports.Location = new System.Drawing.Point(700, 13);
            this.cBox_ports.Name = "cBox_ports";
            this.cBox_ports.Size = new System.Drawing.Size(121, 29);
            this.cBox_ports.TabIndex = 5;
            this.cBox_ports.UseSelectable = true;
            this.cBox_ports.DropDown += new System.EventHandler(this.cBox_ports_DropDown);
            // 
            // cBox_baudrate
            // 
            this.cBox_baudrate.FormattingEnabled = true;
            this.cBox_baudrate.ItemHeight = 23;
            this.cBox_baudrate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "9600"});
            this.cBox_baudrate.Location = new System.Drawing.Point(902, 13);
            this.cBox_baudrate.Name = "cBox_baudrate";
            this.cBox_baudrate.Size = new System.Drawing.Size(121, 29);
            this.cBox_baudrate.TabIndex = 5;
            this.cBox_baudrate.UseSelectable = true;
            // 
            // lbl_BaudRate
            // 
            this.lbl_BaudRate.AutoSize = true;
            this.lbl_BaudRate.Location = new System.Drawing.Point(827, 18);
            this.lbl_BaudRate.Name = "lbl_BaudRate";
            this.lbl_BaudRate.Size = new System.Drawing.Size(69, 19);
            this.lbl_BaudRate.TabIndex = 4;
            this.lbl_BaudRate.Text = "Baud Rate";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(660, 18);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(34, 19);
            this.lbl_port.TabIndex = 4;
            this.lbl_port.Text = "Port";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(1029, 13);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(80, 29);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseSelectable = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            this.btn_connect.MouseEnter += new System.EventHandler(this.btn_connect_MouseEnter);
            this.btn_connect.MouseLeave += new System.EventHandler(this.btn_connect_MouseLeave);
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(1126, 15);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(75, 19);
            this.metroButton8.TabIndex = 3;
            this.metroButton8.Text = "Dark";
            this.metroButton8.UseSelectable = true;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(1207, 14);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(75, 19);
            this.metroButton7.TabIndex = 3;
            this.metroButton7.Text = "White";
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroTile14
            // 
            this.metroTile14.ActiveControl = null;
            this.metroTile14.Location = new System.Drawing.Point(1626, 13);
            this.metroTile14.Name = "metroTile14";
            this.metroTile14.Size = new System.Drawing.Size(20, 20);
            this.metroTile14.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile14.TabIndex = 2;
            this.metroTile14.UseSelectable = true;
            this.metroTile14.Click += new System.EventHandler(this.metroTile14_Click);
            // 
            // metroTile13
            // 
            this.metroTile13.ActiveControl = null;
            this.metroTile13.Location = new System.Drawing.Point(1600, 13);
            this.metroTile13.Name = "metroTile13";
            this.metroTile13.Size = new System.Drawing.Size(20, 20);
            this.metroTile13.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile13.TabIndex = 2;
            this.metroTile13.UseSelectable = true;
            this.metroTile13.Click += new System.EventHandler(this.metroTile13_Click);
            // 
            // metroTile12
            // 
            this.metroTile12.ActiveControl = null;
            this.metroTile12.Location = new System.Drawing.Point(1574, 13);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(20, 20);
            this.metroTile12.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile12.TabIndex = 2;
            this.metroTile12.UseSelectable = true;
            this.metroTile12.Click += new System.EventHandler(this.metroTile12_Click);
            // 
            // metroTile11
            // 
            this.metroTile11.ActiveControl = null;
            this.metroTile11.Location = new System.Drawing.Point(1548, 13);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(20, 20);
            this.metroTile11.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTile11.TabIndex = 2;
            this.metroTile11.UseSelectable = true;
            this.metroTile11.Click += new System.EventHandler(this.metroTile11_Click);
            // 
            // metroTile10
            // 
            this.metroTile10.ActiveControl = null;
            this.metroTile10.Location = new System.Drawing.Point(1522, 13);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(20, 20);
            this.metroTile10.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile10.TabIndex = 2;
            this.metroTile10.UseSelectable = true;
            this.metroTile10.Click += new System.EventHandler(this.metroTile10_Click);
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Location = new System.Drawing.Point(1496, 13);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(20, 20);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTile9.TabIndex = 2;
            this.metroTile9.UseSelectable = true;
            this.metroTile9.Click += new System.EventHandler(this.metroTile9_Click);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(1470, 13);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(20, 20);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile8.TabIndex = 2;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(1444, 13);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(20, 20);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile7.TabIndex = 2;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(1418, 14);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(20, 20);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile6.TabIndex = 2;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(1392, 14);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(20, 20);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile5.TabIndex = 2;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(1366, 14);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(20, 20);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 2;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(1340, 14);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(20, 20);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile3.TabIndex = 2;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(1314, 14);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(20, 20);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile2.TabIndex = 2;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(1288, 14);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(20, 20);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTabControl_main
            // 
            this.metroTabControl_main.Controls.Add(this.metroTabPage_home);
            this.metroTabControl_main.Controls.Add(this.metroTabPage1);
            this.metroTabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl_main.HotTrack = true;
            this.metroTabControl_main.Location = new System.Drawing.Point(23, 115);
            this.metroTabControl_main.Margin = new System.Windows.Forms.Padding(0);
            this.metroTabControl_main.Name = "metroTabControl_main";
            this.metroTabControl_main.SelectedIndex = 0;
            this.metroTabControl_main.Size = new System.Drawing.Size(1654, 663);
            this.metroTabControl_main.TabIndex = 1;
            this.metroTabControl_main.UseSelectable = true;
            // 
            // metroTabPage_home
            // 
            this.metroTabPage_home.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage_home.Controls.Add(this.splitContainer1);
            this.metroTabPage_home.HorizontalScrollbarBarColor = false;
            this.metroTabPage_home.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_home.HorizontalScrollbarSize = 0;
            this.metroTabPage_home.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_home.Name = "metroTabPage_home";
            this.metroTabPage_home.Size = new System.Drawing.Size(1646, 621);
            this.metroTabPage_home.TabIndex = 0;
            this.metroTabPage_home.Text = "Home";
            this.metroTabPage_home.VerticalScrollbarBarColor = false;
            this.metroTabPage_home.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_home.VerticalScrollbarSize = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1646, 621);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.metroTabControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer3.Size = new System.Drawing.Size(505, 621);
            this.splitContainer3.SplitterDistance = 257;
            this.splitContainer3.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage7);
            this.metroTabControl1.Controls.Add(this.metroTabPage8);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(505, 257);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.Controls.Add(this.textBox_missions);
            this.metroTabPage7.Controls.Add(this.groupBox1);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 6;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(497, 215);
            this.metroTabPage7.TabIndex = 0;
            this.metroTabPage7.Text = "Mission";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 3;
            // 
            // textBox_missions
            // 
            // 
            // 
            // 
            this.textBox_missions.CustomButton.Image = null;
            this.textBox_missions.CustomButton.Location = new System.Drawing.Point(453, 2);
            this.textBox_missions.CustomButton.Name = "";
            this.textBox_missions.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.textBox_missions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_missions.CustomButton.TabIndex = 1;
            this.textBox_missions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_missions.CustomButton.UseSelectable = true;
            this.textBox_missions.CustomButton.Visible = false;
            this.textBox_missions.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_missions.Lines = new string[0];
            this.textBox_missions.Location = new System.Drawing.Point(0, 140);
            this.textBox_missions.MaxLength = 32767;
            this.textBox_missions.Multiline = true;
            this.textBox_missions.Name = "textBox_missions";
            this.textBox_missions.PasswordChar = '\0';
            this.textBox_missions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_missions.SelectedText = "";
            this.textBox_missions.SelectionLength = 0;
            this.textBox_missions.SelectionStart = 0;
            this.textBox_missions.ShortcutsEnabled = true;
            this.textBox_missions.Size = new System.Drawing.Size(497, 46);
            this.textBox_missions.TabIndex = 16;
            this.textBox_missions.UseSelectable = true;
            this.textBox_missions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_missions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(497, 140);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.metroLabel3, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBox_speed, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.metroLabel1, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_sendmission, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_setpoint, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroLabel2, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox_altitude, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.metroLabel5, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox_lat, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox_lon, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_deletelastmission, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(491, 119);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.Location = new System.Drawing.Point(3, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 32);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Speed [kmh]";
            // 
            // textBox_speed
            // 
            // 
            // 
            // 
            this.textBox_speed.CustomButton.Image = null;
            this.textBox_speed.CustomButton.Location = new System.Drawing.Point(68, 2);
            this.textBox_speed.CustomButton.Name = "";
            this.textBox_speed.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_speed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_speed.CustomButton.TabIndex = 1;
            this.textBox_speed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_speed.CustomButton.UseSelectable = true;
            this.textBox_speed.CustomButton.Visible = false;
            this.textBox_speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_speed.Lines = new string[] {
        "0"};
            this.textBox_speed.Location = new System.Drawing.Point(102, 90);
            this.textBox_speed.MaxLength = 32767;
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.PasswordChar = '\0';
            this.textBox_speed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_speed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_speed.SelectedText = "";
            this.textBox_speed.SelectionLength = 0;
            this.textBox_speed.SelectionStart = 0;
            this.textBox_speed.ShortcutsEnabled = true;
            this.textBox_speed.Size = new System.Drawing.Size(92, 26);
            this.textBox_speed.TabIndex = 15;
            this.textBox_speed.Text = "0";
            this.textBox_speed.UseSelectable = true;
            this.textBox_speed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_speed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 29);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Latitude";
            // 
            // btn_sendmission
            // 
            this.btn_sendmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sendmission.Location = new System.Drawing.Point(347, 3);
            this.btn_sendmission.Name = "btn_sendmission";
            this.tableLayoutPanel4.SetRowSpan(this.btn_sendmission, 4);
            this.btn_sendmission.Size = new System.Drawing.Size(141, 113);
            this.btn_sendmission.TabIndex = 14;
            this.btn_sendmission.Text = "Send Mission";
            this.btn_sendmission.UseSelectable = true;
            this.btn_sendmission.Click += new System.EventHandler(this.btn_sendmission_Click);
            // 
            // btn_setpoint
            // 
            this.btn_setpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_setpoint.Location = new System.Drawing.Point(200, 3);
            this.btn_setpoint.Name = "btn_setpoint";
            this.tableLayoutPanel4.SetRowSpan(this.btn_setpoint, 3);
            this.btn_setpoint.Size = new System.Drawing.Size(141, 81);
            this.btn_setpoint.TabIndex = 14;
            this.btn_setpoint.Text = "Set Point";
            this.btn_setpoint.UseSelectable = true;
            this.btn_setpoint.Click += new System.EventHandler(this.btn_setpoint_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.Location = new System.Drawing.Point(3, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 29);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Longitude";
            // 
            // textBox_altitude
            // 
            // 
            // 
            // 
            this.textBox_altitude.CustomButton.Image = null;
            this.textBox_altitude.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.textBox_altitude.CustomButton.Name = "";
            this.textBox_altitude.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_altitude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_altitude.CustomButton.TabIndex = 1;
            this.textBox_altitude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_altitude.CustomButton.UseSelectable = true;
            this.textBox_altitude.CustomButton.Visible = false;
            this.textBox_altitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_altitude.Lines = new string[] {
        "0"};
            this.textBox_altitude.Location = new System.Drawing.Point(102, 61);
            this.textBox_altitude.MaxLength = 32767;
            this.textBox_altitude.Name = "textBox_altitude";
            this.textBox_altitude.PasswordChar = '\0';
            this.textBox_altitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_altitude.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_altitude.SelectedText = "";
            this.textBox_altitude.SelectionLength = 0;
            this.textBox_altitude.SelectionStart = 0;
            this.textBox_altitude.ShortcutsEnabled = true;
            this.textBox_altitude.Size = new System.Drawing.Size(92, 23);
            this.textBox_altitude.TabIndex = 9;
            this.textBox_altitude.Text = "0";
            this.textBox_altitude.UseSelectable = true;
            this.textBox_altitude.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_altitude.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel5.Location = new System.Drawing.Point(3, 58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 29);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Altitude [m]";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // textBox_lat
            // 
            // 
            // 
            // 
            this.textBox_lat.CustomButton.Image = null;
            this.textBox_lat.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.textBox_lat.CustomButton.Name = "";
            this.textBox_lat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_lat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_lat.CustomButton.TabIndex = 1;
            this.textBox_lat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_lat.CustomButton.UseSelectable = true;
            this.textBox_lat.CustomButton.Visible = false;
            this.textBox_lat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_lat.Lines = new string[] {
        "0"};
            this.textBox_lat.Location = new System.Drawing.Point(102, 3);
            this.textBox_lat.MaxLength = 32767;
            this.textBox_lat.Name = "textBox_lat";
            this.textBox_lat.PasswordChar = '\0';
            this.textBox_lat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_lat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_lat.SelectedText = "";
            this.textBox_lat.SelectionLength = 0;
            this.textBox_lat.SelectionStart = 0;
            this.textBox_lat.ShortcutsEnabled = true;
            this.textBox_lat.Size = new System.Drawing.Size(92, 23);
            this.textBox_lat.TabIndex = 11;
            this.textBox_lat.Text = "0";
            this.textBox_lat.UseSelectable = true;
            this.textBox_lat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_lat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox_lon
            // 
            // 
            // 
            // 
            this.textBox_lon.CustomButton.Image = null;
            this.textBox_lon.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.textBox_lon.CustomButton.Name = "";
            this.textBox_lon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_lon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_lon.CustomButton.TabIndex = 1;
            this.textBox_lon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_lon.CustomButton.UseSelectable = true;
            this.textBox_lon.CustomButton.Visible = false;
            this.textBox_lon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_lon.Lines = new string[] {
        "0"};
            this.textBox_lon.Location = new System.Drawing.Point(102, 32);
            this.textBox_lon.MaxLength = 32767;
            this.textBox_lon.Name = "textBox_lon";
            this.textBox_lon.PasswordChar = '\0';
            this.textBox_lon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_lon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_lon.SelectedText = "";
            this.textBox_lon.SelectionLength = 0;
            this.textBox_lon.SelectionStart = 0;
            this.textBox_lon.ShortcutsEnabled = true;
            this.textBox_lon.Size = new System.Drawing.Size(92, 23);
            this.textBox_lon.TabIndex = 12;
            this.textBox_lon.Text = "0";
            this.textBox_lon.UseSelectable = true;
            this.textBox_lon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_lon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_deletelastmission
            // 
            this.btn_deletelastmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_deletelastmission.Location = new System.Drawing.Point(200, 90);
            this.btn_deletelastmission.Name = "btn_deletelastmission";
            this.btn_deletelastmission.Size = new System.Drawing.Size(141, 26);
            this.btn_deletelastmission.TabIndex = 17;
            this.btn_deletelastmission.Text = "Delete Last Point";
            this.btn_deletelastmission.UseSelectable = true;
            this.btn_deletelastmission.Click += new System.EventHandler(this.btn_deletelastmission_Click);
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.Controls.Add(this.tableLayoutPanel5);
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 6;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(425, 197);
            this.metroTabPage8.TabIndex = 1;
            this.metroTabPage8.Text = "Start/Stop";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.textBox_incoming, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btn_stop_mission, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_start_mission, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(425, 150);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // textBox_incoming
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox_incoming, 2);
            // 
            // 
            // 
            this.textBox_incoming.CustomButton.Image = null;
            this.textBox_incoming.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.textBox_incoming.CustomButton.Name = "";
            this.textBox_incoming.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.textBox_incoming.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_incoming.CustomButton.TabIndex = 1;
            this.textBox_incoming.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_incoming.CustomButton.UseSelectable = true;
            this.textBox_incoming.CustomButton.Visible = false;
            this.textBox_incoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_incoming.Lines = new string[0];
            this.textBox_incoming.Location = new System.Drawing.Point(3, 78);
            this.textBox_incoming.MaxLength = 32767;
            this.textBox_incoming.Multiline = true;
            this.textBox_incoming.Name = "textBox_incoming";
            this.textBox_incoming.PasswordChar = '\0';
            this.textBox_incoming.ReadOnly = true;
            this.textBox_incoming.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_incoming.SelectedText = "";
            this.textBox_incoming.SelectionLength = 0;
            this.textBox_incoming.SelectionStart = 0;
            this.textBox_incoming.ShortcutsEnabled = true;
            this.textBox_incoming.Size = new System.Drawing.Size(419, 69);
            this.textBox_incoming.TabIndex = 3;
            this.textBox_incoming.UseSelectable = true;
            this.textBox_incoming.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_incoming.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_stop_mission
            // 
            this.btn_stop_mission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_stop_mission.Location = new System.Drawing.Point(215, 3);
            this.btn_stop_mission.Name = "btn_stop_mission";
            this.btn_stop_mission.Size = new System.Drawing.Size(207, 69);
            this.btn_stop_mission.TabIndex = 2;
            this.btn_stop_mission.Text = "Stop";
            this.btn_stop_mission.UseSelectable = true;
            this.btn_stop_mission.Click += new System.EventHandler(this.btn_stop_mission_Click);
            // 
            // btn_start_mission
            // 
            this.btn_start_mission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_start_mission.Location = new System.Drawing.Point(3, 3);
            this.btn_start_mission.Name = "btn_start_mission";
            this.btn_start_mission.Size = new System.Drawing.Size(206, 69);
            this.btn_start_mission.TabIndex = 2;
            this.btn_start_mission.Text = "Start";
            this.btn_start_mission.UseSelectable = true;
            this.btn_start_mission.Click += new System.EventHandler(this.btn_start_mission_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 360);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.metroButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroButton2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroButton3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroButton4, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 66);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton1.Location = new System.Drawing.Point(3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 60);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Start";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton2.Location = new System.Drawing.Point(127, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(118, 60);
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "screenshot";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton3.Location = new System.Drawing.Point(251, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(118, 60);
            this.metroButton3.TabIndex = 0;
            this.metroButton3.Text = "folder";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton4.Location = new System.Drawing.Point(375, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(121, 60);
            this.metroButton4.TabIndex = 0;
            this.metroButton4.Text = "stop";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1137, 621);
            this.splitContainer2.SplitterDistance = 469;
            this.splitContainer2.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(3, 6);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1137, 469);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged_1);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.elementHost1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer4.Size = new System.Drawing.Size(1137, 148);
            this.splitContainer4.SplitterDistance = 688;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(688, 148);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.attitudeIndicatorInstrumentControl1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.headingIndicatorInstrumentControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Log, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(299, 3);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(144, 142);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 2;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(151, 3);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(142, 142);
            this.headingIndicatorInstrumentControl1.TabIndex = 3;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // textBox_Log
            // 
            // 
            // 
            // 
            this.textBox_Log.CustomButton.Image = null;
            this.textBox_Log.CustomButton.Location = new System.Drawing.Point(2, 2);
            this.textBox_Log.CustomButton.Name = "";
            this.textBox_Log.CustomButton.Size = new System.Drawing.Size(137, 137);
            this.textBox_Log.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Log.CustomButton.TabIndex = 1;
            this.textBox_Log.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Log.CustomButton.UseSelectable = true;
            this.textBox_Log.CustomButton.Visible = false;
            this.textBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Log.Lines = new string[0];
            this.textBox_Log.Location = new System.Drawing.Point(3, 3);
            this.textBox_Log.MaxLength = 32767;
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.PasswordChar = '\0';
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.SelectedText = "";
            this.textBox_Log.SelectionLength = 0;
            this.textBox_Log.SelectionStart = 0;
            this.textBox_Log.ShortcutsEnabled = true;
            this.textBox_Log.Size = new System.Drawing.Size(142, 142);
            this.textBox_Log.TabIndex = 0;
            this.textBox_Log.UseSelectable = true;
            this.textBox_Log.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Log.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 6;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1646, 621);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Additional";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 3;
            // 
            // timer_livechart
            // 
            this.timer_livechart.Enabled = true;
            this.timer_livechart.Interval = 50;
            this.timer_livechart.Tick += new System.EventHandler(this.timer_livechart_Tick);
            // 
            // trackPitchAngle
            // 
            this.trackPitchAngle.Location = new System.Drawing.Point(50, 80);
            this.trackPitchAngle.Maximum = 45;
            this.trackPitchAngle.Minimum = -45;
            this.trackPitchAngle.Name = "trackPitchAngle";
            this.trackPitchAngle.Size = new System.Drawing.Size(393, 45);
            this.trackPitchAngle.TabIndex = 4;
            this.trackPitchAngle.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // send_mission_timer
            // 
            this.send_mission_timer.Tick += new System.EventHandler(this.send_mission_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 800);
            this.Controls.Add(this.metroTabControl_main);
            this.Controls.Add(this.metroPanel_status);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 65, 23, 22);
            this.Resizable = false;
            this.Text = "Yıldız Ground Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel_status.ResumeLayout(false);
            this.metroPanel_status.PerformLayout();
            this.metroTabControl_main.ResumeLayout(false);
            this.metroTabPage_home.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.metroTabPage8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackPitchAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel_status;
        private MetroFramework.Controls.MetroTabControl metroTabControl_main;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Timer timer_livechart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroTabPage metroTabPage_home;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox textBox_Log;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private System.Windows.Forms.TrackBar trackPitchAngle;
        private AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroTile metroTile14;
        private MetroFramework.Controls.MetroTile metroTile13;
        private MetroFramework.Controls.MetroTile metroTile12;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox cBox_ports;
        private MetroFramework.Controls.MetroComboBox cBox_baudrate;
        private MetroFramework.Controls.MetroLabel lbl_BaudRate;
        private MetroFramework.Controls.MetroLabel lbl_port;
        private MetroFramework.Controls.MetroButton btn_connect;
        private System.IO.Ports.SerialPort serialPort;
        private MetroFramework.Controls.MetroLabel lbl_status;
        private MetroFramework.Controls.MetroTextBox textBox_lat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBox_lon;
        private MetroFramework.Controls.MetroButton btn_setpoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroButton btn_sendmission;
        private MetroFramework.Controls.MetroTextBox textBox_altitude;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox textBox_missions;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textBox_speed;
        private MetroFramework.Controls.MetroButton btn_deletelastmission;
        private System.Windows.Forms.Timer send_mission_timer;
        private MetroFramework.Controls.MetroButton btn_stop_mission;
        private MetroFramework.Controls.MetroButton btn_start_mission;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MetroFramework.Controls.MetroTextBox textBox_incoming;
        //private AttitudeIndicatorInstrumentControl horizonInstrumentControl1;
        //private HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
    }
}

