using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4.OnlineRadioDatabase
{
	public class InvalidSongMinutesException : InvalidSongLengthException
	{
		public InvalidSongMinutesException() : base() { }

		public InvalidSongMinutesException(string message) : base(message) { }

		public InvalidSongMinutesException(int minSongLength, int maxSongLength) : base($"Song minutes should be between {minSongLength} and {maxSongLength}.") { }
	}
}
