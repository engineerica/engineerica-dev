using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityApi
    {
        /// <summary>
        /// Returns the list of users for a specific permission 
        /// </summary>
        /// <param name="commandname">Name of the action or command to get the roles.</param>
        /// <returns></returns>
        void SecurityAssesspermission (string commandname);
        /// <summary>
        /// Returns the list of permissions for a specific role 
        /// </summary>
        /// <param name="roleid">Role ID to list the effective permissions.</param>
        /// <returns></returns>
        void SecurityAssessrole (Guid? roleid);
        /// <summary>
        /// Returns the list of users for a specific user 
        /// </summary>
        /// <param name="locationid">Location ID to list the users with that scope.</param>
        /// <returns></returns>
        void SecurityAssessscope (Guid? locationid);
        /// <summary>
        /// Returns the list of permissions for a specific user 
        /// </summary>
        /// <param name="userid">User ID to list the effective permissions.</param>
        /// <returns></returns>
        void SecurityAssessuser (Guid? userid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SecurityApi : ISecurityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SecurityApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityApi(String basePath)
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
        /// Returns the list of users for a specific permission 
        /// </summary>
        /// <param name="commandname">Name of the action or command to get the roles.</param> 
        /// <returns></returns>            
        public void SecurityAssesspermission (string commandname)
        {
            
            // verify the required parameter 'commandname' is set
            if (commandname == null) throw new ApiException(400, "Missing required parameter 'commandname' when calling SecurityAssesspermission");
            
    
            var path = "/security/assesspermission";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (commandname != null) queryParams.Add("commandname", ApiClient.ParameterToString(commandname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssesspermission: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssesspermission: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the list of permissions for a specific role 
        /// </summary>
        /// <param name="roleid">Role ID to list the effective permissions.</param> 
        /// <returns></returns>            
        public void SecurityAssessrole (Guid? roleid)
        {
            
            // verify the required parameter 'roleid' is set
            if (roleid == null) throw new ApiException(400, "Missing required parameter 'roleid' when calling SecurityAssessrole");
            
    
            var path = "/security/assessrole";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssessrole: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssessrole: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the list of users for a specific user 
        /// </summary>
        /// <param name="locationid">Location ID to list the users with that scope.</param> 
        /// <returns></returns>            
        public void SecurityAssessscope (Guid? locationid)
        {
            
    
            var path = "/security/assessscope";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssessscope: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssessscope: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Returns the list of permissions for a specific user 
        /// </summary>
        /// <param name="userid">User ID to list the effective permissions.</param> 
        /// <returns></returns>            
        public void SecurityAssessuser (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling SecurityAssessuser");
            
    
            var path = "/security/assessuser";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssessuser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SecurityAssessuser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
