/*
 * Created by SharpDevelop.
 * User: XKID
 * Date: 8/4/2016
 * Time: 5:43 PM
 * 
 * Test Advantech WISE-4012E RESTful API
 * 
 * Required Component : RestSharp
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;

namespace RESTful
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			/* Using WebRequest Method */
			
			/*
			string username = user.Text;
			string password = pass.Text;
			string encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
			string html = string.Empty;
			
			var request = (HttpWebRequest)WebRequest.Create(getURL.Text);
			request.Headers.Add("Authorization", "Basic " + encoded);
			
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
			    html = reader.ReadToEnd();
			}
			GETResult.Text = html;
			*/
			
			/* Using RestSharp Method */
			string username = user.Text;
			string password = pass.Text;
			string html = string.Empty;
			
			var client = new RestClient();
			client.BaseUrl = new Uri(uri.Text);
			client.Authenticator = new HttpBasicAuthenticator(username, password);
			
			var request = new RestRequest();
			request.Resource = getURL.Text;
			
			IRestResponse response = client.Execute(request);
			html = response.Content;
			GETResult.Text = html;
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			/* https://lookonmyworks.co.uk/2011/08/22/making-a-post-request-in-c-with-basic-authentication/			
			string username = user.Text;
			string password = pass.Text;
			string encoded = System.Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
			string html = string.Empty;
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getURL.Text);
			request.Headers.Add("Authorization", "Basic " + encoded);
			
			// POST
			request.Method = "POST";
			var bytes = Encoding.UTF8.GetBytes(POST.Text);
			request.ContentLength = bytes.Length;
			request.ContentType = "application/x-www-form-urlencoded";
			using (var requestStream = request.GetRequestStream())
			{
			    requestStream.Write(bytes, 0, bytes.Length);
			}
			*/
			
			// http://stackoverflow.com/questions/6312970/restsharp-json-parameter-posting
			
			
			string username = user.Text;
			string password = pass.Text;
			string html = string.Empty;
			
			var client = new RestClient();
			client.BaseUrl = new Uri(uri.Text);
			client.Authenticator = new HttpBasicAuthenticator(username, password);
			
			var request = new RestRequest(Method.POST);
			request.Resource = postURL.Text;
			
			request.Method = Method.POST;
			request.AddHeader("Accept", "application/json");
			request.Parameters.Clear();
			request.AddParameter("application/json", POST.Text , ParameterType.RequestBody);
			
			client.Execute(request);

		}

		
		void Timer1Tick(object sender, EventArgs e)
		{
			string username = user.Text;
			string password = pass.Text;
			string html = string.Empty;
			
			// Output Channel 0
			var client1 = new RestClient();
			client1.BaseUrl = new Uri(uri.Text);
			client1.Authenticator = new HttpBasicAuthenticator(username, password);
			
			var request0 = new RestRequest();
			request0.Resource = "do_value/slot_0/ch_0";
			
			IRestResponse response0 = client1.Execute(request0);
			html = response0.Content;
			string[] s1a = html.Split(',');
			foreach (string v1a in s1a){
				string[] s2a = v1a.Split(':');
				if(s2a[0] == "\"Val\"")
				{
					if(s2a[1] == "1"){
						label1.BackColor = Color.Green;
					}else{
						label1.BackColor = Color.White;
					}
				}
			}
			
			// Output Channel 1
			var client2 = new RestClient();
			client2.BaseUrl = new Uri(uri.Text);
			client2.Authenticator = new HttpBasicAuthenticator(username, password);
			
			var request1 = new RestRequest();
			request1.Resource = "do_value/slot_0/ch_1";
			
			IRestResponse response1 = client2.Execute(request1);
			html = response1.Content;
			string[] s1b = html.Split(',');
			foreach (string v1b in s1b){
				string[] s2b = v1b.Split(':');
				if(s2b[0] == "\"Val\"")
				{
					if(s2b[1] == "1"){
						label2.BackColor = Color.Green;
					}else{
						label2.BackColor = Color.White;
					}
				}
			}
			
			// Input Channel 0
			var client3 = new RestClient();
			client3.BaseUrl = new Uri(uri.Text);
			client3.Authenticator = new HttpBasicAuthenticator(username, password);
			
			var request3 = new RestRequest();
			request3.Resource = "di_value/slot_0/ch_0";
			
			IRestResponse response3 = client3.Execute(request3);
			html = response3.Content;
			string[] s1c = html.Split(',');
			foreach (string v1c in s1c){
				string[] s2c = v1c.Split(':');
				if(s2c[0] == "\"Val\"")
				{
					if(s2c[1] == "1"){
						label3.BackColor = Color.Green;
					}else{
						label3.BackColor = Color.White;
					}
				}
			}
			
			// Input Channel 1
			var client4 = new RestClient();
			client4.BaseUrl = new Uri(uri.Text);
			client4.Authenticator = new HttpBasicAuthenticator(username, password);
			
			var request4 = new RestRequest();
			request4.Resource = "di_value/slot_0/ch_1";
			
			IRestResponse response4 = client4.Execute(request4);
			html = response4.Content;
			string[] s1d = html.Split(',');
			foreach (string v1d in s1d){
				string[] s2d = v1d.Split(':');
				if(s2d[0] == "\"Val\"")
				{
					if(s2d[1] == "1"){
						label4.BackColor = Color.Green;
					}else{
						label4.BackColor = Color.White;
					}
				}
			}
			
			
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			// ON
			POST.Text = "{\"Val\":1}";
			Button2Click(sender,e);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			// OFF
			POST.Text = "{\"Val\":0}";
			Button2Click(sender,e);
		}
		
		
		void Button5Click(object sender, EventArgs e)
		{
			if (button5.Text == "Connect"){
				timer1.Enabled = true;
				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = true;
				button4.Enabled = true;
				button5.Text = "Disconnect";
			}else{
				timer1.Enabled = false;
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				button5.Text = "Connect";
			}			
		}
	}
}
