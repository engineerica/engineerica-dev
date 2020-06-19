#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Change user's own password
//
// Allows the user to change their own password.
//
void
UserAPI_userChangepwd(apiClient_t *apiClient, char * oldpass , char * newpass );


// Changes the user password using a change password request id
//
void
UserAPI_userChangepwdbyreq(apiClient_t *apiClient, char * changereq , char * newpass );


// Delete a user
//
// Allows the user to delete a user.
//
void
UserAPI_userDelete(apiClient_t *apiClient, char * id ,  body );


// Finds similar users to prevent duplicates
//
// Allows the user to be warned if a user they are creating has the same card number as another user.
//
void
UserAPI_userFindsimilar(apiClient_t *apiClient, char * currentid , char * phonenumber , char * cardnumber );


// Search and view details of a user
//
// Allows the user to search and view a user and their details.
//
void
UserAPI_userGet(apiClient_t *apiClient, char * id , int photosize );


// Search user by card number
//
// Allows the user to search for a user by their card number.
//
void
UserAPI_userGetbycard(apiClient_t *apiClient, char * card , int photosize );


// View a list of users
//
// Allows the user to view the full list of users and is based on role permissions.
//
void
UserAPI_userList(apiClient_t *apiClient, int from , int count , char * roleid , char * onlywithoutcard , int photosize );


// Upload a photo for a specific user
//
// Allows the user to upload a photo for a user.
//
void
UserAPI_userLoadphoto(apiClient_t *apiClient, char * upload , char * filename , char * userid , int automatch );


// Move data between users
//
// Allows administrators to move data between users.
//
void
UserAPI_userMovedata(apiClient_t *apiClient, char * source , char * destination );


// Requests a password change
//
void
UserAPI_userRequestpwdchange(apiClient_t *apiClient, char * domain , char * email );


// Create or edit a user
//
// Allows the user to create or edit a user.
//
void
UserAPI_userSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Send email to the specified user(s) to set/change their passwords
//
// Allows the user to trigger an email to another user asking them to set or change their password.
//
void
UserAPI_userSavepwdchange(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


