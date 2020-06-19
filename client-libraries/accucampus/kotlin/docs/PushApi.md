# PushApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pushDeregister**](PushApi.md#pushDeregister) | **GET** /push/deregister | Deregisters the current device to receive push notifications
[**pushRegister**](PushApi.md#pushRegister) | **GET** /push/register | Registers the current device to receive push notifications


<a name="pushDeregister"></a>
# **pushDeregister**
> pushDeregister(devicetoken, platform)

Deregisters the current device to receive push notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = PushApi()
val devicetoken : kotlin.String = devicetoken_example // kotlin.String | The device token where to send the notification.
val platform : kotlin.String = platform_example // kotlin.String | Either ios or android
try {
    apiInstance.pushDeregister(devicetoken, platform)
} catch (e: ClientException) {
    println("4xx response calling PushApi#pushDeregister")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling PushApi#pushDeregister")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **kotlin.String**| The device token where to send the notification. |
 **platform** | **kotlin.String**| Either ios or android |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="pushRegister"></a>
# **pushRegister**
> pushRegister(devicetoken, platform)

Registers the current device to receive push notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = PushApi()
val devicetoken : kotlin.String = devicetoken_example // kotlin.String | The device token where to send the notification.
val platform : kotlin.String = platform_example // kotlin.String | Either ios or android
try {
    apiInstance.pushRegister(devicetoken, platform)
} catch (e: ClientException) {
    println("4xx response calling PushApi#pushRegister")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling PushApi#pushRegister")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **kotlin.String**| The device token where to send the notification. |
 **platform** | **kotlin.String**| Either ios or android |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

