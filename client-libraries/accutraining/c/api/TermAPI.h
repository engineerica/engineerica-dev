#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a term
//
// Allows the user to delete a term from the existing list.
//
void
TermAPI_termDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a term
//
// Allows the user to view a term and its details.
//
void
TermAPI_termGet(apiClient_t *apiClient, char * id );


// Search and view details of all terms
//
// Allows the user to view the full list of existing term.
//
void
TermAPI_termList(apiClient_t *apiClient, int from , int count , int notpast );


// Create and edit terms
//
// Allows the user to create and edit terms.
//
void
TermAPI_termSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


