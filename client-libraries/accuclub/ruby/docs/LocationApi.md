# OpenapiClient::LocationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**location_delete**](LocationApi.md#location_delete) | **DELETE** /location/{id} | Delete a location
[**location_get**](LocationApi.md#location_get) | **GET** /location/{id} | Search and view details of a location
[**location_list**](LocationApi.md#location_list) | **GET** /location/list | View a list of locations
[**location_save**](LocationApi.md#location_save) | **POST** /location/{id} | Create or edit a location



## location_delete

> location_delete(id, opts)

Delete a location

Allows the user to delete an existing location.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LocationApi.new
id = 'id_example' # String | The id of the location to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a location
  api_instance.location_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LocationApi->location_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the location to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## location_get

> location_get(id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LocationApi.new
id = 'id_example' # String | The id of the location to get.

begin
  #Search and view details of a location
  api_instance.location_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LocationApi->location_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the location to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## location_list

> location_list(from, count, opts)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LocationApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  locations: 'locations_example', # String | The comma-separated list containing the ids of the locations to list.
  sortbygroup: true # Boolean | True to list locations sorted by the 'Located In' property. Defaults to false.
}

begin
  #View a list of locations
  api_instance.location_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LocationApi->location_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **locations** | **String**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **Boolean**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## location_save

> location_save(id, opts)

Create or edit a location

Allows the user to create or edit a location.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LocationApi.new
id = 'id_example' # String | The id of the location save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a location
  api_instance.location_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LocationApi->location_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the location save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

