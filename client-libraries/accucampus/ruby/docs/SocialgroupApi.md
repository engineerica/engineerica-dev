# OpenapiClient::SocialgroupApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**socialgroup_addmembers**](SocialgroupApi.md#socialgroup_addmembers) | **GET** /socialgroup/addmembers | Adds new members to a group (which the user must own already)
[**socialgroup_delete**](SocialgroupApi.md#socialgroup_delete) | **DELETE** /socialgroup/{id} | Deletes a group
[**socialgroup_list**](SocialgroupApi.md#socialgroup_list) | **GET** /socialgroup/list | View all the groups the current user is in
[**socialgroup_listmembers**](SocialgroupApi.md#socialgroup_listmembers) | **GET** /socialgroup/listmembers | Lists the members of a group
[**socialgroup_removemembers**](SocialgroupApi.md#socialgroup_removemembers) | **GET** /socialgroup/removemembers | Removes members from a group (which the user must own already)
[**socialgroup_removemyself**](SocialgroupApi.md#socialgroup_removemyself) | **GET** /socialgroup/removemyself | Removes myself from an existent group
[**socialgroup_save**](SocialgroupApi.md#socialgroup_save) | **POST** /socialgroup/{id} | Saves a new group



## socialgroup_addmembers

> socialgroup_addmembers(id, userids)

Adds new members to a group (which the user must own already)

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialgroupApi.new
id = 'id_example' # String | ID of the group to add members to.
userids = 'userids_example' # String | Csv list of user Ids to add.

begin
  #Adds new members to a group (which the user must own already)
  api_instance.socialgroup_addmembers(id, userids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialgroupApi->socialgroup_addmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| ID of the group to add members to. | 
 **userids** | **String**| Csv list of user Ids to add. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroup_delete

> socialgroup_delete(id, opts)

Deletes a group

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialgroupApi.new
id = 'id_example' # String | ID of the group to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Deletes a group
  api_instance.socialgroup_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialgroupApi->socialgroup_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| ID of the group to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## socialgroup_list

> socialgroup_list

View all the groups the current user is in

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialgroupApi.new

begin
  #View all the groups the current user is in
  api_instance.socialgroup_list
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialgroupApi->socialgroup_list: #{e}"
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


## socialgroup_listmembers

> socialgroup_listmembers(id)

Lists the members of a group

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialgroupApi.new
id = 'id_example' # String | ID of the group to list members.

begin
  #Lists the members of a group
  api_instance.socialgroup_listmembers(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialgroupApi->socialgroup_listmembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| ID of the group to list members. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroup_removemembers

> socialgroup_removemembers(id, userids)

Removes members from a group (which the user must own already)

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialgroupApi.new
id = 'id_example' # String | ID of the group to remove members from.
userids = 'userids_example' # String | Csv list of user Ids to remove.

begin
  #Removes members from a group (which the user must own already)
  api_instance.socialgroup_removemembers(id, userids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialgroupApi->socialgroup_removemembers: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| ID of the group to remove members from. | 
 **userids** | **String**| Csv list of user Ids to remove. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroup_removemyself

> socialgroup_removemyself(id)

Removes myself from an existent group

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialgroupApi.new
id = 'id_example' # String | ID of the group to remove me from.

begin
  #Removes myself from an existent group
  api_instance.socialgroup_removemyself(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialgroupApi->socialgroup_removemyself: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| ID of the group to remove me from. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## socialgroup_save

> socialgroup_save(id, opts)

Saves a new group

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SocialgroupApi.new
id = 'id_example' # String | ID of the group to update. Leave blank to create new.
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a new group
  api_instance.socialgroup_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SocialgroupApi->socialgroup_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| ID of the group to update. Leave blank to create new. | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

