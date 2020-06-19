# OpenapiClient::BeaconApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**beacon_delete**](BeaconApi.md#beacon_delete) | **DELETE** /beacon/{id} | Delete a beacon profile
[**beacon_disable**](BeaconApi.md#beacon_disable) | **GET** /beacon/disable | Disable beacon support account wide
[**beacon_get**](BeaconApi.md#beacon_get) | **GET** /beacon/{id} | View details of a beacon profile
[**beacon_getlocations**](BeaconApi.md#beacon_getlocations) | **GET** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
[**beacon_getstationlocation**](BeaconApi.md#beacon_getstationlocation) | **GET** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
[**beacon_getuuid**](BeaconApi.md#beacon_getuuid) | **GET** /beacon/getuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**beacon_list**](BeaconApi.md#beacon_list) | **GET** /beacon/list | View a list of beacon profiles
[**beacon_listprofiles**](BeaconApi.md#beacon_listprofiles) | **GET** /beacon/listprofiles | View a list of beacon profiles with their characteristics
[**beacon_resetuuid**](BeaconApi.md#beacon_resetuuid) | **GET** /beacon/resetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**beacon_save**](BeaconApi.md#beacon_save) | **POST** /beacon/{id} | Create or edit a beacon profile
[**beacon_scanlocations**](BeaconApi.md#beacon_scanlocations) | **GET** /beacon/scanlocations | Check if there&#39;s location available to sign-in / out.
[**beacon_setuuid**](BeaconApi.md#beacon_setuuid) | **GET** /beacon/setuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**beacon_silentregions**](BeaconApi.md#beacon_silentregions) | **GET** /beacon/silentregions | View all the beacon regions defined for silent tracking
[**beacon_silentsignin**](BeaconApi.md#beacon_silentsignin) | **GET** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
[**beacon_silentsignout**](BeaconApi.md#beacon_silentsignout) | **GET** /beacon/silentsignout | Sign-out silently from the location specified by a beacon



## beacon_delete

> beacon_delete(id, opts)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
id = 'id_example' # String | The id of the beacon to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a beacon profile
  api_instance.beacon_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the beacon to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## beacon_disable

> beacon_disable

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new

begin
  #Disable beacon support account wide
  api_instance.beacon_disable
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_disable: #{e}"
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


## beacon_get

> beacon_get(id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
id = 'id_example' # String | The id of the beacon to get.

begin
  #View details of a beacon profile
  api_instance.beacon_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the beacon to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacon_getlocations

> beacon_getlocations(beacons)

Get the sign-in stations assigned to specific beacons.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
beacons = 'beacons_example' # String | A JSON array containg the beacons data (region, minor and major) values.

begin
  #Get the sign-in stations assigned to specific beacons.
  api_instance.beacon_getlocations(beacons)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_getlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacon_getstationlocation

> beacon_getstationlocation(station, location)

Get the location settings in the specified sign-in station.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
station = 'station_example' # String | The id of the sign-in station whose location information has to be retrieved.
location = 'location_example' # String | The id of the location whose information has to be retrieved.

begin
  #Get the location settings in the specified sign-in station.
  api_instance.beacon_getstationlocation(station, location)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_getstationlocation: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**String**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacon_getuuid

> beacon_getuuid

View the identifier for the account's beacon region (for sign-in stations).

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new

begin
  #View the identifier for the account's beacon region (for sign-in stations).
  api_instance.beacon_getuuid
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_getuuid: #{e}"
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


## beacon_list

> beacon_list(from, count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of beacon profiles
  api_instance.beacon_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_list: #{e}"
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


## beacon_listprofiles

> beacon_listprofiles

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new

begin
  #View a list of beacon profiles with their characteristics
  api_instance.beacon_listprofiles
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_listprofiles: #{e}"
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


## beacon_resetuuid

> beacon_resetuuid

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new

begin
  #Generate or reset the identifier for the account's beacon region.
  api_instance.beacon_resetuuid
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_resetuuid: #{e}"
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


## beacon_save

> beacon_save(id, opts)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
id = 'id_example' # String | The id of the beacon save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a beacon profile
  api_instance.beacon_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the beacon save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## beacon_scanlocations

> beacon_scanlocations(beacons)

Check if there's location available to sign-in / out.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
beacons = 'beacons_example' # String | A JSON array containg the beacons data (region, minor and major) values.

begin
  #Check if there's location available to sign-in / out.
  api_instance.beacon_scanlocations(beacons)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_scanlocations: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **String**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacon_setuuid

> beacon_setuuid(id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
id = 'id_example' # String | The custom region UUID.

begin
  #Set the identifier for the account's beacon region (for sign-in stations).
  api_instance.beacon_setuuid(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_setuuid: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The custom region UUID. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacon_silentregions

> beacon_silentregions

View all the beacon regions defined for silent tracking

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new

begin
  #View all the beacon regions defined for silent tracking
  api_instance.beacon_silentregions
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_silentregions: #{e}"
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


## beacon_silentsignin

> beacon_silentsignin(uuid)

Sign-in silently from the location specified by a beacon

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
uuid = 'uuid_example' # String | The id of the region the user is in.

begin
  #Sign-in silently from the location specified by a beacon
  api_instance.beacon_silentsignin(uuid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_silentsignin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**String**](.md)| The id of the region the user is in. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## beacon_silentsignout

> beacon_silentsignout(uuid)

Sign-out silently from the location specified by a beacon

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BeaconApi.new
uuid = 'uuid_example' # String | The id of the region the user has left.

begin
  #Sign-out silently from the location specified by a beacon
  api_instance.beacon_silentsignout(uuid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BeaconApi->beacon_silentsignout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**String**](.md)| The id of the region the user has left. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

