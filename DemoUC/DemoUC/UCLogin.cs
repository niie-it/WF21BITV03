using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUC
{
	public partial class UCLogin : UserControl
	{
		public string UserName
		{
			get { return TxtUsername.Text; }
			set { TxtUsername.Text = value; }
		}
		public string Password
		{
			get { return TxtPassword.Text; }
			set { TxtPassword.Text = value; }
		}
		public UCLogin()
		{
			InitializeComponent();
		}
	}
}
