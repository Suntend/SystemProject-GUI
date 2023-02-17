------------------------------------------
|                                        |
| The Intelligent Cocktail-making System |
|                                        |
|                README                  |
|                                        |
------------------------------------------



Basic Info

  HW -   H00365035   - Mingchen Xu
  XD -  20012100080  - 许铭宸

  Project started at - 2023.02.06
  Txt last edited at - 2023.02.14  //TODO

  IDE                - Microsoft Visual Studio Community 2022 (Version 17.4.4)
  Project dependency - .NET Framework 4.8

  Official Website   - 
  Browse in Github   - https://github.com/Suntend/vsGUI
  Contact Author     - https://space.bilibili.com/340532672



Introduction of highlights and precautions

  +1 Adaptive page layout.
     自适应页面布局。

  +2 Use Git for project collaboration and version control.
     使用Git进行项目协同与版本控制。

  +3 Multilingual switching.(EN/CN)
     多语言切换。（中文/英文）

  -1 If there are only two serial ports and the receiver occupied a serial port, the program may be down.
     如果仅有两个串口，且接收端已经占用了其中一个串口，程序会出错。



Cocktails
  
  1 - Tequila
  2 - Rum
  3 - Vodka
  4 - Lemon Juice
  5 - Pineapple Juice
  6 - Blue Curacao

  Tequila Sunrise      - 14 42 52
  Blue Hawaii          - 24 52 62
  Long Island Iced Tea - 13 33 42

  Max 80ml



Global Value

  GlobalValue.globalFormNumber (int)
    Used to represent the current window ID.
      | 0 - Home Page           - W E L C O M E
      | 1 - Classic             - Classic cocktails
      | | 4 - Classic.1.info    - Tequila Sunrise
      | | 5 - Classic.2.info    - Blue Hawaii
      | | 6 - Classic.3.info    - Long Island Iced Tea
      | 2 - Design              - Design your own
      | | 7 - Design list       - Check your design
      | 3 - Settings            - Settings
      | 8 - Bartending / Finish -

  GlobalValue.globalLanguage (bool)
    Used to represent the current language.
      | false - EN  English  英文
      | true  - CN  Chinese  中文



Serial communication




Log

  2023.02.06  UI - Main window.(Deleted)
              页面设计：主页面。（废案）

  2023.02.07  UI - Main / Classic.C1.C2.C3. / BF Form are finished.
              页面设计：完成了以上六个页面。

  2023.02.08  Serial communication - Send test, successful.
              串口通信：完成发送测试。

  2023.02.09  Serial communication - Receive test, successful.
              串口通信：完成接收测试。

  2023.02.13  First meet class.
              Serial communication - Complete the serial port status judgment and detection.
              第一次见面课。
              串口通信：完成串口状态判断与检测。

  2023.02.14  Serial communication - Improve the serial port loading mechanism.
              串口通信：完善串口加载机制。

  2023.02.15  Multi-language switch.
              中英文切换。

  2023.02.16  Multi-language switch.
              中英文切换。

  2023.02.17  Refactor the page layout and code logic of the Settings Form.
              重构设置页的页面布局与业务逻辑。