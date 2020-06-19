# OpenapiClient::SocialApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**social_contacts**](SocialApi.md#social_contacts) | **GET** /social/contacts | Gets the list of contacts in the network



## social_contacts

> social_contacts(opts)

Gets the list of contacts in the network

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialApi.new
opts = {
  filter: 'filter_example', # String | Text to filter results.
  showdefaultphoto: true # Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
}

begin
  #Gets the list of contacts in the network
  api_instance.social_contacts(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialApi->social_contacts: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **String**| Text to filter results. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

