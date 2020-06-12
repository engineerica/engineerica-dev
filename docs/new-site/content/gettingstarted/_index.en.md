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
    curl --location --request GET 'https://accucampus.net/api/v1/login?domain=democampus&<br>username=demo@demo.com&password=password&method=token&rememberme=false' \<br><br>
    --header 'Authorization: Bearer e13ef239-cac3-4440-92eb-3ead283598fa'
{{< /tab >}}

{{< tab "C" >}}
CURL *curl;<br>
CURLcode res;<br>
curl = curl_easy_init();<br>
if(curl) {<br>
  curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "GET");<br>
  curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false");<br>
  curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);<br>
  curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");<br>
  struct curl_slist *headers = NULL;<br>
  headers = curl_slist_append(headers, "Authorization: Bearer e13ef239-cac3-4440-92eb-3ead283598fa");<br>
  curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);<br>
  res = curl_easy_perform(curl);<br>
}<br>
curl_easy_cleanup(curl);

{{< /tab >}}

{{< tab "C#" >}} 
    var client = new RestClient("https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false");<br>
    client.Timeout = -1;<br>
    var request = new RestRequest(Method.GET);<br>
    request.AddHeader("Authorization", "Bearer e13ef239-cac3-4440-92eb-3ead283598fa");<br>
    IRestResponse response = client.Execute(request);<br>
    Console.WriteLine(response.Content);
{{< /tab >}}


{{< tab "Go" >}}
package main <br><br>

import ( <br>
  "fmt"<br>
  "net/http"<br>
  "io/ioutil"<br>
)<br><br>

func main() {<br><br>

  url := "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false"<br>
  method := "GET"<br><br>

  client := &http.Client {<br>
  }<br>
  req, err := http.NewRequest(method, url, nil)<br><br>

  if err != nil {<br>
    fmt.Println(err)<br>
  }<br>
  req.Header.Add("Authorization", "Bearer e13ef239-cac3-4440-92eb-3ead283598fa")<br><br>

  res, err := client.Do(req)<br>
  defer res.Body.Close()<br>
  body, err := ioutil.ReadAll(res.Body)<br><br>

  fmt.Println(string(body))<br>
} 

{{< /tab >}}

{{< tab "Java" >}}
    OkHttpClient client = new OkHttpClient().newBuilder()<br>
    .build();<br>
    Request request = new Request.Builder()<br>
    .url("https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false")<br>
    .method("GET", null)<br>
    .addHeader("Authorization", "Bearer e13ef239-cac3-4440-92eb-3ead283598fa")<br>
    .build();<br>
    Response response = client.newCall(request).execute();
{{< /tab >}}

{{< tab "JavaScript" >}}
var settings = { <br>
  "url": "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false",<br>
  "method": "GET",<br>
  "timeout": 0,<br>
  "headers": {<br>
    "Authorization": "Bearer e13ef239-cac3-4440-92eb-3ead283598fa"<br>
  },<br>
};<br><br>

$.ajax(settings).done(function (response) {<br>
  console.log(response);<br>
});
{{< /tab >}}

{{< tab "NodeJS" >}} 

var request = require('request');<br>
var options = {<br>
  'method': 'GET',<br>
  'url': 'https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false',<br>
  'headers': {<br>
    'Authorization': 'Bearer e13ef239-cac3-4440-92eb-3ead283598fa'<br>
  }<br>
};<br>
request(options, function (error, response) { <br>
  if (error) throw new Error(error);<br>
  console.log(response.body);<br>
});
 {{< /tab >}}

{{< tab "Python" >}} 

import requests<br><br>

url = "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false"<br><br>

payload = {}<br>
headers = {<br>
  'Authorization': 'Bearer e13ef239-cac3-4440-92eb-3ead283598fa'<br>
}<br><br>

response = requests.request("GET", url, headers=headers, data = payload)<br><br>

print(response.text.encode('utf8'))

{{< /tab >}}

{{< tab "PHP" >}}

&lt?php<br><br>

$curl = curl_init();<br><br>

curl_setopt_array($curl, array(<br>
  CURLOPT_URL => "https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false",<br>
  CURLOPT_RETURNTRANSFER => true,<br>
  CURLOPT_ENCODING => "",<br>
  CURLOPT_MAXREDIRS => 10,<br>
  CURLOPT_TIMEOUT => 0,<br>
  CURLOPT_FOLLOWLOCATION => true,<br>
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,<br>
  CURLOPT_CUSTOMREQUEST => "GET",<br>
  CURLOPT_HTTPHEADER => array(<br>
    "Authorization: Bearer e13ef239-cac3-4440-92eb-3ead283598fa"<br>
  ),<br>
));<br><br>

