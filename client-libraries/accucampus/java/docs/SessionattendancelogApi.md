# SessionattendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionattendancelogAddnote**](SessionattendancelogApi.md#sessionattendancelogAddnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
[**sessionattendancelogGet**](SessionattendancelogApi.md#sessionattendancelogGet) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
[**sessionattendancelogGetuser**](SessionattendancelogApi.md#sessionattendancelogGetuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**sessionattendancelogList**](SessionattendancelogApi.md#sessionattendancelogList) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
[**sessionattendancelogListevent**](SessionattendancelogApi.md#sessionattendancelogListevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
[**sessionattendancelogListsummary**](SessionattendancelogApi.md#sessionattendancelogListsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**sessionattendancelogMylistsummary**](SessionattendancelogApi.md#sessionattendancelogMylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
[**sessionattendancelogSave**](SessionattendancelogApi.md#sessionattendancelogSave) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
[**sessionattendancelogSaveswipe**](SessionattendancelogApi.md#sessionattendancelogSaveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe


<a name="sessionattendancelogAddnote"></a>
# **sessionattendancelogAddnote**
> sessionattendancelogAddnote(id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the attendance log.
    String text = "text_example"; // String | The text of the note to add.
    try {
      apiInstance.sessionattendancelogAddnote(id, text);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogAddnote");
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
 **id** | [**UUID**](.md)| The id of the attendance log. |
 **text** | **String**| The text of the note to add. |

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

<a name="sessionattendancelogGet"></a>
# **sessionattendancelogGet**
> sessionattendancelogGet(id, photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the attendance log to get.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.sessionattendancelogGet(id, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogGet");
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
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional]

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

<a name="sessionattendancelogGetuser"></a>
# **sessionattendancelogGetuser**
> sessionattendancelogGetuser(attendee, eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID attendee = new UUID(); // UUID | The id of the attendee to get statistic for.
    UUID eventid = new UUID(); // UUID | The id of the event whose attendee statistics have to be returned.
    try {
      apiInstance.sessionattendancelogGetuser(attendee, eventid);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogGetuser");
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
 **attendee** | [**UUID**](.md)| The id of the attendee to get statistic for. |
 **eventid** | [**UUID**](.md)| The id of the event whose attendee statistics have to be returned. |

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

<a name="sessionattendancelogList"></a>
# **sessionattendancelogList**
> sessionattendancelogList(session, from, count, photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID session = new UUID(); // UUID | The id of the session whose attendees logs have to be returned.
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.sessionattendancelogList(session, from, count, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogList");
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
 **session** | [**UUID**](.md)| The id of the session whose attendees logs have to be returned. |
 **from** | **Integer**| The first record to return. |
 **count** | **Integer**| The max number of records to return. |
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

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

<a name="sessionattendancelogListevent"></a>
# **sessionattendancelogListevent**
> sessionattendancelogListevent(eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event whose attendance has to be returned.
    try {
      apiInstance.sessionattendancelogListevent(eventid);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogListevent");
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
 **eventid** | [**UUID**](.md)| The id of the event whose attendance has to be returned. |

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

<a name="sessionattendancelogListsummary"></a>
# **sessionattendancelogListsummary**
> sessionattendancelogListsummary(eventid, attendeeid, groupid, start, end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event whose attendance has to be returned.
    UUID attendeeid = new UUID(); // UUID | The id of the attendee whose attendance has to be returned.
    UUID groupid = new UUID(); // UUID | The id of the group whose attendance has to be returned.
    String start = "start_example"; // String | The start date to filter (beginning of time by default).
    String end = "end_example"; // String | The end date to filter (today by default).
    try {
      apiInstance.sessionattendancelogListsummary(eventid, attendeeid, groupid, start, end);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogListsummary");
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
 **eventid** | [**UUID**](.md)| The id of the event whose attendance has to be returned. | [optional]
 **attendeeid** | [**UUID**](.md)| The id of the attendee whose attendance has to be returned. | [optional]
 **groupid** | [**UUID**](.md)| The id of the group whose attendance has to be returned. | [optional]
 **start** | **String**| The start date to filter (beginning of time by default). | [optional]
 **end** | **String**| The end date to filter (today by default). | [optional]

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

<a name="sessionattendancelogMylistsummary"></a>
# **sessionattendancelogMylistsummary**
> sessionattendancelogMylistsummary(eventid, start, end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event whose attendance has to be returned.
    String start = "start_example"; // String | The start date to filter (beginning of time by default).
    String end = "end_example"; // String | The end date to filter (today by default).
    try {
      apiInstance.sessionattendancelogMylistsummary(eventid, start, end);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogMylistsummary");
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
 **eventid** | [**UUID**](.md)| The id of the event whose attendance has to be returned. | [optional]
 **start** | **String**| The start date to filter (beginning of time by default). | [optional]
 **end** | **String**| The end date to filter (today by default). | [optional]

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

<a name="sessionattendancelogSave"></a>
# **sessionattendancelogSave**
> sessionattendancelogSave(id, UNKNOWN_BASE_TYPE)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the att log to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.sessionattendancelogSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogSave");
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
 **id** | [**UUID**](.md)| The id of the att log to save (leave empty to create a new one). |
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

<a name="sessionattendancelogSaveswipe"></a>
# **sessionattendancelogSaveswipe**
> sessionattendancelogSaveswipe(UNKNOWN_BASE_TYPE)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionattendancelogApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionattendancelogApi apiInstance = new SessionattendancelogApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.sessionattendancelogSaveswipe(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionattendancelogApi#sessionattendancelogSaveswipe");
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

