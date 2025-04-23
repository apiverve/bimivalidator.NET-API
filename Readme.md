BIMI Record Validator API
============

BIMI Validator checks if a domain has a valid BIMI record published in DNS. BIMI enables domain owners to display verified logos in supported email clients.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [BIMI Record Validator API](https://apiverve.com/marketplace/api/bimivalidator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.BIMIRecordValidator
```

Using the Package Manager:
```
nuget install APIVerve.API.BIMIRecordValidator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.BIMIRecordValidator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.BIMIRecordValidator".
5. Click on the APIVerve.API.BIMIRecordValidator package, click Install.


---

## Configuration

Before using the bimivalidator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The BIMI Record Validator API documentation is found here: [https://docs.apiverve.com/api/bimivalidator](https://docs.apiverve.com/api/bimivalidator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
BIMI Record Validator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new BIMIRecordValidatorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new BIMIRecordValidatorQueryOptions {
  domain = "ebay.com"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "bimi_host": "default._bimi.ebay.com",
    "bimi_record": "v=BIMI1;l=https://bimi.entrust.net/ebay.com/logo.svg;a=https://bimi.entrust.net/ebay.com/certchain.pem",
    "bimi_records_count": 1,
    "has_bimi_record": true,
    "host": "ebay.com",
    "svg_logo": {
      "file_size_bytes": 1633,
      "status_code": 200,
      "url": "https://bimi.entrust.net/ebay.com/logo.svg",
      "valid": true
    },
    "valid": true,
    "version": "BIMI1",
    "vmc_certificate": {
      "status_code": 200,
      "url": "https://bimi.entrust.net/ebay.com/certchain.pem",
      "valid": true
    }
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.