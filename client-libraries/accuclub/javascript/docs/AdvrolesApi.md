# AccuClubOpenApi3.AdvrolesApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advrolesUserlist**](AdvrolesApi.md#advrolesUserlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.



## advrolesUserlist

> advrolesUserlist(from, count, opts)

List users. Alias to user.list, use that one instead.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvrolesApi();
let from = 56; // Number | The first record to return.
let count = 56; // Number | The max number of records to return.
let opts = {
  'roleid': null, // String | The id of the role to filter users by, or empty to return all users.
  'onlywithoutcard': "onlywithoutcard_example", // String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  'photosize': 56 // Number | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
};
apiInstance.advrolesUserlist(from, count, opts, (error, data, response) => {
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

