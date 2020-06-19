#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a credit
//
// Allows the user to delete credits.
//
void
CreditAPI_creditDelete(apiClient_t *apiClient, char * id ,  body );


// Gets the valid discount methods.
//
void
CreditAPI_creditDiscountmethods(apiClient_t *apiClient);


// View details of assigned credit
//
// Allows the user to view an credit and its details.
//
void
CreditAPI_creditGet(apiClient_t *apiClient, char * id );


// Get the total amount of credits of the specified user
//
// Allows the user to view the total amount of credits of a specified user.
//
void
CreditAPI_creditGetuserbalance(apiClient_t *apiClient, char * user );


// View a list of credits for a specific user
//
// Allows the user to view the full list of credits for a user.
//
void
CreditAPI_creditList(apiClient_t *apiClient, char * user , int from , int count );


// Gets the credit usage details
//
void
CreditAPI_creditListdetails(apiClient_t *apiClient, char * credit , int from , int count );


// View the list of credits of the current user
//
// Allows the current user to view his full list of credits.
//
void
CreditAPI_creditListmine(apiClient_t *apiClient, int from , int count );


// Create or edit credit for a user
//
// Allows the user to create or edit credit for a user
//
void
CreditAPI_creditSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Create or edit credit details
//
void
CreditAPI_creditSavedetails(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


