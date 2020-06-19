# SessionregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionregAddcurrentuser**](SessionregApi.md#sessionregAddcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
[**sessionregAdduser**](SessionregApi.md#sessionregAdduser) | **GET** /sessionreg/adduser | Register users for events
[**sessionregGetmysessions**](SessionregApi.md#sessionregGetmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
[**sessionregGetsessions**](SessionregApi.md#sessionregGetsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
[**sessionregGetsettings**](SessionregApi.md#sessionregGetsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
[**sessionregGetusers**](SessionregApi.md#sessionregGetusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
[**sessionregListsessions**](SessionregApi.md#sessionregListsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
[**sessionregListupcoming**](SessionregApi.md#sessionregListupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
[**sessionregListupcomingevent**](SessionregApi.md#sessionregListupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
[**sessionregRemovecurrentuser**](SessionregApi.md#sessionregRemovecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
[**sessionregRemoveuser**](SessionregApi.md#sessionregRemoveuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
[**sessionregSavesettings**](SessionregApi.md#sessionregSavesettings) | **POST** /sessionreg/savesettings | Save the settings for an event&#39;s session registration


<a name="sessionregAddcurrentuser"></a>
# **sessionregAddcurrentuser**
> sessionregAddcurrentuser(eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregAddcurrentuser(eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregAddcurrentuser");
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
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

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

<a name="sessionregAdduser"></a>
# **sessionregAdduser**
> sessionregAdduser(userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to add.
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregAdduser(userid, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregAdduser");
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
 **userid** | [**UUID**](.md)| The id of the user to add. |
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

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

<a name="sessionregGetmysessions"></a>
# **sessionregGetmysessions**
> sessionregGetmysessions(date)

View all the sessions the logged user is registered to

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | Start date to filter the sessions.
    try {
      apiInstance.sessionregGetmysessions(date);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregGetmysessions");
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
 **date** | **OffsetDateTime**| Start date to filter the sessions. | [optional]

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

<a name="sessionregGetsessions"></a>
# **sessionregGetsessions**
> sessionregGetsessions(userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The user id to list sessions.
    try {
      apiInstance.sessionregGetsessions(userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregGetsessions");
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
 **userid** | [**UUID**](.md)| The user id to list sessions. |

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

<a name="sessionregGetsettings"></a>
# **sessionregGetsettings**
> sessionregGetsettings(locationid, eventid, sessiondate, noinherit)

Get the settings for session registration

Allows the user to view a event&#39;s session registration settings.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID locationid = new UUID(); // UUID | The id of the location to save settings.
    UUID eventid = new UUID(); // UUID | The id of the event to save settings.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    Boolean noinherit = true; // Boolean | True to get the location/event/session specific settings without looking for the more global settings.
    try {
      apiInstance.sessionregGetsettings(locationid, eventid, sessiondate, noinherit);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregGetsettings");
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
 **locationid** | [**UUID**](.md)| The id of the location to save settings. | [optional]
 **eventid** | [**UUID**](.md)| The id of the event to save settings. | [optional]
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. | [optional]
 **noinherit** | **Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional]

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

<a name="sessionregGetusers"></a>
# **sessionregGetusers**
> sessionregGetusers(eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The event id to list sessions.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date of the session to find.
    try {
      apiInstance.sessionregGetusers(eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregGetusers");
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
 **eventid** | [**UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **OffsetDateTime**| The date of the session to find. |

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

<a name="sessionregListsessions"></a>
# **sessionregListsessions**
> sessionregListsessions(eventid, sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The event id to list sessions.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date of the session to find.
    try {
      apiInstance.sessionregListsessions(eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregListsessions");
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
 **eventid** | [**UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **OffsetDateTime**| The date of the session to find. | [optional]

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

<a name="sessionregListupcoming"></a>
# **sessionregListupcoming**
> sessionregListupcoming(date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | Only sessions in the week of the specified date will be returned.
    try {
      apiInstance.sessionregListupcoming(date);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregListupcoming");
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
 **date** | **OffsetDateTime**| Only sessions in the week of the specified date will be returned. |

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

<a name="sessionregListupcomingevent"></a>
# **sessionregListupcomingevent**
> sessionregListupcomingevent(date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    OffsetDateTime date = new OffsetDateTime(); // OffsetDateTime | Start date to filter the returned sessions.
    UUID event = new UUID(); // UUID | The id of the event whose sessions will be returned
    try {
      apiInstance.sessionregListupcomingevent(date, event);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregListupcomingevent");
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
 **date** | **OffsetDateTime**| Start date to filter the returned sessions. |
 **event** | [**UUID**](.md)| The id of the event whose sessions will be returned |

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

<a name="sessionregRemovecurrentuser"></a>
# **sessionregRemovecurrentuser**
> sessionregRemovecurrentuser(eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregRemovecurrentuser(eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregRemovecurrentuser");
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
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

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

<a name="sessionregRemoveuser"></a>
# **sessionregRemoveuser**
> sessionregRemoveuser(userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    UUID eventid = new UUID(); // UUID | The id of the event.
    OffsetDateTime sessiondate = new OffsetDateTime(); // OffsetDateTime | The date and time when the session starts.
    try {
      apiInstance.sessionregRemoveuser(userid, eventid, sessiondate);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregRemoveuser");
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
 **userid** | [**UUID**](.md)| The id of the user to remove. |
 **eventid** | [**UUID**](.md)| The id of the event. |
 **sessiondate** | **OffsetDateTime**| The date and time when the session starts. |

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

<a name="sessionregSavesettings"></a>
# **sessionregSavesettings**
> sessionregSavesettings(UNKNOWN_BASE_TYPE)

Save the settings for an event&#39;s session registration

Allows the user to save the settings for an event.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.SessionregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    SessionregApi apiInstance = new SessionregApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.sessionregSavesettings(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling SessionregApi#sessionregSavesettings");
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

