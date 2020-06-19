# OpenapiClient::SessionswipeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionswipe_delete**](SessionswipeApi.md#sessionswipe_delete) | **DELETE** /sessionswipe/{id} | Delete a session swipe
[**sessionswipe_get**](SessionswipeApi.md#sessionswipe_get) | **GET** /sessionswipe/{id} | View details of a class attendance swipe
[**sessionswipe_listunresolved**](SessionswipeApi.md#sessionswipe_listunresolved) | **GET** /sessionswipe/listunresolved | View a list of unresolved swipes
[**sessionswipe_resolve**](SessionswipeApi.md#sessionswipe_resolve) | **GET** /sessionswipe/resolve | Resolve a swipe and create the corresponding attendance log
[**sessionswipe_save**](SessionswipeApi.md#sessionswipe_save) | **POST** /sessionswipe/save | Creates a new swipe, and if possible, creates the attendance log
[**sessionswipe_saveanonym**](SessionswipeApi.md#sessionswipe_saveanonym) | **POST** /sessionswipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log



## sessionswipe_delete

> sessionswipe_delete(id, opts)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionswipeApi.new
id = 'id_example' # String | The id of the session swipe to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a session swipe
  api_instance.sessionswipe_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionswipeApi->sessionswipe_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the session swipe to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## sessionswipe_get

> sessionswipe_get(id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionswipeApi.new
id = 'id_example' # String | The id of the swipe to get.

begin
  #View details of a class attendance swipe
  api_instance.sessionswipe_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionswipeApi->sessionswipe_get: #{e}"
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


## sessionswipe_listunresolved

> sessionswipe_listunresolved(from, count)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionswipeApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of unresolved swipes
  api_instance.sessionswipe_listunresolved(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionswipeApi->sessionswipe_listunresolved: #{e}"
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


## sessionswipe_resolve

> sessionswipe_resolve(id, opts)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionswipeApi.new
id = 'id_example' # String | The id of the swipe to resolve.
opts = {
  session: 'session_example', # String | The id of the session whose swipe has to be saved.
  user: 'user_example' # String | The id of the user who signed-in.
}

begin
  #Resolve a swipe and create the corresponding attendance log
  api_instance.sessionswipe_resolve(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionswipeApi->sessionswipe_resolve: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the swipe to resolve. | 
 **session** | [**String**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**String**](.md)| The id of the user who signed-in. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## sessionswipe_save

> sessionswipe_save(opts)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SessionswipeApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Creates a new swipe, and if possible, creates the attendance log
  api_instance.sessionswipe_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionswipeApi->sessionswipe_save: #{e}"
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


## sessionswipe_saveanonym

> sessionswipe_saveanonym(opts)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::SessionswipeApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Creates a new swipe from a sign-in station, and if possible, creates the attendance log
  api_instance.sessionswipe_saveanonym(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SessionswipeApi->sessionswipe_saveanonym: #{e}"
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

