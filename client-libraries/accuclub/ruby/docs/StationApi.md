# OpenapiClient::StationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**station_delete**](StationApi.md#station_delete) | **DELETE** /station/{id} | Delete a sign-in station
[**station_get**](StationApi.md#station_get) | **GET** /station/{id} | View details of a sign-in station
[**station_getcurrentterms**](StationApi.md#station_getcurrentterms) | **GET** /station/getcurrentterms | Get all the current terms
[**station_getinfo**](StationApi.md#station_getinfo) | **GET** /station/getinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**station_getlicense**](StationApi.md#station_getlicense) | **GET** /station/getlicense | Gets the current license information
[**station_list**](StationApi.md#station_list) | **GET** /station/list | View a list of sign-in stations
[**station_save**](StationApi.md#station_save) | **POST** /station/{id} | Create or edit a sign-in station
[**station_unlock**](StationApi.md#station_unlock) | **GET** /station/unlock | Unlocks the sign-in station.



## station_delete

> station_delete(id, opts)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StationApi.new
id = 'id_example' # String | The id of the sign-in station to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a sign-in station
  api_instance.station_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## station_get

> station_get(id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StationApi.new
id = 'id_example' # String | The id of the sign-in station to get.

begin
  #View details of a sign-in station
  api_instance.station_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## station_getcurrentterms

> station_getcurrentterms(station)

Get all the current terms

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::StationApi.new
station = 'station_example' # String | The id of the sign-in station whose account's current terms have to be retrieved.

begin
  #Get all the current terms
  api_instance.station_getcurrentterms(station)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_getcurrentterms: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## station_getinfo

> station_getinfo(id, opts)

Gets a the info to display in the sign-in station by it's ID.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::StationApi.new
id = 'id_example' # String | The id of the sign-in station to get.
opts = {
  event: 'event_example' # String | The id of the event, to override the one by schedule.
}

begin
  #Gets a the info to display in the sign-in station by it's ID.
  api_instance.station_getinfo(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_getinfo: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to get. | 
 **event** | [**String**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## station_getlicense

> station_getlicense(station)

Gets the current license information

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::StationApi.new
station = 'station_example' # String | The id of the sign-in station whose account's license has to be retrieved.

begin
  #Gets the current license information
  api_instance.station_getlicense(station)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_getlicense: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **String**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## station_list

> station_list(from, count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StationApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of sign-in stations
  api_instance.station_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## station_save

> station_save(id, opts)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::StationApi.new
id = 'id_example' # String | The id of the sign-in station to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a sign-in station
  api_instance.station_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## station_unlock

> station_unlock(id, passcode, method)

Unlocks the sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::StationApi.new
id = 'id_example' # String | The id of the sign-in station to unlock.
passcode = 'passcode_example' # String | The passcode to unlock the station.
method = 'method_example' # String | The authentication method. Valid values are 'token' and 'cookie'.

begin
  #Unlocks the sign-in station.
  api_instance.station_unlock(id, passcode, method)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling StationApi->station_unlock: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **String**| The passcode to unlock the station. | 
 **method** | **String**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

