using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Messages
    {
        public string Message { get; set; }
        public string Name { get; set; }

/*

        public Messages() { }

        public Messages(byte[] data)
        {

            Name = Encoding.ASCII.GetString(data, 0, data.Length);
        }

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();

            byteList.AddRange(Encoding.ASCII.GetBytes(Name));
            Console.WriteLine(byteList.ToArray().ToString());

            return byteList.ToArray();

        }*/
       /* 

        public byte[] Serialize()
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(Name);
                    writer.Write(Message);
                }
                return m.ToArray();
            }*/
        
    }
}
