namespace _11.Linq.Day2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    public class ReadData
    {
        public static List<T> ReadFrom<T>(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return ReadFrom<List<T>>(assembly.GetManifestResourceStream($"_11.Linq.Day2.Files.{fileName}"));
        }

        private static T ReadFrom<T>(Stream stream)
        {
            using (stream)
            using (var reader = new StreamReader(stream ?? throw new InvalidOperationException()))
            {
                var text = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(
                    text,
                    new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            }
        }
    }
}
