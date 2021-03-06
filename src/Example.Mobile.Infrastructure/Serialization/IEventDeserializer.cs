﻿using System;

namespace Example.Mobile.Infrastructure.Serialization
{
    public interface IEventDeserializer
    {
        object Deserialize(string data, Type type);
        T Deserialize<T>(string data);
    }
}
