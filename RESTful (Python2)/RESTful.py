import RESTful_form
import wx
import sys
import requests
from requests.auth import HTTPBasicAuth

def quitclick(self):
	form1.Close()
	sys.exit(0)
	pass

def getclick(self):
	gurl = form1.text_ctrl_2.Value
	r = requests.get(gurl,auth=HTTPBasicAuth('root', '00000000'))
	print r.text
	form1.text_ctrl_1.Value = r.text
	pass
	
def postclick(self):
	purl = form1.text_ctrl_4.Value
	postval = form1.text_ctrl_5.Value
	r = requests.post(purl, data=postval,auth=HTTPBasicAuth('root', '00000000'))
	print r.text
	form1.text_ctrl_3.Value = r.text
	pass

app = wx.App()
form1 = RESTful_form.MyFrame(None)
form1.Bind(wx.EVT_BUTTON, getclick, form1.button_1)
form1.Bind(wx.EVT_BUTTON, quitclick, form1.button_2)
form1.Bind(wx.EVT_BUTTON, postclick, form1.button_3)
form1.Show()

app.MainLoop()