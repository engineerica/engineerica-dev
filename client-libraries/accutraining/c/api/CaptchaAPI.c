#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "CaptchaAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Gets a captcha challenge that the user must complete to do certain requests.
//
void
CaptchaAPI_captchaGetchallenge(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/captcha/getchallenge")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/captcha/getchallenge");



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

// Gets a captcha image that the user must complete to do certain requests.
//
void
CaptchaAPI_captchaGetimage(apiClient_t *apiClient, char * captchatoken )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/captcha/getimage")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/captcha/getimage");




    // query parameters
    char *keyQuery_captchatoken = NULL;
    char * valueQuery_captchatoken = NULL;
    keyValuePair_t *keyPairQuery_captchatoken = 0;
    if (captchatoken)
    {
        keyQuery_captchatoken = strdup("captchatoken");
        valueQuery_captchatoken = strdup((captchatoken));
        keyPairQuery_captchatoken = keyValuePair_create(keyQuery_captchatoken, valueQuery_captchatoken);
        list_addElement(localVarQueryParameters,keyPairQuery_captchatoken);
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
    if(keyQuery_captchatoken){
        free(keyQuery_captchatoken);
        keyQuery_captchatoken = NULL;
    }
    if(valueQuery_captchatoken){
        free(valueQuery_captchatoken);
        valueQuery_captchatoken = NULL;
    }
    if(keyPairQuery_captchatoken){
        keyValuePair_free(keyPairQuery_captchatoken);
        keyPairQuery_captchatoken = NULL;
    }
    if(keyQuery_captchatoken){
        free(keyQuery_captchatoken);
        keyQuery_captchatoken = NULL;
    }
    if(keyPairQuery_captchatoken){
        keyValuePair_free(keyPairQuery_captchatoken);
        keyPairQuery_captchatoken = NULL;
    }

}

