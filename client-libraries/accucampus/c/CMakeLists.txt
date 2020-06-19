cmake_minimum_required (VERSION 2.6)
project (CGenerator)

cmake_policy(SET CMP0063 NEW)

set(CMAKE_C_VISIBILITY_PRESET default)
set(CMAKE_CXX_VISIBILITY_PRESET default)
set(CMAKE_VISIBILITY_INLINES_HIDDEN OFF)
set(CMAKE_BUILD_TYPE Debug)

find_package(OpenSSL)

if (OPENSSL_FOUND)
	message (STATUS "OPENSSL found")
	set (CMAKE_C_FLAGS "-DOPENSSL")
	include_directories(${OPENSSL_INCLUDE_DIR})
	include_directories(${OPENSSL_INCLUDE_DIRS})
	link_directories(${OPENSSL_LIBRARIES})
	message(STATUS "Using OpenSSL ${OPENSSL_VERSION}")
else() 
	message (STATUS "OpenSSL Not found.")
endif()

set(pkgName "accucampus_openapi_3")

find_package(CURL 7.58.0 REQUIRED)
if(CURL_FOUND)
	include_directories(${CURL_INCLUDE_DIR})
	set(PLATFORM_LIBRARIES ${PLATFORM_LIBRARIES} ${CURL_LIBRARIES} )
else(CURL_FOUND)
	message(FATAL_ERROR "Could not find the CURL library and development files.")
endif()

set(SRCS
    src/list.c
    src/apiKey.c
    src/apiClient.c
    src/binary.c
    external/cJSON.c
    model/object.c
    model/action_result.c
    model/error_action_result.c
    api/ActionassignmentAPI.c
    api/ActionitemAPI.c
    api/ActionlogAPI.c
    api/ActionpackAPI.c
    api/ActiontypeAPI.c
    api/AdhocqueryAPI.c
    api/AdhocreportsAPI.c
    api/AdvancedstationAPI.c
    api/AdvroleAPI.c
    api/AdvrolesAPI.c
    api/AppointmentAPI.c
    api/AppshareAPI.c
    api/AttendancelogAPI.c
    api/AttendancelogcommentAPI.c
    api/AttendancerestrictionAPI.c
    api/BeaconAPI.c
    api/BgjobAPI.c
    api/CaptchaAPI.c
    api/ClientAPI.c
    api/CommunityAPI.c
    api/CompasscategoryAPI.c
    api/CompassserviceAPI.c
    api/ComputerlabAPI.c
    api/DeadendrecordingAPI.c
    api/DepartmentAPI.c
    api/EasyloginAPI.c
    api/EventAPI.c
    api/EventregAPI.c
    api/ExportAPI.c
    api/FeatureAPI.c
    api/GeneralAPI.c
    api/HolidayAPI.c
    api/ImportAPI.c
    api/InteractionAPI.c
    api/LicenseAPI.c
    api/LikeAPI.c
    api/LocationAPI.c
    api/MediaAPI.c
    api/MediatypeAPI.c
    api/MemorizedreportAPI.c
    api/MenuAPI.c
    api/MyAPI.c
    api/NotificationAPI.c
    api/NotificationtopicAPI.c
    api/PushAPI.c
    api/QrlabelsAPI.c
    api/QrloginAPI.c
    api/QuickpanelAPI.c
    api/RatingAPI.c
    api/ReportAPI.c
    api/ReportscheduleAPI.c
    api/RiskmodelAPI.c
    api/RoleAPI.c
    api/RuleAPI.c
    api/ScheduleAPI.c
    api/ScheduleintegrationAPI.c
    api/SearchAPI.c
    api/SecurityAPI.c
    api/SeminarAPI.c
    api/ServiceAPI.c
    api/ServiceassignmentAPI.c
    api/SessionAPI.c
    api/SessionattendancelogAPI.c
    api/SessionregAPI.c
    api/SessionswipeAPI.c
    api/SettingAPI.c
    api/SocialAPI.c
    api/SocialgroupAPI.c
    api/SsoAPI.c
    api/StaffavailAPI.c
    api/StationAPI.c
    api/SwipeAPI.c
    api/TagAPI.c
    api/TemplateAPI.c
    api/TermAPI.c
    api/TextcreditAPI.c
    api/TranslationAPI.c
    api/UserAPI.c
    api/UsergroupAPI.c
    api/UserprofileAPI.c
    api/UsersettingsAPI.c
    api/VirtuallineAPI.c
    api/WaitinglineAPI.c

)

