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
 * - Changed Import so files are no longer left open
 * v1.0, 090729
 * - Release
 */

using System;
using System.IO;
using System.Drawing;

namespace Idmr.LAFntEditor
{
	class FntReader
	{
		private string _fntPath;
		private Bitmap[] _glyphs;
		private int _readLength;

		/// <param name="path">The full path to the .FNT file</param>
		public FntReader(string path)
		{
			_fntPath = path;
			if (_fntPath.Contains("16.FNT") || _fntPath.Contains("32.FNT") || _fntPath.Contains("48.FNT") || _fntPath.Contains("64.FNT")) _readLength = 4;
			else _readLength = 1;
			FileStream fs = File.OpenRead(_fntPath);
			BinaryReader br = new BinaryReader(fs);
			int w, h;
			fs.Position = 1;
			h = br.ReadByte();
			int count;
			for (count=0;fs.Position<fs.Length;count++)
				fs.Position += h*_readLength*2 + 2;
			_glyphs = new Bitmap[count*2];
			fs.Position = 0;
			for (int i=0;i<count;i++)
			{
				w = br.ReadByte();
				_glyphs[2*i] = new Bitmap(w, h);		// norm
				_glyphs[2*i+1] = new Bitmap(w, h);	// invert
				fs.Position++;
				for (int y=0;y<h;y++)
				{
					for (int s=(_readLength-1);s>=0;s--)
					{
						int t = br.ReadByte();
						for (int x=s*8, b=7;x<(s+1)*8;x++, b--)
							if (x < _glyphs[2*i].Width)
							{
								if ((t&(1<<b)) != 0) _glyphs[2*i].SetPixel(x, y, Color.White);
								else _glyphs[2*i].SetPixel(x, y, Color.Black);
							}
					}
					for (int s=(_readLength-1);s>=0;s--)
					{
						int t = br.ReadByte();
						for (int x=s*8, b=7;x<(s+1)*8;x++, b--)
							if (x < _glyphs[2*i+1].Width)
							{
								if ((t&(1<<b)) != 0) _glyphs[2*i+1].SetPixel(x, y, Color.White);
								else _glyphs[2*i+1].SetPixel(x, y, Color.Black);
							}
					}
				}
			}
			fs.Close();
		}

		public Bitmap[] Glyphs
		{
			get { return _glyphs; }
		}
		public int MaxWidth
		{
			get { return _readLength*8; }
		}
		public int NumGlyphs
		{
			get { return (_glyphs.Length/2); }
		}
	}
}
