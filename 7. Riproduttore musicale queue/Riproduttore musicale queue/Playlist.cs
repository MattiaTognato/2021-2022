using System.Collections.Generic;
namespace Riproduttore_musicale_queue
{
    public class Playlist 
    {
        public List<Song> PlaylistSongs;

        public Playlist()
        {
            PlaylistSongs = new List<Song>();
        }
        public void AddSongs(Song s)
        {
            PlaylistSongs.Add(s);
        }
    }
}
