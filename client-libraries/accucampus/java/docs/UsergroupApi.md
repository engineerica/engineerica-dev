# UsergroupApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usergroupAddmember**](UsergroupApi.md#usergroupAddmember) | **GET** /usergroup/addmember | Add a user to a group
[**usergroupDelete**](UsergroupApi.md#usergroupDelete) | **DELETE** /usergroup/{id} | Delete a group
[**usergroupGet**](UsergroupApi.md#usergroupGet) | **GET** /usergroup/{id} | Search and view details of a user group
[**usergroupGetmembers**](UsergroupApi.md#usergroupGetmembers) | **GET** /usergroup/getmembers | View the members of a user group
[**usergroupGetuser**](UsergroupApi.md#usergroupGetuser) | **GET** /usergroup/getuser | View the groups which a user is registered to
[**usergroupList**](UsergroupApi.md#usergroupList) | **GET** /usergroup/list | View a list of user groups
[**usergroupRefresh**](UsergroupApi.md#usergroupRefresh) | **GET** /usergroup/refresh | Refresh the dynamic group
[**usergroupRemovemember**](UsergroupApi.md#usergroupRemovemember) | **GET** /usergroup/removemember | Remove a user from a group
[**usergroupSave**](UsergroupApi.md#usergroupSave) | **POST** /usergroup/{id} | Create or edit a group
[**usergroupTagmembers**](UsergroupApi.md#usergroupTagmembers) | **GET** /usergroup/tagmembers | Assign tags to the members of a specified group
[**usergroupUntagmembers**](UsergroupApi.md#usergroupUntagmembers) | **GET** /usergroup/untagmembers | Unassign tags from the members of a specified group


<a name="usergroupAddmember"></a>
# **usergroupAddmember**
> usergroupAddmember(userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to add.
    UUID groupid = new UUID(); // UUID | The id of the group.
    try {
      apiInstance.usergroupAddmember(userid, groupid);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupAddmember");
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
 **groupid** | [**UUID**](.md)| The id of the group. |

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

<a name="usergroupDelete"></a>
# **usergroupDelete**
> usergroupDelete(id, body)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the group to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.usergroupDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupDelete");
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
 **id** | [**UUID**](.md)| The id of the group to delete. |
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

<a name="usergroupGet"></a>
# **usergroupGet**
> usergroupGet(id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the user group to get.
    try {
      apiInstance.usergroupGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupGet");
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
 **id** | [**UUID**](.md)| The id of the user group to get. |

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

<a name="usergroupGetmembers"></a>
# **usergroupGetmembers**
> usergroupGetmembers(groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID groupid = new UUID(); // UUID | The id of the user group to get.
    try {
      apiInstance.usergroupGetmembers(groupid);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupGetmembers");
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
 **groupid** | [**UUID**](.md)| The id of the user group to get. |

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

<a name="usergroupGetuser"></a>
# **usergroupGetuser**
> usergroupGetuser(userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to get his groups.
    try {
      apiInstance.usergroupGetuser(userid);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupGetuser");
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
 **userid** | [**UUID**](.md)| The id of the user to get his groups. |

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

<a name="usergroupList"></a>
# **usergroupList**
> usergroupList(from, count, type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    Integer from = 56; // Integer | The first record to return.
    Integer count = 56; // Integer | The max number of records to return.
    String type = "type_example"; // String | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.
    try {
      apiInstance.usergroupList(from, count, type);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupList");
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
 **from** | **Integer**| The first record to return. | [optional]
 **count** | **Integer**| The max number of records to return. | [optional]
 **type** | **String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional]

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

<a name="usergroupRefresh"></a>
# **usergroupRefresh**
> usergroupRefresh(group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID group = new UUID(); // UUID | The ID of the group to refresh.
    try {
      apiInstance.usergroupRefresh(group);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupRefresh");
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
 **group** | [**UUID**](.md)| The ID of the group to refresh. |

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

<a name="usergroupRemovemember"></a>
# **usergroupRemovemember**
> usergroupRemovemember(userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID userid = new UUID(); // UUID | The id of the user to remove.
    UUID groupid = new UUID(); // UUID | The id of the group.
    try {
      apiInstance.usergroupRemovemember(userid, groupid);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupRemovemember");
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
 **groupid** | [**UUID**](.md)| The id of the group. |

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

<a name="usergroupSave"></a>
# **usergroupSave**
> usergroupSave(id, UNKNOWN_BASE_TYPE)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the group to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.usergroupSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupSave");
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
 **id** | [**UUID**](.md)| The id of the group to save (leave empty to create a new one). |
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

<a name="usergroupTagmembers"></a>
# **usergroupTagmembers**
> usergroupTagmembers(group, tags)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID group = new UUID(); // UUID | The id of the group to save whose members have to be tagged.
    String tags = "tags_example"; // String | The tags to assign to the members of the specified group, in JSON format.
    try {
      apiInstance.usergroupTagmembers(group, tags);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupTagmembers");
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
 **group** | [**UUID**](.md)| The id of the group to save whose members have to be tagged. |
 **tags** | **String**| The tags to assign to the members of the specified group, in JSON format. | [optional]

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

<a name="usergroupUntagmembers"></a>
# **usergroupUntagmembers**
> usergroupUntagmembers(group, tags)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.UsergroupApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    UsergroupApi apiInstance = new UsergroupApi(defaultClient);
    UUID group = new UUID(); // UUID | The id of the group to save whose members have to be untagged.
    String tags = "tags_example"; // String | The tags to unassign from the members of the specified group, in JSON format.
    try {
      apiInstance.usergroupUntagmembers(group, tags);
    } catch (ApiException e) {
      System.err.println("Exception when calling UsergroupApi#usergroupUntagmembers");
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
 **group** | [**UUID**](.md)| The id of the group to save whose members have to be untagged. |
 **tags** | **String**| The tags to unassign from the members of the specified group, in JSON format. | [optional]

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

