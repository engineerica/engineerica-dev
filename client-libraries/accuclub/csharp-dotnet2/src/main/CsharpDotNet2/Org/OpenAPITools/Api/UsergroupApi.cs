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
    public interface IUsergroupApi
    {
        /// <summary>
        /// Add a user to a group Allows the user to add a user to a group that they have permission to edit.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="groupid">The id of the group.</param>
        /// <returns></returns>
        void UsergroupAddmember (Guid? userid, Guid? groupid);
        /// <summary>
        /// Delete a group Allows the user to delete a group that they have permission to edit.
        /// </summary>
        /// <param name="id">The id of the group to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UsergroupDelete (Guid? id, AnyType body);
        /// <summary>
        /// Search and view details of a user group Allows the user to view a user group and its details.
        /// </summary>
        /// <param name="id">The id of the user group to get.</param>
        /// <returns></returns>
        void UsergroupGet (Guid? id);
        /// <summary>
        /// View the members of a user group Allows the user to view the list of users in a group that they have permission to view.
        /// </summary>
        /// <param name="groupid">The id of the user group to get.</param>
        /// <returns></returns>
        void UsergroupGetmembers (Guid? groupid);
        /// <summary>
        /// View the groups which a user is registered to Allows the user to view the groups an individual user is registered to, based on group and user permissions.
        /// </summary>
        /// <param name="userid">The id of the user to get his groups.</param>
        /// <returns></returns>
        void UsergroupGetuser (Guid? userid);
        /// <summary>
        /// View a list of user groups Allows the user to view the list of groups that they have permission to view.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="type">The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group.</param>
        /// <returns></returns>
        void UsergroupList (int? from, int? count, string type);
        /// <summary>
        /// Refresh the dynamic group Allows the user to refresh a dynamic group that they have permission to edit.
        /// </summary>
        /// <param name="group">The ID of the group to refresh.</param>
        /// <returns></returns>
        void UsergroupRefresh (Guid? group);
        /// <summary>
        /// Remove a user from a group Allows the user to remove a user from a group that they have permission to edit.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="groupid">The id of the group.</param>
        /// <returns></returns>
        void UsergroupRemovemember (Guid? userid, Guid? groupid);
        /// <summary>
        /// Create or edit a group Allows the user to create a new group or edit a group that they have permission to edit.
        /// </summary>
        /// <param name="id">The id of the group to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void UsergroupSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsergroupApi : IUsergroupApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsergroupApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsergroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsergroupApi(String basePath)
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
        /// Add a user to a group Allows the user to add a user to a group that they have permission to edit.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="groupid">The id of the group.</param> 
        /// <returns></returns>            
        public void UsergroupAddmember (Guid? userid, Guid? groupid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling UsergroupAddmember");
            
            // verify the required parameter 'groupid' is set
            if (groupid == null) throw new ApiException(400, "Missing required parameter 'groupid' when calling UsergroupAddmember");
            
    
            var path = "/usergroup/addmember";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupAddmember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupAddmember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a group Allows the user to delete a group that they have permission to edit.
        /// </summary>
        /// <param name="id">The id of the group to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void UsergroupDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsergroupDelete");
            
    
            var path = "/usergroup/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a user group Allows the user to view a user group and its details.
        /// </summary>
        /// <param name="id">The id of the user group to get.</param> 
        /// <returns></returns>            
        public void UsergroupGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsergroupGet");
            
    
            var path = "/usergroup/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the members of a user group Allows the user to view the list of users in a group that they have permission to view.
        /// </summary>
        /// <param name="groupid">The id of the user group to get.</param> 
        /// <returns></returns>            
        public void UsergroupGetmembers (Guid? groupid)
        {
            
            // verify the required parameter 'groupid' is set
            if (groupid == null) throw new ApiException(400, "Missing required parameter 'groupid' when calling UsergroupGetmembers");
            
    
            var path = "/usergroup/getmembers";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupGetmembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupGetmembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the groups which a user is registered to Allows the user to view the groups an individual user is registered to, based on group and user permissions.
        /// </summary>
        /// <param name="userid">The id of the user to get his groups.</param> 
        /// <returns></returns>            
        public void UsergroupGetuser (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling UsergroupGetuser");
            
    
            var path = "/usergroup/getuser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupGetuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupGetuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of user groups Allows the user to view the list of groups that they have permission to view.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="type">The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group.</param> 
        /// <returns></returns>            
        public void UsergroupList (int? from, int? count, string type)
        {
            
    
            var path = "/usergroup/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Refresh the dynamic group Allows the user to refresh a dynamic group that they have permission to edit.
        /// </summary>
        /// <param name="group">The ID of the group to refresh.</param> 
        /// <returns></returns>            
        public void UsergroupRefresh (Guid? group)
        {
            
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling UsergroupRefresh");
            
    
            var path = "/usergroup/refresh";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupRefresh: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupRefresh: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a user from a group Allows the user to remove a user from a group that they have permission to edit.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="groupid">The id of the group.</param> 
        /// <returns></returns>            
        public void UsergroupRemovemember (Guid? userid, Guid? groupid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling UsergroupRemovemember");
            
            // verify the required parameter 'groupid' is set
            if (groupid == null) throw new ApiException(400, "Missing required parameter 'groupid' when calling UsergroupRemovemember");
            
    
            var path = "/usergroup/removemember";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupRemovemember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupRemovemember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a group Allows the user to create a new group or edit a group that they have permission to edit.
        /// </summary>
        /// <param name="id">The id of the group to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void UsergroupSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsergroupSave");
            
    
            var path = "/usergroup/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsergroupSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
