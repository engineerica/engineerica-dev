=begin comment

AccuCampus OpenAPI 3

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
package WWW::OpenAPIClient::RatingApi;

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
# rating_flag
#
# Flags one rating for moderation
# 
# @param string $id The rating to flag. (required)
# @param string $comment Comment why should this should be removed. (optional)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The rating to flag.',
        required => '1',
    },
    'comment' => {
        data_type => 'string',
        description => 'Comment why should this should be removed.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_flag' } = { 
        summary => 'Flags one rating for moderation',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_flag {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling rating_flag");
    }

    # parse inputs
    my $_resource_path = '/rating/flag';

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
    if ( exists $args{'id'}) {
        $query_params->{'id'} = $self->{api_client}->to_query_value($args{'id'});
    }

    # query params
    if ( exists $args{'comment'}) {
        $query_params->{'comment'} = $self->{api_client}->to_query_value($args{'comment'});
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
# rating_flagcomment
#
# Flags one comment for moderation
# 
# @param string $id The comment to flag. (required)
# @param string $comment Comment why should this should be removed. (optional)
{
    my $params = {
    'id' => {
        data_type => 'string',
        description => 'The comment to flag.',
        required => '1',
    },
    'comment' => {
        data_type => 'string',
        description => 'Comment why should this should be removed.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_flagcomment' } = { 
        summary => 'Flags one comment for moderation',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_flagcomment {
    my ($self, %args) = @_;

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling rating_flagcomment");
    }

    # parse inputs
    my $_resource_path = '/rating/flagcomment';

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
    if ( exists $args{'id'}) {
        $query_params->{'id'} = $self->{api_client}->to_query_value($args{'id'});
    }

    # query params
    if ( exists $args{'comment'}) {
        $query_params->{'comment'} = $self->{api_client}->to_query_value($args{'comment'});
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
# rating_get
#
# Get rating for one or more entities
# 
# @param string $type The entity type to get the rating. (required)
# @param string $entityids List of ids to get the ratings. (required)
{
    my $params = {
    'type' => {
        data_type => 'string',
        description => 'The entity type to get the rating.',
        required => '1',
    },
    'entityids' => {
        data_type => 'string',
        description => 'List of ids to get the ratings.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_get' } = { 
        summary => 'Get rating for one or more entities',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_get {
    my ($self, %args) = @_;

    # verify the required parameter 'type' is set
    unless (exists $args{'type'}) {
      croak("Missing the required parameter 'type' when calling rating_get");
    }

    # verify the required parameter 'entityids' is set
    unless (exists $args{'entityids'}) {
      croak("Missing the required parameter 'entityids' when calling rating_get");
    }

    # parse inputs
    my $_resource_path = '/rating/get';

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
    if ( exists $args{'type'}) {
        $query_params->{'type'} = $self->{api_client}->to_query_value($args{'type'});
    }

    # query params
    if ( exists $args{'entityids'}) {
        $query_params->{'entityids'} = $self->{api_client}->to_query_value($args{'entityids'});
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
# rating_getall
#
# Gets the full ratings and comments for a specific entity
# 
# @param string $type The entity type to get the rating. (required)
# @param string $entityid Id of the entity to get the ratings. (required)
# @param boolean $mostrecentfirst True to show most recent first, otherwise most helpful first. (optional)
{
    my $params = {
    'type' => {
        data_type => 'string',
        description => 'The entity type to get the rating.',
        required => '1',
    },
    'entityid' => {
        data_type => 'string',
        description => 'Id of the entity to get the ratings.',
        required => '1',
    },
    'mostrecentfirst' => {
        data_type => 'boolean',
        description => 'True to show most recent first, otherwise most helpful first.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_getall' } = { 
        summary => 'Gets the full ratings and comments for a specific entity',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_getall {
    my ($self, %args) = @_;

    # verify the required parameter 'type' is set
    unless (exists $args{'type'}) {
      croak("Missing the required parameter 'type' when calling rating_getall");
    }

    # verify the required parameter 'entityid' is set
    unless (exists $args{'entityid'}) {
      croak("Missing the required parameter 'entityid' when calling rating_getall");
    }

    # parse inputs
    my $_resource_path = '/rating/getall';

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
    if ( exists $args{'type'}) {
        $query_params->{'type'} = $self->{api_client}->to_query_value($args{'type'});
    }

    # query params
    if ( exists $args{'entityid'}) {
        $query_params->{'entityid'} = $self->{api_client}->to_query_value($args{'entityid'});
    }

    # query params
    if ( exists $args{'mostrecentfirst'}) {
        $query_params->{'mostrecentfirst'} = $self->{api_client}->to_query_value($args{'mostrecentfirst'});
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
# rating_getcomments
#
# Gets all the comments for a rating
# 
# @param string $ratingid The ID of the rating to get all comments. (required)
{
    my $params = {
    'ratingid' => {
        data_type => 'string',
        description => 'The ID of the rating to get all comments.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_getcomments' } = { 
        summary => 'Gets all the comments for a rating',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_getcomments {
    my ($self, %args) = @_;

    # verify the required parameter 'ratingid' is set
    unless (exists $args{'ratingid'}) {
      croak("Missing the required parameter 'ratingid' when calling rating_getcomments");
    }

    # parse inputs
    my $_resource_path = '/rating/getcomments';

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
    if ( exists $args{'ratingid'}) {
        $query_params->{'ratingid'} = $self->{api_client}->to_query_value($args{'ratingid'});
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
# rating_getpending
#
# Gets info of pre-saved and pre-approved ratings
# 
# @param string $getgroup The ID of the group of pending ratings to get. (required)
# @param string $rateid Rate this before returning. (optional)
# @param int $rateval The value used to rate the item specified in rateid. (optional)
{
    my $params = {
    'getgroup' => {
        data_type => 'string',
        description => 'The ID of the group of pending ratings to get.',
        required => '1',
    },
    'rateid' => {
        data_type => 'string',
        description => 'Rate this before returning.',
        required => '0',
    },
    'rateval' => {
        data_type => 'int',
        description => 'The value used to rate the item specified in rateid.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_getpending' } = { 
        summary => 'Gets info of pre-saved and pre-approved ratings',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_getpending {
    my ($self, %args) = @_;

    # verify the required parameter 'getgroup' is set
    unless (exists $args{'getgroup'}) {
      croak("Missing the required parameter 'getgroup' when calling rating_getpending");
    }

    # parse inputs
    my $_resource_path = '/rating/getpending';

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
    if ( exists $args{'getgroup'}) {
        $query_params->{'getgroup'} = $self->{api_client}->to_query_value($args{'getgroup'});
    }

    # query params
    if ( exists $args{'rateid'}) {
        $query_params->{'rateid'} = $self->{api_client}->to_query_value($args{'rateid'});
    }

    # query params
    if ( exists $args{'rateval'}) {
        $query_params->{'rateval'} = $self->{api_client}->to_query_value($args{'rateval'});
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw()];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

#
# rating_getpendingmoderation
#
# Shows a list of the ratings and comments that are pending for moderation
# 
{
    my $params = {
    };
    __PACKAGE__->method_documentation->{ 'rating_getpendingmoderation' } = { 
        summary => 'Shows a list of the ratings and comments that are pending for moderation',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_getpendingmoderation {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/rating/getpendingmoderation';

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
# rating_moderate
#
# Allows the user to accept or reject a comment
# 
# @param string $type Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. (required)
# @param string $id Id of the rating or comment, as specified in type. (required)
# @param boolean $approve True to approve, false to reject. (required)
{
    my $params = {
    'type' => {
        data_type => 'string',
        description => 'Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate.',
        required => '1',
    },
    'id' => {
        data_type => 'string',
        description => 'Id of the rating or comment, as specified in type.',
        required => '1',
    },
    'approve' => {
        data_type => 'boolean',
        description => 'True to approve, false to reject.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_moderate' } = { 
        summary => 'Allows the user to accept or reject a comment',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_moderate {
    my ($self, %args) = @_;

    # verify the required parameter 'type' is set
    unless (exists $args{'type'}) {
      croak("Missing the required parameter 'type' when calling rating_moderate");
    }

    # verify the required parameter 'id' is set
    unless (exists $args{'id'}) {
      croak("Missing the required parameter 'id' when calling rating_moderate");
    }

    # verify the required parameter 'approve' is set
    unless (exists $args{'approve'}) {
      croak("Missing the required parameter 'approve' when calling rating_moderate");
    }

    # parse inputs
    my $_resource_path = '/rating/moderate';

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
    if ( exists $args{'type'}) {
        $query_params->{'type'} = $self->{api_client}->to_query_value($args{'type'});
    }

    # query params
    if ( exists $args{'id'}) {
        $query_params->{'id'} = $self->{api_client}->to_query_value($args{'id'});
    }

    # query params
    if ( exists $args{'approve'}) {
        $query_params->{'approve'} = $self->{api_client}->to_query_value($args{'approve'});
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
# rating_postcomment
#
# Posts a comments for in a rating
# 
# @param string $ratingid The ID of the rating to post the comment. (required)
# @param string $comment Text of the comment to post. (required)
# @param boolean $annonymous True to post the comment annonymously. (required)
{
    my $params = {
    'ratingid' => {
        data_type => 'string',
        description => 'The ID of the rating to post the comment.',
        required => '1',
    },
    'comment' => {
        data_type => 'string',
        description => 'Text of the comment to post.',
        required => '1',
    },
    'annonymous' => {
        data_type => 'boolean',
        description => 'True to post the comment annonymously.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_postcomment' } = { 
        summary => 'Posts a comments for in a rating',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_postcomment {
    my ($self, %args) = @_;

    # verify the required parameter 'ratingid' is set
    unless (exists $args{'ratingid'}) {
      croak("Missing the required parameter 'ratingid' when calling rating_postcomment");
    }

    # verify the required parameter 'comment' is set
    unless (exists $args{'comment'}) {
      croak("Missing the required parameter 'comment' when calling rating_postcomment");
    }

    # verify the required parameter 'annonymous' is set
    unless (exists $args{'annonymous'}) {
      croak("Missing the required parameter 'annonymous' when calling rating_postcomment");
    }

    # parse inputs
    my $_resource_path = '/rating/postcomment';

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
    if ( exists $args{'ratingid'}) {
        $query_params->{'ratingid'} = $self->{api_client}->to_query_value($args{'ratingid'});
    }

    # query params
    if ( exists $args{'comment'}) {
        $query_params->{'comment'} = $self->{api_client}->to_query_value($args{'comment'});
    }

    # query params
    if ( exists $args{'annonymous'}) {
        $query_params->{'annonymous'} = $self->{api_client}->to_query_value($args{'annonymous'});
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
# rating_rate
#
# Rates one entity
# 
# @param string $type The entity type to rate. (required)
# @param string $entityid Id of the entity to rate. (required)
# @param boolean $annonymous Whether to post as annonymous. (required)
# @param int $value Value from 0 to 100 with the rating. (optional)
# @param string $comment Comment associated with this review. Comment can be updated later on another request too. (optional)
# @param boolean $updatecomment Whether to update the comments. Defaults to true. (optional)
{
    my $params = {
    'type' => {
        data_type => 'string',
        description => 'The entity type to rate.',
        required => '1',
    },
    'entityid' => {
        data_type => 'string',
        description => 'Id of the entity to rate.',
        required => '1',
    },
    'annonymous' => {
        data_type => 'boolean',
        description => 'Whether to post as annonymous.',
        required => '1',
    },
    'value' => {
        data_type => 'int',
        description => 'Value from 0 to 100 with the rating.',
        required => '0',
    },
    'comment' => {
        data_type => 'string',
        description => 'Comment associated with this review. Comment can be updated later on another request too.',
        required => '0',
    },
    'updatecomment' => {
        data_type => 'boolean',
        description => 'Whether to update the comments. Defaults to true.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_rate' } = { 
        summary => 'Rates one entity',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_rate {
    my ($self, %args) = @_;

    # verify the required parameter 'type' is set
    unless (exists $args{'type'}) {
      croak("Missing the required parameter 'type' when calling rating_rate");
    }

    # verify the required parameter 'entityid' is set
    unless (exists $args{'entityid'}) {
      croak("Missing the required parameter 'entityid' when calling rating_rate");
    }

    # verify the required parameter 'annonymous' is set
    unless (exists $args{'annonymous'}) {
      croak("Missing the required parameter 'annonymous' when calling rating_rate");
    }

    # parse inputs
    my $_resource_path = '/rating/rate';

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
    if ( exists $args{'type'}) {
        $query_params->{'type'} = $self->{api_client}->to_query_value($args{'type'});
    }

    # query params
    if ( exists $args{'entityid'}) {
        $query_params->{'entityid'} = $self->{api_client}->to_query_value($args{'entityid'});
    }

    # query params
    if ( exists $args{'value'}) {
        $query_params->{'value'} = $self->{api_client}->to_query_value($args{'value'});
    }

    # query params
    if ( exists $args{'annonymous'}) {
        $query_params->{'annonymous'} = $self->{api_client}->to_query_value($args{'annonymous'});
    }

    # query params
    if ( exists $args{'comment'}) {
        $query_params->{'comment'} = $self->{api_client}->to_query_value($args{'comment'});
    }

    # query params
    if ( exists $args{'updatecomment'}) {
        $query_params->{'updatecomment'} = $self->{api_client}->to_query_value($args{'updatecomment'});
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
# rating_ratepending
#
# Rates a pre-saved and pre-approved entity
# 
# @param string $group The ID of the group of with pre-approved ratings. (required)
# @param boolean $annonymous Whether to post as annonymous. (required)
# @param string $rateid Rate this before returning. (optional)
# @param int $value Value from 0 to 100 with the rating. (optional)
# @param string $comment Comment associated with this review. Comment can be updated later on another request too. (optional)
# @param boolean $updatecomment Whether to update the comments. Defaults to true. (optional)
{
    my $params = {
    'group' => {
        data_type => 'string',
        description => 'The ID of the group of with pre-approved ratings.',
        required => '1',
    },
    'annonymous' => {
        data_type => 'boolean',
        description => 'Whether to post as annonymous.',
        required => '1',
    },
    'rateid' => {
        data_type => 'string',
        description => 'Rate this before returning.',
        required => '0',
    },
    'value' => {
        data_type => 'int',
        description => 'Value from 0 to 100 with the rating.',
        required => '0',
    },
    'comment' => {
        data_type => 'string',
        description => 'Comment associated with this review. Comment can be updated later on another request too.',
        required => '0',
    },
    'updatecomment' => {
        data_type => 'boolean',
        description => 'Whether to update the comments. Defaults to true.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_ratepending' } = { 
        summary => 'Rates a pre-saved and pre-approved entity',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_ratepending {
    my ($self, %args) = @_;

    # verify the required parameter 'group' is set
    unless (exists $args{'group'}) {
      croak("Missing the required parameter 'group' when calling rating_ratepending");
    }

    # verify the required parameter 'annonymous' is set
    unless (exists $args{'annonymous'}) {
      croak("Missing the required parameter 'annonymous' when calling rating_ratepending");
    }

    # parse inputs
    my $_resource_path = '/rating/ratepending';

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
    if ( exists $args{'group'}) {
        $query_params->{'group'} = $self->{api_client}->to_query_value($args{'group'});
    }

    # query params
    if ( exists $args{'rateid'}) {
        $query_params->{'rateid'} = $self->{api_client}->to_query_value($args{'rateid'});
    }

    # query params
    if ( exists $args{'value'}) {
        $query_params->{'value'} = $self->{api_client}->to_query_value($args{'value'});
    }

    # query params
    if ( exists $args{'annonymous'}) {
        $query_params->{'annonymous'} = $self->{api_client}->to_query_value($args{'annonymous'});
    }

    # query params
    if ( exists $args{'comment'}) {
        $query_params->{'comment'} = $self->{api_client}->to_query_value($args{'comment'});
    }

    # query params
    if ( exists $args{'updatecomment'}) {
        $query_params->{'updatecomment'} = $self->{api_client}->to_query_value($args{'updatecomment'});
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw()];

    # make the API Call
    $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    return;
}

#
# rating_vote
#
# Votes up or down a rating
# 
# @param string $ratingid The ID of the rating to vote on. (required)
# @param int $vote 1 to vote up, -1 to vote down. (required)
{
    my $params = {
    'ratingid' => {
        data_type => 'string',
        description => 'The ID of the rating to vote on.',
        required => '1',
    },
    'vote' => {
        data_type => 'int',
        description => '1 to vote up, -1 to vote down.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'rating_vote' } = { 
        summary => 'Votes up or down a rating',
        params => $params,
        returns => undef,
        };
}
# @return void
#
sub rating_vote {
    my ($self, %args) = @_;

    # verify the required parameter 'ratingid' is set
    unless (exists $args{'ratingid'}) {
      croak("Missing the required parameter 'ratingid' when calling rating_vote");
    }

    # verify the required parameter 'vote' is set
    unless (exists $args{'vote'}) {
      croak("Missing the required parameter 'vote' when calling rating_vote");
    }

    # parse inputs
    my $_resource_path = '/rating/vote';

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
    if ( exists $args{'ratingid'}) {
        $query_params->{'ratingid'} = $self->{api_client}->to_query_value($args{'ratingid'});
    }

    # query params
    if ( exists $args{'vote'}) {
        $query_params->{'vote'} = $self->{api_client}->to_query_value($args{'vote'});
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