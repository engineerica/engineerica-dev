# OpenapiClient::PushApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**push_deregister**](PushApi.md#push_deregister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
[**push_register**](PushApi.md#push_register) | **GET** /push/register | Registers the current device to receive push notifications



## push_deregister

> push_deregister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::PushApi.new
devicetoken = 'devicetoken_example' # String | The device token where to send the notification.
platform = 'platform_example' # String | Either ios or android

begin
  #Deregisters the current device to receive push notifications
  api_instance.push_deregister(devicetoken, platform)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling PushApi->push_deregister: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## push_register

> push_register(devicetoken, platform)

Registers the current device to receive push notifications

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::PushApi.new
devicetoken = 'devicetoken_example' # String | The device token where to send the notification.
platform = 'platform_example' # String | Either ios or android

begin
  #Registers the current device to receive push notifications
  api_instance.push_register(devicetoken, platform)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling PushApi->push_register: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **String**| The device token where to send the notification. | 
 **platform** | **String**| Either ios or android | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