$response = curl_exec($curl);<br><br>

curl_close($curl);<br>
echo $response;
{{< /tab >}}

{{< tab "Ruby" >}}
require "uri"<br>
require "net/http"<br><br>

url = URI("https://accucampus.net/api/v1/login?domain=democampus&username=demo@demo.com&password=password&method=token&<br>rememberme=false")<br><br>

https = Net::HTTP.new(url.host, url.port);<br>
https.use_ssl = true<br><br>

request = Net::HTTP::Get.new(url)<br>
request["Authorization"] = "Bearer e13ef239-cac3-4440-92eb-3ead283598fa"<br><br>

response = https.request(request)<br>

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
    curl --location --request POST 'https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com'
{{< /tab >}}

{{< tab "C" >}}
CURL *curl;<br>
CURLcode res;<br>
curl = curl_easy_init();<br>
if(curl) {<br>
  curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "POST");
  curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com");<br>
  curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);<br>
  curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");<br>
  struct curl_slist *headers = NULL;<br>
  curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);<br>
  res = curl_easy_perform(curl);<br>
}<br>
curl_easy_cleanup(curl);

{{< /tab >}}

{{< tab "C#" >}} 
 var client = new RestClient("https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com");<br>
client.Timeout = -1;<br>
var request = new RestRequest(Method.POST);<br>
IRestResponse response = client.Execute(request);<br>
Console.WriteLine(response.Content);
{{< /tab >}}


{{< tab "Go" >}}
package main<br><br>

import (<br>
  "fmt"<br>
  "net/http"<br>
  "io/ioutil"<br>
)<br><br>

func main() {<br><br>

  url := "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com"<br>
  method := "POST"<br><br>

  client := &http.Client {<br>
  }<br>
  req, err := http.NewRequest(method, url, nil)<br><br>

  if err != nil {<br>
    fmt.Println(err)<br>
  }<br>
  res, err := client.Do(req)<br>
  defer res.Body.Close()<br>
  body, err := ioutil.ReadAll(res.Body)<br><br>

  fmt.Println(string(body))<br>
}
{{< /tab >}}

{{< tab "Java" >}}
    OkHttpClient client = new OkHttpClient().newBuilder()<br>
    .build();<br>
    MediaType mediaType = MediaType.parse("text/plain");<br>
    RequestBody body = RequestBody.create(mediaType, "");<br>
    Request request = new Request.Builder()<br>
    .url("https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com")<br>
    .method("POST", body)<br>
    .build();<br>
    Response response = client.newCall(request).execute();
{{< /tab >}}

{{< tab "JavaScript" >}}
    var settings = {<br>
    "url": "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com",<br>
    "method": "POST",<br>
    "timeout": 0,<br>
    };<br><br>

    $.ajax(settings).done(function (response) {<br>
    console.log(response);<br>
    });<br>
{{< /tab >}}

{{< tab "NodeJS" >}} 

    var request = require('request'); <br>
    var options = {<br>
    'method': 'POST',<br>
    'url': 'https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com',<br>
    'headers': {<br>
    }<br>
    };<br>
    request(options, function (error, response) { <br>
    if (error) throw new Error(error);<br>
    console.log(response.body);<br>
    });
 {{< /tab >}}

{{< tab "Python" >}} 
    import requests<br><br>

    url = "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com"<br><br>

    payload = {}<br>
    headers= {}<br><br>

    response = requests.request("POST", url, headers=headers, data = payload)<br><br>

    print(response.text.encode('utf8'))
{{< /tab >}}

{{< tab "PHP" >}}

&lt?php<br><br>

$curl = curl_init();<br><br>

curl_setopt_array($curl, array(<br>
  CURLOPT_URL => "https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com",<br>
  CURLOPT_RETURNTRANSFER => true,<br>
  CURLOPT_ENCODING => "",<br>
  CURLOPT_MAXREDIRS => 10,<br>
  CURLOPT_TIMEOUT => 0,<br>
  CURLOPT_FOLLOWLOCATION => true,<br>
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,<br>
  CURLOPT_CUSTOMREQUEST => "POST",<br>
));<br><br>

$response = curl_exec($curl);<br><br>

curl_close($curl);<br>
echo $response;<br>

{{< /tab >}}

