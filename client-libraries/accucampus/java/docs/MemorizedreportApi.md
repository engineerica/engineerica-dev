# MemorizedreportApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**memorizedreportDelete**](MemorizedreportApi.md#memorizedreportDelete) | **DELETE** /memorizedreport/{id} | Delete memorized report
[**memorizedreportGet**](MemorizedreportApi.md#memorizedreportGet) | **GET** /memorizedreport/{id} | View details of a memorized report
[**memorizedreportList**](MemorizedreportApi.md#memorizedreportList) | **GET** /memorizedreport/list | View a list of all his memorized reports
[**memorizedreportSave**](MemorizedreportApi.md#memorizedreportSave) | **POST** /memorizedreport/{id} | Create or edit a memorized report


<a name="memorizedreportDelete"></a>
# **memorizedreportDelete**
> memorizedreportDelete(id, body)

Delete memorized report

Allows the user to delete a memorized report that they have created.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MemorizedreportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MemorizedreportApi apiInstance = new MemorizedreportApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the report settings to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.memorizedreportDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling MemorizedreportApi#memorizedreportDelete");
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
 **id** | [**UUID**](.md)| The id of the report settings to delete. |
 **body** | **oas_any_type_not_mapped**|  | [optional]

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

<a name="memorizedreportGet"></a>
# **memorizedreportGet**
> memorizedreportGet(id)

View details of a memorized report

Allows the user to view an individual memorized report and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MemorizedreportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MemorizedreportApi apiInstance = new MemorizedreportApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the report configuration to get.
    try {
      apiInstance.memorizedreportGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling MemorizedreportApi#memorizedreportGet");
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
 **id** | [**UUID**](.md)| The id of the report configuration to get. |

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

<a name="memorizedreportList"></a>
# **memorizedreportList**
> memorizedreportList(from, count, customname)

View a list of all his memorized reports

Allows the user to view the list of all memorized reports that they have created.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MemorizedreportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MemorizedreportApi apiInstance = new MemorizedreportApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String customname = "customname_example"; // String | If specified filters the memorized reports by custom name.
    try {
      apiInstance.memorizedreportList(from, count, customname);
    } catch (ApiException e) {
      System.err.println("Exception when calling MemorizedreportApi#memorizedreportList");
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
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **customname** | **String**| If specified filters the memorized reports by custom name. | [optional]

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

<a name="memorizedreportSave"></a>
# **memorizedreportSave**
> memorizedreportSave(id, UNKNOWN_BASE_TYPE)

Create or edit a memorized report

Allows the user to create or edit a memorized report for themselves.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.MemorizedreportApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    MemorizedreportApi apiInstance = new MemorizedreportApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the report settings to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.memorizedreportSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling MemorizedreportApi#memorizedreportSave");
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
 **id** | [**UUID**](.md)| The id of the report settings to save (leave empty to create a new one). |
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

