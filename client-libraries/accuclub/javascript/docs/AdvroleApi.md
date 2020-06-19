# AccuClubOpenApi3.AdvroleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advroleAddmissing**](AdvroleApi.md#advroleAddmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**advroleCheckperm**](AdvroleApi.md#advroleCheckperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
[**advroleDelete**](AdvroleApi.md#advroleDelete) | **DELETE** /advrole/{id} | Delete a role
[**advroleDeletemapping**](AdvroleApi.md#advroleDeletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
[**advroleGet**](AdvroleApi.md#advroleGet) | **GET** /advrole/{id} | View details of a role
[**advroleList**](AdvroleApi.md#advroleList) | **GET** /advrole/list | Lists the roles for the current account
[**advroleListmaps**](AdvroleApi.md#advroleListmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
[**advroleListrolesmapped**](AdvroleApi.md#advroleListrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
[**advroleListtemplates**](AdvroleApi.md#advroleListtemplates) | **GET** /advrole/listtemplates | View a list of role templates
[**advroleSave**](AdvroleApi.md#advroleSave) | **POST** /advrole/{id} | Create or edit a role
[**advroleSavemapping**](AdvroleApi.md#advroleSavemapping) | **POST** /advrole/savemapping | Saves a role mapping
[**advroleUserupgrade**](AdvroleApi.md#advroleUserupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)



## advroleAddmissing

> advroleAddmissing(roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let roles = "roles_example"; // String | CSV list of the role ids to check
let permissions = "permissions_example"; // String | CSV list of the permissions to check
apiInstance.advroleAddmissing(roles, permissions, (error, data, response) => {
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
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleCheckperm

> advroleCheckperm(roles, permissions)

Checks the permissions are assigned for the given roles

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let roles = "roles_example"; // String | CSV list of the role ids to check
let permissions = "permissions_example"; // String | CSV list of the permissions to check
apiInstance.advroleCheckperm(roles, permissions, (error, data, response) => {
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
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleDelete

> advroleDelete(id, opts)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let id = null; // String | The id of the location to delete.
let opts = {
  'body': new AccuClubOpenApi3.AnyType() // AnyType | 
};
apiInstance.advroleDelete(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the location to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advroleDeletemapping

> advroleDeletemapping(opts)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.advroleDeletemapping(opts, (error, data, response) => {
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


## advroleGet

> advroleGet(id)

View details of a role

Allows the user to view a role and its details.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let id = null; // String | The id of the location to get.
apiInstance.advroleGet(id, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the location to get. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleList

> advroleList(opts)

Lists the roles for the current account

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let opts = {
  'includepolicies': true, // Boolean | True to include the policies, defaults to false.
  'includeinternal': true, // Boolean | True to include the internal roles too.
  'name': "name_example" // String | Filter by name of the role.
};
apiInstance.advroleList(opts, (error, data, response) => {
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
 **includepolicies** | **Boolean**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **Boolean**| True to include the internal roles too. | [optional] 
 **name** | **String**| Filter by name of the role. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleListmaps

> advroleListmaps(roleid)

Lists the maps a roles is mapped to

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let roleid = null; // String | The id of the role to list the maps.
apiInstance.advroleListmaps(roleid, (error, data, response) => {
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
 **roleid** | [**String**](.md)| The id of the role to list the maps. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleListrolesmapped

> advroleListrolesmapped(opts)

Lists the roles mappings

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let opts = {
  'map': "map_example" // String | List only the roles in the specified map.
};
apiInstance.advroleListrolesmapped(opts, (error, data, response) => {
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
 **map** | **String**| List only the roles in the specified map. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advroleListtemplates

> advroleListtemplates()

View a list of role templates

Allows the user to view the full list of available role templates.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
apiInstance.advroleListtemplates((error, data, response) => {
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


## advroleSave

> advroleSave(id, opts)

Create or edit a role

Allows the user to create or edit a role&#39;s permissions.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let id = null; // String | The id of the role to save (leave empty to create a new one).
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.advroleSave(id, opts, (error, data, response) => {
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
 **id** | [**String**](.md)| The id of the role to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advroleSavemapping

> advroleSavemapping(opts)

Saves a role mapping

Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let opts = {
  'UNKNOWN_BASE_TYPE': new AccuClubOpenApi3.UNKNOWN_BASE_TYPE() // UNKNOWN_BASE_TYPE | 
};
apiInstance.advroleSavemapping(opts, (error, data, response) => {
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


## advroleUserupgrade

> advroleUserupgrade(userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.AdvroleApi();
let userid = null; // String | Id of the user to upgrade
let roleid = null; // String | Id of the role to add
apiInstance.advroleUserupgrade(userid, roleid, (error, data, response) => {
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
 **userid** | [**String**](.md)| Id of the user to upgrade | 
 **roleid** | [**String**](.md)| Id of the role to add | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

