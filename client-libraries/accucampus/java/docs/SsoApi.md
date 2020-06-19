# SsoApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ssoGeneratekey**](SsoApi.md#ssoGeneratekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
[**ssoGetsettings**](SsoApi.md#ssoGetsettings) | **GET** /sso/getsettings | View single sign on settings.
[**ssoIssuetoken**](SsoApi.md#ssoIssuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
[**ssoSavesettings**](SsoApi.md#ssoSavesettings) | **POST** /sso/savesettings | Edit single sign-on settings.


<a name="ssoGeneratekey"></a>
# **ssoGeneratekey**
> ssoGeneratekey()

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SsoApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SsoApi apiInstance = new SsoApi(defaultClient);
    try {
      apiInstance.ssoGeneratekey();
    } catch (ApiException e) {
      System.err.println("Exception when calling SsoApi#ssoGeneratekey");
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

<a name="ssoGetsettings"></a>
# **ssoGetsettings**
> ssoGetsettings()

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SsoApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SsoApi apiInstance = new SsoApi(defaultClient);
    try {
      apiInstance.ssoGetsettings();
    } catch (ApiException e) {
      System.err.println("Exception when calling SsoApi#ssoGetsettings");
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

<a name="ssoIssuetoken"></a>
# **ssoIssuetoken**
> ssoIssuetoken(key, username, expires)

Issue single sign-on token

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SsoApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    SsoApi apiInstance = new SsoApi(defaultClient);
    String key = "key_example"; // String | The single sign-on key of the account.
    String username = "username_example"; // String | The email of the user to sign-on.
    Boolean expires = true; // Boolean | Specifies whether the session should expire when inactive.
    try {
      apiInstance.ssoIssuetoken(key, username, expires);
    } catch (ApiException e) {
      System.err.println("Exception when calling SsoApi#ssoIssuetoken");
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
 **key** | **String**| The single sign-on key of the account. |
 **username** | **String**| The email of the user to sign-on. |
 **expires** | **Boolean**| Specifies whether the session should expire when inactive. | [optional]

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

<a name="ssoSavesettings"></a>
# **ssoSavesettings**
> ssoSavesettings(UNKNOWN_BASE_TYPE)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SsoApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SsoApi apiInstance = new SsoApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.ssoSavesettings(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling SsoApi#ssoSavesettings");
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
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

