# ReportscheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportscheduleDelete**](ReportscheduleApi.md#reportscheduleDelete) | **DELETE** /reportschedule/{id} | Delete a report schedule
[**reportscheduleGet**](ReportscheduleApi.md#reportscheduleGet) | **GET** /reportschedule/{id} | Get a report schedule
[**reportscheduleList**](ReportscheduleApi.md#reportscheduleList) | **GET** /reportschedule/list | View a list of the scheduled reports
[**reportscheduleSave**](ReportscheduleApi.md#reportscheduleSave) | **POST** /reportschedule/{id} | Create or edit a report schedule


<a name="reportscheduleDelete"></a>
# **reportscheduleDelete**
> reportscheduleDelete(id, body)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportscheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportscheduleApi apiInstance = new ReportscheduleApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the report schedule to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.reportscheduleDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportscheduleApi#reportscheduleDelete");
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
 **id** | [**UUID**](.md)| The id of the report schedule to delete. |
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

<a name="reportscheduleGet"></a>
# **reportscheduleGet**
> reportscheduleGet(id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportscheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportscheduleApi apiInstance = new ReportscheduleApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the schedule to get.
    try {
      apiInstance.reportscheduleGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportscheduleApi#reportscheduleGet");
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
 **id** | [**UUID**](.md)| The id of the schedule to get. |

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

<a name="reportscheduleList"></a>
# **reportscheduleList**
> reportscheduleList(from, count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportscheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportscheduleApi apiInstance = new ReportscheduleApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.reportscheduleList(from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportscheduleApi#reportscheduleList");
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

<a name="reportscheduleSave"></a>
# **reportscheduleSave**
> reportscheduleSave(id, UNKNOWN_BASE_TYPE)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ReportscheduleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ReportscheduleApi apiInstance = new ReportscheduleApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the schedule save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.reportscheduleSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ReportscheduleApi#reportscheduleSave");
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
 **id** | [**UUID**](.md)| The id of the schedule save (leave empty to create a new one). |
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

