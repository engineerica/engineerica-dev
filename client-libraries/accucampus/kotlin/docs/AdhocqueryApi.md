# AdhocqueryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocqueryCheckexecution**](AdhocqueryApi.md#adhocqueryCheckexecution) | **GET** /adhocquery/checkexecution | Check the status of an ad hoc query execution
[**adhocqueryDelete**](AdhocqueryApi.md#adhocqueryDelete) | **DELETE** /adhocquery/{id} | Delete an ad hoc query
[**adhocqueryExecute**](AdhocqueryApi.md#adhocqueryExecute) | **GET** /adhocquery/execute | Execute an ad hoc query
[**adhocqueryGet**](AdhocqueryApi.md#adhocqueryGet) | **GET** /adhocquery/{id} | View details of an ad hoc query
[**adhocqueryGetschema**](AdhocqueryApi.md#adhocqueryGetschema) | **GET** /adhocquery/getschema | View the database schema for making ad hoc queries
[**adhocqueryList**](AdhocqueryApi.md#adhocqueryList) | **GET** /adhocquery/list | View a list of saved ad hoc queries
[**adhocqueryListexecutions**](AdhocqueryApi.md#adhocqueryListexecutions) | **GET** /adhocquery/listexecutions | View a list of ad hoc queries executions
[**adhocquerySave**](AdhocqueryApi.md#adhocquerySave) | **POST** /adhocquery/{id} | Create or edit an ad hoc query
[**adhocqueryStopexecution**](AdhocqueryApi.md#adhocqueryStopexecution) | **GET** /adhocquery/stopexecution | Stops the execution of an ad hoc query


<a name="adhocqueryCheckexecution"></a>
# **adhocqueryCheckexecution**
> adhocqueryCheckexecution(id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query&#39;s execution page.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the ad hoc query execution to be checked.
try {
    apiInstance.adhocqueryCheckexecution(id)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryCheckexecution")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryCheckexecution")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the ad hoc query execution to be checked. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocqueryDelete"></a>
# **adhocqueryDelete**
> adhocqueryDelete(id, body)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the ad hoc query to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.adhocqueryDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the ad hoc query to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="adhocqueryExecute"></a>
# **adhocqueryExecute**
> adhocqueryExecute(id, query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the query to execute.
val query : kotlin.String = query_example // kotlin.String | The query to execute.
try {
    apiInstance.adhocqueryExecute(id, query)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryExecute")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryExecute")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the query to execute. | [optional]
 **query** | **kotlin.String**| The query to execute. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocqueryGet"></a>
# **adhocqueryGet**
> adhocqueryGet(id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the query to get.
try {
    apiInstance.adhocqueryGet(id)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the query to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocqueryGetschema"></a>
# **adhocqueryGetschema**
> adhocqueryGetschema()

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
try {
    apiInstance.adhocqueryGetschema()
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryGetschema")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryGetschema")
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

<a name="adhocqueryList"></a>
# **adhocqueryList**
> adhocqueryList(from, count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.adhocqueryList(from, count)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryList")
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

<a name="adhocqueryListexecutions"></a>
# **adhocqueryListexecutions**
> adhocqueryListexecutions(from, count, query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val query : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The first record to return.
try {
    apiInstance.adhocqueryListexecutions(from, count, query)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryListexecutions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryListexecutions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **query** | [**java.util.UUID**](.md)| The first record to return. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="adhocquerySave"></a>
# **adhocquerySave**
> adhocquerySave(id, UNKNOWN_BASE_TYPE)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the query to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.adhocquerySave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocquerySave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocquerySave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the query to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="adhocqueryStopexecution"></a>
# **adhocqueryStopexecution**
> adhocqueryStopexecution(id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdhocqueryApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the ad hoc query execution to be stopped.
try {
    apiInstance.adhocqueryStopexecution(id)
} catch (e: ClientException) {
    println("4xx response calling AdhocqueryApi#adhocqueryStopexecution")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdhocqueryApi#adhocqueryStopexecution")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the ad hoc query execution to be stopped. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

