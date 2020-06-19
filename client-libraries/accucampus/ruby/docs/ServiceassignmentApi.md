# OpenapiClient::ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**serviceassignment_addservice**](ServiceassignmentApi.md#serviceassignment_addservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**serviceassignment_getlocation**](ServiceassignmentApi.md#serviceassignment_getlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**serviceassignment_getservice**](ServiceassignmentApi.md#serviceassignment_getservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**serviceassignment_removeservice**](ServiceassignmentApi.md#serviceassignment_removeservice) | **GET** /serviceassignment/removeservice | Remove a service from a location



## serviceassignment_addservice

> serviceassignment_addservice(serviceid, locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceassignmentApi.new
serviceid = 'serviceid_example' # String | The id of the service to add.
locationid = 'locationid_example' # String | The id of the location.

begin
  #Enable a service in a specific location
  api_instance.serviceassignment_addservice(serviceid, locationid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceassignmentApi->serviceassignment_addservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**String**](.md)| The id of the service to add. | 
 **locationid** | [**String**](.md)| The id of the location. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignment_getlocation

> serviceassignment_getlocation(locationid, opts)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceassignmentApi.new
locationid = 'locationid_example' # String | The id of the location to get.
opts = {
  includegloballyavailable: true, # Boolean | Specifies whether the services available globally must be returned or not.
  namefilter: true, # Boolean | Filters the name of the services to return.
  count: 56 # Integer | The max number of services to return.
}

begin
  #View a list of services enabled for a specific location
  api_instance.serviceassignment_getlocation(locationid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceassignmentApi->serviceassignment_getlocation: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**String**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **Boolean**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **Boolean**| Filters the name of the services to return. | [optional] 
 **count** | **Integer**| The max number of services to return. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignment_getservice

> serviceassignment_getservice(serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceassignmentApi.new
serviceid = 'serviceid_example' # String | The id of the service to get its locations.

begin
  #View a list of locations where a service is available
  api_instance.serviceassignment_getservice(serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceassignmentApi->serviceassignment_getservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**String**](.md)| The id of the service to get its locations. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## serviceassignment_removeservice

> serviceassignment_removeservice(serviceid, locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ServiceassignmentApi.new
serviceid = 'serviceid_example' # String | The id of the service to remove.
locationid = 'locationid_example' # String | The id of the location to remove the service from.

begin
  #Remove a service from a location
  api_instance.serviceassignment_removeservice(serviceid, locationid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ServiceassignmentApi->serviceassignment_removeservice: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**String**](.md)| The id of the service to remove. | 
 **locationid** | [**String**](.md)| The id of the location to remove the service from. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

