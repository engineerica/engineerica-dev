using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQrlabelsApi
    {
        /// <summary>
        /// Print and email QR labels Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
        /// </summary>
        /// <param name="user">The id of the user whose label needs to be printed.</param>
        /// <param name="group">The id of the group whose members&#39; labels need to be printed.</param>
        /// <returns></returns>
        void QrlabelsPrint (Guid? user, Guid? group);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QrlabelsApi : IQrlabelsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QrlabelsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public QrlabelsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QrlabelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QrlabelsApi(String basePath)
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
        /// Print and email QR labels Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
        /// </summary>
        /// <param name="user">The id of the user whose label needs to be printed.</param> 
        /// <param name="group">The id of the group whose members&#39; labels need to be printed.</param> 
        /// <returns></returns>            
        public void QrlabelsPrint (Guid? user, Guid? group)
        {
            
    
            var path = "/qrlabels/print";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling QrlabelsPrint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling QrlabelsPrint: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
