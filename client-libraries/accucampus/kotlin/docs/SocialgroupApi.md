# SocialgroupApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**socialgroupAddmembers**](SocialgroupApi.md#socialgroupAddmembers) | **GET** /socialgroup/addmembers | Adds new members to a group (which the user must own already)
[**socialgroupDelete**](SocialgroupApi.md#socialgroupDelete) | **DELETE** /socialgroup/{id} | Deletes a group
[**socialgroupList**](SocialgroupApi.md#socialgroupList) | **GET** /socialgroup/list | View all the groups the current user is in
[**socialgroupListmembers**](SocialgroupApi.md#socialgroupListmembers) | **GET** /socialgroup/listmembers | Lists the members of a group
[**socialgroupRemovemembers**](SocialgroupApi.md#socialgroupRemovemembers) | **GET** /socialgroup/removemembers | Removes members from a group (which the user must own already)
[**socialgroupRemovemyself**](SocialgroupApi.md#socialgroupRemovemyself) | **GET** /socialgroup/removemyself | Removes myself from an existent group
[**socialgroupSave**](SocialgroupApi.md#socialgroupSave) | **POST** /socialgroup/{id} | Saves a new group


<a name="socialgroupAddmembers"></a>
# **socialgroupAddmembers**
> socialgroupAddmembers(id, userids)

Adds new members to a group (which the user must own already)

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SocialgroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to add members to.
val userids : kotlin.String = userids_example // kotlin.String | Csv list of user Ids to add.
try {
    apiInstance.socialgroupAddmembers(id, userids)
} catch (e: ClientException) {
    println("4xx response calling SocialgroupApi#socialgroupAddmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SocialgroupApi#socialgroupAddmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| ID of the group to add members to. |
 **userids** | **kotlin.String**| Csv list of user Ids to add. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupDelete"></a>
# **socialgroupDelete**
> socialgroupDelete(id, body)

Deletes a group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SocialgroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.socialgroupDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling SocialgroupApi#socialgroupDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SocialgroupApi#socialgroupDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| ID of the group to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="socialgroupList"></a>
# **socialgroupList**
> socialgroupList()

View all the groups the current user is in

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SocialgroupApi()
try {
    apiInstance.socialgroupList()
} catch (e: ClientException) {
    println("4xx response calling SocialgroupApi#socialgroupList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SocialgroupApi#socialgroupList")
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

<a name="socialgroupListmembers"></a>
# **socialgroupListmembers**
> socialgroupListmembers(id)

Lists the members of a group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SocialgroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to list members.
try {
    apiInstance.socialgroupListmembers(id)
} catch (e: ClientException) {
    println("4xx response calling SocialgroupApi#socialgroupListmembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SocialgroupApi#socialgroupListmembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| ID of the group to list members. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupRemovemembers"></a>
# **socialgroupRemovemembers**
> socialgroupRemovemembers(id, userids)

Removes members from a group (which the user must own already)

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SocialgroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to remove members from.
val userids : kotlin.String = userids_example // kotlin.String | Csv list of user Ids to remove.
try {
    apiInstance.socialgroupRemovemembers(id, userids)
} catch (e: ClientException) {
    println("4xx response calling SocialgroupApi#socialgroupRemovemembers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SocialgroupApi#socialgroupRemovemembers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| ID of the group to remove members from. |
 **userids** | **kotlin.String**| Csv list of user Ids to remove. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupRemovemyself"></a>
# **socialgroupRemovemyself**
> socialgroupRemovemyself(id)

Removes myself from an existent group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SocialgroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to remove me from.
try {
    apiInstance.socialgroupRemovemyself(id)
} catch (e: ClientException) {
    println("4xx response calling SocialgroupApi#socialgroupRemovemyself")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SocialgroupApi#socialgroupRemovemyself")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| ID of the group to remove me from. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="socialgroupSave"></a>
# **socialgroupSave**
> socialgroupSave(id, UNKNOWN_BASE_TYPE)

Saves a new group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SocialgroupApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | ID of the group to update. Leave blank to create new.
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.socialgroupSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SocialgroupApi#socialgroupSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SocialgroupApi#socialgroupSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| ID of the group to update. Leave blank to create new. |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

