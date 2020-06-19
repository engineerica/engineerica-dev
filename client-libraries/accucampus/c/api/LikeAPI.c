#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "LikeAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Delete a like
//
void
LikeAPI_likeDelete(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/like/delete")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/like/delete");




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

// View all the likes associated to a target
//
void
LikeAPI_likeList(apiClient_t *apiClient, char * interactionid , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/like/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/like/list");




    // query parameters
    char *keyQuery_interactionid = NULL;
    char * valueQuery_interactionid ;
    keyValuePair_t *keyPairQuery_interactionid = 0;
    if (interactionid)
    {
        keyQuery_interactionid = strdup("interactionid");
        valueQuery_interactionid = (interactionid);
        keyPairQuery_interactionid = keyValuePair_create(keyQuery_interactionid, &valueQuery_interactionid);
        list_addElement(localVarQueryParameters,keyPairQuery_interactionid);
    }

    // query parameters
    char *keyQuery_photosize = NULL;
    int valueQuery_photosize ;
    keyValuePair_t *keyPairQuery_photosize = 0;
    if (photosize)
    {
        keyQuery_photosize = strdup("photosize");
        valueQuery_photosize = (photosize);
        keyPairQuery_photosize = keyValuePair_create(keyQuery_photosize, &valueQuery_photosize);
        list_addElement(localVarQueryParameters,keyPairQuery_photosize);
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

// Save a like
//
void
LikeAPI_likeSave(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/like/save")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/like/save");




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

