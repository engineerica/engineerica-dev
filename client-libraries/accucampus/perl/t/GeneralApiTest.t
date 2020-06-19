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

use_ok('WWW::OpenAPIClient::GeneralApi');

my $api = WWW::OpenAPIClient::GeneralApi->new();
isa_ok($api, 'WWW::OpenAPIClient::GeneralApi');

#
# changelog test
#
{
    my $result = $api->changelog();
}

#
# doc test
#
{
    my $excludeanonymous = undef; # replace NULL with a proper value
    my $result = $api->doc(excludeanonymous => $excludeanonymous);
}

#
# export test
#
{
    my $exporttype = undef; # replace NULL with a proper value
    my $exportformat = undef; # replace NULL with a proper value
    my $filters = undef; # replace NULL with a proper value
    my $result = $api->export(exporttype => $exporttype, exportformat => $exportformat, filters => $filters);
}

#
# import test
#
{
    my $importtype = undef; # replace NULL with a proper value
    my $upload = undef; # replace NULL with a proper value
    my $filename = undef; # replace NULL with a proper value
    my $parameters = undef; # replace NULL with a proper value
    my $result = $api->import(importtype => $importtype, upload => $upload, filename => $filename, parameters => $parameters);
}

#
# listtimezones test
#
{
    my $result = $api->listtimezones();
}

#
# login test
#
{
    my $domain = undef; # replace NULL with a proper value
    my $username = undef; # replace NULL with a proper value
    my $password = undef; # replace NULL with a proper value
    my $method = undef; # replace NULL with a proper value
    my $rememberme = undef; # replace NULL with a proper value
    my $result = $api->login(domain => $domain, username => $username, password => $password, method => $method, rememberme => $rememberme);
}

#
# logout test
#
{
    my $result = $api->logout();
}

#
# search test
#
{
    my $query = undef; # replace NULL with a proper value
    my $page = undef; # replace NULL with a proper value
    my $result = $api->search(query => $query, page => $page);
}

#
# texttoimage test
#
{
    my $text = undef; # replace NULL with a proper value
    my $fontcolor = undef; # replace NULL with a proper value
    my $fontsize = undef; # replace NULL with a proper value
    my $direction = undef; # replace NULL with a proper value
    my $width = undef; # replace NULL with a proper value
    my $result = $api->texttoimage(text => $text, fontcolor => $fontcolor, fontsize => $fontsize, direction => $direction, width => $width);
}

#
# version test
#
{
    my $result = $api->version();
}


1;