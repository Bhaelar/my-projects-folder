/*
 * Created by SharpDevelop.
 * User: Modupe Okenla
 * Date: 7/23/2019
 * Time: 7:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lll
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double FirstNumber;  
        string Operation;
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
		void N1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null)  
            {  
                textBox1.Text = "1";  
            }  
            else  
            {  
                textBox1.Text = textBox1.Text + "1";  
            } 
		}
		void N2Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "2";
			} else {
				textBox1.Text = textBox1.Text + "2";
			}
		}
		void N3Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "3";
			} else {
				textBox1.Text = textBox1.Text + "3";
			}
		}
		void N4Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "4";
			} else {
				textBox1.Text = textBox1.Text + "4";
			}
		}
		void N5Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "5";
			} else {
				textBox1.Text = textBox1.Text + "5";
			}
		}
		void N6Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "6";
			} else {
				textBox1.Text = textBox1.Text + "6";
			}
		}
		void N7Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "7";
			} else {
				textBox1.Text = textBox1.Text + "7";
			}
		}
		void N8Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "8";
			} else {
				textBox1.Text = textBox1.Text + "8";
			}
		}
		void N9Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" && textBox1.Text != null) {
				textBox1.Text = "9";
			} else {
				textBox1.Text = textBox1.Text + "9";
			}
		}
		void N0Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + "0";
		}
		void BadClick(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(textBox1.Text);
			textBox1.Text = "0";
			Operation = "+" ;
		}
		void BsubClick(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(textBox1.Text);
			textBox1.Text = "0";
			Operation = "-";
		}
		void BmultClick(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(textBox1.Text);
			textBox1.Text = "0";
			Operation = "*";
		}
		void BdivClick(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(textBox1.Text);
			textBox1.Text = "0";
			Operation = "/";
		}
		void BpClick(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + ".";
		}
		void BequalClick(object sender, EventArgs e)
		{
			double SecondNumber;  
            double Result;  
  
            SecondNumber = Convert.ToDouble(textBox1.Text);  
  
            if (Operation == "+")  
            {  
                Result = (FirstNumber + SecondNumber);  
                textBox1.Text = Convert.ToString(Result);  
                FirstNumber = Result;  
            }  
            if (Operation == "-")  
            {  
                Result = (FirstNumber - SecondNumber);  
                textBox1.Text = Convert.ToString(Result);  
                FirstNumber = Result;  
            }  
            if (Operation == "*")  
            {  
                Result = (FirstNumber * SecondNumber);  
                textBox1.Text = Convert.ToString(Result);  
                FirstNumber = Result;  
            }  
            if (Operation == "/")  
            {  
                if (SecondNumber == 0)  
                {  
                    textBox1.Text = "Cannot divide by zero";  
  
                }  
                else  
                {  
                    Result = (FirstNumber / SecondNumber);  
                    textBox1.Text = Convert.ToString(Result);  
                    FirstNumber = Result;  
                }  
            }  
        
		}
		
		
	}
}
