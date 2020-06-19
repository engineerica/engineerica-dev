# AccuClubOpenApi3.StationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**stationDelete**](StationApi.md#stationDelete) | **DELETE** /station/{id} | Delete a sign-in station
[**stationGet**](StationApi.md#stationGet) | **GET** /station/{id} | View details of a sign-in station
[**stationGetcurrentterms**](StationApi.md#stationGetcurrentterms) | **GET** /station/getcurrentterms | Get all the current terms
[**stationGetinfo**](StationApi.md#stationGetinfo) | **GET** /station/getinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**stationGetlicense**](StationApi.md#stationGetlicense) | **GET** /station/getlicense | Gets the current license information
[**stationList**](StationApi.md#stationList) | **GET** /station/list | View a list of sign-in stations
[**stationSave**](StationApi.md#stationSave) | **POST** /station/{id} | Create or edit a sign-in station
[**stationUnlock**](StationApi.md#stationUnlock) | **GET** /station/unlock | Unlocks the sign-in station.



## stationDelete

> stationDelete(id, opts)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.StationApi();
let id = null; // String | The id of the sign-in station to delete.
let opts = {
  'body': new AccuClubOpenApi3.AnyType() // AnyType | 
};
apiInstance.stationDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the sign-in station to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## stationGet

> stationGet(id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.StationApi();
let id = null; // String | The id of the sign-in station to get.
apiInstance.stationGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the sign-in station to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationGetcurrentterms

> stationGetcurrentterms(station)

Get all the current terms

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.StationApi();
let station = null; // String | The id of the sign-in station whose account's current terms have to be retrieved.
apiInstance.stationGetcurrentterms(station, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationGetinfo

> stationGetinfo(id, opts)

Gets a the info to display in the sign-in station by it&#39;s ID.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.StationApi();
let id = null; // String | The id of the sign-in station to get.
let opts = {
  'event': null // String | The id of the event, to override the one by schedule.
};
apiInstance.stationGetinfo(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the sign-in station to get. | 
 **event** | [**String**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationGetlicense

> stationGetlicense(station)

Gets the current license information

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.StationApi();
let station = "station_example"; // String | The id of the sign-in station whose account's license has to be retrieved.
apiInstance.stationGetlicense(station, (error, data, response) => {
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
 **station** | **String**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationList

> stationList(from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.StationApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.stationList(from, count, (error, data, response) => {
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

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## stationSave

> stationSave(id, opts)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.StationApi();
let id = null; // String | The id of the sign-in station to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.stationSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the sign-in station to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## stationUnlock

> stationUnlock(id, passcode, method)

Unlocks the sign-in station.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.StationApi();
let id = null; // String | The id of the sign-in station to unlock.
let passcode = "passcode_example"; // String | The passcode to unlock the station.
let method = "method_example"; // String | The authentication method. Valid values are 'token' and 'cookie'.
apiInstance.stationUnlock(id, passcode, method, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **String**| The passcode to unlock the station. | 
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

