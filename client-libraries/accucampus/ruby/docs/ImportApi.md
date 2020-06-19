# OpenapiClient::ImportApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**import_listtypes**](ImportApi.md#import_listtypes) | **GET** /import/listtypes | Lists available import types



## import_listtypes

> import_listtypes

Lists available import types

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ImportApi.new

begin
  #Lists available import types
  api_instance.import_listtypes
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ImportApi->import_listtypes: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

