using System.Diagnostics;
using System.Net.Sockets;
using System.Text.Json;

namespace Common.Communication
{
    public class JsonNetworkSerializer
    {
        private readonly Socket socket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public JsonNetworkSerializer(Socket s)
        {
            socket = s;
            stream = new NetworkStream(s);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
        }

        public void Send(object z) => writer.WriteLine(JsonSerializer.Serialize(z));

        public T Receive<T>()
        {
            try
            {
                if (!socket.Connected)
                    return default!;

                string json = reader.ReadLine()!;

                if (string.IsNullOrEmpty(json))
                    return default!;

                return JsonSerializer.Deserialize<T>(json)!;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Грешка приликом пријема: {ex.Message}");
                return default!;
            }
        }
        public T ReadType<T>(object podaci) where T : class => podaci == null ? null! : JsonSerializer.Deserialize<T>((JsonElement)podaci)!;

        public void Close()
        {
            stream?.Close();
            reader?.Close();
            writer?.Close();
        }
    }
}