set(HDRS
    include/apiClient.h
    include/list.h
    include/binary.h
    include/keyValuePair.h
    external/cJSON.h
    model/object.h
    model/action_result.h
    model/error_action_result.h
    api/ActionassignmentAPI.h
    api/ActionitemAPI.h
    api/ActionlogAPI.h
    api/ActionpackAPI.h
    api/ActiontypeAPI.h
    api/AdhocqueryAPI.h
    api/AdhocreportsAPI.h
    api/AdvancedstationAPI.h
    api/AdvroleAPI.h
    api/AdvrolesAPI.h
    api/AppointmentAPI.h
    api/AppshareAPI.h
    api/AttendancelogAPI.h
    api/AttendancelogcommentAPI.h
    api/AttendancerestrictionAPI.h
    api/BeaconAPI.h
    api/BgjobAPI.h
    api/CaptchaAPI.h
    api/ClientAPI.h
    api/CommunityAPI.h
    api/CompasscategoryAPI.h
    api/CompassserviceAPI.h
    api/ComputerlabAPI.h
    api/DeadendrecordingAPI.h
    api/DepartmentAPI.h
    api/EasyloginAPI.h
    api/EventAPI.h
    api/EventregAPI.h
    api/ExportAPI.h
    api/FeatureAPI.h
    api/GeneralAPI.h
    api/HolidayAPI.h
    api/ImportAPI.h
    api/InteractionAPI.h
    api/LicenseAPI.h
    api/LikeAPI.h
    api/LocationAPI.h
    api/MediaAPI.h
    api/MediatypeAPI.h
    api/MemorizedreportAPI.h
    api/MenuAPI.h
    api/MyAPI.h
    api/NotificationAPI.h
    api/NotificationtopicAPI.h
    api/PushAPI.h
    api/QrlabelsAPI.h
    api/QrloginAPI.h
    api/QuickpanelAPI.h
    api/RatingAPI.h
    api/ReportAPI.h
    api/ReportscheduleAPI.h
    api/RiskmodelAPI.h
    api/RoleAPI.h
    api/RuleAPI.h
    api/ScheduleAPI.h
    api/ScheduleintegrationAPI.h
    api/SearchAPI.h
    api/SecurityAPI.h
    api/SeminarAPI.h
    api/ServiceAPI.h
    api/ServiceassignmentAPI.h
    api/SessionAPI.h
    api/SessionattendancelogAPI.h
    api/SessionregAPI.h
    api/SessionswipeAPI.h
    api/SettingAPI.h
    api/SocialAPI.h
    api/SocialgroupAPI.h
    api/SsoAPI.h
    api/StaffavailAPI.h
    api/StationAPI.h
    api/SwipeAPI.h
    api/TagAPI.h
    api/TemplateAPI.h
    api/TermAPI.h
    api/TextcreditAPI.h
    api/TranslationAPI.h
    api/UserAPI.h
    api/UsergroupAPI.h
    api/UserprofileAPI.h
    api/UsersettingsAPI.h
    api/VirtuallineAPI.h
    api/WaitinglineAPI.h

)

# Add library with project file with projectname as library name
add_library(${pkgName} SHARED ${SRCS} ${HDRS})
# Link dependent libraries
target_link_libraries(${pkgName} ${CURL_LIBRARIES} )
#install library to destination
install(TARGETS ${pkgName} DESTINATION ${CMAKE_INSTALL_PREFIX})

# Setting file variables to null
set(SRCS "")
set(HDRS "")


