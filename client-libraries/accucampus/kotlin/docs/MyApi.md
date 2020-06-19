# MyApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**myAccount**](MyApi.md#myAccount) | **GET** /my/account | Gets the logged in user account.
[**myIanatimezone**](MyApi.md#myIanatimezone) | **GET** /my/ianatimezone | Gets the current time zone&#39;s iana name
[**myProfile**](MyApi.md#myProfile) | **GET** /my/profile | Gets the logged in user information.
[**myRights**](MyApi.md#myRights) | **GET** /my/rights | Gets the list of actions the user can execute.
[**mySaveprofile**](MyApi.md#mySaveprofile) | **POST** /my/saveprofile | Updates logged user&#39;s profile information


<a name="myAccount"></a>
# **myAccount**
> myAccount()

Gets the logged in user account.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MyApi()
try {
    apiInstance.myAccount()
} catch (e: ClientException) {
    println("4xx response calling MyApi#myAccount")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MyApi#myAccount")
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

<a name="myIanatimezone"></a>
# **myIanatimezone**
> myIanatimezone()

Gets the current time zone&#39;s iana name

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MyApi()
try {
    apiInstance.myIanatimezone()
} catch (e: ClientException) {
    println("4xx response calling MyApi#myIanatimezone")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MyApi#myIanatimezone")
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

<a name="myProfile"></a>
# **myProfile**
> myProfile(photosize)

Gets the logged in user information.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MyApi()
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.myProfile(photosize)
} catch (e: ClientException) {
    println("4xx response calling MyApi#myProfile")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MyApi#myProfile")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="myRights"></a>
# **myRights**
> myRights()

Gets the list of actions the user can execute.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MyApi()
try {
    apiInstance.myRights()
} catch (e: ClientException) {
    println("4xx response calling MyApi#myRights")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MyApi#myRights")
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

<a name="mySaveprofile"></a>
# **mySaveprofile**
> mySaveprofile(UNKNOWN_BASE_TYPE)

Updates logged user&#39;s profile information

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MyApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.mySaveprofile(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling MyApi#mySaveprofile")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MyApi#mySaveprofile")
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

