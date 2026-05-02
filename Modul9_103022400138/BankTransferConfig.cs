using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400138
{
    public class BankTransferConfig
    {
        public Config config;
        private const string path = "bank_transfer_config.json";

        public BankTransferConfig() 
        {
            try 
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                writeConfigFile();
            }
        }

        public void ReadConfigFile()
        {
            string jsonString = File.ReadAllText(path);
            config = JsonSerializer.Deserialize<Config>(jsonString);
        }

        public void writeConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(path, jsonString);
        }

        public void SetDefault()
        {
            config = new Config
            {
                lang = "en",
                transfer = new Transfer
                {
                    threshold = 25000000,
                    low_fee = 6500,
                    high_fee = 15000
                },
                confirmation = new Confirmation
                {
                    en = "yes",
                    id = "ya"
                },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" }
            };
        }
    }
}
