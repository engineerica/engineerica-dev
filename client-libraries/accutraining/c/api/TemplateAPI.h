#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Add an image to a template
//
// Allows the user to add an image to a badge or certificate template.
//
void
TemplateAPI_templateAddimage(apiClient_t *apiClient, char * template , char * upload , char * filename );


// Delete a template
//
// Allows the user to delete an existing template.
//
void
TemplateAPI_templateDelete(apiClient_t *apiClient, char * id ,  body );


// Send generated templates by email
//
// Allows the user to send generated templates via email through AccuTraining.
//
void
TemplateAPI_templateEmail(apiClient_t *apiClient, char * jobid , char * emailsubject , char * emailbody , char * templatekind , char * emailfrom , char * emailreplyto );


// Generate specified templates
//
// Allows the user to generate an existing template as badges or certificates.
//
void
TemplateAPI_templateGenerate(apiClient_t *apiClient, char * template , char * source , int singlefile , char * userid , int forsending , char * role , char * filters );


// View details of a template
//
// Allows the user to view a template and its details.
//
void
TemplateAPI_templateGet(apiClient_t *apiClient, char * id );


// View generated templates
//
// Allows the user to view templates which have been generated as badges or certificates.
//
void
TemplateAPI_templateGetgenerated(apiClient_t *apiClient, char * jobid );


// View a list of defined templates
//
// Allows the user to view the full list of created templates.
//
void
TemplateAPI_templateList(apiClient_t *apiClient, int from , int count , char * kind , int designedonly );


// View a list of templates' data sources
//
// Allows the user to see tokens to be used in the template
//
void
TemplateAPI_templateListsources(apiClient_t *apiClient, char * kind );


// Create or edit a template
//
// Allows the user to create or edit a template.
//
void
TemplateAPI_templateSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Save the layout of a template
//
// Allows the user to edit a template's layout.
//
void
TemplateAPI_templateSavelayout(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


