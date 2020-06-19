# WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**waitinglineAdduser**](WaitinglineApi.md#waitinglineAdduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**waitinglineDelete**](WaitinglineApi.md#waitinglineDelete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**waitinglineGet**](WaitinglineApi.md#waitinglineGet) | **GET** /waitingline/{id} | View details of a waiting line
[**waitinglineIsuserin**](WaitinglineApi.md#waitinglineIsuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitinglineList**](WaitinglineApi.md#waitinglineList) | **GET** /waitingline/list | View a list of waiting lines
[**waitinglineRemoveuser**](WaitinglineApi.md#waitinglineRemoveuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**waitinglineSave**](WaitinglineApi.md#waitinglineSave) | **POST** /waitingline/{id} | Create or edit a waiting line
[**waitinglineSigninuser**](WaitinglineApi.md#waitinglineSigninuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line


<a name="waitinglineAdduser"></a>
# **waitinglineAdduser**
> waitinglineAdduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize)

Put user in a waiting line

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station.
    String user = "user_example"; // String | The user's card number.
    UUID locationid = new UUID(); // UUID | The location's id where the swipe must be saved.
    OffsetDateTime time = new OffsetDateTime(); // OffsetDateTime | The date and time of the swipe.
    String signinrole = "signinrole_example"; // String | Specifies if the sign-in is for an attendee or a staff member
    UUID roleid = new UUID(); // UUID | Specifies the role the user has selected in order to sign-in
    String services = "services_example"; // String | The services ids the user has selected.
    UUID eventid = new UUID(); // UUID | The id of the event the user selected.
    UUID staff = new UUID(); // UUID | The id of the staff member the user selected.
    Integer photosize = 56; // Integer | The swiping user's photo size.
    try {
      apiInstance.waitinglineAdduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineAdduser");
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
 **station** | [**UUID**](.md)| The id of the sign-in station. |
 **user** | **String**| The user&#39;s card number. |
 **locationid** | [**UUID**](.md)| The location&#39;s id where the swipe must be saved. | [optional]
 **time** | **OffsetDateTime**| The date and time of the swipe. | [optional]
 **signinrole** | **String**| Specifies if the sign-in is for an attendee or a staff member | [optional]
 **roleid** | [**UUID**](.md)| Specifies the role the user has selected in order to sign-in | [optional]
 **services** | **String**| The services ids the user has selected. | [optional]
 **eventid** | [**UUID**](.md)| The id of the event the user selected. | [optional]
 **staff** | [**UUID**](.md)| The id of the staff member the user selected. | [optional]
 **photosize** | **Integer**| The swiping user&#39;s photo size. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="waitinglineDelete"></a>
# **waitinglineDelete**
> waitinglineDelete(id, body)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the line to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.waitinglineDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineDelete");
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
 **id** | [**UUID**](.md)| The id of the line to delete. |
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

<a name="waitinglineGet"></a>
# **waitinglineGet**
> waitinglineGet(id, photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the waiting line to get.
    Integer photosize = 56; // Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    try {
      apiInstance.waitinglineGet(id, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineGet");
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
 **id** | [**UUID**](.md)| The id of the waiting line to get. |
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

<a name="waitinglineIsuserin"></a>
# **waitinglineIsuserin**
> waitinglineIsuserin(station, time, user, location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    UUID station = new UUID(); // UUID | The id of the sign-in station.
    OffsetDateTime time = new OffsetDateTime(); // OffsetDateTime | The date and time of the swipe.
    String user = "user_example"; // String | The card number of the user.
    UUID location = new UUID(); // UUID | The id of the location the user picked.
    try {
      apiInstance.waitinglineIsuserin(station, time, user, location);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineIsuserin");
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
 **station** | [**UUID**](.md)| The id of the sign-in station. |
 **time** | **OffsetDateTime**| The date and time of the swipe. |
 **user** | **String**| The card number of the user. |
 **location** | [**UUID**](.md)| The id of the location the user picked. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="waitinglineList"></a>
# **waitinglineList**
> waitinglineList(from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.waitinglineList(from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineList");
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

<a name="waitinglineRemoveuser"></a>
# **waitinglineRemoveuser**
> waitinglineRemoveuser(waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    UUID waitingline = new UUID(); // UUID | The id of the waiting line whose item has to be removed.
    UUID itemid = new UUID(); // UUID | The ID of the item that has to be removed.
    try {
      apiInstance.waitinglineRemoveuser(waitingline, itemid);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineRemoveuser");
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
 **waitingline** | [**UUID**](.md)| The id of the waiting line whose item has to be removed. |
 **itemid** | [**UUID**](.md)| The ID of the item that has to be removed. |

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

<a name="waitinglineSave"></a>
# **waitinglineSave**
> waitinglineSave(id, UNKNOWN_BASE_TYPE)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the waiting line save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.waitinglineSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineSave");
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
 **id** | [**UUID**](.md)| The id of the waiting line save (leave empty to create a new one). |
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

<a name="waitinglineSigninuser"></a>
# **waitinglineSigninuser**
> waitinglineSigninuser(waitingline, itemid, staff, photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.WaitinglineApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    WaitinglineApi apiInstance = new WaitinglineApi(defaultClient);
    UUID waitingline = new UUID(); // UUID | The id of the waiting line whose item needs to be signed-in.
    UUID itemid = new UUID(); // UUID | The ID of the item that has to be signed-in.
    UUID staff = new UUID(); // UUID | The id of the staff member selected to sign-in.
    Integer photosize = 56; // Integer | The swiping user's photo size.
    try {
      apiInstance.waitinglineSigninuser(waitingline, itemid, staff, photosize);
    } catch (ApiException e) {
      System.err.println("Exception when calling WaitinglineApi#waitinglineSigninuser");
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
 **waitingline** | [**UUID**](.md)| The id of the waiting line whose item needs to be signed-in. |
 **itemid** | [**UUID**](.md)| The ID of the item that has to be signed-in. |
 **staff** | [**UUID**](.md)| The id of the staff member selected to sign-in. |
 **photosize** | **Integer**| The swiping user&#39;s photo size. | [optional]

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

