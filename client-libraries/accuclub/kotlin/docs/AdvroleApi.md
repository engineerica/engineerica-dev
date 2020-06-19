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
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val roles : kotlin.String = roles_example // kotlin.String | CSV list of the role ids to check
val permissions : kotlin.String = permissions_example // kotlin.String | CSV list of the permissions to check
try {
    apiInstance.advroleAddmissing(roles, permissions)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleAddmissing")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleAddmissing")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **kotlin.String**| CSV list of the role ids to check |
 **permissions** | **kotlin.String**| CSV list of the permissions to check |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleCheckperm"></a>
# **advroleCheckperm**
> advroleCheckperm(roles, permissions)

Checks the permissions are assigned for the given roles

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val roles : kotlin.String = roles_example // kotlin.String | CSV list of the role ids to check
val permissions : kotlin.String = permissions_example // kotlin.String | CSV list of the permissions to check
try {
    apiInstance.advroleCheckperm(roles, permissions)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleCheckperm")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleCheckperm")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **kotlin.String**| CSV list of the role ids to check |
 **permissions** | **kotlin.String**| CSV list of the permissions to check |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleDelete"></a>
# **advroleDelete**
> advroleDelete(id, body)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.advroleDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the location to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="advroleDeletemapping"></a>
# **advroleDeletemapping**
> advroleDeletemapping(UNKNOWN_BASE_TYPE)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.advroleDeletemapping(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleDeletemapping")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleDeletemapping")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="advroleGet"></a>
# **advroleGet**
> advroleGet(id)

View details of a role

Allows the user to view a role and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get.
try {
    apiInstance.advroleGet(id)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the location to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleList"></a>
# **advroleList**
> advroleList(includepolicies, includeinternal, name)

Lists the roles for the current account

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val includepolicies : kotlin.Boolean = true // kotlin.Boolean | True to include the policies, defaults to false.
val includeinternal : kotlin.Boolean = true // kotlin.Boolean | True to include the internal roles too.
val name : kotlin.String = name_example // kotlin.String | Filter by name of the role.
try {
    apiInstance.advroleList(includepolicies, includeinternal, name)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includepolicies** | **kotlin.Boolean**| True to include the policies, defaults to false. | [optional]
 **includeinternal** | **kotlin.Boolean**| True to include the internal roles too. | [optional]
 **name** | **kotlin.String**| Filter by name of the role. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleListmaps"></a>
# **advroleListmaps**
> advroleListmaps(roleid)

Lists the maps a roles is mapped to

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role to list the maps.
try {
    apiInstance.advroleListmaps(roleid)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleListmaps")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleListmaps")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**java.util.UUID**](.md)| The id of the role to list the maps. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleListrolesmapped"></a>
# **advroleListrolesmapped**
> advroleListrolesmapped(map)

Lists the roles mappings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val map : kotlin.String = map_example // kotlin.String | List only the roles in the specified map.
try {
    apiInstance.advroleListrolesmapped(map)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleListrolesmapped")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleListrolesmapped")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map** | **kotlin.String**| List only the roles in the specified map. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleListtemplates"></a>
# **advroleListtemplates**
> advroleListtemplates()

View a list of role templates

Allows the user to view the full list of available role templates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
try {
    apiInstance.advroleListtemplates()
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleListtemplates")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleListtemplates")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advroleSave"></a>
# **advroleSave**
> advroleSave(id, UNKNOWN_BASE_TYPE)

Create or edit a role

Allows the user to create or edit a role&#39;s permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.advroleSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the role to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="advroleSavemapping"></a>
# **advroleSavemapping**
> advroleSavemapping(UNKNOWN_BASE_TYPE)

Saves a role mapping

Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.advroleSavemapping(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleSavemapping")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleSavemapping")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="advroleUserupgrade"></a>
# **advroleUserupgrade**
> advroleUserupgrade(userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvroleApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the user to upgrade
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the role to add
try {
    apiInstance.advroleUserupgrade(userid, roleid)
} catch (e: ClientException) {
    println("4xx response calling AdvroleApi#advroleUserupgrade")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvroleApi#advroleUserupgrade")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| Id of the user to upgrade |
 **roleid** | [**java.util.UUID**](.md)| Id of the role to add |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

