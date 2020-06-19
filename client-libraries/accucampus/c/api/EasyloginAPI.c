#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "EasyloginAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Adds background image for the login
//
// Allows the user to set the background image that all users will see when logging into an AccuCampus account not using SSO.
//
void
EasyloginAPI_easyloginAddbgimage(apiClient_t *apiClient, char * upload , char * filename )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/easylogin/addbgimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/easylogin/addbgimage");




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

