# OpenapiClient::WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**waitingline_adduser**](WaitinglineApi.md#waitingline_adduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**waitingline_delete**](WaitinglineApi.md#waitingline_delete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**waitingline_get**](WaitinglineApi.md#waitingline_get) | **GET** /waitingline/{id} | View details of a waiting line
[**waitingline_isuserin**](WaitinglineApi.md#waitingline_isuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitingline_list**](WaitinglineApi.md#waitingline_list) | **GET** /waitingline/list | View a list of waiting lines
[**waitingline_removeuser**](WaitinglineApi.md#waitingline_removeuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**waitingline_save**](WaitinglineApi.md#waitingline_save) | **POST** /waitingline/{id} | Create or edit a waiting line
[**waitingline_signinuser**](WaitinglineApi.md#waitingline_signinuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line



## waitingline_adduser

> waitingline_adduser(station, user, opts)

Put user in a waiting line

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::WaitinglineApi.new
station = 'station_example' # String | The id of the sign-in station.
user = 'user_example' # String | The user's card number.
opts = {
  locationid: 'locationid_example', # String | The location's id where the swipe must be saved.
  time: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The date and time of the swipe.
  signinrole: 'signinrole_example', # String | Specifies if the sign-in is for an attendee or a staff member
  roleid: 'roleid_example', # String | Specifies the role the user has selected in order to sign-in
  services: 'services_example', # String | The services ids the user has selected.
  eventid: 'eventid_example', # String | The id of the event the user selected.
  staff: 'staff_example', # String | The id of the staff member the user selected.
  photosize: 56 # Integer | The swiping user's photo size.
}

begin
  #Put user in a waiting line
  api_instance.waitingline_adduser(station, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_adduser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **user** | **String**| The user&#39;s card number. | 
 **locationid** | [**String**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **DateTime**| The date and time of the swipe. | [optional] 
 **signinrole** | **String**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**String**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **String**| The services ids the user has selected. | [optional] 
 **eventid** | [**String**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**String**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **Integer**| The swiping user&#39;s photo size. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitingline_delete

> waitingline_delete(id, opts)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::WaitinglineApi.new
id = 'id_example' # String | The id of the line to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a waiting line
  api_instance.waitingline_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the line to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## waitingline_get

> waitingline_get(id, opts)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::WaitinglineApi.new
id = 'id_example' # String | The id of the waiting line to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a waiting line
  api_instance.waitingline_get(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the waiting line to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitingline_isuserin

> waitingline_isuserin(station, time, user, opts)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::WaitinglineApi.new
station = 'station_example' # String | The id of the sign-in station.
time = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date and time of the swipe.
user = 'user_example' # String | The card number of the user.
opts = {
  location: 'location_example' # String | The id of the location the user picked.
}

begin
  #Check whether a user is in a waiting line, signed-in or is not in the area
  api_instance.waitingline_isuserin(station, time, user, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_isuserin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**String**](.md)| The id of the sign-in station. | 
 **time** | **DateTime**| The date and time of the swipe. | 
 **user** | **String**| The card number of the user. | 
 **location** | [**String**](.md)| The id of the location the user picked. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitingline_list

> waitingline_list(from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::WaitinglineApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of waiting lines
  api_instance.waitingline_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_list: #{e}"
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


## waitingline_removeuser

> waitingline_removeuser(waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::WaitinglineApi.new
waitingline = 'waitingline_example' # String | The id of the waiting line whose item has to be removed.
itemid = 'itemid_example' # String | The ID of the item that has to be removed.

begin
  #Remove a user from a waiting line
  api_instance.waitingline_removeuser(waitingline, itemid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_removeuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**String**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be removed. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## waitingline_save

> waitingline_save(id, opts)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::WaitinglineApi.new
id = 'id_example' # String | The id of the waiting line save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a waiting line
  api_instance.waitingline_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the waiting line save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## waitingline_signinuser

> waitingline_signinuser(waitingline, itemid, staff, opts)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::WaitinglineApi.new
waitingline = 'waitingline_example' # String | The id of the waiting line whose item needs to be signed-in.
itemid = 'itemid_example' # String | The ID of the item that has to be signed-in.
staff = 'staff_example' # String | The id of the staff member selected to sign-in.
opts = {
  photosize: 56 # Integer | The swiping user's photo size.
}

begin
  #Sign a user in from a waiting line
  api_instance.waitingline_signinuser(waitingline, itemid, staff, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling WaitinglineApi->waitingline_signinuser: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**String**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**String**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**String**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **Integer**| The swiping user&#39;s photo size. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

