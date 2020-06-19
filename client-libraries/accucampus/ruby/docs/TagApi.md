# OpenapiClient::TagApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tag_delete**](TagApi.md#tag_delete) | **DELETE** /tag/{id} | Delete a tag
[**tag_get**](TagApi.md#tag_get) | **GET** /tag/{id} | View details of a specified tag
[**tag_list**](TagApi.md#tag_list) | **GET** /tag/list | View a list of tags
[**tag_listgroups**](TagApi.md#tag_listgroups) | **GET** /tag/listgroups | View a list of entities that can be tagged
[**tag_save**](TagApi.md#tag_save) | **POST** /tag/{id} | Create or edit a tag
[**tag_search**](TagApi.md#tag_search) | **GET** /tag/search | Search for tags in the account



## tag_delete

> tag_delete(id, opts)

Delete a tag

Allows the user to delete an existing tag.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TagApi.new
id = 'id_example' # String | The id of the tag to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a tag
  api_instance.tag_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TagApi->tag_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the tag to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## tag_get

> tag_get(id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TagApi.new
id = 'id_example' # String | The id of the tag to get.

begin
  #View details of a specified tag
  api_instance.tag_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TagApi->tag_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the tag to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## tag_list

> tag_list(group, from, count)

View a list of tags

Allows the user to view the list of tags.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TagApi.new
group = 'group_example' # String | The group of the tags to return.
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of tags
  api_instance.tag_list(group, from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TagApi->tag_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **String**| The group of the tags to return. | 
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## tag_listgroups

> tag_listgroups

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag's settings.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TagApi.new

begin
  #View a list of entities that can be tagged
  api_instance.tag_listgroups
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TagApi->tag_listgroups: #{e}"
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


## tag_save

> tag_save(id, opts)

Create or edit a tag

Allows the user to create or edit a tag.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TagApi.new
id = 'id_example' # String | The id of the tag save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a tag
  api_instance.tag_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TagApi->tag_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the tag save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## tag_search

> tag_search(query, opts)

Search for tags in the account

Allows the user to search for tags.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TagApi.new
query = 'query_example' # String | The query to search tags. Use group:<group> to search in a specific group (mandatory).
opts = {
  allowcreatingnew: true # Boolean | Specifies whether an option to create a new tag should be retrieved.
}

begin
  #Search for tags in the account
  api_instance.tag_search(query, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TagApi->tag_search: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **String**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). | 
 **allowcreatingnew** | **Boolean**| Specifies whether an option to create a new tag should be retrieved. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

