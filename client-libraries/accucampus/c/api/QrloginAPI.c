#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "QrloginAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Gets an image of a QR token
//
void
QrloginAPI_qrloginGet(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/qrlogin/get")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/qrlogin/get");



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
QrloginAPI_qrloginLogin(apiClient_t *apiClient, char * onetimetoken )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/qrlogin/login")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/qrlogin/login");




    // query parameters
    char *keyQuery_onetimetoken = NULL;
    char * valueQuery_onetimetoken = NULL;
    keyValuePair_t *keyPairQuery_onetimetoken = 0;
    if (onetimetoken)
    {
        keyQuery_onetimetoken = strdup("onetimetoken");
        valueQuery_onetimetoken = strdup((onetimetoken));
        keyPairQuery_onetimetoken = keyValuePair_create(keyQuery_onetimetoken, valueQuery_onetimetoken);
        list_addElement(localVarQueryParameters,keyPairQuery_onetimetoken);
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
    if(keyQuery_onetimetoken){
        free(keyQuery_onetimetoken);
        keyQuery_onetimetoken = NULL;
    }
    if(valueQuery_onetimetoken){
        free(valueQuery_onetimetoken);
        valueQuery_onetimetoken = NULL;
    }
    if(keyPairQuery_onetimetoken){
        keyValuePair_free(keyPairQuery_onetimetoken);
        keyPairQuery_onetimetoken = NULL;
    }
    if(keyQuery_onetimetoken){
        free(keyQuery_onetimetoken);
        keyQuery_onetimetoken = NULL;
    }
    if(keyPairQuery_onetimetoken){
        keyValuePair_free(keyPairQuery_onetimetoken);
        keyPairQuery_onetimetoken = NULL;
    }

}

