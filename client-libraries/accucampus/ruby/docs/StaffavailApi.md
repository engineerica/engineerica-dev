# OpenapiClient::StaffavailApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**staffavail_addmetoallservices**](StaffavailApi.md#staffavail_addmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
[**staffavail_addmetoservice**](StaffavailApi.md#staffavail_addmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
[**staffavail_addusertoallservices**](StaffavailApi.md#staffavail_addusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
[**staffavail_addusertoservice**](StaffavailApi.md#staffavail_addusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
[**staffavail_getmyservices**](StaffavailApi.md#staffavail_getmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
[**staffavail_getservices**](StaffavailApi.md#staffavail_getservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
[**staffavail_getusersforservice**](StaffavailApi.md#staffavail_getusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**staffavail_listtypes**](StaffavailApi.md#staffavail_listtypes) | **GET** /staffavail/listtypes | View all the availability types
[**staffavail_removemefromallservices**](StaffavailApi.md#staffavail_removemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
[**staffavail_removemefromservice**](StaffavailApi.md#staffavail_removemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
[**staffavail_removeuserfromallservices**](StaffavailApi.md#staffavail_removeuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**staffavail_removeuserfromservice**](StaffavailApi.md#staffavail_removeuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
[**staffavail_setavailability**](StaffavailApi.md#staffavail_setavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
[**staffavail_setmyavailability**](StaffavailApi.md#staffavail_setmyavailability) | **GET** /staffavail/setmyavailability | Change current user&#39;s availability type



## staffavail_addmetoallservices

> staffavail_addmetoallservices

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new

begin
  #Associate current user to all services
  api_instance.staffavail_addmetoallservices
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_addmetoallservices: #{e}"
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


## staffavail_addmetoservice

> staffavail_addmetoservice(serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Associate current user to a service
  api_instance.staffavail_addmetoservice(serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_addmetoservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_addusertoallservices

> staffavail_addusertoallservices(userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
userid = 'userid_example' # String | The id of the user to add.

begin
  #Associate a staff member to all services
  api_instance.staffavail_addusertoallservices(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_addusertoallservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to add. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_addusertoservice

> staffavail_addusertoservice(userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
userid = 'userid_example' # String | The id of the user to add.
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Associate a staff member to a service
  api_instance.staffavail_addusertoservice(userid, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_addusertoservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to add. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_getmyservices

> staffavail_getmyservices

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new

begin
  #View the services the current user is available for
  api_instance.staffavail_getmyservices
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_getmyservices: #{e}"
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


## staffavail_getservices

> staffavail_getservices(userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
userid = 'userid_example' # String | The user id to list services.

begin
  #View a list of services that a staff member is available for
  api_instance.staffavail_getservices(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_getservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The user id to list services. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_getusersforservice

> staffavail_getusersforservice(serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
serviceid = 'serviceid_example' # String | The service id to list users.

begin
  #View a list of staff members that are available for a specific service
  api_instance.staffavail_getusersforservice(serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_getusersforservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**String**](.md)| The service id to list users. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_listtypes

> staffavail_listtypes

View all the availability types

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new

begin
  #View all the availability types
  api_instance.staffavail_listtypes
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_listtypes: #{e}"
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


## staffavail_removemefromallservices

> staffavail_removemefromallservices

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new

begin
  #Remove current user from all services
  api_instance.staffavail_removemefromallservices
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_removemefromallservices: #{e}"
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


## staffavail_removemefromservice

> staffavail_removemefromservice(serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Remove current user from a service
  api_instance.staffavail_removemefromservice(serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_removemefromservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_removeuserfromallservices

> staffavail_removeuserfromallservices(userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
userid = 'userid_example' # String | The id of the user to remove.

begin
  #Removes a staff member from the registration to all services
  api_instance.staffavail_removeuserfromallservices(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_removeuserfromallservices: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to remove. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_removeuserfromservice

> staffavail_removeuserfromservice(userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
userid = 'userid_example' # String | The id of the user to remove.
serviceid = 'serviceid_example' # String | The id of the service.

begin
  #Remove a staff member from a service
  api_instance.staffavail_removeuserfromservice(userid, serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_removeuserfromservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to remove. | 
 **serviceid** | [**String**](.md)| The id of the service. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_setavailability

> staffavail_setavailability(userid, opts)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
userid = 'userid_example' # String | The id of the user whose specific availability has to be set.
opts = {
  availablefor: 'availablefor_example' # String | Specific availability to set.
}

begin
  #Make a staff member available for a specific availability type
  api_instance.staffavail_setavailability(userid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_setavailability: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user whose specific availability has to be set. | 
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## staffavail_setmyavailability

> staffavail_setmyavailability(opts)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StaffavailApi.new
opts = {
  availablefor: 'availablefor_example' # String | Specific availability to set.
}

begin
  #Change current user's availability type
  api_instance.staffavail_setmyavailability(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StaffavailApi->staffavail_setmyavailability: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **availablefor** | **String**| Specific availability to set. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

