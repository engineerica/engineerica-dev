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
    public interface IUsersettingsApi
    {
        /// <summary>
        /// Lists available user settings 
        /// </summary>
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param>
        /// <param name="user">The user id whose settings have to be returned.</param>
        /// <returns></returns>
        void UsersettingsGet (string keys, Guid? user);
        /// <summary>
        /// Get multiple user settings 
        /// </summary>
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param>
        /// <param name="user">The user id whose settings have to be returned.</param>
        /// <returns></returns>
        void UsersettingsGetmultiple (string keys, Guid? user);
        /// <summary>
        /// Saves a user setting 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void UsersettingsSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Save multiple user settings at once 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void UsersettingsSavemultiple (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersettingsApi : IUsersettingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersettingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersettingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersettingsApi(String basePath)
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
        /// Lists available user settings 
        /// </summary>
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param> 
        /// <param name="user">The user id whose settings have to be returned.</param> 
        /// <returns></returns>            
        public void UsersettingsGet (string keys, Guid? user)
        {
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling UsersettingsGet");
            
    
            var path = "/usersettings/get";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get multiple user settings 
        /// </summary>
        /// <param name="keys">Setting key to get. Can be multiple separated by commas.</param> 
        /// <param name="user">The user id whose settings have to be returned.</param> 
        /// <returns></returns>            
        public void UsersettingsGetmultiple (string keys, Guid? user)
        {
            
            // verify the required parameter 'keys' is set
            if (keys == null) throw new ApiException(400, "Missing required parameter 'keys' when calling UsersettingsGetmultiple");
            
    
            var path = "/usersettings/getmultiple";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keys != null) queryParams.Add("keys", ApiClient.ParameterToString(keys)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsGetmultiple: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsGetmultiple: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Saves a user setting 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void UsersettingsSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usersettings/save";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save multiple user settings at once 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void UsersettingsSavemultiple (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/usersettings/savemultiple";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsSavemultiple: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersettingsSavemultiple: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