{{< tab "Ruby" >}}
    require "uri"<br>
    require "net/http"<br><br>

    url = URI("https://accucampus.net/api/v1/usersave?token=78ee4a54-1afe-4769-b48f-52c8805da2a3&firstname=baby&lastname=yoda&email=babyyoda@sw.com")<br><br>

    https = Net::HTTP.new(url.host, url.port);<br>
    https.use_ssl = true<br><br>

    request = Net::HTTP::Post.new(url)<br><br>

    response = https.request(request)<br>
    puts response.read_body

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
curl --location --request POST 'https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!'
{{< /tab >}}

{{< tab "C" >}}
CURL *curl;<br>
CURLcode res;<br>
curl = curl_easy_init();<br>
if(curl) {<br>
  curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "POST");<br>
  curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!");<br>
  curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);<br>
  curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");<br>
  struct curl_slist *headers = NULL;<br>
  curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);<br>
  res = curl_easy_perform(curl);<br>
}<br>
curl_easy_cleanup(curl);

{{< /tab >}}

{{< tab "C#" >}} 
var client = new RestClient("https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!");<br>
client.Timeout = -1;<br>
var request = new RestRequest(Method.POST);<br>
IRestResponse response = client.Execute(request);<br>
Console.WriteLine(response.Content);
{{< /tab >}}


{{< tab "Go" >}}
package main<br><br>

import (<br>
  "fmt"<br>
  "net/http"<br>
  "io/ioutil"<br>
)
<br><br>
func main() {<br><br>

  url := "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!"<br>
  method := "POST"<br><br>

  client := &http.Client {<br>
  }<br>
  req, err := http.NewRequest(method, url, nil)<br><br>

  if err != nil {<br>
    fmt.Println(err)<br><br>
  }
  res, err := client.Do(req)<br>
  defer res.Body.Close()<br>
  body, err := ioutil.ReadAll(res.Body)<br><br>

  fmt.Println(string(body))<br>
}
{{< /tab >}}

{{< tab "Java" >}}
    OkHttpClient client = new OkHttpClient().newBuilder()<br>
    .build();<br>
    MediaType mediaType = MediaType.parse("text/plain");<br>
    RequestBody body = RequestBody.create(mediaType, "");<br>
    Request request = new Request.Builder()<br>
    .url("https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!")<br>
    .method("POST", body)<br>
    .build();<br>
    Response response = client.newCall(request).execute();<br>
{{< /tab >}}

{{< tab "JavaScript" >}}
    var settings = {<br>
    "url": "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!",<br>
    "method": "POST",<br>
    "timeout": 0,<br>
    };<br><br>

    $.ajax(settings).done(function (response) {<br>
    console.log(response);<br>
    });
{{< /tab >}}

{{< tab "NodeJS" >}} 

    var request = require('request');<br>
    var options = {<br>
    'method': 'POST',<br>
    'url': 'https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!',<br>
    'headers': {<br>
    }<br>
    };<br>
    request(options, function (error, response) { <br>
    if (error) throw new Error(error);<br>
    console.log(response.body);<br>
    });

 {{< /tab >}}

{{< tab "Python" >}} 
    import requests<br><br>

    url = "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!"<br><br>

    payload = {}<br>
    headers= {}<br><br>

    response = requests.request("POST", url, headers=headers, data = payload)<br><br>

    print(response.text.encode('utf8'))

{{< /tab >}}

{{< tab "PHP" >}}

&lt?php<br><br>

    $curl = curl_init();<br><br>

    curl_setopt_array($curl, array(<br>
    CURLOPT_URL => "https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic%20Beasts&details=We%20have%20unicorns!",<br>
    CURLOPT_RETURNTRANSFER => true,<br>
    CURLOPT_ENCODING => "",<br>
    CURLOPT_MAXREDIRS => 10,<br>
    CURLOPT_TIMEOUT => 0,<br>
    CURLOPT_FOLLOWLOCATION => true,<br>
    CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,<br>
    CURLOPT_CUSTOMREQUEST => "POST",<br>
    ));<br><br>

    $response = curl_exec($curl);<br><br>

    curl_close($curl);<br>
    echo $response;

{{< /tab >}}

{{< tab "Ruby" >}}
    require "uri"<br>
    require "net/http"<br><br>

    url = URI("https://accucampus.net/api/v1/departmentsave?token=23773f5b-76ca-423f-86e5-77a13fa5438b&name=Fantastic Beasts&details=We have unicorns!")<br><br>

    https = Net::HTTP.new(url.host, url.port);<br>
    https.use_ssl = true<br><br>

    request = Net::HTTP::Post.new(url)<br><br>

    response = https.request(request)<br>
    puts response.read_body

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

You will need to make a HTTP GET request to the 'appsharesendtext' endpoint:

