=begin comment

AccuCampus OpenAPI 3

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator
# Please update the test cases below to test the API endpoints.
# Ref: https://openapi-generator.tech
#
use Test::More tests => 1; #TODO update number of test cases
use Test::Exception;

use lib 'lib';
use strict;
use warnings;

use_ok('WWW::OpenAPIClient::EventregApi');

my $api = WWW::OpenAPIClient::EventregApi->new();
isa_ok($api, 'WWW::OpenAPIClient::EventregApi');

#
# eventreg_addme test
#
{
    my $eventid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_addme(eventid => $eventid, listname => $listname);
}

#
# eventreg_addmetoall test
#
{
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_addmetoall(listname => $listname);
}

#
# eventreg_addmetogroup test
#
{
    my $codegroup = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_addmetogroup(codegroup => $codegroup, listname => $listname);
}

#
# eventreg_adduser test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $eventid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_adduser(userid => $userid, eventid => $eventid, listname => $listname);
}

#
# eventreg_addusertoall test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_addusertoall(userid => $userid, listname => $listname);
}

#
# eventreg_addusertogroup test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $codegroup = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_addusertogroup(userid => $userid, codegroup => $codegroup, listname => $listname);
}

#
# eventreg_getevents test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $termid = undef; # replace NULL with a proper value
    my $namefilter = undef; # replace NULL with a proper value
    my $result = $api->eventreg_getevents(userid => $userid, listname => $listname, termid => $termid, namefilter => $namefilter);
}

#
# eventreg_getgroups test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_getgroups(userid => $userid, listname => $listname);
}

#
# eventreg_getmyevents test
#
{
    my $listname = undef; # replace NULL with a proper value
    my $termid = undef; # replace NULL with a proper value
    my $namefilter = undef; # replace NULL with a proper value
    my $result = $api->eventreg_getmyevents(listname => $listname, termid => $termid, namefilter => $namefilter);
}

#
# eventreg_getmygroups test
#
{
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_getmygroups(listname => $listname);
}

#
# eventreg_getusers test
#
{
    my $eventid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $photosize = undef; # replace NULL with a proper value
    my $result = $api->eventreg_getusers(eventid => $eventid, listname => $listname, photosize => $photosize);
}

#
# eventreg_getusersfromgroup test
#
{
    my $codegroup = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_getusersfromgroup(codegroup => $codegroup, listname => $listname);
}

#
# eventreg_getuserstoall test
#
{
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_getuserstoall(listname => $listname);
}

#
# eventreg_removeme test
#
{
    my $eventid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_removeme(eventid => $eventid, listname => $listname);
}

#
# eventreg_removemefromall test
#
{
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_removemefromall(listname => $listname);
}

#
# eventreg_removemefromgroup test
#
{
    my $codegroup = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_removemefromgroup(codegroup => $codegroup, listname => $listname);
}

#
# eventreg_removeuser test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $eventid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_removeuser(userid => $userid, eventid => $eventid, listname => $listname);
}

#
# eventreg_removeuserfromall test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_removeuserfromall(userid => $userid, listname => $listname);
}

#
# eventreg_removeuserfromgroup test
#
{
    my $userid = undef; # replace NULL with a proper value
    my $codegroup = undef; # replace NULL with a proper value
    my $listname = undef; # replace NULL with a proper value
    my $result = $api->eventreg_removeuserfromgroup(userid => $userid, codegroup => $codegroup, listname => $listname);
}


1;