## This section shows how to use the above compiled libary to compile the source files
## set source files
#set(SRCS
#    unit-tests/manual-ActionassignmentAPI.c
#    unit-tests/manual-ActionitemAPI.c
#    unit-tests/manual-ActionlogAPI.c
#    unit-tests/manual-ActionpackAPI.c
#    unit-tests/manual-ActiontypeAPI.c
#    unit-tests/manual-AdhocqueryAPI.c
#    unit-tests/manual-AdhocreportsAPI.c
#    unit-tests/manual-AdvancedstationAPI.c
#    unit-tests/manual-AdvroleAPI.c
#    unit-tests/manual-AdvrolesAPI.c
#    unit-tests/manual-AppointmentAPI.c
#    unit-tests/manual-AppshareAPI.c
#    unit-tests/manual-AttendancelogAPI.c
#    unit-tests/manual-AttendancelogcommentAPI.c
#    unit-tests/manual-AttendancerestrictionAPI.c
#    unit-tests/manual-BeaconAPI.c
#    unit-tests/manual-BgjobAPI.c
#    unit-tests/manual-CaptchaAPI.c
#    unit-tests/manual-ClientAPI.c
#    unit-tests/manual-CommunityAPI.c
#    unit-tests/manual-CompasscategoryAPI.c
#    unit-tests/manual-CompassserviceAPI.c
#    unit-tests/manual-ComputerlabAPI.c
#    unit-tests/manual-DeadendrecordingAPI.c
#    unit-tests/manual-DepartmentAPI.c
#    unit-tests/manual-EasyloginAPI.c
#    unit-tests/manual-EventAPI.c
#    unit-tests/manual-EventregAPI.c
#    unit-tests/manual-ExportAPI.c
#    unit-tests/manual-FeatureAPI.c
#    unit-tests/manual-GeneralAPI.c
#    unit-tests/manual-HolidayAPI.c
#    unit-tests/manual-ImportAPI.c
#    unit-tests/manual-InteractionAPI.c
#    unit-tests/manual-LicenseAPI.c
#    unit-tests/manual-LikeAPI.c
#    unit-tests/manual-LocationAPI.c
#    unit-tests/manual-MediaAPI.c
#    unit-tests/manual-MediatypeAPI.c
#    unit-tests/manual-MemorizedreportAPI.c
#    unit-tests/manual-MenuAPI.c
#    unit-tests/manual-MyAPI.c
#    unit-tests/manual-NotificationAPI.c
#    unit-tests/manual-NotificationtopicAPI.c
#    unit-tests/manual-PushAPI.c
#    unit-tests/manual-QrlabelsAPI.c
#    unit-tests/manual-QrloginAPI.c
#    unit-tests/manual-QuickpanelAPI.c
#    unit-tests/manual-RatingAPI.c
#    unit-tests/manual-ReportAPI.c
#    unit-tests/manual-ReportscheduleAPI.c
#    unit-tests/manual-RiskmodelAPI.c
#    unit-tests/manual-RoleAPI.c
#    unit-tests/manual-RuleAPI.c
#    unit-tests/manual-ScheduleAPI.c
#    unit-tests/manual-ScheduleintegrationAPI.c
#    unit-tests/manual-SearchAPI.c
#    unit-tests/manual-SecurityAPI.c
#    unit-tests/manual-SeminarAPI.c
#    unit-tests/manual-ServiceAPI.c
#    unit-tests/manual-ServiceassignmentAPI.c
#    unit-tests/manual-SessionAPI.c
#    unit-tests/manual-SessionattendancelogAPI.c
#    unit-tests/manual-SessionregAPI.c
#    unit-tests/manual-SessionswipeAPI.c
#    unit-tests/manual-SettingAPI.c
#    unit-tests/manual-SocialAPI.c
#    unit-tests/manual-SocialgroupAPI.c
#    unit-tests/manual-SsoAPI.c
#    unit-tests/manual-StaffavailAPI.c
#    unit-tests/manual-StationAPI.c
#    unit-tests/manual-SwipeAPI.c
#    unit-tests/manual-TagAPI.c
#    unit-tests/manual-TemplateAPI.c
#    unit-tests/manual-TermAPI.c
#    unit-tests/manual-TextcreditAPI.c
#    unit-tests/manual-TranslationAPI.c
#    unit-tests/manual-UserAPI.c
#    unit-tests/manual-UsergroupAPI.c
#    unit-tests/manual-UserprofileAPI.c
#    unit-tests/manual-UsersettingsAPI.c
#    unit-tests/manual-VirtuallineAPI.c
#    unit-tests/manual-WaitinglineAPI.c
#)

##set header files
#set(HDRS
#)

## loop over all files in SRCS variable
#foreach(SOURCE_FILE ${SRCS})
#    # Get only the file name from the file as add_executable doesnot support executable with slash("/")
#    get_filename_component(FILE_NAME_ONLY ${SOURCE_FILE} NAME_WE)
#    # Remove .c from the file name and set it as executable name
#    string( REPLACE ".c" "" EXECUTABLE_FILE ${FILE_NAME_ONLY})
#    # Add executable for every source file in  SRCS
#    add_executable(unit-${EXECUTABLE_FILE} ${SOURCE_FILE})
#    # Link above created libary to executable and dependent libary curl
#    target_link_libraries(unit-${EXECUTABLE_FILE} ${CURL_LIBRARIES} ${pkgName} )
#endforeach(SOURCE_FILE ${SRCS})
