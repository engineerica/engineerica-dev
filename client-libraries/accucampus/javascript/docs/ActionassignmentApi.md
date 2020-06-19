# AccuCampusOpenApi3.ActionassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionassignmentDelete**](ActionassignmentApi.md#actionassignmentDelete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
[**actionassignmentGet**](ActionassignmentApi.md#actionassignmentGet) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**actionassignmentList**](ActionassignmentApi.md#actionassignmentList) | **GET** /actionassignment/list | View a list of action items in a user&#39;s plan
[**actionassignmentListhistory**](ActionassignmentApi.md#actionassignmentListhistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
[**actionassignmentListmine**](ActionassignmentApi.md#actionassignmentListmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
[**actionassignmentListpublichistory**](ActionassignmentApi.md#actionassignmentListpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
[**actionassignmentMarkcomplete**](ActionassignmentApi.md#actionassignmentMarkcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
[**actionassignmentSave**](ActionassignmentApi.md#actionassignmentSave) | **POST** /actionassignment/save | Add an action item to a user&#39;s action plan
[**actionassignmentSavehistory**](ActionassignmentApi.md#actionassignmentSavehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user



## actionassignmentDelete

> actionassignmentDelete(id, opts)

Remove an action item from an action plan

Allows a user to remove an action item from a user&#39;s action plan.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let id = null; // String | The id of the action assignment to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.actionassignmentDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the action assignment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actionassignmentGet

> actionassignmentGet(id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let id = null; // String | The id of the action assignment to get.
apiInstance.actionassignmentGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the action assignment to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentList

> actionassignmentList(from, count, opts)

View a list of action items in a user&#39;s plan

Allows the user to view the list of all action items for a specified user.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'assignee': 56, // Number | The assignee's id to filter the assignments.
  'status': 56 // Number | The status to filter the assignments.
};
apiInstance.actionassignmentList(from, count, opts, (error, data, response) => {
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
 **assignee** | **Number**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **Number**| The status to filter the assignments. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentListhistory

> actionassignmentListhistory(actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let actionassignment = null; // String | The action assignment's id whose history the user wants to get.
apiInstance.actionassignmentListhistory(actionassignment, (error, data, response) => {
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
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentListmine

> actionassignmentListmine(from, count, opts)

List public action assignments assigned to the logged user

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'status': 56 // Number | The status to filter the assignments.
};
apiInstance.actionassignmentListmine(from, count, opts, (error, data, response) => {
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
 **status** | **Number**| The status to filter the assignments. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentListpublichistory

> actionassignmentListpublichistory(actionassignment)

List public action assignment history

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let actionassignment = null; // String | The action assignment's id whose history the user wants to get.
apiInstance.actionassignmentListpublichistory(actionassignment, (error, data, response) => {
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
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentMarkcomplete

> actionassignmentMarkcomplete(item, opts)

Bulk complete action items

Allows the user to bulk complete action items.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let item = "item_example"; // String | The action item to assign.
let opts = {
  'assignee': null, // String | The assignee of the item.
  'group': null, // String | The group to assing the item.
  'notes': "notes_example" // String | The assignment's notes.
};
apiInstance.actionassignmentMarkcomplete(item, opts, (error, data, response) => {
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
 **item** | **String**| The action item to assign. | 
 **assignee** | [**String**](.md)| The assignee of the item. | [optional] 
 **group** | [**String**](.md)| The group to assing the item. | [optional] 
 **notes** | **String**| The assignment&#39;s notes. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignmentSave

> actionassignmentSave(opts)

Add an action item to a user&#39;s action plan

Allows the user to edit or assign an action item to a user

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.actionassignmentSave(opts, (error, data, response) => {
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


## actionassignmentSavehistory

> actionassignmentSavehistory(opts)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.ActionassignmentApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.actionassignmentSavehistory(opts, (error, data, response) => {
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

