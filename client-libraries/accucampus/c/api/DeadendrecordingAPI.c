#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "DeadendrecordingAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Deletes a dead-end record group
//
// Allows the user to delete a dead end record group.
//
void
DeadendrecordingAPI_deadendrecordingDelete(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/deadendrecording/delete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/deadendrecording/delete");




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
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

// Lists the recorded dead ends, if enabled
//
// Allows the user to view the list of dead ends, provided dead end recording is enabled for the account.
//
void
DeadendrecordingAPI_deadendrecordingList(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/deadendrecording/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/deadendrecording/list");



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

// Lists the comments for a specific dead end
//
// Allows the user to view the comments made on dead end sessions.
//
void
DeadendrecordingAPI_deadendrecordingListcomments(apiClient_t *apiClient, char * hierarchykey )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/deadendrecording/listcomments")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/deadendrecording/listcomments");




    // query parameters
    char *keyQuery_hierarchykey = NULL;
    char * valueQuery_hierarchykey = NULL;
    keyValuePair_t *keyPairQuery_hierarchykey = 0;
    if (hierarchykey)
    {
        keyQuery_hierarchykey = strdup("hierarchykey");
        valueQuery_hierarchykey = strdup((hierarchykey));
        keyPairQuery_hierarchykey = keyValuePair_create(keyQuery_hierarchykey, valueQuery_hierarchykey);
        list_addElement(localVarQueryParameters,keyPairQuery_hierarchykey);
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
    if(keyQuery_hierarchykey){
        free(keyQuery_hierarchykey);
        keyQuery_hierarchykey = NULL;
    }
    if(valueQuery_hierarchykey){
        free(valueQuery_hierarchykey);
        valueQuery_hierarchykey = NULL;
    }
    if(keyPairQuery_hierarchykey){
        keyValuePair_free(keyPairQuery_hierarchykey);
        keyPairQuery_hierarchykey = NULL;
    }
    if(keyQuery_hierarchykey){
        free(keyQuery_hierarchykey);
        keyQuery_hierarchykey = NULL;
    }
    if(keyPairQuery_hierarchykey){
        keyValuePair_free(keyPairQuery_hierarchykey);
        keyPairQuery_hierarchykey = NULL;
    }

}

// Saves a dead-end record
//
void
DeadendrecordingAPI_deadendrecordingSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/deadendrecording/save")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/deadendrecording/save");




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

