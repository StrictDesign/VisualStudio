using System;
using System.IO;

namespace Indexer
{
    // Class to provide access to a large file
    // as if it were a byte array.
    public class FileByteArray
    {
        Stream _stream; // Holds the underlying stream
                       // used to access the file.

        // Create a new FileByteArray encapsulating a particular file.
        public FileByteArray(string filename)
        {
            _stream = new FileStream(filename, FileMode.Open);
        }

        // Close the stream. This should be the last thing done
        // when you are finished.
        public void Close()
        {
            _stream.Close();
            _stream = null;
        }

        // Indexer to provide read/write access to the file.
        public byte this[long index] // long is a 64-bit integer
        {
            // Read one byte at offset index and return it.
            get
            {
                var buffer = new byte[1];
                _stream.Seek(index, SeekOrigin.Begin);
                _stream.Read(buffer, 0, 1);
                return buffer[0];
            }
            // Write one byte at offset index and return it.
            set
            {
                var buffer = new[] { value };
                _stream.Seek(index, SeekOrigin.Begin);
                _stream.Write(buffer, 0, 1);
            }
        }
        // Get the total length of the file.
        public long Lenght => _stream.Seek(0, SeekOrigin.End);
    }
    // Demonstrate the FileByteArray class.
    // Reverses the bytes in a file.
    public class Reverse
    {
        public static void Main(String[] args)
        {
            // Check for arguments.
            if (args.Length == 0)
            {
                Console.WriteLine("indexer <filename>");
                return;
            }

            var file = new FileByteArray(args[0]);
            var len = file.Lenght;

            // Swap bytes in the file to reverse it.
            for(long i = 0; i < len / 2; ++i)
            {
                // Note that indexing the "file" variable invokes the
                // indexer on the FileByteStream class, which reads
                // and writes the bytes in the file.
                var t = file[i];
                file[i] = file[len - i - 1];
                file[len - i - 1] = t;
            }
            file.Close();
        }
    }

}
