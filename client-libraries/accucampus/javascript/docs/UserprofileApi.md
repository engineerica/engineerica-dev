# AccuCampusOpenApi3.UserprofileApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userprofileDelete**](UserprofileApi.md#userprofileDelete) | **DELETE** /userprofile/{id} | Delete a user profile
[**userprofileGet**](UserprofileApi.md#userprofileGet) | **GET** /userprofile/{id} | View a specific user profile
[**userprofileGetallview**](UserprofileApi.md#userprofileGetallview) | **GET** /userprofile/getallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**userprofileList**](UserprofileApi.md#userprofileList) | **GET** /userprofile/list | View the list of user profiles
[**userprofileListquestions**](UserprofileApi.md#userprofileListquestions) | **GET** /userprofile/listquestions | Gets the list of all the available user questions
[**userprofilePreparestats**](UserprofileApi.md#userprofilePreparestats) | **GET** /userprofile/preparestats | Gets the statistics of a user group
[**userprofileSave**](UserprofileApi.md#userprofileSave) | **POST** /userprofile/{id} | Create or edit user profile questions
[**userprofileSaveanswers**](UserprofileApi.md#userprofileSaveanswers) | **POST** /userprofile/saveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.



## userprofileDelete

> userprofileDelete(id, opts)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
let id = null; // String | The id of the user profile to delete.
let opts = {
  'body': new AccuCampusOpenApi3.AnyType() // AnyType | 
};
apiInstance.userprofileDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the user profile to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userprofileGet

> userprofileGet(id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
let id = null; // String | The id of the profile question set.
apiInstance.userprofileGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the profile question set. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofileGetallview

> userprofileGetallview(opts)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
let opts = {
  'id': null // String | The id of the user to view, or empty for current user.
};
apiInstance.userprofileGetallview(opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofileList

> userprofileList(opts)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
let opts = {
  'from': 56, // Number | The first record to return.
  'count': 56 // Number | The max number of records to return.
};
apiInstance.userprofileList(opts, (error, data, response) => {
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
 **from** | **Number**| The first record to return. | [optional] 
 **count** | **Number**| The max number of records to return. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofileListquestions

> userprofileListquestions()

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
apiInstance.userprofileListquestions((error, data, response) => {
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


## userprofilePreparestats

> userprofilePreparestats(opts)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
let opts = {
  'params': "params_example" // String | The ID of the group, specified as 'group=...'
};
apiInstance.userprofilePreparestats(opts, (error, data, response) => {
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
 **params** | **String**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofileSave

> userprofileSave(id, opts)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
let id = null; // String | The id of the profile question set.
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.userprofileSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the profile question set. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userprofileSaveanswers

> userprofileSaveanswers(opts)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.UserprofileApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuCampusOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.userprofileSaveanswers(opts, (error, data, response) => {
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

