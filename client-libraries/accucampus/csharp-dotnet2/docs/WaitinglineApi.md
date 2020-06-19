# Org.OpenAPITools.Api.WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WaitinglineAdduser**](WaitinglineApi.md#waitinglineadduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**WaitinglineDelete**](WaitinglineApi.md#waitinglinedelete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**WaitinglineGet**](WaitinglineApi.md#waitinglineget) | **GET** /waitingline/{id} | View details of a waiting line
[**WaitinglineIsuserin**](WaitinglineApi.md#waitinglineisuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**WaitinglineList**](WaitinglineApi.md#waitinglinelist) | **GET** /waitingline/list | View a list of waiting lines
[**WaitinglineRemoveuser**](WaitinglineApi.md#waitinglineremoveuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**WaitinglineSave**](WaitinglineApi.md#waitinglinesave) | **POST** /waitingline/{id} | Create or edit a waiting line
[**WaitinglineSigninuser**](WaitinglineApi.md#waitinglinesigninuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line


<a name="waitinglineadduser"></a>
# **WaitinglineAdduser**
> void WaitinglineAdduser (Guid? station, string user, Guid? locationid, DateTime? time, string signinrole, Guid? roleid, string services, Guid? eventid, Guid? staff, int? photosize)

Put user in a waiting line

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineAdduserExample
    {
        public void main()
        {
            var apiInstance = new WaitinglineApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station.
            var user = user_example;  // string | The user's card number.
            var locationid = new Guid?(); // Guid? | The location's id where the swipe must be saved. (optional) 
            var time = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time of the swipe. (optional) 
            var signinrole = signinrole_example;  // string | Specifies if the sign-in is for an attendee or a staff member (optional) 
            var roleid = new Guid?(); // Guid? | Specifies the role the user has selected in order to sign-in (optional) 
            var services = services_example;  // string | The services ids the user has selected. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event the user selected. (optional) 
            var staff = new Guid?(); // Guid? | The id of the staff member the user selected. (optional) 
            var photosize = 56;  // int? | The swiping user's photo size. (optional) 

            try
            {
                // Put user in a waiting line
                apiInstance.WaitinglineAdduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineAdduser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station. | 
 **user** | **string**| The user&#39;s card number. | 
 **locationid** | [**Guid?**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **DateTime?**| The date and time of the swipe. | [optional] 
 **signinrole** | **string**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**Guid?**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **string**| The services ids the user has selected. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**Guid?**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **int?**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinedelete"></a>
# **WaitinglineDelete**
> void WaitinglineDelete (Guid? id, AnyType body)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WaitinglineApi();
            var id = new Guid?(); // Guid? | The id of the line to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a waiting line
                apiInstance.WaitinglineDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the line to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglineget"></a>
# **WaitinglineGet**
> void WaitinglineGet (Guid? id, int? photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WaitinglineApi();
            var id = new Guid?(); // Guid? | The id of the waiting line to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a waiting line
                apiInstance.WaitinglineGet(id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the waiting line to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglineisuserin"></a>
# **WaitinglineIsuserin**
> void WaitinglineIsuserin (Guid? station, DateTime? time, string user, Guid? location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineIsuserinExample
    {
        public void main()
        {
            var apiInstance = new WaitinglineApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station.
            var time = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time of the swipe.
            var user = user_example;  // string | The card number of the user.
            var location = new Guid?(); // Guid? | The id of the location the user picked. (optional) 

            try
            {
                // Check whether a user is in a waiting line, signed-in or is not in the area
                apiInstance.WaitinglineIsuserin(station, time, user, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineIsuserin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station. | 
 **time** | **DateTime?**| The date and time of the swipe. | 
 **user** | **string**| The card number of the user. | 
 **location** | [**Guid?**](.md)| The id of the location the user picked. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinelist"></a>
# **WaitinglineList**
> void WaitinglineList (int? from, int? count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WaitinglineApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of waiting lines
                apiInstance.WaitinglineList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineList: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglineremoveuser"></a>
# **WaitinglineRemoveuser**
> void WaitinglineRemoveuser (Guid? waitingline, Guid? itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineRemoveuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WaitinglineApi();
            var waitingline = new Guid?(); // Guid? | The id of the waiting line whose item has to be removed.
            var itemid = new Guid?(); // Guid? | The ID of the item that has to be removed.

            try
            {
                // Remove a user from a waiting line
                apiInstance.WaitinglineRemoveuser(waitingline, itemid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineRemoveuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**Guid?**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**Guid?**](.md)| The ID of the item that has to be removed. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinesave"></a>
# **WaitinglineSave**
> void WaitinglineSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WaitinglineApi();
            var id = new Guid?(); // Guid? | The id of the waiting line save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a waiting line
                apiInstance.WaitinglineSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the waiting line save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="waitinglinesigninuser"></a>
# **WaitinglineSigninuser**
> void WaitinglineSigninuser (Guid? waitingline, Guid? itemid, Guid? staff, int? photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WaitinglineSigninuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WaitinglineApi();
            var waitingline = new Guid?(); // Guid? | The id of the waiting line whose item needs to be signed-in.
            var itemid = new Guid?(); // Guid? | The ID of the item that has to be signed-in.
            var staff = new Guid?(); // Guid? | The id of the staff member selected to sign-in.
            var photosize = 56;  // int? | The swiping user's photo size. (optional) 

            try
            {
                // Sign a user in from a waiting line
                apiInstance.WaitinglineSigninuser(waitingline, itemid, staff, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WaitinglineApi.WaitinglineSigninuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**Guid?**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**Guid?**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**Guid?**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **int?**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

