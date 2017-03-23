'use strict';

var gulp = require('gulp');
var concat = require('gulp-concat');

var sourcejs = ['src/js/*.js'];
var sourceVendor = [
	'bower_components/angucomplete-alt/dist/angucomplete-alt.min.js',
	'bower_components/angular/angular.min.js',
	'bower_components/angular-base64/angular-base64.min.js',
	'bower_components/angular-bootstrap/ui-bootstrap.min.js',
	'bower_components/angular-file-upload/angular-file-upload.min.js',
	'bower_components/angular-loading-bar/build/loading-bar.min.js',
	'bower_components/bootstrap/dist/js/bootstrap.min.js',
	'bower_components/jquery/dist/jquery.min.js',
	'bower_components/tg-angular-validator/dist/angular-validator.min.js'
];


gulp.task('copyVendor', function() {
	gulp.src(sourceVendor)
		.pipe(gulp.dest('scripts/vendor/'));
});
