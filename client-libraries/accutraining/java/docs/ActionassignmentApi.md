# ActionassignmentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionassignmentDelete**](ActionassignmentApi.md#actionassignmentDelete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
[**actionassignmentGet**](ActionassignmentApi.md#actionassignmentGet) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**actionassignmentList**](ActionassignmentApi.md#actionassignmentList) | **GET** /actionassignment/list | View a list of action items in a user&#39;s plan
[**actionassignmentListhistory**](ActionassignmentApi.md#actionassignmentListhistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
[**actionassignmentListmine**](ActionassignmentApi.md#actionassignmentListmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
[**actionassignmentListpublichistory**](ActionassignmentApi.md#actionassignmentListpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
[**actionassignmentMarkcomplete**](ActionassignmentApi.md#actionassignmentMarkcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
[**actionassignmentSave**](ActionassignmentApi.md#actionassignmentSave) | **POST** /actionassignment/save | Add an action item to a user&#39;s action plan
[**actionassignmentSavehistory**](ActionassignmentApi.md#actionassignmentSavehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user


<a name="actionassignmentDelete"></a>
# **actionassignmentDelete**
> actionassignmentDelete(id, body)

Remove an action item from an action plan

Allows a user to remove an action item from a user&#39;s action plan.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the action assignment to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.actionassignmentDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentDelete");
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
 **id** | [**UUID**](.md)| The id of the action assignment to delete. |
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

<a name="actionassignmentGet"></a>
# **actionassignmentGet**
> actionassignmentGet(id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the action assignment to get.
    try {
      apiInstance.actionassignmentGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentGet");
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
 **id** | [**UUID**](.md)| The id of the action assignment to get. |

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

<a name="actionassignmentList"></a>
# **actionassignmentList**
> actionassignmentList(from, count, assignee, status)

View a list of action items in a user&#39;s plan

Allows the user to view the list of all action items for a specified user.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Integer assignee = 56; // Integer | The assignee's id to filter the assignments.
    Integer status = 56; // Integer | The status to filter the assignments.
    try {
      apiInstance.actionassignmentList(from, count, assignee, status);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentList");
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
 **assignee** | **Integer**| The assignee&#39;s id to filter the assignments. | [optional]
 **status** | **Integer**| The status to filter the assignments. | [optional]

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

<a name="actionassignmentListhistory"></a>
# **actionassignmentListhistory**
> actionassignmentListhistory(actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    UUID actionassignment = new UUID(); // UUID | The action assignment's id whose history the user wants to get.
    try {
      apiInstance.actionassignmentListhistory(actionassignment);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentListhistory");
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
 **actionassignment** | [**UUID**](.md)| The action assignment&#39;s id whose history the user wants to get. |

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

<a name="actionassignmentListmine"></a>
# **actionassignmentListmine**
> actionassignmentListmine(from, count, status)

List public action assignments assigned to the logged user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    Integer status = 56; // Integer | The status to filter the assignments.
    try {
      apiInstance.actionassignmentListmine(from, count, status);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentListmine");
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
 **status** | **Integer**| The status to filter the assignments. | [optional]

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

<a name="actionassignmentListpublichistory"></a>
# **actionassignmentListpublichistory**
> actionassignmentListpublichistory(actionassignment)

List public action assignment history

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    UUID actionassignment = new UUID(); // UUID | The action assignment's id whose history the user wants to get.
    try {
      apiInstance.actionassignmentListpublichistory(actionassignment);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentListpublichistory");
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
 **actionassignment** | [**UUID**](.md)| The action assignment&#39;s id whose history the user wants to get. |

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

<a name="actionassignmentMarkcomplete"></a>
# **actionassignmentMarkcomplete**
> actionassignmentMarkcomplete(item, assignee, group, notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    String item = "item_example"; // String | The action item to assign.
    UUID assignee = new UUID(); // UUID | The assignee of the item.
    UUID group = new UUID(); // UUID | The group to assing the item.
    String notes = "notes_example"; // String | The assignment's notes.
    try {
      apiInstance.actionassignmentMarkcomplete(item, assignee, group, notes);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentMarkcomplete");
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
 **item** | **String**| The action item to assign. |
 **assignee** | [**UUID**](.md)| The assignee of the item. | [optional]
 **group** | [**UUID**](.md)| The group to assing the item. | [optional]
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

<a name="actionassignmentSave"></a>
# **actionassignmentSave**
> actionassignmentSave(UNKNOWN_BASE_TYPE)

Add an action item to a user&#39;s action plan

Allows the user to edit or assign an action item to a user

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.actionassignmentSave(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentSave");
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

<a name="actionassignmentSavehistory"></a>
# **actionassignmentSavehistory**
> actionassignmentSavehistory(UNKNOWN_BASE_TYPE)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.ActionassignmentApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accutraining.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    ActionassignmentApi apiInstance = new ActionassignmentApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.actionassignmentSavehistory(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling ActionassignmentApi#actionassignmentSavehistory");
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

