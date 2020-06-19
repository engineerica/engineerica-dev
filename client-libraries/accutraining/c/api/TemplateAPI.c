#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "TemplateAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Add an image to a template
//
// Allows the user to add an image to a badge or certificate template.
//
void
TemplateAPI_templateAddimage(apiClient_t *apiClient, char * template , char * upload , char * filename )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/addimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/addimage");




    // query parameters
    char *keyQuery_template = NULL;
    char * valueQuery_template ;
    keyValuePair_t *keyPairQuery_template = 0;
    if (template)
    {
        keyQuery_template = strdup("template");
        valueQuery_template = (template);
        keyPairQuery_template = keyValuePair_create(keyQuery_template, &valueQuery_template);
        list_addElement(localVarQueryParameters,keyPairQuery_template);
    }

    // query parameters
    char *keyQuery_upload = NULL;
    char * valueQuery_upload = NULL;
    keyValuePair_t *keyPairQuery_upload = 0;
    if (upload)
    {
        keyQuery_upload = strdup("upload");
        valueQuery_upload = strdup((upload));
        keyPairQuery_upload = keyValuePair_create(keyQuery_upload, valueQuery_upload);
        list_addElement(localVarQueryParameters,keyPairQuery_upload);
    }

    // query parameters
    char *keyQuery_filename = NULL;
    char * valueQuery_filename = NULL;
    keyValuePair_t *keyPairQuery_filename = 0;
    if (filename)
    {
        keyQuery_filename = strdup("filename");
        valueQuery_filename = strdup((filename));
        keyPairQuery_filename = keyValuePair_create(keyQuery_filename, valueQuery_filename);
        list_addElement(localVarQueryParameters,keyPairQuery_filename);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(valueQuery_upload){
        free(valueQuery_upload);
        valueQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_upload){
        free(keyQuery_upload);
        keyQuery_upload = NULL;
    }
    if(keyPairQuery_upload){
        keyValuePair_free(keyPairQuery_upload);
        keyPairQuery_upload = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(valueQuery_filename){
        free(valueQuery_filename);
        valueQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }
    if(keyQuery_filename){
        free(keyQuery_filename);
        keyQuery_filename = NULL;
    }
    if(keyPairQuery_filename){
        keyValuePair_free(keyPairQuery_filename);
        keyPairQuery_filename = NULL;
    }

}

// Delete a template
//
// Allows the user to delete an existing template.
//
void
TemplateAPI_templateDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // Body Param
    cJSON *localVarSingleItemJSON_body;
    if (body != NULL)
    {
        //string
        localVarSingleItemJSON_body = any_type_convertToJSON(body);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_body);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "DELETE");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_body);
    free(localVarBodyParameters);

}

