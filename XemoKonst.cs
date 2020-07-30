
using System;

/// <summary>
/// Konstanten Definitionen
/// </summary>
/// <remarks></remarks>
internal static class XemoKonst
{
    public const long BAUDRATE = 19200;
    
    // Bits im Systemstatus 
    // ------------------------------- 
    public const int STATE_F0 = 0x1;
    public const int STATE_F1 = 0x2;
    public const int STATE_F2 = 0x4;
    public const int STATE_ERR = 0x8;
    public const int STATE_MS = 0x10;
    public const int STATE_OR0 = 0x20;
    public const int STATE_RUN = 0x40;

    public const int PSTATE_PSTATE = 0x7;
    public const int PSTATE_ERROR = 0x8;
    public const int PSTATE_ONERROR = 0x10;
    public const int PSTATE_DEBUG = 0x40;

    public const int STATE_FIFO = 0x3;
    public const int STATE_FIFO_EMPTY = 0;
    public const int STATE_FIFO_LOW = 1;
    public const int STATE_FIFO_HIGH = 2;
    public const int STATE_FIFO_FULL = 3;

    // Syscontrol Kommandos 
    public const int m_Reset = 1;     // System Reset 
    public const int m_Break = 2;     // MotionBasic Programm unterbrechen 
    public const int m_Halt = 3;      // MotionBasic Programm anhalten 

    public const int m_PrgQuit = 100;         // MotionBasic Programm benden 
    public const int m_DebugShell = 101;      // Zur Debug-Shell wechseln 
    public const int m_OnlineShell = 102;     // Zur Online-Shell wechseln 

    // SetFifo FifoStatus 
    // ------------------------------- 
    public const int m_FfDisable = 1;
    public const int m_FfEnable = 2;
    public const int m_FfClear = 3;

    // Tastatur-Codes 
    public const int m_Key_F1 = 0x13b;
    public const int m_Key_F2 = 0x13c;
    public const int m_Key_F3 = 0x13d;
    public const int m_Key_F4 = 0x13e;
    public const int m_Key_Bs = 0x8;
    public const int m_Key_Enter = 0xd;
    public const int m_Key_Up = 0x148;
    public const int m_Key_Down = 0x150;
    public const int m_Key_Right = 0x14d;
    public const int m_Key_Left = 0x14b;

    // KeyLed-Codes 
    // ------------------------------- 
    public const int m_LedOff = 0;
    public const int m_LedOn = 1;
    public const int m_LedBlink = 10;
    public const int m_LedFlash = 11;

    // Die Achsbezeichner 
    // ------------------------------- 
    public const int m_X = 0;
    public const int m_Y = 1;
    public const int m_Z = 2;
    public const int m_A = 3;
    public const int m_XALL = 255; // Alle Achsen / Achsparameter 
    public const int m_ALL = 254;  // Alle Achs- und Bahnparameter 

    // Seriell IO 
    public const int m_COM1 = 1;
    public const int m_BD9600 = 5;
    public const int m_BD19200 = 6;
    public const int m_BD28800 = 7;
    public const int m_BD38400 = 8;
    public const int m_BD57600 = 9;

    // USB 
    public const int USB_OFF = 0;
    public const int USB_AUTO = 1;
    public const int USB_ONLY = 2;

    // Diverse 
    public const int m_Off = 0;

    // Systemparameter 
    public const int BOT_SPARM_NO = 1000;

    public const int m_State = 1000;
    public const int m_Version = 1004;
    public const int m_Release = 1005;
    public const int m_ComRelease = 1006;
    public const int m_Extent = 1007;
    public const int m_Clock = 1008;

    public const int m_ErrNo = 1010;
    public const int m_ErrState = 1011;
    public const int m_ErrLine = 1012;
    public const int m_ErrAxis = 1013;
    public const int m_ErrParam = 1014;
    public const int m_SubError = 1015;

    public const int m_FifoSize = 1021;
    public const int m_FifoLevel = 1022;
    public const int m_FifoLeft = 1023;
    public const int m_FifoMarker = 1024;

    public const int m_Mode1 = 1030;
    public const int m_CanMode = 1034;
    public const int m_OtSelect = 1035;
    public const int m_Can2Mode = 1036;
    public const int m_Can1Device = 1038;
    public const int m_Can2Device = 1039;

    public const int m_IpGroup = 1040;

    public const int m_BkPwmCycle = 1050;
    public const int m_BkPwmDuty = 1051;

    public const int m_AnlIn = 1060;
    public const int m_AnlOut = 1061;

    public const int m_OvrIn = 1062;
    public const int m_JoyX = 1063;
    public const int m_JoyY = 1064;

    public const int m_HandWheel = 1070;
    public const int m_Encoder = 1071;
    public const int m_EncIdx = 1072;
    public const int m_EncIpr = 1073;

    public const int m_Ovride = 1075;
    public const int m_Omode = 1076;
    public const int m_OvScale = 1077;

    public const int m_SAnlIn0 = 1080;
    public const int m_SAnlIn1 = 1081;
    public const int m_SAnlIn2 = 1082;

    public const int m_VoMode = 1090;
    public const int m_VoScale = 1091;
    public const int m_VoOffs = 1092;
    public const int m_VoMin = 1093;
    public const int m_VoMax = 1094;

    public const int m_AnlFSel = 1100;
    public const int m_AFType = 1101;
    public const int m_AFSTime = 1102;
    public const int m_AFSpread = 1103;
    public const int m_AFHyster = 1104;
    public const int m_AFTrack = 1105;
    public const int m_AFAverage = 1106;

