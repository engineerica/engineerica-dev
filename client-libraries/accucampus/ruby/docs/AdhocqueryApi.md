# OpenapiClient::AdhocqueryApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocquery_checkexecution**](AdhocqueryApi.md#adhocquery_checkexecution) | **GET** /adhocquery/checkexecution | Check the status of an ad hoc query execution
[**adhocquery_delete**](AdhocqueryApi.md#adhocquery_delete) | **DELETE** /adhocquery/{id} | Delete an ad hoc query
[**adhocquery_execute**](AdhocqueryApi.md#adhocquery_execute) | **GET** /adhocquery/execute | Execute an ad hoc query
[**adhocquery_get**](AdhocqueryApi.md#adhocquery_get) | **GET** /adhocquery/{id} | View details of an ad hoc query
[**adhocquery_getschema**](AdhocqueryApi.md#adhocquery_getschema) | **GET** /adhocquery/getschema | View the database schema for making ad hoc queries
[**adhocquery_list**](AdhocqueryApi.md#adhocquery_list) | **GET** /adhocquery/list | View a list of saved ad hoc queries
[**adhocquery_listexecutions**](AdhocqueryApi.md#adhocquery_listexecutions) | **GET** /adhocquery/listexecutions | View a list of ad hoc queries executions
[**adhocquery_save**](AdhocqueryApi.md#adhocquery_save) | **POST** /adhocquery/{id} | Create or edit an ad hoc query
[**adhocquery_stopexecution**](AdhocqueryApi.md#adhocquery_stopexecution) | **GET** /adhocquery/stopexecution | Stops the execution of an ad hoc query



## adhocquery_checkexecution

> adhocquery_checkexecution(id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
id = 'id_example' # String | The id of the ad hoc query execution to be checked.

begin
  #Check the status of an ad hoc query execution
  api_instance.adhocquery_checkexecution(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_checkexecution: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the ad hoc query execution to be checked. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquery_delete

> adhocquery_delete(id, opts)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
id = 'id_example' # String | The id of the ad hoc query to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an ad hoc query
  api_instance.adhocquery_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the ad hoc query to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## adhocquery_execute

> adhocquery_execute(opts)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
opts = {
  id: 'id_example', # String | The id of the query to execute.
  query: 'query_example' # String | The query to execute.
}

begin
  #Execute an ad hoc query
  api_instance.adhocquery_execute(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_execute: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the query to execute. | [optional] 
 **query** | **String**| The query to execute. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquery_get

> adhocquery_get(id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
id = 'id_example' # String | The id of the query to get.

begin
  #View details of an ad hoc query
  api_instance.adhocquery_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the query to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquery_getschema

> adhocquery_getschema

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new

begin
  #View the database schema for making ad hoc queries
  api_instance.adhocquery_getschema
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_getschema: #{e}"
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


## adhocquery_list

> adhocquery_list(from, count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of saved ad hoc queries
  api_instance.adhocquery_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquery_listexecutions

> adhocquery_listexecutions(from, count, opts)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  query: 'query_example' # String | The first record to return.
}

begin
  #View a list of ad hoc queries executions
  api_instance.adhocquery_listexecutions(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_listexecutions: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **query** | [**String**](.md)| The first record to return. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## adhocquery_save

> adhocquery_save(id, opts)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
id = 'id_example' # String | The id of the query to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an ad hoc query
  api_instance.adhocquery_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the query to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## adhocquery_stopexecution

> adhocquery_stopexecution(id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdhocqueryApi.new
id = 'id_example' # String | The id of the ad hoc query execution to be stopped.

begin
  #Stops the execution of an ad hoc query
  api_instance.adhocquery_stopexecution(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdhocqueryApi->adhocquery_stopexecution: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the ad hoc query execution to be stopped. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

