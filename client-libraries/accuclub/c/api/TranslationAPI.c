#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "TranslationAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Gets the translations of the specified values
//
void
TranslationAPI_translationGet(apiClient_t *apiClient, char * universal )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translation/get")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translation/get");




    // query parameters
    char *keyQuery_universal = NULL;
    char * valueQuery_universal = NULL;
    keyValuePair_t *keyPairQuery_universal = 0;
    if (universal)
    {
        keyQuery_universal = strdup("universal");
        valueQuery_universal = strdup((universal));
        keyPairQuery_universal = keyValuePair_create(keyQuery_universal, valueQuery_universal);
        list_addElement(localVarQueryParameters,keyPairQuery_universal);
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
    if(keyQuery_universal){
        free(keyQuery_universal);
        keyQuery_universal = NULL;
    }
    if(valueQuery_universal){
        free(valueQuery_universal);
        valueQuery_universal = NULL;
    }
    if(keyPairQuery_universal){
        keyValuePair_free(keyPairQuery_universal);
        keyPairQuery_universal = NULL;
    }
    if(keyQuery_universal){
        free(keyQuery_universal);
        keyQuery_universal = NULL;
    }
    if(keyPairQuery_universal){
        keyValuePair_free(keyPairQuery_universal);
        keyPairQuery_universal = NULL;
    }

}

// Get the file containing the translations
//
void
TranslationAPI_translationGetcachefile(apiClient_t *apiClient, char * account )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translation/getcachefile")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translation/getcachefile");




    // query parameters
    char *keyQuery_account = NULL;
    char * valueQuery_account = NULL;
    keyValuePair_t *keyPairQuery_account = 0;
    if (account)
    {
        keyQuery_account = strdup("account");
        valueQuery_account = strdup((account));
        keyPairQuery_account = keyValuePair_create(keyQuery_account, valueQuery_account);
        list_addElement(localVarQueryParameters,keyPairQuery_account);
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
    if(keyQuery_account){
        free(keyQuery_account);
        keyQuery_account = NULL;
    }
    if(valueQuery_account){
        free(valueQuery_account);
        valueQuery_account = NULL;
    }
    if(keyPairQuery_account){
        keyValuePair_free(keyPairQuery_account);
        keyPairQuery_account = NULL;
    }
    if(keyQuery_account){
        free(keyQuery_account);
        keyQuery_account = NULL;
    }
    if(keyPairQuery_account){
        keyValuePair_free(keyPairQuery_account);
        keyPairQuery_account = NULL;
    }

}

// Lists all the available translations in the system
//
void
TranslationAPI_translationList(apiClient_t *apiClient, char * filter , int nondefaultonly , int appdefaultasuniversal )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translation/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translation/list");




    // query parameters
    char *keyQuery_filter = NULL;
    char * valueQuery_filter = NULL;
    keyValuePair_t *keyPairQuery_filter = 0;
    if (filter)
    {
        keyQuery_filter = strdup("filter");
        valueQuery_filter = strdup((filter));
        keyPairQuery_filter = keyValuePair_create(keyQuery_filter, valueQuery_filter);
        list_addElement(localVarQueryParameters,keyPairQuery_filter);
    }

    // query parameters
    char *keyQuery_nondefaultonly = NULL;
    int valueQuery_nondefaultonly ;
    keyValuePair_t *keyPairQuery_nondefaultonly = 0;
    if (nondefaultonly)
    {
        keyQuery_nondefaultonly = strdup("nondefaultonly");
        valueQuery_nondefaultonly = (nondefaultonly);
        keyPairQuery_nondefaultonly = keyValuePair_create(keyQuery_nondefaultonly, &valueQuery_nondefaultonly);
        list_addElement(localVarQueryParameters,keyPairQuery_nondefaultonly);
    }

    // query parameters
    char *keyQuery_appdefaultasuniversal = NULL;
    int valueQuery_appdefaultasuniversal ;
    keyValuePair_t *keyPairQuery_appdefaultasuniversal = 0;
    if (appdefaultasuniversal)
    {
        keyQuery_appdefaultasuniversal = strdup("appdefaultasuniversal");
        valueQuery_appdefaultasuniversal = (appdefaultasuniversal);
        keyPairQuery_appdefaultasuniversal = keyValuePair_create(keyQuery_appdefaultasuniversal, &valueQuery_appdefaultasuniversal);
        list_addElement(localVarQueryParameters,keyPairQuery_appdefaultasuniversal);
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
    if(keyQuery_filter){
        free(keyQuery_filter);
        keyQuery_filter = NULL;
    }
    if(valueQuery_filter){
        free(valueQuery_filter);
        valueQuery_filter = NULL;
    }
    if(keyPairQuery_filter){
        keyValuePair_free(keyPairQuery_filter);
        keyPairQuery_filter = NULL;
    }
    if(keyQuery_filter){
        free(keyQuery_filter);
        keyQuery_filter = NULL;
    }
    if(keyPairQuery_filter){
        keyValuePair_free(keyPairQuery_filter);
        keyPairQuery_filter = NULL;
    }

}

// Edit a translation
//
// Allows the user to edit a translation for the entire account.
//
void
TranslationAPI_translationSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/translation/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/translation/{id}");


    // Path Params
    long sizeOfPathParams_id = strlen(id)+3 + strlen("{ id }");
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

