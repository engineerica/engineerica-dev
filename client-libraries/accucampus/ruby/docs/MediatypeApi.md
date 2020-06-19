# OpenapiClient::MediatypeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mediatype_delete**](MediatypeApi.md#mediatype_delete) | **DELETE** /mediatype/{id} | Delete a media type
[**mediatype_get**](MediatypeApi.md#mediatype_get) | **GET** /mediatype/{id} | Search and view details of a media type
[**mediatype_list**](MediatypeApi.md#mediatype_list) | **GET** /mediatype/list | View a list of media types
[**mediatype_save**](MediatypeApi.md#mediatype_save) | **POST** /mediatype/{id} | Create or edit a media type



## mediatype_delete

> mediatype_delete(id, opts)

Delete a media type

Allows the user to delete an existing media type.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediatypeApi.new
id = 'id_example' # String | The id of the media type to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a media type
  api_instance.mediatype_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediatypeApi->mediatype_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media type to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## mediatype_get

> mediatype_get(id)

Search and view details of a media type

Allows the user to view a media type and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediatypeApi.new
id = 'id_example' # String | The id of the media type to get.

begin
  #Search and view details of a media type
  api_instance.mediatype_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediatypeApi->mediatype_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media type to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## mediatype_list

> mediatype_list(from, count)

View a list of media types

Allows the user to view the list of all media types.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediatypeApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of media types
  api_instance.mediatype_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediatypeApi->mediatype_list: #{e}"
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


## mediatype_save

> mediatype_save(id, opts)

Create or edit a media type

Allows the user to create or edit a media type.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediatypeApi.new
id = 'id_example' # String | The id of the mediaType save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a media type
  api_instance.mediatype_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediatypeApi->mediatype_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the mediaType save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

