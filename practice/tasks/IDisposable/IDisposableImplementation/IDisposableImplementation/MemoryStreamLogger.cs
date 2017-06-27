using System;
using System.IO;

namespace NetMentoring
{
    public class MemoryStreamLogger : IDisposable
    {
        private FileStream memoryStream;
        private StreamWriter streamWriter;

        public MemoryStreamLogger()
        {
            memoryStream = new FileStream(@"\Logs\log.txt", FileMode.Append | FileMode.OpenOrCreate);

            streamWriter = new StreamWriter(memoryStream);
        }

        public void Log(string message)
        {
            streamWriter.WriteLine($"{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss:fff} | {message}");
        }

        public void Dispose()
        {
            streamWriter?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}