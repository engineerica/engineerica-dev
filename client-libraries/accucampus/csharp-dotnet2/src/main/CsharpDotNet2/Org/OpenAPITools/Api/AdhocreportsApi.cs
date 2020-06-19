using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdhocreportsApi
    {
        /// <summary>
        /// Request access to the ad-hoc reports Allows the user to request access to the ad-hoc reports by clicking, &#39;Request Access&#39; under Institutional Research -&gt; Ad-hoc Reports
        /// </summary>
        /// <returns></returns>
        void AdhocreportsReqaccess ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AdhocreportsApi : IAdhocreportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocreportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AdhocreportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocreportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdhocreportsApi(String basePath)
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
        /// Request access to the ad-hoc reports Allows the user to request access to the ad-hoc reports by clicking, &#39;Request Access&#39; under Institutional Research -&gt; Ad-hoc Reports
        /// </summary>
        /// <returns></returns>            
        public void AdhocreportsReqaccess ()
        {
            
    
            var path = "/adhocreports/reqaccess";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AdhocreportsReqaccess: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AdhocreportsReqaccess: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
