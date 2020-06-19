# OpenapiClient::VirtuallineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**virtualline_addmyself**](VirtuallineApi.md#virtualline_addmyself) | **GET** /virtualline/addmyself | Add myself to a waiting line
[**virtualline_list**](VirtuallineApi.md#virtualline_list) | **GET** /virtualline/list | Lists waiting lines that have remote access enabled
[**virtualline_removemyself**](VirtuallineApi.md#virtualline_removemyself) | **GET** /virtualline/removemyself | Remove myself from a waiting line



## virtualline_addmyself

> virtualline_addmyself(waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::VirtuallineApi.new
waitinglineid = 'waitinglineid_example' # String | ID of the waiting line to join.

begin
  #Add myself to a waiting line
  api_instance.virtualline_addmyself(waitinglineid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling VirtuallineApi->virtualline_addmyself: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitinglineid** | [**String**](.md)| ID of the waiting line to join. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## virtualline_list

> virtualline_list

Lists waiting lines that have remote access enabled

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::VirtuallineApi.new

begin
  #Lists waiting lines that have remote access enabled
  api_instance.virtualline_list
rescue OpenapiClient::ApiError => e
  puts "Exception when calling VirtuallineApi->virtualline_list: #{e}"
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


## virtualline_removemyself

> virtualline_removemyself

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::VirtuallineApi.new

begin
  #Remove myself from a waiting line
  api_instance.virtualline_removemyself
rescue OpenapiClient::ApiError => e
  puts "Exception when calling VirtuallineApi->virtualline_removemyself: #{e}"
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

