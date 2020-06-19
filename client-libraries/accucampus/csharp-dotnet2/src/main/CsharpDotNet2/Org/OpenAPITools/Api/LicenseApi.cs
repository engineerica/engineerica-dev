using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILicenseApi
    {
        /// <summary>
        /// Accept the license agreement 
        /// </summary>
        /// <returns></returns>
        void LicenseAcceptagreement ();
        /// <summary>
        /// Check if license agreement has been accepted 
        /// </summary>
        /// <returns></returns>
        void LicenseGetagreementstatus ();
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <returns></returns>
        void LicenseGetcurrent ();
        /// <summary>
        /// Contact Engineerica in order to renew the AccuCampus subscription Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.
        /// </summary>
        /// <param name="email">The e-mail of the user sending the request.</param>
        /// <param name="phonenumber">The phone number of the user sending the request.</param>
        /// <param name="jobtitle">The job title of the user sending the request.</param>
        /// <param name="institution">The institution of the user sending the request.</param>
        /// <param name="comments">Comments entered by the user sending the request.</param>
        /// <returns></returns>
        void LicenseRenew (string email, string phonenumber, string jobtitle, string institution, string comments);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LicenseApi : ILicenseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LicenseApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LicenseApi(String basePath)
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
        /// Accept the license agreement 
        /// </summary>
        /// <returns></returns>            
        public void LicenseAcceptagreement ()
        {
            
    
            var path = "/license/acceptagreement";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseAcceptagreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseAcceptagreement: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Check if license agreement has been accepted 
        /// </summary>
        /// <returns></returns>            
        public void LicenseGetagreementstatus ()
        {
            
    
            var path = "/license/getagreementstatus";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseGetagreementstatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseGetagreementstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the current license information 
        /// </summary>
        /// <returns></returns>            
        public void LicenseGetcurrent ()
        {
            
    
            var path = "/license/getcurrent";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseGetcurrent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseGetcurrent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Contact Engineerica in order to renew the AccuCampus subscription Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.
        /// </summary>
        /// <param name="email">The e-mail of the user sending the request.</param> 
        /// <param name="phonenumber">The phone number of the user sending the request.</param> 
        /// <param name="jobtitle">The job title of the user sending the request.</param> 
        /// <param name="institution">The institution of the user sending the request.</param> 
        /// <param name="comments">Comments entered by the user sending the request.</param> 
        /// <returns></returns>            
        public void LicenseRenew (string email, string phonenumber, string jobtitle, string institution, string comments)
        {
            
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling LicenseRenew");
            
            // verify the required parameter 'phonenumber' is set
            if (phonenumber == null) throw new ApiException(400, "Missing required parameter 'phonenumber' when calling LicenseRenew");
            
    
            var path = "/license/renew";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
 if (phonenumber != null) queryParams.Add("phonenumber", ApiClient.ParameterToString(phonenumber)); // query parameter
 if (jobtitle != null) queryParams.Add("jobtitle", ApiClient.ParameterToString(jobtitle)); // query parameter
 if (institution != null) queryParams.Add("institution", ApiClient.ParameterToString(institution)); // query parameter
 if (comments != null) queryParams.Add("comments", ApiClient.ParameterToString(comments)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseRenew: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LicenseRenew: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
