# OpenapiClient::BgjobApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bgjob_getstatus**](BgjobApi.md#bgjob_getstatus) | **GET** /bgjob/getstatus | Get background job status



## bgjob_getstatus

> bgjob_getstatus(opts)

Get background job status

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::BgjobApi.new
opts = {
  jobid: 'jobid_example', # String | The ID of the job to get the status. 10 most recent will be returned if not specified.
  jobtype: 'jobtype_example' # String | The job type to filter by.
}

begin
  #Get background job status
  api_instance.bgjob_getstatus(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling BgjobApi->bgjob_getstatus: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | [**String**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional] 
 **jobtype** | **String**| The job type to filter by. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

