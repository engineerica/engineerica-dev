/**
 * AccuCampus OpenAPI 3
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', process.cwd()+'/src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require(process.cwd()+'/src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.AccuCampusOpenApi3);
  }
}(this, function(expect, AccuCampusOpenApi3) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new AccuCampusOpenApi3.ComputerlabApi();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('ComputerlabApi', function() {
    describe('computerlabDeletecomputer', function() {
      it('should call computerlabDeletecomputer successfully', function(done) {
        //uncomment below and update the code to test computerlabDeletecomputer
        //instance.computerlabDeletecomputer(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabGetcomputer', function() {
      it('should call computerlabGetcomputer successfully', function(done) {
        //uncomment below and update the code to test computerlabGetcomputer
        //instance.computerlabGetcomputer(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabGetsettings', function() {
      it('should call computerlabGetsettings successfully', function(done) {
        //uncomment below and update the code to test computerlabGetsettings
        //instance.computerlabGetsettings(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabIssignedin', function() {
      it('should call computerlabIssignedin successfully', function(done) {
        //uncomment below and update the code to test computerlabIssignedin
        //instance.computerlabIssignedin(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabListcomputers', function() {
      it('should call computerlabListcomputers successfully', function(done) {
        //uncomment below and update the code to test computerlabListcomputers
        //instance.computerlabListcomputers(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabListlabs', function() {
      it('should call computerlabListlabs successfully', function(done) {
        //uncomment below and update the code to test computerlabListlabs
        //instance.computerlabListlabs(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabListstations', function() {
      it('should call computerlabListstations successfully', function(done) {
        //uncomment below and update the code to test computerlabListstations
        //instance.computerlabListstations(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabSavecomputer', function() {
      it('should call computerlabSavecomputer successfully', function(done) {
        //uncomment below and update the code to test computerlabSavecomputer
        //instance.computerlabSavecomputer(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabSavesettings', function() {
      it('should call computerlabSavesettings successfully', function(done) {
        //uncomment below and update the code to test computerlabSavesettings
        //instance.computerlabSavesettings(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('computerlabSaveswipe', function() {
      it('should call computerlabSaveswipe successfully', function(done) {
        //uncomment below and update the code to test computerlabSaveswipe
        //instance.computerlabSaveswipe(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
  });

}));