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
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action assignment to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.actionassignmentDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action assignment to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="actionassignmentGet"></a>
# **actionassignmentGet**
> actionassignmentGet(id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the action assignment to get.
try {
    apiInstance.actionassignmentGet(id)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the action assignment to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentList"></a>
# **actionassignmentList**
> actionassignmentList(from, count, assignee, status)

View a list of action items in a user&#39;s plan

Allows the user to view the list of all action items for a specified user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val assignee : kotlin.Int = 56 // kotlin.Int | The assignee's id to filter the assignments.
val status : kotlin.Int = 56 // kotlin.Int | The status to filter the assignments.
try {
    apiInstance.actionassignmentList(from, count, assignee, status)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **assignee** | **kotlin.Int**| The assignee&#39;s id to filter the assignments. | [optional]
 **status** | **kotlin.Int**| The status to filter the assignments. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentListhistory"></a>
# **actionassignmentListhistory**
> actionassignmentListhistory(actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val actionassignment : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The action assignment's id whose history the user wants to get.
try {
    apiInstance.actionassignmentListhistory(actionassignment)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentListhistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentListhistory")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**java.util.UUID**](.md)| The action assignment&#39;s id whose history the user wants to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentListmine"></a>
# **actionassignmentListmine**
> actionassignmentListmine(from, count, status)

List public action assignments assigned to the logged user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val status : kotlin.Int = 56 // kotlin.Int | The status to filter the assignments.
try {
    apiInstance.actionassignmentListmine(from, count, status)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentListmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentListmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **status** | **kotlin.Int**| The status to filter the assignments. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentListpublichistory"></a>
# **actionassignmentListpublichistory**
> actionassignmentListpublichistory(actionassignment)

List public action assignment history

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val actionassignment : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The action assignment's id whose history the user wants to get.
try {
    apiInstance.actionassignmentListpublichistory(actionassignment)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentListpublichistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentListpublichistory")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**java.util.UUID**](.md)| The action assignment&#39;s id whose history the user wants to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentMarkcomplete"></a>
# **actionassignmentMarkcomplete**
> actionassignmentMarkcomplete(item, assignee, group, notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val item : kotlin.String = item_example // kotlin.String | The action item to assign.
val assignee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The assignee of the item.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The group to assing the item.
val notes : kotlin.String = notes_example // kotlin.String | The assignment's notes.
try {
    apiInstance.actionassignmentMarkcomplete(item, assignee, group, notes)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentMarkcomplete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentMarkcomplete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | **kotlin.String**| The action item to assign. |
 **assignee** | [**java.util.UUID**](.md)| The assignee of the item. | [optional]
 **group** | [**java.util.UUID**](.md)| The group to assing the item. | [optional]
 **notes** | **kotlin.String**| The assignment&#39;s notes. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="actionassignmentSave"></a>
# **actionassignmentSave**
> actionassignmentSave(UNKNOWN_BASE_TYPE)

Add an action item to a user&#39;s action plan

Allows the user to edit or assign an action item to a user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionassignmentSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentSave")
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

<a name="actionassignmentSavehistory"></a>
# **actionassignmentSavehistory**
> actionassignmentSavehistory(UNKNOWN_BASE_TYPE)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionassignmentApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.actionassignmentSavehistory(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ActionassignmentApi#actionassignmentSavehistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionassignmentApi#actionassignmentSavehistory")
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

