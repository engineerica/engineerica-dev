# CreditApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**creditDelete**](CreditApi.md#creditDelete) | **DELETE** /credit/{id} | Delete a credit
[**creditDiscountmethods**](CreditApi.md#creditDiscountmethods) | **GET** /credit/discountmethods | Gets the valid discount methods.
[**creditGet**](CreditApi.md#creditGet) | **GET** /credit/{id} | View details of assigned credit
[**creditGetuserbalance**](CreditApi.md#creditGetuserbalance) | **GET** /credit/getuserbalance | Get the total amount of credits of the specified user
[**creditList**](CreditApi.md#creditList) | **GET** /credit/list | View a list of credits for a specific user
[**creditListdetails**](CreditApi.md#creditListdetails) | **GET** /credit/listdetails | Gets the credit usage details
[**creditListmine**](CreditApi.md#creditListmine) | **GET** /credit/listmine | View the list of credits of the current user
[**creditSave**](CreditApi.md#creditSave) | **POST** /credit/{id} | Create or edit credit for a user
[**creditSavedetails**](CreditApi.md#creditSavedetails) | **POST** /credit/savedetails | Create or edit credit details


<a name="creditDelete"></a>
# **creditDelete**
> creditDelete(id, body)

Delete a credit

Allows the user to delete credits.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the credit to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.creditDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the credit to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="creditDiscountmethods"></a>
# **creditDiscountmethods**
> creditDiscountmethods()

Gets the valid discount methods.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
try {
    apiInstance.creditDiscountmethods()
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditDiscountmethods")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditDiscountmethods")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="creditGet"></a>
# **creditGet**
> creditGet(id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the credit to get.
try {
    apiInstance.creditGet(id)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the credit to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="creditGetuserbalance"></a>
# **creditGetuserbalance**
> creditGetuserbalance(user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user whose balance has to be returned.
try {
    apiInstance.creditGetuserbalance(user)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditGetuserbalance")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditGetuserbalance")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**java.util.UUID**](.md)| The id of the user whose balance has to be returned. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="creditList"></a>
# **creditList**
> creditList(user, from, count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.creditList(user, from, count)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**java.util.UUID**](.md)| The id of the user. |
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

<a name="creditListdetails"></a>
# **creditListdetails**
> creditListdetails(credit, from, count)

Gets the credit usage details

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val credit : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the credit to look up for details.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.creditListdetails(credit, from, count)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditListdetails")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditListdetails")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credit** | [**java.util.UUID**](.md)| The id of the credit to look up for details. |
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

<a name="creditListmine"></a>
# **creditListmine**
> creditListmine(from, count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.creditListmine(from, count)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditListmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditListmine")
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

<a name="creditSave"></a>
# **creditSave**
> creditSave(id, UNKNOWN_BASE_TYPE)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the credit save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.creditSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the credit save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="creditSavedetails"></a>
# **creditSavedetails**
> creditSavedetails(UNKNOWN_BASE_TYPE)

Create or edit credit details

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CreditApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.creditSavedetails(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling CreditApi#creditSavedetails")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CreditApi#creditSavedetails")
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

