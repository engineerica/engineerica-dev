#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "GeneralAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Get the application change log
//
void
GeneralAPI_changelog(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/changelog")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/changelog");



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

}

// Get the documentation
//
// Retrieves the list of actions available in the system.
//
void
GeneralAPI_doc(apiClient_t *apiClient, int excludeanonymous )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/doc")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/doc");




    // query parameters
    char *keyQuery_excludeanonymous = NULL;
    int valueQuery_excludeanonymous ;
    keyValuePair_t *keyPairQuery_excludeanonymous = 0;
    if (excludeanonymous)
    {
        keyQuery_excludeanonymous = strdup("excludeanonymous");
        valueQuery_excludeanonymous = (excludeanonymous);
        keyPairQuery_excludeanonymous = keyValuePair_create(keyQuery_excludeanonymous, &valueQuery_excludeanonymous);
        list_addElement(localVarQueryParameters,keyPairQuery_excludeanonymous);
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

}

// Export AccuClub data
//
// Allows the user to export data from AccuClub into a CSV, HTML, or Excel format.
//
void
GeneralAPI_export(apiClient_t *apiClient, char * exporttype , char * exportformat , char * filters )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/export")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/export");




    // query parameters
    char *keyQuery_exporttype = NULL;
    char * valueQuery_exporttype = NULL;
    keyValuePair_t *keyPairQuery_exporttype = 0;
    if (exporttype)
    {
        keyQuery_exporttype = strdup("exporttype");
        valueQuery_exporttype = strdup((exporttype));
        keyPairQuery_exporttype = keyValuePair_create(keyQuery_exporttype, valueQuery_exporttype);
        list_addElement(localVarQueryParameters,keyPairQuery_exporttype);
    }

    // query parameters
    char *keyQuery_exportformat = NULL;
    char * valueQuery_exportformat = NULL;
    keyValuePair_t *keyPairQuery_exportformat = 0;
    if (exportformat)
    {
        keyQuery_exportformat = strdup("exportformat");
        valueQuery_exportformat = strdup((exportformat));
        keyPairQuery_exportformat = keyValuePair_create(keyQuery_exportformat, valueQuery_exportformat);
        list_addElement(localVarQueryParameters,keyPairQuery_exportformat);
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
    if(keyQuery_exporttype){
        free(keyQuery_exporttype);
        keyQuery_exporttype = NULL;
    }
    if(valueQuery_exporttype){
        free(valueQuery_exporttype);
        valueQuery_exporttype = NULL;
    }
    if(keyPairQuery_exporttype){
        keyValuePair_free(keyPairQuery_exporttype);
        keyPairQuery_exporttype = NULL;
    }
    if(keyQuery_exporttype){
        free(keyQuery_exporttype);
        keyQuery_exporttype = NULL;
    }
    if(keyPairQuery_exporttype){
        keyValuePair_free(keyPairQuery_exporttype);
        keyPairQuery_exporttype = NULL;
    }
    if(keyQuery_exportformat){
        free(keyQuery_exportformat);
        keyQuery_exportformat = NULL;
    }
    if(valueQuery_exportformat){
        free(valueQuery_exportformat);
        valueQuery_exportformat = NULL;
    }
    if(keyPairQuery_exportformat){
        keyValuePair_free(keyPairQuery_exportformat);
        keyPairQuery_exportformat = NULL;
    }
    if(keyQuery_exportformat){
        free(keyQuery_exportformat);
        keyQuery_exportformat = NULL;
    }
    if(keyPairQuery_exportformat){
        keyValuePair_free(keyPairQuery_exportformat);
        keyPairQuery_exportformat = NULL;
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

// Import data into AccuClub
//
// Allows the user to import data into AccuClub via CSV or flat files either manually or automatically using the import utility.
//
void
GeneralAPI_import(apiClient_t *apiClient, char * importtype , char * upload , char * filename , char * parameters )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/import")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/import");




    // query parameters
    char *keyQuery_importtype = NULL;
    char * valueQuery_importtype = NULL;
    keyValuePair_t *keyPairQuery_importtype = 0;
    if (importtype)
    {
        keyQuery_importtype = strdup("importtype");
        valueQuery_importtype = strdup((importtype));
        keyPairQuery_importtype = keyValuePair_create(keyQuery_importtype, valueQuery_importtype);
        list_addElement(localVarQueryParameters,keyPairQuery_importtype);
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

    // query parameters
    char *keyQuery_parameters = NULL;
    char * valueQuery_parameters = NULL;
    keyValuePair_t *keyPairQuery_parameters = 0;
    if (parameters)
    {
        keyQuery_parameters = strdup("parameters");
        valueQuery_parameters = strdup((parameters));
        keyPairQuery_parameters = keyValuePair_create(keyQuery_parameters, valueQuery_parameters);
        list_addElement(localVarQueryParameters,keyPairQuery_parameters);
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
    if(keyQuery_importtype){
        free(keyQuery_importtype);
        keyQuery_importtype = NULL;
    }
    if(valueQuery_importtype){
        free(valueQuery_importtype);
        valueQuery_importtype = NULL;
    }
    if(keyPairQuery_importtype){
        keyValuePair_free(keyPairQuery_importtype);
        keyPairQuery_importtype = NULL;
    }
    if(keyQuery_importtype){
        free(keyQuery_importtype);
        keyQuery_importtype = NULL;
    }
    if(keyPairQuery_importtype){
        keyValuePair_free(keyPairQuery_importtype);
        keyPairQuery_importtype = NULL;
    }
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
    if(keyQuery_parameters){
        free(keyQuery_parameters);
        keyQuery_parameters = NULL;
    }
    if(valueQuery_parameters){
        free(valueQuery_parameters);
        valueQuery_parameters = NULL;
    }
    if(keyPairQuery_parameters){
        keyValuePair_free(keyPairQuery_parameters);
        keyPairQuery_parameters = NULL;
    }
    if(keyQuery_parameters){
        free(keyQuery_parameters);
        keyQuery_parameters = NULL;
    }
    if(keyPairQuery_parameters){
        keyValuePair_free(keyPairQuery_parameters);
        keyPairQuery_parameters = NULL;
    }

}

// Lists the available timezones
//
void
GeneralAPI_listtimezones(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/listtimezones")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/listtimezones");



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

}

// Login
//
void
GeneralAPI_login(apiClient_t *apiClient, char * domain , char * username , char * password , char * method , int rememberme )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/login")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/login");




    // query parameters
    char *keyQuery_domain = NULL;
    char * valueQuery_domain = NULL;
    keyValuePair_t *keyPairQuery_domain = 0;
    if (domain)
    {
        keyQuery_domain = strdup("domain");
        valueQuery_domain = strdup((domain));
        keyPairQuery_domain = keyValuePair_create(keyQuery_domain, valueQuery_domain);
        list_addElement(localVarQueryParameters,keyPairQuery_domain);
    }

    // query parameters
    char *keyQuery_username = NULL;
    char * valueQuery_username = NULL;
    keyValuePair_t *keyPairQuery_username = 0;
    if (username)
    {
        keyQuery_username = strdup("username");
        valueQuery_username = strdup((username));
        keyPairQuery_username = keyValuePair_create(keyQuery_username, valueQuery_username);
        list_addElement(localVarQueryParameters,keyPairQuery_username);
    }

    // query parameters
    char *keyQuery_password = NULL;
    char * valueQuery_password = NULL;
    keyValuePair_t *keyPairQuery_password = 0;
    if (password)
    {
        keyQuery_password = strdup("password");
        valueQuery_password = strdup((password));
        keyPairQuery_password = keyValuePair_create(keyQuery_password, valueQuery_password);
        list_addElement(localVarQueryParameters,keyPairQuery_password);
    }

    // query parameters
    char *keyQuery_method = NULL;
    char * valueQuery_method = NULL;
    keyValuePair_t *keyPairQuery_method = 0;
    if (method)
    {
        keyQuery_method = strdup("method");
        valueQuery_method = strdup((method));
        keyPairQuery_method = keyValuePair_create(keyQuery_method, valueQuery_method);
        list_addElement(localVarQueryParameters,keyPairQuery_method);
    }

    // query parameters
    char *keyQuery_rememberme = NULL;
    int valueQuery_rememberme ;
    keyValuePair_t *keyPairQuery_rememberme = 0;
    if (rememberme)
    {
        keyQuery_rememberme = strdup("rememberme");
        valueQuery_rememberme = (rememberme);
        keyPairQuery_rememberme = keyValuePair_create(keyQuery_rememberme, &valueQuery_rememberme);
        list_addElement(localVarQueryParameters,keyPairQuery_rememberme);
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
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(valueQuery_domain){
        free(valueQuery_domain);
        valueQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_username){
        free(keyQuery_username);
        keyQuery_username = NULL;
    }
    if(valueQuery_username){
        free(valueQuery_username);
        valueQuery_username = NULL;
    }
    if(keyPairQuery_username){
        keyValuePair_free(keyPairQuery_username);
        keyPairQuery_username = NULL;
    }
    if(keyQuery_username){
        free(keyQuery_username);
        keyQuery_username = NULL;
    }
    if(keyPairQuery_username){
        keyValuePair_free(keyPairQuery_username);
        keyPairQuery_username = NULL;
    }
    if(keyQuery_password){
        free(keyQuery_password);
        keyQuery_password = NULL;
    }
    if(valueQuery_password){
        free(valueQuery_password);
        valueQuery_password = NULL;
    }
    if(keyPairQuery_password){
        keyValuePair_free(keyPairQuery_password);
        keyPairQuery_password = NULL;
    }
    if(keyQuery_password){
        free(keyQuery_password);
        keyQuery_password = NULL;
    }
    if(keyPairQuery_password){
        keyValuePair_free(keyPairQuery_password);
        keyPairQuery_password = NULL;
    }
    if(keyQuery_method){
        free(keyQuery_method);
        keyQuery_method = NULL;
    }
    if(valueQuery_method){
        free(valueQuery_method);
        valueQuery_method = NULL;
    }
    if(keyPairQuery_method){
        keyValuePair_free(keyPairQuery_method);
        keyPairQuery_method = NULL;
    }
    if(keyQuery_method){
        free(keyQuery_method);
        keyQuery_method = NULL;
    }
    if(keyPairQuery_method){
        keyValuePair_free(keyPairQuery_method);
        keyPairQuery_method = NULL;
    }

}

