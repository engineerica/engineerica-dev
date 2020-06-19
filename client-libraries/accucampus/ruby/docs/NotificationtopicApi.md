# OpenapiClient::NotificationtopicApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notificationtopic_delete**](NotificationtopicApi.md#notificationtopic_delete) | **DELETE** /notificationtopic/{id} | Delete a notification topic
[**notificationtopic_get**](NotificationtopicApi.md#notificationtopic_get) | **GET** /notificationtopic/{id} | Search and view details of a notification topic
[**notificationtopic_list**](NotificationtopicApi.md#notificationtopic_list) | **GET** /notificationtopic/list | List all the notification topics
[**notificationtopic_listsubscribe**](NotificationtopicApi.md#notificationtopic_listsubscribe) | **GET** /notificationtopic/listsubscribe | List all the notification topics available to subscribe
[**notificationtopic_save**](NotificationtopicApi.md#notificationtopic_save) | **POST** /notificationtopic/{id} | Create or edit a notification topic



## notificationtopic_delete

> notificationtopic_delete(id, opts)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationtopicApi.new
id = 'id_example' # String | The id of the notification topic to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a notification topic
  api_instance.notificationtopic_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationtopicApi->notificationtopic_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification topic to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## notificationtopic_get

> notificationtopic_get(id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationtopicApi.new
id = 'id_example' # String | The id of the notification topic to get.

begin
  #Search and view details of a notification topic
  api_instance.notificationtopic_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationtopicApi->notificationtopic_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the notification topic to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## notificationtopic_list

> notificationtopic_list(from, count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationtopicApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #List all the notification topics
  api_instance.notificationtopic_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationtopicApi->notificationtopic_list: #{e}"
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


## notificationtopic_listsubscribe

> notificationtopic_listsubscribe

List all the notification topics available to subscribe

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationtopicApi.new

begin
  #List all the notification topics available to subscribe
  api_instance.notificationtopic_listsubscribe
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationtopicApi->notificationtopic_listsubscribe: #{e}"
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


## notificationtopic_save

> notificationtopic_save(id, opts)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::NotificationtopicApi.new
id = 'id_example' # String | The id of the topic to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a notification topic
  api_instance.notificationtopic_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling NotificationtopicApi->notificationtopic_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the topic to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

