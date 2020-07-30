/// <summary>
/// 
/// </summary>
/// <remarks></remarks>

using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpDemo
{
	internal partial class DemoForm : System.Windows.Forms.Form
	{


		private bool ExitEvent;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="newScrollValue"></param>
		/// <remarks></remarks>
		private short Timer_Refresh_Tick_led_zustand;

		private void AchsScroll_Change(int newScrollValue)
		{
			AchsParameter.Text = System.Convert.ToString(3 - newScrollValue);
		}

	#region  Achsebewegung

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void Rmove_Click(object eventSender, System.EventArgs eventArgs)
		{
			XemoDLL.MB_Rmove(System.Convert.ToInt16(AchsParameter.Text), System.Convert.ToInt32(RmoveParameter.Text));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void Amove_Click(object eventSender, System.EventArgs eventArgs)
		{
            XemoDLL.MB_Amove(System.Convert.ToInt16(AchsParameter.Text), System.Convert.ToInt32(AmoveParameter.Text));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void Jog_Click(object eventSender, System.EventArgs eventArgs)
		{
            XemoDLL.MB_Jog(System.Convert.ToInt16(AchsParameter.Text), System.Convert.ToInt32(JogParameter.Text));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void StopAchseKlick(object eventSender, System.EventArgs eventArgs)
		{
            XemoDLL.MB_Stop(-1);
		}

	#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void DemoForm_Load(object eventSender, System.EventArgs eventArgs)
		{
			Show();
			CSharpDemo.BAUDRATE = System.Convert.ToInt32(Microsoft.VisualBasic.Interaction.GetSetting("XemoDemo", "Comport", "Baudrate", System.Convert.ToString(19200)));
            CSharpDemo.COMNR = System.Convert.ToInt16(Microsoft.VisualBasic.Interaction.GetSetting("XemoDemo", "Comport", "ComNr", System.Convert.ToString(1)));
            if (CSharpDemo.COMNR == 0)
			{
				Text = "CSharp XemoDLL Demo" + " (USB)";
			}
			else
			{
                Text = "CSharp XemoDLL Demo" + " (COM " + System.Convert.ToString(CSharpDemo.COMNR).ToString() + ", Baud " + System.Convert.ToString(CSharpDemo.BAUDRATE).ToString() + ")";
			}

			if (CSharpDemo.Ini_Xemo() == false)
			{
				this.Close();
				return;
			}
            _Position_0.Text = "37300";
            _Position_1.Text = "77400";
            _Position_2.Text = "0";
            ExitEvent = false;
			Timer_Refresh.Interval = 100;
			Timer_Refresh.Enabled = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void DemoForm_FormClosed(object eventSender, System.Windows.Forms.FormClosedEventArgs eventArgs)
		{
			Microsoft.VisualBasic.Interaction.SaveSetting("XemoDemo", "Comport", "Baudrate", CSharpDemo.BAUDRATE.ToString());
			Microsoft.VisualBasic.Interaction.SaveSetting("XemoDemo", "Comport", "ComNr", CSharpDemo.COMNR.ToString());
            XemoDLL.ML_DeIniCom();
			ExitEvent = true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		public void MnuSchlieﬂen_Click(object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		public void MnuSchnittstelle_Click(object eventSender, System.EventArgs eventArgs)
		{
            FormSchnittstelle m_Schnittstelle = new FormSchnittstelle();
            m_Schnittstelle.Text = "CSharp XemoDLL Demo" + " (COM " + CSharpDemo.COMNR.ToString() + ", Baud " + CSharpDemo.BAUDRATE.ToString() + ")";
            m_Schnittstelle.ShowDialog();           
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void Test_Click(object eventSender, System.EventArgs eventArgs)
		{
            XemoDLL.MB_Cpos(1, 1);
            XemoDLL.MB_Print("Textausgabe");
            XemoDLL.MB_Printxy(1, 2, "Xemo DLL Demo");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void Timer_Refresh_Tick(object eventSender, System.EventArgs eventArgs)
		{
            XemoDLL.MB_GetState();
            if (XemoDLL.ML_GetErrState() == XemoKonst.ERR_CANCEL)
            {
				this.Close();
				return;
			}
			// Alle Positionen einlesen
			short x = 0;
			for (x = 0; x <= 3; x++)
			{
				System.Windows.Forms.Application.DoEvents();
				if (ExitEvent)
				{
					return;
				}
                Position[x].Text = System.Convert.ToString(XemoDLL.MB_AGet(x, XemoKonst.m_RPos));
			}
			if (Timer_Refresh_Tick_led_zustand == 0)
			{
				Timer_Refresh_Tick_led_zustand = 1;
			}
			else
			{
				Timer_Refresh_Tick_led_zustand = 0;
			}
            XemoDLL.MB_KeyLed(XemoKonst.m_Key_F1, Timer_Refresh_Tick_led_zustand);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void AchsScroll_Scroll(object eventSender, System.Windows.Forms.ScrollEventArgs eventArgs)
		{
			switch (eventArgs.Type)
			{
				case System.Windows.Forms.ScrollEventType.EndScroll:
					AchsScroll_Change(eventArgs.NewValue);
					break;
			}
		}

	}
} //end of root namespace