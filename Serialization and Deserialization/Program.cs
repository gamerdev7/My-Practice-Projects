using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_and_Deserialization
{
    [Serializable]
    public class GameData
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public GameData(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GameData gameDataBf = new("Shubham", 100);
            SerializeToBinary_BinaryFormatter(gameDataBf);
            GameData returnedGameDataBf = (GameData)DeserializeFromBinary_BinaryFormatter();
            Console.WriteLine($"returnedGameDataBf : Player Name = {returnedGameDataBf.PlayerName}, Score = {returnedGameDataBf.Score}");

            GameData gameDataBwr = new("Sam", 50);
            SerializeToBinary_BinaryWriterReader(gameDataBwr);
            GameData returnedGameDataBwr = DeserializeToBinary_BinaryWriterReader();

            Console.WriteLine($"returnedGameDataBwr : Player Name = {returnedGameDataBwr.PlayerName}, Score = {returnedGameDataBwr.Score}");
        }

        public static void <sdfs>hello()
        {

        }

        public static void SerializeToBinary_BinaryFormatter(object data)
        {
            using FileStream fs = new FileStream("GameData_bf.txt", FileMode.OpenOrCreate);

            BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            bf.Serialize(fs, data);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
        }

        public static object DeserializeFromBinary_BinaryFormatter()
        {
            using FileStream fs = new FileStream("GameData_bf.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            return bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
        }

        public static void SerializeToBinary_BinaryWriterReader(GameData data)
        {
            using FileStream fs = new FileStream("GameData_bwr.txt", FileMode.OpenOrCreate);

            using BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(data.PlayerName);
            writer.Write(data.Score);
        }

        public static GameData DeserializeToBinary_BinaryWriterReader()
        {
            using FileStream fs = new FileStream("GameData_bwr.txt", FileMode.OpenOrCreate);

            using BinaryReader reader = new BinaryReader(fs);

            GameData gameData = new(reader.ReadString(), reader.ReadInt32());

            return gameData;
        }
    }
}