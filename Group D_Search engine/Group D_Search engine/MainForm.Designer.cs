/*
 * Created by SharpDevelop.
 * User: Modupe Okenla
 * Date: 10/2/2019
 * Time: 7:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Group_D_Search_engine
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.TextBox search;
		private System.Windows.Forms.Button button1;
		
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
			this.Title = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(27, 12);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(372, 29);
			this.Title.TabIndex = 0;
			this.Title.Text = "Welcome to our search engine";
			this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Title.Click += new System.EventHandler(this.Label1Click);
			// 
			// search
			// 
			this.search.Location = new System.Drawing.Point(27, 62);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(303, 20);
			this.search.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Highlight;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(343, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 20);
			this.button1.TabIndex = 2;
			this.button1.Text = "Go";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 272);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.search);
			this.Controls.Add(this.Title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Text = "Go";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
