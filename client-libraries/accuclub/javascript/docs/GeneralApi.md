# AccuClubOpenApi3.GeneralApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**callExport**](GeneralApi.md#callExport) | **GET** /export | Export AccuClub data
[**callImport**](GeneralApi.md#callImport) | **GET** /import | Import data into AccuClub
[**changelog**](GeneralApi.md#changelog) | **GET** /changelog | Get the application change log
[**doc**](GeneralApi.md#doc) | **GET** /doc | Get the documentation
[**listtimezones**](GeneralApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**login**](GeneralApi.md#login) | **GET** /login | Login
[**logout**](GeneralApi.md#logout) | **GET** /logout | Logout
[**search**](GeneralApi.md#search) | **GET** /search | Search
[**texttoimage**](GeneralApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**version**](GeneralApi.md#version) | **GET** /version | Get current version information



## callExport

> callExport(exporttype, exportformat, opts)

Export AccuClub data

Allows the user to export data from AccuClub into a CSV, HTML, or Excel format.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.GeneralApi();
let exporttype = "exporttype_example"; // String | What to export.
let exportformat = "exportformat_example"; // String | The format of the resulting file. Valid types are CSV, HTML, XLS.
let opts = {
  'filters': "filters_example" // String | Pipe separated filters for the export, eg: aaa=val|bbb=val|...
};
apiInstance.callExport(exporttype, exportformat, opts, (error, data, response) => {
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
 **exporttype** | **String**| What to export. | 
 **exportformat** | **String**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **String**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## callImport

> callImport(importtype, upload, opts)

Import data into AccuClub

Allows the user to import data into AccuClub via CSV or flat files either manually or automatically using the import utility.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.GeneralApi();
let importtype = "importtype_example"; // String | The kind of data that is being uploaded.
let upload = "upload_example"; // String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
let opts = {
  'filename': "filename_example", // String | The local name of the uploaded file. For later reference.
  'parameters': "parameters_example" // String | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.
};
apiInstance.callImport(importtype, upload, opts, (error, data, response) => {
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
 **importtype** | **String**| The kind of data that is being uploaded. | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 
 **parameters** | **String**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## changelog

> changelog()

Get the application change log

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.GeneralApi();
apiInstance.changelog((error, data, response) => {
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


## doc

> doc(opts)

Get the documentation

Retrieves the list of actions available in the system.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.GeneralApi();
let opts = {
  'excludeanonymous': true // Boolean | If true it excludes the anonymous actions from the returned list.
};
apiInstance.doc(opts, (error, data, response) => {
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
 **excludeanonymous** | **Boolean**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## listtimezones

> listtimezones()

Lists the available timezones

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.GeneralApi();
apiInstance.listtimezones((error, data, response) => {
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

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## login

> login(domain, username, password, method, opts)

Login

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';

let apiInstance = new AccuClubOpenApi3.GeneralApi();
let domain = "domain_example"; // String | The account domain to login.
let username = "username_example"; // String | The username (email) of the user to login as.
let password = "password_example"; // String | The password of the user to login as.
let method = "method_example"; // String | The authentication method. Valid values are 'token' and 'cookie'.
let opts = {
  'rememberme': true // Boolean | If true then the session will not expire.
};
apiInstance.login(domain, username, password, method, opts, (error, data, response) => {
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
 **domain** | **String**| The account domain to login. | 
 **username** | **String**| The username (email) of the user to login as. | 
 **password** | **String**| The password of the user to login as. | 
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **Boolean**| If true then the session will not expire. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## logout

> logout()

Logout

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.GeneralApi();
apiInstance.logout((error, data, response) => {
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


## search

> search(query, opts)

Search

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.GeneralApi();
let query = "query_example"; // String | The query to search for.
let opts = {
  'page': 56 // Number | Current page to show, zero-based.
};
apiInstance.search(query, opts, (error, data, response) => {
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
 **query** | **String**| The query to search for. | 
 **page** | **Number**| Current page to show, zero-based. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## texttoimage

> texttoimage(text, opts)

Generates a dynamic image from text

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.GeneralApi();
let text = "text_example"; // String | The text to convert to an image, use double pipes (||) as a new line.
let opts = {
  'fontcolor': "fontcolor_example", // String | The color of the text, in hex format, without the #.
  'fontsize': 56, // Number | The size of the text, in points.
  'direction': "direction_example", // String | Either vertical or horizontal, default horizontal.
  'width': 56 // Number | The image width in pixels (or height if the direction is vertical).
};
apiInstance.texttoimage(text, opts, (error, data, response) => {
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
 **text** | **String**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **String**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **Number**| The size of the text, in points. | [optional] 
 **direction** | **String**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **Number**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## version

> version()

Get current version information

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.GeneralApi();
apiInstance.version((error, data, response) => {
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

