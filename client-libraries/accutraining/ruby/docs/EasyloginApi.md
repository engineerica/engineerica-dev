# OpenapiClient::EasyloginApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**easylogin_addbgimage**](EasyloginApi.md#easylogin_addbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login



## easylogin_addbgimage

> easylogin_addbgimage(upload, filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuTraining account not using SSO.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::EasyloginApi.new
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # String | The original filename, needed to process the file.

begin
  #Adds background image for the login
  api_instance.easylogin_addbgimage(upload, filename)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling EasyloginApi->easylogin_addbgimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The original filename, needed to process the file. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

