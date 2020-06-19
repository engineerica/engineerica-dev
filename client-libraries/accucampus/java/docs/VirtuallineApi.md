# VirtuallineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**virtuallineAddmyself**](VirtuallineApi.md#virtuallineAddmyself) | **GET** /virtualline/addmyself | Add myself to a waiting line
[**virtuallineList**](VirtuallineApi.md#virtuallineList) | **GET** /virtualline/list | Lists waiting lines that have remote access enabled
[**virtuallineRemovemyself**](VirtuallineApi.md#virtuallineRemovemyself) | **GET** /virtualline/removemyself | Remove myself from a waiting line


<a name="virtuallineAddmyself"></a>
# **virtuallineAddmyself**
> virtuallineAddmyself(waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.VirtuallineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    VirtuallineApi apiInstance = new VirtuallineApi(defaultClient);
    UUID waitinglineid = new UUID(); // UUID | ID of the waiting line to join.
    try {
      apiInstance.virtuallineAddmyself(waitinglineid);
    } catch (ApiException e) {
      System.err.println("Exception when calling VirtuallineApi#virtuallineAddmyself");
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
 **waitinglineid** | [**UUID**](.md)| ID of the waiting line to join. |

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

<a name="virtuallineList"></a>
# **virtuallineList**
> virtuallineList()

Lists waiting lines that have remote access enabled

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.VirtuallineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    VirtuallineApi apiInstance = new VirtuallineApi(defaultClient);
    try {
      apiInstance.virtuallineList();
    } catch (ApiException e) {
      System.err.println("Exception when calling VirtuallineApi#virtuallineList");
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

<a name="virtuallineRemovemyself"></a>
# **virtuallineRemovemyself**
> virtuallineRemovemyself()

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.VirtuallineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    VirtuallineApi apiInstance = new VirtuallineApi(defaultClient);
    try {
      apiInstance.virtuallineRemovemyself();
    } catch (ApiException e) {
      System.err.println("Exception when calling VirtuallineApi#virtuallineRemovemyself");
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

