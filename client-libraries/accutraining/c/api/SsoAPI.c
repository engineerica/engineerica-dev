#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "SsoAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Generate/reset single sign on access key.
//
// Allows the user to generate or reset the access key for single sign-on.
//
void
SsoAPI_ssoGeneratekey(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sso/generatekey")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sso/generatekey");



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

// View single sign on settings.
//
// Allows the user to view settings for single sign-on.
//
void
SsoAPI_ssoGetsettings(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sso/getsettings")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sso/getsettings");



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

// Issue single sign-on token
//
void
SsoAPI_ssoIssuetoken(apiClient_t *apiClient, char * key , char * username , int expires )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sso/issuetoken")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sso/issuetoken");




    // query parameters
    char *keyQuery_key = NULL;
    char * valueQuery_key = NULL;
    keyValuePair_t *keyPairQuery_key = 0;
    if (key)
    {
        keyQuery_key = strdup("key");
        valueQuery_key = strdup((key));
        keyPairQuery_key = keyValuePair_create(keyQuery_key, valueQuery_key);
        list_addElement(localVarQueryParameters,keyPairQuery_key);
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
    char *keyQuery_expires = NULL;
    int valueQuery_expires ;
    keyValuePair_t *keyPairQuery_expires = 0;
    if (expires)
    {
        keyQuery_expires = strdup("expires");
        valueQuery_expires = (expires);
        keyPairQuery_expires = keyValuePair_create(keyQuery_expires, &valueQuery_expires);
        list_addElement(localVarQueryParameters,keyPairQuery_expires);
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
    if(keyQuery_key){
        free(keyQuery_key);
        keyQuery_key = NULL;
    }
    if(valueQuery_key){
        free(valueQuery_key);
        valueQuery_key = NULL;
    }
    if(keyPairQuery_key){
        keyValuePair_free(keyPairQuery_key);
        keyPairQuery_key = NULL;
    }
    if(keyQuery_key){
        free(keyQuery_key);
        keyQuery_key = NULL;
    }
    if(keyPairQuery_key){
        keyValuePair_free(keyPairQuery_key);
        keyPairQuery_key = NULL;
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

}

// Edit single sign-on settings.
//
// Allows the user to edit settings for single sign-on.
//
void
SsoAPI_ssoSavesettings(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/sso/savesettings")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/sso/savesettings");




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

