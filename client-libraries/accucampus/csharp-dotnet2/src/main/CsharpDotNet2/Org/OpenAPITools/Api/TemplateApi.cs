using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITemplateApi
    {
        /// <summary>
        /// Add an image to a template Allows the user to add an image to a badge or certificate template.
        /// </summary>
        /// <param name="template">The id of the template where the image has to be added</param>
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
        /// <param name="filename">The local name of the uploaded file. For later reference.</param>
        /// <returns></returns>
        void TemplateAddimage (Guid? template, string upload, string filename);
        /// <summary>
        /// Delete a template Allows the user to delete an existing template.
        /// </summary>
        /// <param name="id">The id of the template to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void TemplateDelete (Guid? id, AnyType body);
        /// <summary>
        /// Send generated templates by email Allows the user to send generated templates via email through AccuCampus.
        /// </summary>
        /// <param name="jobid">The id of the job that is creating the templates.</param>
        /// <param name="emailsubject">Args depending on the send-to flag.</param>
        /// <param name="emailbody">Args depending on the send-to flag.</param>
        /// <param name="templatekind">The kind of the template you&#39;re sending. It must be included in (badge, certificate).</param>
        /// <param name="emailfrom">The name of the sender to be displayed in the receipients inbox</param>
        /// <param name="emailreplyto">The reply-to field for the emails.</param>
        /// <returns></returns>
        void TemplateEmail (string jobid, string emailsubject, string emailbody, string templatekind, string emailfrom, string emailreplyto);
        /// <summary>
        /// Generate specified templates Allows the user to generate an existing template as badges or certificates.
        /// </summary>
        /// <param name="template">The id of the template to generate.</param>
        /// <param name="source">The source key of the selected template data source.</param>
        /// <param name="singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param>
        /// <param name="userid">Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas.</param>
        /// <param name="forsending">It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading</param>
        /// <param name="role">When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor</param>
        /// <param name="filters">Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|...</param>
        /// <returns></returns>
        void TemplateGenerate (Guid? template, Guid? source, bool? singlefile, string userid, bool? forsending, Guid? role, string filters);
        /// <summary>
        /// View details of a template Allows the user to view a template and its details.
        /// </summary>
        /// <param name="id">The id of the template to get.</param>
        /// <returns></returns>
        void TemplateGet (Guid? id);
        /// <summary>
        /// View generated templates Allows the user to view templates which have been generated as badges or certificates.
        /// </summary>
        /// <param name="jobid">The id of the job that is creating the templates.</param>
        /// <returns></returns>
        void TemplateGetgenerated (string jobid);
        /// <summary>
        /// View a list of defined templates Allows the user to view the full list of created templates.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param>
        /// <param name="designedonly">If true then it only returns the templates that were designed. Otherwise, it returns all.</param>
        /// <returns></returns>
        void TemplateList (int? from, int? count, string kind, bool? designedonly);
        /// <summary>
        /// View a list of templates&#39; data sources Allows the user to see tokens to be used in the template
        /// </summary>
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param>
        /// <returns></returns>
        void TemplateListsources (string kind);
        /// <summary>
        /// Create or edit a template Allows the user to create or edit a template.
        /// </summary>
        /// <param name="id">The id of the template to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void TemplateSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Save the layout of a template Allows the user to edit a template&#39;s layout.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void TemplateSavelayout (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TemplateApi : ITemplateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TemplateApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TemplateApi(String basePath)
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
        /// Add an image to a template Allows the user to add an image to a badge or certificate template.
        /// </summary>
        /// <param name="template">The id of the template where the image has to be added</param> 
        /// <param name="upload">Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object).</param> 
        /// <param name="filename">The local name of the uploaded file. For later reference.</param> 
        /// <returns></returns>            
        public void TemplateAddimage (Guid? template, string upload, string filename)
        {
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling TemplateAddimage");
            
            // verify the required parameter 'upload' is set
            if (upload == null) throw new ApiException(400, "Missing required parameter 'upload' when calling TemplateAddimage");
            
    
            var path = "/template/addimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (template != null) queryParams.Add("template", ApiClient.ParameterToString(template)); // query parameter
 if (upload != null) queryParams.Add("upload", ApiClient.ParameterToString(upload)); // query parameter
 if (filename != null) queryParams.Add("filename", ApiClient.ParameterToString(filename)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateAddimage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateAddimage: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a template Allows the user to delete an existing template.
        /// </summary>
        /// <param name="id">The id of the template to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void TemplateDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TemplateDelete");
            
    
            var path = "/template/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send generated templates by email Allows the user to send generated templates via email through AccuCampus.
        /// </summary>
        /// <param name="jobid">The id of the job that is creating the templates.</param> 
        /// <param name="emailsubject">Args depending on the send-to flag.</param> 
        /// <param name="emailbody">Args depending on the send-to flag.</param> 
        /// <param name="templatekind">The kind of the template you&#39;re sending. It must be included in (badge, certificate).</param> 
        /// <param name="emailfrom">The name of the sender to be displayed in the receipients inbox</param> 
        /// <param name="emailreplyto">The reply-to field for the emails.</param> 
        /// <returns></returns>            
        public void TemplateEmail (string jobid, string emailsubject, string emailbody, string templatekind, string emailfrom, string emailreplyto)
        {
            
            // verify the required parameter 'jobid' is set
            if (jobid == null) throw new ApiException(400, "Missing required parameter 'jobid' when calling TemplateEmail");
            
            // verify the required parameter 'emailsubject' is set
            if (emailsubject == null) throw new ApiException(400, "Missing required parameter 'emailsubject' when calling TemplateEmail");
            
            // verify the required parameter 'emailbody' is set
            if (emailbody == null) throw new ApiException(400, "Missing required parameter 'emailbody' when calling TemplateEmail");
            
    
            var path = "/template/email";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (jobid != null) queryParams.Add("jobid", ApiClient.ParameterToString(jobid)); // query parameter
 if (templatekind != null) queryParams.Add("templatekind", ApiClient.ParameterToString(templatekind)); // query parameter
 if (emailfrom != null) queryParams.Add("emailfrom", ApiClient.ParameterToString(emailfrom)); // query parameter
 if (emailreplyto != null) queryParams.Add("emailreplyto", ApiClient.ParameterToString(emailreplyto)); // query parameter
 if (emailsubject != null) queryParams.Add("emailsubject", ApiClient.ParameterToString(emailsubject)); // query parameter
 if (emailbody != null) queryParams.Add("emailbody", ApiClient.ParameterToString(emailbody)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Generate specified templates Allows the user to generate an existing template as badges or certificates.
        /// </summary>
        /// <param name="template">The id of the template to generate.</param> 
        /// <param name="source">The source key of the selected template data source.</param> 
        /// <param name="singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param> 
        /// <param name="userid">Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas.</param> 
        /// <param name="forsending">It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading</param> 
        /// <param name="role">When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor</param> 
        /// <param name="filters">Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|...</param> 
        /// <returns></returns>            
        public void TemplateGenerate (Guid? template, Guid? source, bool? singlefile, string userid, bool? forsending, Guid? role, string filters)
        {
            
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling TemplateGenerate");
            
            // verify the required parameter 'source' is set
            if (source == null) throw new ApiException(400, "Missing required parameter 'source' when calling TemplateGenerate");
            
            // verify the required parameter 'singlefile' is set
            if (singlefile == null) throw new ApiException(400, "Missing required parameter 'singlefile' when calling TemplateGenerate");
            
    
            var path = "/template/generate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (template != null) queryParams.Add("template", ApiClient.ParameterToString(template)); // query parameter
 if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
 if (singlefile != null) queryParams.Add("singlefile", ApiClient.ParameterToString(singlefile)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (forsending != null) queryParams.Add("forsending", ApiClient.ParameterToString(forsending)); // query parameter
 if (role != null) queryParams.Add("role", ApiClient.ParameterToString(role)); // query parameter
 if (filters != null) queryParams.Add("filters", ApiClient.ParameterToString(filters)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateGenerate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateGenerate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a template Allows the user to view a template and its details.
        /// </summary>
        /// <param name="id">The id of the template to get.</param> 
        /// <returns></returns>            
        public void TemplateGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TemplateGet");
            
    
            var path = "/template/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View generated templates Allows the user to view templates which have been generated as badges or certificates.
        /// </summary>
        /// <param name="jobid">The id of the job that is creating the templates.</param> 
        /// <returns></returns>            
        public void TemplateGetgenerated (string jobid)
        {
            
            // verify the required parameter 'jobid' is set
            if (jobid == null) throw new ApiException(400, "Missing required parameter 'jobid' when calling TemplateGetgenerated");
            
    
            var path = "/template/getgenerated";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (jobid != null) queryParams.Add("jobid", ApiClient.ParameterToString(jobid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateGetgenerated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateGetgenerated: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of defined templates Allows the user to view the full list of created templates.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param> 
        /// <param name="designedonly">If true then it only returns the templates that were designed. Otherwise, it returns all.</param> 
        /// <returns></returns>            
        public void TemplateList (int? from, int? count, string kind, bool? designedonly)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling TemplateList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling TemplateList");
            
            // verify the required parameter 'kind' is set
            if (kind == null) throw new ApiException(400, "Missing required parameter 'kind' when calling TemplateList");
            
    
            var path = "/template/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
 if (designedonly != null) queryParams.Add("designedonly", ApiClient.ParameterToString(designedonly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of templates&#39; data sources Allows the user to see tokens to be used in the template
        /// </summary>
        /// <param name="kind">The kind of the templates to return. It must be included in (badge, certificate).</param> 
        /// <returns></returns>            
        public void TemplateListsources (string kind)
        {
            
            // verify the required parameter 'kind' is set
            if (kind == null) throw new ApiException(400, "Missing required parameter 'kind' when calling TemplateListsources");
            
    
            var path = "/template/listsources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateListsources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateListsources: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a template Allows the user to create or edit a template.
        /// </summary>
        /// <param name="id">The id of the template to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void TemplateSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TemplateSave");
            
    
            var path = "/template/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save the layout of a template Allows the user to edit a template&#39;s layout.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void TemplateSavelayout (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/template/savelayout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateSavelayout: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TemplateSavelayout: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
