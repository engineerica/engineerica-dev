# ClientApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**clientGet**](ClientApi.md#clientGet) | **GET** /client/get | Get client
[**clientList**](ClientApi.md#clientList) | **GET** /client/list | Gets the clients of the specified conference
[**clientSave**](ClientApi.md#clientSave) | **POST** /client/save | Saves a client
[**clientSendmessage**](ClientApi.md#clientSendmessage) | **GET** /client/sendmessage | Send a message to a client


<a name="clientGet"></a>
# **clientGet**
> clientGet(client, clientname)

Get client

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ClientApi()
val client : kotlin.String = client_example // kotlin.String | The unique id of the client.
val clientname : kotlin.String = clientname_example // kotlin.String | The custom name of the client.
try {
    apiInstance.clientGet(client, clientname)
} catch (e: ClientException) {
    println("4xx response calling ClientApi#clientGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ClientApi#clientGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **client** | **kotlin.String**| The unique id of the client. |
 **clientname** | **kotlin.String**| The custom name of the client. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="clientList"></a>
# **clientList**
> clientList(from, count)

Gets the clients of the specified conference

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ClientApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.clientList(from, count)
} catch (e: ClientException) {
    println("4xx response calling ClientApi#clientList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ClientApi#clientList")
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

<a name="clientSave"></a>
# **clientSave**
> clientSave(UNKNOWN_BASE_TYPE)

Saves a client

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ClientApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.clientSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ClientApi#clientSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ClientApi#clientSave")
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

<a name="clientSendmessage"></a>
# **clientSendmessage**
> clientSendmessage(uniqueclientid, message)

Send a message to a client

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ClientApi()
val uniqueclientid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The unique id of the client.
val message : kotlin.String = message_example // kotlin.String | The body of the message to send.
try {
    apiInstance.clientSendmessage(uniqueclientid, message)
} catch (e: ClientException) {
    println("4xx response calling ClientApi#clientSendmessage")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ClientApi#clientSendmessage")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueclientid** | [**java.util.UUID**](.md)| The unique id of the client. |
 **message** | **kotlin.String**| The body of the message to send. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

