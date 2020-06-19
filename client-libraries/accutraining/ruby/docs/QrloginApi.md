# OpenapiClient::QrloginApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrlogin_get**](QrloginApi.md#qrlogin_get) | **GET** /qrlogin/get | Gets an image of a QR token
[**qrlogin_login**](QrloginApi.md#qrlogin_login) | **GET** /qrlogin/login | Login



## qrlogin_get

> qrlogin_get

Gets an image of a QR token

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QrloginApi.new

begin
  #Gets an image of a QR token
  api_instance.qrlogin_get
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QrloginApi->qrlogin_get: #{e}"
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


## qrlogin_login

> qrlogin_login(onetimetoken)

Login

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::QrloginApi.new
onetimetoken = 'onetimetoken_example' # String | The token read from the QR code.

begin
  #Login
  api_instance.qrlogin_login(onetimetoken)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QrloginApi->qrlogin_login: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **onetimetoken** | **String**| The token read from the QR code. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

