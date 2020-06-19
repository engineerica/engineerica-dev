# OpenapiClient::SwipeApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**swipe_delete**](SwipeApi.md#swipe_delete) | **DELETE** /swipe/{id} | Delete a swipe
[**swipe_get**](SwipeApi.md#swipe_get) | **GET** /swipe/{id} | Search and view details of a swipe
[**swipe_list**](SwipeApi.md#swipe_list) | **GET** /swipe/list | View a list of swipes
[**swipe_save**](SwipeApi.md#swipe_save) | **POST** /swipe/save | Create or edit a swipe, and if possible, save the related attendance log
[**swipe_saveanonym**](SwipeApi.md#swipe_saveanonym) | **POST** /swipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log



## swipe_delete

> swipe_delete(id, opts)

Delete a swipe

Allows the user to delete an existing attendance swipe.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SwipeApi.new
id = 'id_example' # String | The id of the swipe to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a swipe
  api_instance.swipe_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SwipeApi->swipe_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the swipe to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## swipe_get

> swipe_get(id)

Search and view details of a swipe

Allows the user to view an individual attendance swipe.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SwipeApi.new
id = 'id_example' # String | The id of the swipe to get.

begin
  #Search and view details of a swipe
  api_instance.swipe_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SwipeApi->swipe_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the swipe to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## swipe_list

> swipe_list(from, count)

View a list of swipes

Allows the user to view a list of all swipes for the location or locations in which the user is scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SwipeApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of swipes
  api_instance.swipe_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SwipeApi->swipe_list: #{e}"
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


## swipe_save

> swipe_save(opts)

Create or edit a swipe, and if possible, save the related attendance log

Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SwipeApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a swipe, and if possible, save the related attendance log
  api_instance.swipe_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SwipeApi->swipe_save: #{e}"
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


## swipe_saveanonym

> swipe_saveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::SwipeApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Creates a new swipe from a sign-in station, and if possible, creates the attendance log
  api_instance.swipe_saveanonym(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SwipeApi->swipe_saveanonym: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

