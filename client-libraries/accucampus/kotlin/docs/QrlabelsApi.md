# QrlabelsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**qrlabelsPrint**](QrlabelsApi.md#qrlabelsPrint) | **GET** /qrlabels/print | Print and email QR labels


<a name="qrlabelsPrint"></a>
# **qrlabelsPrint**
> qrlabelsPrint(user, group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = QrlabelsApi()
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user whose label needs to be printed.
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the group whose members' labels need to be printed.
try {
    apiInstance.qrlabelsPrint(user, group)
} catch (e: ClientException) {
    println("4xx response calling QrlabelsApi#qrlabelsPrint")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling QrlabelsApi#qrlabelsPrint")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**java.util.UUID**](.md)| The id of the user whose label needs to be printed. | [optional]
 **group** | [**java.util.UUID**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

