﻿//PixivUniversal
//Copyright(C) 2017 Pixeez Plus Project

//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; version 2
//of the License.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

namespace Pixeez.Objects
{

    public class UserInfo
    {
        public NewUser user { get; set; }
        public NewProfile profile { get; set; }
        public NewWorkspace workspace { get; set; }
    }

    public class NewUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public string account { get; set; }
        public ImageUrls profile_image_urls { get; set; }
        public string comment { get; set; }
        public bool is_followed { get; set; }
    }

    public class NewProfile
    {
        public string webpage { get; set; }
        public string gender { get; set; }
        public string birth { get; set; }
        public string region { get; set; }
        public string job { get; set; }
        public int total_follow_users { get; set; }
        public int total_follower { get; set; }
        public int total_mypixiv_users { get; set; }
        public int total_illusts { get; set; }
        public int total_manga { get; set; }
        public int total_novels { get; set; }
        public int total_illust_bookmarks_public { get; set; }
        public object background_image_url { get; set; }
        public string twitter_account { get; set; }
        public object twitter_url { get; set; }
        public bool is_premium { get; set; }
    }

    public class NewWorkspace
    {
        public string pc { get; set; }
        public string monitor { get; set; }
        public string tool { get; set; }
        public string scanner { get; set; }
        public string tablet { get; set; }
        public string mouse { get; set; }
        public string printer { get; set; }
        public string desktop { get; set; }
        public string music { get; set; }
        public string desk { get; set; }
        public string chair { get; set; }
        public string comment { get; set; }
        public string workspace_image_url { get; set; }
    }

}
