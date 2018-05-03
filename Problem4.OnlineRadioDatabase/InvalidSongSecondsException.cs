using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4.OnlineRadioDatabase
{
    public class InvalidSongSecondsException : InvalidSongNameException 
    {
		public InvalidSongSecondsException() : base() { }

		public InvalidSongSecondsException(string message) : base(message) { }

		public InvalidSongSecondsException(int minSeconds,int maxSeconds)
			: base($"Song seconds should be between {minSeconds} and {maxSeconds}.") { }
	}
}
