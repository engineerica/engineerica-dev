#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "AppshareAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Gets the phone number of the current user
//
void
AppshareAPI_appshareGetphone(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appshare/getphone")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appshare/getphone");



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

// Sends an SMS with the link to the app
//
void
AppshareAPI_appshareSendtext(apiClient_t *apiClient, char * phonenumber )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/appshare/sendtext")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/appshare/sendtext");




    // query parameters
    char *keyQuery_phonenumber = NULL;
    char * valueQuery_phonenumber = NULL;
    keyValuePair_t *keyPairQuery_phonenumber = 0;
    if (phonenumber)
    {
        keyQuery_phonenumber = strdup("phonenumber");
        valueQuery_phonenumber = strdup((phonenumber));
        keyPairQuery_phonenumber = keyValuePair_create(keyQuery_phonenumber, valueQuery_phonenumber);
        list_addElement(localVarQueryParameters,keyPairQuery_phonenumber);
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
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(valueQuery_phonenumber){
        free(valueQuery_phonenumber);
        valueQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }
    if(keyQuery_phonenumber){
        free(keyQuery_phonenumber);
        keyQuery_phonenumber = NULL;
    }
    if(keyPairQuery_phonenumber){
        keyValuePair_free(keyPairQuery_phonenumber);
        keyPairQuery_phonenumber = NULL;
    }

}

