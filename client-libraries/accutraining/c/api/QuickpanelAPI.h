#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Deletes a widget from the Quick Panel
//
// Allows the user to delete a widget that has been added to the Quick Panel.
//
void
QuickpanelAPI_quickpanelDeletewidget(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Fetches the information for a specific widget.
//
void
QuickpanelAPI_quickpanelFetchwidget(apiClient_t *apiClient, char * widgetid );


// View details of a widget included in the Quick Panel
//
// Allows the user to view a widget added in as Quick Panel.
//
void
QuickpanelAPI_quickpanelGetwidget(apiClient_t *apiClient, char * id );


// Returns the initial information required to show the quick panels
//
void
QuickpanelAPI_quickpanelInit(apiClient_t *apiClient);


// Lists all the widgets that are added in the Quick Panel
//
// Allows the user to view the widgets that have been added to the Quick Panel.
//
void
QuickpanelAPI_quickpanelListwidgets(apiClient_t *apiClient);


// Lists all the widget types available in the system
//
void
QuickpanelAPI_quickpanelListwidgettypes(apiClient_t *apiClient);


// Reorders the widgets and moves them to a specific column
//
void
QuickpanelAPI_quickpanelReorderwidgets(apiClient_t *apiClient, char * sectionname , char * orderids );


// Saves a widget for the Quick Panel
//
// Allows the user to save a widget to the Quick Panel.
//
void
QuickpanelAPI_quickpanelSavewidget(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