// Send generated templates by email
//
// Allows the user to send generated templates via email through AccuTraining.
//
void
TemplateAPI_templateEmail(apiClient_t *apiClient, char * jobid , char * emailsubject , char * emailbody , char * templatekind , char * emailfrom , char * emailreplyto )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/email")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/email");




    // query parameters
    char *keyQuery_jobid = NULL;
    char * valueQuery_jobid = NULL;
    keyValuePair_t *keyPairQuery_jobid = 0;
    if (jobid)
    {
        keyQuery_jobid = strdup("jobid");
        valueQuery_jobid = strdup((jobid));
        keyPairQuery_jobid = keyValuePair_create(keyQuery_jobid, valueQuery_jobid);
        list_addElement(localVarQueryParameters,keyPairQuery_jobid);
    }

    // query parameters
    char *keyQuery_templatekind = NULL;
    char * valueQuery_templatekind = NULL;
    keyValuePair_t *keyPairQuery_templatekind = 0;
    if (templatekind)
    {
        keyQuery_templatekind = strdup("templatekind");
        valueQuery_templatekind = strdup((templatekind));
        keyPairQuery_templatekind = keyValuePair_create(keyQuery_templatekind, valueQuery_templatekind);
        list_addElement(localVarQueryParameters,keyPairQuery_templatekind);
    }

    // query parameters
    char *keyQuery_emailfrom = NULL;
    char * valueQuery_emailfrom = NULL;
    keyValuePair_t *keyPairQuery_emailfrom = 0;
    if (emailfrom)
    {
        keyQuery_emailfrom = strdup("emailfrom");
        valueQuery_emailfrom = strdup((emailfrom));
        keyPairQuery_emailfrom = keyValuePair_create(keyQuery_emailfrom, valueQuery_emailfrom);
        list_addElement(localVarQueryParameters,keyPairQuery_emailfrom);
    }

    // query parameters
    char *keyQuery_emailreplyto = NULL;
    char * valueQuery_emailreplyto = NULL;
    keyValuePair_t *keyPairQuery_emailreplyto = 0;
    if (emailreplyto)
    {
        keyQuery_emailreplyto = strdup("emailreplyto");
        valueQuery_emailreplyto = strdup((emailreplyto));
        keyPairQuery_emailreplyto = keyValuePair_create(keyQuery_emailreplyto, valueQuery_emailreplyto);
        list_addElement(localVarQueryParameters,keyPairQuery_emailreplyto);
    }

    // query parameters
    char *keyQuery_emailsubject = NULL;
    char * valueQuery_emailsubject = NULL;
    keyValuePair_t *keyPairQuery_emailsubject = 0;
    if (emailsubject)
    {
        keyQuery_emailsubject = strdup("emailsubject");
        valueQuery_emailsubject = strdup((emailsubject));
        keyPairQuery_emailsubject = keyValuePair_create(keyQuery_emailsubject, valueQuery_emailsubject);
        list_addElement(localVarQueryParameters,keyPairQuery_emailsubject);
    }

    // query parameters
    char *keyQuery_emailbody = NULL;
    char * valueQuery_emailbody = NULL;
    keyValuePair_t *keyPairQuery_emailbody = 0;
    if (emailbody)
    {
        keyQuery_emailbody = strdup("emailbody");
        valueQuery_emailbody = strdup((emailbody));
        keyPairQuery_emailbody = keyValuePair_create(keyQuery_emailbody, valueQuery_emailbody);
        list_addElement(localVarQueryParameters,keyPairQuery_emailbody);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(valueQuery_jobid){
        free(valueQuery_jobid);
        valueQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }
    if(keyQuery_templatekind){
        free(keyQuery_templatekind);
        keyQuery_templatekind = NULL;
    }
    if(valueQuery_templatekind){
        free(valueQuery_templatekind);
        valueQuery_templatekind = NULL;
    }
    if(keyPairQuery_templatekind){
        keyValuePair_free(keyPairQuery_templatekind);
        keyPairQuery_templatekind = NULL;
    }
    if(keyQuery_templatekind){
        free(keyQuery_templatekind);
        keyQuery_templatekind = NULL;
    }
    if(keyPairQuery_templatekind){
        keyValuePair_free(keyPairQuery_templatekind);
        keyPairQuery_templatekind = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(valueQuery_emailfrom){
        free(valueQuery_emailfrom);
        valueQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailreplyto){
        free(keyQuery_emailreplyto);
        keyQuery_emailreplyto = NULL;
    }
    if(valueQuery_emailreplyto){
        free(valueQuery_emailreplyto);
        valueQuery_emailreplyto = NULL;
    }
    if(keyPairQuery_emailreplyto){
        keyValuePair_free(keyPairQuery_emailreplyto);
        keyPairQuery_emailreplyto = NULL;
    }
    if(keyQuery_emailreplyto){
        free(keyQuery_emailreplyto);
        keyQuery_emailreplyto = NULL;
    }
    if(keyPairQuery_emailreplyto){
        keyValuePair_free(keyPairQuery_emailreplyto);
        keyPairQuery_emailreplyto = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(valueQuery_emailsubject){
        free(valueQuery_emailsubject);
        valueQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(valueQuery_emailbody){
        free(valueQuery_emailbody);
        valueQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }

}

// Generate specified templates
//
// Allows the user to generate an existing template as badges or certificates.
//
void
TemplateAPI_templateGenerate(apiClient_t *apiClient, char * template , char * source , int singlefile , char * userid , int forsending , char * role , char * filters )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/generate")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/generate");




    // query parameters
    char *keyQuery_template = NULL;
    char * valueQuery_template ;
    keyValuePair_t *keyPairQuery_template = 0;
    if (template)
    {
        keyQuery_template = strdup("template");
        valueQuery_template = (template);
        keyPairQuery_template = keyValuePair_create(keyQuery_template, &valueQuery_template);
        list_addElement(localVarQueryParameters,keyPairQuery_template);
    }

    // query parameters
    char *keyQuery_source = NULL;
    char * valueQuery_source ;
    keyValuePair_t *keyPairQuery_source = 0;
    if (source)
    {
        keyQuery_source = strdup("source");
        valueQuery_source = (source);
        keyPairQuery_source = keyValuePair_create(keyQuery_source, &valueQuery_source);
        list_addElement(localVarQueryParameters,keyPairQuery_source);
    }

    // query parameters
    char *keyQuery_singlefile = NULL;
    int valueQuery_singlefile ;
    keyValuePair_t *keyPairQuery_singlefile = 0;
    if (singlefile)
    {
        keyQuery_singlefile = strdup("singlefile");
        valueQuery_singlefile = (singlefile);
        keyPairQuery_singlefile = keyValuePair_create(keyQuery_singlefile, &valueQuery_singlefile);
        list_addElement(localVarQueryParameters,keyPairQuery_singlefile);
    }

    // query parameters
    char *keyQuery_userid = NULL;
    char * valueQuery_userid = NULL;
    keyValuePair_t *keyPairQuery_userid = 0;
    if (userid)
    {
        keyQuery_userid = strdup("userid");
        valueQuery_userid = strdup((userid));
        keyPairQuery_userid = keyValuePair_create(keyQuery_userid, valueQuery_userid);
        list_addElement(localVarQueryParameters,keyPairQuery_userid);
    }

    // query parameters
    char *keyQuery_forsending = NULL;
    int valueQuery_forsending ;
    keyValuePair_t *keyPairQuery_forsending = 0;
    if (forsending)
    {
        keyQuery_forsending = strdup("forsending");
        valueQuery_forsending = (forsending);
        keyPairQuery_forsending = keyValuePair_create(keyQuery_forsending, &valueQuery_forsending);
        list_addElement(localVarQueryParameters,keyPairQuery_forsending);
    }

    // query parameters
    char *keyQuery_role = NULL;
    char * valueQuery_role ;
    keyValuePair_t *keyPairQuery_role = 0;
    if (role)
    {
        keyQuery_role = strdup("role");
        valueQuery_role = (role);
        keyPairQuery_role = keyValuePair_create(keyQuery_role, &valueQuery_role);
        list_addElement(localVarQueryParameters,keyPairQuery_role);
    }

    // query parameters
    char *keyQuery_filters = NULL;
    char * valueQuery_filters = NULL;
    keyValuePair_t *keyPairQuery_filters = 0;
    if (filters)
    {
        keyQuery_filters = strdup("filters");
        valueQuery_filters = strdup((filters));
        keyPairQuery_filters = keyValuePair_create(keyQuery_filters, valueQuery_filters);
        list_addElement(localVarQueryParameters,keyPairQuery_filters);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_userid){
        free(keyQuery_userid);
        keyQuery_userid = NULL;
    }
    if(valueQuery_userid){
        free(valueQuery_userid);
        valueQuery_userid = NULL;
    }
    if(keyPairQuery_userid){
        keyValuePair_free(keyPairQuery_userid);
        keyPairQuery_userid = NULL;
    }
    if(keyQuery_userid){
        free(keyQuery_userid);
        keyQuery_userid = NULL;
    }
    if(keyPairQuery_userid){
        keyValuePair_free(keyPairQuery_userid);
        keyPairQuery_userid = NULL;
    }
    if(keyQuery_filters){
        free(keyQuery_filters);
        keyQuery_filters = NULL;
    }
    if(valueQuery_filters){
        free(valueQuery_filters);
        valueQuery_filters = NULL;
    }
    if(keyPairQuery_filters){
        keyValuePair_free(keyPairQuery_filters);
        keyPairQuery_filters = NULL;
    }
    if(keyQuery_filters){
        free(keyQuery_filters);
        keyQuery_filters = NULL;
    }
    if(keyPairQuery_filters){
        keyValuePair_free(keyPairQuery_filters);
        keyPairQuery_filters = NULL;
    }

}

// View details of a template
//
// Allows the user to view a template and its details.
//
void
TemplateAPI_templateGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);


    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    
    free(localVarPath);
    free(localVarToReplace_id);

}

