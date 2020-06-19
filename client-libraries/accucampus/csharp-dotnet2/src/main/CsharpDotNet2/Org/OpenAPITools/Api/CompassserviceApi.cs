using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompassserviceApi
    {
        /// <summary>
        /// View all the services added to the compass 
        /// </summary>
        /// <param name="category">The id of the category to filter the services.</param>
        /// <returns></returns>
        void CompassserviceList (Guid? category);
        /// <summary>
        /// View all the locations where a service added to the compass is available 
        /// </summary>
        /// <param name="serviceid">The id of the service to get its locations.</param>
        /// <returns></returns>
        void CompassserviceListlocations (Guid? serviceid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CompassserviceApi : ICompassserviceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompassserviceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CompassserviceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompassserviceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompassserviceApi(String basePath)
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
        /// View all the services added to the compass 
        /// </summary>
        /// <param name="category">The id of the category to filter the services.</param> 
        /// <returns></returns>            
        public void CompassserviceList (Guid? category)
        {
            
    
            var path = "/compassservice/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CompassserviceList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CompassserviceList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the locations where a service added to the compass is available 
        /// </summary>
        /// <param name="serviceid">The id of the service to get its locations.</param> 
        /// <returns></returns>            
        public void CompassserviceListlocations (Guid? serviceid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling CompassserviceListlocations");
            
    
            var path = "/compassservice/listlocations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceid != null) queryParams.Add("serviceid", ApiClient.ParameterToString(serviceid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CompassserviceListlocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CompassserviceListlocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
