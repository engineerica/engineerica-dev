# SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionBulkupdate**](SessionApi.md#sessionBulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**sessionGet**](SessionApi.md#sessionGet) | **GET** /session/{id} | View details of a session
[**sessionGetschedule**](SessionApi.md#sessionGetschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**sessionList**](SessionApi.md#sessionList) | **GET** /session/list | Gets all future sessions of the current semester


<a name="sessionBulkupdate"></a>
# **sessionBulkupdate**
> sessionBulkupdate(eventid, sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to bulk update.
val sessions : kotlin.String = sessions_example // kotlin.String | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.
try {
    apiInstance.sessionBulkupdate(eventid, sessions)
} catch (e: ClientException) {
    println("4xx response calling SessionApi#sessionBulkupdate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionApi#sessionBulkupdate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event to bulk update. |
 **sessions** | **kotlin.String**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionGet"></a>
# **sessionGet**
> sessionGet(id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session to get.
try {
    apiInstance.sessionGet(id)
} catch (e: ClientException) {
    println("4xx response calling SessionApi#sessionGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionApi#sessionGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the session to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionGetschedule"></a>
# **sessionGetschedule**
> sessionGetschedule(day, attendee, location, instructor)

Gets the schedule for a location, instructor or attendees

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionApi()
val day : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The day to return. It will also return the whole week for that day.
val attendee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendee to get the schedule.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to get the schedule.
val instructor : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the instructor to get the schedule.
try {
    apiInstance.sessionGetschedule(day, attendee, location, instructor)
} catch (e: ClientException) {
    println("4xx response calling SessionApi#sessionGetschedule")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionApi#sessionGetschedule")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **day** | **java.time.OffsetDateTime**| The day to return. It will also return the whole week for that day. | [optional]
 **attendee** | [**java.util.UUID**](.md)| The id of the attendee to get the schedule. | [optional]
 **location** | [**java.util.UUID**](.md)| The id of the location to get the schedule. | [optional]
 **instructor** | [**java.util.UUID**](.md)| The id of the instructor to get the schedule. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionList"></a>
# **sessionList**
> sessionList(from, count, startdate, enddate)

Gets all future sessions of the current semester

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date to filter the sessions
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date to filter the sessions.
try {
    apiInstance.sessionList(from, count, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling SessionApi#sessionList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionApi#sessionList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **startdate** | **java.time.OffsetDateTime**| The start date to filter the sessions | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date to filter the sessions. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

