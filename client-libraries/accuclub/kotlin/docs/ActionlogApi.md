# ActionlogApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionlogList**](ActionlogApi.md#actionlogList) | **GET** /actionlog/list | View a list of users action logs


<a name="actionlogList"></a>
# **actionlogList**
> actionlogList(from, count, user, startdate, enddate, resource, actionfilter, argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ActionlogApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user whose action logs have to be returned.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the logs.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the logs.
val resource : kotlin.String = resource_example // kotlin.String | The resource to filter the action logs.
val actionfilter : kotlin.String = actionfilter_example // kotlin.String | The action to filter the action logs.
val argument : kotlin.String = argument_example // kotlin.String | The id of the entity that was the argument of the executed action.
try {
    apiInstance.actionlogList(from, count, user, startdate, enddate, resource, actionfilter, argument)
} catch (e: ClientException) {
    println("4xx response calling ActionlogApi#actionlogList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ActionlogApi#actionlogList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **user** | [**java.util.UUID**](.md)| The id of the user whose action logs have to be returned. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the logs. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the logs. | [optional]
 **resource** | **kotlin.String**| The resource to filter the action logs. | [optional]
 **actionfilter** | **kotlin.String**| The action to filter the action logs. | [optional]
 **argument** | **kotlin.String**| The id of the entity that was the argument of the executed action. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

