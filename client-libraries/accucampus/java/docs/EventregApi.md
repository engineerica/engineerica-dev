# EventregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventregAddme**](EventregApi.md#eventregAddme) | **GET** /eventreg/addme | Register current user to a course
[**eventregAddmetoall**](EventregApi.md#eventregAddmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
[**eventregAddmetogroup**](EventregApi.md#eventregAddmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
[**eventregAdduser**](EventregApi.md#eventregAdduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
[**eventregAddusertoall**](EventregApi.md#eventregAddusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
[**eventregAddusertogroup**](EventregApi.md#eventregAddusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
[**eventregGetevents**](EventregApi.md#eventregGetevents) | **GET** /eventreg/getevents | View course registration by user
[**eventregGetgroups**](EventregApi.md#eventregGetgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
[**eventregGetmyevents**](EventregApi.md#eventregGetmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
[**eventregGetmygroups**](EventregApi.md#eventregGetmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
[**eventregGetusers**](EventregApi.md#eventregGetusers) | **GET** /eventreg/getusers | View course registration
[**eventregGetusersfromgroup**](EventregApi.md#eventregGetusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**eventregGetuserstoall**](EventregApi.md#eventregGetuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
[**eventregRemoveme**](EventregApi.md#eventregRemoveme) | **GET** /eventreg/removeme | Unregister current user from a course
[**eventregRemovemefromall**](EventregApi.md#eventregRemovemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
[**eventregRemovemefromgroup**](EventregApi.md#eventregRemovemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
[**eventregRemoveuser**](EventregApi.md#eventregRemoveuser) | **GET** /eventreg/removeuser | Remove a user from a course
[**eventregRemoveuserfromall**](EventregApi.md#eventregRemoveuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**eventregRemoveuserfromgroup**](EventregApi.md#eventregRemoveuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group


<a name="eventregAddme"></a>
# **eventregAddme**
> eventregAddme(eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event.
    String listname = "listname_example"; // String | The name of the list where the user has to be registered.
    try {
      apiInstance.eventregAddme(eventid, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregAddme");
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
 **listname** | **String**| The name of the list where the user has to be registered. |

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

<a name="eventregAddmetoall"></a>
# **eventregAddmetoall**
> eventregAddmetoall(listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    String listname = "listname_example"; // String | The name of the list where the user has to be registered.
    try {
      apiInstance.eventregAddmetoall(listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregAddmetoall");
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
 **listname** | **String**| The name of the list where the user has to be registered. |

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

<a name="eventregAddmetogroup"></a>
# **eventregAddmetogroup**
> eventregAddmetogroup(codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    String codegroup = "codegroup_example"; // String | The code used to group events.
    String listname = "listname_example"; // String | The name of the list where the user has to be registered.
    try {
      apiInstance.eventregAddmetogroup(codegroup, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregAddmetogroup");
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
 **codegroup** | **String**| The code used to group events. |
 **listname** | **String**| The name of the list where the user has to be registered. |

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

<a name="eventregAdduser"></a>
# **eventregAdduser**
> eventregAdduser(userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to add.
    UUID eventid = new UUID(); // UUID | The id of the event.
    String listname = "listname_example"; // String | The name of the list where the user has to be registered.
    try {
      apiInstance.eventregAdduser(userid, eventid, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregAdduser");
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
 **listname** | **String**| The name of the list where the user has to be registered. |

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

<a name="eventregAddusertoall"></a>
# **eventregAddusertoall**
> eventregAddusertoall(userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to add.
    String listname = "listname_example"; // String | The name of the list where the user has to be registered.
    try {
      apiInstance.eventregAddusertoall(userid, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregAddusertoall");
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
 **listname** | **String**| The name of the list where the user has to be registered. |

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

<a name="eventregAddusertogroup"></a>
# **eventregAddusertogroup**
> eventregAddusertogroup(userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to add.
    String codegroup = "codegroup_example"; // String | The code used to group events.
    String listname = "listname_example"; // String | The name of the list where the user has to be registered.
    try {
      apiInstance.eventregAddusertogroup(userid, codegroup, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregAddusertogroup");
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
 **codegroup** | **String**| The code used to group events. |
 **listname** | **String**| The name of the list where the user has to be registered. |

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

<a name="eventregGetevents"></a>
# **eventregGetevents**
> eventregGetevents(userid, listname, termid, namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The user id to list events.
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    UUID termid = new UUID(); // UUID | The term id to list events.
    String namefilter = "namefilter_example"; // String | The value used to filter the events by name.
    try {
      apiInstance.eventregGetevents(userid, listname, termid, namefilter);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregGetevents");
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
 **userid** | [**UUID**](.md)| The user id to list events. |
 **listname** | **String**| The name of the list where the user is registered. |
 **termid** | [**UUID**](.md)| The term id to list events. | [optional]
 **namefilter** | **String**| The value used to filter the events by name. | [optional]

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

<a name="eventregGetgroups"></a>
# **eventregGetgroups**
> eventregGetgroups(userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The user id to list events.
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregGetgroups(userid, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregGetgroups");
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
 **userid** | [**UUID**](.md)| The user id to list events. |
 **listname** | **String**| The name of the list where the user is registered. |

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

<a name="eventregGetmyevents"></a>
# **eventregGetmyevents**
> eventregGetmyevents(listname, termid, namefilter)

View the event registrations of the current user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    UUID termid = new UUID(); // UUID | The term id to list events.
    String namefilter = "namefilter_example"; // String | The value used to filter the events by name.
    try {
      apiInstance.eventregGetmyevents(listname, termid, namefilter);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregGetmyevents");
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
 **listname** | **String**| The name of the list where the user is registered. |
 **termid** | [**UUID**](.md)| The term id to list events. | [optional]
 **namefilter** | **String**| The value used to filter the events by name. | [optional]

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

<a name="eventregGetmygroups"></a>
# **eventregGetmygroups**
> eventregGetmygroups(listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregGetmygroups(listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregGetmygroups");
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
 **listname** | **String**| The name of the list where the user is registered. |

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

<a name="eventregGetusers"></a>
# **eventregGetusers**
> eventregGetusers(eventid, listname, photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The event id to list users.
    String listname = "listname_example"; // String | The name of the list to get.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.eventregGetusers(eventid, listname, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregGetusers");
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
 **eventid** | [**UUID**](.md)| The event id to list users. |
 **listname** | **String**| The name of the list to get. |
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

<a name="eventregGetusersfromgroup"></a>
# **eventregGetusersfromgroup**
> eventregGetusersfromgroup(codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID codegroup = new UUID(); // UUID | The code group to list users.
    String listname = "listname_example"; // String | The name of the list to get.
    try {
      apiInstance.eventregGetusersfromgroup(codegroup, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregGetusersfromgroup");
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
 **codegroup** | [**UUID**](.md)| The code group to list users. |
 **listname** | **String**| The name of the list to get. |

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

<a name="eventregGetuserstoall"></a>
# **eventregGetuserstoall**
> eventregGetuserstoall(listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    String listname = "listname_example"; // String | The name of the list to get.
    try {
      apiInstance.eventregGetuserstoall(listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregGetuserstoall");
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
 **listname** | **String**| The name of the list to get. |

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

<a name="eventregRemoveme"></a>
# **eventregRemoveme**
> eventregRemoveme(eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID eventid = new UUID(); // UUID | The id of the event.
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregRemoveme(eventid, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregRemoveme");
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
 **listname** | **String**| The name of the list where the user is registered. |

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

<a name="eventregRemovemefromall"></a>
# **eventregRemovemefromall**
> eventregRemovemefromall(listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregRemovemefromall(listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregRemovemefromall");
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
 **listname** | **String**| The name of the list where the user is registered. |

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

<a name="eventregRemovemefromgroup"></a>
# **eventregRemovemefromgroup**
> eventregRemovemefromgroup(codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID codegroup = new UUID(); // UUID | The code group of the events/courses.
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregRemovemefromgroup(codegroup, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregRemovemefromgroup");
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
 **codegroup** | [**UUID**](.md)| The code group of the events/courses. |
 **listname** | **String**| The name of the list where the user is registered. |

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

<a name="eventregRemoveuser"></a>
# **eventregRemoveuser**
> eventregRemoveuser(userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course&#39;s registration.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    UUID eventid = new UUID(); // UUID | The id of the event.
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregRemoveuser(userid, eventid, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregRemoveuser");
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
 **listname** | **String**| The name of the list where the user is registered. |

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

<a name="eventregRemoveuserfromall"></a>
# **eventregRemoveuserfromall**
> eventregRemoveuserfromall(userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregRemoveuserfromall(userid, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregRemoveuserfromall");
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
 **listname** | **String**| The name of the list where the user is registered. |

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

<a name="eventregRemoveuserfromgroup"></a>
# **eventregRemoveuserfromgroup**
> eventregRemoveuserfromgroup(userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.EventregApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    EventregApi apiInstance = new EventregApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    UUID codegroup = new UUID(); // UUID | The code group of the events/courses.
    String listname = "listname_example"; // String | The name of the list where the user is registered.
    try {
      apiInstance.eventregRemoveuserfromgroup(userid, codegroup, listname);
    } catch (ApiException e) {
      System.err.println("Exception when calling EventregApi#eventregRemoveuserfromgroup");
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
 **codegroup** | [**UUID**](.md)| The code group of the events/courses. |
 **listname** | **String**| The name of the list where the user is registered. |

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

