# OpenapiClient::AppshareApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**appshare_getphone**](AppshareApi.md#appshare_getphone) | **GET** /appshare/getphone | Gets the phone number of the current user
[**appshare_sendtext**](AppshareApi.md#appshare_sendtext) | **GET** /appshare/sendtext | Sends an SMS with the link to the app



## appshare_getphone

> appshare_getphone

Gets the phone number of the current user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppshareApi.new

begin
  #Gets the phone number of the current user
  api_instance.appshare_getphone
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppshareApi->appshare_getphone: #{e}"
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


## appshare_sendtext

> appshare_sendtext(opts)

Sends an SMS with the link to the app

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AppshareApi.new
opts = {
  phonenumber: 'phonenumber_example' # String | Phone number to where to send the link. Leave empty to the number on file.
}

begin
  #Sends an SMS with the link to the app
  api_instance.appshare_sendtext(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AppshareApi->appshare_sendtext: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phonenumber** | **String**| Phone number to where to send the link. Leave empty to the number on file. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

