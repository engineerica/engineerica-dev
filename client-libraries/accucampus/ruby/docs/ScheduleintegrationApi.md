# OpenapiClient::ScheduleintegrationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**scheduleintegration_clearids**](ScheduleintegrationApi.md#scheduleintegration_clearids) | **GET** /scheduleintegration/clearids | Clear all third party IDs from specified staff member&#39;s schedule items.
[**scheduleintegration_deleteitem**](ScheduleintegrationApi.md#scheduleintegration_deleteitem) | **DELETE** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
[**scheduleintegration_deleteitemsbymasterid**](ScheduleintegrationApi.md#scheduleintegration_deleteitemsbymasterid) | **DELETE** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**scheduleintegration_getitem**](ScheduleintegrationApi.md#scheduleintegration_getitem) | **GET** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
[**scheduleintegration_saveitem**](ScheduleintegrationApi.md#scheduleintegration_saveitem) | **POST** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
[**scheduleintegration_setid**](ScheduleintegrationApi.md#scheduleintegration_setid) | **GET** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item



## scheduleintegration_clearids

> scheduleintegration_clearids(staff)

Clear all third party IDs from specified staff member's schedule items.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleintegrationApi.new
staff = 'staff_example' # String | The ID of the staff member whose schedule items third party IDs must be cleared.

begin
  #Clear all third party IDs from specified staff member's schedule items.
  api_instance.scheduleintegration_clearids(staff)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleintegrationApi->scheduleintegration_clearids: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staff** | [**String**](.md)| The ID of the staff member whose schedule items third party IDs must be cleared. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegration_deleteitem

> scheduleintegration_deleteitem(opts)

Delete a schedule item looking up by a third party ID

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleintegrationApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Delete a schedule item looking up by a third party ID
  api_instance.scheduleintegration_deleteitem(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleintegrationApi->scheduleintegration_deleteitem: #{e}"
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


## scheduleintegration_deleteitemsbymasterid

> scheduleintegration_deleteitemsbymasterid(opts)

Delete multiple schedule items looking up by a third party master ID

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleintegrationApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Delete multiple schedule items looking up by a third party master ID
  api_instance.scheduleintegration_deleteitemsbymasterid(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleintegrationApi->scheduleintegration_deleteitemsbymasterid: #{e}"
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


## scheduleintegration_getitem

> scheduleintegration_getitem(thirdpartyid)

Get a schedule item looking up by a third party ID

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleintegrationApi.new
thirdpartyid = 'thirdpartyid_example' # String | The third party id to search for the schedule item.

begin
  #Get a schedule item looking up by a third party ID
  api_instance.scheduleintegration_getitem(thirdpartyid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleintegrationApi->scheduleintegration_getitem: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdpartyid** | **String**| The third party id to search for the schedule item. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## scheduleintegration_saveitem

> scheduleintegration_saveitem(opts)

Save a schedule item looking up by a third party ID

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleintegrationApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save a schedule item looking up by a third party ID
  api_instance.scheduleintegration_saveitem(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleintegrationApi->scheduleintegration_saveitem: #{e}"
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


## scheduleintegration_setid

> scheduleintegration_setid(id, thirdpartyid, opts)

Set a 3rd party ID on a specific schedule item

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ScheduleintegrationApi.new
id = 'id_example' # String | The id of the schedule block / appointment.
thirdpartyid = 'thirdpartyid_example' # String | The 3rd party ID to set.
opts = {
  thirdpartymasterid: 'thirdpartymasterid_example' # String | The 3rd party master ID to set (useful to handle recurring items).
}

begin
  #Set a 3rd party ID on a specific schedule item
  api_instance.scheduleintegration_setid(id, thirdpartyid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ScheduleintegrationApi->scheduleintegration_setid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the schedule block / appointment. | 
 **thirdpartyid** | **String**| The 3rd party ID to set. | 
 **thirdpartymasterid** | **String**| The 3rd party master ID to set (useful to handle recurring items). | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

