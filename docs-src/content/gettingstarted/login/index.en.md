---
title: "Login"
date: 2020-07-28T11:02:05+06:00
lastmod: 2020-07-28T11:02:05+06:00
weight: 1
draft: false
# search related keywords
keywords: ["login", "example", "code", "guide"]
---

To login to your AccuCampus account through the AccuCampus API, you will need to make a HTTP GET request. The AccuCampus API is authenticated with bearer tokens- a type of security token represented as a cryptic string. When you make a login request to AccuCampus, the server will generate a bearer token in response to the login request. You must include the bearer token in the `Authorization` header, or, alternatively, you can specify the token directly in the URL when making requests to protected resources. 

To login using the Accucampus API, you need to make a HTTP GET request to the `login` endpoint: 

```ruby
https://accucampus.net/api/v1/login
```
    
<!-- login examples -->
The login request requires the following [parameters](/accucampus/#operation/login) to be specified: domain, username, password, method, and rememberme.

__Usage and SDK Examples:__
{{< tabs >}}

{{< tab "cURL" >}} 
{{< highlight js >}}
curl --location --request GET 'https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false'
{{< /highlight >}}
{{< /tab >}}

{{< tab "C" >}}
{{< highlight c >}}
CURL *curl;
CURLcode res;
curl = curl_easy_init();
if(curl) {
  curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "GET");
  curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false");
  curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);
  curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");
  struct curl_slist *headers = NULL;
  curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);
  res = curl_easy_perform(curl);
}
curl_easy_cleanup(curl);

{{< /tab >}}
{{< /highlight >}}

{{< tab "C#" >}}
{{< highlight cs >}} 
    var client = new RestClient("https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false");
    client.Timeout = -1;
    var request = new RestRequest(Method.GET);
    request.AddHeader("Authorization", "Bearer e13ef239-cac3-4440-92eb-3ead283598fa");
    IRestResponse response = client.Execute(request);
    Console.WriteLine(response.Content);
{{< /highlight >}}
{{< /tab >}}


{{< tab "Go" >}}
{{< highlight go >}}
package main 

import ( 
  "fmt"
  "net/http"
  "io/ioutil"
)

func main() {

  url := "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false"
  method := "GET"

  client := &http.Client {
  }
  req, err := http.NewRequest(method, url, nil)

  if err != nil {
    fmt.Println(err)
  }
 
  res, err := client.Do(req)
  defer res.Body.Close()
  body, err := ioutil.ReadAll(res.Body)

  fmt.Println(string(body))
} 
{{< /highlight  >}}
{{< /tab >}}

{{< tab "Java" >}}
{{< highlight java >}}
    OkHttpClient client = new OkHttpClient().newBuilder()
    .build();
    Request request = new Request.Builder()
    .url("https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false")
    .method("GET", null)
    .build();
    Response response = client.newCall(request).execute();
{{< /highlight  >}}
{{< /tab >}}

{{< tab "NodeJS" >}} 
{{< highlight js >}}
var request = require('request');
var options = {
  'method': 'GET',
  'url': 'https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false',
  'headers': {

  }
};
request(options, function (error, response) { 
  if (error) throw new Error(error);
  console.log(response.body);
});
{{< /highlight >}}
 {{< /tab >}}

{{< tab "Python" >}} 
{{< highlight py >}}
import requests

url = "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false"

payload = {}
headers = {
}

response = requests.request("GET", url, headers=headers, data = payload)

print(response.text.encode('utf8'))
{{< /highlight  >}}
{{< /tab >}}

{{< tab "PHP" >}}
{{< highlight php >}}
<?php

$curl = curl_init();

curl_setopt_array($curl, array(
  CURLOPT_URL => "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false",
  CURLOPT_RETURNTRANSFER => true,
  CURLOPT_ENCODING => "",
  CURLOPT_MAXREDIRS => 10,
  CURLOPT_TIMEOUT => 0,
  CURLOPT_FOLLOWLOCATION => true,
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
  CURLOPT_CUSTOMREQUEST => "GET",
));

$response = curl_exec($curl);

curl_close($curl);
echo $response;
{{< /highlight >}}
{{< /tab >}}

{{< tab "Ruby" >}}
{{< highlight ruby >}}
require "uri"
require "net/http"

url = URI("https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&rememberme=false")

https = Net::HTTP.new(url.host, url.port);
https.use_ssl = true

request = Net::HTTP::Get.new(url)

response = https.request(request)

{{< /highlight  >}}
{{< /tab >}}


{{</ tabs >}}

__Successful response:__

    {

        "token": "6bc5e875-c905-49f8-818c-8f6c855a328e",
        "UserId": "82e32343-df2d-4e0e-9147-a482013c7845",
        "FirstName": "Doug",
        "FullName": "Doug C Blundergas",
        "ShowLicenseAgreement": false,
        "success": true
    }