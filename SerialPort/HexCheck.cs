using System;
using System.Windows.Forms;

namespace SerialPort
{
    class HexCheck
    {
        // 检查字符串是否为有效的十六进制字符串
        public static bool IsHexString(string hex)
        {
            foreach (char c in hex)
            {
                if (!Uri.IsHexDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // 将十六进制字符串转换为字节数组
        public static byte[] HexStringToByteArray(string hex)
        {
            try
            {
                int length = hex.Length;
                byte[] bytes = new byte[length / 2];
                for (int i = 0; i < length; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                }
                return bytes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()+"\n 转化出现错误，请修改", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }
}
