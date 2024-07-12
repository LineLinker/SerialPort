using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SerialPort
{
    public partial class Form1 : Form
    {
        private bool SerialIsOpen = false;
        private bool IsStopRecv = false;
        private List<byte> recvBuffer = new List<byte>();//接收缓冲区
        private List<byte> sendBuffer = new List<byte>();//发送缓冲区

        int RecvCounts = 0;//接收计数
        int SendCounts = 0;//发送计数
        private string strRead = string.Empty; // 声明 strRead 变量以保存读取的文件内容

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllInit();
        }

        //初始化
        private void AllInit()
        {
            try
            {
                String[] AllPortName = System.IO.Ports.SerialPort.GetPortNames();//获取所有串口
                foreach (String i in AllPortName)
                {
                    Cbb_PortNum.Items.Add(i);
                }

                //下拉列表初始化
                this.Cbb_PortNum.SelectedIndex = 0;//默认选中读取到的第一个串口
                this.Cbb_BaudRate.SelectedItem = "9600";
                this.Cbb_CheckBits.SelectedItem = "None(无)";
                this.Cbb_DataBits.SelectedItem = "8";
                this.Cbb_StopBits.SelectedItem = "1";

                //状态栏初始化
                this.Tssl_RecvNums.Text = "0";
                this.Tssl_SendNums.Text = "0";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Btn_OpenSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (SerialIsOpen)
                {
                    serialPort1.Close();
                    this.Btn_OpenSerial.Text = "打开串口";
                    SerialIsOpen=false;
                    return;
                }
                else {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show("串口" + Cbb_PortNum.Text + "已被占用");
                    }
                    else 
                    {
                        serialPort1.PortName = this.Cbb_PortNum.Text;
                        serialPort1.BaudRate = int.Parse(this.Cbb_BaudRate.Text);
                        serialPort1.DataBits = int.Parse(this.Cbb_DataBits.Text);
                        switch (this.Cbb_CheckBits.SelectedIndex)//校验位设置
                        {
                            case 0:serialPort1.Parity = Parity.None;break;
                            case 1:serialPort1.Parity = Parity.Odd;break;
                            case 2:serialPort1.Parity = Parity.Even;break;
                            default:serialPort1.Parity = Parity.None;break;
                        }
                        switch(this.Cbb_StopBits.SelectedIndex)//停止位设置
                        {
                            case 0:serialPort1.StopBits = StopBits.One;break;
                            case 1:serialPort1.StopBits = StopBits.OnePointFive; break;
                            case 2:serialPort1.StopBits = StopBits.Two; break;
                            default:serialPort1.StopBits = StopBits.One; break;
                        }
                        serialPort1.Open();
                        this.Btn_OpenSerial.Text = "关闭串口";
                        SerialIsOpen = true;
                    }
                }               
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Btn_OpenSerial.Text = "打开串口";
                SerialIsOpen = false;
                throw;
            }
        }

        private void Btn_ManualSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if(Rtb_Send.Text.Length>0)
                {
                    serialPort1.Write(sendBuffer.ToArray(),0,sendBuffer.Count);
                    SendCounts+=sendBuffer.Count;
                    Tssl_SendNums.Text=SendCounts.ToString();
                }
                else
                {
                    MessageBox.Show("发送不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (IsStopRecv)//停止接收时，不接收并清空接收缓冲区
            { 
                serialPort1.DiscardInBuffer(); 
                return; 
            }
            // 读取串口数据
            // 创建一个字节数组，用于存储从串口读取的数据，数组长度为当前串口可读取的字节数
            byte[] buffer = new byte[serialPort1.BytesToRead];
            // 从串口读取数据，并将读取的数据存储到 buffer 数组中
            serialPort1.Read(buffer, 0, buffer.Length);
            // 将接收到的数据追加到缓冲区
            recvBuffer.AddRange(buffer);
            // 更新接收计数器，累加接收到的字节数
            RecvCounts += buffer.Length;
            // 在UI线程上更新UI
            BeginInvoke(new Action(() =>
            {
                if (Cb_Recv_Hex.Checked) // 16进制接收
                {
                    Rtb_Recv.AppendText(BitConverter.ToString(buffer).Replace("-", " "));
                    Rtb_Recv.AppendText(" ");
                }
                else // GB2312接收
                {
                    // 替换掉所有的 0x00 字节为 \0 形式   由于0x00不会显示，故转译为\0
                    Rtb_Recv.AppendText(Encoding.GetEncoding("gb2312").GetString(buffer).Replace("\0", "\\0"));
                }
                // 滚动到 RichTextBox 的末尾
                Rtb_Recv.SelectionStart = Rtb_Recv.Text.Length;
                Rtb_Recv.ScrollToCaret();
                //UI接收计数同步
                Tssl_RecvNums.Text = RecvCounts.ToString();
            }));
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            if (IsStopRecv) {
                IsStopRecv = false;
                Btn_Stop.Text = "停止";
            }
            else
            {
                IsStopRecv = true;
                Btn_Stop.Text = "继续";
            }
        }

        private void Cb_Recv_Hex_CheckedChanged(object sender, EventArgs e)
        {
            if (Rtb_Recv.Text.Length<=0) return;
            if (Cb_Recv_Hex.Checked) //将接收到的数据显示为16进制
            {
                Rtb_Recv.Text = BitConverter.ToString(recvBuffer.ToArray()).Replace("-", " ");
            }
            else//否则为默认GB2312
            {
                Rtb_Recv.Text= Encoding.GetEncoding("gb2312").GetString(recvBuffer.ToArray()).Replace("\0", "\\0");
            }
            // 确保光标移动到文本的末尾
            Rtb_Recv.SelectionStart = Rtb_Recv.Text.Length;
            Rtb_Recv.ScrollToCaret();
        }

        private void Btn_Manual_Clear_Click(object sender, EventArgs e)
        {
            RecvCounts = 0;
            Tssl_RecvNums.Text = RecvCounts.ToString();
            recvBuffer.Clear();
            Rtb_Recv.Clear();
        }

        private void Cb_AutoClear_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_AutoClear.Checked) // 自动清除
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RecvCounts >= 10000)
            {
                RecvCounts = 0;
                Tssl_RecvNums.Text = RecvCounts.ToString();
                Rtb_Recv.Clear();
                recvBuffer.Clear();
            }
        }

        private void Cb_Send_Hex_CheckedChanged(object sender, EventArgs e)
        {
            if (Rtb_Send.Text.Length <= 0) return;
            if (Cb_Send_Hex.Checked) //将接收到的数据显示为16进制
            {
                Rtb_Send.Text = BitConverter.ToString(sendBuffer.ToArray()).Replace("-", " ");
            }
            else//否则为默认GB2312
            {
                Rtb_Send.Text = Encoding.GetEncoding("gb2312").GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }
            // 确保光标移动到文本的末尾
            Rtb_Send.SelectionStart = Rtb_Send.Text.Length;
            Rtb_Send.ScrollToCaret();
        }

        private void Btn_ClearSend_Click(object sender, EventArgs e)
        {
            SendCounts = 0;
            Tssl_SendNums.Text = SendCounts.ToString();
            sendBuffer.Clear();
            Rtb_Send.Clear();
        }

        private void Cb_AutoSend_CheckedChanged(object sender, EventArgs e)
        {
            //如果串口没打开  自动发送且被选中
            if (serialPort1.IsOpen==false&&Cb_AutoSend.Checked)
            {
                if (timer2!=null)
                {
                    timer2.Stop();
                    timer2.Enabled = false;
                }
                MessageBox.Show("串口未打开", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Btn_ManualSend.Enabled = true;
                Cb_AutoSend.Checked = false;
                return;
            }
            //确认为自动发送状态
            if (Cb_AutoSend.Checked && serialPort1.IsOpen)
            {
                //无法选中发送框和手动发送按钮
                Rtb_Send.Enabled = false;
                Btn_ManualSend.Enabled = false;
                int interval = int.Parse(Tb_AutoSendCycle.Text);
                if (interval <= 10|| interval >= 10000)
                {
                    interval = 1000;
                    MessageBox.Show("自动发送周期应在10~10000ms之间", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                timer2.Interval = interval;
                timer2.Enabled = true;
                timer2.Start();
            }
            else
            {
                //重新使能发送框和手动发送按钮
                Rtb_Send.Enabled = true;
                Btn_ManualSend.Enabled = true;
                //关闭定时器2
                if (timer2 != null)
                {
                    timer2.Stop();
                    timer2.Enabled = false;
                }
            }
        }

        private void Rtb_Send_Leave(object sender, EventArgs e)
        {
            if (Cb_Send_Hex.Checked)
            {
                string hexString = Rtb_Send.Text.Replace(" ", "");
                if (HexCheck.IsHexString(hexString)) // 检查 Rtb_Send 中是否为有效的十六进制字符串
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(HexCheck.HexStringToByteArray(hexString));
                }
                else
                {
                    MessageBox.Show("请输入正确的十六进制数据", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Rtb_Send.Select();
                }
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding("gb2312").GetBytes(Rtb_Send.Text));
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //到达定时器时间，自动发送数据
            if (serialPort1.IsOpen)
            {
                if (Rtb_Send.Text.Length > 0)
                {
                    serialPort1.Write(sendBuffer.ToArray(), 0, sendBuffer.Count);
                    SendCounts += sendBuffer.Count;
                    Tssl_SendNums.Text = SendCounts.ToString();
                }
                else
                {
                    Btn_ManualSend.Enabled = true;
                    Cb_AutoSend.Checked = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                    MessageBox.Show("发送不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                timer2.Stop();
                timer2.Enabled = false;
                Btn_ManualSend.Enabled = true;
                Cb_AutoSend.Checked = false;
                MessageBox.Show("串口未打开", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //清除计数
        private void Tssl_ClearCount_Click(object sender, EventArgs e)
        {
            recvBuffer.Clear();
            RecvCounts = 0;
            Tssl_RecvNums.Text = RecvCounts.ToString();
            sendBuffer.Clear();
            SendCounts = 0;
            Tssl_SendNums.Text = SendCounts.ToString();
        }

        private void Tssl_MY_Click(object sender, EventArgs e)
        {
            // URL of the website you want to open
            string url = "https://linelinker.serv00.net";
            try
            {
                // Open the specified URL in the default web browser
                Process.Start(url);
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., if the URL is invalid or no default browser is available
                MessageBox.Show("An error occurred while trying to open the website: " + ex.Message);
            }
        }

        private void Cb_RTS_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_RTS.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void Cb_DTR_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_DTR.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void Btn_SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Tb_Path_Recv.Text = fbd.SelectedPath;
            }
        }

        private void Btn_SaveData_Click(object sender, EventArgs e)
        {
            if (Rtb_Recv.Text.Length <= 0)
            {
                MessageBox.Show("接收不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Tb_Path_Recv.Text.Length <= 0)
            {
                MessageBox.Show("路径不能为空", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //存储接收区文本数据
                string FileName = Tb_Path_Recv.Text + "\\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt";
                StreamWriter sw = new StreamWriter(FileName);
                sw.Write(Rtb_Recv.Text);
                sw.Flush();
                sw.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败\n"+ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //该数组仅供发送文件使用
        private byte[] DATA; // 声明用于存储文件内容的字节数组
        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            if (Rtb_Recv.Text.Length > 0)
            {
                Rtb_Recv.Clear();
            }

            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "请选择文件",
                Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*",
                RestoreDirectory = true // 记录上一次打开的目录
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Tb_Path_Send.Text = ofd.FileName; // 将文件路径显示到文本框
                    using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8))
                    {
                        // 读取文件内容（已知为UTF-8 编码）并转换为 GB2312 编码
                        DATA = Encoding.Convert(
                            Encoding.UTF8, Encoding.GetEncoding("gb2312"), 
                            Encoding.UTF8.GetBytes(sr.ReadToEnd())
                            );
                        Rtb_Send.Text = Encoding.GetEncoding("gb2312").GetString(DATA); // 显示到发送框
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件失败\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Btn_SendFile_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("串口未打开", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 串口未打开，退出发送操作
            }

            if (DATA != null && DATA.Length > 0)
            {
                try
                {
                    SendCounts += DATA.Length;
                    // 按页数发送，Windows下串口最大一次发4096
                    int pageNum = DATA.Length / 4096; // 数据可填充页数
                    int remaind = DATA.Length % 4096; // 剩余部分

                    for (int i = 0; i < pageNum; i++)
                    {
                        serialPort1.Write(DATA, i * 4096, 4096);
                        await Task.Delay(10); // 延迟10ms
                    }

                    if (remaind > 0) // 如果剩余部分大于0，则发送剩余部分
                    {
                        serialPort1.Write(DATA, pageNum * 4096, remaind);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发送文件失败\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请先选择文件", "TIPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
