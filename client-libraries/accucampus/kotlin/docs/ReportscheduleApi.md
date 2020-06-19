# ReportscheduleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportscheduleDelete**](ReportscheduleApi.md#reportscheduleDelete) | **DELETE** /reportschedule/{id} | Delete a report schedule
[**reportscheduleGet**](ReportscheduleApi.md#reportscheduleGet) | **GET** /reportschedule/{id} | Get a report schedule
[**reportscheduleList**](ReportscheduleApi.md#reportscheduleList) | **GET** /reportschedule/list | View a list of the scheduled reports
[**reportscheduleSave**](ReportscheduleApi.md#reportscheduleSave) | **POST** /reportschedule/{id} | Create or edit a report schedule


<a name="reportscheduleDelete"></a>
# **reportscheduleDelete**
> reportscheduleDelete(id, body)

Delete a report schedule

Allows the user to delete a scheduled report that they created.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportscheduleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the report schedule to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.reportscheduleDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling ReportscheduleApi#reportscheduleDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportscheduleApi#reportscheduleDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the report schedule to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="reportscheduleGet"></a>
# **reportscheduleGet**
> reportscheduleGet(id)

Get a report schedule

Allows the user to view the list of reports that they scheduled.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportscheduleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule to get.
try {
    apiInstance.reportscheduleGet(id)
} catch (e: ClientException) {
    println("4xx response calling ReportscheduleApi#reportscheduleGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportscheduleApi#reportscheduleGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the schedule to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportscheduleList"></a>
# **reportscheduleList**
> reportscheduleList(from, count)

View a list of the scheduled reports

Allows the user to view a list of the scheduled reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportscheduleApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.reportscheduleList(from, count)
} catch (e: ClientException) {
    println("4xx response calling ReportscheduleApi#reportscheduleList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportscheduleApi#reportscheduleList")
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

<a name="reportscheduleSave"></a>
# **reportscheduleSave**
> reportscheduleSave(id, UNKNOWN_BASE_TYPE)

Create or edit a report schedule

Allows the user to create or edit a scheduled report.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportscheduleApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the schedule save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.reportscheduleSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ReportscheduleApi#reportscheduleSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportscheduleApi#reportscheduleSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the schedule save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

