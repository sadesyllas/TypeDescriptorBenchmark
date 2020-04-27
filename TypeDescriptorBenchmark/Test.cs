using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using BenchmarkDotNet.Attributes;

namespace TypeDescriptorBenchmark
{
    public class Test
    {
        private object Message => new
        {
            a = (string) null,
            b = 45,
            c = DBNull.Value,
            d = new Extra(),
            e = (DateTime?) null
        };

        [Benchmark]
        public void AccessWithTypeDescriptor()
        {
            var message = Message;
            // var dict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(message))
            {
                var obj = propertyDescriptor.GetValue(message);

                // dict.Add(propertyDescriptor.Name, obj);
            }

            // return dict;
        }

        [Benchmark]
        public void SingleAccessWithGetProperties()
        {
            var message = Message;
            var messageType = message.GetType();
            var properties = messageType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            // var dict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

            foreach (PropertyInfo propertyInfo in properties)
            {
                var obj = propertyInfo.GetValue(message);

                // dict.Add(propertyInfo.Name, obj);
            }

            // return dict;
        }

        [Benchmark]
        public void NewAccessPerPropertyName()
        {
            var message = Message;
            var messageType = message.GetType();
            // var dict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

            foreach (var propertyName in new[] {"a", "b", "c", "d", "e"}
            )
            {
                var obj =
                    messageType.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance)!
                        .GetValue(message);

                // dict.Add(propertyName, obj);
            }

            // return dict;
        }

        class Extra
        {
            private static readonly Random Random = new Random();

            public override string ToString() => $"{nameof(Extra)}::{Random.Next()}";
        }
    }
}
