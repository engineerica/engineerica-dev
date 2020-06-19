# AttendancelogcommentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogcommentDelete**](AttendancelogcommentApi.md#attendancelogcommentDelete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**attendancelogcommentGet**](AttendancelogcommentApi.md#attendancelogcommentGet) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
[**attendancelogcommentList**](AttendancelogcommentApi.md#attendancelogcommentList) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
[**attendancelogcommentSave**](AttendancelogcommentApi.md#attendancelogcommentSave) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log


<a name="attendancelogcommentDelete"></a>
# **attendancelogcommentDelete**
> attendancelogcommentDelete(id, body)

Delete a comment on an attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogcommentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogcommentApi apiInstance = new AttendancelogcommentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the attendance log comment to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.attendancelogcommentDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogcommentApi#attendancelogcommentDelete");
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
 **id** | [**UUID**](.md)| The id of the attendance log comment to delete. |
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

<a name="attendancelogcommentGet"></a>
# **attendancelogcommentGet**
> attendancelogcommentGet(id)

View a comment on an attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogcommentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogcommentApi apiInstance = new AttendancelogcommentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the comment to get.
    try {
      apiInstance.attendancelogcommentGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogcommentApi#attendancelogcommentGet");
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
 **id** | [**UUID**](.md)| The id of the comment to get. |

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

<a name="attendancelogcommentList"></a>
# **attendancelogcommentList**
> attendancelogcommentList(attendancelog)

View all the comments on a specific attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogcommentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogcommentApi apiInstance = new AttendancelogcommentApi(defaultClient);
    UUID attendancelog = new UUID(); // UUID | The id of the attendance log whose comments have to be retrieved.
    try {
      apiInstance.attendancelogcommentList(attendancelog);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogcommentApi#attendancelogcommentList");
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
 **attendancelog** | [**UUID**](.md)| The id of the attendance log whose comments have to be retrieved. |

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

<a name="attendancelogcommentSave"></a>
# **attendancelogcommentSave**
> attendancelogcommentSave(id, UNKNOWN_BASE_TYPE)

Save a comment on an attendance log

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogcommentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogcommentApi apiInstance = new AttendancelogcommentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the comment to edit (leave empty to create a new one)
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.attendancelogcommentSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogcommentApi#attendancelogcommentSave");
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
 **id** | [**UUID**](.md)| The id of the comment to edit (leave empty to create a new one) |
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

