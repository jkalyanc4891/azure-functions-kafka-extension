﻿using Confluent.Kafka;
using Google.Protobuf;

namespace ConsoleProducer
{
    /// <summary>
    /// Protobuf serializer
    /// </summary>
    public class ProtobufSerializer<T> : ISerializer<T> where T : IMessage<T>, new()
    {
        public byte[] Serialize(T data, SerializationContext context)
            => data.ToByteArray();
    }
}
