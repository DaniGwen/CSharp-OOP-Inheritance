using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4.OnlineRadioDatabase
{
    public class InvalidSongNameException : InvalidSongMinutesException 
    {
		public InvalidSongNameException(): base() { }

		public InvalidSongNameException(string message) : base(message) { }

		public InvalidSongNameException(int minNameLength, int maxNameLength)
			: base($"Song name should be between {minNameLength} and {maxNameLength} symbols.") { }
	}
}
