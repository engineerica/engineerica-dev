# OpenapiClient::ExportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**export_listtypes**](ExportApi.md#export_listtypes) | **GET** /export/listtypes | Lists available export types



## export_listtypes

> export_listtypes

Lists available export types

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ExportApi.new

begin
  #Lists available export types
  api_instance.export_listtypes
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ExportApi->export_listtypes: #{e}"
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

