# AttendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogDelete**](AttendancelogApi.md#attendancelogDelete) | **DELETE** /attendancelog/{id} | Delete an attendance log
[**attendancelogGet**](AttendancelogApi.md#attendancelogGet) | **GET** /attendancelog/{id} | Search and view details of an attendance log
[**attendancelogGetchangehistory**](AttendancelogApi.md#attendancelogGetchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**attendancelogList**](AttendancelogApi.md#attendancelogList) | **GET** /attendancelog/list | View a list of attendance logs
[**attendancelogListmine**](AttendancelogApi.md#attendancelogListmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
[**attendancelogListstaff**](AttendancelogApi.md#attendancelogListstaff) | **GET** /attendancelog/liststaff | Gets the attendance logs that the current user is involved in as staff
[**attendancelogSave**](AttendancelogApi.md#attendancelogSave) | **POST** /attendancelog/{id} | Create or edit an attendance log
[**attendancelogSignout**](AttendancelogApi.md#attendancelogSignout) | **GET** /attendancelog/signout | Sign out an attendance log
[**attendancelogWhosin**](AttendancelogApi.md#attendancelogWhosin) | **GET** /attendancelog/whosin | View who&#39;s in a location


<a name="attendancelogDelete"></a>
# **attendancelogDelete**
> attendancelogDelete(id, body)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the attendance log to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.attendancelogDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogDelete");
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
 **id** | [**UUID**](.md)| The id of the attendance log to delete. |
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

<a name="attendancelogGet"></a>
# **attendancelogGet**
> attendancelogGet(id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the attendance log to get.
    try {
      apiInstance.attendancelogGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogGet");
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
 **id** | [**UUID**](.md)| The id of the attendance log to get. |

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

<a name="attendancelogGetchangehistory"></a>
# **attendancelogGetchangehistory**
> attendancelogGetchangehistory(id)

Search and view details of an attendance log&#39;s swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the attendance log to get.
    try {
      apiInstance.attendancelogGetchangehistory(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogGetchangehistory");
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
 **id** | [**UUID**](.md)| The id of the attendance log to get. |

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

<a name="attendancelogList"></a>
# **attendancelogList**
> attendancelogList(from, count, filter, userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String filter = "filter_example"; // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
    UUID userid = new UUID(); // UUID | The user ID of the user to get the logs.
    try {
      apiInstance.attendancelogList(from, count, filter, userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogList");
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
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]
 **userid** | [**UUID**](.md)| The user ID of the user to get the logs. | [optional]

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

<a name="attendancelogListmine"></a>
# **attendancelogListmine**
> attendancelogListmine(from, count, filter)

Gets the attendance logs of the current user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String filter = "filter_example"; // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
    try {
      apiInstance.attendancelogListmine(from, count, filter);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogListmine");
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
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]

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

<a name="attendancelogListstaff"></a>
# **attendancelogListstaff**
> attendancelogListstaff(from, count, filter)

Gets the attendance logs that the current user is involved in as staff

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String filter = "filter_example"; // String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
    try {
      apiInstance.attendancelogListstaff(from, count, filter);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogListstaff");
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
 **filter** | **String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]

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

<a name="attendancelogSave"></a>
# **attendancelogSave**
> attendancelogSave(id, UNKNOWN_BASE_TYPE)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the room to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.attendancelogSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogSave");
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
 **id** | [**UUID**](.md)| The id of the room to save (leave empty to create a new one). |
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

<a name="attendancelogSignout"></a>
# **attendancelogSignout**
> attendancelogSignout(id, location, event, datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who&#39;s In page.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the attendance log to sign-out.
    UUID location = new UUID(); // UUID | The id of the location to filter the users to sign out.
    UUID event = new UUID(); // UUID | The id of the event to filter the users to sign out.
    OffsetDateTime datetime = new OffsetDateTime(); // OffsetDateTime | Specifies the date and time when the specified logs have to be signed out.
    try {
      apiInstance.attendancelogSignout(id, location, event, datetime);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogSignout");
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
 **id** | [**UUID**](.md)| The id of the attendance log to sign-out. | [optional]
 **location** | [**UUID**](.md)| The id of the location to filter the users to sign out. | [optional]
 **event** | [**UUID**](.md)| The id of the event to filter the users to sign out. | [optional]
 **datetime** | **OffsetDateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional]

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

<a name="attendancelogWhosin"></a>
# **attendancelogWhosin**
> attendancelogWhosin(from, count, location, event, sorting, roles, photosize, extensions, export)

View who&#39;s in a location

Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AttendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AttendancelogApi apiInstance = new AttendancelogApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    UUID location = new UUID(); // UUID | The id of the location to search for users that are in.
    UUID event = new UUID(); // UUID | The id of the event to search for users that are in.
    String sorting = "sorting_example"; // String | Field to sort by. Either first-name, last-name or sign-in-time.
    String roles = "roles_example"; // String | The comma-separated list of ids of the roles to search for users that are in.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    String extensions = "extensions_example"; // String | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
    Boolean export = true; // Boolean | True to export the results as CSV
    try {
      apiInstance.attendancelogWhosin(from, count, location, event, sorting, roles, photosize, extensions, export);
    } catch (ApiException e) {
      System.err.println("Exception when calling AttendancelogApi#attendancelogWhosin");
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
 **location** | [**UUID**](.md)| The id of the location to search for users that are in. | [optional]
 **event** | [**UUID**](.md)| The id of the event to search for users that are in. | [optional]
 **sorting** | **String**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional]
 **roles** | **String**| The comma-separated list of ids of the roles to search for users that are in. | [optional]
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **extensions** | **String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional]
 **export** | **Boolean**| True to export the results as CSV | [optional]

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

