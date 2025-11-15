using System.Diagnostics;
using System.Text;

namespace MusicLibrary
{
    public class MusicLibrary
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Track> Tracks { get; set; }

        public MusicLibrary(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Tracks = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            if(Tracks.Count < Capacity)
            {
                if (!Tracks.Where(t => t.Title == track.Title && t.Artist == track.Artist).Any())
                {
                    Tracks.Add(track);
                }
            }
        }

        public bool RemoveTrack(string title, string artist)
        {
            var trackToRemove = Tracks.FirstOrDefault(t => t.Title == title && t.Artist == artist);

            if (trackToRemove != null)
            {
                Tracks.Remove(trackToRemove);
                return true;
            }

            return false;
        }

        public Track GetLongestTrack()
        {
            return Tracks.OrderByDescending(t => t.Duration).First();
        }

        public string GetTrackDetails(string title, string artist)
        {
            var track = Tracks.FirstOrDefault(t => t.Title == title && t.Artist == artist);

            if (track != null)
            {
                return track.ToString();
            }

            return "Track not found!";
        }

        public int GetTracksCount()
        {
            return Tracks.Count;
        }

        public List<Track> GetTracksByGenre(string genre)
        {
            return Tracks.Where(t => t.Genre == genre).ToList().OrderBy(k => k.Duration).ToList();
        }

        public string LibraryReport()
        {
            StringBuilder report = new();

            report.AppendLine($"Music Library: {Name}");
            report.AppendLine($"Tracks capacity: {Capacity}");
            report.AppendLine($"Number of tracks added: {Tracks.Count}");

            report.AppendLine("Tracks:");
            foreach (var track in Tracks.OrderByDescending(k => k.Duration))
            {
                report.AppendLine("-" + track.ToString());
            }

            return report.ToString().TrimEnd();
        }
    }
}
