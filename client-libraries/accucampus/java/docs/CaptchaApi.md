# CaptchaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**captchaGetchallenge**](CaptchaApi.md#captchaGetchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captchaGetimage**](CaptchaApi.md#captchaGetimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.


<a name="captchaGetchallenge"></a>
# **captchaGetchallenge**
> captchaGetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.CaptchaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    CaptchaApi apiInstance = new CaptchaApi(defaultClient);
    try {
      apiInstance.captchaGetchallenge();
    } catch (ApiException e) {
      System.err.println("Exception when calling CaptchaApi#captchaGetchallenge");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters
This endpoint does not need any parameter.

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

<a name="captchaGetimage"></a>
# **captchaGetimage**
> captchaGetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.CaptchaApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    CaptchaApi apiInstance = new CaptchaApi(defaultClient);
    String captchatoken = "captchatoken_example"; // String | The captcha token or ID returned by the captcha.getchallenge action
    try {
      apiInstance.captchaGetimage(captchatoken);
    } catch (ApiException e) {
      System.err.println("Exception when calling CaptchaApi#captchaGetimage");
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
 **captchatoken** | **String**| The captcha token or ID returned by the captcha.getchallenge action |

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

