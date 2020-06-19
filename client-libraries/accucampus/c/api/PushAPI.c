#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "PushAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Deregisters the current device to receive push notifications
//
void
PushAPI_pushDeregister(apiClient_t *apiClient, char * devicetoken , char * platform )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/push/deregister")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/push/deregister");




    // query parameters
    char *keyQuery_devicetoken = NULL;
    char * valueQuery_devicetoken = NULL;
    keyValuePair_t *keyPairQuery_devicetoken = 0;
    if (devicetoken)
    {
        keyQuery_devicetoken = strdup("devicetoken");
        valueQuery_devicetoken = strdup((devicetoken));
        keyPairQuery_devicetoken = keyValuePair_create(keyQuery_devicetoken, valueQuery_devicetoken);
        list_addElement(localVarQueryParameters,keyPairQuery_devicetoken);
    }

    // query parameters
    char *keyQuery_platform = NULL;
    char * valueQuery_platform = NULL;
    keyValuePair_t *keyPairQuery_platform = 0;
    if (platform)
    {
        keyQuery_platform = strdup("platform");
        valueQuery_platform = strdup((platform));
        keyPairQuery_platform = keyValuePair_create(keyQuery_platform, valueQuery_platform);
        list_addElement(localVarQueryParameters,keyPairQuery_platform);
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
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(valueQuery_devicetoken){
        free(valueQuery_devicetoken);
        valueQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(valueQuery_platform){
        free(valueQuery_platform);
        valueQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }

}

// Registers the current device to receive push notifications
//
void
PushAPI_pushRegister(apiClient_t *apiClient, char * devicetoken , char * platform )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/push/register")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/push/register");




    // query parameters
    char *keyQuery_devicetoken = NULL;
    char * valueQuery_devicetoken = NULL;
    keyValuePair_t *keyPairQuery_devicetoken = 0;
    if (devicetoken)
    {
        keyQuery_devicetoken = strdup("devicetoken");
        valueQuery_devicetoken = strdup((devicetoken));
        keyPairQuery_devicetoken = keyValuePair_create(keyQuery_devicetoken, valueQuery_devicetoken);
        list_addElement(localVarQueryParameters,keyPairQuery_devicetoken);
    }

    // query parameters
    char *keyQuery_platform = NULL;
    char * valueQuery_platform = NULL;
    keyValuePair_t *keyPairQuery_platform = 0;
    if (platform)
    {
        keyQuery_platform = strdup("platform");
        valueQuery_platform = strdup((platform));
        keyPairQuery_platform = keyValuePair_create(keyQuery_platform, valueQuery_platform);
        list_addElement(localVarQueryParameters,keyPairQuery_platform);
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
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(valueQuery_devicetoken){
        free(valueQuery_devicetoken);
        valueQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_devicetoken){
        free(keyQuery_devicetoken);
        keyQuery_devicetoken = NULL;
    }
    if(keyPairQuery_devicetoken){
        keyValuePair_free(keyPairQuery_devicetoken);
        keyPairQuery_devicetoken = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(valueQuery_platform){
        free(valueQuery_platform);
        valueQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }
    if(keyQuery_platform){
        free(keyQuery_platform);
        keyQuery_platform = NULL;
    }
    if(keyPairQuery_platform){
        keyValuePair_free(keyPairQuery_platform);
        keyPairQuery_platform = NULL;
    }

}

