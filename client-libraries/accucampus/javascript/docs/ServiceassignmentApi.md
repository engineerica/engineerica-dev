# AccuCampusOpenApi3.ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceassignmentAddservice**](ServiceassignmentApi.md#serviceassignmentAddservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**serviceassignmentGetlocation**](ServiceassignmentApi.md#serviceassignmentGetlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**serviceassignmentGetservice**](ServiceassignmentApi.md#serviceassignmentGetservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**serviceassignmentRemoveservice**](ServiceassignmentApi.md#serviceassignmentRemoveservice) | **GET** /serviceassignment/removeservice | Remove a service from a location



## serviceassignmentAddservice

> serviceassignmentAddservice(serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ServiceassignmentApi();
let serviceid = null; // String | The id of the service to add.
let locationid = null; // String | The id of the location.
apiInstance.serviceassignmentAddservice(serviceid, locationid, (error, data, response) => {
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
 **serviceid** | [**String**](.md)| The id of the service to add. | 
 **locationid** | [**String**](.md)| The id of the location. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignmentGetlocation

> serviceassignmentGetlocation(locationid, opts)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ServiceassignmentApi();
let locationid = null; // String | The id of the location to get.
let opts = {
  'includegloballyavailable': true, // Boolean | Specifies whether the services available globally must be returned or not.
  'namefilter': true, // Boolean | Filters the name of the services to return.
  'count': 56 // Number | The max number of services to return.
};
apiInstance.serviceassignmentGetlocation(locationid, opts, (error, data, response) => {
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
 **locationid** | [**String**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **Boolean**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **Boolean**| Filters the name of the services to return. | [optional] 
 **count** | **Number**| The max number of services to return. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignmentGetservice

> serviceassignmentGetservice(serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ServiceassignmentApi();
let serviceid = null; // String | The id of the service to get its locations.
apiInstance.serviceassignmentGetservice(serviceid, (error, data, response) => {
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
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignmentRemoveservice

> serviceassignmentRemoveservice(serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ServiceassignmentApi();
let serviceid = null; // String | The id of the service to remove.
let locationid = null; // String | The id of the location to remove the service from.
apiInstance.serviceassignmentRemoveservice(serviceid, locationid, (error, data, response) => {
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
 **serviceid** | [**String**](.md)| The id of the service to remove. | 
 **locationid** | [**String**](.md)| The id of the location to remove the service from. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

