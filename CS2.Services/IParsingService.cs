using System.IO;
using Lucene.Net.Documents;

namespace CS2.Services
{
    public interface IParsingService
    {
        void Parse(FileInfo file, Document document);
    }
}