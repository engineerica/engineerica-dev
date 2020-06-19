# OpenapiClient::CommunityApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**community_invite**](CommunityApi.md#community_invite) | **GET** /community/invite | Sends an invitation to everyone to AccuCampus Communities
[**community_join**](CommunityApi.md#community_join) | **GET** /community/join | Sends an invitation for myself to AccuCampus Communities



## community_invite

> community_invite

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CommunityApi.new

begin
  #Sends an invitation to everyone to AccuCampus Communities
  api_instance.community_invite
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CommunityApi->community_invite: #{e}"
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


## community_join

> community_join

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::CommunityApi.new

begin
  #Sends an invitation for myself to AccuCampus Communities
  api_instance.community_join
rescue OpenapiClient::ApiError => e
  puts "Exception when calling CommunityApi->community_join: #{e}"
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

