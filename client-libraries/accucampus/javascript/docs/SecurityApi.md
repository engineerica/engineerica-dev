# AccuCampusOpenApi3.SecurityApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**securityAssesspermission**](SecurityApi.md#securityAssesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
[**securityAssessrole**](SecurityApi.md#securityAssessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
[**securityAssessscope**](SecurityApi.md#securityAssessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
[**securityAssessuser**](SecurityApi.md#securityAssessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user



## securityAssesspermission

> securityAssesspermission(commandname)

Returns the list of users for a specific permission

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SecurityApi();
let commandname = "commandname_example"; // String | Name of the action or command to get the roles.
apiInstance.securityAssesspermission(commandname, (error, data, response) => {
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
 **commandname** | **String**| Name of the action or command to get the roles. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityAssessrole

> securityAssessrole(roleid)

Returns the list of permissions for a specific role

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SecurityApi();
let roleid = null; // String | Role ID to list the effective permissions.
apiInstance.securityAssessrole(roleid, (error, data, response) => {
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
 **roleid** | [**String**](.md)| Role ID to list the effective permissions. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityAssessscope

> securityAssessscope(opts)

Returns the list of users for a specific user

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SecurityApi();
let opts = {
  'locationid': null // String | Location ID to list the users with that scope.
};
apiInstance.securityAssessscope(opts, (error, data, response) => {
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
 **locationid** | [**String**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## securityAssessuser

> securityAssessuser(userid)

Returns the list of permissions for a specific user

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.SecurityApi();
let userid = null; // String | User ID to list the effective permissions.
apiInstance.securityAssessuser(userid, (error, data, response) => {
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
 **userid** | [**String**](.md)| User ID to list the effective permissions. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

