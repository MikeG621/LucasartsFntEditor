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
 * v1.0, 090729
 * - Release
 */
using System;
using System.IO;
using System.Drawing;

namespace Idmr.LAFntEditor
{
	class FntWriter
	{
		private string _fntPath;
		private Bitmap[] _glyphs;
		private int _writeLength;

		/// <param name="path">The full path to the .FNT file</param>
		/// <param name="glyphs">Array of glyphs for the font, alternating normal and inverted</param>
		public FntWriter(string path, Bitmap[] glyphs)
		{
			_fntPath = path;
			if (_fntPath.Contains("16.FNT") || _fntPath.Contains("32.FNT") || _fntPath.Contains("48.FNT") || _fntPath.Contains("64.FNT")) _writeLength = 4;
			else _writeLength = 1;
			_glyphs = glyphs;
			if (_glyphs.Length%2 == 1) throw new Exception("Array length must be even");
		}

		public bool WriteAll()
		{
			FileStream fs = null;
			try
			{
				fs = File.OpenWrite(_fntPath);
				BinaryWriter bw = new BinaryWriter(fs);
				byte h = (byte)_glyphs[0].Height;
				byte t;
				for (int i=0;i<_glyphs.Length/2;i++)
				{
					bw.Write((byte)_glyphs[2*i].Width);
					bw.Write(h);
					for (int y=0;y<h;y++)
					{
						for (int s=(_writeLength-1);s>=0;s--)
						{
							t = 0;
							for (int x=s*8, b=7;x<(s+1)*8;x++, b--)
								if (x < _glyphs[2*i].Width)
									if (_glyphs[2*i].GetPixel(x, y) != Color.FromArgb(0, 0, 0)) t = (byte)(t|(1<<b));
							bw.Write(t);
						}
						for (int s=(_writeLength-1);s>=0;s--)
						{
							t = 0;
							for (int x=s*8, b=7;x<(s+1)*8;x++, b--)
								if (x < _glyphs[2*i+1].Width)
									if (_glyphs[2*i+1].GetPixel(x, y) != Color.FromArgb(0, 0, 0)) t = (byte)(t|(1<<b));
							bw.Write(t);
						}
					}
				}
				return true;
			}
			catch { return false; }
			finally { fs.Close(); }
		}
	}
}
