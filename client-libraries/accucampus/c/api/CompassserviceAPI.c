#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "CompassserviceAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// View all the services added to the compass
//
void
CompassserviceAPI_compassserviceList(apiClient_t *apiClient, char * category )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/compassservice/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/compassservice/list");




    // query parameters
    char *keyQuery_category = NULL;
    char * valueQuery_category ;
    keyValuePair_t *keyPairQuery_category = 0;
    if (category)
    {
        keyQuery_category = strdup("category");
        valueQuery_category = (category);
        keyPairQuery_category = keyValuePair_create(keyQuery_category, &valueQuery_category);
        list_addElement(localVarQueryParameters,keyPairQuery_category);
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

// View all the locations where a service added to the compass is available
//
void
CompassserviceAPI_compassserviceListlocations(apiClient_t *apiClient, char * serviceid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/compassservice/listlocations")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/compassservice/listlocations");




    // query parameters
    char *keyQuery_serviceid = NULL;
    char * valueQuery_serviceid ;
    keyValuePair_t *keyPairQuery_serviceid = 0;
    if (serviceid)
    {
        keyQuery_serviceid = strdup("serviceid");
        valueQuery_serviceid = (serviceid);
        keyPairQuery_serviceid = keyValuePair_create(keyQuery_serviceid, &valueQuery_serviceid);
        list_addElement(localVarQueryParameters,keyPairQuery_serviceid);
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

