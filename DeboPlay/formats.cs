using System;
using System.Collections.Generic;

namespace DeboPlay
{
    internal class Formats
    {
        public static readonly List<string> SupportedFormats = new List<string>
        {
            ".mp4", ".mkv", ".avi", ".mov", ".wmv", ".flv", ".webm", ".mpg", ".mpeg",
            ".3gp", ".ogv", ".mts", ".m2ts", ".vob", ".ts", ".divx", ".rmvb", ".mp3",
            ".aac", ".wav", ".flac", ".alac", ".ogg", ".wma", ".aiff", ".opus", ".dts",
            ".ac3", ".amr", ".m4a", ".mid", ".midi", ".pcm"
        };
    }
}
