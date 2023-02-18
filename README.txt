------------------------------------------
|                                        |
| The Intelligent Cocktail-making System |
|                                        |
|                README                  |
|                                        |
------------------------------------------

* The content of this public warehouse is only for course acceptance demonstration!
* Any form of copying is prohibited except for learning purposes!
*
* 本公开仓库内容仅供课程验收演示！
* 除学习目的，禁止任何形式的复制！
*
* System design - 系统设计 - B39VS




----------
Basic Info
基本信息

  HW -   H00365035   - Mingchen Xu
  XD -  20012100080  - 许铭宸

  Project started at - 2023.02.06
  Txt last edited at - 2023.02.18  //TODO

  IDE                - Microsoft Visual Studio Community 2022 (Version 17.4.4)
  Project dependency - .NET Framework 4.8

  Official Website   - 
  Browse in Github   - https://github.com/Suntend/vsGUI
  Contact Author     - https://space.bilibili.com/340532672




------------------------------------------
Introduction of highlights and precautions
亮点介绍与注意事项

  + Adaptive page layout.
    自适应布局。

  + Multi-threading technology.(Cancel)
    多线程技术。（取消）

  + Multi-language switching.(EN/CN)
    多语言切换。（中文/英文）

  + Use Git for project collaboration and version control.
    使用Git进行项目协同与版本控制。

  + Use rigorous and proven state machine logic to minimize state chaos.
    使用严谨的且经过验证的状态机逻辑，最大程度防止状态混乱。

  +++ "Project-oriented" development, not "Curriculum-oriented" development.
      "面向 项目 开发"，而不是 "面向 课设 开发"。

  ! If there are only two serial ports and the receiver occupied a serial port, the program may be down.
    如果仅有两个串口，且接收端已经占用了其中一个串口，程序可能会出错。




---------------------
Cocktails composition
鸡尾酒成份
  
  1 - Tequila
  2 - Rum
  3 - Vodka
  4 - Lemon Juice
  5 - Pineapple Juice
  6 - Blue Curacao

  Tequila Sunrise      - 144252 - 1 40ml, 4 20ml, 5 20ml.
  Blue Hawaii          - 245262 - 2 40ml, 5 20ml, 6 20ml.
  Long Island Iced Tea - 133342 - 1 30ml, 3 30ml, 4 20ml.

  Max 80ml




------------
Global Value
全局变量

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
      | 8 - Bartending / Finish *

  GlobalValue.globalLanguage (bool)
    Used to represent the current language.
      | false - EN  English  英文
      | true  - CN  Chinese  中文




--------------------
Serial communication
串口通信
  
  (GUI)
  Send "checkP"
  (Arduino)
  LED Green off
  LED Red off
  Check Press
    If true,  Send "y"
    If false, Send "n"

  (GUI)
  Send "144252"
  (Arduino)
  LED Red on
  Move...
  Move back to position 0
  Send "d"
  LED Red off
  LED Green on

  (Arduino)
  Send ("t" + (string)temperature(xxx.x))




---
Log
日志

  2023.02.06  UI - Main window.(Deleted)
              页面设计：主页面。（废案）

  2023.02.07  UI - Main / Classic.C1.C2.C3. / BF Form are finished.
              页面设计：完成了以上六个页面。

  2023.02.08  Serial communication: Send test, successful.
              串口通信：完成发送测试。

  2023.02.09  Serial communication: Receive test, successful.
              串口通信：完成接收测试。

  2023.02.13  First meet class.
              Serial communication: Complete the serial port status judgment and detection.
              第一次见面课。
              串口通信：完成串口状态判断与检测。

  2023.02.14  Serial communication: Improve the serial port loading mechanism.
              串口通信：完善串口加载机制。

  2023.02.15  Multi-language switch.
              中英文切换。

  2023.02.16  Multi-language switch.
              中英文切换。

  2023.02.17  Refactor the page layout and code logic of the Settings Form.
              Serial communication: Improve communication with Arduino.
              重构设置页的页面布局与业务逻辑。
              串口通信：完善与Arduino通信业务。

  2023.02.18  Two major businesses: the first part of "Classic Cocktails" and "Design your own".
              Completed all business logic and verified all serial communication processes.
              两大部分业务：“经典鸡尾酒”和“DIY鸡尾酒”的第一部分。
              完成了全部业务逻辑，验证了全部串口通信流程。




----
Note
笔记