=begin
#AccuTraining OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::SwipeApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'SwipeApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::SwipeApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of SwipeApi' do
    it 'should create an instance of SwipeApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::SwipeApi)
    end
  end

  # unit tests for swipe_delete
  # Delete a swipe
  # Allows the user to delete an existing attendance swipe.
  # @param id The id of the swipe to delete.
  # @param [Hash] opts the optional parameters
  # @option opts [AnyType] :body 
  # @return [nil]
  describe 'swipe_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for swipe_get
  # Search and view details of a swipe
  # Allows the user to view an individual attendance swipe.
  # @param id The id of the swipe to get.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'swipe_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for swipe_list
  # View a list of swipes
  # Allows the user to view a list of all swipes for the location or locations in which the user is scoped.
  # @param from The first record to return.
  # @param count The max number of records to return.
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'swipe_list test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for swipe_save
  # Create or edit a swipe, and if possible, save the related attendance log
  # Allows the user to save an attendance swipe, which will also save the attendance log if the information in the swipe is enough.
  # @param [Hash] opts the optional parameters
  # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
  # @return [nil]
  describe 'swipe_save test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for swipe_saveanonym
  # Creates a new swipe from a sign-in station, and if possible, creates the attendance log
  # @param [Hash] opts the optional parameters
  # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
  # @return [nil]
  describe 'swipe_saveanonym test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end