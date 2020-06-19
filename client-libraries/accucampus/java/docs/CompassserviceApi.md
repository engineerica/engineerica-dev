# CompassserviceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**compassserviceList**](CompassserviceApi.md#compassserviceList) | **GET** /compassservice/list | View all the services added to the compass
[**compassserviceListlocations**](CompassserviceApi.md#compassserviceListlocations) | **GET** /compassservice/listlocations | View all the locations where a service added to the compass is available


<a name="compassserviceList"></a>
# **compassserviceList**
> compassserviceList(category)

View all the services added to the compass

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.CompassserviceApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    CompassserviceApi apiInstance = new CompassserviceApi(defaultClient);
    UUID category = new UUID(); // UUID | The id of the category to filter the services.
    try {
      apiInstance.compassserviceList(category);
    } catch (ApiException e) {
      System.err.println("Exception when calling CompassserviceApi#compassserviceList");
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
 **category** | [**UUID**](.md)| The id of the category to filter the services. | [optional]

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

<a name="compassserviceListlocations"></a>
# **compassserviceListlocations**
> compassserviceListlocations(serviceid)

View all the locations where a service added to the compass is available

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.CompassserviceApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    CompassserviceApi apiInstance = new CompassserviceApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The id of the service to get its locations.
    try {
      apiInstance.compassserviceListlocations(serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling CompassserviceApi#compassserviceListlocations");
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
 **serviceid** | [**UUID**](.md)| The id of the service to get its locations. |

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

