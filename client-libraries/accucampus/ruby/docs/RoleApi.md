# OpenapiClient::RoleApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**role_list**](RoleApi.md#role_list) | **GET** /role/list | Show a list of roles



## role_list

> role_list(opts)

Show a list of roles

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RoleApi.new
opts = {
  name: 'name_example' # String | Filter by name of the role.
}

begin
  #Show a list of roles
  api_instance.role_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RoleApi->role_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **String**| Filter by name of the role. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

