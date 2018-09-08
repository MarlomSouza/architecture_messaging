using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;

namespace Producer
{
    public class Fila
    {
        private const string bootstrapServer = "bootstrap.servers";
        private const string uri = "localhost:9092";
        private Dictionary<string, object> config = new Dictionary<string, object> { { bootstrapServer, uri } };

        public string Enviar(string mensagem, string topico = "myTopic")
        {
            using (var producer = new Producer<Null, string>(config, null, new StringSerializer(Encoding.UTF8)))
            {
                var resultado = producer.ProduceAsync(topico, null, mensagem).Result;
                return $"Valor: '{resultado.Value}' Local: {resultado.TopicPartitionOffset}";
            }
        }


    }
}
