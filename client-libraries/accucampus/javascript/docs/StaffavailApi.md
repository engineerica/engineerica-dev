# AccuCampusOpenApi3.StaffavailApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**staffavailAddmetoallservices**](StaffavailApi.md#staffavailAddmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
[**staffavailAddmetoservice**](StaffavailApi.md#staffavailAddmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
[**staffavailAddusertoallservices**](StaffavailApi.md#staffavailAddusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
[**staffavailAddusertoservice**](StaffavailApi.md#staffavailAddusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
[**staffavailGetmyservices**](StaffavailApi.md#staffavailGetmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
[**staffavailGetservices**](StaffavailApi.md#staffavailGetservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
[**staffavailGetusersforservice**](StaffavailApi.md#staffavailGetusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**staffavailListtypes**](StaffavailApi.md#staffavailListtypes) | **GET** /staffavail/listtypes | View all the availability types
[**staffavailRemovemefromallservices**](StaffavailApi.md#staffavailRemovemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
[**staffavailRemovemefromservice**](StaffavailApi.md#staffavailRemovemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
[**staffavailRemoveuserfromallservices**](StaffavailApi.md#staffavailRemoveuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**staffavailRemoveuserfromservice**](StaffavailApi.md#staffavailRemoveuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
[**staffavailSetavailability**](StaffavailApi.md#staffavailSetavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
[**staffavailSetmyavailability**](StaffavailApi.md#staffavailSetmyavailability) | **GET** /staffavail/setmyavailability | Change current user&#39;s availability type



## staffavailAddmetoallservices

> staffavailAddmetoallservices()

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
apiInstance.staffavailAddmetoallservices((error, data, response) => {
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


## staffavailAddmetoservice

> staffavailAddmetoservice(serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let serviceid = null; // String | The id of the service.
apiInstance.staffavailAddmetoservice(serviceid, (error, data, response) => {
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
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailAddusertoallservices

> staffavailAddusertoallservices(userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let userid = null; // String | The id of the user to add.
apiInstance.staffavailAddusertoallservices(userid, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to add. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailAddusertoservice

> staffavailAddusertoservice(userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let userid = null; // String | The id of the user to add.
let serviceid = null; // String | The id of the service.
apiInstance.staffavailAddusertoservice(userid, serviceid, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to add. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailGetmyservices

> staffavailGetmyservices()

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
apiInstance.staffavailGetmyservices((error, data, response) => {
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


## staffavailGetservices

> staffavailGetservices(userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let userid = null; // String | The user id to list services.
apiInstance.staffavailGetservices(userid, (error, data, response) => {
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
 **userid** | [**String**](.md)| The user id to list services. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailGetusersforservice

> staffavailGetusersforservice(serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let serviceid = null; // String | The service id to list users.
apiInstance.staffavailGetusersforservice(serviceid, (error, data, response) => {
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
 **serviceid** | [**String**](.md)| The service id to list users. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailListtypes

> staffavailListtypes()

View all the availability types

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
apiInstance.staffavailListtypes((error, data, response) => {
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


## staffavailRemovemefromallservices

> staffavailRemovemefromallservices()

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
apiInstance.staffavailRemovemefromallservices((error, data, response) => {
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


## staffavailRemovemefromservice

> staffavailRemovemefromservice(serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let serviceid = null; // String | The id of the service.
apiInstance.staffavailRemovemefromservice(serviceid, (error, data, response) => {
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
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailRemoveuserfromallservices

> staffavailRemoveuserfromallservices(userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member&#39;s availability to all services.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let userid = null; // String | The id of the user to remove.
apiInstance.staffavailRemoveuserfromallservices(userid, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to remove. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailRemoveuserfromservice

> staffavailRemoveuserfromservice(userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member&#39;s service availability.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let userid = null; // String | The id of the user to remove.
let serviceid = null; // String | The id of the service.
apiInstance.staffavailRemoveuserfromservice(userid, serviceid, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailSetavailability

> staffavailSetavailability(userid, opts)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let userid = null; // String | The id of the user whose specific availability has to be set.
let opts = {
  'availablefor': "availablefor_example" // String | Specific availability to set.
};
apiInstance.staffavailSetavailability(userid, opts, (error, data, response) => {
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
 **userid** | [**String**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavailSetmyavailability

> staffavailSetmyavailability(opts)

Change current user&#39;s availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.StaffavailApi();
let opts = {
  'availablefor': "availablefor_example" // String | Specific availability to set.
};
apiInstance.staffavailSetmyavailability(opts, (error, data, response) => {
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
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

