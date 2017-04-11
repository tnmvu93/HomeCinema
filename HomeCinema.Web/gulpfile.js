'use strict';

var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var rename = require('gulp-rename');

var baseDir = {
	vendor: [
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
	],
	src: [
		'scripts/spa/**/*.js',
		'!scripts/spa/modules/*.js',
	],
	module: [
		'scripts/spa/modules/*.js',
	],
	dest: 'scripts/dest/'
};


/*-------------- Copy vendor ----------------*/
gulp.task('copyVendor', function() {
	return gulp.src(baseDir.vendor)
		.pipe(concat('vendor.js'))
		.pipe(gulp.dest(baseDir.dest));
});
/*----------------------------------------------*/

gulp.task('buildModuleJs', function() {
	return gulp.src(baseDir.module)
		.pipe(concat('module.js'))
		.pipe(gulp.dest(baseDir.dest));
});

gulp.task('buildAppJs', function() {
	return gulp.src(baseDir.src)
		.pipe(concat('app.js'))
		.pipe(gulp.dest(baseDir.dest));
});


gulp.task('watch', ['buildModuleJs', 'buildAppJs'], function() {
	gulp.watch(baseDir.module, ['buildModuleJs']);
	gulp.watch(baseDir.src, ['buildAppJs']);
});

gulp.task('default', ['copyVendor', 'watch']);