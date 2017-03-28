'use strict';

var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var rename = require('gulp-rename');

var sourcejs = [
	'scripts/spa/modules/*.js', 
	'scripts/spa/app.js', 
	'scripts/spa/**/*.js'
];
var sourceVendor = [
	'bower_components/jquery/dist/jquery.min.js',
	'bower_components/bootstrap/dist/js/bootstrap.min.js',
	'bower_components/toastr/toastr.min.js',
	'bower_components/raty/lib/jquery.raty.js',
	'bower_components/angular/angular.min.js',
	'bower_components/angular-resource/angular-resource.min.js',
	'bower_components/angular-route/angular-route.min.js',
	'bower_components/angular-cookies/angular-cookies.min.js',
	'bower_components/tg-angular-validator/dist/angular-validator.min.js',
	'bower_components/angular-base64/angular-base64.min.js',
	'bower_components/angular-file-upload/dist/angular-file-upload.min.js',
	'bower_components/angucomplete-alt/dist/angucomplete-alt.min.js',
	'bower_components/angular-bootstrap/ui-bootstrap.min.js',
	'bower_components/angular-bootstrap/ui-bootstrap-tpls.min.js',
	'bower_components/angular-loading-bar/build/loading-bar.min.js'
];

gulp.task('copyVendor', function() {
	return gulp.src(sourceVendor)
		//.pipe(concat('vendor.js'))
		.pipe(gulp.dest('scripts/vendor/'));
});

gulp.task('compileJs', function() {
	return gulp.src(sourcejs)
		.pipe(concat('main.js'))
		.pipe(rename({suffix: '.min'}))
		//.pipe(uglify())
		.pipe(gulp.dest('scripts/dest/'));
});

gulp.task('compileModuleJs', function() {
	
})

gulp.task('watch', function() {
	return gulp.watch(sourcejs, ['compileJs']);
});

gulp.task('default', ['compileJs', 'watch']);