LucasArts FNT Editor
===============================================================================
Author: Michael Gaisser (mjgaisser@gmail.com)
Version 1.0.2
Date: 2015.08.12
===============================================================================

This editor reads and writes the *.FNT files found in the base install
directories of TIE95, Xwing v TIE, Balance of Power, and Xwing Alliance, both
the 8-bit and 32-bit encodings.

At this time there is no ability to export images, this wasn't seen as a
necessity given the small size and simplicity of the character glyphs.  Future
versions may include the abilty to import/export bitmap image lists instead of
single characters.

===================
VERSION HISTORY

1.0.2 - 12 Aug 2015
 - Published under the MPL 2.0
 
1.0.1 - 06 Aug 2009
 - Fixed a bug when trying to use '>' past end
 - Changed Import so files are no longer left open
 - changed form to fixed size, removed Maxmimize button

1.0 - 29 Jul 2009
 - Release

===================
IMAGE GUIDELINES

Given the different encodings, the maximum width of the character is dependant
on the filename.  For filenames of "size.FNT", the maximum width is 8 pixels.
For filenames of "size##.FNT", a maximum width of 32 pixels is allowable.
Height of a given character for the purpose of this program is required to
maintain the height of the entire font, although the technical format itself
may allow differing sizes with unknown consequences.

Images should have a black background, interpreted by the game as transparent.
Any non-black color will be converted to white as solid.

===================
INSTRUCTIONS

- Open the FNT you wish to edit using the 'Open' button. The full path will be
displayed below.
- Use the '<' and '>' buttons to browse the glyphs.
- The 'Import' button will let you choose the bitmap you wish to use to
overwrite, sizing restrictions are enforced here.
- The '<- Copy' button does just that, copies the imported image to the left.
- Inverted image will be auto-generated upon copy.
- Changes are not permanent until the 'Save' button is clicked. This only has
to be done once per FNT, not per character.

As always, backup your original files first.

===============================================================================
Copyright © 2009 Michael Gaisser
This program and related files are licensed under the Mozilla Public License.
See License.txt for the full text. If for some reason the license was not
distributed with this program, you can obtain the full text of the license at
http://mozilla.org/MPL/2.0/.

"Star Wars" and related items are trademarks of LucasFilm Ltd and
LucasArts Entertainment Co.

This software is provided "as is" without warranty of any kind; including that
the software is free of defects, merchantable, fit for a particular purpose or
non-infringing. See the full license text for more details.