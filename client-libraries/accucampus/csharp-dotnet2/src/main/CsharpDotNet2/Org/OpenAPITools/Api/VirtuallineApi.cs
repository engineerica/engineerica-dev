using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVirtuallineApi
    {
        /// <summary>
        /// Add myself to a waiting line Allows the user to add themselves to a waiting line from the AccuCampus mobile app.
        /// </summary>
        /// <param name="waitinglineid">ID of the waiting line to join.</param>
        /// <returns></returns>
        void VirtuallineAddmyself (Guid? waitinglineid);
        /// <summary>
        /// Lists waiting lines that have remote access enabled 
        /// </summary>
        /// <returns></returns>
        void VirtuallineList ();
        /// <summary>
        /// Remove myself from a waiting line Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.
        /// </summary>
        /// <returns></returns>
        void VirtuallineRemovemyself ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VirtuallineApi : IVirtuallineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtuallineApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VirtuallineApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtuallineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VirtuallineApi(String basePath)
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
        /// Add myself to a waiting line Allows the user to add themselves to a waiting line from the AccuCampus mobile app.
        /// </summary>
        /// <param name="waitinglineid">ID of the waiting line to join.</param> 
        /// <returns></returns>            
        public void VirtuallineAddmyself (Guid? waitinglineid)
        {
            
            // verify the required parameter 'waitinglineid' is set
            if (waitinglineid == null) throw new ApiException(400, "Missing required parameter 'waitinglineid' when calling VirtuallineAddmyself");
            
    
            var path = "/virtualline/addmyself";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (waitinglineid != null) queryParams.Add("waitinglineid", ApiClient.ParameterToString(waitinglineid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VirtuallineAddmyself: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VirtuallineAddmyself: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists waiting lines that have remote access enabled 
        /// </summary>
        /// <returns></returns>            
        public void VirtuallineList ()
        {
            
    
            var path = "/virtualline/list";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VirtuallineList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VirtuallineList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove myself from a waiting line Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.
        /// </summary>
        /// <returns></returns>            
        public void VirtuallineRemovemyself ()
        {
            
    
            var path = "/virtualline/removemyself";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VirtuallineRemovemyself: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VirtuallineRemovemyself: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
