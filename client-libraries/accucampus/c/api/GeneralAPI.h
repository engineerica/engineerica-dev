#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Get the application change log
//
void
GeneralAPI_changelog(apiClient_t *apiClient);


// Get the documentation
//
// Retrieves the list of actions available in the system.
//
void
GeneralAPI_doc(apiClient_t *apiClient, int excludeanonymous );


// Export AccuCampus data
//
// Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.
//
void
GeneralAPI_export(apiClient_t *apiClient, char * exporttype , char * exportformat , char * filters );


// Import data into AccuCampus
//
// Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.
//
void
GeneralAPI_import(apiClient_t *apiClient, char * importtype , char * upload , char * filename , char * parameters );


// Lists the available timezones
//
void
GeneralAPI_listtimezones(apiClient_t *apiClient);


// Login
//
void
GeneralAPI_login(apiClient_t *apiClient, char * domain , char * username , char * password , char * method , int rememberme );


// Logout
//
void
GeneralAPI_logout(apiClient_t *apiClient);


// Search
//
void
GeneralAPI_search(apiClient_t *apiClient, char * query , int page );


// Generates a dynamic image from text
//
void
GeneralAPI_texttoimage(apiClient_t *apiClient, char * text , char * fontcolor , int fontsize , char * direction , int width );


// Get current version information
//
void
GeneralAPI_version(apiClient_t *apiClient);


