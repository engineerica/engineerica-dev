# Org.OpenAPITools.Api.UserApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserChangepwd**](UserApi.md#userchangepwd) | **GET** /user/changepwd | Change user&#39;s own password
[**UserChangepwdbyreq**](UserApi.md#userchangepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
[**UserDelete**](UserApi.md#userdelete) | **DELETE** /user/{id} | Delete a user
[**UserFindsimilar**](UserApi.md#userfindsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
[**UserGet**](UserApi.md#userget) | **GET** /user/{id} | Search and view details of a user
[**UserGetbycard**](UserApi.md#usergetbycard) | **GET** /user/getbycard | Search user by card number
[**UserList**](UserApi.md#userlist) | **GET** /user/list | View a list of users
[**UserLoadphoto**](UserApi.md#userloadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
[**UserMovedata**](UserApi.md#usermovedata) | **GET** /user/movedata | Move data between users
[**UserRequestpwdchange**](UserApi.md#userrequestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
[**UserSave**](UserApi.md#usersave) | **POST** /user/{id} | Create or edit a user
[**UserSavepwdchange**](UserApi.md#usersavepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords


<a name="userchangepwd"></a>
# **UserChangepwd**
> void UserChangepwd (Guid? oldpass, Guid? newpass)

Change user's own password

Allows the user to change their own password.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserChangepwdExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var oldpass = new Guid?(); // Guid? | The old password of the authenticated user.
            var newpass = new Guid?(); // Guid? | The new password of the authenticated user.

            try
            {
                // Change user's own password
                apiInstance.UserChangepwd(oldpass, newpass);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserChangepwd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oldpass** | [**Guid?**](.md)| The old password of the authenticated user. | 
 **newpass** | [**Guid?**](.md)| The new password of the authenticated user. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userchangepwdbyreq"></a>
# **UserChangepwdbyreq**
> void UserChangepwdbyreq (string changereq, string newpass)

Changes the user password using a change password request id

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserChangepwdbyreqExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var changereq = changereq_example;  // string | The change password request ID sent by email to the user.
            var newpass = newpass_example;  // string | The new password of the user.

            try
            {
                // Changes the user password using a change password request id
                apiInstance.UserChangepwdbyreq(changereq, newpass);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserChangepwdbyreq: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **string**| The change password request ID sent by email to the user. | 
 **newpass** | **string**| The new password of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userdelete"></a>
# **UserDelete**
> void UserDelete (Guid? id, AnyType body)

Delete a user

Allows the user to delete a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var id = new Guid?(); // Guid? | The id of the user to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a user
                apiInstance.UserDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the user to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userfindsimilar"></a>
# **UserFindsimilar**
> void UserFindsimilar (Guid? currentid, string phonenumber, string cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserFindsimilarExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var currentid = new Guid?(); // Guid? | The id of the current user. (optional) 
            var phonenumber = phonenumber_example;  // string | A phone number to search for similar users. (optional) 
            var cardnumber = cardnumber_example;  // string | A card number to search for similar users. (optional) 

            try
            {
                // Finds similar users to prevent duplicates
                apiInstance.UserFindsimilar(currentid, phonenumber, cardnumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserFindsimilar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentid** | [**Guid?**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **string**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **string**| A card number to search for similar users. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userget"></a>
# **UserGet**
> void UserGet (Guid? id, int? photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var id = new Guid?(); // Guid? | The id of the user to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search and view details of a user
                apiInstance.UserGet(id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the user to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetbycard"></a>
# **UserGetbycard**
> void UserGetbycard (string card, int? photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetbycardExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var card = card_example;  // string | The card number of the user to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Search user by card number
                apiInstance.UserGetbycard(card, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGetbycard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **card** | **string**| The card number of the user to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userlist"></a>
# **UserList**
> void UserList (int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var roleid = new Guid?(); // Guid? | The id of the role to filter users by, or empty to return all users. (optional) 
            var onlywithoutcard = onlywithoutcard_example;  // string | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View a list of users
                apiInstance.UserList(from, count, roleid, onlywithoutcard, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **roleid** | [**Guid?**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userloadphoto"></a>
# **UserLoadphoto**
> void UserLoadphoto (string upload, string filename, Guid? userid, bool? automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserLoadphotoExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The local name of the uploaded file. For later reference. (optional) 
            var userid = new Guid?(); // Guid? | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'. (optional) 
            var automatch = true;  // bool? | Set this to true to find the specific user based on the file name.  (optional) 

            try
            {
                // Upload a photo for a specific user
                apiInstance.UserLoadphoto(upload, filename, userid, automatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserLoadphoto: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**Guid?**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **bool?**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usermovedata"></a>
# **UserMovedata**
> void UserMovedata (Guid? source, Guid? destination)

Move data between users

Allows administrators to move data between users.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserMovedataExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var source = new Guid?(); // Guid? | The id of the user that is the source of the data.
            var destination = new Guid?(); // Guid? | The id of the user that is the destination of the data.

            try
            {
                // Move data between users
                apiInstance.UserMovedata(source, destination);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserMovedata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | [**Guid?**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**Guid?**](.md)| The id of the user that is the destination of the data. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userrequestpwdchange"></a>
# **UserRequestpwdchange**
> void UserRequestpwdchange (string domain, string email)

Requests a password change

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserRequestpwdchangeExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var domain = domain_example;  // string | The domain of the account where the user exists.
            var email = email_example;  // string | The email of the user.

            try
            {
                // Requests a password change
                apiInstance.UserRequestpwdchange(domain, email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserRequestpwdchange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The domain of the account where the user exists. | 
 **email** | **string**| The email of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersave"></a>
# **UserSave**
> void UserSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a user

Allows the user to create or edit a user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var id = new Guid?(); // Guid? | The id of the user to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a user
                apiInstance.UserSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the user to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersavepwdchange"></a>
# **UserSavepwdchange**
> void UserSavepwdchange (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserSavepwdchangeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Send email to the specified user(s) to set/change their passwords
                apiInstance.UserSavepwdchange(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserSavepwdchange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

