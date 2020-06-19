# ActionpackApi

All URIs are relative to *https://accutraining.net:443/api/v1*

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
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionpackApi()
val pack : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action pack to assign.
val itemsdata : kotlin.Boolean = true // kotlin.Boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
val assignee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The assignee of the pack.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The group to assign the pack.
val notes : kotlin.String = notes_example // kotlin.String | The assignment's notes.
try {
    apiInstance.actionpackAssign(pack, itemsdata, assignee, group, notes)
} catch (e: ClientException) {
    println("4xx response calling ActionpackApi#actionpackAssign")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionpackApi#actionpackAssign")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pack** | [**java.util.UUID**](.md)| The id of the action pack to assign. |
 **itemsdata** | **kotlin.Boolean**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). |
 **assignee** | [**java.util.UUID**](.md)| The assignee of the pack. | [optional]
 **group** | [**java.util.UUID**](.md)| The group to assign the pack. | [optional]
 **notes** | **kotlin.String**| The assignment&#39;s notes. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpackDelete"></a>
# **actionpackDelete**
> actionpackDelete(id, body)

Delete an action item pack

Allows the user to delete an action item pack.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionpackApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action pack to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.actionpackDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling ActionpackApi#actionpackDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionpackApi#actionpackDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action pack to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actionpackGet"></a>
# **actionpackGet**
> actionpackGet(id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionpackApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action pack to get.
try {
    apiInstance.actionpackGet(id)
} catch (e: ClientException) {
    println("4xx response calling ActionpackApi#actionpackGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionpackApi#actionpackGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action pack to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpackList"></a>
# **actionpackList**
> actionpackList(from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionpackApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.actionpackList(from, count)
} catch (e: ClientException) {
    println("4xx response calling ActionpackApi#actionpackList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionpackApi#actionpackList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionpackSave"></a>
# **actionpackSave**
> actionpackSave(id, UNKNOWN_BASE_TYPE)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionpackApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action pack to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionpackSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ActionpackApi#actionpackSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionpackApi#actionpackSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action pack to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

