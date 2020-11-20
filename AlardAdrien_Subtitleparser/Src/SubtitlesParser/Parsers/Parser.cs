using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SubtitlesParser.Parsers
{
    public interface Parser
    {
        List<SubtitleItem> ParseStream(Stream stream, Encoding encoding);
    }
}