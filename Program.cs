using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
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

    public static class GlobalValue
    {
        //Used to represent the current window ID.
        public static int globalFormNumber;

        // false = EN, true = CN
        public static bool globalLanguage = false;

        public static string[] globalPortName;
        public static string globalPortNameSet;
        public static bool globalIsPortOpening = false;

        public static string globalTemperature;
        public static string globalCocktailCode;
        public static bool globalBartending = false;
        public static bool globalDone = false;
    }

    //所有的自创方法都写这个类下就行
    public class GlobalMethod
    {
        static SerialPort serial_ = new SerialPort();

        //获取串口，并写入全局变量
        public static void GetPort()
        {
            string[] portName = SerialPort.GetPortNames();
            GlobalValue.globalPortName = portName;
        }

        public static void LoadPort()
        {
            serial_.Close();
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
            serial_.DataReceived += new SerialDataReceivedEventHandler(PortReceived);
            serial_.Close();
        }

        public static void OpenPort()
        {
            serial_.Close();
            serial_.Open();
            GlobalValue.globalIsPortOpening = true;
            if (GlobalValue.globalLanguage)
            {
                MessageBox.Show(serial_.PortName + " 已打开！");
            }
            else
            {
                MessageBox.Show(serial_.PortName + " opening!");
            }
            
        }

        public static void ClosePort()
        {
            serial_.Close();
            GlobalValue.globalIsPortOpening = false;
            if (GlobalValue.globalLanguage)
            {
                MessageBox.Show(serial_.PortName + " 已关闭！");
            }
            else
            {
                MessageBox.Show(serial_.PortName + " closed!");
            }
        }

        public static void PortSend(string send)
        {
            serial_.Write(send);
        }

        private static void PortReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial = (SerialPort)sender;
            //string s = serial.ReadExisting();
            string s = serial.ReadLine();

            if (s.Length != 0 && s != null)
            {
                string ss = s.Substring(0, 1);

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
                    GlobalValue.globalBartending = false;
                    if (GlobalValue.globalLanguage)
                    {
                        MessageBox.Show("完成！");
                    }
                    else
                    {
                        MessageBox.Show("Done!");
                    }
                    GlobalValue.globalDone = true;
                }
            }
        }
    }
}
