# WWW::OpenAPIClient::PushApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::PushApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**push_deregister**](PushApi.md#push_deregister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
[**push_register**](PushApi.md#push_register) | **GET** /push/register | Registers the current device to receive push notifications


# **push_deregister**
> push_deregister(devicetoken => $devicetoken, platform => $platform)

Deregisters the current device to receive push notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::PushApi;
my $api_instance = WWW::OpenAPIClient::PushApi->new(
);

my $devicetoken = "devicetoken_example"; # string | The device token where to send the notification.
my $platform = "platform_example"; # string | Either ios or android

eval { 
    $api_instance->push_deregister(devicetoken => $devicetoken, platform => $platform);
};
if ($@) {
    warn "Exception when calling PushApi->push_deregister: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **string**| The device token where to send the notification. | 
 **platform** | **string**| Either ios or android | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **push_register**
> push_register(devicetoken => $devicetoken, platform => $platform)

Registers the current device to receive push notifications

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::PushApi;
my $api_instance = WWW::OpenAPIClient::PushApi->new(
);

my $devicetoken = "devicetoken_example"; # string | The device token where to send the notification.
my $platform = "platform_example"; # string | Either ios or android

eval { 
    $api_instance->push_register(devicetoken => $devicetoken, platform => $platform);
};
if ($@) {
    warn "Exception when calling PushApi->push_register: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **string**| The device token where to send the notification. | 
 **platform** | **string**| Either ios or android | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

