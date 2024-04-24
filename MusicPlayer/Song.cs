using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MusicPlayer
{
    public class Song
    {
        public string filename {  get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string album { get; set; }
        public string genre { get; set; }
        public TimeSpan duration { get; set; }
        public Image image { get; set; }

        public Song next { get; set; }
        public Song prev { get; set; }
        public Song()
        {
            filename = null;
            title = null;
            artist = null;
            album = null;
            genre = null;
            duration = TimeSpan.Zero;
            image = null;
            next = null;
            prev = null;
        }
        public Song(string filename, string title, string artist, string album, string genre, TimeSpan duration, Image image)
        {
            this.filename = filename;
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.genre = genre;
            this.duration = duration;
            this.image = image;
            next = null;
            prev = null;
        }
    }
}
