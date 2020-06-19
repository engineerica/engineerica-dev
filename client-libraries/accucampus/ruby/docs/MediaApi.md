# OpenapiClient::MediaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**media_checkin**](MediaApi.md#media_checkin) | **GET** /media/checkin | Check in media item
[**media_checkout**](MediaApi.md#media_checkout) | **GET** /media/checkout | Check out media item
[**media_checkoutlist**](MediaApi.md#media_checkoutlist) | **GET** /media/checkoutlist | View a list of past media checkouts
[**media_delete**](MediaApi.md#media_delete) | **DELETE** /media/{id} | Delete a media item
[**media_deletecheckoutlog**](MediaApi.md#media_deletecheckoutlog) | **DELETE** /media/deletecheckoutlog | Delete a media checkout log
[**media_get**](MediaApi.md#media_get) | **GET** /media/{id} | Search and view details of a media item
[**media_getbycode**](MediaApi.md#media_getbycode) | **GET** /media/getbycode | Search media item by unique code
[**media_getcheckout**](MediaApi.md#media_getcheckout) | **GET** /media/getcheckout | View details of a media item checkout information
[**media_getcheckoutlog**](MediaApi.md#media_getcheckoutlog) | **GET** /media/getcheckoutlog | View details of a media checkout log
[**media_list**](MediaApi.md#media_list) | **GET** /media/list | View a list of media items
[**media_save**](MediaApi.md#media_save) | **POST** /media/{id} | Create or edit a media item



## media_checkin

> media_checkin(media, checkindate, opts)

Check in media item

Allows the user to check in a media item.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
media = 'media_example' # String | The id of the media item to checkin.
checkindate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The checkout date.
opts = {
  notes: 'notes_example' # String | The notes of the checkout.
}

begin
  #Check in media item
  api_instance.media_checkin(media, checkindate, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_checkin: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**String**](.md)| The id of the media item to checkin. | 
 **checkindate** | **DateTime**| The checkout date. | 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_checkout

> media_checkout(media, user, checkoutdate, duedate, opts)

Check out media item

Allows the user to check out a media item.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
media = 'media_example' # String | The id of the media item to checkout.
user = 'user_example' # String | The id of the user that is checking the item out.
checkoutdate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The checkout date.
duedate = DateTime.parse('2013-10-20T19:20:30+01:00') # DateTime | The date when the checkout is due.
opts = {
  staff: 'staff_example', # String | The id of the staff member related to the checkout.
  event: 'event_example', # String | The id of the event related to the checkout.
  notes: 'notes_example' # String | The notes of the checkout.
}

begin
  #Check out media item
  api_instance.media_checkout(media, user, checkoutdate, duedate, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_checkout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**String**](.md)| The id of the media item to checkout. | 
 **user** | [**String**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **DateTime**| The checkout date. | 
 **duedate** | **DateTime**| The date when the checkout is due. | 
 **staff** | [**String**](.md)| The id of the staff member related to the checkout. | [optional] 
 **event** | [**String**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **String**| The notes of the checkout. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_checkoutlist

> media_checkoutlist(from, count, opts)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  media: 'media_example', # String | Used to filter the checkouts of a specific media item.
  user: 'user_example', # String | Used to filter the checkouts made by a specific user.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View a list of past media checkouts
  api_instance.media_checkoutlist(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_checkoutlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **media** | [**String**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**String**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_delete

> media_delete(id, opts)

Delete a media item

Allows the user to delete an existing media item.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
id = 'id_example' # String | The id of the media item to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a media item
  api_instance.media_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## media_deletecheckoutlog

> media_deletecheckoutlog(opts)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Delete a media checkout log
  api_instance.media_deletecheckoutlog(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_deletecheckoutlog: #{e}"
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


## media_get

> media_get(id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
id = 'id_example' # String | The id of the media item to get.

begin
  #Search and view details of a media item
  api_instance.media_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_getbycode

> media_getbycode(code, opts)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
code = 'code_example' # String | The code of the media item to get.
opts = {
  location: 'location_example' # String | The location where to look for the media item.
}

begin
  #Search media item by unique code
  api_instance.media_getbycode(code, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_getbycode: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **String**| The code of the media item to get. | 
 **location** | [**String**](.md)| The location where to look for the media item. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_getcheckout

> media_getcheckout(id, opts)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
id = 'id_example' # String | The id of the media item whose checkout information has to be retrieved.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a media item checkout information
  api_instance.media_getcheckout(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_getcheckout: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_getcheckoutlog

> media_getcheckoutlog(id, opts)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
id = 'id_example' # String | The id of the media item whose checkout information has to be retrieved.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View details of a media checkout log
  api_instance.media_getcheckoutlog(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_getcheckoutlog: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_list

> media_list(from, count, opts)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  status: 56, # Integer | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
  user: 'user_example' # String | Used to filter the media items that are checked-out by a specific user.
}

begin
  #View a list of media items
  api_instance.media_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **status** | **Integer**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**String**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## media_save

> media_save(id, opts)

Create or edit a media item

Allows the user to create or edit a media item.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::MediaApi.new
id = 'id_example' # String | The id of the media item save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a media item
  api_instance.media_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MediaApi->media_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the media item save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

