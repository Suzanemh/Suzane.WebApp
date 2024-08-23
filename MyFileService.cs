using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Suzane.WebApp
{
    public class MyFileService : IMyFileService
    {
        public IEnumerable<string> ReadMyFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty", nameof(filePath));
            }

            var lines = File.ReadAllLines(filePath);

            // Add signature to the last line
            var newEnumerable = lines.Append("Signatur: Suzane");

            return newEnumerable;
        }
    }
}
