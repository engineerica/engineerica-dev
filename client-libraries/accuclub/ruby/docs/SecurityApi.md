# OpenapiClient::SecurityApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**security_assesspermission**](SecurityApi.md#security_assesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
[**security_assessrole**](SecurityApi.md#security_assessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
[**security_assessscope**](SecurityApi.md#security_assessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
[**security_assessuser**](SecurityApi.md#security_assessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user



## security_assesspermission

> security_assesspermission(commandname)

Returns the list of users for a specific permission

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SecurityApi.new
commandname = 'commandname_example' # String | Name of the action or command to get the roles.

begin
  #Returns the list of users for a specific permission
  api_instance.security_assesspermission(commandname)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SecurityApi->security_assesspermission: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commandname** | **String**| Name of the action or command to get the roles. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## security_assessrole

> security_assessrole(roleid)

Returns the list of permissions for a specific role

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SecurityApi.new
roleid = 'roleid_example' # String | Role ID to list the effective permissions.

begin
  #Returns the list of permissions for a specific role
  api_instance.security_assessrole(roleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SecurityApi->security_assessrole: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**String**](.md)| Role ID to list the effective permissions. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## security_assessscope

> security_assessscope(opts)

Returns the list of users for a specific user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SecurityApi.new
opts = {
  locationid: 'locationid_example' # String | Location ID to list the users with that scope.
}

begin
  #Returns the list of users for a specific user
  api_instance.security_assessscope(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SecurityApi->security_assessscope: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**String**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## security_assessuser

> security_assessuser(userid)

Returns the list of permissions for a specific user

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::SecurityApi.new
userid = 'userid_example' # String | User ID to list the effective permissions.

begin
  #Returns the list of permissions for a specific user
  api_instance.security_assessuser(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling SecurityApi->security_assessuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| User ID to list the effective permissions. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

