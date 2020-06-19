using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeneralApi
    {
        /// <summary>
        /// Get the application change log 
        /// </summary>
        /// <returns></returns>
        void Changelog ();
        /// <summary>
        /// Get the documentation Retrieves the list of actions available in the system.
        /// </summary>
        /// <param name="excludeanonymous">If true it excludes the anonymous actions from the returned list.</param>
        /// <returns></returns>
        void Doc (bool? excludeanonymous);
        /// <summary>
        /// Export AccuCampus data Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.
        /// </summary>
        /// <param name="exporttype">What to export.</param>
        /// <param name="exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param>
        /// <param name="filters">Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|...</param>
        /// <returns></returns>
        void Export (string exporttype, string exportformat, string filters);
        /// <summary>
        /// Import data into AccuCampus Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.
        /// </summary>
        /// <param name="importtype">The kind of data that is being uploaded.</param>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The local name of the uploaded file. For later reference.</param>
        /// <param name="parameters">Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}.</param>
        /// <returns></returns>
        void Import (string importtype, string upload, string filename, string parameters);
        /// <summary>
        /// Lists the available timezones 
        /// </summary>
        /// <returns></returns>
        void Listtimezones ();
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="domain">The account domain to login.</param>
        /// <param name="username">The username (email) of the user to login as.</param>
        /// <param name="password">The password of the user to login as.</param>
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param>
        /// <param name="rememberme">If true then the session will not expire.</param>
        /// <returns></returns>
        void Login (string domain, string username, string password, string method, bool? rememberme);
        /// <summary>
        /// Logout 
        /// </summary>
        /// <returns></returns>
        void Logout ();
        /// <summary>
        /// Search 
        /// </summary>
        /// <param name="query">The query to search for.</param>
        /// <param name="page">Current page to show, zero-based.</param>
        /// <returns></returns>
        void Search (string query, int? page);
        /// <summary>
        /// Generates a dynamic image from text 
        /// </summary>
        /// <param name="text">The text to convert to an image, use double pipes (||) as a new line.</param>
        /// <param name="fontcolor">The color of the text, in hex format, without the #.</param>
        /// <param name="fontsize">The size of the text, in points.</param>
        /// <param name="direction">Either vertical or horizontal, default horizontal.</param>
        /// <param name="width">The image width in pixels (or height if the direction is vertical).</param>
        /// <returns></returns>
        void Texttoimage (string text, string fontcolor, int? fontsize, string direction, int? width);
        /// <summary>
        /// Get current version information 
        /// </summary>
        /// <returns></returns>
        void Version ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GeneralApi : IGeneralApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GeneralApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeneralApi(String basePath)
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
        /// Get the application change log 
        /// </summary>
        /// <returns></returns>            
        public void Changelog ()
        {
            
    
            var path = "/changelog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Changelog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Changelog: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the documentation Retrieves the list of actions available in the system.
        /// </summary>
        /// <param name="excludeanonymous">If true it excludes the anonymous actions from the returned list.</param> 
        /// <returns></returns>            
        public void Doc (bool? excludeanonymous)
        {
            
    
            var path = "/doc";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (excludeanonymous != null) queryParams.Add("excludeanonymous", ApiClient.ParameterToString(excludeanonymous)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Doc: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Doc: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Export AccuCampus data Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.
        /// </summary>
        /// <param name="exporttype">What to export.</param> 
        /// <param name="exportformat">The format of the resulting file. Valid types are CSV, HTML, XLS.</param> 
        /// <param name="filters">Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|...</param> 
        /// <returns></returns>            
        public void Export (string exporttype, string exportformat, string filters)
        {
            
            // verify the required parameter 'exporttype' is set
            if (exporttype == null) throw new ApiException(400, "Missing required parameter 'exporttype' when calling Export");
            
            // verify the required parameter 'exportformat' is set
            if (exportformat == null) throw new ApiException(400, "Missing required parameter 'exportformat' when calling Export");
            
    
            var path = "/export";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (exporttype != null) queryParams.Add("exporttype", ApiClient.ParameterToString(exporttype)); // query parameter
 if (exportformat != null) queryParams.Add("exportformat", ApiClient.ParameterToString(exportformat)); // query parameter
 if (filters != null) queryParams.Add("filters", ApiClient.ParameterToString(filters)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Export: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Export: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Import data into AccuCampus Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.
        /// </summary>
        /// <param name="importtype">The kind of data that is being uploaded.</param> 
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The local name of the uploaded file. For later reference.</param> 
        /// <param name="parameters">Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}.</param> 
        /// <returns></returns>            
        public void Import (string importtype, string upload, string filename, string parameters)
        {
            
            // verify the required parameter 'importtype' is set
            if (importtype == null) throw new ApiException(400, "Missing required parameter 'importtype' when calling Import");
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling Import");
            
    
            var path = "/import";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (importtype != null) queryParams.Add("importtype", ApiClient.ParameterToString(importtype)); // query parameter
 if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
 if (parameters != null) queryParams.Add("parameters", ApiClient.ParameterToString(parameters)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Import: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Import: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Lists the available timezones 
        /// </summary>
        /// <returns></returns>            
        public void Listtimezones ()
        {
            
    
            var path = "/listtimezones";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Listtimezones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Listtimezones: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="domain">The account domain to login.</param> 
        /// <param name="username">The username (email) of the user to login as.</param> 
        /// <param name="password">The password of the user to login as.</param> 
        /// <param name="method">The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;.</param> 
        /// <param name="rememberme">If true then the session will not expire.</param> 
        /// <returns></returns>            
        public void Login (string domain, string username, string password, string method, bool? rememberme)
        {
            
            // verify the required parameter 'domain' is set
            if (domain == null) throw new ApiException(400, "Missing required parameter 'domain' when calling Login");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling Login");
            
            // verify the required parameter 'password' is set
            if (password == null) throw new ApiException(400, "Missing required parameter 'password' when calling Login");
            
            // verify the required parameter 'method' is set
            if (method == null) throw new ApiException(400, "Missing required parameter 'method' when calling Login");
            
    
            var path = "/login";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (domain != null) queryParams.Add("domain", ApiClient.ParameterToString(domain)); // query parameter
 if (username != null) queryParams.Add("username", ApiClient.ParameterToString(username)); // query parameter
 if (password != null) queryParams.Add("password", ApiClient.ParameterToString(password)); // query parameter
 if (method != null) queryParams.Add("method", ApiClient.ParameterToString(method)); // query parameter
 if (rememberme != null) queryParams.Add("rememberme", ApiClient.ParameterToString(rememberme)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Logout 
        /// </summary>
        /// <returns></returns>            
        public void Logout ()
        {
            
    
            var path = "/logout";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Logout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Logout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search 
        /// </summary>
        /// <param name="query">The query to search for.</param> 
        /// <param name="page">Current page to show, zero-based.</param> 
        /// <returns></returns>            
        public void Search (string query, int? page)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling Search");
            
    
            var path = "/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Search: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Generates a dynamic image from text 
        /// </summary>
        /// <param name="text">The text to convert to an image, use double pipes (||) as a new line.</param> 
        /// <param name="fontcolor">The color of the text, in hex format, without the #.</param> 
        /// <param name="fontsize">The size of the text, in points.</param> 
        /// <param name="direction">Either vertical or horizontal, default horizontal.</param> 
        /// <param name="width">The image width in pixels (or height if the direction is vertical).</param> 
        /// <returns></returns>            
        public void Texttoimage (string text, string fontcolor, int? fontsize, string direction, int? width)
        {
            
            // verify the required parameter 'text' is set
            if (text == null) throw new ApiException(400, "Missing required parameter 'text' when calling Texttoimage");
            
    
            var path = "/texttoimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (text != null) queryParams.Add("text", ApiClient.ParameterToString(text)); // query parameter
 if (fontcolor != null) queryParams.Add("fontcolor", ApiClient.ParameterToString(fontcolor)); // query parameter
 if (fontsize != null) queryParams.Add("fontsize", ApiClient.ParameterToString(fontsize)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (width != null) queryParams.Add("width", ApiClient.ParameterToString(width)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Texttoimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Texttoimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get current version information 
        /// </summary>
        /// <returns></returns>            
        public void Version ()
        {
            
    
            var path = "/version";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Version: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Version: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
