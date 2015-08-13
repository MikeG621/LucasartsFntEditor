namespace Idmr.LAFntEditor
{
	partial class frmLFE
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLFE));
			this.pctNormal = new System.Windows.Forms.PictureBox();
			this.pctInvert = new System.Windows.Forms.PictureBox();
			this.lblGlyph = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.lblWidth = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pctImport = new System.Windows.Forms.PictureBox();
			this.cmdImport = new System.Windows.Forms.Button();
			this.cmdCopyL = new System.Windows.Forms.Button();
			this.cmdPrev = new System.Windows.Forms.Button();
			this.cmdNext = new System.Windows.Forms.Button();
			this.cmdOpen = new System.Windows.Forms.Button();
			this.lblFile = new System.Windows.Forms.Label();
			this.cmdExit = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.opnFNT = new System.Windows.Forms.OpenFileDialog();
			this.opnImport = new System.Windows.Forms.OpenFileDialog();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctNormal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctInvert)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctImport)).BeginInit();
			this.SuspendLayout();
			// 
			// pctNormal
			// 
			this.pctNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pctNormal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pctNormal.Location = new System.Drawing.Point(10, 21);
			this.pctNormal.Name = "pctNormal";
			this.pctNormal.Size = new System.Drawing.Size(44, 50);
			this.pctNormal.TabIndex = 0;
			this.pctNormal.TabStop = false;
			// 
			// pctInvert
			// 
			this.pctInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pctInvert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pctInvert.Location = new System.Drawing.Point(279, 21);
			this.pctInvert.Name = "pctInvert";
			this.pctInvert.Size = new System.Drawing.Size(44, 50);
			this.pctInvert.TabIndex = 0;
			this.pctInvert.TabStop = false;
			// 
			// lblGlyph
			// 
			this.lblGlyph.AutoSize = true;
			this.lblGlyph.Location = new System.Drawing.Point(10, 74);
			this.lblGlyph.Name = "lblGlyph";
			this.lblGlyph.Size = new System.Drawing.Size(44, 13);
			this.lblGlyph.TabIndex = 1;
			this.lblGlyph.Text = "Glyph #";
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(10, 87);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(44, 13);
			this.lblHeight.TabIndex = 1;
			this.lblHeight.Text = "Height: ";
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(10, 100);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(41, 13);
			this.lblWidth.TabIndex = 1;
			this.lblWidth.Text = "Width: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(276, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Inverted";
			// 
			// pctImport
			// 
			this.pctImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pctImport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pctImport.Location = new System.Drawing.Point(143, 21);
			this.pctImport.Name = "pctImport";
			this.pctImport.Size = new System.Drawing.Size(44, 50);
			this.pctImport.TabIndex = 0;
			this.pctImport.TabStop = false;
			// 
			// cmdImport
			// 
			this.cmdImport.Enabled = false;
			this.cmdImport.Location = new System.Drawing.Point(143, 74);
			this.cmdImport.Name = "cmdImport";
			this.cmdImport.Size = new System.Drawing.Size(44, 23);
			this.cmdImport.TabIndex = 3;
			this.cmdImport.Text = "&Import";
			this.cmdImport.UseVisualStyleBackColor = true;
			this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
			// 
			// cmdCopyL
			// 
			this.cmdCopyL.Enabled = false;
			this.cmdCopyL.Location = new System.Drawing.Point(83, 35);
			this.cmdCopyL.Name = "cmdCopyL";
			this.cmdCopyL.Size = new System.Drawing.Size(54, 23);
			this.cmdCopyL.TabIndex = 4;
			this.cmdCopyL.Text = "<- Copy";
			this.cmdCopyL.UseVisualStyleBackColor = true;
			this.cmdCopyL.Click += new System.EventHandler(this.cmdCopyL_Click);
			// 
			// cmdPrev
			// 
			this.cmdPrev.Enabled = false;
			this.cmdPrev.Location = new System.Drawing.Point(10, 116);
			this.cmdPrev.Name = "cmdPrev";
			this.cmdPrev.Size = new System.Drawing.Size(24, 23);
			this.cmdPrev.TabIndex = 5;
			this.cmdPrev.Text = "<";
			this.cmdPrev.UseVisualStyleBackColor = true;
			this.cmdPrev.Click += new System.EventHandler(this.cmdPrev_Click);
			// 
			// cmdNext
			// 
			this.cmdNext.Enabled = false;
			this.cmdNext.Location = new System.Drawing.Point(40, 116);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(24, 23);
			this.cmdNext.TabIndex = 5;
			this.cmdNext.Text = ">";
			this.cmdNext.UseVisualStyleBackColor = true;
			this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
			// 
			// cmdOpen
			// 
			this.cmdOpen.Location = new System.Drawing.Point(83, 116);
			this.cmdOpen.Name = "cmdOpen";
			this.cmdOpen.Size = new System.Drawing.Size(45, 23);
			this.cmdOpen.TabIndex = 6;
			this.cmdOpen.Text = "&Open";
			this.cmdOpen.UseVisualStyleBackColor = true;
			this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Location = new System.Drawing.Point(10, 142);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(33, 13);
			this.lblFile.TabIndex = 7;
			this.lblFile.Text = "lblFile";
			// 
			// cmdExit
			// 
			this.cmdExit.Location = new System.Drawing.Point(253, 159);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(75, 23);
			this.cmdExit.TabIndex = 8;
			this.cmdExit.Text = "E&xit";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.Enabled = false;
			this.cmdSave.Location = new System.Drawing.Point(172, 159);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(75, 23);
			this.cmdSave.TabIndex = 8;
			this.cmdSave.Text = "&Save";
			this.cmdSave.UseVisualStyleBackColor = true;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// opnFNT
			// 
			this.opnFNT.DefaultExt = "fnt";
			this.opnFNT.Filter = "LA FNT Files|*.fnt";
			this.opnFNT.FileOk += new System.ComponentModel.CancelEventHandler(this.opnFNT_FileOk);
			// 
			// opnImport
			// 
			this.opnImport.DefaultExt = "bmp";
			this.opnImport.Filter = "Bitmaps|*.bmp";
			this.opnImport.FileOk += new System.ComponentModel.CancelEventHandler(this.opnImport_FileOk);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(140, 121);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(72, 13);
			this.lblTotal.TabIndex = 9;
			this.lblTotal.Text = "Total Glyphs: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(193, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 50);
			this.label2.TabIndex = 10;
			this.label2.Text = "Invert auto-generated on Import Copy";
			// 
			// frmLFE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 195);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.cmdOpen);
			this.Controls.Add(this.cmdNext);
			this.Controls.Add(this.cmdPrev);
			this.Controls.Add(this.cmdCopyL);
			this.Controls.Add(this.cmdImport);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.lblGlyph);
			this.Controls.Add(this.pctImport);
			this.Controls.Add(this.pctInvert);
			this.Controls.Add(this.pctNormal);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmLFE";
			this.Text = "LucasArts FNT Editor";
			((System.ComponentModel.ISupportInitialize)(this.pctNormal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctInvert)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctImport)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pctNormal;
		private System.Windows.Forms.PictureBox pctInvert;
		private System.Windows.Forms.Label lblGlyph;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pctImport;
		private System.Windows.Forms.Button cmdImport;
		private System.Windows.Forms.Button cmdCopyL;
		private System.Windows.Forms.Button cmdPrev;
		private System.Windows.Forms.Button cmdNext;
		private System.Windows.Forms.Button cmdOpen;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.OpenFileDialog opnFNT;
		private System.Windows.Forms.OpenFileDialog opnImport;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label2;
	}
}

