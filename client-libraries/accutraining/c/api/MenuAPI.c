#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "MenuAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Gets the items on the menu
//
void
MenuAPI_menuGetitems(apiClient_t *apiClient, char * menuid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/menu/getitems")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/menu/getitems");




    // query parameters
    char *keyQuery_menuid = NULL;
    char * valueQuery_menuid = NULL;
    keyValuePair_t *keyPairQuery_menuid = 0;
    if (menuid)
    {
        keyQuery_menuid = strdup("menuid");
        valueQuery_menuid = strdup((menuid));
        keyPairQuery_menuid = keyValuePair_create(keyQuery_menuid, valueQuery_menuid);
        list_addElement(localVarQueryParameters,keyPairQuery_menuid);
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
    if(keyQuery_menuid){
        free(keyQuery_menuid);
        keyQuery_menuid = NULL;
    }
    if(valueQuery_menuid){
        free(valueQuery_menuid);
        valueQuery_menuid = NULL;
    }
    if(keyPairQuery_menuid){
        keyValuePair_free(keyPairQuery_menuid);
        keyPairQuery_menuid = NULL;
    }
    if(keyQuery_menuid){
        free(keyQuery_menuid);
        keyQuery_menuid = NULL;
    }
    if(keyPairQuery_menuid){
        keyValuePair_free(keyPairQuery_menuid);
        keyPairQuery_menuid = NULL;
    }

}

