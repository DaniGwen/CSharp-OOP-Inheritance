using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4.OnlineRadioDatabase
{


	public class Song : InvalidSongException
	{
		private const int ArtistMinLength = 3;
		private const int ArtistMaxLength = 20;
		private const int NameMinLength = 3;
		private const int NameMaxLength = 30;
		private const int MinutesMin = 0;
		private const int MinutesMax = 14;
		private const int SecondsMin = 0;
		private const int SecondsMax = 59;

		public Song(string artist, string song, int minutes, int seconds)
		{
			this.ArtistName = artist;
			this.SongName = song;
			this.Minutes = minutes;
			this.Seconds = seconds;
		}

		public int songLengthInSeconds => Seconds + (Minutes * 59);

		private int songLength;
		private string artistName;
		private string songName;
		private int minutes;
		private int seconds;

		public int Seconds
		{
			get { return this.seconds; }
			set
			{
				if (value < SecondsMin || value > SecondsMax)
				{
					throw new InvalidSongSecondsException(SecondsMin, SecondsMax);
				}
				seconds = value;
			}
		}

		public int Minutes
		{
			get { return minutes; }
			set
			{
				if (value < MinutesMin || value > MinutesMax)
				{
					throw new InvalidSongMinutesException(MinutesMin, MinutesMax);
				}
				minutes = value;
			}
		}

		public string ArtistName
		{
			get { return artistName; }
			set
			{
				if (value.Length < ArtistMinLength && value.Length > ArtistMaxLength)
				{
					throw new InvalidArtistNameException(ArtistMinLength, ArtistMaxLength);
				}
				artistName = value;
			}
		}

		public string SongName
		{
			get { return songName; }
			set
			{
				if (value.Length < NameMinLength && value.Length > NameMaxLength)
				{
					throw new InvalidSongNameException(NameMinLength, NameMaxLength);
				}
				songName = value;
			}
		}

	}
}
