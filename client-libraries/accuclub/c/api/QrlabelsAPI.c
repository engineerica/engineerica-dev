#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "QrlabelsAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Print and email QR labels
//
// Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
//
void
QrlabelsAPI_qrlabelsPrint(apiClient_t *apiClient, char * user , char * group )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/qrlabels/print")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/qrlabels/print");




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

    // query parameters
    char *keyQuery_group = NULL;
    char * valueQuery_group ;
    keyValuePair_t *keyPairQuery_group = 0;
    if (group)
    {
        keyQuery_group = strdup("group");
        valueQuery_group = (group);
        keyPairQuery_group = keyValuePair_create(keyQuery_group, &valueQuery_group);
        list_addElement(localVarQueryParameters,keyPairQuery_group);
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

