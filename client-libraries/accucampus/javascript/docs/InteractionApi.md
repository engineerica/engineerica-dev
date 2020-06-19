# AccuCampusOpenApi3.InteractionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**interactionDelete**](InteractionApi.md#interactionDelete) | **DELETE** /interaction/{id} | Delete an interaction
[**interactionFeed**](InteractionApi.md#interactionFeed) | **GET** /interaction/feed | Get the interactions feed
[**interactionGet**](InteractionApi.md#interactionGet) | **GET** /interaction/{id} | View an interaction
[**interactionListprivatesummary**](InteractionApi.md#interactionListprivatesummary) | **GET** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**interactionSave**](InteractionApi.md#interactionSave) | **POST** /interaction/{id} | Save an interaction



## interactionDelete

> interactionDelete(id, opts)

Delete an interaction

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.InteractionApi();
let id = null; // String | The id of the interaction to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.interactionDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the interaction to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## interactionFeed

> interactionFeed(from, count, opts)

Get the interactions feed

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.InteractionApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'startdate': new Date("2013-10-20T19:20:30+01:00"), // Date | If set, only interactions that happened after this date are returned.
  '_public': true, // Boolean | Specifies whether to return public or private interactions.
  'contexttype': "contexttype_example", // String | The type of the context of the interactions to return.
  'contextid': null, // String | The id of the context of the interactions to return.
  'types': "types_example", // String | The  comma separated types of the interactions to return.
  'photosize': 56, // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  'showdefaultphoto': true, // Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
  'orderdescending': true // Boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.
};
apiInstance.interactionFeed(from, count, opts, (error, data, response) => {
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
 **startdate** | **Date**| If set, only interactions that happened after this date are returned. | [optional] 
 **_public** | **Boolean**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **String**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**String**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **String**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **Boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionGet

> interactionGet(id, opts)

View an interaction

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.InteractionApi();
let id = "id_example"; // String | The id of the interaction.
let opts = {
  'thumbnailmediasize': 56, // Number | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.interactionGet(id, opts, (error, data, response) => {
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
 **id** | **String**| The id of the interaction. | 
 **thumbnailmediasize** | **Number**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionListprivatesummary

> interactionListprivatesummary(opts)

Get current user&#39;s latest private interactions

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.InteractionApi();
let opts = {
  'photosize': 56, // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  'showdefaultphoto': true // Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
};
apiInstance.interactionListprivatesummary(opts, (error, data, response) => {
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
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interactionSave

> interactionSave(id, opts)

Save an interaction

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.InteractionApi();
let id = null; // String | The id of the interaction to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.interactionSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the interaction to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