    // ab 1200 sind zunächst nicht dokumetierte 
    // Systemparameter zur Geräteüberwachung 
    public const int TOP_SPARM_NO = 1250;     // Grösste Systemparameter-Nummer 

    // Setup-Parameter 
    // Die Setup-Parameter sind besonders schreibgeschützt 
    // und können nur beschrieben werden, wenn der Hexschalter auf 0x0e steht 
    public const int BOT_SUPARM_NO = 1400;
    public const int m_ComPort = 1400;      // RS232 Programmier-Schnittstelle auswählen 
    public const int m_Bdrate = 1401;       // Baudrate der RS232 Schnittstelle festlegen 
    public const int m_DsplContr = 1402;    // Xemo Display Kontrast 
    public const int m_PonComDelay = 1403;  // Power On ComPort Delay 
    public const int m_USBConfig = 1404;    // USB Schnittstelle konfigurieren 
    public const int TOP_SUPARM_NO = 1404;

    // Achsparameter 
    public const int BOT_XPARM_NO = 2000;

    public const int m_Speed = 2000;
    public const int m_Accel = 2001;
    public const int m_Decel = 2002;
    public const int m_Vmin = 2003;
    public const int m_LDecel = 2004;
    public const int m_MaxVel = 2008;
    public const int m_MaxAcc = 2009;
    public const int m_IpLink = 2010;
    public const int m_IpAxis = 2011;

    public const int m_NodeId = 2012;

    public const int m_H1Speed = 2020;
    public const int m_H2Speed = 2021;
    public const int m_H3Speed = 2022;
    public const int m_HOffset = 2023;
    public const int m_HVerify = 2024;
    public const int m_HMethod = 2025;

    public const int m_OpMode = 2030;
    public const int m_Current = 2031;
    public const int m_FErrWin = 2032;
    public const int m_TPosWin = 2033;
    public const int m_TPosTime = 2034;
    public const int m_BrakeOutp = 2035;
    public const int m_BrkDelay1 = 2036;
    public const int m_BrkDelay2 = 2037;

    public const int m_Uscale = 2040;
    public const int m_Iscale = 2041;

    public const int m_Zero = 2042;
    public const int m_Origin = 2043;
    public const int m_Refp = 2044;
    public const int m_SlLimit = 2045;
    public const int m_SrLimit = 2046;
    public const int m_Pmode = 2047;
    public const int m_BLash = 2048;

    public const int m_Micro = 2050;
    public const int m_MPhi = 2051;
    public const int m_StopCurr = 2052;

    public const int m_APos = 2061;
    public const int m_RPos = 2062;
    public const int m_RVelo = 2063;
    public const int m_XEncoder = 2064;

    public const int m_XOvr = 2075;
    public const int m_XOmode = 2076;

    public const int m_EgState = 2090;
    public const int m_EgMode = 2092;
    public const int m_EgSource = 2093;
    public const int m_EgMult = 2094;

    public const int TOP_XPARM_NO = 2094;

    // Bahnparameter 
    public const int BOT_IPARM_NO = 3000;

    public const int m_IpSpeed = 3000;
    public const int m_IpAccel = 3001;
    public const int m_IpDecel = 3002;
    public const int m_IpVmin = 3003;
    public const int m_IpLDecel = 3004;
    public const int m_IpVend = 3005;
    public const int m_IpFeed = 3006;
    public const int m_IpMaxVel = 3008;
    public const int m_IpMaxAcc = 3009;
    public const int m_IpDim = 3010;
    public const int m_IpUnit = 3011;

    public const int m_IpLaFact = 3013;
    public const int m_IpLaCvFact = 3014;
    public const int m_IpLaTprof = 3015;

    public const int m_IpVelo = 3063;

    public const int m_IpOvr = 3075;
    public const int m_IpOmode = 3076;

    public const int TOP_IPARM_NO = 3076;

    // EA-Parameter 
    public const int BOT_IOPARM_NO = 4000;
    public const int m_InPolarity = 4000;
    public const int m_OutPolarity = 4001;
    public const int TOP_IOPARM_NO = 4003;

    //  Xemo_DLL Koordinaten-Bezeichner
    // ---------------------------------
    public const int C_X = 0x1;
    public const int C_Y = 0x2;
    public const int C_XY = 0x3;
    public const int C_Z = 0x4;
    public const int C_XZ = 0x5;
    public const int C_YZ = 0x6;
    public const int C_XYZ = 0x7;
    public const int C_A = 0x8;
    public const int C_XA = 0x9;
    public const int C_YA = 0xA;
    public const int C_XYA = 0xB;
    public const int C_ZA = 0xC;
    public const int C_XZA = 0xD;
    public const int C_YZA = 0xE;
    public const int C_XYZA = 0xF;
    
    // Xemo_DLL Error-Codes 
    // ------------------------------- 
    public const int ERR_XEMO = 1;
    public const int ERR_COM_PORT = 2;
    public const int ERR_RCV_OVERFLOW = 3;
    public const int ERR_RCV_TIMEOUT = 4;
    public const int ERR_FIFO_TIMEOUT = 5;
    public const int ERR_GETSTATE = 6;
    public const int ERR_RCV_CMD = 7;
    public const int ERR_TRM_TIMEOUT = 8;
    public const int ERR_CHECKSUM = 9;

    // Xemo_DLL Error-Status 
    // ------------------------------- 
    public const int ERR_LEFT = -1;
    public const int NO_ERR = 0;
    public const int ERR_XEMO_PENDING = 1;
    public const int ERR_COM_PENDING = 2;
    public const int ERR_RETRY = 3;
    public const int ERR_CANCEL = 4;
    public const int ERR_COM_DEINI = 5; 

}
