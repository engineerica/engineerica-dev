# ScheduleintegrationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleintegrationClearids**](ScheduleintegrationApi.md#scheduleintegrationClearids) | **GET** /scheduleintegration/clearids | Clear all third party IDs from specified staff member&#39;s schedule items.
[**scheduleintegrationDeleteitem**](ScheduleintegrationApi.md#scheduleintegrationDeleteitem) | **DELETE** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
[**scheduleintegrationDeleteitemsbymasterid**](ScheduleintegrationApi.md#scheduleintegrationDeleteitemsbymasterid) | **DELETE** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**scheduleintegrationGetitem**](ScheduleintegrationApi.md#scheduleintegrationGetitem) | **GET** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
[**scheduleintegrationSaveitem**](ScheduleintegrationApi.md#scheduleintegrationSaveitem) | **POST** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
[**scheduleintegrationSetid**](ScheduleintegrationApi.md#scheduleintegrationSetid) | **GET** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item


<a name="scheduleintegrationClearids"></a>
# **scheduleintegrationClearids**
> scheduleintegrationClearids(staff)

Clear all third party IDs from specified staff member&#39;s schedule items.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleintegrationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleintegrationApi apiInstance = new ScheduleintegrationApi(defaultClient);
    UUID staff = new UUID(); // UUID | The ID of the staff member whose schedule items third party IDs must be cleared.
    try {
      apiInstance.scheduleintegrationClearids(staff);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleintegrationApi#scheduleintegrationClearids");
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
 **staff** | [**UUID**](.md)| The ID of the staff member whose schedule items third party IDs must be cleared. |

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

<a name="scheduleintegrationDeleteitem"></a>
# **scheduleintegrationDeleteitem**
> scheduleintegrationDeleteitem(UNKNOWN_BASE_TYPE)

Delete a schedule item looking up by a third party ID

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleintegrationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleintegrationApi apiInstance = new ScheduleintegrationApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.scheduleintegrationDeleteitem(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleintegrationApi#scheduleintegrationDeleteitem");
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

<a name="scheduleintegrationDeleteitemsbymasterid"></a>
# **scheduleintegrationDeleteitemsbymasterid**
> scheduleintegrationDeleteitemsbymasterid(UNKNOWN_BASE_TYPE)

Delete multiple schedule items looking up by a third party master ID

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleintegrationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleintegrationApi apiInstance = new ScheduleintegrationApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.scheduleintegrationDeleteitemsbymasterid(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleintegrationApi#scheduleintegrationDeleteitemsbymasterid");
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

<a name="scheduleintegrationGetitem"></a>
# **scheduleintegrationGetitem**
> scheduleintegrationGetitem(thirdpartyid)

Get a schedule item looking up by a third party ID

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleintegrationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleintegrationApi apiInstance = new ScheduleintegrationApi(defaultClient);
    String thirdpartyid = "thirdpartyid_example"; // String | The third party id to search for the schedule item.
    try {
      apiInstance.scheduleintegrationGetitem(thirdpartyid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleintegrationApi#scheduleintegrationGetitem");
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
 **thirdpartyid** | **String**| The third party id to search for the schedule item. |

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

<a name="scheduleintegrationSaveitem"></a>
# **scheduleintegrationSaveitem**
> scheduleintegrationSaveitem(UNKNOWN_BASE_TYPE)

Save a schedule item looking up by a third party ID

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleintegrationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleintegrationApi apiInstance = new ScheduleintegrationApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.scheduleintegrationSaveitem(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleintegrationApi#scheduleintegrationSaveitem");
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

<a name="scheduleintegrationSetid"></a>
# **scheduleintegrationSetid**
> scheduleintegrationSetid(id, thirdpartyid, thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ScheduleintegrationApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ScheduleintegrationApi apiInstance = new ScheduleintegrationApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the schedule block / appointment.
    String thirdpartyid = "thirdpartyid_example"; // String | The 3rd party ID to set.
    String thirdpartymasterid = "thirdpartymasterid_example"; // String | The 3rd party master ID to set (useful to handle recurring items).
    try {
      apiInstance.scheduleintegrationSetid(id, thirdpartyid, thirdpartymasterid);
    } catch (ApiException e) {
      System.err.println("Exception when calling ScheduleintegrationApi#scheduleintegrationSetid");
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
 **id** | [**UUID**](.md)| The id of the schedule block / appointment. |
 **thirdpartyid** | **String**| The 3rd party ID to set. |
 **thirdpartymasterid** | **String**| The 3rd party master ID to set (useful to handle recurring items). | [optional]

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

