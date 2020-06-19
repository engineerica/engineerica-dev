# AttendancelogApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelogDelete**](AttendancelogApi.md#attendancelogDelete) | **DELETE** /attendancelog/{id} | Delete an attendance log
[**attendancelogGet**](AttendancelogApi.md#attendancelogGet) | **GET** /attendancelog/{id} | Search and view details of an attendance log
[**attendancelogGetchangehistory**](AttendancelogApi.md#attendancelogGetchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**attendancelogList**](AttendancelogApi.md#attendancelogList) | **GET** /attendancelog/list | View a list of attendance logs
[**attendancelogListmine**](AttendancelogApi.md#attendancelogListmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
[**attendancelogSave**](AttendancelogApi.md#attendancelogSave) | **POST** /attendancelog/{id} | Create or edit an attendance log
[**attendancelogSignout**](AttendancelogApi.md#attendancelogSignout) | **GET** /attendancelog/signout | Sign out an attendance log
[**attendancelogWhosin**](AttendancelogApi.md#attendancelogWhosin) | **GET** /attendancelog/whosin | View who&#39;s in a location


<a name="attendancelogDelete"></a>
# **attendancelogDelete**
> attendancelogDelete(id, body)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.attendancelogDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="attendancelogGet"></a>
# **attendancelogGet**
> attendancelogGet(id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to get.
try {
    apiInstance.attendancelogGet(id)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogGetchangehistory"></a>
# **attendancelogGetchangehistory**
> attendancelogGetchangehistory(id)

Search and view details of an attendance log&#39;s swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to get.
try {
    apiInstance.attendancelogGetchangehistory(id)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogGetchangehistory")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogGetchangehistory")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogList"></a>
# **attendancelogList**
> attendancelogList(from, count, filter, userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val filter : kotlin.String = filter_example // kotlin.String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user ID of the user to get the logs.
try {
    apiInstance.attendancelogList(from, count, filter, userid)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **filter** | **kotlin.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]
 **userid** | [**java.util.UUID**](.md)| The user ID of the user to get the logs. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogListmine"></a>
# **attendancelogListmine**
> attendancelogListmine(from, count, filter)

Gets the attendance logs of the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val filter : kotlin.String = filter_example // kotlin.String | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
try {
    apiInstance.attendancelogListmine(from, count, filter)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogListmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogListmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **filter** | **kotlin.String**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogSave"></a>
# **attendancelogSave**
> attendancelogSave(id, UNKNOWN_BASE_TYPE)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the room to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.attendancelogSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the room to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="attendancelogSignout"></a>
# **attendancelogSignout**
> attendancelogSignout(id, location, event, datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who&#39;s In page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to sign-out.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to filter the users to sign out.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to filter the users to sign out.
val datetime : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Specifies the date and time when the specified logs have to be signed out.
try {
    apiInstance.attendancelogSignout(id, location, event, datetime)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogSignout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogSignout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the attendance log to sign-out. | [optional]
 **location** | [**java.util.UUID**](.md)| The id of the location to filter the users to sign out. | [optional]
 **event** | [**java.util.UUID**](.md)| The id of the event to filter the users to sign out. | [optional]
 **datetime** | **java.time.OffsetDateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="attendancelogWhosin"></a>
# **attendancelogWhosin**
> attendancelogWhosin(from, count, location, event, sorting, roles, photosize, extensions, export)

View who&#39;s in a location

Allows the user to view the Who&#39;s In page and view all users who are logged into locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AttendancelogApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to search for users that are in.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to search for users that are in.
val sorting : kotlin.String = sorting_example // kotlin.String | Field to sort by. Either first-name, last-name or sign-in-time.
val roles : kotlin.String = roles_example // kotlin.String | The comma-separated list of ids of the roles to search for users that are in.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
val extensions : kotlin.String = extensions_example // kotlin.String | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
val export : kotlin.Boolean = true // kotlin.Boolean | True to export the results as CSV
try {
    apiInstance.attendancelogWhosin(from, count, location, event, sorting, roles, photosize, extensions, export)
} catch (e: ClientException) {
    println("4xx response calling AttendancelogApi#attendancelogWhosin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AttendancelogApi#attendancelogWhosin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **location** | [**java.util.UUID**](.md)| The id of the location to search for users that are in. | [optional]
 **event** | [**java.util.UUID**](.md)| The id of the event to search for users that are in. | [optional]
 **sorting** | **kotlin.String**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional]
 **roles** | **kotlin.String**| The comma-separated list of ids of the roles to search for users that are in. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]
 **extensions** | **kotlin.String**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional]
 **export** | **kotlin.Boolean**| True to export the results as CSV | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

