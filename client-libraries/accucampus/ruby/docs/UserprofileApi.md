# OpenapiClient::UserprofileApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userprofile_delete**](UserprofileApi.md#userprofile_delete) | **DELETE** /userprofile/{id} | Delete a user profile
[**userprofile_get**](UserprofileApi.md#userprofile_get) | **GET** /userprofile/{id} | View a specific user profile
[**userprofile_getallview**](UserprofileApi.md#userprofile_getallview) | **GET** /userprofile/getallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**userprofile_list**](UserprofileApi.md#userprofile_list) | **GET** /userprofile/list | View the list of user profiles
[**userprofile_listquestions**](UserprofileApi.md#userprofile_listquestions) | **GET** /userprofile/listquestions | Gets the list of all the available user questions
[**userprofile_preparestats**](UserprofileApi.md#userprofile_preparestats) | **GET** /userprofile/preparestats | Gets the statistics of a user group
[**userprofile_save**](UserprofileApi.md#userprofile_save) | **POST** /userprofile/{id} | Create or edit user profile questions
[**userprofile_saveanswers**](UserprofileApi.md#userprofile_saveanswers) | **POST** /userprofile/saveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.



## userprofile_delete

> userprofile_delete(id, opts)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new
id = 'id_example' # String | The id of the user profile to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a user profile
  api_instance.userprofile_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the user profile to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userprofile_get

> userprofile_get(id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new
id = 'id_example' # String | The id of the profile question set.

begin
  #View a specific user profile
  api_instance.userprofile_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the profile question set. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofile_getallview

> userprofile_getallview(opts)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new
opts = {
  id: 'id_example' # String | The id of the user to view, or empty for current user.
}

begin
  #Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
  api_instance.userprofile_getallview(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_getallview: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofile_list

> userprofile_list(opts)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new
opts = {
  from: 56, # Integer | The first record to return.
  count: 56 # Integer | The max number of records to return.
}

begin
  #View the list of user profiles
  api_instance.userprofile_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | [optional] 
 **count** | **Integer**| The max number of records to return. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofile_listquestions

> userprofile_listquestions

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new

begin
  #Gets the list of all the available user questions
  api_instance.userprofile_listquestions
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_listquestions: #{e}"
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


## userprofile_preparestats

> userprofile_preparestats(opts)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new
opts = {
  params: 'params_example' # String | The ID of the group, specified as 'group=...'
}

begin
  #Gets the statistics of a user group
  api_instance.userprofile_preparestats(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_preparestats: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **String**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## userprofile_save

> userprofile_save(id, opts)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new
id = 'id_example' # String | The id of the profile question set.
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit user profile questions
  api_instance.userprofile_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the profile question set. | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## userprofile_saveanswers

> userprofile_saveanswers(opts)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserprofileApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
  api_instance.userprofile_saveanswers(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserprofileApi->userprofile_saveanswers: #{e}"
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

