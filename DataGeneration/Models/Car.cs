﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        public static readonly string PATH = "../../../../../Reports/";
        public static readonly string FILE = "cars.json";

        public static readonly string GETALL = "SELECT [Plate] ,[Name] ,[ModelYear] ,[ManufatureYear] ,[Color] FROM [DBCarGarage].[dbo].[Car] ORDER BY [Name]";

        [JsonProperty("plate_number")]
        public string Plate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("model_year")]
        public int ModelYear { get; set; }

        [JsonProperty("manufature_year")]
        public int ManufatureYear { get; set; }
        
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}
