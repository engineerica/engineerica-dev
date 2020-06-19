# OpenapiClient::ReportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**report_list**](ReportApi.md#report_list) | **GET** /report/list | View a list of available reports
[**report_permissionsbyuser**](ReportApi.md#report_permissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**report_prepare**](ReportApi.md#report_prepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**report_query**](ReportApi.md#report_query) | **GET** /report/query | Query and load a specified report



## report_list

> report_list

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportApi.new

begin
  #View a list of available reports
  api_instance.report_list
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportApi->report_list: #{e}"
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


## report_permissionsbyuser

> report_permissionsbyuser(opts)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportApi.new
opts = {
  params: 'params_example' # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
}

begin
  #Permissions by user report
  api_instance.report_permissionsbyuser(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportApi->report_permissionsbyuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## report_prepare

> report_prepare(reportname, opts)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportApi.new
reportname = 'reportname_example' # String | The name of the report to execute
opts = {
  params: 'params_example', # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
  repformat: 'repformat_example', # String | The format of the resulting report. Json, pdf, csv, ...
  fillgroupid: 'fillgroupid_example', # String | If specified, the result is used to fill the group with the given ID
  groupby: 'groupby_example', # String | How to group the records. In the format 'col1+col2|col3+col4
  refreshgroup: 'refreshgroup_example', # String | The ID of the group to check (and refresh) before processing the report.
  filtertext: 'filtertext_example' # String | The user friendly text of the applied filters.
}

begin
  #Queries and loads the specified report, in background.
  api_instance.report_prepare(reportname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportApi->report_prepare: #{e}"
end
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

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## report_query

> report_query(reportname, opts)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ReportApi.new
reportname = 'reportname_example' # String | The name of the report to execute
opts = {
  params: 'params_example' # String | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
}

begin
  #Query and load a specified report
  api_instance.report_query(reportname, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ReportApi->report_query: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **String**| The name of the report to execute | 
 **params** | **String**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

