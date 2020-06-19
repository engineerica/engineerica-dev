# SeminarApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**seminarDelete**](SeminarApi.md#seminarDelete) | **DELETE** /seminar/{id} | Delete an event
[**seminarGet**](SeminarApi.md#seminarGet) | **GET** /seminar/{id} | Search and view details of a event
[**seminarList**](SeminarApi.md#seminarList) | **GET** /seminar/list | View a list of events
[**seminarSave**](SeminarApi.md#seminarSave) | **POST** /seminar/{id} | Create or edit a event


<a name="seminarDelete"></a>
# **seminarDelete**
> seminarDelete(id, body)

Delete an event

Allows the user to delete an existing event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SeminarApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the seminar to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.seminarDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling SeminarApi#seminarDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SeminarApi#seminarDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the seminar to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="seminarGet"></a>
# **seminarGet**
> seminarGet(id)

Search and view details of a event

Allows the user to view a event and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SeminarApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the seminar to get.
try {
    apiInstance.seminarGet(id)
} catch (e: ClientException) {
    println("4xx response calling SeminarApi#seminarGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SeminarApi#seminarGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the seminar to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="seminarList"></a>
# **seminarList**
> seminarList(from, count, summaryonly, termid)

View a list of events

Allows the user to view the full list of events in the past, present, and future.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SeminarApi()
val from : kotlin.String = from_example // kotlin.String | The first record to return.
val count : kotlin.String = count_example // kotlin.String | The max number of records to return.
val summaryonly : kotlin.Boolean = true // kotlin.Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the term to list the events. Null to list all events.
try {
    apiInstance.seminarList(from, count, summaryonly, termid)
} catch (e: ClientException) {
    println("4xx response calling SeminarApi#seminarList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SeminarApi#seminarList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.String**| The first record to return. |
 **count** | **kotlin.String**| The max number of records to return. |
 **summaryonly** | **kotlin.Boolean**| True to return only the event information and not the associated schedule, dept, etc. Defaults to false. | [optional]
 **termid** | [**java.util.UUID**](.md)| Id of the term to list the events. Null to list all events. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="seminarSave"></a>
# **seminarSave**
> seminarSave(id, UNKNOWN_BASE_TYPE)

Create or edit a event

Allows the user to create or edit a event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SeminarApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.seminarSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SeminarApi#seminarSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SeminarApi#seminarSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the event to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

