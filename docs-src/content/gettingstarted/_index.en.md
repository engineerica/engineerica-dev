---
title: "Getting Started"
icon: "ti-world"
description: "View our quickstart guide"
date: 2020-06-11T11:02:05+06:00
type : "docs"
weight: 3
keywords: ["getting started", "help", "quickstart", "guide", "examples", "code", "api", "request", "response", "client library", "SDK"]
---
Engineerica’s Developer Hub website provides a collection of APIs that allow you to interact with our software products. In this guide, we will explore how to use Engineerica’s AccuCampus API to: 

- Create a new user 
- Create or edit a college department
- Send a SMS with the link to the AccuCampus app

Engineerica’s APIs use the JSON format for accepting and responding to HTTP requests. Our APIs also use HTTP response status codes to indicate whether a specific request has been successfully completed. 

You can use cURL (or a different HTTP/REST library of your choice) to directly make requests to the API, or you can make use of one of our SDKs.

 > We have over 10 SDKs available in our [GitHub repository](https://github.com/engineerica/engineerica-dev/tree/master/client-libraries) for the AccuCampus, AccuClub, and AccuTraining platforms. Please refer to the README documents for instructions on how to download and install a particular SDK. 


 <hr>

### Login
You will need to make a HTTP GET request to login to AccuCampus. The AccuCampus API is authenticated with bearer tokens- a type of security token represented as a cryptic string. When you make a login request to AccuCampus, the server will generate a bearer token in response to the login request. You must include the bearer token in the `Authorization` header when making requests to protected resources. 

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

***

### Create a New User

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

***

### Create or edit a college department

To create a new college department or edit an existing one, you must make a HTTP POST request to the `departmentsave` endpoint: 

```ruby
https://accucampus.net/api/v1/departmentsave
```

When creating a new college department through the AccuCampus API, include the following required [parameters](/accucampus/#operation/departmentSave): token and name.

__Usage and SDK Examples:__
<!-- New Department Examples -->
{{< tabs >}}

{{< tab "cURL" >}} 
{{< highlight js >}}
curl --location --request POST 'https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!'
{{< /highlight  >}}
{{< /tab >}}

{{< tab "C" >}}
{{< highlight c >}}
CURL *curl;
CURLcode res;
curl = curl_easy_init();
if(curl) {
  curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "POST");
  curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!");
  curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);
  curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");
  struct curl_slist *headers = NULL;
  curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);
  res = curl_easy_perform(curl);
}
curl_easy_cleanup(curl);
{{< /highlight >}}
{{< /tab >}}

{{< tab "C#" >}} 
{{< highlight cs >}}
var client = new RestClient("https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!");
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

  url := "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!"
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
{{< /highlight >}}
{{< /tab >}}

{{< tab "Java" >}}
{{< highlight java >}}
    OkHttpClient client = new OkHttpClient().newBuilder()
    .build();
    MediaType mediaType = MediaType.parse("text/plain");
    RequestBody body = RequestBody.create(mediaType, "");
    Request request = new Request.Builder()
    .url("https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!")
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
    'url': 'https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!',
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

    url = "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!"

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
    CURLOPT_URL => "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!",
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

    url = URI("https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!")

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
        "results": []
    }

***

### Send a SMS with the link to the AccuCampus app

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



 

