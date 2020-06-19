# OpenapiClient::AdhocreportsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocreports_reqaccess**](AdhocreportsApi.md#adhocreports_reqaccess) | **GET** /adhocreports/reqaccess | Request access to the ad-hoc reports



## adhocreports_reqaccess

> adhocreports_reqaccess

Request access to the ad-hoc reports

Allows the user to request access to the ad-hoc reports by clicking, 'Request Access' under Institutional Research -> Ad-hoc Reports

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocreportsApi.new

begin
  #Request access to the ad-hoc reports
  api_instance.adhocreports_reqaccess
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocreportsApi->adhocreports_reqaccess: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