// View generated templates
//
// Allows the user to view templates which have been generated as badges or certificates.
//
void
TemplateAPI_templateGetgenerated(apiClient_t *apiClient, char * jobid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/getgenerated")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/getgenerated");




    // query parameters
    char *keyQuery_jobid = NULL;
    char * valueQuery_jobid = NULL;
    keyValuePair_t *keyPairQuery_jobid = 0;
    if (jobid)
    {
        keyQuery_jobid = strdup("jobid");
        valueQuery_jobid = strdup((jobid));
        keyPairQuery_jobid = keyValuePair_create(keyQuery_jobid, valueQuery_jobid);
        list_addElement(localVarQueryParameters,keyPairQuery_jobid);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(valueQuery_jobid){
        free(valueQuery_jobid);
        valueQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }
    if(keyQuery_jobid){
        free(keyQuery_jobid);
        keyQuery_jobid = NULL;
    }
    if(keyPairQuery_jobid){
        keyValuePair_free(keyPairQuery_jobid);
        keyPairQuery_jobid = NULL;
    }

}

// View a list of defined templates
//
// Allows the user to view the full list of created templates.
//
void
TemplateAPI_templateList(apiClient_t *apiClient, int from , int count , char * kind , int designedonly )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/list");




    // query parameters
    char *keyQuery_from = NULL;
    int valueQuery_from ;
    keyValuePair_t *keyPairQuery_from = 0;
    if (from)
    {
        keyQuery_from = strdup("from");
        valueQuery_from = (from);
        keyPairQuery_from = keyValuePair_create(keyQuery_from, &valueQuery_from);
        list_addElement(localVarQueryParameters,keyPairQuery_from);
    }

    // query parameters
    char *keyQuery_count = NULL;
    int valueQuery_count ;
    keyValuePair_t *keyPairQuery_count = 0;
    if (count)
    {
        keyQuery_count = strdup("count");
        valueQuery_count = (count);
        keyPairQuery_count = keyValuePair_create(keyQuery_count, &valueQuery_count);
        list_addElement(localVarQueryParameters,keyPairQuery_count);
    }

    // query parameters
    char *keyQuery_kind = NULL;
    char * valueQuery_kind = NULL;
    keyValuePair_t *keyPairQuery_kind = 0;
    if (kind)
    {
        keyQuery_kind = strdup("kind");
        valueQuery_kind = strdup((kind));
        keyPairQuery_kind = keyValuePair_create(keyQuery_kind, valueQuery_kind);
        list_addElement(localVarQueryParameters,keyPairQuery_kind);
    }

    // query parameters
    char *keyQuery_designedonly = NULL;
    int valueQuery_designedonly ;
    keyValuePair_t *keyPairQuery_designedonly = 0;
    if (designedonly)
    {
        keyQuery_designedonly = strdup("designedonly");
        valueQuery_designedonly = (designedonly);
        keyPairQuery_designedonly = keyValuePair_create(keyQuery_designedonly, &valueQuery_designedonly);
        list_addElement(localVarQueryParameters,keyPairQuery_designedonly);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(valueQuery_kind){
        free(valueQuery_kind);
        valueQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }

}

