# OpenapiClient::InteractionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**interaction_delete**](InteractionApi.md#interaction_delete) | **DELETE** /interaction/{id} | Delete an interaction
[**interaction_feed**](InteractionApi.md#interaction_feed) | **GET** /interaction/feed | Get the interactions feed
[**interaction_get**](InteractionApi.md#interaction_get) | **GET** /interaction/{id} | View an interaction
[**interaction_listprivatesummary**](InteractionApi.md#interaction_listprivatesummary) | **GET** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**interaction_save**](InteractionApi.md#interaction_save) | **POST** /interaction/{id} | Save an interaction



## interaction_delete

> interaction_delete(id, opts)

Delete an interaction

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::InteractionApi.new
id = 'id_example' # String | The id of the interaction to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete an interaction
  api_instance.interaction_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling InteractionApi->interaction_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the interaction to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## interaction_feed

> interaction_feed(from, count, opts)

Get the interactions feed

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::InteractionApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | If set, only interactions that happened after this date are returned.
  public: true, # Boolean | Specifies whether to return public or private interactions.
  contexttype: 'contexttype_example', # String | The type of the context of the interactions to return.
  contextid: 'contextid_example', # String | The id of the context of the interactions to return.
  types: 'types_example', # String | The  comma separated types of the interactions to return.
  photosize: 56, # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  showdefaultphoto: true, # Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
  orderdescending: true # Boolean | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.
}

begin
  #Get the interactions feed
  api_instance.interaction_feed(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling InteractionApi->interaction_feed: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **startdate** | **DateTime**| If set, only interactions that happened after this date are returned. | [optional] 
 **public** | **Boolean**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **String**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**String**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **String**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **Boolean**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interaction_get

> interaction_get(id, opts)

View an interaction

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::InteractionApi.new
id = 'id_example' # String | The id of the interaction.
opts = {
  thumbnailmediasize: 56, # Integer | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View an interaction
  api_instance.interaction_get(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling InteractionApi->interaction_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The id of the interaction. | 
 **thumbnailmediasize** | **Integer**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interaction_listprivatesummary

> interaction_listprivatesummary(opts)

Get current user's latest private interactions

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::InteractionApi.new
opts = {
  photosize: 56, # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
  showdefaultphoto: true # Boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.
}

begin
  #Get current user's latest private interactions
  api_instance.interaction_listprivatesummary(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling InteractionApi->interaction_listprivatesummary: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **Boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## interaction_save

> interaction_save(id, opts)

Save an interaction

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::InteractionApi.new
id = 'id_example' # String | The id of the interaction to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save an interaction
  api_instance.interaction_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling InteractionApi->interaction_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the interaction to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

