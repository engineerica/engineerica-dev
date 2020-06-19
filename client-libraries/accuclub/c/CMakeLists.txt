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

set(pkgName "accuclub_openapi_3")

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
    api/ActionlogAPI.c
    api/AdvroleAPI.c
    api/AdvrolesAPI.c
    api/AppshareAPI.c
    api/AttendancelogAPI.c
    api/AttendancelogcommentAPI.c
    api/BgjobAPI.c
    api/CaptchaAPI.c
    api/ClientAPI.c
    api/CreditAPI.c
    api/CreditplanAPI.c
    api/EasyloginAPI.c
    api/EventAPI.c
    api/ExportAPI.c
    api/FeatureAPI.c
    api/GeneralAPI.c
    api/HolidayAPI.c
    api/ImportAPI.c
    api/LicenseAPI.c
    api/LocationAPI.c
    api/MemorizedreportAPI.c
    api/MenuAPI.c
    api/MyAPI.c
    api/NotificationAPI.c
    api/NotificationtopicAPI.c
    api/PushAPI.c
    api/QrlabelsAPI.c
    api/QrloginAPI.c
    api/QuickpanelAPI.c
    api/ReportAPI.c
    api/RoleAPI.c
    api/RuleAPI.c
    api/SearchAPI.c
    api/SecurityAPI.c
    api/SessionregAPI.c
    api/SettingAPI.c
    api/SsoAPI.c
    api/StationAPI.c
    api/SwipeAPI.c
    api/TagAPI.c
    api/TemplateAPI.c
    api/TermAPI.c
    api/TextcreditAPI.c
    api/TranslationAPI.c
    api/UserAPI.c
    api/UsergroupAPI.c
    api/UsersettingsAPI.c

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
    api/ActionlogAPI.h
    api/AdvroleAPI.h
    api/AdvrolesAPI.h
    api/AppshareAPI.h
    api/AttendancelogAPI.h
    api/AttendancelogcommentAPI.h
    api/BgjobAPI.h
    api/CaptchaAPI.h
    api/ClientAPI.h
    api/CreditAPI.h
    api/CreditplanAPI.h
    api/EasyloginAPI.h
    api/EventAPI.h
    api/ExportAPI.h
    api/FeatureAPI.h
    api/GeneralAPI.h
    api/HolidayAPI.h
    api/ImportAPI.h
    api/LicenseAPI.h
    api/LocationAPI.h
    api/MemorizedreportAPI.h
    api/MenuAPI.h
    api/MyAPI.h
    api/NotificationAPI.h
    api/NotificationtopicAPI.h
    api/PushAPI.h
    api/QrlabelsAPI.h
    api/QrloginAPI.h
    api/QuickpanelAPI.h
    api/ReportAPI.h
    api/RoleAPI.h
    api/RuleAPI.h
    api/SearchAPI.h
    api/SecurityAPI.h
    api/SessionregAPI.h
    api/SettingAPI.h
    api/SsoAPI.h
    api/StationAPI.h
    api/SwipeAPI.h
    api/TagAPI.h
    api/TemplateAPI.h
    api/TermAPI.h
    api/TextcreditAPI.h
    api/TranslationAPI.h
    api/UserAPI.h
    api/UsergroupAPI.h
    api/UsersettingsAPI.h

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
#    unit-tests/manual-ActionlogAPI.c
#    unit-tests/manual-AdvroleAPI.c
#    unit-tests/manual-AdvrolesAPI.c
#    unit-tests/manual-AppshareAPI.c
#    unit-tests/manual-AttendancelogAPI.c
#    unit-tests/manual-AttendancelogcommentAPI.c
#    unit-tests/manual-BgjobAPI.c
#    unit-tests/manual-CaptchaAPI.c
#    unit-tests/manual-ClientAPI.c
#    unit-tests/manual-CreditAPI.c
#    unit-tests/manual-CreditplanAPI.c
#    unit-tests/manual-EasyloginAPI.c
#    unit-tests/manual-EventAPI.c
#    unit-tests/manual-ExportAPI.c
#    unit-tests/manual-FeatureAPI.c
#    unit-tests/manual-GeneralAPI.c
#    unit-tests/manual-HolidayAPI.c
#    unit-tests/manual-ImportAPI.c
#    unit-tests/manual-LicenseAPI.c
#    unit-tests/manual-LocationAPI.c
#    unit-tests/manual-MemorizedreportAPI.c
#    unit-tests/manual-MenuAPI.c
#    unit-tests/manual-MyAPI.c
#    unit-tests/manual-NotificationAPI.c
#    unit-tests/manual-NotificationtopicAPI.c
#    unit-tests/manual-PushAPI.c
#    unit-tests/manual-QrlabelsAPI.c
#    unit-tests/manual-QrloginAPI.c
#    unit-tests/manual-QuickpanelAPI.c
#    unit-tests/manual-ReportAPI.c
#    unit-tests/manual-RoleAPI.c
#    unit-tests/manual-RuleAPI.c
#    unit-tests/manual-SearchAPI.c
#    unit-tests/manual-SecurityAPI.c
#    unit-tests/manual-SessionregAPI.c
#    unit-tests/manual-SettingAPI.c
#    unit-tests/manual-SsoAPI.c
#    unit-tests/manual-StationAPI.c
#    unit-tests/manual-SwipeAPI.c
#    unit-tests/manual-TagAPI.c
#    unit-tests/manual-TemplateAPI.c
#    unit-tests/manual-TermAPI.c
#    unit-tests/manual-TextcreditAPI.c
#    unit-tests/manual-TranslationAPI.c
#    unit-tests/manual-UserAPI.c
#    unit-tests/manual-UsergroupAPI.c
#    unit-tests/manual-UsersettingsAPI.c
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
