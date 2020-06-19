# OpenapiClient::CreditApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**credit_delete**](CreditApi.md#credit_delete) | **DELETE** /credit/{id} | Delete a credit
[**credit_discountmethods**](CreditApi.md#credit_discountmethods) | **GET** /credit/discountmethods | Gets the valid discount methods.
[**credit_get**](CreditApi.md#credit_get) | **GET** /credit/{id} | View details of assigned credit
[**credit_getuserbalance**](CreditApi.md#credit_getuserbalance) | **GET** /credit/getuserbalance | Get the total amount of credits of the specified user
[**credit_list**](CreditApi.md#credit_list) | **GET** /credit/list | View a list of credits for a specific user
[**credit_listdetails**](CreditApi.md#credit_listdetails) | **GET** /credit/listdetails | Gets the credit usage details
[**credit_listmine**](CreditApi.md#credit_listmine) | **GET** /credit/listmine | View the list of credits of the current user
[**credit_save**](CreditApi.md#credit_save) | **POST** /credit/{id} | Create or edit credit for a user
[**credit_savedetails**](CreditApi.md#credit_savedetails) | **POST** /credit/savedetails | Create or edit credit details



## credit_delete

> credit_delete(id, opts)

Delete a credit

Allows the user to delete credits.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
id = 'id_example' # String | The id of the credit to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a credit
  api_instance.credit_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the credit to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## credit_discountmethods

> credit_discountmethods

Gets the valid discount methods.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::CreditApi.new

begin
  #Gets the valid discount methods.
  api_instance.credit_discountmethods
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_discountmethods: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## credit_get

> credit_get(id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
id = 'id_example' # String | The id of the credit to get.

begin
  #View details of assigned credit
  api_instance.credit_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the credit to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## credit_getuserbalance

> credit_getuserbalance(user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
user = 'user_example' # String | The id of the user whose balance has to be returned.

begin
  #Get the total amount of credits of the specified user
  api_instance.credit_getuserbalance(user)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_getuserbalance: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**String**](.md)| The id of the user whose balance has to be returned. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## credit_list

> credit_list(user, from, count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
user = 'user_example' # String | The id of the user.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of credits for a specific user
  api_instance.credit_list(user, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**String**](.md)| The id of the user. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## credit_listdetails

> credit_listdetails(credit, from, count)

Gets the credit usage details

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
credit = 'credit_example' # String | The id of the credit to look up for details.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #Gets the credit usage details
  api_instance.credit_listdetails(credit, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_listdetails: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credit** | [**String**](.md)| The id of the credit to look up for details. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## credit_listmine

> credit_listmine(from, count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View the list of credits of the current user
  api_instance.credit_listmine(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_listmine: #{e}"
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


## credit_save

> credit_save(id, opts)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
id = 'id_example' # String | The id of the credit save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit credit for a user
  api_instance.credit_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the credit save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## credit_savedetails

> credit_savedetails(opts)

Create or edit credit details

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CreditApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit credit details
  api_instance.credit_savedetails(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CreditApi->credit_savedetails: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

