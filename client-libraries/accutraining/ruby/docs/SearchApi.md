# OpenapiClient::SearchApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**search_getentities**](SearchApi.md#search_getentities) | **GET** /search/getentities | Get the information of the entities that can be searched



## search_getentities

> search_getentities

Get the information of the entities that can be searched

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SearchApi.new

begin
  #Get the information of the entities that can be searched
  api_instance.search_getentities
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SearchApi->search_getentities: #{e}"
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

