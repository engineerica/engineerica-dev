# AccuCampusOpenApi3.ComputerlabApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**computerlabDeletecomputer**](ComputerlabApi.md#computerlabDeletecomputer) | **DELETE** /computerlab/deletecomputer | Delete a computer
[**computerlabGetcomputer**](ComputerlabApi.md#computerlabGetcomputer) | **GET** /computerlab/getcomputer | Search and view details of a computer
[**computerlabGetsettings**](ComputerlabApi.md#computerlabGetsettings) | **GET** /computerlab/getsettings | Loads the settings for a computer lab
[**computerlabIssignedin**](ComputerlabApi.md#computerlabIssignedin) | **GET** /computerlab/issignedin | Gets whether a user is signed-in or not.
[**computerlabListcomputers**](ComputerlabApi.md#computerlabListcomputers) | **GET** /computerlab/listcomputers | View a list of computers
[**computerlabListlabs**](ComputerlabApi.md#computerlabListlabs) | **GET** /computerlab/listlabs | View a list of the locations that use the Computer Lab add-on
[**computerlabListstations**](ComputerlabApi.md#computerlabListstations) | **GET** /computerlab/liststations | View a list of sign-in stations available for computer labs.
[**computerlabSavecomputer**](ComputerlabApi.md#computerlabSavecomputer) | **POST** /computerlab/savecomputer | Create or edit a computer
[**computerlabSavesettings**](ComputerlabApi.md#computerlabSavesettings) | **POST** /computerlab/savesettings | Saves the settings for a computer lab
[**computerlabSaveswipe**](ComputerlabApi.md#computerlabSaveswipe) | **POST** /computerlab/saveswipe | Save a new swipe from a computer in a computer lab.



## computerlabDeletecomputer

> computerlabDeletecomputer(opts)

Delete a computer

Allows the user to delete an existing computer.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.computerlabDeletecomputer(opts, (error, data, response) => {
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


## computerlabGetcomputer

> computerlabGetcomputer(id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let id = "id_example"; // String | The unique device id of the computer to get.
apiInstance.computerlabGetcomputer(id, (error, data, response) => {
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
 **id** | **String**| The unique device id of the computer to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabGetsettings

> computerlabGetsettings(id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let id = null; // String | The id of the computer lab/location.
apiInstance.computerlabGetsettings(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the computer lab/location. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabIssignedin

> computerlabIssignedin(station, user)

Gets whether a user is signed-in or not.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let station = null; // String | The id of the sign-in station to get.
let user = "user_example"; // String | The card of the user.
apiInstance.computerlabIssignedin(station, user, (error, data, response) => {
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
 **station** | [**String**](.md)| The id of the sign-in station to get. | 
 **user** | **String**| The card of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabListcomputers

> computerlabListcomputers(from, count, opts)

View a list of computers

Allows the user to view the list of all computers.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'location': null, // String | The id of the location whose computers have to be returned.
  'freeonly': true // Boolean | If true, only free computers will be returned.
};
apiInstance.computerlabListcomputers(from, count, opts, (error, data, response) => {
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
 **location** | [**String**](.md)| The id of the location whose computers have to be returned. | [optional] 
 **freeonly** | **Boolean**| If true, only free computers will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## computerlabListlabs

> computerlabListlabs()

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
apiInstance.computerlabListlabs((error, data, response) => {
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


## computerlabListstations

> computerlabListstations()

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
apiInstance.computerlabListstations((error, data, response) => {
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


## computerlabSavecomputer

> computerlabSavecomputer(opts)

Create or edit a computer

Allows the user to create or edit a computer.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.computerlabSavecomputer(opts, (error, data, response) => {
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


## computerlabSavesettings

> computerlabSavesettings(opts)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.computerlabSavesettings(opts, (error, data, response) => {
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


## computerlabSaveswipe

> computerlabSaveswipe(opts)

Save a new swipe from a computer in a computer lab.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.ComputerlabApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.computerlabSaveswipe(opts, (error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

