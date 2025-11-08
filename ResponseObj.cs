using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Svglogo data
    /// </summary>
    public class Svglogo
    {
        [JsonProperty("file_size_bytes")]
        public int Filesizebytes { get; set; }

        [JsonProperty("status_code")]
        public int Statuscode { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

    }
    /// <summary>
    /// Vmccertificate data
    /// </summary>
    public class Vmccertificate
    {
        [JsonProperty("status_code")]
        public int Statuscode { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("bimi_host")]
        public string Bimihost { get; set; }

        [JsonProperty("bimi_record")]
        public string Bimirecord { get; set; }

        [JsonProperty("bimi_records_count")]
        public int Bimirecordscount { get; set; }

        [JsonProperty("has_bimi_record")]
        public bool Hasbimirecord { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("svg_logo")]
        public Svglogo Svglogo { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("vmc_certificate")]
        public Vmccertificate Vmccertificate { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
