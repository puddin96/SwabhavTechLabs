using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Serial;

namespace Serial
{ 
    class SerialTest
    {

        static void Main(string[] args)
        {
            string path = "C:\\Users\\Puddin\\Desktop\\1234.pdf";
            Serial S;
            FileStream stream;
            BinaryFormatter formater;
            Serialization(path, out S, out stream, out formater);
            Deserialization(path, formater);

        }

        private static void Deserialization(string path, BinaryFormatter formater)
        {
            FileStream stream1 = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formater1 = new BinaryFormatter();
            Serial S1 = (Serial)formater1.Deserialize(stream1);
            Console.WriteLine("After Deserialization");
            PDetails(S1);
        }

        private static void Serialization(string path, out Serial S, out FileStream stream, out BinaryFormatter formater)
        {
            S = new Serial(1000);
            PrintDetails(S);
            S.Deposit(1000);
            Console.WriteLine(" ");
            stream = new FileStream(path, FileMode.OpenOrCreate);
            formater = new BinaryFormatter();
            formater.Serialize(stream, S);
            stream.Close();
            Console.WriteLine("Serialization successful");
            Console.WriteLine("File saved at :" + path);
            Console.WriteLine(" ");
        }

        public static void PrintDetails(Serial S)
        {
            Console.WriteLine("Old Balance: {0} ", S.Balance);
        }
        public static void PDetails(Serial S)
        {
            Console.WriteLine("New Balance: {0} ", S.Balance);
        }

    }
}
