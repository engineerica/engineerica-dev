# EventApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventChecksessions**](EventApi.md#eventChecksessions) | **GET** /event/checksessions | Edit an event&#39;s sessions according to their schedule
[**eventDelete**](EventApi.md#eventDelete) | **DELETE** /event/{id} | Delete a course
[**eventGet**](EventApi.md#eventGet) | **GET** /event/{id} | Search and view details of a course
[**eventGetsessionsbydate**](EventApi.md#eventGetsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
[**eventList**](EventApi.md#eventList) | **GET** /event/list | View a list of courses
[**eventListregistered**](EventApi.md#eventListregistered) | **GET** /event/listregistered | View a list of courses I am registered to
[**eventSave**](EventApi.md#eventSave) | **POST** /event/{id} | Create or edit a course
[**eventSearchgroup**](EventApi.md#eventSearchgroup) | **GET** /event/searchgroup | Searches for the available event groups


<a name="eventChecksessions"></a>
# **eventChecksessions**
> eventChecksessions(eventid, autorepair)

Edit an event&#39;s sessions according to their schedule

Allows the user to edit event sessions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event to check.
    Boolean autorepair = true; // Boolean | True to automatically fix the invalid sessions.
    try {
      apiInstance.eventChecksessions(eventid, autorepair);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventChecksessions");
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
 **eventid** | [**UUID**](.md)| The id of the event to check. |
 **autorepair** | **Boolean**| True to automatically fix the invalid sessions. |

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

<a name="eventDelete"></a>
# **eventDelete**
> eventDelete(id, body)

Delete a course

Allows the user to delete an existing course.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the event to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.eventDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventDelete");
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
 **id** | [**UUID**](.md)| The id of the event to delete. |
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

<a name="eventGet"></a>
# **eventGet**
> eventGet(id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the event to get.
    try {
      apiInstance.eventGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventGet");
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
 **id** | [**UUID**](.md)| The id of the event to get. |

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

<a name="eventGetsessionsbydate"></a>
# **eventGetsessionsbydate**
> eventGetsessionsbydate(location, date, type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    UUID location = new UUID(); // UUID | The location to filter the events.
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | The date to filter the events. Today will be used if this parameter is omitted.
    String type = "type_example"; // String | Type of event to list.
    try {
      apiInstance.eventGetsessionsbydate(location, date, type);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventGetsessionsbydate");
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
 **location** | [**UUID**](.md)| The location to filter the events. | [optional]
 **date** | **OffsetDateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional]
 **type** | **String**| Type of event to list. | [optional]

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

<a name="eventList"></a>
# **eventList**
> eventList(from, count, summaryonly, termid)

View a list of courses

Allows the user to view the full list of courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    String from = "from_example"; // String | The first record to return.
    String count = "count_example"; // String | The max number of records to return.
    Boolean summaryonly = true; // Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
    UUID termid = new UUID(); // UUID | Id of the term to list the events. Null to list all events.
    try {
      apiInstance.eventList(from, count, summaryonly, termid);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventList");
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
 **from** | **String**| The first record to return. |
 **count** | **String**| The max number of records to return. |
 **summaryonly** | **Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**UUID**](.md)| Id of the term to list the events. Null to list all events. | [optional]

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

<a name="eventListregistered"></a>
# **eventListregistered**
> eventListregistered(from, count, summaryonly, termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    String from = "from_example"; // String | The first record to return.
    String count = "count_example"; // String | The max number of records to return.
    Boolean summaryonly = true; // Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
    UUID termid = new UUID(); // UUID | Id of the term to list the events. Null to list all events.
    try {
      apiInstance.eventListregistered(from, count, summaryonly, termid);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventListregistered");
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
 **from** | **String**| The first record to return. |
 **count** | **String**| The max number of records to return. |
 **summaryonly** | **Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**UUID**](.md)| Id of the term to list the events. Null to list all events. | [optional]

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

<a name="eventSave"></a>
# **eventSave**
> eventSave(id, UNKNOWN_BASE_TYPE)

Create or edit a course

Allows the user to create or edit a course.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the event to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.eventSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventSave");
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
 **id** | [**UUID**](.md)| The id of the event to save (leave empty to create a new one). |
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

<a name="eventSearchgroup"></a>
# **eventSearchgroup**
> eventSearchgroup(query)

Searches for the available event groups

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventApi apiInstance = new EventApi(defaultClient);
    UUID query = new UUID(); // UUID | Query to search event groups.
    try {
      apiInstance.eventSearchgroup(query);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventApi#eventSearchgroup");
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
 **query** | [**UUID**](.md)| Query to search event groups. |

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

