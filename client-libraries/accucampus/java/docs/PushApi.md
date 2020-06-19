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
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.PushApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    PushApi apiInstance = new PushApi(defaultClient);
    String devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
    String platform = "platform_example"; // String | Either ios or android
    try {
      apiInstance.pushDeregister(devicetoken, platform);
    } catch (ApiException e) {
      System.err.println("Exception when calling PushApi#pushDeregister");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **String**| The device token where to send the notification. |
 **platform** | **String**| Either ios or android |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="pushRegister"></a>
# **pushRegister**
> pushRegister(devicetoken, platform)

Registers the current device to receive push notifications

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.PushApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    PushApi apiInstance = new PushApi(defaultClient);
    String devicetoken = "devicetoken_example"; // String | The device token where to send the notification.
    String platform = "platform_example"; // String | Either ios or android
    try {
      apiInstance.pushRegister(devicetoken, platform);
    } catch (ApiException e) {
      System.err.println("Exception when calling PushApi#pushRegister");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **devicetoken** | **String**| The device token where to send the notification. |
 **platform** | **String**| Either ios or android |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

