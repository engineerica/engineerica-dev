# OpenapiClient::CompassserviceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**compassservice_list**](CompassserviceApi.md#compassservice_list) | **GET** /compassservice/list | View all the services added to the compass
[**compassservice_listlocations**](CompassserviceApi.md#compassservice_listlocations) | **GET** /compassservice/listlocations | View all the locations where a service added to the compass is available



## compassservice_list

> compassservice_list(opts)

View all the services added to the compass

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CompassserviceApi.new
opts = {
  category: 'category_example' # String | The id of the category to filter the services.
}

begin
  #View all the services added to the compass
  api_instance.compassservice_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CompassserviceApi->compassservice_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**String**](.md)| The id of the category to filter the services. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## compassservice_listlocations

> compassservice_listlocations(serviceid)

View all the locations where a service added to the compass is available

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CompassserviceApi.new
serviceid = 'serviceid_example' # String | The id of the service to get its locations.

begin
  #View all the locations where a service added to the compass is available
  api_instance.compassservice_listlocations(serviceid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CompassserviceApi->compassservice_listlocations: #{e}"
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

