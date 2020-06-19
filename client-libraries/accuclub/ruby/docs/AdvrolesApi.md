# OpenapiClient::AdvrolesApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advroles_userlist**](AdvrolesApi.md#advroles_userlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.



## advroles_userlist

> advroles_userlist(from, count, opts)

List users. Alias to user.list, use that one instead.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvrolesApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  roleid: 'roleid_example', # String | The id of the role to filter users by, or empty to return all users.
  onlywithoutcard: 'onlywithoutcard_example', # String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #List users. Alias to user.list, use that one instead.
  api_instance.advroles_userlist(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvrolesApi->advroles_userlist: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **roleid** | [**String**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **String**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

