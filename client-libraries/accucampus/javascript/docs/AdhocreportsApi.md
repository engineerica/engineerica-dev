# AccuCampusOpenApi3.AdhocreportsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocreportsReqaccess**](AdhocreportsApi.md#adhocreportsReqaccess) | **GET** /adhocreports/reqaccess | Request access to the ad-hoc reports



## adhocreportsReqaccess

> adhocreportsReqaccess()

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, &#39;Request Access&#39; under Institutional Research -&gt; Ad-hoc Reports

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.AdhocreportsApi();
apiInstance.adhocreportsReqaccess((error, data, response) => {
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

