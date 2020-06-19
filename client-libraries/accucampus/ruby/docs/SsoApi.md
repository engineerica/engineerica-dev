# OpenapiClient::SsoApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sso_generatekey**](SsoApi.md#sso_generatekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
[**sso_getsettings**](SsoApi.md#sso_getsettings) | **GET** /sso/getsettings | View single sign on settings.
[**sso_issuetoken**](SsoApi.md#sso_issuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
[**sso_savesettings**](SsoApi.md#sso_savesettings) | **POST** /sso/savesettings | Edit single sign-on settings.



## sso_generatekey

> sso_generatekey

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SsoApi.new

begin
  #Generate/reset single sign on access key.
  api_instance.sso_generatekey
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SsoApi->sso_generatekey: #{e}"
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


## sso_getsettings

> sso_getsettings

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SsoApi.new

begin
  #View single sign on settings.
  api_instance.sso_getsettings
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SsoApi->sso_getsettings: #{e}"
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


## sso_issuetoken

> sso_issuetoken(key, username, opts)

Issue single sign-on token

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::SsoApi.new
key = 'key_example' # String | The single sign-on key of the account.
username = 'username_example' # String | The email of the user to sign-on.
opts = {
  expires: true # Boolean | Specifies whether the session should expire when inactive.
}

begin
  #Issue single sign-on token
  api_instance.sso_issuetoken(key, username, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SsoApi->sso_issuetoken: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **String**| The single sign-on key of the account. | 
 **username** | **String**| The email of the user to sign-on. | 
 **expires** | **Boolean**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sso_savesettings

> sso_savesettings(opts)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SsoApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Edit single sign-on settings.
  api_instance.sso_savesettings(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SsoApi->sso_savesettings: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

