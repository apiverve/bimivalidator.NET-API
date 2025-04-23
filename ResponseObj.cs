using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class svglogo
{
    [JsonProperty("file_size_bytes")]
    public int filesizebytes { get; set; }

    [JsonProperty("status_code")]
    public int statuscode { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

}

public class vmccertificate
{
    [JsonProperty("status_code")]
    public int statuscode { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

}

public class data
{
    [JsonProperty("bimi_host")]
    public string bimihost { get; set; }

    [JsonProperty("bimi_record")]
    public string bimirecord { get; set; }

    [JsonProperty("bimi_records_count")]
    public int bimirecordscount { get; set; }

    [JsonProperty("has_bimi_record")]
    public bool hasbimirecord { get; set; }

    [JsonProperty("host")]
    public string host { get; set; }

    [JsonProperty("svg_logo")]
    public svglogo svglogo { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

    [JsonProperty("vmc_certificate")]
    public vmccertificate vmccertificate { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
