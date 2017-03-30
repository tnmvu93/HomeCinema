'use strict';

var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var rename = require('gulp-rename');

var srcAppModuleJs = 'scripts/spa/modules/*.js';
var srcAppServiceJs = 'scripts/spa/services/*.js';
var srcAppLayoutJs = 'scripts/spa/layout/*.js';
var destJs = 'scripts/dist/';


var sourcejs = [
	'scripts/spa/modules/*.js', 
	'scripts/spa/app.js', 
	'scripts/spa/**/*.js'
];
var srcVendor = [
	'bower_components/jquery/dist/jquery.js',
	'bower_components/bootstrap/dist/js/bootstrap.js',
	'bower_components/angular/angular.js',
	'bower_components/angular-resource/angular-resource.js',
	'bower_components/angular-route/angular-route.js',
	'bower_components/angular-base64/angular-base64.js',
	'bower_components/angular-cookies/angular-cookies.js',
	'bower_components/tg-angular-validator/dist/angular-validator.js',
	'bower_components/angular-file-upload/dist/angular-file-upload.js',
	'bower_components/angucomplete-alt/angucomplete-alt.js',
	'bower_components/angular-bootstrap/ui-bootstrap.js',
	'bower_components/angular-bootstrap/ui-bootstrap-tpls.js',
	'bower_components/toastr/toastr.js',
	'bower_components/raty/lib/jquery.raty.js',
	'bower_components/angular-loading-bar/build/loading-bar.js'
];

/*-------------- Compile vendor ----------------*/
gulp.task('copyVendor', function() {
	return gulp.src(srcVendor)
		.pipe(concat('vendor.js'))
		.pipe(gulp.dest('scripts/vendor/'));
});
/*----------------------------------------------*/

/*-------------- Compile app js ----------------*/
gulp.task('compileAppModuleJs', function() {
	return gulp.src(srcAppModuleJs)
		.pipe(concat('appModule.js'))
		.pipe(gulp.dest(destJs));
});

gulp.task('compileAppServiceJs', function() {
	return gulp.src(srcAppServiceJs)
		.pipe(concat('appService.js'))
		.pipe(gulp.dest(destJs));
});

gulp.task('compileAppLayoutJs', function() {
	return gulp.src(srcAppLayoutJs)
		.pipe(concat('appLayout.js'))
		.pipe(gulp.dest(destJs));
});
/*----------------------------------------------*/


gulp.task('watch', function() {
	gulp.watch(srcAppModuleJs, ['compileAppModuleJs']);
	gulp.watch(srcAppServiceJs, ['compileAppServiceJs']);
	gulp.watch(srcAppLayoutJs, ['compileAppLayoutJs']);
});

gulp.task('default', [
	'compileAppModuleJs',
	'compileAppServiceJs', 
	'compileAppLayoutJs', 
	'watch'
]);