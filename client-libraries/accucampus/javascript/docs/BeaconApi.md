# AccuCampusOpenApi3.BeaconApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**beaconDelete**](BeaconApi.md#beaconDelete) | **DELETE** /beacon/{id} | Delete a beacon profile
[**beaconDisable**](BeaconApi.md#beaconDisable) | **GET** /beacon/disable | Disable beacon support account wide
[**beaconGet**](BeaconApi.md#beaconGet) | **GET** /beacon/{id} | View details of a beacon profile
[**beaconGetlocations**](BeaconApi.md#beaconGetlocations) | **GET** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
[**beaconGetstationlocation**](BeaconApi.md#beaconGetstationlocation) | **GET** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
[**beaconGetuuid**](BeaconApi.md#beaconGetuuid) | **GET** /beacon/getuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconList**](BeaconApi.md#beaconList) | **GET** /beacon/list | View a list of beacon profiles
[**beaconListprofiles**](BeaconApi.md#beaconListprofiles) | **GET** /beacon/listprofiles | View a list of beacon profiles with their characteristics
[**beaconResetuuid**](BeaconApi.md#beaconResetuuid) | **GET** /beacon/resetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**beaconSave**](BeaconApi.md#beaconSave) | **POST** /beacon/{id} | Create or edit a beacon profile
[**beaconScanlocations**](BeaconApi.md#beaconScanlocations) | **GET** /beacon/scanlocations | Check if there&#39;s location available to sign-in / out.
[**beaconSetuuid**](BeaconApi.md#beaconSetuuid) | **GET** /beacon/setuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**beaconSilentregions**](BeaconApi.md#beaconSilentregions) | **GET** /beacon/silentregions | View all the beacon regions defined for silent tracking
[**beaconSilentsignin**](BeaconApi.md#beaconSilentsignin) | **GET** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
[**beaconSilentsignout**](BeaconApi.md#beaconSilentsignout) | **GET** /beacon/silentsignout | Sign-out silently from the location specified by a beacon



## beaconDelete

> beaconDelete(id, opts)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let id = null; // String | The id of the beacon to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.beaconDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the beacon to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## beaconDisable

> beaconDisable()

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
apiInstance.beaconDisable((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconGet

> beaconGet(id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let id = null; // String | The id of the beacon to get.
apiInstance.beaconGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the beacon to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconGetlocations

> beaconGetlocations(beacons)

Get the sign-in stations assigned to specific beacons.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let beacons = "beacons_example"; // String | A JSON array containg the beacons data (region, minor and major) values.
apiInstance.beaconGetlocations(beacons, (error, data, response) => {
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
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconGetstationlocation

> beaconGetstationlocation(station, location)

Get the location settings in the specified sign-in station.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let station = null; // String | The id of the sign-in station whose location information has to be retrieved.
let location = null; // String | The id of the location whose information has to be retrieved.
apiInstance.beaconGetstationlocation(station, location, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**String**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconGetuuid

> beaconGetuuid()

View the identifier for the account&#39;s beacon region (for sign-in stations).

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
apiInstance.beaconGetuuid((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconList

> beaconList(from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
apiInstance.beaconList(from, count, (error, data, response) => {
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


## beaconListprofiles

> beaconListprofiles()

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
apiInstance.beaconListprofiles((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconResetuuid

> beaconResetuuid()

Generate or reset the identifier for the account&#39;s beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
apiInstance.beaconResetuuid((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconSave

> beaconSave(id, opts)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let id = null; // String | The id of the beacon save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.beaconSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the beacon save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## beaconScanlocations

> beaconScanlocations(beacons)

Check if there&#39;s location available to sign-in / out.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let beacons = "beacons_example"; // String | A JSON array containg the beacons data (region, minor and major) values.
apiInstance.beaconScanlocations(beacons, (error, data, response) => {
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
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconSetuuid

> beaconSetuuid(id)

Set the identifier for the account&#39;s beacon region (for sign-in stations).

Allows the user to set the identifier for the account&#39;s beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let id = null; // String | The custom region UUID.
apiInstance.beaconSetuuid(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The custom region UUID. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconSilentregions

> beaconSilentregions()

View all the beacon regions defined for silent tracking

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
apiInstance.beaconSilentregions((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconSilentsignin

> beaconSilentsignin(uuid)

Sign-in silently from the location specified by a beacon

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let uuid = null; // String | The id of the region the user is in.
apiInstance.beaconSilentsignin(uuid, (error, data, response) => {
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
 **uuid** | [**String**](.md)| The id of the region the user is in. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beaconSilentsignout

> beaconSilentsignout(uuid)

Sign-out silently from the location specified by a beacon

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.BeaconApi();
let uuid = null; // String | The id of the region the user has left.
apiInstance.beaconSilentsignout(uuid, (error, data, response) => {
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
 **uuid** | [**String**](.md)| The id of the region the user has left. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

