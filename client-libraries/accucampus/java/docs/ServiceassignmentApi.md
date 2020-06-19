# ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceassignmentAddservice**](ServiceassignmentApi.md#serviceassignmentAddservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**serviceassignmentGetlocation**](ServiceassignmentApi.md#serviceassignmentGetlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**serviceassignmentGetservice**](ServiceassignmentApi.md#serviceassignmentGetservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**serviceassignmentRemoveservice**](ServiceassignmentApi.md#serviceassignmentRemoveservice) | **GET** /serviceassignment/removeservice | Remove a service from a location


<a name="serviceassignmentAddservice"></a>
# **serviceassignmentAddservice**
> serviceassignmentAddservice(serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ServiceassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ServiceassignmentApi apiInstance = new ServiceassignmentApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The id of the service to add.
    UUID locationid = new UUID(); // UUID | The id of the location.
    try {
      apiInstance.serviceassignmentAddservice(serviceid, locationid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ServiceassignmentApi#serviceassignmentAddservice");
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
 **serviceid** | [**UUID**](.md)| The id of the service to add. |
 **locationid** | [**UUID**](.md)| The id of the location. |

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

<a name="serviceassignmentGetlocation"></a>
# **serviceassignmentGetlocation**
> serviceassignmentGetlocation(locationid, includegloballyavailable, namefilter, count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ServiceassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ServiceassignmentApi apiInstance = new ServiceassignmentApi(defaultClient);
    UUID locationid = new UUID(); // UUID | The id of the location to get.
    Boolean includegloballyavailable = true; // Boolean | Specifies whether the services available globally must be returned or not.
    Boolean namefilter = true; // Boolean | Filters the name of the services to return.
    Integer count = 56; // Integer | The max number of services to return.
    try {
      apiInstance.serviceassignmentGetlocation(locationid, includegloballyavailable, namefilter, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling ServiceassignmentApi#serviceassignmentGetlocation");
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
 **locationid** | [**UUID**](.md)| The id of the location to get. |
 **includegloballyavailable** | **Boolean**| Specifies whether the services available globally must be returned or not. | [optional]
 **namefilter** | **Boolean**| Filters the name of the services to return. | [optional]
 **count** | **Integer**| The max number of services to return. | [optional]

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

<a name="serviceassignmentGetservice"></a>
# **serviceassignmentGetservice**
> serviceassignmentGetservice(serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ServiceassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ServiceassignmentApi apiInstance = new ServiceassignmentApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The id of the service to get its locations.
    try {
      apiInstance.serviceassignmentGetservice(serviceid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ServiceassignmentApi#serviceassignmentGetservice");
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

<a name="serviceassignmentRemoveservice"></a>
# **serviceassignmentRemoveservice**
> serviceassignmentRemoveservice(serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ServiceassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ServiceassignmentApi apiInstance = new ServiceassignmentApi(defaultClient);
    UUID serviceid = new UUID(); // UUID | The id of the service to remove.
    UUID locationid = new UUID(); // UUID | The id of the location to remove the service from.
    try {
      apiInstance.serviceassignmentRemoveservice(serviceid, locationid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ServiceassignmentApi#serviceassignmentRemoveservice");
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
 **serviceid** | [**UUID**](.md)| The id of the service to remove. |
 **locationid** | [**UUID**](.md)| The id of the location to remove the service from. |

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

