# AdvroleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advroleAddmissing**](AdvroleApi.md#advroleAddmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**advroleCheckperm**](AdvroleApi.md#advroleCheckperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
[**advroleDelete**](AdvroleApi.md#advroleDelete) | **DELETE** /advrole/{id} | Delete a role
[**advroleDeletemapping**](AdvroleApi.md#advroleDeletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
[**advroleGet**](AdvroleApi.md#advroleGet) | **GET** /advrole/{id} | View details of a role
[**advroleList**](AdvroleApi.md#advroleList) | **GET** /advrole/list | Lists the roles for the current account
[**advroleListmaps**](AdvroleApi.md#advroleListmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
[**advroleListrolesmapped**](AdvroleApi.md#advroleListrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
[**advroleListtemplates**](AdvroleApi.md#advroleListtemplates) | **GET** /advrole/listtemplates | View a list of role templates
[**advroleSave**](AdvroleApi.md#advroleSave) | **POST** /advrole/{id} | Create or edit a role
[**advroleSavemapping**](AdvroleApi.md#advroleSavemapping) | **POST** /advrole/savemapping | Saves a role mapping
[**advroleUserupgrade**](AdvroleApi.md#advroleUserupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)


<a name="advroleAddmissing"></a>
# **advroleAddmissing**
> advroleAddmissing(roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    String roles = "roles_example"; // String | CSV list of the role ids to check
    String permissions = "permissions_example"; // String | CSV list of the permissions to check
    try {
      apiInstance.advroleAddmissing(roles, permissions);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleAddmissing");
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
 **roles** | **String**| CSV list of the role ids to check |
 **permissions** | **String**| CSV list of the permissions to check |

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

<a name="advroleCheckperm"></a>
# **advroleCheckperm**
> advroleCheckperm(roles, permissions)

Checks the permissions are assigned for the given roles

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    String roles = "roles_example"; // String | CSV list of the role ids to check
    String permissions = "permissions_example"; // String | CSV list of the permissions to check
    try {
      apiInstance.advroleCheckperm(roles, permissions);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleCheckperm");
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
 **roles** | **String**| CSV list of the role ids to check |
 **permissions** | **String**| CSV list of the permissions to check |

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

<a name="advroleDelete"></a>
# **advroleDelete**
> advroleDelete(id, body)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the location to delete.
    oas_any_type_not_mapped body = new oas_any_type_not_mapped(); // oas_any_type_not_mapped | 
    try {
      apiInstance.advroleDelete(id, body);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleDelete");
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
 **id** | [**UUID**](.md)| The id of the location to delete. |
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

<a name="advroleDeletemapping"></a>
# **advroleDeletemapping**
> advroleDeletemapping(UNKNOWN_BASE_TYPE)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.advroleDeletemapping(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleDeletemapping");
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

<a name="advroleGet"></a>
# **advroleGet**
> advroleGet(id)

View details of a role

Allows the user to view a role and its details.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the location to get.
    try {
      apiInstance.advroleGet(id);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleGet");
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
 **id** | [**UUID**](.md)| The id of the location to get. |

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

<a name="advroleList"></a>
# **advroleList**
> advroleList(includepolicies, includeinternal, name)

Lists the roles for the current account

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    Boolean includepolicies = true; // Boolean | True to include the policies, defaults to false.
    Boolean includeinternal = true; // Boolean | True to include the internal roles too.
    String name = "name_example"; // String | Filter by name of the role.
    try {
      apiInstance.advroleList(includepolicies, includeinternal, name);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleList");
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
 **includepolicies** | **Boolean**| True to include the policies, defaults to false. | [optional]
 **includeinternal** | **Boolean**| True to include the internal roles too. | [optional]
 **name** | **String**| Filter by name of the role. | [optional]

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

<a name="advroleListmaps"></a>
# **advroleListmaps**
> advroleListmaps(roleid)

Lists the maps a roles is mapped to

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    UUID roleid = new UUID(); // UUID | The id of the role to list the maps.
    try {
      apiInstance.advroleListmaps(roleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleListmaps");
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
 **roleid** | [**UUID**](.md)| The id of the role to list the maps. |

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

<a name="advroleListrolesmapped"></a>
# **advroleListrolesmapped**
> advroleListrolesmapped(map)

Lists the roles mappings

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    String map = "map_example"; // String | List only the roles in the specified map.
    try {
      apiInstance.advroleListrolesmapped(map);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleListrolesmapped");
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
 **map** | **String**| List only the roles in the specified map. | [optional]

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

<a name="advroleListtemplates"></a>
# **advroleListtemplates**
> advroleListtemplates()

View a list of role templates

Allows the user to view the full list of available role templates.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    try {
      apiInstance.advroleListtemplates();
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleListtemplates");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters
This endpoint does not need any parameter.

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

<a name="advroleSave"></a>
# **advroleSave**
> advroleSave(id, UNKNOWN_BASE_TYPE)

Create or edit a role

Allows the user to create or edit a role&#39;s permissions.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    UUID id = new UUID(); // UUID | The id of the role to save (leave empty to create a new one).
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.advroleSave(id, UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleSave");
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
 **id** | [**UUID**](.md)| The id of the role to save (leave empty to create a new one). |
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

<a name="advroleSavemapping"></a>
# **advroleSavemapping**
> advroleSavemapping(UNKNOWN_BASE_TYPE)

Saves a role mapping

Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE | 
    try {
      apiInstance.advroleSavemapping(UNKNOWN_BASE_TYPE);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleSavemapping");
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

<a name="advroleUserupgrade"></a>
# **advroleUserupgrade**
> advroleUserupgrade(userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.AdvroleApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accuclub.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    AdvroleApi apiInstance = new AdvroleApi(defaultClient);
    UUID userid = new UUID(); // UUID | Id of the user to upgrade
    UUID roleid = new UUID(); // UUID | Id of the role to add
    try {
      apiInstance.advroleUserupgrade(userid, roleid);
    } catch (ApiException e) {
      System.err.println("Exception when calling AdvroleApi#advroleUserupgrade");
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
 **userid** | [**UUID**](.md)| Id of the user to upgrade |
 **roleid** | [**UUID**](.md)| Id of the role to add |

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

