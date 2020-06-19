# OpenapiClient::TextcreditApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**textcredit_remaining**](TextcreditApi.md#textcredit_remaining) | **GET** /textcredit/remaining | Gets the remaining text credits for the account



## textcredit_remaining

> textcredit_remaining

Gets the remaining text credits for the account

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TextcreditApi.new

begin
  #Gets the remaining text credits for the account
  api_instance.textcredit_remaining
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TextcreditApi->textcredit_remaining: #{e}"
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

