# HolidayApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**holidayList**](HolidayApi.md#holidayList) | **GET** /holiday/list | View a list of entered holidays
[**holidaySave**](HolidayApi.md#holidaySave) | **POST** /holiday/save | Create or edit a list of holidays
[**holidaySuggest**](HolidayApi.md#holidaySuggest) | **GET** /holiday/suggest | View the holiday suggestions in the given term


<a name="holidayList"></a>
# **holidayList**
> holidayList(term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = HolidayApi()
val term : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term to get holidays from.
try {
    apiInstance.holidayList(term)
} catch (e: ClientException) {
    println("4xx response calling HolidayApi#holidayList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling HolidayApi#holidayList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**java.util.UUID**](.md)| The term to get holidays from. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="holidaySave"></a>
# **holidaySave**
> holidaySave(UNKNOWN_BASE_TYPE)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = HolidayApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.holidaySave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling HolidayApi#holidaySave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling HolidayApi#holidaySave")
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

<a name="holidaySuggest"></a>
# **holidaySuggest**
> holidaySuggest(term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = HolidayApi()
val term : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term to get holidays from.
try {
    apiInstance.holidaySuggest(term)
} catch (e: ClientException) {
    println("4xx response calling HolidayApi#holidaySuggest")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling HolidayApi#holidaySuggest")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**java.util.UUID**](.md)| The term to get holidays from. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

