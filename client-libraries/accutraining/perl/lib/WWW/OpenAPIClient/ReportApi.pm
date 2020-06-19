=begin comment

AccuTraining OpenAPI 3

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# Do not edit the class manually.
# Ref: https://openapi-generator.tech
#
package WWW::OpenAPIClient::ReportApi;

require 5.6.0;
use strict;
use warnings;
use utf8; 
use Exporter;
use Carp qw( croak );
use Log::Any qw($log);

use WWW::OpenAPIClient::ApiClient;

use base "Class::Data::Inheritable";

__PACKAGE__->mk_classdata('method_documentation' => {});

sub new {
    my $class = shift;
    my $api_client;

    if ($_[0] && ref $_[0] && ref $_[0] eq 'WWW::OpenAPIClient::ApiClient' ) {
        $api_client = $_[0];
    } else {
        $api_client = WWW::OpenAPIClient::ApiClient->new(@_);
    }

    bless { api_client => $api_client }, $class;

}


#
# report_list
#
# View a list of available reports
# 
{
    my $params = {
    };
    __PACKAGE__->method_documentation->{ 'report_list' } = { 
        summary => 'View a list of available reports',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub report_list {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/report/list';

    my $_method = 'GET';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept();
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type();

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(bearerAuth )];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

#
# report_permissionsbyuser
#
# Permissions by user report
# 
# @param string $params A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 (optional)
{
    my $params = {
    'params' => {
        data_type => 'string',
        description => 'A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'report_permissionsbyuser' } = { 
        summary => 'Permissions by user report',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub report_permissionsbyuser {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/report/permissionsbyuser';

    my $_method = 'GET';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept();
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type();

    # query params
    if ( exists $args{'params'}) {
        $query_params->{'params'} = $self->{api_client}->to_query_value($args{'params'});
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(bearerAuth )];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

#
# report_prepare
#
# Queries and loads the specified report, in background.
# 
# @param string $reportname The name of the report to execute (required)
# @param string $params A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 (optional)
# @param string $repformat The format of the resulting report. Json, pdf, csv, ... (optional)
# @param string $fillgroupid If specified, the result is used to fill the group with the given ID (optional)
# @param string $groupby How to group the records. In the format &#39;col1+col2|col3+col4 (optional)
# @param string $refreshgroup The ID of the group to check (and refresh) before processing the report. (optional)
# @param string $filtertext The user friendly text of the applied filters. (optional)
{
    my $params = {
    'reportname' => {
        data_type => 'string',
        description => 'The name of the report to execute',
        required => '1',
    },
    'params' => {
        data_type => 'string',
        description => 'A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3',
        required => '0',
    },
    'repformat' => {
        data_type => 'string',
        description => 'The format of the resulting report. Json, pdf, csv, ...',
        required => '0',
    },
    'fillgroupid' => {
        data_type => 'string',
        description => 'If specified, the result is used to fill the group with the given ID',
        required => '0',
    },
    'groupby' => {
        data_type => 'string',
        description => 'How to group the records. In the format &#39;col1+col2|col3+col4',
        required => '0',
    },
    'refreshgroup' => {
        data_type => 'string',
        description => 'The ID of the group to check (and refresh) before processing the report.',
        required => '0',
    },
    'filtertext' => {
        data_type => 'string',
        description => 'The user friendly text of the applied filters.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'report_prepare' } = { 
        summary => 'Queries and loads the specified report, in background.',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub report_prepare {
    my ($self, %args) = @_;

    # verify the required parameter 'reportname' is set
    unless (exists $args{'reportname'}) {
      croak("Missing the required parameter 'reportname' when calling report_prepare");
    }

    # parse inputs
    my $_resource_path = '/report/prepare';

    my $_method = 'GET';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept();
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type();

    # query params
    if ( exists $args{'reportname'}) {
        $query_params->{'reportname'} = $self->{api_client}->to_query_value($args{'reportname'});
    }

    # query params
    if ( exists $args{'params'}) {
        $query_params->{'params'} = $self->{api_client}->to_query_value($args{'params'});
    }

    # query params
    if ( exists $args{'repformat'}) {
        $query_params->{'repformat'} = $self->{api_client}->to_query_value($args{'repformat'});
    }

    # query params
    if ( exists $args{'fillgroupid'}) {
        $query_params->{'fillgroupid'} = $self->{api_client}->to_query_value($args{'fillgroupid'});
    }

    # query params
    if ( exists $args{'groupby'}) {
        $query_params->{'groupby'} = $self->{api_client}->to_query_value($args{'groupby'});
    }

    # query params
    if ( exists $args{'refreshgroup'}) {
        $query_params->{'refreshgroup'} = $self->{api_client}->to_query_value($args{'refreshgroup'});
    }

    # query params
    if ( exists $args{'filtertext'}) {
        $query_params->{'filtertext'} = $self->{api_client}->to_query_value($args{'filtertext'});
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(bearerAuth )];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

#
# report_query
#
# Query and load a specified report
# 
# @param string $reportname The name of the report to execute (required)
# @param string $params A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 (optional)
{
    my $params = {
    'reportname' => {
        data_type => 'string',
        description => 'The name of the report to execute',
        required => '1',
    },
    'params' => {
        data_type => 'string',
        description => 'A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'report_query' } = { 
        summary => 'Query and load a specified report',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub report_query {
    my ($self, %args) = @_;

    # verify the required parameter 'reportname' is set
    unless (exists $args{'reportname'}) {
      croak("Missing the required parameter 'reportname' when calling report_query");
    }

    # parse inputs
    my $_resource_path = '/report/query';

    my $_method = 'GET';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept();
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type();

    # query params
    if ( exists $args{'reportname'}) {
        $query_params->{'reportname'} = $self->{api_client}->to_query_value($args{'reportname'});
    }

    # query params
    if ( exists $args{'params'}) {
        $query_params->{'params'} = $self->{api_client}->to_query_value($args{'params'});
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(bearerAuth )];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

1;