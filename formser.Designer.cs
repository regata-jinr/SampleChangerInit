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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	internal partial class FormSchnittstelle
	{
	#region Vom Windows Form-Designer generierter Code 
		[System.Diagnostics.DebuggerNonUserCode()]
		public FormSchnittstelle() : base()
		{
			//Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();
		}
		//Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
		//Wird vom Windows Form-Designer benötigt.
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.ComboBox cboComPort;
		public System.Windows.Forms.ComboBox cboBaudrate;
		public System.Windows.Forms.Button CmdAbbruch;
		public System.Windows.Forms.Button CmdOk;
		public System.Windows.Forms.Label lbComPort;
		public System.Windows.Forms.Label lbBaudrate;
		//Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
		//Das Verändern mit dem Windows Form-Designer ist nicht möglich.
		//Das Bearbeiten mit dem Code-Editor ist nicht möglich.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormSchnittstelle));
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(components);
			this.cboComPort = new System.Windows.Forms.ComboBox();
			this.cboBaudrate = new System.Windows.Forms.ComboBox();
			this.CmdAbbruch = new System.Windows.Forms.Button();
			this.CmdOk = new System.Windows.Forms.Button();
			this.lbComPort = new System.Windows.Forms.Label();
			this.lbBaudrate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.ToolTip1.Active = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Text = "Serielle Schnittstelle";
			this.ClientSize = new System.Drawing.Size(339, 107);
			this.Location = new System.Drawing.Point(3, 22);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ControlBox = true;
			this.Enabled = true;
			this.KeyPreview = false;
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.HelpButton = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Name = "FormSchnittstelle";
			this.cboComPort.Size = new System.Drawing.Size(89, 20);
			this.cboComPort.Location = new System.Drawing.Point(96, 48);
			this.cboComPort.Items.AddRange(new object[]{"USB", "COM1", "COM2", "COM3", "COM4"});
			this.cboComPort.TabIndex = 3;
			this.cboComPort.BackColor = System.Drawing.SystemColors.Window;
			this.cboComPort.CausesValidation = true;
			this.cboComPort.Enabled = true;
			this.cboComPort.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cboComPort.IntegralHeight = true;
			this.cboComPort.Cursor = System.Windows.Forms.Cursors.Default;
			this.cboComPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cboComPort.Sorted = false;
			this.cboComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.cboComPort.TabStop = true;
			this.cboComPort.Visible = true;
			this.cboComPort.Name = "cboComPort";
			this.cboBaudrate.Size = new System.Drawing.Size(89, 20);
			this.cboBaudrate.Location = new System.Drawing.Point(96, 20);
			this.cboBaudrate.Items.AddRange(new object[]{"9600", "19200", "28800", "57600"});
			this.cboBaudrate.TabIndex = 2;
			this.cboBaudrate.BackColor = System.Drawing.SystemColors.Window;
			this.cboBaudrate.CausesValidation = true;
			this.cboBaudrate.Enabled = true;
			this.cboBaudrate.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cboBaudrate.IntegralHeight = true;
			this.cboBaudrate.Cursor = System.Windows.Forms.Cursors.Default;
			this.cboBaudrate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cboBaudrate.Sorted = false;
			this.cboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.cboBaudrate.TabStop = true;
			this.cboBaudrate.Visible = true;
			this.cboBaudrate.Name = "cboBaudrate";
			this.CmdAbbruch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CmdAbbruch.Text = "Abbruch";
			this.CmdAbbruch.Size = new System.Drawing.Size(89, 21);
			this.CmdAbbruch.Location = new System.Drawing.Point(216, 48);
			this.CmdAbbruch.TabIndex = 1;
			this.CmdAbbruch.BackColor = System.Drawing.SystemColors.Control;
			this.CmdAbbruch.CausesValidation = true;
			this.CmdAbbruch.Enabled = true;
			this.CmdAbbruch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdAbbruch.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdAbbruch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdAbbruch.TabStop = true;
			this.CmdAbbruch.Name = "CmdAbbruch";
			this.CmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CmdOk.Text = "OK";
			this.CmdOk.Size = new System.Drawing.Size(89, 21);
			this.CmdOk.Location = new System.Drawing.Point(216, 20);
			this.CmdOk.TabIndex = 0;
			this.CmdOk.BackColor = System.Drawing.SystemColors.Control;
			this.CmdOk.CausesValidation = true;
			this.CmdOk.Enabled = true;
			this.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdOk.TabStop = true;
			this.CmdOk.Name = "CmdOk";
			this.lbComPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lbComPort.Text = "Port ";
			this.lbComPort.Size = new System.Drawing.Size(53, 13);
			this.lbComPort.Location = new System.Drawing.Point(32, 52);
			this.lbComPort.TabIndex = 5;
			this.lbComPort.BackColor = System.Drawing.SystemColors.Control;
			this.lbComPort.Enabled = true;
			this.lbComPort.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbComPort.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbComPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbComPort.UseMnemonic = true;
			this.lbComPort.Visible = true;
			this.lbComPort.AutoSize = false;
			this.lbComPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbComPort.Name = "lbComPort";
			this.lbBaudrate.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lbBaudrate.Text = "Baudrate ";
			this.lbBaudrate.Size = new System.Drawing.Size(53, 13);
			this.lbBaudrate.Location = new System.Drawing.Point(32, 24);
			this.lbBaudrate.TabIndex = 4;
			this.lbBaudrate.BackColor = System.Drawing.SystemColors.Control;
			this.lbBaudrate.Enabled = true;
			this.lbBaudrate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbBaudrate.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbBaudrate.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbBaudrate.UseMnemonic = true;
			this.lbBaudrate.Visible = true;
			this.lbBaudrate.AutoSize = false;
			this.lbBaudrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbBaudrate.Name = "lbBaudrate";
			this.Controls.Add(cboComPort);
			this.Controls.Add(cboBaudrate);
			this.Controls.Add(CmdAbbruch);
			this.Controls.Add(CmdOk);
			this.Controls.Add(lbComPort);
			this.Controls.Add(lbBaudrate);
			this.ResumeLayout(false);
			this.PerformLayout();
			//INSTANT C# NOTE: Converted event handler wireups:
			base.Load += new System.EventHandler(FormSchnittstelle_Load);
			CmdOk.Click += new System.EventHandler(CmdOk_Click);
			CmdAbbruch.Click += new System.EventHandler(CmdAbbruch_Click);
			cboComPort.SelectedIndexChanged += new System.EventHandler(cboComPort_SelectedIndexChanged);
			cboComPort.TextChanged += new System.EventHandler(cboComPort_TextChanged);

		}
	#endregion
	}
} //end of root namespace