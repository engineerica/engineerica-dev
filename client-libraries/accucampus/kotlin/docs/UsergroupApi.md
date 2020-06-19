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
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group.
try {
    apiInstance.usergroupAddmember(userid, groupid)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupAddmember")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupAddmember")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **groupid** | [**java.util.UUID**](.md)| The id of the group. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupDelete"></a>
# **usergroupDelete**
> usergroupDelete(id, body)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.usergroupDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the group to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="usergroupGet"></a>
# **usergroupGet**
> usergroupGet(id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user group to get.
try {
    apiInstance.usergroupGet(id)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the user group to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupGetmembers"></a>
# **usergroupGetmembers**
> usergroupGetmembers(groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user group to get.
try {
    apiInstance.usergroupGetmembers(groupid)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupGetmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupGetmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | [**java.util.UUID**](.md)| The id of the user group to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupGetuser"></a>
# **usergroupGetuser**
> usergroupGetuser(userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get his groups.
try {
    apiInstance.usergroupGetuser(userid)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupGetuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupGetuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to get his groups. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupList"></a>
# **usergroupList**
> usergroupList(from, count, type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val type : kotlin.String = type_example // kotlin.String | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.
try {
    apiInstance.usergroupList(from, count, type)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. | [optional]
 **count** | **kotlin.Int**| The max number of records to return. | [optional]
 **type** | **kotlin.String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupRefresh"></a>
# **usergroupRefresh**
> usergroupRefresh(group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group to refresh.
try {
    apiInstance.usergroupRefresh(group)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupRefresh")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupRefresh")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**java.util.UUID**](.md)| The ID of the group to refresh. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupRemovemember"></a>
# **usergroupRemovemember**
> usergroupRemovemember(userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group.
try {
    apiInstance.usergroupRemovemember(userid, groupid)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupRemovemember")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupRemovemember")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **groupid** | [**java.util.UUID**](.md)| The id of the group. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupSave"></a>
# **usergroupSave**
> usergroupSave(id, UNKNOWN_BASE_TYPE)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.usergroupSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the group to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="usergroupTagmembers"></a>
# **usergroupTagmembers**
> usergroupTagmembers(group, tags)

Assign tags to the members of a specified group

Allows the user to assign tags to the users of a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group to save whose members have to be tagged.
val tags : kotlin.String = tags_example // kotlin.String | The tags to assign to the members of the specified group, in JSON format.
try {
    apiInstance.usergroupTagmembers(group, tags)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupTagmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupTagmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**java.util.UUID**](.md)| The id of the group to save whose members have to be tagged. |
 **tags** | **kotlin.String**| The tags to assign to the members of the specified group, in JSON format. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="usergroupUntagmembers"></a>
# **usergroupUntagmembers**
> usergroupUntagmembers(group, tags)

Unassign tags from the members of a specified group

Allows the user to unassign tags to the users of a group that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UsergroupApi()
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group to save whose members have to be untagged.
val tags : kotlin.String = tags_example // kotlin.String | The tags to unassign from the members of the specified group, in JSON format.
try {
    apiInstance.usergroupUntagmembers(group, tags)
} catch (e: ClientException) {
    println("4xx response calling UsergroupApi#usergroupUntagmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UsergroupApi#usergroupUntagmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**java.util.UUID**](.md)| The id of the group to save whose members have to be untagged. |
 **tags** | **kotlin.String**| The tags to unassign from the members of the specified group, in JSON format. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

