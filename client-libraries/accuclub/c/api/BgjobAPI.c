#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "BgjobAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Get background job status
//
void
BgjobAPI_bgjobGetstatus(apiClient_t *apiClient, char * jobid , char * jobtype )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/bgjob/getstatus")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/bgjob/getstatus");




    // query parameters
    char *keyQuery_jobid = NULL;
    char * valueQuery_jobid ;
    keyValuePair_t *keyPairQuery_jobid = 0;
    if (jobid)
    {
        keyQuery_jobid = strdup("jobid");
        valueQuery_jobid = (jobid);
        keyPairQuery_jobid = keyValuePair_create(keyQuery_jobid, &valueQuery_jobid);
        list_addElement(localVarQueryParameters,keyPairQuery_jobid);
    }

    // query parameters
    char *keyQuery_jobtype = NULL;
    char * valueQuery_jobtype = NULL;
    keyValuePair_t *keyPairQuery_jobtype = 0;
    if (jobtype)
    {
        keyQuery_jobtype = strdup("jobtype");
        valueQuery_jobtype = strdup((jobtype));
        keyPairQuery_jobtype = keyValuePair_create(keyQuery_jobtype, valueQuery_jobtype);
        list_addElement(localVarQueryParameters,keyPairQuery_jobtype);
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
    if(keyQuery_jobtype){
        free(keyQuery_jobtype);
        keyQuery_jobtype = NULL;
    }
    if(valueQuery_jobtype){
        free(valueQuery_jobtype);
        valueQuery_jobtype = NULL;
    }
    if(keyPairQuery_jobtype){
        keyValuePair_free(keyPairQuery_jobtype);
        keyPairQuery_jobtype = NULL;
    }
    if(keyQuery_jobtype){
        free(keyQuery_jobtype);
        keyQuery_jobtype = NULL;
    }
    if(keyPairQuery_jobtype){
        keyValuePair_free(keyPairQuery_jobtype);
        keyPairQuery_jobtype = NULL;
    }

}

