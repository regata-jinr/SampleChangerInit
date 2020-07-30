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
	internal partial class DemoForm
	{
	#region Vom Windows Form-Designer generierter Code 
		[System.Diagnostics.DebuggerNonUserCode()]
		public DemoForm() : base()
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
		public System.Windows.Forms.Timer Timer_Refresh;
		public System.Windows.Forms.TextBox JogParameter;
		public System.Windows.Forms.Button Jog;
		public System.Windows.Forms.Button StopAchse;
		public System.Windows.Forms.VScrollBar AchsScroll;
		public System.Windows.Forms.TextBox AchsParameter;
		public System.Windows.Forms.TextBox AmoveParameter;
		public System.Windows.Forms.TextBox RmoveParameter;
		public System.Windows.Forms.Button Amove;
		public System.Windows.Forms.Button Rmove;
		public System.Windows.Forms.Button Test;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label _Position_3;
		public System.Windows.Forms.Label _Position_2;
		public System.Windows.Forms.Label _Position_1;
		public System.Windows.Forms.Label _Label2_3;
		public System.Windows.Forms.Label _Label2_2;
		public System.Windows.Forms.Label _Label2_1;
		public System.Windows.Forms.Label _Label2_0;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label _Position_0;
		public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Label2;
		public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Position;
		public System.Windows.Forms.ToolStripMenuItem MnuSchließen;
		public System.Windows.Forms.ToolStripMenuItem MnuDatei;
		public System.Windows.Forms.ToolStripMenuItem MnuSchnittstelle;
		public System.Windows.Forms.ToolStripMenuItem MnuOptionen;
		public System.Windows.Forms.MenuStrip MainMenu1;
		//Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
		//Das Verändern mit dem Windows Form-Designer ist nicht möglich.
		//Das Bearbeiten mit dem Code-Editor ist nicht möglich.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.JogParameter = new System.Windows.Forms.TextBox();
            this.Jog = new System.Windows.Forms.Button();
            this.StopAchse = new System.Windows.Forms.Button();
            this.AchsScroll = new System.Windows.Forms.VScrollBar();
            this.AchsParameter = new System.Windows.Forms.TextBox();
            this.AmoveParameter = new System.Windows.Forms.TextBox();
            this.RmoveParameter = new System.Windows.Forms.TextBox();
            this.Amove = new System.Windows.Forms.Button();
            this.Rmove = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this._Position_3 = new System.Windows.Forms.Label();
            this._Position_2 = new System.Windows.Forms.Label();
            this._Position_1 = new System.Windows.Forms.Label();
            this._Label2_3 = new System.Windows.Forms.Label();
            this._Label2_2 = new System.Windows.Forms.Label();
            this._Label2_1 = new System.Windows.Forms.Label();
            this._Label2_0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this._Position_0 = new System.Windows.Forms.Label();
            this.Label2 = new Microsoft.VisualBasic.Compatibility.VB6.LabelArray(this.components);
            this.Position = new Microsoft.VisualBasic.Compatibility.VB6.LabelArray(this.components);
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.MnuDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSchließen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOptionen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSchnittstelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position)).BeginInit();
            this.MainMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer_Refresh
            // 
            this.Timer_Refresh.Tick += new System.EventHandler(this.Timer_Refresh_Tick);
            // 
            // JogParameter
            // 
            this.JogParameter.AcceptsReturn = true;
            this.JogParameter.BackColor = System.Drawing.SystemColors.Window;
            this.JogParameter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JogParameter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.JogParameter.Location = new System.Drawing.Point(116, 117);
            this.JogParameter.MaxLength = 0;
            this.JogParameter.Name = "JogParameter";
            this.JogParameter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.JogParameter.Size = new System.Drawing.Size(73, 20);
            this.JogParameter.TabIndex = 19;
            this.JogParameter.Text = "0";
            // 
            // Jog
            // 
            this.Jog.BackColor = System.Drawing.SystemColors.Control;
            this.Jog.Cursor = System.Windows.Forms.Cursors.Default;
            this.Jog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Jog.Location = new System.Drawing.Point(28, 117);
            this.Jog.Name = "Jog";
            this.Jog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Jog.Size = new System.Drawing.Size(81, 22);
            this.Jog.TabIndex = 18;
            this.Jog.Text = "Jog";
            this.Jog.UseVisualStyleBackColor = false;
            this.Jog.Click += new System.EventHandler(this.Jog_Click);
            // 
            // StopAchse
            // 
            this.StopAchse.BackColor = System.Drawing.SystemColors.Control;
            this.StopAchse.Cursor = System.Windows.Forms.Cursors.Default;
            this.StopAchse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StopAchse.Location = new System.Drawing.Point(28, 141);
            this.StopAchse.Name = "StopAchse";
            this.StopAchse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StopAchse.Size = new System.Drawing.Size(81, 22);
            this.StopAchse.TabIndex = 17;
            this.StopAchse.Text = "Stop";
            this.StopAchse.UseVisualStyleBackColor = false;
            this.StopAchse.Click += new System.EventHandler(this.StopAchseKlick);
            // 
            // AchsScroll
            // 
            this.AchsScroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.AchsScroll.LargeChange = 1;
            this.AchsScroll.Location = new System.Drawing.Point(164, 35);
            this.AchsScroll.Maximum = 3;
            this.AchsScroll.Name = "AchsScroll";
            this.AchsScroll.Size = new System.Drawing.Size(17, 25);
            this.AchsScroll.TabIndex = 15;
            this.AchsScroll.TabStop = true;
            this.AchsScroll.Value = 3;
            this.AchsScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.AchsScroll_Scroll);
            // 
            // AchsParameter
            // 
            this.AchsParameter.AcceptsReturn = true;
            this.AchsParameter.BackColor = System.Drawing.SystemColors.Window;
            this.AchsParameter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AchsParameter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AchsParameter.Location = new System.Drawing.Point(128, 39);
            this.AchsParameter.MaxLength = 10;
            this.AchsParameter.Name = "AchsParameter";
            this.AchsParameter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AchsParameter.Size = new System.Drawing.Size(33, 20);
            this.AchsParameter.TabIndex = 14;
            this.AchsParameter.Text = "0";
            // 
            // AmoveParameter
            // 
            this.AmoveParameter.AcceptsReturn = true;
            this.AmoveParameter.BackColor = System.Drawing.SystemColors.Window;
            this.AmoveParameter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmoveParameter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AmoveParameter.Location = new System.Drawing.Point(116, 93);
            this.AmoveParameter.MaxLength = 10;
            this.AmoveParameter.Name = "AmoveParameter";
            this.AmoveParameter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmoveParameter.Size = new System.Drawing.Size(73, 20);
            this.AmoveParameter.TabIndex = 13;
            this.AmoveParameter.Text = "0";
            // 
            // RmoveParameter
            // 
            this.RmoveParameter.AcceptsReturn = true;
            this.RmoveParameter.BackColor = System.Drawing.SystemColors.Window;
            this.RmoveParameter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RmoveParameter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RmoveParameter.Location = new System.Drawing.Point(116, 69);
            this.RmoveParameter.MaxLength = 10;
            this.RmoveParameter.Name = "RmoveParameter";
            this.RmoveParameter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RmoveParameter.Size = new System.Drawing.Size(73, 20);
            this.RmoveParameter.TabIndex = 3;
            this.RmoveParameter.Text = "0";
            // 
            // Amove
            // 
            this.Amove.BackColor = System.Drawing.SystemColors.Control;
            this.Amove.Cursor = System.Windows.Forms.Cursors.Default;
            this.Amove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Amove.Location = new System.Drawing.Point(28, 93);
            this.Amove.Name = "Amove";
            this.Amove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Amove.Size = new System.Drawing.Size(81, 22);
            this.Amove.TabIndex = 2;
            this.Amove.Text = "Amove";
            this.Amove.UseVisualStyleBackColor = false;
            this.Amove.Click += new System.EventHandler(this.Amove_Click);
            // 
            // Rmove
            // 
            this.Rmove.BackColor = System.Drawing.SystemColors.Control;
            this.Rmove.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rmove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rmove.Location = new System.Drawing.Point(28, 69);
            this.Rmove.Name = "Rmove";
            this.Rmove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rmove.Size = new System.Drawing.Size(81, 22);
            this.Rmove.TabIndex = 1;
            this.Rmove.Text = "Rmove";
            this.Rmove.UseVisualStyleBackColor = false;
            this.Rmove.Click += new System.EventHandler(this.Rmove_Click);
            // 
            // Test
            // 
            this.Test.BackColor = System.Drawing.SystemColors.Control;
            this.Test.Cursor = System.Windows.Forms.Cursors.Default;
            this.Test.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Test.Location = new System.Drawing.Point(288, 162);
            this.Test.Name = "Test";
            this.Test.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Test.Size = new System.Drawing.Size(81, 22);
            this.Test.TabIndex = 0;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(76, 40);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(50, 17);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Achse";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _Position_3
            // 
            this._Position_3.BackColor = System.Drawing.SystemColors.Control;
            this._Position_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._Position_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._Position_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Position.SetIndex(this._Position_3, ((short)(3)));
            this._Position_3.Location = new System.Drawing.Point(288, 130);
            this._Position_3.Name = "_Position_3";
            this._Position_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Position_3.Size = new System.Drawing.Size(73, 17);
            this._Position_3.TabIndex = 12;
            this._Position_3.Text = "0";
            // 
            // _Position_2
            // 
            this._Position_2.BackColor = System.Drawing.SystemColors.Control;
            this._Position_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._Position_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._Position_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Position.SetIndex(this._Position_2, ((short)(2)));
            this._Position_2.Location = new System.Drawing.Point(288, 106);
            this._Position_2.Name = "_Position_2";
            this._Position_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Position_2.Size = new System.Drawing.Size(73, 17);
            this._Position_2.TabIndex = 11;
            this._Position_2.Text = "0";
            // 
            // _Position_1
            // 
            this._Position_1.BackColor = System.Drawing.SystemColors.Control;
            this._Position_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._Position_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Position_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Position.SetIndex(this._Position_1, ((short)(1)));
            this._Position_1.Location = new System.Drawing.Point(288, 82);
            this._Position_1.Name = "_Position_1";
            this._Position_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Position_1.Size = new System.Drawing.Size(73, 17);
            this._Position_1.TabIndex = 10;
            this._Position_1.Text = "0";
            // 
            // _Label2_3
            // 
            this._Label2_3.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_3.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.SetIndex(this._Label2_3, ((short)(3)));
            this._Label2_3.Location = new System.Drawing.Point(264, 130);
            this._Label2_3.Name = "_Label2_3";
            this._Label2_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_3.Size = new System.Drawing.Size(25, 17);
            this._Label2_3.TabIndex = 9;
            this._Label2_3.Text = "M3";
            // 
            // _Label2_2
            // 
            this._Label2_2.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_2.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.SetIndex(this._Label2_2, ((short)(2)));
            this._Label2_2.Location = new System.Drawing.Point(264, 106);
            this._Label2_2.Name = "_Label2_2";
            this._Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_2.Size = new System.Drawing.Size(25, 17);
            this._Label2_2.TabIndex = 8;
            this._Label2_2.Text = "M2";
            // 
            // _Label2_1
            // 
            this._Label2_1.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_1.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.SetIndex(this._Label2_1, ((short)(1)));
            this._Label2_1.Location = new System.Drawing.Point(264, 82);
            this._Label2_1.Name = "_Label2_1";
            this._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_1.Size = new System.Drawing.Size(25, 17);
            this._Label2_1.TabIndex = 7;
            this._Label2_1.Text = "M1";
            // 
            // _Label2_0
            // 
            this._Label2_0.BackColor = System.Drawing.SystemColors.Control;
            this._Label2_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.SetIndex(this._Label2_0, ((short)(0)));
            this._Label2_0.Location = new System.Drawing.Point(264, 58);
            this._Label2_0.Name = "_Label2_0";
            this._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Label2_0.Size = new System.Drawing.Size(25, 17);
            this._Label2_0.TabIndex = 6;
            this._Label2_0.Text = "M0";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(289, 38);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(71, 17);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Positionen";
            // 
            // _Position_0
            // 
            this._Position_0.BackColor = System.Drawing.SystemColors.Control;
            this._Position_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._Position_0.Cursor = System.Windows.Forms.Cursors.Default;
            this._Position_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Position.SetIndex(this._Position_0, ((short)(0)));
            this._Position_0.Location = new System.Drawing.Point(288, 58);
            this._Position_0.Name = "_Position_0";
            this._Position_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._Position_0.Size = new System.Drawing.Size(73, 17);
            this._Position_0.TabIndex = 4;
            this._Position_0.Text = "0";
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDatei,
            this.MnuOptionen});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(405, 24);
            this.MainMenu1.TabIndex = 20;
            // 
            // MnuDatei
            // 
            this.MnuDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSchließen});
            this.MnuDatei.Name = "MnuDatei";
            this.MnuDatei.Size = new System.Drawing.Size(44, 20);
            this.MnuDatei.Text = "&Datei";
            // 
            // MnuSchließen
            // 
            this.MnuSchließen.Name = "MnuSchließen";
            this.MnuSchließen.Size = new System.Drawing.Size(130, 22);
            this.MnuSchließen.Text = "&Schließen";
            this.MnuSchließen.Click += new System.EventHandler(this.MnuSchließen_Click);
            // 
            // MnuOptionen
            // 
            this.MnuOptionen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSchnittstelle});
            this.MnuOptionen.Name = "MnuOptionen";
            this.MnuOptionen.Size = new System.Drawing.Size(63, 20);
            this.MnuOptionen.Text = "&Optionen";
            // 
            // MnuSchnittstelle
            // 
            this.MnuSchnittstelle.Name = "MnuSchnittstelle";
            this.MnuSchnittstelle.Size = new System.Drawing.Size(143, 22);
            this.MnuSchnittstelle.Text = "&Schnittstelle";
            this.MnuSchnittstelle.Click += new System.EventHandler(this.MnuSchnittstelle_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(405, 200);
            this.Controls.Add(this.JogParameter);
            this.Controls.Add(this.Jog);
            this.Controls.Add(this.StopAchse);
            this.Controls.Add(this.AchsScroll);
            this.Controls.Add(this.AchsParameter);
            this.Controls.Add(this.AmoveParameter);
            this.Controls.Add(this.RmoveParameter);
            this.Controls.Add(this.Amove);
            this.Controls.Add(this.Rmove);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this._Position_3);
            this.Controls.Add(this._Position_2);
            this.Controls.Add(this._Position_1);
            this.Controls.Add(this._Label2_3);
            this.Controls.Add(this._Label2_2);
            this.Controls.Add(this._Label2_1);
            this.Controls.Add(this._Label2_0);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._Position_0);
            this.Controls.Add(this.MainMenu1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(10, 42);
            this.MaximizeBox = false;
            this.Name = "DemoForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CSharp XemoDLL Demo";
            this.Load += new System.EventHandler(this.DemoForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DemoForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position)).EndInit();
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	#endregion

		[STAThread]
		static void Main()
		{
			Application.Run(new DemoForm());
		}

	}
} //end of root namespace