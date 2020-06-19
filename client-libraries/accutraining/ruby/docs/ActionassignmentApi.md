# OpenapiClient::ActionassignmentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionassignment_delete**](ActionassignmentApi.md#actionassignment_delete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
[**actionassignment_get**](ActionassignmentApi.md#actionassignment_get) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**actionassignment_list**](ActionassignmentApi.md#actionassignment_list) | **GET** /actionassignment/list | View a list of action items in a user&#39;s plan
[**actionassignment_listhistory**](ActionassignmentApi.md#actionassignment_listhistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
[**actionassignment_listmine**](ActionassignmentApi.md#actionassignment_listmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
[**actionassignment_listpublichistory**](ActionassignmentApi.md#actionassignment_listpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
[**actionassignment_markcomplete**](ActionassignmentApi.md#actionassignment_markcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
[**actionassignment_save**](ActionassignmentApi.md#actionassignment_save) | **POST** /actionassignment/save | Add an action item to a user&#39;s action plan
[**actionassignment_savehistory**](ActionassignmentApi.md#actionassignment_savehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user



## actionassignment_delete

> actionassignment_delete(id, opts)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
id = 'id_example' # String | The id of the action assignment to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Remove an action item from an action plan
  api_instance.actionassignment_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action assignment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## actionassignment_get

> actionassignment_get(id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
id = 'id_example' # String | The id of the action assignment to get.

begin
  #Search and view details of an action item assigned to a user
  api_instance.actionassignment_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the action assignment to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignment_list

> actionassignment_list(from, count, opts)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  assignee: 56, # Integer | The assignee's id to filter the assignments.
  status: 56 # Integer | The status to filter the assignments.
}

begin
  #View a list of action items in a user's plan
  api_instance.actionassignment_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **assignee** | **Integer**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **Integer**| The status to filter the assignments. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignment_listhistory

> actionassignment_listhistory(actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
actionassignment = 'actionassignment_example' # String | The action assignment's id whose history the user wants to get.

begin
  #View the history of an action item assigned to a user
  api_instance.actionassignment_listhistory(actionassignment)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_listhistory: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignment_listmine

> actionassignment_listmine(from, count, opts)

List public action assignments assigned to the logged user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  status: 56 # Integer | The status to filter the assignments.
}

begin
  #List public action assignments assigned to the logged user
  api_instance.actionassignment_listmine(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_listmine: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **status** | **Integer**| The status to filter the assignments. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignment_listpublichistory

> actionassignment_listpublichistory(actionassignment)

List public action assignment history

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
actionassignment = 'actionassignment_example' # String | The action assignment's id whose history the user wants to get.

begin
  #List public action assignment history
  api_instance.actionassignment_listpublichistory(actionassignment)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_listpublichistory: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**String**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignment_markcomplete

> actionassignment_markcomplete(item, opts)

Bulk complete action items

Allows the user to bulk complete action items.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
item = 'item_example' # String | The action item to assign.
opts = {
  assignee: 'assignee_example', # String | The assignee of the item.
  group: 'group_example', # String | The group to assing the item.
  notes: 'notes_example' # String | The assignment's notes.
}

begin
  #Bulk complete action items
  api_instance.actionassignment_markcomplete(item, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_markcomplete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | **String**| The action item to assign. | 
 **assignee** | [**String**](.md)| The assignee of the item. | [optional] 
 **group** | [**String**](.md)| The group to assing the item. | [optional] 
 **notes** | **String**| The assignment&#39;s notes. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## actionassignment_save

> actionassignment_save(opts)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Add an action item to a user's action plan
  api_instance.actionassignment_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_save: #{e}"
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


## actionassignment_savehistory

> actionassignment_savehistory(opts)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionassignmentApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Update an action item assigned to a user
  api_instance.actionassignment_savehistory(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionassignmentApi->actionassignment_savehistory: #{e}"
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

