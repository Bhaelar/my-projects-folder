﻿/*
 * Created by SharpDevelop.
 * User: Modupe Okenla
 * Date: 7/23/2019
 * Time: 7:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace lll
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button n1;
		private System.Windows.Forms.Button n2;
		private System.Windows.Forms.Button n3;
		private System.Windows.Forms.Button n4;
		private System.Windows.Forms.Button n5;
		private System.Windows.Forms.Button n6;
		private System.Windows.Forms.Button n7;
		private System.Windows.Forms.Button n8;
		private System.Windows.Forms.Button n9;
		private System.Windows.Forms.Button n0;
		private System.Windows.Forms.Button bmult;
		private System.Windows.Forms.Button bsub;
		private System.Windows.Forms.Button bad;
		private System.Windows.Forms.Button bc;
		private System.Windows.Forms.Button bp;
		private System.Windows.Forms.Button bdiv;
		private System.Windows.Forms.Button bequal;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.n1 = new System.Windows.Forms.Button();
			this.n2 = new System.Windows.Forms.Button();
			this.n3 = new System.Windows.Forms.Button();
			this.n4 = new System.Windows.Forms.Button();
			this.n5 = new System.Windows.Forms.Button();
			this.n6 = new System.Windows.Forms.Button();
			this.n7 = new System.Windows.Forms.Button();
			this.n8 = new System.Windows.Forms.Button();
			this.n9 = new System.Windows.Forms.Button();
			this.n0 = new System.Windows.Forms.Button();
			this.bmult = new System.Windows.Forms.Button();
			this.bsub = new System.Windows.Forms.Button();
			this.bad = new System.Windows.Forms.Button();
			this.bc = new System.Windows.Forms.Button();
			this.bp = new System.Windows.Forms.Button();
			this.bdiv = new System.Windows.Forms.Button();
			this.bequal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(1, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(285, 38);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// n1
			// 
			this.n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n1.Location = new System.Drawing.Point(1, 66);
			this.n1.Name = "n1";
			this.n1.Size = new System.Drawing.Size(65, 31);
			this.n1.TabIndex = 1;
			this.n1.Text = "1";
			this.n1.UseVisualStyleBackColor = false;
			this.n1.Click += new System.EventHandler(this.N1Click);
			// 
			// n2
			// 
			this.n2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n2.Location = new System.Drawing.Point(72, 65);
			this.n2.Name = "n2";
			this.n2.Size = new System.Drawing.Size(65, 31);
			this.n2.TabIndex = 2;
			this.n2.Text = "2";
			this.n2.UseVisualStyleBackColor = false;
			this.n2.Click += new System.EventHandler(this.N2Click);
			// 
			// n3
			// 
			this.n3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n3.Location = new System.Drawing.Point(143, 66);
			this.n3.Name = "n3";
			this.n3.Size = new System.Drawing.Size(65, 31);
			this.n3.TabIndex = 3;
			this.n3.Text = "3";
			this.n3.UseVisualStyleBackColor = false;
			this.n3.Click += new System.EventHandler(this.N3Click);
			// 
			// n4
			// 
			this.n4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n4.Location = new System.Drawing.Point(1, 103);
			this.n4.Name = "n4";
			this.n4.Size = new System.Drawing.Size(65, 31);
			this.n4.TabIndex = 4;
			this.n4.Text = "4";
			this.n4.UseVisualStyleBackColor = false;
			this.n4.Click += new System.EventHandler(this.N4Click);
			// 
			// n5
			// 
			this.n5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n5.Location = new System.Drawing.Point(72, 102);
			this.n5.Name = "n5";
			this.n5.Size = new System.Drawing.Size(65, 31);
			this.n5.TabIndex = 5;
			this.n5.Text = "5";
			this.n5.UseVisualStyleBackColor = false;
			this.n5.Click += new System.EventHandler(this.N5Click);
			// 
			// n6
			// 
			this.n6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n6.Location = new System.Drawing.Point(143, 103);
			this.n6.Name = "n6";
			this.n6.Size = new System.Drawing.Size(65, 31);
			this.n6.TabIndex = 6;
			this.n6.Text = "6";
			this.n6.UseVisualStyleBackColor = false;
			this.n6.Click += new System.EventHandler(this.N6Click);
			// 
			// n7
			// 
			this.n7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n7.Location = new System.Drawing.Point(1, 140);
			this.n7.Name = "n7";
			this.n7.Size = new System.Drawing.Size(65, 31);
			this.n7.TabIndex = 7;
			this.n7.Text = "7";
			this.n7.UseVisualStyleBackColor = false;
			this.n7.Click += new System.EventHandler(this.N7Click);
			// 
			// n8
			// 
			this.n8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n8.Location = new System.Drawing.Point(72, 140);
			this.n8.Name = "n8";
			this.n8.Size = new System.Drawing.Size(65, 31);
			this.n8.TabIndex = 8;
			this.n8.Text = "8";
			this.n8.UseVisualStyleBackColor = false;
			this.n8.Click += new System.EventHandler(this.N8Click);
			// 
			// n9
			// 
			this.n9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n9.Location = new System.Drawing.Point(143, 140);
			this.n9.Name = "n9";
			this.n9.Size = new System.Drawing.Size(65, 31);
			this.n9.TabIndex = 9;
			this.n9.Text = "9";
			this.n9.UseVisualStyleBackColor = false;
			this.n9.Click += new System.EventHandler(this.N9Click);
			// 
			// n0
			// 
			this.n0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.n0.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.n0.Location = new System.Drawing.Point(72, 177);
			this.n0.Name = "n0";
			this.n0.Size = new System.Drawing.Size(65, 31);
			this.n0.TabIndex = 10;
			this.n0.Text = "0";
			this.n0.UseVisualStyleBackColor = false;
			this.n0.Click += new System.EventHandler(this.N0Click);
			// 
			// bmult
			// 
			this.bmult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bmult.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bmult.Location = new System.Drawing.Point(214, 140);
			this.bmult.Name = "bmult";
			this.bmult.Size = new System.Drawing.Size(65, 31);
			this.bmult.TabIndex = 11;
			this.bmult.Text = "*";
			this.bmult.UseVisualStyleBackColor = false;
			this.bmult.Click += new System.EventHandler(this.BmultClick);
			// 
			// bsub
			// 
			this.bsub.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bsub.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bsub.Location = new System.Drawing.Point(214, 103);
			this.bsub.Name = "bsub";
			this.bsub.Size = new System.Drawing.Size(65, 31);
			this.bsub.TabIndex = 12;
			this.bsub.Text = "-";
			this.bsub.UseVisualStyleBackColor = false;
			this.bsub.Click += new System.EventHandler(this.BsubClick);
			// 
			// bad
			// 
			this.bad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bad.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bad.Location = new System.Drawing.Point(214, 66);
			this.bad.Name = "bad";
			this.bad.Size = new System.Drawing.Size(65, 31);
			this.bad.TabIndex = 13;
			this.bad.Text = "+";
			this.bad.UseVisualStyleBackColor = false;
			this.bad.Click += new System.EventHandler(this.BadClick);
			// 
			// bc
			// 
			this.bc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bc.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bc.Location = new System.Drawing.Point(143, 177);
			this.bc.Name = "bc";
			this.bc.Size = new System.Drawing.Size(65, 31);
			this.bc.TabIndex = 14;
			this.bc.Text = "C";
			this.bc.UseVisualStyleBackColor = false;
			// 
			// bp
			// 
			this.bp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bp.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bp.Location = new System.Drawing.Point(1, 177);
			this.bp.Name = "bp";
			this.bp.Size = new System.Drawing.Size(65, 31);
			this.bp.TabIndex = 15;
			this.bp.Text = ".";
			this.bp.UseVisualStyleBackColor = false;
			this.bp.Click += new System.EventHandler(this.BpClick);
			// 
			// bdiv
			// 
			this.bdiv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bdiv.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bdiv.Location = new System.Drawing.Point(214, 177);
			this.bdiv.Name = "bdiv";
			this.bdiv.Size = new System.Drawing.Size(65, 31);
			this.bdiv.TabIndex = 16;
			this.bdiv.Text = "/";
			this.bdiv.UseVisualStyleBackColor = false;
			this.bdiv.Click += new System.EventHandler(this.BdivClick);
			// 
			// bequal
			// 
			this.bequal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bequal.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bequal.Location = new System.Drawing.Point(110, 214);
			this.bequal.Name = "bequal";
			this.bequal.Size = new System.Drawing.Size(65, 31);
			this.bequal.TabIndex = 17;
			this.bequal.Text = "=";
			this.bequal.UseVisualStyleBackColor = false;
			this.bequal.Click += new System.EventHandler(this.BequalClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.bequal);
			this.Controls.Add(this.bdiv);
			this.Controls.Add(this.bp);
			this.Controls.Add(this.bc);
			this.Controls.Add(this.bad);
			this.Controls.Add(this.bsub);
			this.Controls.Add(this.bmult);
			this.Controls.Add(this.n0);
			this.Controls.Add(this.n9);
			this.Controls.Add(this.n8);
			this.Controls.Add(this.n7);
			this.Controls.Add(this.n6);
			this.Controls.Add(this.n5);
			this.Controls.Add(this.n4);
			this.Controls.Add(this.n3);
			this.Controls.Add(this.n2);
			this.Controls.Add(this.n1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
