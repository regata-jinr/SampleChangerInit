using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpDemo
{
    internal static class CSharpDemo
    {
        public static int BAUDRATE;
        public static short COMNR;

        public static bool Ini_Xemo()
        {
            bool tempIni_Xemo = false;
            //ini

            XemoDLL.ML_IniUsb(0, "107374");
            //XemoDLL.ML_IniUsb(0, "114005");

            // xXemoDLL.ML_ComSelect(3);
            XemoDLL.MB_SysControl(2);
            XemoDLL.MB_SysControl(1);
            XemoDLL.MB_GetState();

            // machine
            XemoDLL.MB_Waitinp(12, 1, 1, 1);
            XemoDLL.MB_GetState();

            //test

            var XemoType = (long)XemoDLL.MB_Get(1004);
            var XemoExtent = (long)XemoDLL.MB_Get(1007);

            int[] nums = { 1,0,2 }; //, 2, 1 };

            //for (var num = 0; num < 2; ++num)
            foreach (var num in nums)
            {
                //MessageBox.Show($"3009:   {(long)XemoDLL.MB_Get(3009)}");
                //MessageBox.Show($"3001:   {(long)XemoDLL.MB_Get(3001)}");
                MessageBox.Show(num.ToString());
                XemoDLL.MB_ASet((short)num, 2031, (int)MOTOR_CURRENT[num]);
                XemoDLL.MB_ASet((short)num, 2052, (int)MOTOR_STOP_CURRENT[num]);
                XemoDLL.MB_ASet((short)num, 2050, (int)MICROSTEP_DEFINER[num]);

                XemoDLL.MB_ASet((short)num, 2000, 100);
                XemoDLL.MB_ASet((short)num, 2001, 100);
                XemoDLL.MB_ASet((short)num, 2002, 100);

                XemoDLL.MB_ASet((short)num, 2041, (int)Math.Round((double)INC_PER_REVOLUTION[num] / (double)MICROSTEP_DEFINER[num]));

                XemoDLL.MB_ASet((short)num, 2040, (int)Math.Round((double)(unchecked(MM_PER_REVOLUTION[num] * 100f))));


                XemoDLL.MB_ASet((short)num, 2000, (int)(MAX_VELOCITY[num] * 100L));
                XemoDLL.MB_ASet((short)num, 2001, (int)((long)Math.Round((double)(unchecked(ACCELERATION_FACTOR[num] * (float)(checked(MAX_VELOCITY[num] * 100L)))))));
                XemoDLL.MB_ASet((short)num, 2002, (int)((long)Math.Round((double)(unchecked(DECELERATION_FACTOR[num] * (float)(checked(MAX_VELOCITY[num] * 100L)))))));

             

                XemoDLL.MB_ASet((short)num, 2003, (int)Math.Round((double)(START_STOP_FREQUENCY[num] * 100L) / 10.0));

                XemoDLL.MB_ASet((short)num, 2020, (int)(REF_VELOCITY_H1[num] * 100L));

                XemoDLL.MB_ASet((short)num, 2021, (int)(REF_VELOCITY_H2[num] * 100L));
                XemoDLL.MB_ASet((short)num, 2022, (int)(REF_VELOCITY_H3[num] * 100L));
                XemoDLL.MB_ASet((short)num, 2023, (int)((long)Math.Round((double)(unchecked(ZERO_REF_OFFSET[num] * 100f)))));
                XemoDLL.MB_ASet((short)num, 2045, 0);
                XemoDLL.MB_ASet((short)num, 2046, (int)(TRAVEL_AXIS[num] * 100L));
                XemoDLL.MB_IoSet((short)num, 0, 3, 4000, (short)POLARITY_SWITCHES[num]);
                XemoDLL.MB_ASet((short)num, 2048, (int)((long)Math.Round((double)(unchecked(BLASH[num] * 100f)))));
                bool flag = XTYPE[num] != 0L;
                if (flag)
                {
                    XemoDLL.MB_ASet((short)num, 2013, (int)XTYPE[num]);
                }
                flag = (GANTRY_ACHSE[num] != 0L);
                if (flag)
                {
                    XemoDLL.MB_ASet((short)num, 2049, (int)GANTRY_ACHSE[num]);
                }
                flag = (JERKMS[num] != 0L);
                if (flag)
                {
                    XemoDLL.MB_ASet((short)num, 2007, (int)JERKMS[num]);
                }
                flag = (INC_MONITORING_ENCODER[num] != 0L);
                if (flag)
                {
                    XemoDLL.MB_ASet((short)num, 2056, (int)INC_MONITORING_ENCODER[num]);
                    XemoDLL.MB_ASet((short)num, 2032, (int)POSITION_ERROR[num]);
                }
                flag = (XemoType != 448L);
                if (flag)
                {
                    XemoDLL.MB_ASet((short)num, 2004, (int)((long)Math.Round((double)(unchecked((float)(checked(MAX_VELOCITY[num] * 100L)) * EMERGCY_DECEL_FACTOR[num])))));
                }
                flag = (BRAKE[num] >= 0);
                if (flag)
                {
                    int num2 = BRAKE[num];
                    XemoDLL.MB_ASet((short)num, 2035, 10 + 4096 * num2 + 256);
                }
            }
            // XemoDLL.ML_DeIniCom();

            //   XemoDLL.MB_Waitinp(12, 1, 1, 1);
            // XemoDLL.ML_IniCom(3, BAUDRATE);
            short ErrState = 0;
            do
            {
                XemoDLL.MB_GetState();
                ErrState = XemoDLL.ML_GetErrState();
                if (ErrState == XemoKonst.NO_ERR)
                {
                    tempIni_Xemo = true;
                    goto ExitLabel1;

                }
                else if (ErrState == XemoKonst.ERR_CANCEL)
                {
                    return false;
                }
                else
                {
                    if (MessageBox.Show("Serielle Schnittstelle neu konfigurieren?", "XemoDLL Demo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        FormSchnittstelle m_Schnittstelle = new FormSchnittstelle();
                        m_Schnittstelle.ShowDialog();
                    }
                    else
                    {
                        return false;
                    }
                }
            } while (true);

        ExitLabel1:
            return tempIni_Xemo;

        }

        #region Params

        private static  long[] MaxSpeed = new long[3];
			private static  long[] MAX_VELOCITY = new long[]
			{
				100L,
				100L,
				120L,
				400L,
				400L
			};

            private static  long[] TRAVEL_AXIS = new long[]
            {
                400L,
                800L,
                0L,
                100L,
                100L
            };

            private static  long[] MICROSTEP_DEFINER = new long[]
            {
                1L,
                1L,
                1L,
                1L,
                1L
            };

            private static  long[] INC_PER_REVOLUTION = new long[]
            {
                10000L,
                10000L,
                10000L,
                10000L,
                10000L
            };

            private static float[] MM_PER_REVOLUTION = new float[]
            {
                8f,
                8f,
                14.4f,
                130f,
                130f
            };

            private static  long[] INC_MONITORING_ENCODER = new long[]
            {
                2000L,
                -2000L,
                2000L,
                0L,
                130L
            };

            private static  long[] MOTOR_CURRENT = new long[]
            {
                60L,
                50L,
                50L,
                100L,
                100L
            };

            private static  long[] MOTOR_STOP_CURRENT = new long[]
            {
                70L,
                70L,
                70L,
                70L,
                70L
            };

            private static float[] ZERO_REF_OFFSET = new float[]
            {
                0f,
                0f,
                0f,
                0f,
                0f
            };

            private static float[] NULL_OFFSET = new float[]
            {
                -373f,
                -774f,
                0f,
                0f,
                0f
            };

            private static  long[] REF_ORDER = new long[]
            {
                1L,
                2L,
                3L,
                4L,
                5L
            };

            private static  long[] REF_PORT = new long[]
            {
                -1L,
                -1L,
                -1L,
                -1L,
                -1L
            };

            private static  long[] REF_SWITCH = new long[]
            {
                -1L,
                -1L,
                -1L,
                -1L,
                -1L
            };

            private static  long[] POLARITY_SWITCHES = new long[]
            {
                3L,
                3L,
                0L,
                3L,
                3L
            };

            private static  long[] REF_VELOCITY_H1 = new long[]
            {
                50L,
                50L,
                50L,
                100L,
                100L
            };

            private static  long[] REF_VELOCITY_H2 = new long[]
            {
                -1L,
                -1L,
                -1L,
                -30L,
                -30L
            };

            private static  long[] REF_VELOCITY_H3 = new long[]
            {
                100L,
                100L,
                100L,
                200L,
                200L
            };

            private static float[] ACCELERATION_FACTOR = new float[]
            {
                10f,
                10f,
                1f,
                10f,
                10f
            };

            private static float[] DECELERATION_FACTOR = new float[]
            {
                10f,
                10f,
                1f,
                10f,
                10f
            };

            private static  long[] START_STOP_FREQUENCY = new long[]
            {
                0L,
                0L,
                0L,
                2L,
                2L
            };

            private static float[] EMERGCY_DECEL_FACTOR = new float[]
            {
                10f,
                10f,
                10f,
                10f,
                10f
            };

            private static float[] BLASH = new float[]
            {
                0f,
                0f,
                0f,
                0f,
                0f
            };

            private static  long[] NODE_ID = new long[]
            {
                1L,
                2L,
                3L,
                4L,
                5L
            };

            private static  long[] POSITION_ERROR = new long[]
            {
                200L,
                200L,
                200L,
                10000L,
                10000L
            };

            private static  long[] POSITION_WINDOW = new long[]
            {
                100L,
                100L,
                100L,
                100L,
                100L
            };

            private static  long[] POSITION_TIME = new long[]
            {
                0L,
                0L,
                0L,
                0L,
                0L
            };

            private static  long[] HOME_METHOD = new long[]
            {
                19L,
                19L,
                19L,
                19L,
                19L
            };

            private static  long[] ENCODER_NACHBILDUNG = new long[]
            {
                -1L,
                -1L,
                -1L,
                -1L,
                -1L
            };

            private static  long[] ENCODER_RESOLUTION = new long[]
            {
                2000L,
                2000L,
                2000L,
                0L,
                0L
            };

            private static  long[] MAX_ENCODER_FEHLER = new long[]
            {
                200L,
                200L,
                200L,
                0L,
                0L
            };

            private static int[] BRAKE = new int[]
            {
                -1,
                -1,
                -1,
                -1,
                -1
            };

            private static int[] INIT_PNOZ_OUT = new int[]
            {
                -1,
                -1,
                -1,
                -1,
                -1
            };

            private static int[] P_FAKTOR_GESCHW = new int[]
            {
                0,
                0,
                0,
                0,
                -1
            };

            private static int[] P_FAKTOR_POSMODUS = new int[]
            {
                0,
                0,
                0,
                0,
                0
            };

            private static int[] KOMMUTIERUNGS_METHODE = new int[]
            {
                3,
                3,
                3,
                3,
                3
            };

            private static  long[] GANTRY_ACHSE = new long[]
            {
                0L,
                0L,
                0L,
                0L,
                0L
            };

            private static  long[] XTYPE = new long[]
            {
                0L,
                0L,
                0L,
                0L,
                0L
            };

            private static  long[] JERKMS = new long[]
            {
                0L,
                0L,
                0L,
                0L,
                0L
            };
        #endregion
    }
}