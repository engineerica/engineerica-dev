# SessionattendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionattendancelogAddnote**](SessionattendancelogApi.md#sessionattendancelogAddnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
[**sessionattendancelogGet**](SessionattendancelogApi.md#sessionattendancelogGet) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
[**sessionattendancelogGetuser**](SessionattendancelogApi.md#sessionattendancelogGetuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**sessionattendancelogList**](SessionattendancelogApi.md#sessionattendancelogList) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
[**sessionattendancelogListevent**](SessionattendancelogApi.md#sessionattendancelogListevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
[**sessionattendancelogListsummary**](SessionattendancelogApi.md#sessionattendancelogListsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**sessionattendancelogMylistsummary**](SessionattendancelogApi.md#sessionattendancelogMylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
[**sessionattendancelogSave**](SessionattendancelogApi.md#sessionattendancelogSave) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
[**sessionattendancelogSaveswipe**](SessionattendancelogApi.md#sessionattendancelogSaveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe


<a name="sessionattendancelogAddnote"></a>
# **sessionattendancelogAddnote**
> sessionattendancelogAddnote(id, text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log.
val text : kotlin.String = text_example // kotlin.String | The text of the note to add.
try {
    apiInstance.sessionattendancelogAddnote(id, text)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogAddnote")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogAddnote")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the attendance log. |
 **text** | **kotlin.String**| The text of the note to add. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogGet"></a>
# **sessionattendancelogGet**
> sessionattendancelogGet(id, photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.sessionattendancelogGet(id, photosize)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogGetuser"></a>
# **sessionattendancelogGetuser**
> sessionattendancelogGetuser(attendee, eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val attendee : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendee to get statistic for.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendee statistics have to be returned.
try {
    apiInstance.sessionattendancelogGetuser(attendee, eventid)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogGetuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogGetuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**java.util.UUID**](.md)| The id of the attendee to get statistic for. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendee statistics have to be returned. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogList"></a>
# **sessionattendancelogList**
> sessionattendancelogList(session, from, count, photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val session : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session whose attendees logs have to be returned.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.sessionattendancelogList(session, from, count, photosize)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **session** | [**java.util.UUID**](.md)| The id of the session whose attendees logs have to be returned. |
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogListevent"></a>
# **sessionattendancelogListevent**
> sessionattendancelogListevent(eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendance has to be returned.
try {
    apiInstance.sessionattendancelogListevent(eventid)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogListevent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogListevent")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendance has to be returned. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogListsummary"></a>
# **sessionattendancelogListsummary**
> sessionattendancelogListsummary(eventid, attendeeid, groupid, start, end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendance has to be returned.
val attendeeid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendee whose attendance has to be returned.
val groupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group whose attendance has to be returned.
val start : kotlin.String = start_example // kotlin.String | The start date to filter (beginning of time by default).
val end : kotlin.String = end_example // kotlin.String | The end date to filter (today by default).
try {
    apiInstance.sessionattendancelogListsummary(eventid, attendeeid, groupid, start, end)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogListsummary")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogListsummary")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendance has to be returned. | [optional]
 **attendeeid** | [**java.util.UUID**](.md)| The id of the attendee whose attendance has to be returned. | [optional]
 **groupid** | [**java.util.UUID**](.md)| The id of the group whose attendance has to be returned. | [optional]
 **start** | **kotlin.String**| The start date to filter (beginning of time by default). | [optional]
 **end** | **kotlin.String**| The end date to filter (today by default). | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogMylistsummary"></a>
# **sessionattendancelogMylistsummary**
> sessionattendancelogMylistsummary(eventid, start, end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose attendance has to be returned.
val start : kotlin.String = start_example // kotlin.String | The start date to filter (beginning of time by default).
val end : kotlin.String = end_example // kotlin.String | The end date to filter (today by default).
try {
    apiInstance.sessionattendancelogMylistsummary(eventid, start, end)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogMylistsummary")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogMylistsummary")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event whose attendance has to be returned. | [optional]
 **start** | **kotlin.String**| The start date to filter (beginning of time by default). | [optional]
 **end** | **kotlin.String**| The end date to filter (today by default). | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionattendancelogSave"></a>
# **sessionattendancelogSave**
> sessionattendancelogSave(id, UNKNOWN_BASE_TYPE)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the att log to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionattendancelogSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the att log to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="sessionattendancelogSaveswipe"></a>
# **sessionattendancelogSaveswipe**
> sessionattendancelogSaveswipe(UNKNOWN_BASE_TYPE)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionattendancelogApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionattendancelogSaveswipe(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SessionattendancelogApi#sessionattendancelogSaveswipe")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionattendancelogApi#sessionattendancelogSaveswipe")
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

