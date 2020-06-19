# OpenapiClient::FeatureApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**feature_list**](FeatureApi.md#feature_list) | **GET** /feature/list | Lists the available features.



## feature_list

> feature_list

Lists the available features.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::FeatureApi.new

begin
  #Lists the available features.
  api_instance.feature_list
rescue OpenapiClient::ApiError => e
  puts "Exception when calling FeatureApi->feature_list: #{e}"
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

