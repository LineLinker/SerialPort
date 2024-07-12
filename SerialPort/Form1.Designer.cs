
namespace SerialPort
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_OpenSerial = new System.Windows.Forms.Button();
            this.Rtb_Recv = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbb_StopBits = new System.Windows.Forms.ComboBox();
            this.Cbb_DataBits = new System.Windows.Forms.ComboBox();
            this.Cbb_CheckBits = new System.Windows.Forms.ComboBox();
            this.Cbb_BaudRate = new System.Windows.Forms.ComboBox();
            this.Cbb_PortNum = new System.Windows.Forms.ComboBox();
            this.Cb_DTR = new System.Windows.Forms.CheckBox();
            this.Cb_RTS = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tb_Path_Recv = new System.Windows.Forms.TextBox();
            this.Btn_SelectPath = new System.Windows.Forms.Button();
            this.Btn_SaveData = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Manual_Clear = new System.Windows.Forms.Button();
            this.Cb_Recv_Hex = new System.Windows.Forms.CheckBox();
            this.Cb_AutoClear = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tb_AutoSendCycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_Path_Send = new System.Windows.Forms.TextBox();
            this.Cb_Send_Hex = new System.Windows.Forms.CheckBox();
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Cb_AutoSend = new System.Windows.Forms.CheckBox();
            this.Btn_SendFile = new System.Windows.Forms.Button();
            this.Btn_ClearSend = new System.Windows.Forms.Button();
            this.Btn_ManualSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Tssl_MY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tssl_RecvNums = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tssl_SendNums = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tssl_ClearCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Rtb_Send = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_OpenSerial
            // 
            this.Btn_OpenSerial.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OpenSerial.Location = new System.Drawing.Point(105, 189);
            this.Btn_OpenSerial.Name = "Btn_OpenSerial";
            this.Btn_OpenSerial.Size = new System.Drawing.Size(133, 40);
            this.Btn_OpenSerial.TabIndex = 0;
            this.Btn_OpenSerial.Text = "打开串口";
            this.Btn_OpenSerial.UseVisualStyleBackColor = true;
            this.Btn_OpenSerial.Click += new System.EventHandler(this.Btn_OpenSerial_Click);
            // 
            // Rtb_Recv
            // 
            this.Rtb_Recv.BackColor = System.Drawing.SystemColors.Window;
            this.Rtb_Recv.Location = new System.Drawing.Point(6, 24);
            this.Rtb_Recv.Name = "Rtb_Recv";
            this.Rtb_Recv.Size = new System.Drawing.Size(470, 390);
            this.Rtb_Recv.TabIndex = 3;
            this.Rtb_Recv.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbb_StopBits);
            this.groupBox1.Controls.Add(this.Cbb_DataBits);
            this.groupBox1.Controls.Add(this.Cbb_CheckBits);
            this.groupBox1.Controls.Add(this.Cbb_BaudRate);
            this.groupBox1.Controls.Add(this.Cbb_PortNum);
            this.groupBox1.Controls.Add(this.Btn_OpenSerial);
            this.groupBox1.Controls.Add(this.Cb_DTR);
            this.groupBox1.Controls.Add(this.Cb_RTS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // Cbb_StopBits
            // 
            this.Cbb_StopBits.FormattingEnabled = true;
            this.Cbb_StopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.Cbb_StopBits.Location = new System.Drawing.Point(110, 148);
            this.Cbb_StopBits.Name = "Cbb_StopBits";
            this.Cbb_StopBits.Size = new System.Drawing.Size(121, 23);
            this.Cbb_StopBits.TabIndex = 11;
            // 
            // Cbb_DataBits
            // 
            this.Cbb_DataBits.FormattingEnabled = true;
            this.Cbb_DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.Cbb_DataBits.Location = new System.Drawing.Point(110, 117);
            this.Cbb_DataBits.Name = "Cbb_DataBits";
            this.Cbb_DataBits.Size = new System.Drawing.Size(121, 23);
            this.Cbb_DataBits.TabIndex = 10;
            // 
            // Cbb_CheckBits
            // 
            this.Cbb_CheckBits.FormattingEnabled = true;
            this.Cbb_CheckBits.Items.AddRange(new object[] {
            "None(无)",
            "Odd(奇)",
            "Even(偶)"});
            this.Cbb_CheckBits.Location = new System.Drawing.Point(110, 87);
            this.Cbb_CheckBits.Name = "Cbb_CheckBits";
            this.Cbb_CheckBits.Size = new System.Drawing.Size(121, 23);
            this.Cbb_CheckBits.TabIndex = 9;
            // 
            // Cbb_BaudRate
            // 
            this.Cbb_BaudRate.FormattingEnabled = true;
            this.Cbb_BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "57600",
            "115200"});
            this.Cbb_BaudRate.Location = new System.Drawing.Point(110, 55);
            this.Cbb_BaudRate.Name = "Cbb_BaudRate";
            this.Cbb_BaudRate.Size = new System.Drawing.Size(121, 23);
            this.Cbb_BaudRate.TabIndex = 8;
            // 
            // Cbb_PortNum
            // 
            this.Cbb_PortNum.FormattingEnabled = true;
            this.Cbb_PortNum.Location = new System.Drawing.Point(110, 25);
            this.Cbb_PortNum.Name = "Cbb_PortNum";
            this.Cbb_PortNum.Size = new System.Drawing.Size(121, 23);
            this.Cbb_PortNum.TabIndex = 7;
            // 
            // Cb_DTR
            // 
            this.Cb_DTR.AutoSize = true;
            this.Cb_DTR.Location = new System.Drawing.Point(30, 210);
            this.Cb_DTR.Name = "Cb_DTR";
            this.Cb_DTR.Size = new System.Drawing.Size(53, 19);
            this.Cb_DTR.TabIndex = 6;
            this.Cb_DTR.Text = "DTR";
            this.Cb_DTR.UseVisualStyleBackColor = true;
            this.Cb_DTR.CheckedChanged += new System.EventHandler(this.Cb_DTR_CheckedChanged);
            // 
            // Cb_RTS
            // 
            this.Cb_RTS.AutoSize = true;
            this.Cb_RTS.Location = new System.Drawing.Point(30, 180);
            this.Cb_RTS.Name = "Cb_RTS";
            this.Cb_RTS.Size = new System.Drawing.Size(53, 19);
            this.Cb_RTS.TabIndex = 5;
            this.Cb_RTS.Text = "RTS";
            this.Cb_RTS.UseVisualStyleBackColor = true;
            this.Cb_RTS.CheckedChanged += new System.EventHandler(this.Cb_RTS_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "校验位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tb_Path_Recv);
            this.groupBox2.Controls.Add(this.Btn_SelectPath);
            this.groupBox2.Controls.Add(this.Btn_SaveData);
            this.groupBox2.Controls.Add(this.Btn_Stop);
            this.groupBox2.Controls.Add(this.Btn_Manual_Clear);
            this.groupBox2.Controls.Add(this.Cb_Recv_Hex);
            this.groupBox2.Controls.Add(this.Cb_AutoClear);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // Tb_Path_Recv
            // 
            this.Tb_Path_Recv.Location = new System.Drawing.Point(28, 133);
            this.Tb_Path_Recv.Name = "Tb_Path_Recv";
            this.Tb_Path_Recv.Size = new System.Drawing.Size(202, 25);
            this.Tb_Path_Recv.TabIndex = 18;
            // 
            // Btn_SelectPath
            // 
            this.Btn_SelectPath.Location = new System.Drawing.Point(30, 96);
            this.Btn_SelectPath.Name = "Btn_SelectPath";
            this.Btn_SelectPath.Size = new System.Drawing.Size(85, 30);
            this.Btn_SelectPath.TabIndex = 17;
            this.Btn_SelectPath.Text = "选择路径";
            this.Btn_SelectPath.UseVisualStyleBackColor = true;
            this.Btn_SelectPath.Click += new System.EventHandler(this.Btn_SelectPath_Click);
            // 
            // Btn_SaveData
            // 
            this.Btn_SaveData.Location = new System.Drawing.Point(145, 96);
            this.Btn_SaveData.Name = "Btn_SaveData";
            this.Btn_SaveData.Size = new System.Drawing.Size(85, 30);
            this.Btn_SaveData.TabIndex = 16;
            this.Btn_SaveData.Text = "保存数据";
            this.Btn_SaveData.UseVisualStyleBackColor = true;
            this.Btn_SaveData.Click += new System.EventHandler(this.Btn_SaveData_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(145, 60);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(85, 30);
            this.Btn_Stop.TabIndex = 15;
            this.Btn_Stop.Text = "暂停";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // Btn_Manual_Clear
            // 
            this.Btn_Manual_Clear.Location = new System.Drawing.Point(145, 24);
            this.Btn_Manual_Clear.Name = "Btn_Manual_Clear";
            this.Btn_Manual_Clear.Size = new System.Drawing.Size(85, 30);
            this.Btn_Manual_Clear.TabIndex = 14;
            this.Btn_Manual_Clear.Text = "手动清空";
            this.Btn_Manual_Clear.UseVisualStyleBackColor = true;
            this.Btn_Manual_Clear.Click += new System.EventHandler(this.Btn_Manual_Clear_Click);
            // 
            // Cb_Recv_Hex
            // 
            this.Cb_Recv_Hex.AutoSize = true;
            this.Cb_Recv_Hex.Location = new System.Drawing.Point(30, 67);
            this.Cb_Recv_Hex.Name = "Cb_Recv_Hex";
            this.Cb_Recv_Hex.Size = new System.Drawing.Size(89, 19);
            this.Cb_Recv_Hex.TabIndex = 13;
            this.Cb_Recv_Hex.Text = "十六进制";
            this.Cb_Recv_Hex.UseVisualStyleBackColor = true;
            this.Cb_Recv_Hex.CheckedChanged += new System.EventHandler(this.Cb_Recv_Hex_CheckedChanged);
            // 
            // Cb_AutoClear
            // 
            this.Cb_AutoClear.AutoSize = true;
            this.Cb_AutoClear.Location = new System.Drawing.Point(30, 35);
            this.Cb_AutoClear.Name = "Cb_AutoClear";
            this.Cb_AutoClear.Size = new System.Drawing.Size(89, 19);
            this.Cb_AutoClear.TabIndex = 12;
            this.Cb_AutoClear.Text = "自动清空";
            this.Cb_AutoClear.UseVisualStyleBackColor = true;
            this.Cb_AutoClear.CheckedChanged += new System.EventHandler(this.Cb_AutoClear_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Tb_AutoSendCycle);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Tb_Path_Send);
            this.groupBox3.Controls.Add(this.Cb_Send_Hex);
            this.groupBox3.Controls.Add(this.Btn_OpenFile);
            this.groupBox3.Controls.Add(this.Cb_AutoSend);
            this.groupBox3.Controls.Add(this.Btn_SendFile);
            this.groupBox3.Controls.Add(this.Btn_ClearSend);
            this.groupBox3.Controls.Add(this.Btn_ManualSend);
            this.groupBox3.Location = new System.Drawing.Point(12, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 219);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // Tb_AutoSendCycle
            // 
            this.Tb_AutoSendCycle.Location = new System.Drawing.Point(171, 173);
            this.Tb_AutoSendCycle.Name = "Tb_AutoSendCycle";
            this.Tb_AutoSendCycle.Size = new System.Drawing.Size(67, 25);
            this.Tb_AutoSendCycle.TabIndex = 27;
            this.Tb_AutoSendCycle.Text = "1000";
            this.Tb_AutoSendCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "自动发送周期（ms）";
            // 
            // Tb_Path_Send
            // 
            this.Tb_Path_Send.Location = new System.Drawing.Point(28, 133);
            this.Tb_Path_Send.Name = "Tb_Path_Send";
            this.Tb_Path_Send.Size = new System.Drawing.Size(202, 25);
            this.Tb_Path_Send.TabIndex = 25;
            // 
            // Cb_Send_Hex
            // 
            this.Cb_Send_Hex.AutoSize = true;
            this.Cb_Send_Hex.Location = new System.Drawing.Point(30, 67);
            this.Cb_Send_Hex.Name = "Cb_Send_Hex";
            this.Cb_Send_Hex.Size = new System.Drawing.Size(89, 19);
            this.Cb_Send_Hex.TabIndex = 20;
            this.Cb_Send_Hex.Text = "十六进制";
            this.Cb_Send_Hex.UseVisualStyleBackColor = true;
            this.Cb_Send_Hex.CheckedChanged += new System.EventHandler(this.Cb_Send_Hex_CheckedChanged);
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Location = new System.Drawing.Point(30, 96);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(85, 30);
            this.Btn_OpenFile.TabIndex = 24;
            this.Btn_OpenFile.Text = "打开文件";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Cb_AutoSend
            // 
            this.Cb_AutoSend.AutoSize = true;
            this.Cb_AutoSend.Location = new System.Drawing.Point(30, 35);
            this.Cb_AutoSend.Name = "Cb_AutoSend";
            this.Cb_AutoSend.Size = new System.Drawing.Size(89, 19);
            this.Cb_AutoSend.TabIndex = 19;
            this.Cb_AutoSend.Text = "自动发送";
            this.Cb_AutoSend.UseVisualStyleBackColor = true;
            this.Cb_AutoSend.CheckedChanged += new System.EventHandler(this.Cb_AutoSend_CheckedChanged);
            // 
            // Btn_SendFile
            // 
            this.Btn_SendFile.Location = new System.Drawing.Point(145, 96);
            this.Btn_SendFile.Name = "Btn_SendFile";
            this.Btn_SendFile.Size = new System.Drawing.Size(85, 30);
            this.Btn_SendFile.TabIndex = 23;
            this.Btn_SendFile.Text = "发送文件";
            this.Btn_SendFile.UseVisualStyleBackColor = true;
            this.Btn_SendFile.Click += new System.EventHandler(this.Btn_SendFile_Click);
            // 
            // Btn_ClearSend
            // 
            this.Btn_ClearSend.Location = new System.Drawing.Point(145, 60);
            this.Btn_ClearSend.Name = "Btn_ClearSend";
            this.Btn_ClearSend.Size = new System.Drawing.Size(85, 30);
            this.Btn_ClearSend.TabIndex = 22;
            this.Btn_ClearSend.Text = "清空发送";
            this.Btn_ClearSend.UseVisualStyleBackColor = true;
            this.Btn_ClearSend.Click += new System.EventHandler(this.Btn_ClearSend_Click);
            // 
            // Btn_ManualSend
            // 
            this.Btn_ManualSend.Location = new System.Drawing.Point(145, 24);
            this.Btn_ManualSend.Name = "Btn_ManualSend";
            this.Btn_ManualSend.Size = new System.Drawing.Size(85, 30);
            this.Btn_ManualSend.TabIndex = 21;
            this.Btn_ManualSend.Text = "手动发送";
            this.Btn_ManualSend.UseVisualStyleBackColor = true;
            this.Btn_ManualSend.Click += new System.EventHandler(this.Btn_ManualSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tssl_MY,
            this.toolStripStatusLabel3,
            this.Tssl_RecvNums,
            this.toolStripStatusLabel5,
            this.Tssl_SendNums,
            this.Tssl_ClearCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 30);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Tssl_MY
            // 
            this.Tssl_MY.BackColor = System.Drawing.SystemColors.Control;
            this.Tssl_MY.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Tssl_MY.IsLink = true;
            this.Tssl_MY.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Tssl_MY.LinkColor = System.Drawing.Color.DarkOrchid;
            this.Tssl_MY.Name = "Tssl_MY";
            this.Tssl_MY.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Tssl_MY.Size = new System.Drawing.Size(160, 24);
            this.Tssl_MY.Text = "⚝Create By YYE";
            this.Tssl_MY.Click += new System.EventHandler(this.Tssl_MY_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 24);
            this.toolStripStatusLabel3.Text = "接收计数：";
            // 
            // Tssl_RecvNums
            // 
            this.Tssl_RecvNums.AutoSize = false;
            this.Tssl_RecvNums.Name = "Tssl_RecvNums";
            this.Tssl_RecvNums.Size = new System.Drawing.Size(110, 24);
            this.Tssl_RecvNums.Text = "1000000";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(84, 24);
            this.toolStripStatusLabel5.Text = "发送计数：";
            // 
            // Tssl_SendNums
            // 
            this.Tssl_SendNums.AutoSize = false;
            this.Tssl_SendNums.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tssl_SendNums.Name = "Tssl_SendNums";
            this.Tssl_SendNums.Size = new System.Drawing.Size(110, 24);
            this.Tssl_SendNums.Text = "1000000";
            // 
            // Tssl_ClearCount
            // 
            this.Tssl_ClearCount.IsLink = true;
            this.Tssl_ClearCount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Tssl_ClearCount.LinkColor = System.Drawing.Color.Black;
            this.Tssl_ClearCount.Name = "Tssl_ClearCount";
            this.Tssl_ClearCount.Size = new System.Drawing.Size(69, 24);
            this.Tssl_ClearCount.Text = "清除计数";
            this.Tssl_ClearCount.Click += new System.EventHandler(this.Tssl_ClearCount_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Rtb_Recv);
            this.groupBox4.Location = new System.Drawing.Point(288, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 420);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Rtb_Send);
            this.groupBox5.Location = new System.Drawing.Point(289, 438);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 219);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送";
            // 
            // Rtb_Send
            // 
            this.Rtb_Send.Location = new System.Drawing.Point(5, 17);
            this.Rtb_Send.Name = "Rtb_Send";
            this.Rtb_Send.Size = new System.Drawing.Size(470, 196);
            this.Rtb_Send.TabIndex = 0;
            this.Rtb_Send.Text = "";
            this.Rtb_Send.Leave += new System.EventHandler(this.Rtb_Send_Leave);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 683);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenSerial;
        private System.Windows.Forms.RichTextBox Rtb_Recv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Tssl_MY;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox Rtb_Send;
        private System.Windows.Forms.ComboBox Cbb_PortNum;
        private System.Windows.Forms.CheckBox Cb_DTR;
        private System.Windows.Forms.CheckBox Cb_RTS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbb_StopBits;
        private System.Windows.Forms.ComboBox Cbb_DataBits;
        private System.Windows.Forms.ComboBox Cbb_CheckBits;
        private System.Windows.Forms.ComboBox Cbb_BaudRate;
        private System.Windows.Forms.Button Btn_SelectPath;
        private System.Windows.Forms.Button Btn_SaveData;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Manual_Clear;
        private System.Windows.Forms.CheckBox Cb_Recv_Hex;
        private System.Windows.Forms.CheckBox Cb_AutoClear;
        private System.Windows.Forms.TextBox Tb_Path_Recv;
        private System.Windows.Forms.TextBox Tb_AutoSendCycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_Path_Send;
        private System.Windows.Forms.CheckBox Cb_Send_Hex;
        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.CheckBox Cb_AutoSend;
        private System.Windows.Forms.Button Btn_SendFile;
        private System.Windows.Forms.Button Btn_ClearSend;
        private System.Windows.Forms.Button Btn_ManualSend;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel Tssl_RecvNums;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel Tssl_SendNums;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripStatusLabel Tssl_ClearCount;
    }
}

