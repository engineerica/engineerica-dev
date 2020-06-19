# OpenapiClient::ActionlogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionlog_list**](ActionlogApi.md#actionlog_list) | **GET** /actionlog/list | View a list of users action logs



## actionlog_list

> actionlog_list(from, count, opts)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::ActionlogApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  user: 'user_example', # String | The id of the user whose action logs have to be returned.
  startdate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The start date of the period to filter the logs.
  enddate: DateTime.parse('2013-10-20T19:20:30+01:00'), # DateTime | The end date of the period to filter the logs.
  resource: 'resource_example', # String | The resource to filter the action logs.
  actionfilter: 'actionfilter_example', # String | The action to filter the action logs.
  argument: 'argument_example' # String | The id of the entity that was the argument of the executed action.
}

begin
  #View a list of users action logs
  api_instance.actionlog_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling ActionlogApi->actionlog_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **user** | [**String**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the logs. | [optional] 
 **resource** | **String**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **String**| The action to filter the action logs. | [optional] 
 **argument** | **String**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

