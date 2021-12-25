using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Riproduttore_musicale_queue
{
    public class Player 
    {
        public Queue<Song> SongsQueue;
        System.Timers.Timer time;
        public event EventHandler<Song> OnSongChanged;
        public Player()
        {
            SongsQueue = new Queue<Song>();
        }
        public void Play() 
        {
            if (SongsQueue.Count == 0)
            {
                time?.Stop();
                OnSongChanged?.Invoke(this, null);
                return;
            }
            time = new System.Timers.Timer()
            {
                Interval = SongsQueue.Peek().Durata * 1000,
                AutoReset = false,
                Enabled = true
            };
            time.Elapsed += UpdateQueue;
            time.Start();
            OnSongChanged?.Invoke(this, SongsQueue.Dequeue());
        }
        private void UpdateQueue(object sender, EventArgs e)
        {
            Play();
        }
        public void AddSongToQueue(Song s)
        {
            SongsQueue.Enqueue(s);
        }
        public void Stop()
        {
            time?.Stop();
            time?.Dispose();
            OnSongChanged?.Invoke(this, null);
        }
        public void Skip()
        {
            time?.Stop();
            time?.Dispose();
            Play();
        }
    }
}
    