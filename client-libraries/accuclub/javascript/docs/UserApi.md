# AccuClubOpenApi3.UserApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userChangepwd**](UserApi.md#userChangepwd) | **GET** /user/changepwd | Change user&#39;s own password
[**userChangepwdbyreq**](UserApi.md#userChangepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
[**userDelete**](UserApi.md#userDelete) | **DELETE** /user/{id} | Delete a user
[**userFindsimilar**](UserApi.md#userFindsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
[**userGet**](UserApi.md#userGet) | **GET** /user/{id} | Search and view details of a user
[**userGetbycard**](UserApi.md#userGetbycard) | **GET** /user/getbycard | Search user by card number
[**userList**](UserApi.md#userList) | **GET** /user/list | View a list of users
[**userLoadphoto**](UserApi.md#userLoadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
[**userMovedata**](UserApi.md#userMovedata) | **GET** /user/movedata | Move data between users
[**userRequestpwdchange**](UserApi.md#userRequestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
[**userSave**](UserApi.md#userSave) | **POST** /user/{id} | Create or edit a user
[**userSavepwdchange**](UserApi.md#userSavepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords



## userChangepwd

> userChangepwd(oldpass, newpass)

Change user&#39;s own password

Allows the user to change their own password.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let oldpass = null; // String | The old password of the authenticated user.
let newpass = null; // String | The new password of the authenticated user.
apiInstance.userChangepwd(oldpass, newpass, (error, data, response) => {
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
 **oldpass** | [**String**](.md)| The old password of the authenticated user. | 
 **newpass** | [**String**](.md)| The new password of the authenticated user. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userChangepwdbyreq

> userChangepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.UserApi();
let changereq = "changereq_example"; // String | The change password request ID sent by email to the user.
let newpass = "newpass_example"; // String | The new password of the user.
apiInstance.userChangepwdbyreq(changereq, newpass, (error, data, response) => {
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
 **changereq** | **String**| The change password request ID sent by email to the user. | 
 **newpass** | **String**| The new password of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userDelete

> userDelete(id, opts)

Delete a user

Allows the user to delete a user.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let id = null; // String | The id of the user to delete.
let opts = {
  'body': new AccuClubOpenApi3.AnyType() // AnyType | 
};
apiInstance.userDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the user to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userFindsimilar

> userFindsimilar(opts)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let opts = {
  'currentid': null, // String | The id of the current user.
  'phonenumber': "phonenumber_example", // String | A phone number to search for similar users.
  'cardnumber': "cardnumber_example" // String | A card number to search for similar users.
};
apiInstance.userFindsimilar(opts, (error, data, response) => {
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
 **currentid** | [**String**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **String**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **String**| A card number to search for similar users. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userGet

> userGet(id, opts)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let id = null; // String | The id of the user to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.userGet(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the user to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userGetbycard

> userGetbycard(card, opts)

Search user by card number

Allows the user to search for a user by their card number.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let card = "card_example"; // String | The card number of the user to get.
let opts = {
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.userGetbycard(card, opts, (error, data, response) => {
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
 **card** | **String**| The card number of the user to get. | 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userList

> userList(from, count, opts)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'roleid': null, // String | The id of the role to filter users by, or empty to return all users.
  'onlywithoutcard': "onlywithoutcard_example", // String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.userList(from, count, opts, (error, data, response) => {
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
 **roleid** | [**String**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **Number**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userLoadphoto

> userLoadphoto(upload, opts)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let opts = {
  'filename': "filename_example", // String | The local name of the uploaded file. For later reference.
  'userid': null, // String | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
  'automatch': true // Boolean | Set this to true to find the specific user based on the file name. 
};
apiInstance.userLoadphoto(upload, opts, (error, data, response) => {
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
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**String**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **Boolean**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userMovedata

> userMovedata(source, destination)

Move data between users

Allows administrators to move data between users.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let source = null; // String | The id of the user that is the source of the data.
let destination = null; // String | The id of the user that is the destination of the data.
apiInstance.userMovedata(source, destination, (error, data, response) => {
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
 **source** | [**String**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**String**](.md)| The id of the user that is the destination of the data. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userRequestpwdchange

> userRequestpwdchange(domain, email)

Requests a password change

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.UserApi();
let domain = "domain_example"; // String | The domain of the account where the user exists.
let email = "email_example"; // String | The email of the user.
apiInstance.userRequestpwdchange(domain, email, (error, data, response) => {
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
 **domain** | **String**| The domain of the account where the user exists. | 
 **email** | **String**| The email of the user. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userSave

> userSave(id, opts)

Create or edit a user

Allows the user to create or edit a user.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let id = null; // String | The id of the user to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.userSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the user to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userSavepwdchange

> userSavepwdchange(opts)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.UserApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.userSavepwdchange(opts, (error, data, response) => {
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

