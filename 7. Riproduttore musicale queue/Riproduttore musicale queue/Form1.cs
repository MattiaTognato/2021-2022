using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riproduttore_musicale_queue
{
    public partial class Form1 : Form
    {
        Playlist _playlist;
        Player _player;
        delegate void SafeCall(string titolo);
        public Form1()
        {
            InitializeComponent();
            _playlist = new Playlist();
            _playlist.AddSongs(new Song("c1", 1));
            _playlist.AddSongs(new Song("c2", 2));
            _playlist.AddSongs(new Song("c3", 3));
            _playlist.AddSongs(new Song("c4", 4));
            _playlist.AddSongs(new Song("c5", 5));
            _playlist.AddSongs(new Song("c6", 6));

            _player = new Player();
            _player.OnSongChanged += _player_OnSongChanged;
            RefreshData();
        }

        private void _player_OnSongChanged(object sender, Song e)
        {
            if (e == null)
            {
                ChangeText("Niente in riproduzione");
            }
            else
            {
                ChangeText($"Sto riproducendo {e.Titolo}");
            }
        }
        void ChangeText(string text)
        {
            if (PlayerLabel.InvokeRequired)
            {
                SafeCall d = new SafeCall(ChangeText);
                PlayerLabel.Invoke(d, text);
            }
            else
            {
                PlayerLabel.Text = text;
                RefreshData();
            }
        }

        public void RefreshData()
        {
            PlaylistDataGridView.DataSource = null;
            PlaylistDataGridView.DataSource = _playlist.PlaylistSongs;
            PlayerDataGridView.DataSource = null;
            PlayerDataGridView.DataSource = _player.SongsQueue.ToList();
        }

        private void AddToQueueBtn_Click(object sender, EventArgs e)
        {
            _player.AddSongToQueue(_playlist.PlaylistSongs[PlaylistDataGridView.CurrentCell.RowIndex]);
            RefreshData();
        }

        private void PlayCodaBtn_Click(object sender, EventArgs e)
        {
            _player.Play();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            _player.Stop();
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            _player.Skip();
        }
    }
}
