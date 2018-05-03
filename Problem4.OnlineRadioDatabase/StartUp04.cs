using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4.OnlineRadioDatabase
{
	class StartUp04
	{
		static void Main()
		{
			int numberOfSongs = int.Parse(Console.ReadLine());

			List<Song> songs = new List<Song>();

			for (int i = 0; i < numberOfSongs; i++)
			{
				try
				{
					var songInput = Console.ReadLine().Split(':', ';');
					int minutes = int.Parse(songInput[2]);
					int seconds = int.Parse(songInput[3]);
					int songArtist = songInput[0].Length;
					int songTitle = songInput[1].Length;

					if (songArtist < 3 && songArtist > 20 || songTitle < 3 && songTitle > 30)
					{
						throw new InvalidSongException();
					}

					if (minutes < 0 && minutes > 14 || seconds < 0 && seconds > 59)
					{
						throw new InvalidSongLengthException();
					}

					var artist = songInput[0];
					var songName = songInput[1];
					var songMinutes = int.Parse(songInput[2]);
					var songSeconds = int.Parse(songInput[3]);

					songs.Add(new Song(artist, songName, songMinutes, songSeconds));

					Console.WriteLine("Song added.");
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			CalculateAndPrintTotalPlayTime(songs);
		}

		public static void CalculateAndPrintTotalPlayTime(List<Song> songs)
		{
			Console.WriteLine($"Songs added: {songs.Count}");


			var totalSeconds = songs.Select(s => s.Seconds).Sum();
			var secondsToMinutes = totalSeconds / 60;
			var seconds = totalSeconds % 60;

			var totalMinutes = songs.Select(s => s.Minutes).Sum() + secondsToMinutes;
			var minutesToHours = totalMinutes / 60;
			var minutes = totalMinutes % 60;

			var hours = minutesToHours;

			Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
		}
	}
}
