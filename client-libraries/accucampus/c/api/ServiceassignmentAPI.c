#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "ServiceassignmentAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Enable a service in a specific location
//
// Allows the user to enable a service in a location to which they are scoped.
//
void
ServiceassignmentAPI_serviceassignmentAddservice(apiClient_t *apiClient, char * serviceid , char * locationid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/serviceassignment/addservice")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/serviceassignment/addservice");




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

    // query parameters
    char *keyQuery_locationid = NULL;
    char * valueQuery_locationid ;
    keyValuePair_t *keyPairQuery_locationid = 0;
    if (locationid)
    {
        keyQuery_locationid = strdup("locationid");
        valueQuery_locationid = (locationid);
        keyPairQuery_locationid = keyValuePair_create(keyQuery_locationid, &valueQuery_locationid);
        list_addElement(localVarQueryParameters,keyPairQuery_locationid);
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

// View a list of services enabled for a specific location
//
// Allows the user to view a list of services available in a location to which they are scoped.
//
void
ServiceassignmentAPI_serviceassignmentGetlocation(apiClient_t *apiClient, char * locationid , int includegloballyavailable , int namefilter , int count )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/serviceassignment/getlocation")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/serviceassignment/getlocation");




    // query parameters
    char *keyQuery_locationid = NULL;
    char * valueQuery_locationid ;
    keyValuePair_t *keyPairQuery_locationid = 0;
    if (locationid)
    {
        keyQuery_locationid = strdup("locationid");
        valueQuery_locationid = (locationid);
        keyPairQuery_locationid = keyValuePair_create(keyQuery_locationid, &valueQuery_locationid);
        list_addElement(localVarQueryParameters,keyPairQuery_locationid);
    }

    // query parameters
    char *keyQuery_includegloballyavailable = NULL;
    int valueQuery_includegloballyavailable ;
    keyValuePair_t *keyPairQuery_includegloballyavailable = 0;
    if (includegloballyavailable)
    {
        keyQuery_includegloballyavailable = strdup("includegloballyavailable");
        valueQuery_includegloballyavailable = (includegloballyavailable);
        keyPairQuery_includegloballyavailable = keyValuePair_create(keyQuery_includegloballyavailable, &valueQuery_includegloballyavailable);
        list_addElement(localVarQueryParameters,keyPairQuery_includegloballyavailable);
    }

    // query parameters
    char *keyQuery_namefilter = NULL;
    int valueQuery_namefilter ;
    keyValuePair_t *keyPairQuery_namefilter = 0;
    if (namefilter)
    {
        keyQuery_namefilter = strdup("namefilter");
        valueQuery_namefilter = (namefilter);
        keyPairQuery_namefilter = keyValuePair_create(keyQuery_namefilter, &valueQuery_namefilter);
        list_addElement(localVarQueryParameters,keyPairQuery_namefilter);
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

// View a list of locations where a service is available
//
// Allows the user to view a list of locations in which a service is available.
//
void
ServiceassignmentAPI_serviceassignmentGetservice(apiClient_t *apiClient, char * serviceid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/serviceassignment/getservice")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/serviceassignment/getservice");




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

// Remove a service from a location
//
// Allows the user to disable a service from a location to which they are scoped.
//
void
ServiceassignmentAPI_serviceassignmentRemoveservice(apiClient_t *apiClient, char * serviceid , char * locationid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/serviceassignment/removeservice")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/serviceassignment/removeservice");




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

    // query parameters
    char *keyQuery_locationid = NULL;
    char * valueQuery_locationid ;
    keyValuePair_t *keyPairQuery_locationid = 0;
    if (locationid)
    {
        keyQuery_locationid = strdup("locationid");
        valueQuery_locationid = (locationid);
        keyPairQuery_locationid = keyValuePair_create(keyQuery_locationid, &valueQuery_locationid);
        list_addElement(localVarQueryParameters,keyPairQuery_locationid);
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

