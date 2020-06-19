using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEasyloginApi
    {
        /// <summary>
        /// Adds background image for the login Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.
        /// </summary>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The original filename, needed to process the file.</param>
        /// <returns></returns>
        void EasyloginAddbgimage (string upload, string filename);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EasyloginApi : IEasyloginApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EasyloginApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EasyloginApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EasyloginApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EasyloginApi(String basePath)
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
        /// Adds background image for the login Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.
        /// </summary>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The original filename, needed to process the file.</param> 
        /// <returns></returns>            
        public void EasyloginAddbgimage (string upload, string filename)
        {
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling EasyloginAddbgimage");
            
            // verify the required parameter 'filename' is set
            if (filename == null) throw new ApiException(400, "Missing required parameter 'filename' when calling EasyloginAddbgimage");
            
    
            var path = "/easylogin/addbgimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EasyloginAddbgimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EasyloginAddbgimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
