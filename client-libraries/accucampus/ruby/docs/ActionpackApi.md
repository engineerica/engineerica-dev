# OpenapiClient::ActionpackApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionpack_assign**](ActionpackApi.md#actionpack_assign) | **GET** /actionpack/assign | Assign an action item pack to a user
[**actionpack_delete**](ActionpackApi.md#actionpack_delete) | **DELETE** /actionpack/{id} | Delete an action item pack
[**actionpack_get**](ActionpackApi.md#actionpack_get) | **GET** /actionpack/{id} | View details of an action item pack
[**actionpack_list**](ActionpackApi.md#actionpack_list) | **GET** /actionpack/list | View a list of action item packs
[**actionpack_save**](ActionpackApi.md#actionpack_save) | **POST** /actionpack/{id} | Create or edit an action item pack



## actionpack_assign

> actionpack_assign(pack, itemsdata, opts)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionpackApi.new
pack = 'pack_example' # String | The id of the action pack to assign.
itemsdata = true # Boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
opts = {
  assignee: 'assignee_example', # String | The assignee of the pack.
  group: 'group_example', # String | The group to assign the pack.
  notes: 'notes_example' # String | The assignment's notes.
}

begin
  #Assign an action item pack to a user
  api_instance.actionpack_assign(pack, itemsdata, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionpackApi->actionpack_assign: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pack** | [**String**](.md)| The id of the action pack to assign. | 
 **itemsdata** | **Boolean**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **assignee** | [**String**](.md)| The assignee of the pack. | [optional] 
 **group** | [**String**](.md)| The group to assign the pack. | [optional] 
 **notes** | **String**| The assignment&#39;s notes. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionpack_delete

> actionpack_delete(id, opts)

Delete an action item pack

Allows the user to delete an action item pack.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionpackApi.new
id = 'id_example' # String | The id of the action pack to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an action item pack
  api_instance.actionpack_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionpackApi->actionpack_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action pack to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actionpack_get

> actionpack_get(id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionpackApi.new
id = 'id_example' # String | The id of the action pack to get.

begin
  #View details of an action item pack
  api_instance.actionpack_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionpackApi->actionpack_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action pack to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionpack_list

> actionpack_list(from, count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionpackApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of action item packs
  api_instance.actionpack_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionpackApi->actionpack_list: #{e}"
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


## actionpack_save

> actionpack_save(id, opts)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionpackApi.new
id = 'id_example' # String | The id of the action pack to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit an action item pack
  api_instance.actionpack_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionpackApi->actionpack_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action pack to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

