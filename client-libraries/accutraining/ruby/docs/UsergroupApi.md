# OpenapiClient::UsergroupApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usergroup_addmember**](UsergroupApi.md#usergroup_addmember) | **GET** /usergroup/addmember | Add a user to a group
[**usergroup_delete**](UsergroupApi.md#usergroup_delete) | **DELETE** /usergroup/{id} | Delete a group
[**usergroup_get**](UsergroupApi.md#usergroup_get) | **GET** /usergroup/{id} | Search and view details of a user group
[**usergroup_getmembers**](UsergroupApi.md#usergroup_getmembers) | **GET** /usergroup/getmembers | View the members of a user group
[**usergroup_getuser**](UsergroupApi.md#usergroup_getuser) | **GET** /usergroup/getuser | View the groups which a user is registered to
[**usergroup_list**](UsergroupApi.md#usergroup_list) | **GET** /usergroup/list | View a list of user groups
[**usergroup_refresh**](UsergroupApi.md#usergroup_refresh) | **GET** /usergroup/refresh | Refresh the dynamic group
[**usergroup_removemember**](UsergroupApi.md#usergroup_removemember) | **GET** /usergroup/removemember | Remove a user from a group
[**usergroup_save**](UsergroupApi.md#usergroup_save) | **POST** /usergroup/{id} | Create or edit a group



## usergroup_addmember

> usergroup_addmember(userid, groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
userid = 'userid_example' # String | The id of the user to add.
groupid = 'groupid_example' # String | The id of the group.

begin
  #Add a user to a group
  api_instance.usergroup_addmember(userid, groupid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_addmember: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to add. | 
 **groupid** | [**String**](.md)| The id of the group. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroup_delete

> usergroup_delete(id, opts)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
id = 'id_example' # String | The id of the group to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a group
  api_instance.usergroup_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the group to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## usergroup_get

> usergroup_get(id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
id = 'id_example' # String | The id of the user group to get.

begin
  #Search and view details of a user group
  api_instance.usergroup_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the user group to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroup_getmembers

> usergroup_getmembers(groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
groupid = 'groupid_example' # String | The id of the user group to get.

begin
  #View the members of a user group
  api_instance.usergroup_getmembers(groupid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_getmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | [**String**](.md)| The id of the user group to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroup_getuser

> usergroup_getuser(userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
userid = 'userid_example' # String | The id of the user to get his groups.

begin
  #View the groups which a user is registered to
  api_instance.usergroup_getuser(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_getuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to get his groups. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroup_list

> usergroup_list(opts)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
opts = {
  from: 56, # Integer | The first record to return.
  count: 56, # Integer | The max number of records to return.
  type: 'type_example' # String | The type of the groups to return. Either 'user', 'dynamic' or any other type of group.
}

begin
  #View a list of user groups
  api_instance.usergroup_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 
 **type** | **String**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroup_refresh

> usergroup_refresh(group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
group = 'group_example' # String | The ID of the group to refresh.

begin
  #Refresh the dynamic group
  api_instance.usergroup_refresh(group)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_refresh: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**String**](.md)| The ID of the group to refresh. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroup_removemember

> usergroup_removemember(userid, groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
userid = 'userid_example' # String | The id of the user to remove.
groupid = 'groupid_example' # String | The id of the group.

begin
  #Remove a user from a group
  api_instance.usergroup_removemember(userid, groupid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_removemember: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **groupid** | [**String**](.md)| The id of the group. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## usergroup_save

> usergroup_save(id, opts)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UsergroupApi.new
id = 'id_example' # String | The id of the group to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a group
  api_instance.usergroup_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UsergroupApi->usergroup_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the group to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

