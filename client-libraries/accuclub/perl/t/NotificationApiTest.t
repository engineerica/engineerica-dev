=begin comment

AccuClub OpenAPI 3

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

use_ok('WWW::OpenAPIClient::NotificationApi');

my $api = WWW::OpenAPIClient::NotificationApi->new();
isa_ok($api, 'WWW::OpenAPIClient::NotificationApi');

#
# notification_delete test
#
{
    my $id = undef; # replace NULL with a proper value
    my $body = undef; # replace NULL with a proper value
    my $result = $api->notification_delete(id => $id, body => $body);
}

#
# notification_get test
#
{
    my $id = undef; # replace NULL with a proper value
    my $result = $api->notification_get(id => $id);
}

#
# notification_getforstation test
#
{
    my $station = undef; # replace NULL with a proper value
    my $user = undef; # replace NULL with a proper value
    my $result = $api->notification_getforstation(station => $station, user => $user);
}

#
# notification_getunreadcount test
#
{
    my $result = $api->notification_getunreadcount();
}

#
# notification_list test
#
{
    my $from = undef; # replace NULL with a proper value
    my $count = undef; # replace NULL with a proper value
    my $recipient = undef; # replace NULL with a proper value
    my $status = undef; # replace NULL with a proper value
    my $startdate = undef; # replace NULL with a proper value
    my $enddate = undef; # replace NULL with a proper value
    my $sentonscreen = undef; # replace NULL with a proper value
    my $sentemail = undef; # replace NULL with a proper value
    my $sentsms = undef; # replace NULL with a proper value
    my $result = $api->notification_list(from => $from, count => $count, recipient => $recipient, status => $status, startdate => $startdate, enddate => $enddate, sentonscreen => $sentonscreen, sentemail => $sentemail, sentsms => $sentsms);
}

#
# notification_listmine test
#
{
    my $from = undef; # replace NULL with a proper value
    my $count = undef; # replace NULL with a proper value
    my $status = undef; # replace NULL with a proper value
    my $startdate = undef; # replace NULL with a proper value
    my $enddate = undef; # replace NULL with a proper value
    my $result = $api->notification_listmine(from => $from, count => $count, status => $status, startdate => $startdate, enddate => $enddate);
}

#
# notification_markasread test
#
{
    my $id = undef; # replace NULL with a proper value
    my $status = undef; # replace NULL with a proper value
    my $startdate = undef; # replace NULL with a proper value
    my $enddate = undef; # replace NULL with a proper value
    my $result = $api->notification_markasread(id => $id, status => $status, startdate => $startdate, enddate => $enddate);
}

#
# notification_markasunread test
#
{
    my $id = undef; # replace NULL with a proper value
    my $status = undef; # replace NULL with a proper value
    my $startdate = undef; # replace NULL with a proper value
    my $enddate = undef; # replace NULL with a proper value
    my $result = $api->notification_markasunread(id => $id, status => $status, startdate => $startdate, enddate => $enddate);
}

#
# notification_send test
#
{
    my $emailenabled = undef; # replace NULL with a proper value
    my $onscreenenabled = undef; # replace NULL with a proper value
    my $smsenabled = undef; # replace NULL with a proper value
    my $title = undef; # replace NULL with a proper value
    my $tousers = undef; # replace NULL with a proper value
    my $togroups = undef; # replace NULL with a proper value
    my $onscreenbody = undef; # replace NULL with a proper value
    my $onscreenclick = undef; # replace NULL with a proper value
    my $onscreenurl = undef; # replace NULL with a proper value
    my $onscreenclass = undef; # replace NULL with a proper value
    my $onscreenduration = undef; # replace NULL with a proper value
    my $showonstation = undef; # replace NULL with a proper value
    my $emailfromname = undef; # replace NULL with a proper value
    my $emailfrom = undef; # replace NULL with a proper value
    my $emailsubject = undef; # replace NULL with a proper value
    my $emailbody = undef; # replace NULL with a proper value
    my $textmessagebody = undef; # replace NULL with a proper value
    my $result = $api->notification_send(emailenabled => $emailenabled, onscreenenabled => $onscreenenabled, smsenabled => $smsenabled, title => $title, tousers => $tousers, togroups => $togroups, onscreenbody => $onscreenbody, onscreenclick => $onscreenclick, onscreenurl => $onscreenurl, onscreenclass => $onscreenclass, onscreenduration => $onscreenduration, showonstation => $showonstation, emailfromname => $emailfromname, emailfrom => $emailfrom, emailsubject => $emailsubject, emailbody => $emailbody, textmessagebody => $textmessagebody);
}

#
# notification_sendonscreen test
#
{
    my $notification = undef; # replace NULL with a proper value
    my $result = $api->notification_sendonscreen(notification => $notification);
}


1;