# LicenseApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**licenseAcceptagreement**](LicenseApi.md#licenseAcceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**licenseGetagreementstatus**](LicenseApi.md#licenseGetagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**licenseGetcurrent**](LicenseApi.md#licenseGetcurrent) | **GET** /license/getcurrent | Gets the current license information
[**licenseRenew**](LicenseApi.md#licenseRenew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuClub subscription


<a name="licenseAcceptagreement"></a>
# **licenseAcceptagreement**
> licenseAcceptagreement()

Accept the license agreement

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LicenseApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    LicenseApi apiInstance = new LicenseApi(defaultClient);
    try {
      apiInstance.licenseAcceptagreement();
    } catch (ApiException e) {
      System.err.println("Exception when calling LicenseApi#licenseAcceptagreement");
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="licenseGetagreementstatus"></a>
# **licenseGetagreementstatus**
> licenseGetagreementstatus()

Check if license agreement has been accepted

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LicenseApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    LicenseApi apiInstance = new LicenseApi(defaultClient);
    try {
      apiInstance.licenseGetagreementstatus();
    } catch (ApiException e) {
      System.err.println("Exception when calling LicenseApi#licenseGetagreementstatus");
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="licenseGetcurrent"></a>
# **licenseGetcurrent**
> licenseGetcurrent()

Gets the current license information

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LicenseApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    LicenseApi apiInstance = new LicenseApi(defaultClient);
    try {
      apiInstance.licenseGetcurrent();
    } catch (ApiException e) {
      System.err.println("Exception when calling LicenseApi#licenseGetcurrent");
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

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="licenseRenew"></a>
# **licenseRenew**
> licenseRenew(email, phonenumber, jobtitle, institution, comments)

Contact Engineerica in order to renew the AccuClub subscription

Allows the user to select the option to contact Engineerica when the AccuClub account is nearing its renewal date.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.LicenseApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    LicenseApi apiInstance = new LicenseApi(defaultClient);
    String email = "email_example"; // String | The e-mail of the user sending the request.
    String phonenumber = "phonenumber_example"; // String | The phone number of the user sending the request.
    String jobtitle = "jobtitle_example"; // String | The job title of the user sending the request.
    String institution = "institution_example"; // String | The institution of the user sending the request.
    String comments = "comments_example"; // String | Comments entered by the user sending the request.
    try {
      apiInstance.licenseRenew(email, phonenumber, jobtitle, institution, comments);
    } catch (ApiException e) {
      System.err.println("Exception when calling LicenseApi#licenseRenew");
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
 **email** | **String**| The e-mail of the user sending the request. |
 **phonenumber** | **String**| The phone number of the user sending the request. |
 **jobtitle** | **String**| The job title of the user sending the request. | [optional]
 **institution** | **String**| The institution of the user sending the request. | [optional]
 **comments** | **String**| Comments entered by the user sending the request. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

