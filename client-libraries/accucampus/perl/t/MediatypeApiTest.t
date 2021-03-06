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

use_ok('WWW::OpenAPIClient::MediatypeApi');

my $api = WWW::OpenAPIClient::MediatypeApi->new();
isa_ok($api, 'WWW::OpenAPIClient::MediatypeApi');

#
# mediatype_delete test
#
{
    my $id = undef; # replace NULL with a proper value
    my $body = undef; # replace NULL with a proper value
    my $result = $api->mediatype_delete(id => $id, body => $body);
}

#
# mediatype_get test
#
{
    my $id = undef; # replace NULL with a proper value
    my $result = $api->mediatype_get(id => $id);
}

#
# mediatype_list test
#
{
    my $from = undef; # replace NULL with a proper value
    my $count = undef; # replace NULL with a proper value
    my $result = $api->mediatype_list(from => $from, count => $count);
}

#
# mediatype_save test
#
{
    my $id = undef; # replace NULL with a proper value
    my $unknown_base_type = undef; # replace NULL with a proper value
    my $result = $api->mediatype_save(id => $id, unknown_base_type => $unknown_base_type);
}


1;
