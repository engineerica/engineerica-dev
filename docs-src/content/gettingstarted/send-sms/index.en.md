---
title: "Send a SMS"
date: 2020-07-28T11:02:05+06:00
lastmod: 2020-07-28T11:02:05+06:00
weight: 4
draft: false
# search related keywords
keywords: ["SMS", "link", "example", "code", "guide"]
---

Using the AccuCampus API, you can send a SMS message containing a link to the Accucampus app to the phone number of your choice or to the phone number linked to your account (default). 

You will need to make a HTTP GET request to the `appsharesendtext` endpoint:

```ruby
https://accucampus.net/api/v1/appsharesendtext 
```

To send a SMS to a phone number other than the one linked to your account, you will need to specify the phonenumber [parameter](/accucampus/#operation/appshareSendtext). Otherwise, the only required parameter is the token. 

__Usage and SDK Examples:__
<!-- Send SMS Examples -->
{{< tabs >}}

{{< tab "cURL" >}} 
{{< highlight js >}}
curl --location --request GET 'https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999'
{{< /highlight >}}
{{< /tab >}}

{{< tab "C" >}}
{{< highlight c >}}
    CURL *curl;
    CURLcode res;
    curl = curl_easy_init();
    if(curl) {
    curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "GET");
    curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999");
    curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);
    curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");
    struct curl_slist *headers = NULL;
    curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);
    res = curl_easy_perform(curl);
    }
    curl_easy_cleanup(curl);
{{< / highlight >}}
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

    url := "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999"
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
{{< /highlight >}}
{{< /tab >}}

{{< tab "Java" >}}
{{< highlight java >}}
    OkHttpClient client = new OkHttpClient().newBuilder()
    .build();
    Request request = new Request.Builder()
    .url("https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999")
    .method("GET", null)
    .build();
    Response response = client.newCall(request).execute();
{{< /highlight >}}
{{< /tab >}}

{{< tab "NodeJS" >}} 
{{< highlight js >}}
    var request = require('request');
    var options = {
    'method': 'GET',
    'url': 'https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999',
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

    url = "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999"

    payload = {}
    headers= {}

    response = requests.request("GET", url, headers=headers, data = payload)

    print(response.text.encode('utf8'))

{{< /highlight >}}
{{< /tab >}}

{{< tab "PHP" >}}
{{< highlight php >}}
<?php

    $curl = curl_init();

    curl_setopt_array($curl, array(
    CURLOPT_URL => "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999",
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

    url = URI("https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999")

    https = Net::HTTP.new(url.host, url.port);
    https.use_ssl = true

    request = Net::HTTP::Get.new(url)

    response = https.request(request)
    puts response.read_body
{{< /highlight >}}
{{< /tab >}}

{{</ tabs >}}

__Successful response:__

    {
        "success": true,
        "results": [
            true
        ]
    }