using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Utilities
{
    public class QueryConfig
    {
        private static QueryConfig _instance;
        private static readonly object _lock = new object();
        public Dictionary<string, Dictionary<string, string>> Queries { get; private set; }

        private QueryConfig()
        {
            var queryFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "queries.json");
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
