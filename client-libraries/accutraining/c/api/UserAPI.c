#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "UserAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Change user's own password
//
// Allows the user to change their own password.
//
void
UserAPI_userChangepwd(apiClient_t *apiClient, char * oldpass , char * newpass )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/changepwd")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/changepwd");




    // query parameters
    char *keyQuery_oldpass = NULL;
    char * valueQuery_oldpass ;
    keyValuePair_t *keyPairQuery_oldpass = 0;
    if (oldpass)
    {
        keyQuery_oldpass = strdup("oldpass");
        valueQuery_oldpass = (oldpass);
        keyPairQuery_oldpass = keyValuePair_create(keyQuery_oldpass, &valueQuery_oldpass);
        list_addElement(localVarQueryParameters,keyPairQuery_oldpass);
    }

    // query parameters
    char *keyQuery_newpass = NULL;
    char * valueQuery_newpass ;
    keyValuePair_t *keyPairQuery_newpass = 0;
    if (newpass)
    {
        keyQuery_newpass = strdup("newpass");
        valueQuery_newpass = (newpass);
        keyPairQuery_newpass = keyValuePair_create(keyQuery_newpass, &valueQuery_newpass);
        list_addElement(localVarQueryParameters,keyPairQuery_newpass);
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

// Changes the user password using a change password request id
//
void
UserAPI_userChangepwdbyreq(apiClient_t *apiClient, char * changereq , char * newpass )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/changepwdbyreq")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/changepwdbyreq");




    // query parameters
    char *keyQuery_changereq = NULL;
    char * valueQuery_changereq = NULL;
    keyValuePair_t *keyPairQuery_changereq = 0;
    if (changereq)
    {
        keyQuery_changereq = strdup("changereq");
        valueQuery_changereq = strdup((changereq));
        keyPairQuery_changereq = keyValuePair_create(keyQuery_changereq, valueQuery_changereq);
        list_addElement(localVarQueryParameters,keyPairQuery_changereq);
    }

    // query parameters
    char *keyQuery_newpass = NULL;
    char * valueQuery_newpass = NULL;
    keyValuePair_t *keyPairQuery_newpass = 0;
    if (newpass)
    {
        keyQuery_newpass = strdup("newpass");
        valueQuery_newpass = strdup((newpass));
        keyPairQuery_newpass = keyValuePair_create(keyQuery_newpass, valueQuery_newpass);
        list_addElement(localVarQueryParameters,keyPairQuery_newpass);
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
    if(keyQuery_changereq){
        free(keyQuery_changereq);
        keyQuery_changereq = NULL;
    }
    if(valueQuery_changereq){
        free(valueQuery_changereq);
        valueQuery_changereq = NULL;
    }
    if(keyPairQuery_changereq){
        keyValuePair_free(keyPairQuery_changereq);
        keyPairQuery_changereq = NULL;
    }
    if(keyQuery_changereq){
        free(keyQuery_changereq);
        keyQuery_changereq = NULL;
    }
    if(keyPairQuery_changereq){
        keyValuePair_free(keyPairQuery_changereq);
        keyPairQuery_changereq = NULL;
    }
    if(keyQuery_newpass){
        free(keyQuery_newpass);
        keyQuery_newpass = NULL;
    }
    if(valueQuery_newpass){
        free(valueQuery_newpass);
        valueQuery_newpass = NULL;
    }
    if(keyPairQuery_newpass){
        keyValuePair_free(keyPairQuery_newpass);
        keyPairQuery_newpass = NULL;
    }
    if(keyQuery_newpass){
        free(keyQuery_newpass);
        keyQuery_newpass = NULL;
    }
    if(keyPairQuery_newpass){
        keyValuePair_free(keyPairQuery_newpass);
        keyPairQuery_newpass = NULL;
    }

}

// Delete a user
//
// Allows the user to delete a user.
//
void
UserAPI_userDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // Body Param
    cJSON *localVarSingleItemJSON_body;
    if (body != NULL)
    {
        //string
        localVarSingleItemJSON_body = any_type_convertToJSON(body);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_body);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "DELETE");

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
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_body);
    free(localVarBodyParameters);

}

