using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Challenge
{
    public class Playlist
    {
        public int PlayList(string[] songs, int k, string q)
        {
            int songIndex = -1;
            int foundSongSwitches;
            for(int i = 0; i < songs.Length; i++)
            {
                if(songs[i].Equals(q))
                {
                    songIndex = i;
                    break;
                }
            }

            if (songIndex == -1)
            {
                foundSongSwitches = 0;
            }
            else
            {
                foundSongSwitches = (songIndex > k) ? (songIndex - k) : (k - songIndex);
            }

            return foundSongSwitches;
        }
    }
}
