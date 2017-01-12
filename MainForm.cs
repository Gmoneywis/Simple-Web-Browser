/*
 * Created by SharpDevelop.
 * User: GB10237
 * Date: 1/5/2017
 * Time: 8:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Web_Browser
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
		
		
		// If you go to file and then exit it closes the application
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
	
		void ProgressBar1Click(object sender, EventArgs e)
		{
	
		}
		
		// When you click the search button it does navigate
		void Button1Click(object sender, EventArgs e)
		{
			Navigate();
		}
		
		//This puts whatever is in the text box on the web browser object and disables the search box and button
		private void Navigate()
		{
			button1.Enabled = false;
			textBox1.Enabled = false;
		webBrowser1.Navigate(textBox1.Text);
		}
		
		//This makes it so you can navigate with the enter button
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
	        
			if(e. KeyChar == (Char)ConsoleKey.Enter)
			{
			
			
				Navigate();
			
			}
			
		}
		
	    // This makes it so when you are done navigating it restores the button and textbox
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			button1.Enabled = true;
		    textBox1.Enabled = true;
		}
		void Button2Click(object sender, EventArgs e)
		{
			Navigate();
		}
		
	}
}
