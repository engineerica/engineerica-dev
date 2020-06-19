# UserApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userChangepwd**](UserApi.md#userChangepwd) | **GET** /user/changepwd | Change user&#39;s own password
[**userChangepwdbyreq**](UserApi.md#userChangepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
[**userDelete**](UserApi.md#userDelete) | **DELETE** /user/{id} | Delete a user
[**userFindsimilar**](UserApi.md#userFindsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
[**userGet**](UserApi.md#userGet) | **GET** /user/{id} | Search and view details of a user
[**userGetbycard**](UserApi.md#userGetbycard) | **GET** /user/getbycard | Search user by card number
[**userList**](UserApi.md#userList) | **GET** /user/list | View a list of users
[**userLoadphoto**](UserApi.md#userLoadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
[**userMovedata**](UserApi.md#userMovedata) | **GET** /user/movedata | Move data between users
[**userRequestpwdchange**](UserApi.md#userRequestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
[**userSave**](UserApi.md#userSave) | **POST** /user/{id} | Create or edit a user
[**userSavepwdchange**](UserApi.md#userSavepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords


<a name="userChangepwd"></a>
# **userChangepwd**
> userChangepwd(oldpass, newpass)

Change user&#39;s own password

Allows the user to change their own password.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val oldpass : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The old password of the authenticated user.
val newpass : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The new password of the authenticated user.
try {
    apiInstance.userChangepwd(oldpass, newpass)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userChangepwd")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userChangepwd")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oldpass** | [**java.util.UUID**](.md)| The old password of the authenticated user. |
 **newpass** | [**java.util.UUID**](.md)| The new password of the authenticated user. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userChangepwdbyreq"></a>
# **userChangepwdbyreq**
> userChangepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val changereq : kotlin.String = changereq_example // kotlin.String | The change password request ID sent by email to the user.
val newpass : kotlin.String = newpass_example // kotlin.String | The new password of the user.
try {
    apiInstance.userChangepwdbyreq(changereq, newpass)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userChangepwdbyreq")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userChangepwdbyreq")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **kotlin.String**| The change password request ID sent by email to the user. |
 **newpass** | **kotlin.String**| The new password of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userDelete"></a>
# **userDelete**
> userDelete(id, body)

Delete a user

Allows the user to delete a user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.userDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the user to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userFindsimilar"></a>
# **userFindsimilar**
> userFindsimilar(currentid, phonenumber, cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val currentid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the current user.
val phonenumber : kotlin.String = phonenumber_example // kotlin.String | A phone number to search for similar users.
val cardnumber : kotlin.String = cardnumber_example // kotlin.String | A card number to search for similar users.
try {
    apiInstance.userFindsimilar(currentid, phonenumber, cardnumber)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userFindsimilar")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userFindsimilar")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentid** | [**java.util.UUID**](.md)| The id of the current user. | [optional]
 **phonenumber** | **kotlin.String**| A phone number to search for similar users. | [optional]
 **cardnumber** | **kotlin.String**| A card number to search for similar users. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userGet"></a>
# **userGet**
> userGet(id, photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.userGet(id, photosize)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the user to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userGetbycard"></a>
# **userGetbycard**
> userGetbycard(card, photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val card : kotlin.String = card_example // kotlin.String | The card number of the user to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.userGetbycard(card, photosize)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userGetbycard")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userGetbycard")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **card** | **kotlin.String**| The card number of the user to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userList"></a>
# **userList**
> userList(from, count, roleid, onlywithoutcard, photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the role to filter users by, or empty to return all users.
val onlywithoutcard : kotlin.String = onlywithoutcard_example // kotlin.String | If is 1 then only the users without a card are returned, otherwise all users are returned.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.userList(from, count, roleid, onlywithoutcard, photosize)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userList")
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

<a name="userLoadphoto"></a>
# **userLoadphoto**
> userLoadphoto(upload, filename, userid, automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val upload : kotlin.String = upload_example // kotlin.String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
val filename : kotlin.String = filename_example // kotlin.String | The local name of the uploaded file. For later reference.
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
val automatch : kotlin.Boolean = true // kotlin.Boolean | Set this to true to find the specific user based on the file name. 
try {
    apiInstance.userLoadphoto(upload, filename, userid, automatch)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userLoadphoto")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userLoadphoto")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **kotlin.String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **kotlin.String**| The local name of the uploaded file. For later reference. | [optional]
 **userid** | [**java.util.UUID**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional]
 **automatch** | **kotlin.Boolean**| Set this to true to find the specific user based on the file name.  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userMovedata"></a>
# **userMovedata**
> userMovedata(source, destination)

Move data between users

Allows administrators to move data between users.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val source : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user that is the source of the data.
val destination : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user that is the destination of the data.
try {
    apiInstance.userMovedata(source, destination)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userMovedata")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userMovedata")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | [**java.util.UUID**](.md)| The id of the user that is the source of the data. |
 **destination** | [**java.util.UUID**](.md)| The id of the user that is the destination of the data. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userRequestpwdchange"></a>
# **userRequestpwdchange**
> userRequestpwdchange(domain, email)

Requests a password change

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val domain : kotlin.String = domain_example // kotlin.String | The domain of the account where the user exists.
val email : kotlin.String = email_example // kotlin.String | The email of the user.
try {
    apiInstance.userRequestpwdchange(domain, email)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userRequestpwdchange")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userRequestpwdchange")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **kotlin.String**| The domain of the account where the user exists. |
 **email** | **kotlin.String**| The email of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userSave"></a>
# **userSave**
> userSave(id, UNKNOWN_BASE_TYPE)

Create or edit a user

Allows the user to create or edit a user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.userSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the user to save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userSavepwdchange"></a>
# **userSavepwdchange**
> userSavepwdchange(UNKNOWN_BASE_TYPE)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.userSavepwdchange(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UserApi#userSavepwdchange")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserApi#userSavepwdchange")
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