// Logout
//
void
GeneralAPI_logout(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/logout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/logout");



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

}

// Search
//
void
GeneralAPI_search(apiClient_t *apiClient, char * query , int page )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/search")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/search");




    // query parameters
    char *keyQuery_query = NULL;
    char * valueQuery_query = NULL;
    keyValuePair_t *keyPairQuery_query = 0;
    if (query)
    {
        keyQuery_query = strdup("query");
        valueQuery_query = strdup((query));
        keyPairQuery_query = keyValuePair_create(keyQuery_query, valueQuery_query);
        list_addElement(localVarQueryParameters,keyPairQuery_query);
    }

    // query parameters
    char *keyQuery_page = NULL;
    int valueQuery_page ;
    keyValuePair_t *keyPairQuery_page = 0;
    if (page)
    {
        keyQuery_page = strdup("page");
        valueQuery_page = (page);
        keyPairQuery_page = keyValuePair_create(keyQuery_page, &valueQuery_page);
        list_addElement(localVarQueryParameters,keyPairQuery_page);
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
    if(keyQuery_query){
        free(keyQuery_query);
        keyQuery_query = NULL;
    }
    if(valueQuery_query){
        free(valueQuery_query);
        valueQuery_query = NULL;
    }
    if(keyPairQuery_query){
        keyValuePair_free(keyPairQuery_query);
        keyPairQuery_query = NULL;
    }
    if(keyQuery_query){
        free(keyQuery_query);
        keyQuery_query = NULL;
    }
    if(keyPairQuery_query){
        keyValuePair_free(keyPairQuery_query);
        keyPairQuery_query = NULL;
    }

}

