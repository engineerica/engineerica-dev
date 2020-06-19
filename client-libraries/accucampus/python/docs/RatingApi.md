# openapi_client.RatingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rating_flag**](RatingApi.md#rating_flag) | **GET** /rating/flag | Flags one rating for moderation
[**rating_flagcomment**](RatingApi.md#rating_flagcomment) | **GET** /rating/flagcomment | Flags one comment for moderation
[**rating_get**](RatingApi.md#rating_get) | **GET** /rating/get | Get rating for one or more entities
[**rating_getall**](RatingApi.md#rating_getall) | **GET** /rating/getall | Gets the full ratings and comments for a specific entity
[**rating_getcomments**](RatingApi.md#rating_getcomments) | **GET** /rating/getcomments | Gets all the comments for a rating
[**rating_getpending**](RatingApi.md#rating_getpending) | **GET** /rating/getpending | Gets info of pre-saved and pre-approved ratings
[**rating_getpendingmoderation**](RatingApi.md#rating_getpendingmoderation) | **GET** /rating/getpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**rating_moderate**](RatingApi.md#rating_moderate) | **GET** /rating/moderate | Allows the user to accept or reject a comment
[**rating_postcomment**](RatingApi.md#rating_postcomment) | **GET** /rating/postcomment | Posts a comments for in a rating
[**rating_rate**](RatingApi.md#rating_rate) | **GET** /rating/rate | Rates one entity
[**rating_ratepending**](RatingApi.md#rating_ratepending) | **GET** /rating/ratepending | Rates a pre-saved and pre-approved entity
[**rating_vote**](RatingApi.md#rating_vote) | **GET** /rating/vote | Votes up or down a rating


# **rating_flag**
> rating_flag(id, comment=comment)

Flags one rating for moderation

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    id = 'id_example' # str | The rating to flag.
comment = 'comment_example' # str | Comment why should this should be removed. (optional)

    try:
        # Flags one rating for moderation
        api_instance.rating_flag(id, comment=comment)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_flag: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The rating to flag. | 
 **comment** | **str**| Comment why should this should be removed. | [optional] 

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

# **rating_flagcomment**
> rating_flagcomment(id, comment=comment)

Flags one comment for moderation

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    id = 'id_example' # str | The comment to flag.
comment = 'comment_example' # str | Comment why should this should be removed. (optional)

    try:
        # Flags one comment for moderation
        api_instance.rating_flagcomment(id, comment=comment)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_flagcomment: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**str**](.md)| The comment to flag. | 
 **comment** | **str**| Comment why should this should be removed. | [optional] 

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

# **rating_get**
> rating_get(type, entityids)

Get rating for one or more entities

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    type = 'type_example' # str | The entity type to get the rating.
entityids = 'entityids_example' # str | List of ids to get the ratings.

    try:
        # Get rating for one or more entities
        api_instance.rating_get(type, entityids)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **str**| The entity type to get the rating. | 
 **entityids** | **str**| List of ids to get the ratings. | 

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

# **rating_getall**
> rating_getall(type, entityid, mostrecentfirst=mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    type = 'type_example' # str | The entity type to get the rating.
entityid = 'entityid_example' # str | Id of the entity to get the ratings.
mostrecentfirst = True # bool | True to show most recent first, otherwise most helpful first. (optional)

    try:
        # Gets the full ratings and comments for a specific entity
        api_instance.rating_getall(type, entityid, mostrecentfirst=mostrecentfirst)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_getall: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **str**| The entity type to get the rating. | 
 **entityid** | **str**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **bool**| True to show most recent first, otherwise most helpful first. | [optional] 

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

# **rating_getcomments**
> rating_getcomments(ratingid)

Gets all the comments for a rating

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    ratingid = 'ratingid_example' # str | The ID of the rating to get all comments.

    try:
        # Gets all the comments for a rating
        api_instance.rating_getcomments(ratingid)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_getcomments: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**str**](.md)| The ID of the rating to get all comments. | 

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

# **rating_getpending**
> rating_getpending(getgroup, rateid=rateid, rateval=rateval)

Gets info of pre-saved and pre-approved ratings

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.RatingApi(api_client)
    getgroup = 'getgroup_example' # str | The ID of the group of pending ratings to get.
rateid = 'rateid_example' # str | Rate this before returning. (optional)
rateval = 56 # int | The value used to rate the item specified in rateid. (optional)

    try:
        # Gets info of pre-saved and pre-approved ratings
        api_instance.rating_getpending(getgroup, rateid=rateid, rateval=rateval)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_getpending: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**str**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**str**](.md)| Rate this before returning. | [optional] 
 **rateval** | **int**| The value used to rate the item specified in rateid. | [optional] 

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

# **rating_getpendingmoderation**
> rating_getpendingmoderation()

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    
    try:
        # Shows a list of the ratings and comments that are pending for moderation
        api_instance.rating_getpendingmoderation()
    except ApiException as e:
        print("Exception when calling RatingApi->rating_getpendingmoderation: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

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

# **rating_moderate**
> rating_moderate(type, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    type = 'type_example' # str | Either 'rating' or 'comment' depending on what you want to moderate.
id = 'id_example' # str | Id of the rating or comment, as specified in type.
approve = True # bool | True to approve, false to reject.

    try:
        # Allows the user to accept or reject a comment
        api_instance.rating_moderate(type, id, approve)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_moderate: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **str**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**str**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **bool**| True to approve, false to reject. | 

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

# **rating_postcomment**
> rating_postcomment(ratingid, comment, annonymous)

Posts a comments for in a rating

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    ratingid = 'ratingid_example' # str | The ID of the rating to post the comment.
comment = 'comment_example' # str | Text of the comment to post.
annonymous = True # bool | True to post the comment annonymously.

    try:
        # Posts a comments for in a rating
        api_instance.rating_postcomment(ratingid, comment, annonymous)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_postcomment: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**str**](.md)| The ID of the rating to post the comment. | 
 **comment** | **str**| Text of the comment to post. | 
 **annonymous** | **bool**| True to post the comment annonymously. | 

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

# **rating_rate**
> rating_rate(type, entityid, annonymous, value=value, comment=comment, updatecomment=updatecomment)

Rates one entity

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    type = 'type_example' # str | The entity type to rate.
entityid = 'entityid_example' # str | Id of the entity to rate.
annonymous = True # bool | Whether to post as annonymous.
value = 56 # int | Value from 0 to 100 with the rating. (optional)
comment = 'comment_example' # str | Comment associated with this review. Comment can be updated later on another request too. (optional)
updatecomment = True # bool | Whether to update the comments. Defaults to true. (optional)

    try:
        # Rates one entity
        api_instance.rating_rate(type, entityid, annonymous, value=value, comment=comment, updatecomment=updatecomment)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_rate: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **str**| The entity type to rate. | 
 **entityid** | **str**| Id of the entity to rate. | 
 **annonymous** | **bool**| Whether to post as annonymous. | 
 **value** | **int**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **str**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **bool**| Whether to update the comments. Defaults to true. | [optional] 

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

# **rating_ratepending**
> rating_ratepending(group, annonymous, rateid=rateid, value=value, comment=comment, updatecomment=updatecomment)

Rates a pre-saved and pre-approved entity

### Example

```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
)


# Enter a context with an instance of the API client
with openapi_client.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = openapi_client.RatingApi(api_client)
    group = 'group_example' # str | The ID of the group of with pre-approved ratings.
annonymous = True # bool | Whether to post as annonymous.
rateid = 'rateid_example' # str | Rate this before returning. (optional)
value = 56 # int | Value from 0 to 100 with the rating. (optional)
comment = 'comment_example' # str | Comment associated with this review. Comment can be updated later on another request too. (optional)
updatecomment = True # bool | Whether to update the comments. Defaults to true. (optional)

    try:
        # Rates a pre-saved and pre-approved entity
        api_instance.rating_ratepending(group, annonymous, rateid=rateid, value=value, comment=comment, updatecomment=updatecomment)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_ratepending: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**str**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **bool**| Whether to post as annonymous. | 
 **rateid** | [**str**](.md)| Rate this before returning. | [optional] 
 **value** | **int**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **str**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **bool**| Whether to update the comments. Defaults to true. | [optional] 

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

# **rating_vote**
> rating_vote(ratingid, vote)

Votes up or down a rating

### Example

* Bearer (string) Authentication (bearerAuth):
```python
from __future__ import print_function
import time
import openapi_client
from openapi_client.rest import ApiException
from pprint import pprint
# Defining the host is optional and defaults to https://accucampus.net:443/api/v1
# See configuration.py for a list of all supported configuration parameters.
configuration = openapi_client.Configuration(
    host = "https://accucampus.net:443/api/v1"
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
    api_instance = openapi_client.RatingApi(api_client)
    ratingid = 'ratingid_example' # str | The ID of the rating to vote on.
vote = 56 # int | 1 to vote up, -1 to vote down.

    try:
        # Votes up or down a rating
        api_instance.rating_vote(ratingid, vote)
    except ApiException as e:
        print("Exception when calling RatingApi->rating_vote: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**str**](.md)| The ID of the rating to vote on. | 
 **vote** | **int**| 1 to vote up, -1 to vote down. | 

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

