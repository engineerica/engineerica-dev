#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "SettingAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Add a logo to the account
//
// Allows the user to add the logo for the account, which appears on all pages on the AccuClub browser version.
//
void
SettingAPI_settingAddlogo(apiClient_t *apiClient, char * upload , char * filename )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/setting/addlogo")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/setting/addlogo");




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

// Get settings for the account or the specified scope
//
void
SettingAPI_settingGet(apiClient_t *apiClient, char * keys , char * domain , char * scope )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/setting/get")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/setting/get");




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
    char *keyQuery_keys = NULL;
    char * valueQuery_keys = NULL;
    keyValuePair_t *keyPairQuery_keys = 0;
    if (keys)
    {
        keyQuery_keys = strdup("keys");
        valueQuery_keys = strdup((keys));
        keyPairQuery_keys = keyValuePair_create(keyQuery_keys, valueQuery_keys);
        list_addElement(localVarQueryParameters,keyPairQuery_keys);
    }

    // query parameters
    char *keyQuery_scope = NULL;
    char * valueQuery_scope = NULL;
    keyValuePair_t *keyPairQuery_scope = 0;
    if (scope)
    {
        keyQuery_scope = strdup("scope");
        valueQuery_scope = strdup((scope));
        keyPairQuery_scope = keyValuePair_create(keyQuery_scope, valueQuery_scope);
        list_addElement(localVarQueryParameters,keyPairQuery_scope);
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
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(valueQuery_keys){
        free(valueQuery_keys);
        valueQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }
    if(keyQuery_keys){
        free(keyQuery_keys);
        keyQuery_keys = NULL;
    }
    if(keyPairQuery_keys){
        keyValuePair_free(keyPairQuery_keys);
        keyPairQuery_keys = NULL;
    }
    if(keyQuery_scope){
        free(keyQuery_scope);
        keyQuery_scope = NULL;
    }
    if(valueQuery_scope){
        free(valueQuery_scope);
        valueQuery_scope = NULL;
    }
    if(keyPairQuery_scope){
        keyValuePair_free(keyPairQuery_scope);
        keyPairQuery_scope = NULL;
    }
    if(keyQuery_scope){
        free(keyQuery_scope);
        keyQuery_scope = NULL;
    }
    if(keyPairQuery_scope){
        keyValuePair_free(keyPairQuery_scope);
        keyPairQuery_scope = NULL;
    }

}

// Save settings for the account or the specified scope
//
// Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.
//
void
SettingAPI_settingSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/setting/save")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/setting/save");




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

// View general settings for the account
//
// Allows the user to view the settings' general section.
//
void
SettingAPI_settingViewgeneral(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/setting/viewgeneral")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/setting/viewgeneral");



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

