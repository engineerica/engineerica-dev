using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPushApi
    {
        /// <summary>
        /// Deregisters the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param>
        /// <param name="platform">Either ios or android</param>
        /// <returns></returns>
        void PushDeregister (string devicetoken, string platform);
        /// <summary>
        /// Registers the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param>
        /// <param name="platform">Either ios or android</param>
        /// <returns></returns>
        void PushRegister (string devicetoken, string platform);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PushApi : IPushApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PushApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PushApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PushApi(String basePath)
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
        /// Deregisters the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param> 
        /// <param name="platform">Either ios or android</param> 
        /// <returns></returns>            
        public void PushDeregister (string devicetoken, string platform)
        {
            
            // verify the required parameter 'devicetoken' is set
            if (devicetoken == null) throw new ApiException(400, "Missing required parameter 'devicetoken' when calling PushDeregister");
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling PushDeregister");
            
    
            var path = "/push/deregister";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (devicetoken != null) queryParams.Add("devicetoken", ApiClient.ParameterToString(devicetoken)); // query parameter
 if (platform != null) queryParams.Add("platform", ApiClient.ParameterToString(platform)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PushDeregister: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PushDeregister: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Registers the current device to receive push notifications 
        /// </summary>
        /// <param name="devicetoken">The device token where to send the notification.</param> 
        /// <param name="platform">Either ios or android</param> 
        /// <returns></returns>            
        public void PushRegister (string devicetoken, string platform)
        {
            
            // verify the required parameter 'devicetoken' is set
            if (devicetoken == null) throw new ApiException(400, "Missing required parameter 'devicetoken' when calling PushRegister");
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling PushRegister");
            
    
            var path = "/push/register";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (devicetoken != null) queryParams.Add("devicetoken", ApiClient.ParameterToString(devicetoken)); // query parameter
 if (platform != null) queryParams.Add("platform", ApiClient.ParameterToString(platform)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PushRegister: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PushRegister: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
