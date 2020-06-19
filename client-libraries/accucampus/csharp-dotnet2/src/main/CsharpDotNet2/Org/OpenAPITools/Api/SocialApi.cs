using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISocialApi
    {
        /// <summary>
        /// Gets the list of contacts in the network 
        /// </summary>
        /// <param name="filter">Text to filter results.</param>
        /// <param name="showdefaultphoto">If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.</param>
        /// <returns></returns>
        void SocialContacts (string filter, bool? showdefaultphoto);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SocialApi : ISocialApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SocialApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SocialApi(String basePath)
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
        /// Gets the list of contacts in the network 
        /// </summary>
        /// <param name="filter">Text to filter results.</param> 
        /// <param name="showdefaultphoto">If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.</param> 
        /// <returns></returns>            
        public void SocialContacts (string filter, bool? showdefaultphoto)
        {
            
    
            var path = "/social/contacts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (showdefaultphoto != null) queryParams.Add("showdefaultphoto", ApiClient.ParameterToString(showdefaultphoto)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SocialContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SocialContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
