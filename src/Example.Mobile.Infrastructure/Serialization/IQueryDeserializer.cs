﻿using System;

namespace Example.Mobile.Infrastructure.Serialization
{
    public interface IQueryDeserializer
    {
        object Deserialize(string data, Type type);
        T Deserialize<T>(string data);
    }
}
