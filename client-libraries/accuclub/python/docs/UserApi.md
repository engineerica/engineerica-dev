# openapi_client.UserApi

All URIs are relative to *https://accuclub.net:443/api/v1*

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


# **user_changepwd**
> user_changepwd(oldpass, newpass)

Change user's own password

Allows the user to change their own password.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    oldpass = 'oldpass_example' # str | The old password of the authenticated user.
newpass = 'newpass_example' # str | The new password of the authenticated user.

    try:
        # Change user's own password
        api_instance.user_changepwd(oldpass, newpass)
    except ApiException as e:
        print("Exception when calling UserApi->user_changepwd: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oldpass** | [**str**](.md)| The old password of the authenticated user. | 
 **newpass** | [**str**](.md)| The new password of the authenticated user. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_changepwdbyreq**
> user_changepwdbyreq(changereq, newpass)

Changes the user password using a change password request id

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    changereq = 'changereq_example' # str | The change password request ID sent by email to the user.
newpass = 'newpass_example' # str | The new password of the user.

    try:
        # Changes the user password using a change password request id
        api_instance.user_changepwdbyreq(changereq, newpass)
    except ApiException as e:
        print("Exception when calling UserApi->user_changepwdbyreq: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **str**| The change password request ID sent by email to the user. | 
 **newpass** | **str**| The new password of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_delete**
> user_delete(id, body=body)

Delete a user

Allows the user to delete a user.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    id = 'id_example' # str | The id of the user to delete.
body = None # object |  (optional)

    try:
        # Delete a user
        api_instance.user_delete(id, body=body)
    except ApiException as e:
        print("Exception when calling UserApi->user_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the user to delete. | 
 **body** | **object**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_findsimilar**
> user_findsimilar(currentid=currentid, phonenumber=phonenumber, cardnumber=cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    currentid = 'currentid_example' # str | The id of the current user. (optional)
phonenumber = 'phonenumber_example' # str | A phone number to search for similar users. (optional)
cardnumber = 'cardnumber_example' # str | A card number to search for similar users. (optional)

    try:
        # Finds similar users to prevent duplicates
        api_instance.user_findsimilar(currentid=currentid, phonenumber=phonenumber, cardnumber=cardnumber)
    except ApiException as e:
        print("Exception when calling UserApi->user_findsimilar: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentid** | [**str**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **str**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **str**| A card number to search for similar users. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_get**
> user_get(id, photosize=photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    id = 'id_example' # str | The id of the user to get.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Search and view details of a user
        api_instance.user_get(id, photosize=photosize)
    except ApiException as e:
        print("Exception when calling UserApi->user_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_getbycard**
> user_getbycard(card, photosize=photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    card = 'card_example' # str | The card number of the user to get.
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # Search user by card number
        api_instance.user_getbycard(card, photosize=photosize)
    except ApiException as e:
        print("Exception when calling UserApi->user_getbycard: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **card** | **str**| The card number of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_list**
> user_list(_from, count, roleid=roleid, onlywithoutcard=onlywithoutcard, photosize=photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    _from = 56 # int | The first record to return.
count = 56 # int | The max number of records to return.
roleid = 'roleid_example' # str | The id of the role to filter users by, or empty to return all users. (optional)
onlywithoutcard = 'onlywithoutcard_example' # str | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional)
photosize = 56 # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional)

    try:
        # View a list of users
        api_instance.user_list(_from, count, roleid=roleid, onlywithoutcard=onlywithoutcard, photosize=photosize)
    except ApiException as e:
        print("Exception when calling UserApi->user_list: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **roleid** | [**str**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **str**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_loadphoto**
> user_loadphoto(upload, filename=filename, userid=userid, automatch=automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    upload = 'upload_example' # str | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
filename = 'filename_example' # str | The local name of the uploaded file. For later reference. (optional)
userid = 'userid_example' # str | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'. (optional)
automatch = True # bool | Set this to true to find the specific user based on the file name.  (optional)

    try:
        # Upload a photo for a specific user
        api_instance.user_loadphoto(upload, filename=filename, userid=userid, automatch=automatch)
    except ApiException as e:
        print("Exception when calling UserApi->user_loadphoto: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **str**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **str**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**str**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **bool**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_movedata**
> user_movedata(source, destination)

Move data between users

Allows administrators to move data between users.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    source = 'source_example' # str | The id of the user that is the source of the data.
destination = 'destination_example' # str | The id of the user that is the destination of the data.

    try:
        # Move data between users
        api_instance.user_movedata(source, destination)
    except ApiException as e:
        print("Exception when calling UserApi->user_movedata: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | [**str**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**str**](.md)| The id of the user that is the destination of the data. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_requestpwdchange**
> user_requestpwdchange(domain, email)

Requests a password change

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    domain = 'domain_example' # str | The domain of the account where the user exists.
email = 'email_example' # str | The email of the user.

    try:
        # Requests a password change
        api_instance.user_requestpwdchange(domain, email)
    except ApiException as e:
        print("Exception when calling UserApi->user_requestpwdchange: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **str**| The domain of the account where the user exists. | 
 **email** | **str**| The email of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_save**
> user_save(id, unknown_base_type=unknown_base_type)

Create or edit a user

Allows the user to create or edit a user.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    id = 'id_example' # str | The id of the user to save (leave empty to create a new one).
unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Create or edit a user
        api_instance.user_save(id, unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling UserApi->user_save: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The id of the user to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_savepwdchange**
> user_savepwdchange(unknown_base_type=unknown_base_type)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accuclub.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accuclub.net:443/api/v1"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure Bearer authorization (string): bearerAuth
configuration = openapi_client.Configuration(
    access_token = 'YOUR_BEARER_TOKEN'
)

# Enter a context with an instance of the API client
with openapi_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.UserApi(api_client)
    unknown_base_type = openapi_client.UNKNOWN_BASE_TYPE() # UNKNOWN_BASE_TYPE |  (optional)

    try:
        # Send email to the specified user(s) to set/change their passwords
        api_instance.user_savepwdchange(unknown_base_type=unknown_base_type)
    except ApiException as e:
        print("Exception when calling UserApi->user_savepwdchange: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

