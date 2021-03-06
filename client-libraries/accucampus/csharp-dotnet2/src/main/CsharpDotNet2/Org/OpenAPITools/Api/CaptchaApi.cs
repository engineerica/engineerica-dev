using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICaptchaApi
    {
        /// <summary>
        /// Gets a captcha challenge that the user must complete to do certain requests. 
        /// </summary>
        /// <returns></returns>
        void CaptchaGetchallenge ();
        /// <summary>
        /// Gets a captcha image that the user must complete to do certain requests. 
        /// </summary>
        /// <param name="captchatoken">The captcha token or ID returned by the captcha.getchallenge action</param>
        /// <returns></returns>
        void CaptchaGetimage (string captchatoken);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CaptchaApi : ICaptchaApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptchaApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CaptchaApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptchaApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CaptchaApi(String basePath)
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
        /// Gets a captcha challenge that the user must complete to do certain requests. 
        /// </summary>
        /// <returns></returns>            
        public void CaptchaGetchallenge ()
        {
            
    
            var path = "/captcha/getchallenge";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CaptchaGetchallenge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CaptchaGetchallenge: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a captcha image that the user must complete to do certain requests. 
        /// </summary>
        /// <param name="captchatoken">The captcha token or ID returned by the captcha.getchallenge action</param> 
        /// <returns></returns>            
        public void CaptchaGetimage (string captchatoken)
        {
            
            // verify the required parameter 'captchatoken' is set
            if (captchatoken == null) throw new ApiException(400, "Missing required parameter 'captchatoken' when calling CaptchaGetimage");
            
    
            var path = "/captcha/getimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (captchatoken != null) queryParams.Add("captchatoken", ApiClient.ParameterToString(captchatoken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CaptchaGetimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CaptchaGetimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
