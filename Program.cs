using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }

    //全局变量
    public static class GlobalValue
    {
        public static int globalFormNumber;                //记录当前窗口ID

        public static bool globalLanguage = false;         //false = EN, true = CN.

        public static string[] globalPortName;             //全部的端口名称（数组）
        public static string globalPortNameSet;            //选择的端口名称
        public static bool   globalIsPortOpening = false;  //记录端口状态

        public static string globalTemperature   = "0";    //实时温度
        public static string globalCocktailCode;           //鸡尾酒代码，用于和arduino通信
        public static bool   globalBartending    = false;  //记录调制状态
        public static bool   globalDone          = false;  //记录完成状态
    }

    //全局方法
    public class GlobalMethod
    {
        static SerialPort serial_ = new SerialPort();  //声明串口

        //获取全部串口，并写入全局变量
        public static void GetPort()
        {
            string[] portName = SerialPort.GetPortNames();
            GlobalValue.globalPortName = portName;
        }

        //初始化串口
        public static void LoadPort()
        {
            serial_.Close();

            //如果未指定串口，则默认选择第一个串口
            if (GlobalValue.globalPortNameSet == null || GlobalValue.globalPortNameSet.Length == 0){
                GlobalValue.globalPortNameSet = GlobalValue.globalPortName.First();}

            serial_.PortName = GlobalValue.globalPortNameSet;
            serial_.Open();
            serial_.BaudRate = 9600;
            serial_.DataBits = 8;
            serial_.StopBits = StopBits.One;
            serial_.Parity   = Parity.None;
            serial_.ReadTimeout  = 100;
            serial_.WriteTimeout = -1;
            serial_.ReceivedBytesThreshold = 1;
            serial_.DataReceived += new SerialDataReceivedEventHandler(PortReceived);  //注册事件，如果串口收到消息，则调用PortReceived()方法
            serial_.Close();
        }

        //开启串口
        public static void OpenPort()
        {
            serial_.Close();
            serial_.Open();
            GlobalValue.globalIsPortOpening = true;  //更新状态
            if (GlobalValue.globalLanguage)
            {
                MessageBox.Show(serial_.PortName + " 已打开！");
            }
            else
            {
                MessageBox.Show(serial_.PortName + " opening!");
            }
            
        }

        //关闭串口
        public static void ClosePort()
        {
            serial_.Close();
            GlobalValue.globalIsPortOpening = false;  //更新状态
            if (GlobalValue.globalLanguage)
            {
                MessageBox.Show(serial_.PortName + " 已关闭！");
            }
            else
            {
                MessageBox.Show(serial_.PortName + " closed!");
            }
        }

        //串口发送
        public static void PortSend(string send)
        {
            serial_.Write(send);
        }

        //串口接收
        private static void PortReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial = (SerialPort)sender;
            string s = serial.ReadLine();

            //进行字符串处理
            if (s.Length != 0 && s != null)
            {
                string ss = s.Substring(0, 1);  //从第0位截取，截取1长度，等于截取首字母

                if (ss == "t")
                {
                    GlobalValue.globalTemperature = s.Substring(1);
                }
                else if (ss == "y")
                {
                    //checkP = true
                    GlobalValue.globalBartending = true;
                    PortSend(GlobalValue.globalCocktailCode);
                }
                else if (ss == "n")
                {
                    //checkP = false
                    if (GlobalValue.globalLanguage)
                    {
                        MessageBox.Show("请放置杯子后重试！");
                    }
                    else
                    {
                        MessageBox.Show("Please place the cup and try again!");
                    }
                }
                else if (ss == "d")
                {
                    //done
                    SoundPlayer soundPlayer = new SoundPlayer();  //播放音频
                    soundPlayer.SoundLocation = @"D:\vsProject\vsGUI\Resources\levelup.wav";
                    soundPlayer.Load();
                    soundPlayer.Play();

                    GlobalValue.globalBartending = false;  //更新状态
                    GlobalValue.globalDone = true;         //更新状态

                    if (GlobalValue.globalLanguage)
                    {
                        MessageBox.Show("完成！");
                    }
                    else
                    {
                        MessageBox.Show("Done!");
                    }
                }
            }
        }
    }
}
