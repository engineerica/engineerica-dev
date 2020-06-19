# EventApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventChecksessions**](EventApi.md#eventChecksessions) | **GET** /event/checksessions | Edit an event&#39;s sessions according to their schedule
[**eventDelete**](EventApi.md#eventDelete) | **DELETE** /event/{id} | Delete a course
[**eventGet**](EventApi.md#eventGet) | **GET** /event/{id} | Search and view details of a course
[**eventGetsessionsbydate**](EventApi.md#eventGetsessionsbydate) | **GET** /event/getsessionsbydate | View a list of courses by date
[**eventList**](EventApi.md#eventList) | **GET** /event/list | View a list of courses
[**eventListregistered**](EventApi.md#eventListregistered) | **GET** /event/listregistered | View a list of courses I am registered to
[**eventSave**](EventApi.md#eventSave) | **POST** /event/{id} | Create or edit a course
[**eventSearchgroup**](EventApi.md#eventSearchgroup) | **GET** /event/searchgroup | Searches for the available event groups


<a name="eventChecksessions"></a>
# **eventChecksessions**
> eventChecksessions(eventid, autorepair)

Edit an event&#39;s sessions according to their schedule

Allows the user to edit event sessions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to check.
val autorepair : kotlin.Boolean = true // kotlin.Boolean | True to automatically fix the invalid sessions.
try {
    apiInstance.eventChecksessions(eventid, autorepair)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventChecksessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventChecksessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event to check. |
 **autorepair** | **kotlin.Boolean**| True to automatically fix the invalid sessions. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventDelete"></a>
# **eventDelete**
> eventDelete(id, body)

Delete a course

Allows the user to delete an existing course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.eventDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the event to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="eventGet"></a>
# **eventGet**
> eventGet(id)

Search and view details of a course

Allows the user to view an individual course and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to get.
try {
    apiInstance.eventGet(id)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the event to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventGetsessionsbydate"></a>
# **eventGetsessionsbydate**
> eventGetsessionsbydate(location, date, type)

View a list of courses by date

Allows the user to view a list of courses by date.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The location to filter the events.
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date to filter the events. Today will be used if this parameter is omitted.
val type : kotlin.String = type_example // kotlin.String | Type of event to list.
try {
    apiInstance.eventGetsessionsbydate(location, date, type)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventGetsessionsbydate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventGetsessionsbydate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**java.util.UUID**](.md)| The location to filter the events. | [optional]
 **date** | **java.time.OffsetDateTime**| The date to filter the events. Today will be used if this parameter is omitted. | [optional]
 **type** | **kotlin.String**| Type of event to list. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventList"></a>
# **eventList**
> eventList(from, count, summaryonly, termid)

View a list of courses

Allows the user to view the full list of courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val from : kotlin.String = from_example // kotlin.String | The first record to return.
val count : kotlin.String = count_example // kotlin.String | The max number of records to return.
val summaryonly : kotlin.Boolean = true // kotlin.Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the term to list the events. Null to list all events.
try {
    apiInstance.eventList(from, count, summaryonly, termid)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventList")
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

<a name="eventListregistered"></a>
# **eventListregistered**
> eventListregistered(from, count, summaryonly, termid)

View a list of courses I am registered to

Allows the user to view the courses they are registered to.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val from : kotlin.String = from_example // kotlin.String | The first record to return.
val count : kotlin.String = count_example // kotlin.String | The max number of records to return.
val summaryonly : kotlin.Boolean = true // kotlin.Boolean | True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the term to list the events. Null to list all events.
try {
    apiInstance.eventListregistered(from, count, summaryonly, termid)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventListregistered")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventListregistered")
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

<a name="eventSave"></a>
# **eventSave**
> eventSave(id, UNKNOWN_BASE_TYPE)

Create or edit a course

Allows the user to create or edit a course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.eventSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventSave")
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

<a name="eventSearchgroup"></a>
# **eventSearchgroup**
> eventSearchgroup(query)

Searches for the available event groups

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventApi()
val query : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Query to search event groups.
try {
    apiInstance.eventSearchgroup(query)
} catch (e: ClientException) {
    println("4xx response calling EventApi#eventSearchgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventApi#eventSearchgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**java.util.UUID**](.md)| Query to search event groups. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

