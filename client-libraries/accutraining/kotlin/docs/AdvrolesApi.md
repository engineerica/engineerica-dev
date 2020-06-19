# AdvrolesApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advrolesUserlist**](AdvrolesApi.md#advrolesUserlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.


<a name="advrolesUserlist"></a>
# **advrolesUserlist**
> advrolesUserlist(from, count, roleid, onlywithoutcard, photosize)

List users. Alias to user.list, use that one instead.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvrolesApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role to filter users by, or empty to return all users.
val onlywithoutcard : kotlin.String = onlywithoutcard_example // kotlin.String | If is 1 then only the users without a card are returned, otherwise all users are returned.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.advrolesUserlist(from, count, roleid, onlywithoutcard, photosize)
} catch (e: ClientException) {
    println("4xx response calling AdvrolesApi#advrolesUserlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvrolesApi#advrolesUserlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **roleid** | [**java.util.UUID**](.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **kotlin.String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

