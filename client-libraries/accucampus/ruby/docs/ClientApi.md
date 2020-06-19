# OpenapiClient::ClientApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**client_get**](ClientApi.md#client_get) | **GET** /client/get | Get client
[**client_list**](ClientApi.md#client_list) | **GET** /client/list | Gets the clients of the specified conference
[**client_save**](ClientApi.md#client_save) | **POST** /client/save | Saves a client
[**client_sendmessage**](ClientApi.md#client_sendmessage) | **GET** /client/sendmessage | Send a message to a client



## client_get

> client_get(client, opts)

Get client

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ClientApi.new
client = 'client_example' # String | The unique id of the client.
opts = {
  clientname: 'clientname_example' # String | The custom name of the client.
}

begin
  #Get client
  api_instance.client_get(client, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ClientApi->client_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **client** | **String**| The unique id of the client. | 
 **clientname** | **String**| The custom name of the client. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## client_list

> client_list(from, count)

Gets the clients of the specified conference

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ClientApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #Gets the clients of the specified conference
  api_instance.client_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ClientApi->client_list: #{e}"
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


## client_save

> client_save(opts)

Saves a client

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ClientApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a client
  api_instance.client_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ClientApi->client_save: #{e}"
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


## client_sendmessage

> client_sendmessage(uniqueclientid, message)

Send a message to a client

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ClientApi.new
uniqueclientid = 'uniqueclientid_example' # String | The unique id of the client.
message = 'message_example' # String | The body of the message to send.

begin
  #Send a message to a client
  api_instance.client_sendmessage(uniqueclientid, message)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ClientApi->client_sendmessage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueclientid** | [**String**](.md)| The unique id of the client. | 
 **message** | **String**| The body of the message to send. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

