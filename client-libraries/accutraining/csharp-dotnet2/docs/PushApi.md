# Org.OpenAPITools.Api.PushApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PushDeregister**](PushApi.md#pushderegister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
[**PushRegister**](PushApi.md#pushregister) | **GET** /push/register | Registers the current device to receive push notifications


<a name="pushderegister"></a>
# **PushDeregister**
> void PushDeregister (string devicetoken, string platform)

Deregisters the current device to receive push notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushDeregisterExample
    {
        public void main()
        {
            var apiInstance = new PushApi();
            var devicetoken = devicetoken_example;  // string | The device token where to send the notification.
            var platform = platform_example;  // string | Either ios or android

            try
            {
                // Deregisters the current device to receive push notifications
                apiInstance.PushDeregister(devicetoken, platform);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.PushDeregister: " + e.Message );
            }
        }
    }
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

<a name="pushregister"></a>
# **PushRegister**
> void PushRegister (string devicetoken, string platform)

Registers the current device to receive push notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PushRegisterExample
    {
        public void main()
        {
            var apiInstance = new PushApi();
            var devicetoken = devicetoken_example;  // string | The device token where to send the notification.
            var platform = platform_example;  // string | Either ios or android

            try
            {
                // Registers the current device to receive push notifications
                apiInstance.PushRegister(devicetoken, platform);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.PushRegister: " + e.Message );
            }
        }
    }
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

