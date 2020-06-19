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
    public interface IAdvroleApi
    {
        /// <summary>
        /// Adds the missing permissions to a role. Requires access to advrole.save 
        /// </summary>
        /// <param name="roles">CSV list of the role ids to check</param>
        /// <param name="permissions">CSV list of the permissions to check</param>
        /// <returns></returns>
        void AdvroleAddmissing (string roles, string permissions);
        /// <summary>
        /// Checks the permissions are assigned for the given roles 
        /// </summary>
        /// <param name="roles">CSV list of the role ids to check</param>
        /// <param name="permissions">CSV list of the permissions to check</param>
        /// <returns></returns>
        void AdvroleCheckperm (string roles, string permissions);
        /// <summary>
        /// Delete a role Allows the user to delete a role from the list of available roles.
        /// </summary>
        /// <param name="id">The id of the location to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void AdvroleDelete (Guid? id, AnyType body);
        /// <summary>
        /// Delete a role mapping Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void AdvroleDeletemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// View details of a role Allows the user to view a role and its details.
        /// </summary>
        /// <param name="id">The id of the location to get.</param>
        /// <returns></returns>
        void AdvroleGet (Guid? id);
        /// <summary>
        /// Lists the roles for the current account 
        /// </summary>
        /// <param name="includepolicies">True to include the policies, defaults to false.</param>
        /// <param name="includeinternal">True to include the internal roles too.</param>
        /// <param name="name">Filter by name of the role.</param>
        /// <returns></returns>
        void AdvroleList (bool? includepolicies, bool? includeinternal, string name);
        /// <summary>
        /// Lists the maps a roles is mapped to 
        /// </summary>
        /// <param name="roleid">The id of the role to list the maps.</param>
        /// <returns></returns>
        void AdvroleListmaps (Guid? roleid);
        /// <summary>
        /// Lists the roles mappings 
        /// </summary>
        /// <param name="map">List only the roles in the specified map.</param>
        /// <returns></returns>
        void AdvroleListrolesmapped (string map);
        /// <summary>
        /// View a list of role templates Allows the user to view the full list of available role templates.
        /// </summary>
        /// <returns></returns>
        void AdvroleListtemplates ();
        /// <summary>
        /// Create or edit a role Allows the user to create or edit a role&#39;s permissions.
        /// </summary>
        /// <param name="id">The id of the role to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void AdvroleSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Saves a role mapping Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void AdvroleSavemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Upgrade a user to another role (requires permission to edit those roles) Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
        /// </summary>
        /// <param name="userid">Id of the user to upgrade</param>
        /// <param name="roleid">Id of the role to add</param>
        /// <returns></returns>
        void AdvroleUserupgrade (Guid? userid, Guid? roleid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdvroleApi : IAdvroleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvroleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AdvroleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvroleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdvroleApi(String basePath)
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
        /// Adds the missing permissions to a role. Requires access to advrole.save 
        /// </summary>
        /// <param name="roles">CSV list of the role ids to check</param> 
        /// <param name="permissions">CSV list of the permissions to check</param> 
        /// <returns></returns>            
        public void AdvroleAddmissing (string roles, string permissions)
        {
            
            // verify the required parameter 'roles' is set
            if (roles == null) throw new ApiException(400, "Missing required parameter 'roles' when calling AdvroleAddmissing");
            
            // verify the required parameter 'permissions' is set
            if (permissions == null) throw new ApiException(400, "Missing required parameter 'permissions' when calling AdvroleAddmissing");
            
    
            var path = "/advrole/addmissing";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (roles != null) queryParams.Add("roles", ApiClient.ParameterToString(roles)); // query parameter
 if (permissions != null) queryParams.Add("permissions", ApiClient.ParameterToString(permissions)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleAddmissing: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleAddmissing: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Checks the permissions are assigned for the given roles 
        /// </summary>
        /// <param name="roles">CSV list of the role ids to check</param> 
        /// <param name="permissions">CSV list of the permissions to check</param> 
        /// <returns></returns>            
        public void AdvroleCheckperm (string roles, string permissions)
        {
            
            // verify the required parameter 'roles' is set
            if (roles == null) throw new ApiException(400, "Missing required parameter 'roles' when calling AdvroleCheckperm");
            
            // verify the required parameter 'permissions' is set
            if (permissions == null) throw new ApiException(400, "Missing required parameter 'permissions' when calling AdvroleCheckperm");
            
    
            var path = "/advrole/checkperm";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (roles != null) queryParams.Add("roles", ApiClient.ParameterToString(roles)); // query parameter
 if (permissions != null) queryParams.Add("permissions", ApiClient.ParameterToString(permissions)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleCheckperm: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleCheckperm: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a role Allows the user to delete a role from the list of available roles.
        /// </summary>
        /// <param name="id">The id of the location to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void AdvroleDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AdvroleDelete");
            
    
            var path = "/advrole/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a role mapping Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void AdvroleDeletemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/advrole/deletemapping";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleDeletemapping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleDeletemapping: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a role Allows the user to view a role and its details.
        /// </summary>
        /// <param name="id">The id of the location to get.</param> 
        /// <returns></returns>            
        public void AdvroleGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AdvroleGet");
            
    
            var path = "/advrole/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the roles for the current account 
        /// </summary>
        /// <param name="includepolicies">True to include the policies, defaults to false.</param> 
        /// <param name="includeinternal">True to include the internal roles too.</param> 
        /// <param name="name">Filter by name of the role.</param> 
        /// <returns></returns>            
        public void AdvroleList (bool? includepolicies, bool? includeinternal, string name)
        {
            
    
            var path = "/advrole/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includepolicies != null) queryParams.Add("includepolicies", ApiClient.ParameterToString(includepolicies)); // query parameter
 if (includeinternal != null) queryParams.Add("includeinternal", ApiClient.ParameterToString(includeinternal)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the maps a roles is mapped to 
        /// </summary>
        /// <param name="roleid">The id of the role to list the maps.</param> 
        /// <returns></returns>            
        public void AdvroleListmaps (Guid? roleid)
        {
            
            // verify the required parameter 'roleid' is set
            if (roleid == null) throw new ApiException(400, "Missing required parameter 'roleid' when calling AdvroleListmaps");
            
    
            var path = "/advrole/listmaps";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleListmaps: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleListmaps: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the roles mappings 
        /// </summary>
        /// <param name="map">List only the roles in the specified map.</param> 
        /// <returns></returns>            
        public void AdvroleListrolesmapped (string map)
        {
            
    
            var path = "/advrole/listrolesmapped";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleListrolesmapped: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleListrolesmapped: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of role templates Allows the user to view the full list of available role templates.
        /// </summary>
        /// <returns></returns>            
        public void AdvroleListtemplates ()
        {
            
    
            var path = "/advrole/listtemplates";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleListtemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleListtemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a role Allows the user to create or edit a role&#39;s permissions.
        /// </summary>
        /// <param name="id">The id of the role to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void AdvroleSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AdvroleSave");
            
    
            var path = "/advrole/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a role mapping Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void AdvroleSavemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/advrole/savemapping";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleSavemapping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleSavemapping: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Upgrade a user to another role (requires permission to edit those roles) Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
        /// </summary>
        /// <param name="userid">Id of the user to upgrade</param> 
        /// <param name="roleid">Id of the role to add</param> 
        /// <returns></returns>            
        public void AdvroleUserupgrade (Guid? userid, Guid? roleid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling AdvroleUserupgrade");
            
            // verify the required parameter 'roleid' is set
            if (roleid == null) throw new ApiException(400, "Missing required parameter 'roleid' when calling AdvroleUserupgrade");
            
    
            var path = "/advrole/userupgrade";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (roleid != null) queryParams.Add("roleid", ApiClient.ParameterToString(roleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleUserupgrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdvroleUserupgrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
