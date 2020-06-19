# OpenapiClient::UserApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**user_changepwd**](UserApi.md#user_changepwd) | **GET** /user/changepwd | Change user&#39;s own password
[**user_changepwdbyreq**](UserApi.md#user_changepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
[**user_delete**](UserApi.md#user_delete) | **DELETE** /user/{id} | Delete a user
[**user_findsimilar**](UserApi.md#user_findsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
[**user_get**](UserApi.md#user_get) | **GET** /user/{id} | Search and view details of a user
[**user_getbycard**](UserApi.md#user_getbycard) | **GET** /user/getbycard | Search user by card number
[**user_list**](UserApi.md#user_list) | **GET** /user/list | View a list of users
[**user_loadphoto**](UserApi.md#user_loadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
[**user_movedata**](UserApi.md#user_movedata) | **GET** /user/movedata | Move data between users
[**user_requestpwdchange**](UserApi.md#user_requestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
[**user_save**](UserApi.md#user_save) | **POST** /user/{id} | Create or edit a user
[**user_savepwdchange**](UserApi.md#user_savepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords



## user_changepwd

> user_changepwd(oldpass, newpass)

Change user's own password

Allows the user to change their own password.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
oldpass = 'oldpass_example' # String | The old password of the authenticated user.
newpass = 'newpass_example' # String | The new password of the authenticated user.

begin
  #Change user's own password
  api_instance.user_changepwd(oldpass, newpass)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_changepwd: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oldpass** | [**String**](.md)| The old password of the authenticated user. | 
 **newpass** | [**String**](.md)| The new password of the authenticated user. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_changepwdbyreq

> user_changepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::UserApi.new
changereq = 'changereq_example' # String | The change password request ID sent by email to the user.
newpass = 'newpass_example' # String | The new password of the user.

begin
  #Changes the user password using a change password request id
  api_instance.user_changepwdbyreq(changereq, newpass)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_changepwdbyreq: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **String**| The change password request ID sent by email to the user. | 
 **newpass** | **String**| The new password of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_delete

> user_delete(id, opts)

Delete a user

Allows the user to delete a user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
id = 'id_example' # String | The id of the user to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a user
  api_instance.user_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the user to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## user_findsimilar

> user_findsimilar(opts)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
opts = {
  currentid: 'currentid_example', # String | The id of the current user.
  phonenumber: 'phonenumber_example', # String | A phone number to search for similar users.
  cardnumber: 'cardnumber_example' # String | A card number to search for similar users.
}

begin
  #Finds similar users to prevent duplicates
  api_instance.user_findsimilar(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_findsimilar: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentid** | [**String**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **String**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **String**| A card number to search for similar users. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_get

> user_get(id, opts)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
id = 'id_example' # String | The id of the user to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Search and view details of a user
  api_instance.user_get(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the user to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_getbycard

> user_getbycard(card, opts)

Search user by card number

Allows the user to search for a user by their card number.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
card = 'card_example' # String | The card number of the user to get.
opts = {
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #Search user by card number
  api_instance.user_getbycard(card, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_getbycard: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **card** | **String**| The card number of the user to get. | 
 **photosize** | **Integer**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_list

> user_list(from, count, opts)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  roleid: 'roleid_example', # String | The id of the role to filter users by, or empty to return all users.
  onlywithoutcard: 'onlywithoutcard_example', # String | If is 1 then only the users without a card are returned, otherwise all users are returned.
  photosize: 56 # Integer | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
}

begin
  #View a list of users
  api_instance.user_list(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_list: #{e}"
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


## user_loadphoto

> user_loadphoto(upload, opts)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
opts = {
  filename: 'filename_example', # String | The local name of the uploaded file. For later reference.
  userid: 'userid_example', # String | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
  automatch: true # Boolean | Set this to true to find the specific user based on the file name. 
}

begin
  #Upload a photo for a specific user
  api_instance.user_loadphoto(upload, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_loadphoto: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**String**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **Boolean**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_movedata

> user_movedata(source, destination)

Move data between users

Allows administrators to move data between users.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
source = 'source_example' # String | The id of the user that is the source of the data.
destination = 'destination_example' # String | The id of the user that is the destination of the data.

begin
  #Move data between users
  api_instance.user_movedata(source, destination)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_movedata: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | [**String**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**String**](.md)| The id of the user that is the destination of the data. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_requestpwdchange

> user_requestpwdchange(domain, email)

Requests a password change

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::UserApi.new
domain = 'domain_example' # String | The domain of the account where the user exists.
email = 'email_example' # String | The email of the user.

begin
  #Requests a password change
  api_instance.user_requestpwdchange(domain, email)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_requestpwdchange: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **String**| The domain of the account where the user exists. | 
 **email** | **String**| The email of the user. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## user_save

> user_save(id, opts)

Create or edit a user

Allows the user to create or edit a user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
id = 'id_example' # String | The id of the user to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a user
  api_instance.user_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the user to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## user_savepwdchange

> user_savepwdchange(opts)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::UserApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Send email to the specified user(s) to set/change their passwords
  api_instance.user_savepwdchange(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling UserApi->user_savepwdchange: #{e}"
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

