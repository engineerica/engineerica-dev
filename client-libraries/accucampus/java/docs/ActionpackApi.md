# ActionpackApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionpackAssign**](ActionpackApi.md#actionpackAssign) | **GET** /actionpack/assign | Assign an action item pack to a user
[**actionpackDelete**](ActionpackApi.md#actionpackDelete) | **DELETE** /actionpack/{id} | Delete an action item pack
[**actionpackGet**](ActionpackApi.md#actionpackGet) | **GET** /actionpack/{id} | View details of an action item pack
[**actionpackList**](ActionpackApi.md#actionpackList) | **GET** /actionpack/list | View a list of action item packs
[**actionpackSave**](ActionpackApi.md#actionpackSave) | **POST** /actionpack/{id} | Create or edit an action item pack


<a name="actionpackAssign"></a>
# **actionpackAssign**
> actionpackAssign(pack, itemsdata, assignee, group, notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionpackApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionpackApi apiInstance = new ActionpackApi(defaultClient);
    UUID pack = new UUID(); // UUID | The id of the action pack to assign.
    Boolean itemsdata = true; // Boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
    UUID assignee = new UUID(); // UUID | The assignee of the pack.
    UUID group = new UUID(); // UUID | The group to assign the pack.
    String notes = "notes_example"; // String | The assignment's notes.
    try {
      apiInstance.actionpackAssign(pack, itemsdata, assignee, group, notes);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionpackApi#actionpackAssign");
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
 **pack** | [**UUID**](.md)| The id of the action pack to assign. |
 **itemsdata** | **Boolean**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). |
 **assignee** | [**UUID**](.md)| The assignee of the pack. | [optional]
 **group** | [**UUID**](.md)| The group to assign the pack. | [optional]
 **notes** | **String**| The assignment&#39;s notes. | [optional]

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

<a name="actionpackDelete"></a>
# **actionpackDelete**
> actionpackDelete(id, body)

Delete an action item pack

Allows the user to delete an action item pack.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionpackApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionpackApi apiInstance = new ActionpackApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the action pack to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.actionpackDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionpackApi#actionpackDelete");
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
 **id** | [**UUID**](.md)| The id of the action pack to delete. |
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

<a name="actionpackGet"></a>
# **actionpackGet**
> actionpackGet(id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionpackApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionpackApi apiInstance = new ActionpackApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the action pack to get.
    try {
      apiInstance.actionpackGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionpackApi#actionpackGet");
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
 **id** | [**UUID**](.md)| The id of the action pack to get. |

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

<a name="actionpackList"></a>
# **actionpackList**
> actionpackList(from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionpackApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionpackApi apiInstance = new ActionpackApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    try {
      apiInstance.actionpackList(from, count);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionpackApi#actionpackList");
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

<a name="actionpackSave"></a>
# **actionpackSave**
> actionpackSave(id, UNKNOWN_BASE_TYPE)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionpackApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionpackApi apiInstance = new ActionpackApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the action pack to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.actionpackSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionpackApi#actionpackSave");
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
 **id** | [**UUID**](.md)| The id of the action pack to save (leave empty to create a new one). |
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

