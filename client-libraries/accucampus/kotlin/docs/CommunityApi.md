# CommunityApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**communityInvite**](CommunityApi.md#communityInvite) | **GET** /community/invite | Sends an invitation to everyone to AccuCampus Communities
[**communityJoin**](CommunityApi.md#communityJoin) | **GET** /community/join | Sends an invitation for myself to AccuCampus Communities


<a name="communityInvite"></a>
# **communityInvite**
> communityInvite()

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CommunityApi()
try {
    apiInstance.communityInvite()
} catch (e: ClientException) {
    println("4xx response calling CommunityApi#communityInvite")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CommunityApi#communityInvite")
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

<a name="communityJoin"></a>
# **communityJoin**
> communityJoin()

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = CommunityApi()
try {
    apiInstance.communityJoin()
} catch (e: ClientException) {
    println("4xx response calling CommunityApi#communityJoin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling CommunityApi#communityJoin")
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