// Generates a dynamic image from text
//
void
GeneralAPI_texttoimage(apiClient_t *apiClient, char * text , char * fontcolor , int fontsize , char * direction , int width )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/texttoimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/texttoimage");




    // query parameters
    char *keyQuery_text = NULL;
    char * valueQuery_text = NULL;
    keyValuePair_t *keyPairQuery_text = 0;
    if (text)
    {
        keyQuery_text = strdup("text");
        valueQuery_text = strdup((text));
        keyPairQuery_text = keyValuePair_create(keyQuery_text, valueQuery_text);
        list_addElement(localVarQueryParameters,keyPairQuery_text);
    }

    // query parameters
    char *keyQuery_fontcolor = NULL;
    char * valueQuery_fontcolor = NULL;
    keyValuePair_t *keyPairQuery_fontcolor = 0;
    if (fontcolor)
    {
        keyQuery_fontcolor = strdup("fontcolor");
        valueQuery_fontcolor = strdup((fontcolor));
        keyPairQuery_fontcolor = keyValuePair_create(keyQuery_fontcolor, valueQuery_fontcolor);
        list_addElement(localVarQueryParameters,keyPairQuery_fontcolor);
    }

    // query parameters
    char *keyQuery_fontsize = NULL;
    int valueQuery_fontsize ;
    keyValuePair_t *keyPairQuery_fontsize = 0;
    if (fontsize)
    {
        keyQuery_fontsize = strdup("fontsize");
        valueQuery_fontsize = (fontsize);
        keyPairQuery_fontsize = keyValuePair_create(keyQuery_fontsize, &valueQuery_fontsize);
        list_addElement(localVarQueryParameters,keyPairQuery_fontsize);
    }

    // query parameters
    char *keyQuery_direction = NULL;
    char * valueQuery_direction = NULL;
    keyValuePair_t *keyPairQuery_direction = 0;
    if (direction)
    {
        keyQuery_direction = strdup("direction");
        valueQuery_direction = strdup((direction));
        keyPairQuery_direction = keyValuePair_create(keyQuery_direction, valueQuery_direction);
        list_addElement(localVarQueryParameters,keyPairQuery_direction);
    }

    // query parameters
    char *keyQuery_width = NULL;
    int valueQuery_width ;
    keyValuePair_t *keyPairQuery_width = 0;
    if (width)
    {
        keyQuery_width = strdup("width");
        valueQuery_width = (width);
        keyPairQuery_width = keyValuePair_create(keyQuery_width, &valueQuery_width);
        list_addElement(localVarQueryParameters,keyPairQuery_width);
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
    if(keyQuery_text){
        free(keyQuery_text);
        keyQuery_text = NULL;
    }
    if(valueQuery_text){
        free(valueQuery_text);
        valueQuery_text = NULL;
    }
    if(keyPairQuery_text){
        keyValuePair_free(keyPairQuery_text);
        keyPairQuery_text = NULL;
    }
    if(keyQuery_text){
        free(keyQuery_text);
        keyQuery_text = NULL;
    }
    if(keyPairQuery_text){
        keyValuePair_free(keyPairQuery_text);
        keyPairQuery_text = NULL;
    }
    if(keyQuery_fontcolor){
        free(keyQuery_fontcolor);
        keyQuery_fontcolor = NULL;
    }
    if(valueQuery_fontcolor){
        free(valueQuery_fontcolor);
        valueQuery_fontcolor = NULL;
    }
    if(keyPairQuery_fontcolor){
        keyValuePair_free(keyPairQuery_fontcolor);
        keyPairQuery_fontcolor = NULL;
    }
    if(keyQuery_fontcolor){
        free(keyQuery_fontcolor);
        keyQuery_fontcolor = NULL;
    }
    if(keyPairQuery_fontcolor){
        keyValuePair_free(keyPairQuery_fontcolor);
        keyPairQuery_fontcolor = NULL;
    }
    if(keyQuery_direction){
        free(keyQuery_direction);
        keyQuery_direction = NULL;
    }
    if(valueQuery_direction){
        free(valueQuery_direction);
        valueQuery_direction = NULL;
    }
    if(keyPairQuery_direction){
        keyValuePair_free(keyPairQuery_direction);
        keyPairQuery_direction = NULL;
    }
    if(keyQuery_direction){
        free(keyQuery_direction);
        keyQuery_direction = NULL;
    }
    if(keyPairQuery_direction){
        keyValuePair_free(keyPairQuery_direction);
        keyPairQuery_direction = NULL;
    }

}

// Get current version information
//
void
GeneralAPI_version(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/version")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/version");



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

}

