#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "AdvrolesAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// List users. Alias to user.list, use that one instead.
//
void
AdvrolesAPI_advrolesUserlist(apiClient_t *apiClient, int from , int count , char * roleid , char * onlywithoutcard , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/advroles/userlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/advroles/userlist");




    // query parameters
    char *keyQuery_from = NULL;
    int valueQuery_from ;
    keyValuePair_t *keyPairQuery_from = 0;
    if (from)
    {
        keyQuery_from = strdup("from");
        valueQuery_from = (from);
        keyPairQuery_from = keyValuePair_create(keyQuery_from, &valueQuery_from);
        list_addElement(localVarQueryParameters,keyPairQuery_from);
    }

    // query parameters
    char *keyQuery_count = NULL;
    int valueQuery_count ;
    keyValuePair_t *keyPairQuery_count = 0;
    if (count)
    {
        keyQuery_count = strdup("count");
        valueQuery_count = (count);
        keyPairQuery_count = keyValuePair_create(keyQuery_count, &valueQuery_count);
        list_addElement(localVarQueryParameters,keyPairQuery_count);
    }

    // query parameters
    char *keyQuery_roleid = NULL;
    char * valueQuery_roleid ;
    keyValuePair_t *keyPairQuery_roleid = 0;
    if (roleid)
    {
        keyQuery_roleid = strdup("roleid");
        valueQuery_roleid = (roleid);
        keyPairQuery_roleid = keyValuePair_create(keyQuery_roleid, &valueQuery_roleid);
        list_addElement(localVarQueryParameters,keyPairQuery_roleid);
    }

    // query parameters
    char *keyQuery_onlywithoutcard = NULL;
    char * valueQuery_onlywithoutcard = NULL;
    keyValuePair_t *keyPairQuery_onlywithoutcard = 0;
    if (onlywithoutcard)
    {
        keyQuery_onlywithoutcard = strdup("onlywithoutcard");
        valueQuery_onlywithoutcard = strdup((onlywithoutcard));
        keyPairQuery_onlywithoutcard = keyValuePair_create(keyQuery_onlywithoutcard, valueQuery_onlywithoutcard);
        list_addElement(localVarQueryParameters,keyPairQuery_onlywithoutcard);
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
    if(keyQuery_onlywithoutcard){
        free(keyQuery_onlywithoutcard);
        keyQuery_onlywithoutcard = NULL;
    }
    if(valueQuery_onlywithoutcard){
        free(valueQuery_onlywithoutcard);
        valueQuery_onlywithoutcard = NULL;
    }
    if(keyPairQuery_onlywithoutcard){
        keyValuePair_free(keyPairQuery_onlywithoutcard);
        keyPairQuery_onlywithoutcard = NULL;
    }
    if(keyQuery_onlywithoutcard){
        free(keyQuery_onlywithoutcard);
        keyQuery_onlywithoutcard = NULL;
    }
    if(keyPairQuery_onlywithoutcard){
        keyValuePair_free(keyPairQuery_onlywithoutcard);
        keyPairQuery_onlywithoutcard = NULL;
    }

}

