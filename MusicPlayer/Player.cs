using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MusicPlayer
{
    public class Player
    {
        public WaveOutEvent outputDevice = new WaveOutEvent();
        public AudioFileReader audioFile;
        public Song currentSong { get; set; }
        public MainDisplay mainDisplay;
        public void PlaySong(Song song)
        {
            if (audioFile != null)
            {
                outputDevice.Stop();
            }
            audioFile = new AudioFileReader(song.filename);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        public void Stop()
        {
            outputDevice.Stop();
            currentSong = null;
            audioFile = null;
            outputDevice = null;
        }

        public void Pause()
        {
            outputDevice.Pause();
        }

        public void Continue()
        {
            outputDevice.Play();
        }
        public void Next()
        {
            if(currentSong.next != null)
            {
                currentSong = currentSong.next;
                PlaySong(currentSong);
            }    
        }
        public void Previous()
        {
            if (currentSong.prev != null)
            {
                currentSong = currentSong.prev;
                PlaySong(currentSong);
            }
        }
        
    }
}
