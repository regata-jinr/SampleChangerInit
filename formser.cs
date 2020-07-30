/// <summary>
/// 
/// </summary>
/// <remarks></remarks>
//INSTANT C# NOTE: Formerly VB.NET project-level imports:
using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpDemo
{
	internal partial class FormSchnittstelle : System.Windows.Forms.Form
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void cboComPort_TextChanged(object eventSender, System.EventArgs eventArgs)
		{

			if (cboComPort.Text == "USB")
			{
				cboBaudrate.Enabled = false;
			}
			else
			{
				cboBaudrate.Enabled = true;
			}

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void cboComPort_SelectedIndexChanged(object eventSender, System.EventArgs eventArgs)
		{
			cboComPort_TextChanged(cboComPort, new System.EventArgs());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void CmdAbbruch_Click(object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void CmdOk_Click(object eventSender, System.EventArgs eventArgs)
		{
			short i = 0;
			bool InList = false;
			InList = false;
			for (i = 0; i <= cboBaudrate.Items.Count; i++)
			{
				if (cboBaudrate.Text == Support.GetItemString(cboBaudrate, i))
				{
					InList = true;
				}
			}
			if (InList == false)
			{
				MessageBox.Show("Ungültige Baudrate", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}
			InList = false;
			for (i = 0; i <= cboComPort.Items.Count; i++)
			{
				if (cboComPort.Text == Support.GetItemString(cboComPort, i))
				{
					InList = true;
				}

				if ("COM" + cboComPort.Text == Support.GetItemString(cboComPort, i))
				{
					cboComPort.SelectedIndex = i;
					cboComPort.Text = Support.GetItemString(cboComPort, i);
					InList = true;
				}
			}
			if (InList == false)
			{
				MessageBox.Show("Ungültiger Comport", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}
            CSharpDemo.BAUDRATE = System.Convert.ToInt32(cboBaudrate.Text);
            CSharpDemo.COMNR = System.Convert.ToInt16(cboComPort.SelectedIndex);
            XemoDLL.ML_DeIniCom();
            XemoDLL.ML_IniCom(CSharpDemo.COMNR, CSharpDemo.BAUDRATE);
			this.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="eventSender"></param>
		/// <param name="eventArgs"></param>
		/// <remarks></remarks>
		private void FormSchnittstelle_Load(object eventSender, System.EventArgs eventArgs)
		{
            cboBaudrate.Text = CSharpDemo.BAUDRATE.ToString();
            cboComPort.SelectedIndex = CSharpDemo.COMNR;
			cboComPort_TextChanged(cboComPort, new System.EventArgs());
		}

	}
} //end of root namespace