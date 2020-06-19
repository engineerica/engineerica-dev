#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "LicenseAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Accept the license agreement
//
void
LicenseAPI_licenseAcceptagreement(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/license/acceptagreement")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/license/acceptagreement");



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

// Check if license agreement has been accepted
//
void
LicenseAPI_licenseGetagreementstatus(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/license/getagreementstatus")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/license/getagreementstatus");



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

// Gets the current license information
//
void
LicenseAPI_licenseGetcurrent(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/license/getcurrent")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/license/getcurrent");



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

// Contact Engineerica in order to renew the AccuTraining subscription
//
// Allows the user to select the option to contact Engineerica when the AccuTraining account is nearing its renewal date.
//
void
LicenseAPI_licenseRenew(apiClient_t *apiClient, char * email , char * phonenumber , char * jobtitle , char * institution , char * comments )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/license/renew")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/license/renew");




    // query parameters
    char *keyQuery_email = NULL;
    char * valueQuery_email = NULL;
    keyValuePair_t *keyPairQuery_email = 0;
    if (email)
    {
        keyQuery_email = strdup("email");
        valueQuery_email = strdup((email));
        keyPairQuery_email = keyValuePair_create(keyQuery_email, valueQuery_email);
        list_addElement(localVarQueryParameters,keyPairQuery_email);
    }

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

    // query parameters
    char *keyQuery_jobtitle = NULL;
    char * valueQuery_jobtitle = NULL;
    keyValuePair_t *keyPairQuery_jobtitle = 0;
    if (jobtitle)
    {
        keyQuery_jobtitle = strdup("jobtitle");
        valueQuery_jobtitle = strdup((jobtitle));
        keyPairQuery_jobtitle = keyValuePair_create(keyQuery_jobtitle, valueQuery_jobtitle);
        list_addElement(localVarQueryParameters,keyPairQuery_jobtitle);
    }

    // query parameters
    char *keyQuery_institution = NULL;
    char * valueQuery_institution = NULL;
    keyValuePair_t *keyPairQuery_institution = 0;
    if (institution)
    {
        keyQuery_institution = strdup("institution");
        valueQuery_institution = strdup((institution));
        keyPairQuery_institution = keyValuePair_create(keyQuery_institution, valueQuery_institution);
        list_addElement(localVarQueryParameters,keyPairQuery_institution);
    }

    // query parameters
    char *keyQuery_comments = NULL;
    char * valueQuery_comments = NULL;
    keyValuePair_t *keyPairQuery_comments = 0;
    if (comments)
    {
        keyQuery_comments = strdup("comments");
        valueQuery_comments = strdup((comments));
        keyPairQuery_comments = keyValuePair_create(keyQuery_comments, valueQuery_comments);
        list_addElement(localVarQueryParameters,keyPairQuery_comments);
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
    if(keyQuery_email){
        free(keyQuery_email);
        keyQuery_email = NULL;
    }
    if(valueQuery_email){
        free(valueQuery_email);
        valueQuery_email = NULL;
    }
    if(keyPairQuery_email){
        keyValuePair_free(keyPairQuery_email);
        keyPairQuery_email = NULL;
    }
    if(keyQuery_email){
        free(keyQuery_email);
        keyQuery_email = NULL;
    }
    if(keyPairQuery_email){
        keyValuePair_free(keyPairQuery_email);
        keyPairQuery_email = NULL;
    }
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
    if(keyQuery_jobtitle){
        free(keyQuery_jobtitle);
        keyQuery_jobtitle = NULL;
    }
    if(valueQuery_jobtitle){
        free(valueQuery_jobtitle);
        valueQuery_jobtitle = NULL;
    }
    if(keyPairQuery_jobtitle){
        keyValuePair_free(keyPairQuery_jobtitle);
        keyPairQuery_jobtitle = NULL;
    }
    if(keyQuery_jobtitle){
        free(keyQuery_jobtitle);
        keyQuery_jobtitle = NULL;
    }
    if(keyPairQuery_jobtitle){
        keyValuePair_free(keyPairQuery_jobtitle);
        keyPairQuery_jobtitle = NULL;
    }
    if(keyQuery_institution){
        free(keyQuery_institution);
        keyQuery_institution = NULL;
    }
    if(valueQuery_institution){
        free(valueQuery_institution);
        valueQuery_institution = NULL;
    }
    if(keyPairQuery_institution){
        keyValuePair_free(keyPairQuery_institution);
        keyPairQuery_institution = NULL;
    }
    if(keyQuery_institution){
        free(keyQuery_institution);
        keyQuery_institution = NULL;
    }
    if(keyPairQuery_institution){
        keyValuePair_free(keyPairQuery_institution);
        keyPairQuery_institution = NULL;
    }
    if(keyQuery_comments){
        free(keyQuery_comments);
        keyQuery_comments = NULL;
    }
    if(valueQuery_comments){
        free(valueQuery_comments);
        valueQuery_comments = NULL;
    }
    if(keyPairQuery_comments){
        keyValuePair_free(keyPairQuery_comments);
        keyPairQuery_comments = NULL;
    }
    if(keyQuery_comments){
        free(keyQuery_comments);
        keyQuery_comments = NULL;
    }
    if(keyPairQuery_comments){
        keyValuePair_free(keyPairQuery_comments);
        keyPairQuery_comments = NULL;
    }

}