// View a list of templates' data sources
//
// Allows the user to see tokens to be used in the template
//
void
TemplateAPI_templateListsources(apiClient_t *apiClient, char * kind )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/listsources")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/listsources");




    // query parameters
    char *keyQuery_kind = NULL;
    char * valueQuery_kind = NULL;
    keyValuePair_t *keyPairQuery_kind = 0;
    if (kind)
    {
        keyQuery_kind = strdup("kind");
        valueQuery_kind = strdup((kind));
        keyPairQuery_kind = keyValuePair_create(keyQuery_kind, valueQuery_kind);
        list_addElement(localVarQueryParameters,keyPairQuery_kind);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(valueQuery_kind){
        free(valueQuery_kind);
        valueQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }
    if(keyQuery_kind){
        free(keyQuery_kind);
        keyQuery_kind = NULL;
    }
    if(keyPairQuery_kind){
        keyValuePair_free(keyPairQuery_kind);
        keyPairQuery_kind = NULL;
    }

}

// Create or edit a template
//
// Allows the user to create or edit a template.
//
void
TemplateAPI_templateSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "POST");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

// Save the layout of a template
//
// Allows the user to edit a template's layout.
//
void
TemplateAPI_templateSavelayout(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/template/savelayout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/template/savelayout");




    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "POST");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

