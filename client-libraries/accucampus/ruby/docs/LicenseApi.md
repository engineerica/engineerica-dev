# OpenapiClient::LicenseApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**license_acceptagreement**](LicenseApi.md#license_acceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**license_getagreementstatus**](LicenseApi.md#license_getagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**license_getcurrent**](LicenseApi.md#license_getcurrent) | **GET** /license/getcurrent | Gets the current license information
[**license_renew**](LicenseApi.md#license_renew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuCampus subscription



## license_acceptagreement

> license_acceptagreement

Accept the license agreement

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LicenseApi.new

begin
  #Accept the license agreement
  api_instance.license_acceptagreement
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LicenseApi->license_acceptagreement: #{e}"
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


## license_getagreementstatus

> license_getagreementstatus

Check if license agreement has been accepted

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LicenseApi.new

begin
  #Check if license agreement has been accepted
  api_instance.license_getagreementstatus
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LicenseApi->license_getagreementstatus: #{e}"
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


## license_getcurrent

> license_getcurrent

Gets the current license information

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LicenseApi.new

begin
  #Gets the current license information
  api_instance.license_getcurrent
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LicenseApi->license_getcurrent: #{e}"
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


## license_renew

> license_renew(email, phonenumber, opts)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::LicenseApi.new
email = 'email_example' # String | The e-mail of the user sending the request.
phonenumber = 'phonenumber_example' # String | The phone number of the user sending the request.
opts = {
  jobtitle: 'jobtitle_example', # String | The job title of the user sending the request.
  institution: 'institution_example', # String | The institution of the user sending the request.
  comments: 'comments_example' # String | Comments entered by the user sending the request.
}

begin
  #Contact Engineerica in order to renew the AccuCampus subscription
  api_instance.license_renew(email, phonenumber, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling LicenseApi->license_renew: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**| The e-mail of the user sending the request. | 
 **phonenumber** | **String**| The phone number of the user sending the request. | 
 **jobtitle** | **String**| The job title of the user sending the request. | [optional] 
 **institution** | **String**| The institution of the user sending the request. | [optional] 
 **comments** | **String**| Comments entered by the user sending the request. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