```ruby
https://accucampus.net/api/v1/appsharesendtext 
```

To send a SMS to a phone number other than the one linked to your account, you will need to specify the phonenumber [parameter](/accucampus/#operation/appshareSendtext). Otherwise, the only required parameter is the token. 

__Usage and SDK Examples:__
<!-- Send SMS Examples -->
{{< tabs >}}

{{< tab "cURL" >}} 
curl --location --request GET 'https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999'
{{< /tab >}}

{{< tab "C" >}}
    CURL *curl;<br>
    CURLcode res;<br>
    curl = curl_easy_init();<br>
    if(curl) {<br>
    curl_easy_setopt(curl, CURLOPT_CUSTOMREQUEST, "GET");<br>
    curl_easy_setopt(curl, CURLOPT_URL, "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999");<br>
    curl_easy_setopt(curl, CURLOPT_FOLLOWLOCATION, 1L);<br>
    curl_easy_setopt(curl, CURLOPT_DEFAULT_PROTOCOL, "https");<br>
    struct curl_slist *headers = NULL;<br>
    curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);<br>
    res = curl_easy_perform(curl);<br>
    }<br>
    curl_easy_cleanup(curl);
{{< /tab >}}

{{< tab "Go" >}}
    package main<br><br>

    import (<br>
    "fmt"<br>
    "net/http"<br>
    "io/ioutil"<br>
    )<br><br>

    func main() {<br><br>

    url := "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999"<br>
    method := "GET"<br><br>

    client := &http.Client {<br>
    }<br>
    req, err := http.NewRequest(method, url, nil)<br><br>

    if err != nil {<br>
        fmt.Println(err)<br>
    }<br>
    res, err := client.Do(req)<br>
    defer res.Body.Close()<br>
    body, err := ioutil.ReadAll(res.Body)<br><br>

    fmt.Println(string(body))
    }
{{< /tab >}}

{{< tab "Java" >}}
    OkHttpClient client = new OkHttpClient().newBuilder()<br>
    .build();<br>
    Request request = new Request.Builder()<br>
    .url("https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999")<br>
    .method("GET", null)<br>
    .build();<br>
    Response response = client.newCall(request).execute();
{{< /tab >}}

{{< tab "JavaScript" >}}
    var settings = {<br>
    "url": "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999",<br>
    "method": "GET",<br>
    "timeout": 0,<br>
    };<br><br>

    $.ajax(settings).done(function (response) {<br>
    console.log(response);<br>
    });
{{< /tab >}}

{{< tab "NodeJS" >}} 

    var request = require('request');<br>
    var options = {<br>
    'method': 'GET',<br>
    'url': 'https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999',<br>
    'headers': {<br>
    }<br>
    };<br>
    request(options, function (error, response) { <br>
    if (error) throw new Error(error);<br>
    console.log(response.body);<br>
    });

 {{< /tab >}}

{{< tab "Python" >}} 
    import requests<br><br>

    url = "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999"<br><br>

    payload = {}<br>
    headers= {}<br><br>

    response = requests.request("GET", url, headers=headers, data = payload)<br><br>

    print(response.text.encode('utf8'))


{{< /tab >}}

{{< tab "PHP" >}}

&lt?php<br><br>

    $curl = curl_init();<br><br>

    curl_setopt_array($curl, array(<br>
    CURLOPT_URL => "https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999",<br>
    CURLOPT_RETURNTRANSFER => true,<br>
    CURLOPT_ENCODING => "",<br>
    CURLOPT_MAXREDIRS => 10,<br>
    CURLOPT_TIMEOUT => 0,<br>
    CURLOPT_FOLLOWLOCATION => true,<br>
    CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,<br>
    CURLOPT_CUSTOMREQUEST => "GET",<br>
    ));<br><br>

    $response = curl_exec($curl);<br><br>

    curl_close($curl);<br>
    echo $response;


{{< /tab >}}

{{< tab "Ruby" >}}
    require "uri"<br>
    require "net/http"<br><br>

    url = URI("https://accucampus.net/api/v1/appsharesendtext?token=23773f5b-76ca-423f-86e5-77a13fa5438b&phonenumber=9999999999")<br><br>

    https = Net::HTTP.new(url.host, url.port);<br>
    https.use_ssl = true<br><br>

    request = Net::HTTP::Get.new(url)<br><br>

    response = https.request(request)<br>
    puts response.read_body

{{< /tab >}}

{{</ tabs >}}

__Successful response:__

    {
        "success": true,
        "results": [
            true
        ]
    }



 

