using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ProMedic_Lease.Utilities
{
    public class QueryConfig
    {
        private static QueryConfig _instance;
        private static readonly object _lock = new object();
        public Dictionary<string, Dictionary<string, string>> Queries { get; private set; }

        private QueryConfig()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.FullName;
            var queryFilePath = Path.Combine(projectDirectory, "Resources", "queries.json");

            var jsonData = File.ReadAllText(queryFilePath);
            Queries = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonData);
        }


        public static QueryConfig Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new QueryConfig();
                    }
                    return _instance;
                }
            }
        }
    }
}