// Finds similar users to prevent duplicates
//
// Allows the user to be warned if a user they are creating has the same card number as another user.
//
void
UserAPI_userFindsimilar(apiClient_t *apiClient, char * currentid , char * phonenumber , char * cardnumber )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/findsimilar")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/findsimilar");




    // query parameters
    char *keyQuery_currentid = NULL;
    char * valueQuery_currentid ;
    keyValuePair_t *keyPairQuery_currentid = 0;
    if (currentid)
    {
        keyQuery_currentid = strdup("currentid");
        valueQuery_currentid = (currentid);
        keyPairQuery_currentid = keyValuePair_create(keyQuery_currentid, &valueQuery_currentid);
        list_addElement(localVarQueryParameters,keyPairQuery_currentid);
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
    char *keyQuery_cardnumber = NULL;
    char * valueQuery_cardnumber = NULL;
    keyValuePair_t *keyPairQuery_cardnumber = 0;
    if (cardnumber)
    {
        keyQuery_cardnumber = strdup("cardnumber");
        valueQuery_cardnumber = strdup((cardnumber));
        keyPairQuery_cardnumber = keyValuePair_create(keyQuery_cardnumber, valueQuery_cardnumber);
        list_addElement(localVarQueryParameters,keyPairQuery_cardnumber);
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
    if(keyQuery_cardnumber){
        free(keyQuery_cardnumber);
        keyQuery_cardnumber = NULL;
    }
    if(valueQuery_cardnumber){
        free(valueQuery_cardnumber);
        valueQuery_cardnumber = NULL;
    }
    if(keyPairQuery_cardnumber){
        keyValuePair_free(keyPairQuery_cardnumber);
        keyPairQuery_cardnumber = NULL;
    }
    if(keyQuery_cardnumber){
        free(keyQuery_cardnumber);
        keyQuery_cardnumber = NULL;
    }
    if(keyPairQuery_cardnumber){
        keyValuePair_free(keyPairQuery_cardnumber);
        keyPairQuery_cardnumber = NULL;
    }

}

// Search and view details of a user
//
// Allows the user to search and view a user and their details.
//
void
UserAPI_userGet(apiClient_t *apiClient, char * id , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



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
    free(localVarToReplace_id);

}

// Search user by card number
//
// Allows the user to search for a user by their card number.
//
void
UserAPI_userGetbycard(apiClient_t *apiClient, char * card , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/getbycard")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/getbycard");




    // query parameters
    char *keyQuery_card = NULL;
    char * valueQuery_card = NULL;
    keyValuePair_t *keyPairQuery_card = 0;
    if (card)
    {
        keyQuery_card = strdup("card");
        valueQuery_card = strdup((card));
        keyPairQuery_card = keyValuePair_create(keyQuery_card, valueQuery_card);
        list_addElement(localVarQueryParameters,keyPairQuery_card);
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
    if(keyQuery_card){
        free(keyQuery_card);
        keyQuery_card = NULL;
    }
    if(valueQuery_card){
        free(valueQuery_card);
        valueQuery_card = NULL;
    }
    if(keyPairQuery_card){
        keyValuePair_free(keyPairQuery_card);
        keyPairQuery_card = NULL;
    }
    if(keyQuery_card){
        free(keyQuery_card);
        keyQuery_card = NULL;
    }
    if(keyPairQuery_card){
        keyValuePair_free(keyPairQuery_card);
        keyPairQuery_card = NULL;
    }

}

// View a list of users
//
// Allows the user to view the full list of users and is based on role permissions.
//
void
UserAPI_userList(apiClient_t *apiClient, int from , int count , char * roleid , char * onlywithoutcard , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/list");




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

// Upload a photo for a specific user
//
// Allows the user to upload a photo for a user.
//
void
UserAPI_userLoadphoto(apiClient_t *apiClient, char * upload , char * filename , char * userid , int automatch )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/loadphoto")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/loadphoto");




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

    // query parameters
    char *keyQuery_userid = NULL;
    char * valueQuery_userid ;
    keyValuePair_t *keyPairQuery_userid = 0;
    if (userid)
    {
        keyQuery_userid = strdup("userid");
        valueQuery_userid = (userid);
        keyPairQuery_userid = keyValuePair_create(keyQuery_userid, &valueQuery_userid);
        list_addElement(localVarQueryParameters,keyPairQuery_userid);
    }

    // query parameters
    char *keyQuery_automatch = NULL;
    int valueQuery_automatch ;
    keyValuePair_t *keyPairQuery_automatch = 0;
    if (automatch)
    {
        keyQuery_automatch = strdup("automatch");
        valueQuery_automatch = (automatch);
        keyPairQuery_automatch = keyValuePair_create(keyQuery_automatch, &valueQuery_automatch);
        list_addElement(localVarQueryParameters,keyPairQuery_automatch);
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

// Move data between users
//
// Allows administrators to move data between users.
//
void
UserAPI_userMovedata(apiClient_t *apiClient, char * source , char * destination )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/movedata")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/movedata");




    // query parameters
    char *keyQuery_source = NULL;
    char * valueQuery_source ;
    keyValuePair_t *keyPairQuery_source = 0;
    if (source)
    {
        keyQuery_source = strdup("source");
        valueQuery_source = (source);
        keyPairQuery_source = keyValuePair_create(keyQuery_source, &valueQuery_source);
        list_addElement(localVarQueryParameters,keyPairQuery_source);
    }

    // query parameters
    char *keyQuery_destination = NULL;
    char * valueQuery_destination ;
    keyValuePair_t *keyPairQuery_destination = 0;
    if (destination)
    {
        keyQuery_destination = strdup("destination");
        valueQuery_destination = (destination);
        keyPairQuery_destination = keyValuePair_create(keyQuery_destination, &valueQuery_destination);
        list_addElement(localVarQueryParameters,keyPairQuery_destination);
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

// Requests a password change
//
void
UserAPI_userRequestpwdchange(apiClient_t *apiClient, char * domain , char * email )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/requestpwdchange")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/requestpwdchange");




    // query parameters
    char *keyQuery_domain = NULL;
    char * valueQuery_domain = NULL;
    keyValuePair_t *keyPairQuery_domain = 0;
    if (domain)
    {
        keyQuery_domain = strdup("domain");
        valueQuery_domain = strdup((domain));
        keyPairQuery_domain = keyValuePair_create(keyQuery_domain, valueQuery_domain);
        list_addElement(localVarQueryParameters,keyPairQuery_domain);
    }

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
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(valueQuery_domain){
        free(valueQuery_domain);
        valueQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
    if(keyQuery_domain){
        free(keyQuery_domain);
        keyQuery_domain = NULL;
    }
    if(keyPairQuery_domain){
        keyValuePair_free(keyPairQuery_domain);
        keyPairQuery_domain = NULL;
    }
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

}

// Create or edit a user
//
// Allows the user to create or edit a user.
//
void
UserAPI_userSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "POST");

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
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

// Send email to the specified user(s) to set/change their passwords
//
// Allows the user to trigger an email to another user asking them to set or change their password.
//
void
UserAPI_userSavepwdchange(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/user/savepwdchange")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/user/savepwdchange");




    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "POST");

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
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

