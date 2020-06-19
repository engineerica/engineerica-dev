# OpenapiClient::TermApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**term_delete**](TermApi.md#term_delete) | **DELETE** /term/{id} | Delete a term
[**term_get**](TermApi.md#term_get) | **GET** /term/{id} | Search and view details of a term
[**term_list**](TermApi.md#term_list) | **GET** /term/list | Search and view details of all terms
[**term_save**](TermApi.md#term_save) | **POST** /term/{id} | Create and edit terms



## term_delete

> term_delete(id, opts)

Delete a term

Allows the user to delete a term from the existing list.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TermApi.new
id = 'id_example' # String | The id of the term to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a term
  api_instance.term_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TermApi->term_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the term to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## term_get

> term_get(id)

Search and view details of a term

Allows the user to view a term and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TermApi.new
id = 'id_example' # String | The id of the term to get.

begin
  #Search and view details of a term
  api_instance.term_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TermApi->term_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the term to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## term_list

> term_list(opts)

Search and view details of all terms

Allows the user to view the full list of existing term.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TermApi.new
opts = {
  from: 56, # Integer | The first record to return.
  count: 56, # Integer | The max number of records to return.
  notpast: true # Boolean | Specifies whether the terms in the past should be returned or not.
}

begin
  #Search and view details of all terms
  api_instance.term_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TermApi->term_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 
 **notpast** | **Boolean**| Specifies whether the terms in the past should be returned or not. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## term_save

> term_save(id, opts)

Create and edit terms

Allows the user to create and edit terms.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TermApi.new
id = 'id_example' # String | The id of the term to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create and edit terms
  api_instance.term_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TermApi->term_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the term to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

