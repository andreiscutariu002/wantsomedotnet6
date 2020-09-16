using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _03ReadSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath = @"output.data";

            Stream stream = File.Open(fpath, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            var obj = bf.Deserialize(stream);
            stream.Close();
        }
    }
}
