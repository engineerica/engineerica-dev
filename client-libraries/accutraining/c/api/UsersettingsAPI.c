#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "UsersettingsAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Lists available user settings
//
void
UsersettingsAPI_usersettingsGet(apiClient_t *apiClient, char * keys , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettings/get")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettings/get");




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
    char *keyQuery_user = NULL;
    char * valueQuery_user ;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = (user);
        keyPairQuery_user = keyValuePair_create(keyQuery_user, &valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
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

}

// Get multiple user settings
//
void
UsersettingsAPI_usersettingsGetmultiple(apiClient_t *apiClient, char * keys , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettings/getmultiple")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettings/getmultiple");




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
    char *keyQuery_user = NULL;
    char * valueQuery_user ;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = (user);
        keyPairQuery_user = keyValuePair_create(keyQuery_user, &valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
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

}

// Saves a user setting
//
void
UsersettingsAPI_usersettingsSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettings/save")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettings/save");




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

// Save multiple user settings at once
//
void
UsersettingsAPI_usersettingsSavemultiple(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/usersettings/savemultiple")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/usersettings/savemultiple");




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

