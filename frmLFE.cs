/*
 * LucasArts FNT Reader, Edits the .FNT files found in the LucasArts X-wing Series
 * Copyright (C) 2009 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 1.0.2
 */

/* CHANGELOG
 * v1.0.2, 150812
 * - Released under MPL
 * v1.0.1, 090806
 * - Fixed a bug when trying to use '>' past end
 * - Changed Import so files are no longer left open
 * - changed form to fixed size, removed Maxmimize button
 * v1.0, 090729
 * - Release
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Idmr.LAFntEditor
{
	public partial class frmLFE : Form
	{
		private int _glyphIndex = 0;
		private Bitmap[] _glyphs;
		private int _maxWidth;

		public frmLFE()
		{
			InitializeComponent();
			Height = 230;
			lblFile.Text = "";
		}

		private void cmdExit_Click(object sender, EventArgs e)
		{
			if (Text.Contains("*"))
			{
				DialogResult res = MessageBox.Show("Font is unsaved, do you wish to save now?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (res== DialogResult.Cancel) return;
				else if (res == DialogResult.No) Application.Exit();
				else
				{
					FntWriter fw = new FntWriter(lblFile.Text, _glyphs);
					fw.WriteAll();
				}
			}
			else Application.Exit();
		}
		private void cmdOpen_Click(object sender, EventArgs e)
		{
			opnFNT.ShowDialog();
		}
		private void cmdImport_Click(object sender, EventArgs e)
		{
			opnImport.ShowDialog();
		}
		private void cmdPrev_Click(object sender, EventArgs e)
		{
			if (_glyphIndex==0) return;
			_glyphIndex--;
			UpdateGlyphs();
		}
		private void cmdNext_Click(object sender, EventArgs e)
		{
			if (_glyphIndex == (_glyphs.Length/2-1)) return;
			_glyphIndex++;
			UpdateGlyphs();
		}
		private void cmdSave_Click(object sender, EventArgs e)
		{
			FntWriter fw = new FntWriter(lblFile.Text, _glyphs);
			fw.WriteAll();
			Text = Text.Replace("*","");
		}
		private void cmdCopyL_Click(object sender, EventArgs e)
		{
			cmdSave.Enabled = true;
			_glyphs[2*_glyphIndex] = (Bitmap)pctImport.BackgroundImage;
			_glyphs[2*_glyphIndex+1] = new Bitmap(pctImport.BackgroundImage);
			for(int y=0;y<_glyphs[0].Height;y++)
				for (int x=0;x<_glyphs[2*_glyphIndex].Width;x++)
				{
					Color c = _glyphs[2*_glyphIndex].GetPixel(x, y);
					if (c == Color.FromArgb(0, 0, 0)) _glyphs[2*_glyphIndex+1].SetPixel(x, y, Color.White);
					else _glyphs[2*_glyphIndex+1].SetPixel(x, y, Color.Black);
				}
			UpdateGlyphs();
			if (!Text.Contains("*")) Text += "*";
		}
		private void opnFNT_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			cmdNext.Enabled = true;
			cmdPrev.Enabled = true;
			cmdImport.Enabled = true;
			cmdSave.Enabled = false;
			FntReader fr = new FntReader(opnFNT.FileName);
			_glyphs = fr.Glyphs;
			_maxWidth = fr.MaxWidth;
			lblFile.Text = opnFNT.FileName;
			_glyphIndex = 0;
			lblHeight.Text = "Height: " + _glyphs[0].Height.ToString();
			lblTotal.Text = "Total Glyphs: " + fr.NumGlyphs.ToString();
			UpdateGlyphs();
		}
		private void opnImport_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			cmdCopyL.Enabled = true;
			Bitmap bm = new Bitmap(opnImport.FileName);
			if (bm.Height != _glyphs[0].Height) { MessageBox.Show("Must be same as existing height", "Error"); return; }
			if (bm.Width > _maxWidth) { MessageBox.Show("Image exceeds maximum width (" + _maxWidth.ToString() + "px)", "Error"); return; }
			for(int y=0;y<bm.Height;y++)
				for (int x=0;x<bm.Width;x++)
				{
					Color c = bm.GetPixel(x, y);
					if (c != Color.FromArgb(0, 0, 0)) bm.SetPixel(x, y, Color.White);
				}
			pctImport.BackgroundImage = new Bitmap(bm);
			bm.Dispose();
		}

		private void UpdateGlyphs()
		{
			pctNormal.BackgroundImage = _glyphs[2*_glyphIndex];
			pctInvert.BackgroundImage = _glyphs[2*_glyphIndex+1];
			lblGlyph.Text = "Glyph #" + (_glyphIndex+1).ToString();
			lblWidth.Text = "Width: " + _glyphs[2*_glyphIndex].Width.ToString();
		}
	}
}
