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
        /// <summary>
        /// Name:  Mingchen Xu
        /// HW ID: H00365035
        /// 
        /// 姓名：许铭宸
        /// 学号：20012100080
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /// <summary>
            /// If I have created a new window class(MyForm.cs):
            ///     class MyForm : Form { }
            /// then i need(Program.cs):
            ///     MyForm form = new MyForm();
            ///     Application.Run(form);
            /// </summary>
            Application.Run(new FormMain());
        }
    }

    public static class GlobalValue
    {
        //Used to represent the current window ID.
        public static int globalFormNumber;

        public static bool ifCheckPort;
        public static bool ifCheckCommunication;
        public static bool ifCheckPress;

        public static string[] globalPortName;
        public static string globalPortNameSet;
        public static bool globalIsPortOpening;
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
            //SerialPort serial_ = new SerialPort();
            serial_.Close();
            if (GlobalValue.globalPortNameSet == null){
                GlobalValue.globalPortNameSet = GlobalValue.globalPortName.First();}
            serial_.PortName = GlobalValue.globalPortNameSet;
            serial_.Open();
            serial_.BaudRate = 115200;
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
            MessageBox.Show(serial_.PortName + " opening!");
        }

        public static void ClosePort()
        {
            serial_.Close();
            GlobalValue.globalIsPortOpening = false;
            MessageBox.Show(serial_.PortName + " closed!");
        }

        public static void PortSend(string send)
        {
            serial_.Write(send);
        }

        private static void PortReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial = (SerialPort)sender;
            string s = serial.ReadExisting();
            MessageBox.Show(s);

            

            //throw new NotImplementedException();
        }
    }
}
