﻿#region Copyright and License Header
/*

	ShinyPatcher

	Copyright (c) 2016 0xFireball, IridiumIon Software

	Author(s): 0xFireball
	

	This file is part of ShinyPatcher.

	ShinyPatcher is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	ShinyPatcher is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with ShinyPatcher.  If not, see <http://www.gnu.org/licenses/>.

*/
#endregion


using Microsoft.Win32;

namespace ShinyPatcher
{
    internal class ShinyPatcherCommon
    {
        public static string BrowseForSaveFile(string filter, string title)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = filter,
                Title = title
            };
            var showDialog = sfd.ShowDialog();
            if (showDialog != null && (bool)showDialog)
            {
                return sfd.FileName;
            }
            return null;
        }

        public static string BrowseForOpenFile(string filter, string title)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = filter,
                Title = title,
                Multiselect = false
            };
            var showDialog = ofd.ShowDialog();
            if (showDialog != null && (bool)showDialog)
            {
                return ofd.FileName;
            }
            return null;
        }
    }
}