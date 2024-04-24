using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class SongComponent : UserControl
    {
        public SongComponent(MainDisplay mainDisplay)
        {
            InitializeComponent();
            this.mainDisplay = mainDisplay;

        }
        private MainDisplay mainDisplay;
        private LinkedList ll = new LinkedList();
        public Song song { get; set; }
        public void SetSongInfo(Song song)
        {
            lblTitle.Text = song.title;
            lblArtist.Text = song.artist;
            lblDuration.Text = song.duration.ToString("m':'ss");
            ptbSongImage.Image = song.image;
        }

    #region Event 
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (mainDisplay.player.currentSong != song)
            {
                mainDisplay.player.currentSong = song;
                mainDisplay.Play();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(mainDisplay.player.currentSong == song)
            {
                MessageBox.Show("The song is playing, can't delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Delete this song?", "Delete song", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    ll.Delete(song);
                    var flowLayoutPanel = Parent as FlowLayoutPanel;
                    flowLayoutPanel?.Controls.Remove(this);
                }
            }
        }

        private void SongComponent_MouseEnter(object sender, EventArgs e)
        {
            pnItem.FillColor = Color.FromArgb(50, 50, 50);
            btnPlay.Image = Properties.Resources.icons8_play_50;
            btnDelete.Image = Properties.Resources.icons8_bin_48;
    }

        private void SongComponent_MouseLeave(object sender, EventArgs e)
        {
            pnItem.FillColor = Color.Transparent;
            btnPlay.Image = null;
            btnDelete.Image = null;
        }

        private void SongComponent_Load(object sender, EventArgs e)
        {
            if (lblTitle.Size.Width > 200)
                lblTitle.Text = lblTitle.Text.Substring(0, 30) + "...";
            if (lblArtist.Size.Width > 150)
                lblArtist.Text = lblArtist.Text.Substring(0, 20) + "...";
        }
        #endregion

    }
}
