using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib.Mpeg;
using NAudio.Wave;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using TagLib.IFD.Entries;

namespace MusicPlayer
{
    internal class LinkedList
    {
        public Song head {  get; set; }

        public void Add(Song newSong)
        {
            if (head == null)
            {
                head = newSong;
            }
            else
            {
                Song current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newSong;
                newSong.prev = current;
            }
        }
        public void Delete(Song delSong)
        {
            if (head == delSong)
            {
                head = delSong.next;
            }
            if (delSong.prev != null)
                delSong.prev.next = delSong.next;
            if (delSong.next != null)
                delSong.next.prev = delSong.prev;
            delSong.prev = null;
            delSong.next = null;
        }

        public bool CheckDuplicate(Song newSong)
        {
            Song current = head;
            while (current != null)
            {
                if (current.filename == newSong.filename)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void GetSongInfo(Song song)
        {
            TagLib.File file = TagLib.File.Create(song.filename);

            song.title = file.Tag.Title ?? "Unknown";
            song.artist = file.Tag.FirstPerformer ?? "Unknown";
            song.genre = file.Tag.FirstGenre ?? "Unknown";
            song.album = file.Tag.Album ?? "Unknown";

            var audioFile = new AudioFileReader(song.filename);
            song.duration = audioFile.TotalTime;

            if (file.Tag.Pictures.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data))
                {
                    song.image = Image.FromStream(ms);
                }
            }
            else
            {
                song.image = Properties.Resources._default;
            }
        }

        public List<Song> ToList(LinkedList ll) 
        {
            List<Song> list = new List<Song>();
            Song current = ll.head;
            while(current != null)
            {
                list.Add(current);
                current = current.next;
            }    
            return list; 
        }
    }
}
