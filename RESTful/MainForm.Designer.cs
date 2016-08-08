/*
 * Created by SharpDevelop.
 * User: win8
 * Date: 8/4/2016
 * Time: 5:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RESTful
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.GETResult = new System.Windows.Forms.TextBox();
			this.getURL = new System.Windows.Forms.TextBox();
			this.postURL = new System.Windows.Forms.TextBox();
			this.POSTResult = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.POST = new System.Windows.Forms.TextBox();
			this.user = new System.Windows.Forms.TextBox();
			this.pass = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.uri = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(316, 188);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "GET";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// GETResult
			// 
			this.GETResult.Location = new System.Drawing.Point(25, 42);
			this.GETResult.Margin = new System.Windows.Forms.Padding(2);
			this.GETResult.Multiline = true;
			this.GETResult.Name = "GETResult";
			this.GETResult.Size = new System.Drawing.Size(395, 115);
			this.GETResult.TabIndex = 1;
			this.GETResult.Text = "http://192.168.8.7/do_value/slot_0/ch_0\r\nhttp://192.168.8.7/di_value/slot_0/ch_0";
			// 
			// getURL
			// 
			this.getURL.Location = new System.Drawing.Point(25, 162);
			this.getURL.Margin = new System.Windows.Forms.Padding(2);
			this.getURL.Name = "getURL";
			this.getURL.Size = new System.Drawing.Size(395, 20);
			this.getURL.TabIndex = 2;
			this.getURL.Text = "do_value/slot_0/ch_0";
			// 
			// postURL
			// 
			this.postURL.Location = new System.Drawing.Point(26, 356);
			this.postURL.Margin = new System.Windows.Forms.Padding(2);
			this.postURL.Name = "postURL";
			this.postURL.Size = new System.Drawing.Size(394, 20);
			this.postURL.TabIndex = 5;
			this.postURL.Text = "do_value/slot_0/ch_0";
			// 
			// POSTResult
			// 
			this.POSTResult.Location = new System.Drawing.Point(26, 236);
			this.POSTResult.Margin = new System.Windows.Forms.Padding(2);
			this.POSTResult.Multiline = true;
			this.POSTResult.Name = "POSTResult";
			this.POSTResult.Size = new System.Drawing.Size(395, 115);
			this.POSTResult.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(316, 427);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 33);
			this.button2.TabIndex = 3;
			this.button2.Text = "POST";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// POST
			// 
			this.POST.Location = new System.Drawing.Point(26, 379);
			this.POST.Margin = new System.Windows.Forms.Padding(2);
			this.POST.Multiline = true;
			this.POST.Name = "POST";
			this.POST.Size = new System.Drawing.Size(279, 83);
			this.POST.TabIndex = 6;
			this.POST.Text = "{\"Val\":0}";
			// 
			// user
			// 
			this.user.Location = new System.Drawing.Point(25, 10);
			this.user.Margin = new System.Windows.Forms.Padding(2);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(58, 20);
			this.user.TabIndex = 7;
			this.user.Text = "root";
			// 
			// pass
			// 
			this.pass.Location = new System.Drawing.Point(87, 10);
			this.pass.Margin = new System.Windows.Forms.Padding(2);
			this.pass.Name = "pass";
			this.pass.Size = new System.Drawing.Size(96, 20);
			this.pass.TabIndex = 8;
			this.pass.Text = "00000000";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(224, 188);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 33);
			this.label1.TabIndex = 9;
			this.label1.Text = "OUT1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(269, 188);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 33);
			this.label2.TabIndex = 10;
			this.label2.Text = "OUT2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// uri
			// 
			this.uri.Location = new System.Drawing.Point(187, 10);
			this.uri.Margin = new System.Windows.Forms.Padding(2);
			this.uri.Name = "uri";
			this.uri.Size = new System.Drawing.Size(150, 20);
			this.uri.TabIndex = 11;
			this.uri.Text = "http://192.168.8.7/";
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(316, 396);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(44, 26);
			this.button3.TabIndex = 12;
			this.button3.Text = "ON";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(376, 396);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(44, 26);
			this.button4.TabIndex = 13;
			this.button4.Text = "OFF";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(25, 188);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 33);
			this.label3.TabIndex = 15;
			this.label3.Text = "IN1";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(70, 188);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 33);
			this.label4.TabIndex = 14;
			this.label4.Text = "IN2";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(342, 10);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(79, 21);
			this.button5.TabIndex = 16;
			this.button5.Text = "Connect";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 474);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.uri);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.user);
			this.Controls.Add(this.POST);
			this.Controls.Add(this.postURL);
			this.Controls.Add(this.POSTResult);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.getURL);
			this.Controls.Add(this.GETResult);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "RESTful";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox uri;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox pass;
		private System.Windows.Forms.TextBox user;
		private System.Windows.Forms.TextBox POST;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox POSTResult;
		private System.Windows.Forms.TextBox postURL;
		private System.Windows.Forms.TextBox getURL;
		private System.Windows.Forms.TextBox GETResult;
		private System.Windows.Forms.Button button1;
	}
}
