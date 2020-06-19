using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi
    {
        /// <summary>
        /// Change user&#39;s own password Allows the user to change their own password.
        /// </summary>
        /// <param name="oldpass">The old password of the authenticated user.</param>
        /// <param name="newpass">The new password of the authenticated user.</param>
        /// <returns></returns>
        void UserChangepwd (Guid? oldpass, Guid? newpass);
        /// <summary>
        /// Changes the user password using a change password request id 
        /// </summary>
        /// <param name="changereq">The change password request ID sent by email to the user.</param>
        /// <param name="newpass">The new password of the user.</param>
        /// <returns></returns>
        void UserChangepwdbyreq (string changereq, string newpass);
        /// <summary>
        /// Delete a user Allows the user to delete a user.
        /// </summary>
        /// <param name="id">The id of the user to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UserDelete (Guid? id, AnyType body);
        /// <summary>
        /// Finds similar users to prevent duplicates Allows the user to be warned if a user they are creating has the same card number as another user.
        /// </summary>
        /// <param name="currentid">The id of the current user.</param>
        /// <param name="phonenumber">A phone number to search for similar users.</param>
        /// <param name="cardnumber">A card number to search for similar users.</param>
        /// <returns></returns>
        void UserFindsimilar (Guid? currentid, string phonenumber, string cardnumber);
        /// <summary>
        /// Search and view details of a user Allows the user to search and view a user and their details.
        /// </summary>
        /// <param name="id">The id of the user to get.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void UserGet (Guid? id, int? photosize);
        /// <summary>
        /// Search user by card number Allows the user to search for a user by their card number.
        /// </summary>
        /// <param name="card">The card number of the user to get.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void UserGetbycard (string card, int? photosize);
        /// <summary>
        /// View a list of users Allows the user to view the full list of users and is based on role permissions.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param>
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void UserList (int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize);
        /// <summary>
        /// Upload a photo for a specific user Allows the user to upload a photo for a user.
        /// </summary>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The local name of the uploaded file. For later reference.</param>
        /// <param name="userid">The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;.</param>
        /// <param name="automatch">Set this to true to find the specific user based on the file name. </param>
        /// <returns></returns>
        void UserLoadphoto (string upload, string filename, Guid? userid, bool? automatch);
        /// <summary>
        /// Move data between users Allows administrators to move data between users.
        /// </summary>
        /// <param name="source">The id of the user that is the source of the data.</param>
        /// <param name="destination">The id of the user that is the destination of the data.</param>
        /// <returns></returns>
        void UserMovedata (Guid? source, Guid? destination);
        /// <summary>
        /// Requests a password change 
        /// </summary>
        /// <param name="domain">The domain of the account where the user exists.</param>
        /// <param name="email">The email of the user.</param>
        /// <returns></returns>
        void UserRequestpwdchange (string domain, string email);
        /// <summary>
        /// Create or edit a user Allows the user to create or edit a user.
        /// </summary>
        /// <param name="id">The id of the user to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void UserSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Send email to the specified user(s) to set/change their passwords Allows the user to trigger an email to another user asking them to set or change their password.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void UserSavepwdchange (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Change user&#39;s own password Allows the user to change their own password.
        /// </summary>
        /// <param name="oldpass">The old password of the authenticated user.</param> 
        /// <param name="newpass">The new password of the authenticated user.</param> 
        /// <returns></returns>            
        public void UserChangepwd (Guid? oldpass, Guid? newpass)
        {
            
            // verify the required parameter 'oldpass' is set
            if (oldpass == null) throw new ApiException(400, "Missing required parameter 'oldpass' when calling UserChangepwd");
            
            // verify the required parameter 'newpass' is set
            if (newpass == null) throw new ApiException(400, "Missing required parameter 'newpass' when calling UserChangepwd");
            
    
            var path = "/user/changepwd";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (oldpass != null) queryParams.Add("oldpass", ApiClient.ParameterToString(oldpass)); // query parameter
 if (newpass != null) queryParams.Add("newpass", ApiClient.ParameterToString(newpass)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserChangepwd: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserChangepwd: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Changes the user password using a change password request id 
        /// </summary>
        /// <param name="changereq">The change password request ID sent by email to the user.</param> 
        /// <param name="newpass">The new password of the user.</param> 
        /// <returns></returns>            
        public void UserChangepwdbyreq (string changereq, string newpass)
        {
            
            // verify the required parameter 'changereq' is set
            if (changereq == null) throw new ApiException(400, "Missing required parameter 'changereq' when calling UserChangepwdbyreq");
            
            // verify the required parameter 'newpass' is set
            if (newpass == null) throw new ApiException(400, "Missing required parameter 'newpass' when calling UserChangepwdbyreq");
            
    
            var path = "/user/changepwdbyreq";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (changereq != null) queryParams.Add("changereq", ApiClient.ParameterToString(changereq)); // query parameter
 if (newpass != null) queryParams.Add("newpass", ApiClient.ParameterToString(newpass)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserChangepwdbyreq: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserChangepwdbyreq: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a user Allows the user to delete a user.
        /// </summary>
        /// <param name="id">The id of the user to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UserDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserDelete");
            
    
            var path = "/user/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Finds similar users to prevent duplicates Allows the user to be warned if a user they are creating has the same card number as another user.
        /// </summary>
        /// <param name="currentid">The id of the current user.</param> 
        /// <param name="phonenumber">A phone number to search for similar users.</param> 
        /// <param name="cardnumber">A card number to search for similar users.</param> 
        /// <returns></returns>            
        public void UserFindsimilar (Guid? currentid, string phonenumber, string cardnumber)
        {
            
    
            var path = "/user/findsimilar";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (currentid != null) queryParams.Add("currentid", ApiClient.ParameterToString(currentid)); // query parameter
 if (phonenumber != null) queryParams.Add("phonenumber", ApiClient.ParameterToString(phonenumber)); // query parameter
 if (cardnumber != null) queryParams.Add("cardnumber", ApiClient.ParameterToString(cardnumber)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserFindsimilar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserFindsimilar: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a user Allows the user to search and view a user and their details.
        /// </summary>
        /// <param name="id">The id of the user to get.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void UserGet (Guid? id, int? photosize)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGet");
            
    
            var path = "/user/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search user by card number Allows the user to search for a user by their card number.
        /// </summary>
        /// <param name="card">The card number of the user to get.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void UserGetbycard (string card, int? photosize)
        {
            
            // verify the required parameter 'card' is set
            if (card == null) throw new ApiException(400, "Missing required parameter 'card' when calling UserGetbycard");
            
    
            var path = "/user/getbycard";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (card != null) queryParams.Add("card", ApiClient.ParameterToString(card)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetbycard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetbycard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of users Allows the user to view the full list of users and is based on role permissions.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="roleid">The id of the role to filter users by, or empty to return all users.</param> 
        /// <param name="onlywithoutcard">If is 1 then only the users without a card are returned, otherwise all users are returned.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void UserList (int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling UserList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling UserList");
            
    
            var path = "/user/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
 if (onlywithoutcard != null) queryParams.Add("onlywithoutcard", ApiClient.ParameterToString(onlywithoutcard)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Upload a photo for a specific user Allows the user to upload a photo for a user.
        /// </summary>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The local name of the uploaded file. For later reference.</param> 
        /// <param name="userid">The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;.</param> 
        /// <param name="automatch">Set this to true to find the specific user based on the file name. </param> 
        /// <returns></returns>            
        public void UserLoadphoto (string upload, string filename, Guid? userid, bool? automatch)
        {
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling UserLoadphoto");
            
    
            var path = "/user/loadphoto";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (automatch != null) queryParams.Add("automatch", ApiClient.ParameterToString(automatch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserLoadphoto: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserLoadphoto: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Move data between users Allows administrators to move data between users.
        /// </summary>
        /// <param name="source">The id of the user that is the source of the data.</param> 
        /// <param name="destination">The id of the user that is the destination of the data.</param> 
        /// <returns></returns>            
        public void UserMovedata (Guid? source, Guid? destination)
        {
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling UserMovedata");
            
            // verify the required parameter 'destination' is set
            if (destination == null) throw new ApiException(400, "Missing required parameter 'destination' when calling UserMovedata");
            
    
            var path = "/user/movedata";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
 if (destination != null) queryParams.Add("destination", ApiClient.ParameterToString(destination)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMovedata: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserMovedata: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Requests a password change 
        /// </summary>
        /// <param name="domain">The domain of the account where the user exists.</param> 
        /// <param name="email">The email of the user.</param> 
        /// <returns></returns>            
        public void UserRequestpwdchange (string domain, string email)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling UserRequestpwdchange");
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling UserRequestpwdchange");
            
    
            var path = "/user/requestpwdchange";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
 if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserRequestpwdchange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserRequestpwdchange: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a user Allows the user to create or edit a user.
        /// </summary>
        /// <param name="id">The id of the user to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void UserSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserSave");
            
    
            var path = "/user/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send email to the specified user(s) to set/change their passwords Allows the user to trigger an email to another user asking them to set or change their password.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void UserSavepwdchange (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/user/savepwdchange";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserSavepwdchange: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserSavepwdchange: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
