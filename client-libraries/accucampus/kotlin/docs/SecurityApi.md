# SecurityApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**securityAssesspermission**](SecurityApi.md#securityAssesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
[**securityAssessrole**](SecurityApi.md#securityAssessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
[**securityAssessscope**](SecurityApi.md#securityAssessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
[**securityAssessuser**](SecurityApi.md#securityAssessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user


<a name="securityAssesspermission"></a>
# **securityAssesspermission**
> securityAssesspermission(commandname)

Returns the list of users for a specific permission

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SecurityApi()
val commandname : kotlin.String = commandname_example // kotlin.String | Name of the action or command to get the roles.
try {
    apiInstance.securityAssesspermission(commandname)
} catch (e: ClientException) {
    println("4xx response calling SecurityApi#securityAssesspermission")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SecurityApi#securityAssesspermission")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commandname** | **kotlin.String**| Name of the action or command to get the roles. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="securityAssessrole"></a>
# **securityAssessrole**
> securityAssessrole(roleid)

Returns the list of permissions for a specific role

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SecurityApi()
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Role ID to list the effective permissions.
try {
    apiInstance.securityAssessrole(roleid)
} catch (e: ClientException) {
    println("4xx response calling SecurityApi#securityAssessrole")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SecurityApi#securityAssessrole")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**java.util.UUID**](.md)| Role ID to list the effective permissions. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="securityAssessscope"></a>
# **securityAssessscope**
> securityAssessscope(locationid)

Returns the list of users for a specific user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SecurityApi()
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Location ID to list the users with that scope.
try {
    apiInstance.securityAssessscope(locationid)
} catch (e: ClientException) {
    println("4xx response calling SecurityApi#securityAssessscope")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SecurityApi#securityAssessscope")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**java.util.UUID**](.md)| Location ID to list the users with that scope. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="securityAssessuser"></a>
# **securityAssessuser**
> securityAssessuser(userid)

Returns the list of permissions for a specific user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SecurityApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | User ID to list the effective permissions.
try {
    apiInstance.securityAssessuser(userid)
} catch (e: ClientException) {
    println("4xx response calling SecurityApi#securityAssessuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SecurityApi#securityAssessuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| User ID to list the effective permissions. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

