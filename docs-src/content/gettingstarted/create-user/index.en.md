---
title: "Create or edit a user"
date: 2020-07-28T11:02:05+06:00
lastmod: 2020-07-28T11:02:05+06:00
weight: 2
draft: false
# search related keywords
keywords: ["create new user", "edit user", "example", "code", "guide"]
---

To create a new user or edit an existing one, you must make a HTTP POST request to the `usersave` endpoint:

```ruby
https://accucampus.net/api/v1/usersave
```

When creating a new user through the AccuCampus API, include the following required [parameters](/accucampus/#operation/userSave): token, firstname, lastname, and email. 

__Usage and SDK Examples:__
<!-- New User Examples -->
{{< tabs >}}

{{< tab "cURL" >}} 
{{< highlight js >}}
    curl --location --request POST 'https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com'
{{< /highlight >}}
{{< /tab >}}

{{< tab "C" >}}
{{< highlight c >}}
CURL *curl;
CURLcode res;
curl = curl_easy_init();
if(curl) {
  curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "POST");
  curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com");
  curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);
  curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");
  struct curl_slist *headers = NULL;
  curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);
  res = curl_easy_perform(curl);
}
curl_easy_cleanup(curl);
{{< /highlight  >}}
{{< /tab >}}

{{< tab "C#" >}} 
{{< highlight cs >}}
 var client = new RestClient("https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
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

  url := "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com"
  method := "POST"

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
    MediaType mediaType = MediaType.parse("text/plain");
    RequestBody body = RequestBody.create(mediaType, "");
    Request request = new Request.Builder()
    .url("https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com")
    .method("POST", body)
    .build();
    Response response = client.newCall(request).execute();
{{< /highlight >}}
{{< /tab >}}


{{< tab "NodeJS" >}} 
{{< highlight js >}}
    var request = require('request'); 
    var options = {
    'method': 'POST',
    'url': 'https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com',
    'headers': {
    }
    };
    request(options, function (error, response) { 
    if (error) throw new Error(error);
    console.log(response.body);
    });
{{< /highlight  >}}
 {{< /tab >}}

{{< tab "Python" >}} 
{{< highlight py >}}
    import requests

    url = "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com"

    payload = {}
    headers= {}

    response = requests.request("POST", url, headers=headers, data = payload)

    print(response.text.encode('utf8'))
    {{< /highlight >}}
{{< /tab >}}

{{< tab "PHP" >}}
{{< highlight php >}}
<?php

$curl = curl_init();

curl_setopt_array($curl, array(
  CURLOPT_URL => "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com",
  CURLOPT_RETURNTRANSFER => true,
  CURLOPT_ENCODING => "",
  CURLOPT_MAXREDIRS => 10,
  CURLOPT_TIMEOUT => 0,
  CURLOPT_FOLLOWLOCATION => true,
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
  CURLOPT_CUSTOMREQUEST => "POST",
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

    url = URI("https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com")

    https = Net::HTTP.new(url.host, url.port);
    https.use_ssl = true

    request = Net::HTTP::Post.new(url)

    response = https.request(request)
    puts response.read_body

{{< /highlight >}}
{{< /tab >}}


{{</ tabs >}}


__Successful response:__

    {
        "success": true,
        "results": [
            {
                "Id": "bbdec5ab-0c91-4f2e-a79e-abd70180d96e",
                "FirstName": "baby",
                "LastName": "yoda",
                "Email": "babyyoda@sw.com",
                "Active": true,
                "Extension": []
            }
        ]
    }
