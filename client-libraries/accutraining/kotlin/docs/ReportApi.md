# ReportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportList**](ReportApi.md#reportList) | **GET** /report/list | View a list of available reports
[**reportPermissionsbyuser**](ReportApi.md#reportPermissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**reportPrepare**](ReportApi.md#reportPrepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**reportQuery**](ReportApi.md#reportQuery) | **GET** /report/query | Query and load a specified report


<a name="reportList"></a>
# **reportList**
> reportList()

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportApi()
try {
    apiInstance.reportList()
} catch (e: ClientException) {
    println("4xx response calling ReportApi#reportList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportApi#reportList")
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

<a name="reportPermissionsbyuser"></a>
# **reportPermissionsbyuser**
> reportPermissionsbyuser(params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportApi()
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
try {
    apiInstance.reportPermissionsbyuser(params)
} catch (e: ClientException) {
    println("4xx response calling ReportApi#reportPermissionsbyuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportApi#reportPermissionsbyuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportPrepare"></a>
# **reportPrepare**
> reportPrepare(reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportApi()
val reportname : kotlin.String = reportname_example // kotlin.String | The name of the report to execute
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
val repformat : kotlin.String = repformat_example // kotlin.String | The format of the resulting report. Json, pdf, csv, ...
val fillgroupid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | If specified, the result is used to fill the group with the given ID
val groupby : kotlin.String = groupby_example // kotlin.String | How to group the records. In the format 'col1+col2|col3+col4
val refreshgroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group to check (and refresh) before processing the report.
val filtertext : kotlin.String = filtertext_example // kotlin.String | The user friendly text of the applied filters.
try {
    apiInstance.reportPrepare(reportname, params, repformat, fillgroupid, groupby, refreshgroup, filtertext)
} catch (e: ClientException) {
    println("4xx response calling ReportApi#reportPrepare")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportApi#reportPrepare")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **kotlin.String**| The name of the report to execute |
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **repformat** | **kotlin.String**| The format of the resulting report. Json, pdf, csv, ... | [optional]
 **fillgroupid** | [**java.util.UUID**](.md)| If specified, the result is used to fill the group with the given ID | [optional]
 **groupby** | **kotlin.String**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional]
 **refreshgroup** | [**java.util.UUID**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional]
 **filtertext** | **kotlin.String**| The user friendly text of the applied filters. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="reportQuery"></a>
# **reportQuery**
> reportQuery(reportname, params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ReportApi()
val reportname : kotlin.String = reportname_example // kotlin.String | The name of the report to execute
val params : kotlin.String = params_example // kotlin.String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
try {
    apiInstance.reportQuery(reportname, params)
} catch (e: ClientException) {
    println("4xx response calling ReportApi#reportQuery")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ReportApi#reportQuery")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **kotlin.String**| The name of the report to execute |
 **params** | **kotlin.String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

