# SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionBulkupdate**](SessionApi.md#sessionBulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**sessionGet**](SessionApi.md#sessionGet) | **GET** /session/{id} | View details of a session
[**sessionGetschedule**](SessionApi.md#sessionGetschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**sessionList**](SessionApi.md#sessionList) | **GET** /session/list | Gets all future sessions of the current semester


<a name="sessionBulkupdate"></a>
# **sessionBulkupdate**
> sessionBulkupdate(eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionApi apiInstance = new SessionApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event to bulk update.
    String sessions = "sessions_example"; // String | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.
    try {
      apiInstance.sessionBulkupdate(eventid, sessions);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionApi#sessionBulkupdate");
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
 **eventid** | [**UUID**](.md)| The id of the event to bulk update. |
 **sessions** | **String**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. |

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

<a name="sessionGet"></a>
# **sessionGet**
> sessionGet(id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionApi apiInstance = new SessionApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the session to get.
    try {
      apiInstance.sessionGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionApi#sessionGet");
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
 **id** | [**UUID**](.md)| The id of the session to get. |

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

<a name="sessionGetschedule"></a>
# **sessionGetschedule**
> sessionGetschedule(day, attendee, location, instructor)

Gets the schedule for a location, instructor or attendees

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionApi apiInstance = new SessionApi(defaultClient);
    OffsetDateTime day = new OffsetDateTime(); // OffsetDateTime | The day to return. It will also return the whole week for that day.
    UUID attendee = new UUID(); // UUID | The id of the attendee to get the schedule.
    UUID location = new UUID(); // UUID | The id of the location to get the schedule.
    UUID instructor = new UUID(); // UUID | The id of the instructor to get the schedule.
    try {
      apiInstance.sessionGetschedule(day, attendee, location, instructor);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionApi#sessionGetschedule");
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
 **day** | **OffsetDateTime**| The day to return. It will also return the whole week for that day. | [optional]
 **attendee** | [**UUID**](.md)| The id of the attendee to get the schedule. | [optional]
 **location** | [**UUID**](.md)| The id of the location to get the schedule. | [optional]
 **instructor** | [**UUID**](.md)| The id of the instructor to get the schedule. | [optional]

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

<a name="sessionList"></a>
# **sessionList**
> sessionList(from, count, startdate, enddate)

Gets all future sessions of the current semester

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionApi apiInstance = new SessionApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    OffsetDateTime startdate = new OffsetDateTime(); // OffsetDateTime | The start date to filter the sessions
    OffsetDateTime enddate = new OffsetDateTime(); // OffsetDateTime | The end date to filter the sessions.
    try {
      apiInstance.sessionList(from, count, startdate, enddate);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionApi#sessionList");
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
 **startdate** | **OffsetDateTime**| The start date to filter the sessions | [optional]
 **enddate** | **OffsetDateTime**| The end date to filter the sessions. | [optional]

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

