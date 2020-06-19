# AccuClubOpenApi3.ReportApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportList**](ReportApi.md#reportList) | **GET** /report/list | View a list of available reports
[**reportPermissionsbyuser**](ReportApi.md#reportPermissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**reportPrepare**](ReportApi.md#reportPrepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**reportQuery**](ReportApi.md#reportQuery) | **GET** /report/query | Query and load a specified report



## reportList

> reportList()

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.ReportApi();
apiInstance.reportList((error, data, response) => {
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


## reportPermissionsbyuser

> reportPermissionsbyuser(opts)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.ReportApi();
let opts = {
  'params': "params_example" // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
};
apiInstance.reportPermissionsbyuser(opts, (error, data, response) => {
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
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportPrepare

> reportPrepare(reportname, opts)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.ReportApi();
let reportname = "reportname_example"; // String | The name of the report to execute
let opts = {
  'params': "params_example", // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
  'repformat': "repformat_example", // String | The format of the resulting report. Json, pdf, csv, ...
  'fillgroupid': null, // String | If specified, the result is used to fill the group with the given ID
  'groupby': "groupby_example", // String | How to group the records. In the format 'col1+col2|col3+col4
  'refreshgroup': null, // String | The ID of the group to check (and refresh) before processing the report.
  'filtertext': "filtertext_example" // String | The user friendly text of the applied filters.
};
apiInstance.reportPrepare(reportname, opts, (error, data, response) => {
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
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **String**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**String**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **String**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**String**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **String**| The user friendly text of the applied filters. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## reportQuery

> reportQuery(reportname, opts)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example

```javascript
import AccuClubOpenApi3 from 'accu_club_open_api_3';
let defaultClient = AccuClubOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuClubOpenApi3.ReportApi();
let reportname = "reportname_example"; // String | The name of the report to execute
let opts = {
  'params': "params_example" // String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
};
apiInstance.reportQuery(reportname, opts, (error, data, response) => {
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
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

