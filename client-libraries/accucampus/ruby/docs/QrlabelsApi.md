# OpenapiClient::QrlabelsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrlabels_print**](QrlabelsApi.md#qrlabels_print) | **GET** /qrlabels/print | Print and email QR labels



## qrlabels_print

> qrlabels_print(opts)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QrlabelsApi.new
opts = {
  user: 'user_example', # String | The id of the user whose label needs to be printed.
  group: 'group_example' # String | The id of the group whose members' labels need to be printed.
}

begin
  #Print and email QR labels
  api_instance.qrlabels_print(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QrlabelsApi->qrlabels_print: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**String**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**String**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

