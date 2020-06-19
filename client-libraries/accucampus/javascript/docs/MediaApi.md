# AccuCampusOpenApi3.MediaApi

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



## mediaCheckin

> mediaCheckin(media, checkindate, opts)

Check in media item

Allows the user to check in a media item.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let media = null; // String | The id of the media item to checkin.
let checkindate = new Date("2013-10-20T19:20:30+01:00"); // Date | The checkout date.
let opts = {
  'notes': "notes_example" // String | The notes of the checkout.
};
apiInstance.mediaCheckin(media, checkindate, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**String**](.md)| The id of the media item to checkin. | 
 **checkindate** | **Date**| The checkout date. | 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaCheckout

> mediaCheckout(media, user, checkoutdate, duedate, opts)

Check out media item

Allows the user to check out a media item.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let media = null; // String | The id of the media item to checkout.
let user = null; // String | The id of the user that is checking the item out.
let checkoutdate = new Date("2013-10-20T19:20:30+01:00"); // Date | The checkout date.
let duedate = new Date("2013-10-20T19:20:30+01:00"); // Date | The date when the checkout is due.
let opts = {
  'staff': null, // String | The id of the staff member related to the checkout.
  'event': null, // String | The id of the event related to the checkout.
  'notes': "notes_example" // String | The notes of the checkout.
};
apiInstance.mediaCheckout(media, user, checkoutdate, duedate, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**String**](.md)| The id of the media item to checkout. | 
 **user** | [**String**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **Date**| The checkout date. | 
 **duedate** | **Date**| The date when the checkout is due. | 
 **staff** | [**String**](.md)| The id of the staff member related to the checkout. | [optional] 
 **event** | [**String**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaCheckoutlist

> mediaCheckoutlist(from, count, opts)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'media': null, // String | Used to filter the checkouts of a specific media item.
  'user': null, // String | Used to filter the checkouts made by a specific user.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.mediaCheckoutlist(from, count, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **media** | [**String**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**String**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaDelete

> mediaDelete(id, opts)

Delete a media item

Allows the user to delete an existing media item.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let id = null; // String | The id of the media item to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.mediaDelete(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## mediaDeletecheckoutlog

> mediaDeletecheckoutlog(opts)

Delete a media checkout log

Allows the user to delete a media item&#39;s checkout log.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.mediaDeletecheckoutlog(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## mediaGet

> mediaGet(id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let id = null; // String | The id of the media item to get.
apiInstance.mediaGet(id, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaGetbycode

> mediaGetbycode(code, opts)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let code = "code_example"; // String | The code of the media item to get.
let opts = {
  'location': null // String | The location where to look for the media item.
};
apiInstance.mediaGetbycode(code, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **String**| The code of the media item to get. | 
 **location** | [**String**](.md)| The location where to look for the media item. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaGetcheckout

> mediaGetcheckout(id, opts)

View details of a media item checkout information

Allows the user to view a media item&#39;s checkout information.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let id = null; // String | The id of the media item whose checkout information has to be retrieved.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.mediaGetcheckout(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaGetcheckoutlog

> mediaGetcheckoutlog(id, opts)

View details of a media checkout log

Allows the user to view a media item&#39;s checkout history.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let id = null; // String | The id of the media item whose checkout information has to be retrieved.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.mediaGetcheckoutlog(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaList

> mediaList(from, count, opts)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'status': 56, // Number | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
  'user': null // String | Used to filter the media items that are checked-out by a specific user.
};
apiInstance.mediaList(from, count, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Number**| The first record to return. | 
 **count** | **Number**| The max number of records to return. | 
 **status** | **Number**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**String**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediaSave

> mediaSave(id, opts)

Create or edit a media item

Allows the user to create or edit a media item.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.MediaApi();
let id = null; // String | The id of the media item save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.mediaSave(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

