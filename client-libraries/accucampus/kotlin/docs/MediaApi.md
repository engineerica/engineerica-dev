# MediaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mediaCheckin**](MediaApi.md#mediaCheckin) | **GET** /media/checkin | Check in media item
[**mediaCheckout**](MediaApi.md#mediaCheckout) | **GET** /media/checkout | Check out media item
[**mediaCheckoutlist**](MediaApi.md#mediaCheckoutlist) | **GET** /media/checkoutlist | View a list of past media checkouts
[**mediaDelete**](MediaApi.md#mediaDelete) | **DELETE** /media/{id} | Delete a media item
[**mediaDeletecheckoutlog**](MediaApi.md#mediaDeletecheckoutlog) | **DELETE** /media/deletecheckoutlog | Delete a media checkout log
[**mediaGet**](MediaApi.md#mediaGet) | **GET** /media/{id} | Search and view details of a media item
[**mediaGetbycode**](MediaApi.md#mediaGetbycode) | **GET** /media/getbycode | Search media item by unique code
[**mediaGetcheckout**](MediaApi.md#mediaGetcheckout) | **GET** /media/getcheckout | View details of a media item checkout information
[**mediaGetcheckoutlog**](MediaApi.md#mediaGetcheckoutlog) | **GET** /media/getcheckoutlog | View details of a media checkout log
[**mediaList**](MediaApi.md#mediaList) | **GET** /media/list | View a list of media items
[**mediaSave**](MediaApi.md#mediaSave) | **POST** /media/{id} | Create or edit a media item


<a name="mediaCheckin"></a>
# **mediaCheckin**
> mediaCheckin(media, checkindate, notes)

Check in media item

Allows the user to check in a media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val media : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to checkin.
val checkindate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The checkout date.
val notes : kotlin.String = notes_example // kotlin.String | The notes of the checkout.
try {
    apiInstance.mediaCheckin(media, checkindate, notes)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaCheckin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaCheckin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**java.util.UUID**](.md)| The id of the media item to checkin. |
 **checkindate** | **java.time.OffsetDateTime**| The checkout date. |
 **notes** | **kotlin.String**| The notes of the checkout. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaCheckout"></a>
# **mediaCheckout**
> mediaCheckout(media, user, checkoutdate, duedate, staff, event, notes)

Check out media item

Allows the user to check out a media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val media : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to checkout.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user that is checking the item out.
val checkoutdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The checkout date.
val duedate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date when the checkout is due.
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff member related to the checkout.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event related to the checkout.
val notes : kotlin.String = notes_example // kotlin.String | The notes of the checkout.
try {
    apiInstance.mediaCheckout(media, user, checkoutdate, duedate, staff, event, notes)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaCheckout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaCheckout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**java.util.UUID**](.md)| The id of the media item to checkout. |
 **user** | [**java.util.UUID**](.md)| The id of the user that is checking the item out. |
 **checkoutdate** | **java.time.OffsetDateTime**| The checkout date. |
 **duedate** | **java.time.OffsetDateTime**| The date when the checkout is due. |
 **staff** | [**java.util.UUID**](.md)| The id of the staff member related to the checkout. | [optional]
 **event** | [**java.util.UUID**](.md)| The id of the event related to the checkout. | [optional]
 **notes** | **kotlin.String**| The notes of the checkout. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaCheckoutlist"></a>
# **mediaCheckoutlist**
> mediaCheckoutlist(from, count, media, user, photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val media : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Used to filter the checkouts of a specific media item.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Used to filter the checkouts made by a specific user.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.mediaCheckoutlist(from, count, media, user, photosize)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaCheckoutlist")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaCheckoutlist")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **media** | [**java.util.UUID**](.md)| Used to filter the checkouts of a specific media item. | [optional]
 **user** | [**java.util.UUID**](.md)| Used to filter the checkouts made by a specific user. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaDelete"></a>
# **mediaDelete**
> mediaDelete(id, body)

Delete a media item

Allows the user to delete an existing media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.mediaDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the media item to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="mediaDeletecheckoutlog"></a>
# **mediaDeletecheckoutlog**
> mediaDeletecheckoutlog(UNKNOWN_BASE_TYPE)

Delete a media checkout log

Allows the user to delete a media item&#39;s checkout log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.mediaDeletecheckoutlog(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaDeletecheckoutlog")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaDeletecheckoutlog")
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

<a name="mediaGet"></a>
# **mediaGet**
> mediaGet(id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item to get.
try {
    apiInstance.mediaGet(id)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the media item to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaGetbycode"></a>
# **mediaGetbycode**
> mediaGetbycode(code, location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val code : kotlin.String = code_example // kotlin.String | The code of the media item to get.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The location where to look for the media item.
try {
    apiInstance.mediaGetbycode(code, location)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaGetbycode")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaGetbycode")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **kotlin.String**| The code of the media item to get. |
 **location** | [**java.util.UUID**](.md)| The location where to look for the media item. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaGetcheckout"></a>
# **mediaGetcheckout**
> mediaGetcheckout(id, photosize)

View details of a media item checkout information

Allows the user to view a media item&#39;s checkout information.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item whose checkout information has to be retrieved.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.mediaGetcheckout(id, photosize)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaGetcheckout")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaGetcheckout")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the media item whose checkout information has to be retrieved. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaGetcheckoutlog"></a>
# **mediaGetcheckoutlog**
> mediaGetcheckoutlog(id, photosize)

View details of a media checkout log

Allows the user to view a media item&#39;s checkout history.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item whose checkout information has to be retrieved.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.mediaGetcheckoutlog(id, photosize)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaGetcheckoutlog")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaGetcheckoutlog")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the media item whose checkout information has to be retrieved. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaList"></a>
# **mediaList**
> mediaList(from, count, status, user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val status : kotlin.Int = 56 // kotlin.Int | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Used to filter the media items that are checked-out by a specific user.
try {
    apiInstance.mediaList(from, count, status, user)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **status** | **kotlin.Int**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional]
 **user** | [**java.util.UUID**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="mediaSave"></a>
# **mediaSave**
> mediaSave(id, UNKNOWN_BASE_TYPE)

Create or edit a media item

Allows the user to create or edit a media item.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = MediaApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the media item save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.mediaSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling MediaApi#mediaSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling MediaApi#mediaSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the media item save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

