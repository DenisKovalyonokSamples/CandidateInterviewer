/// <binding BeforeBuild='build' Clean='build' />
"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    rename = require("gulp-rename"),
    sass = require("gulp-sass"),
    npmDist = require('gulp-npm-dist'),
    autoprefixer = require('gulp-autoprefixer');

var paths = {
    webroot: "./wwwroot/",
    outputCss: "styles.min.css",
    outputJs: "scripts.js",
    outputMinJs: "scripts.min.js",
    outputLibsMinJs: "external-libs.min.js",
    outputLibsMinCss: "external-libs.min.css"
};

paths.scssRoot = paths.webroot + "sass/";
paths.cssRoot = paths.webroot + "css/";
paths.jsRoot = paths.webroot + "js/";

paths.js = paths.jsRoot + '*.js';
paths.minJs = paths.jsRoot + '*.min.js';
paths.concatJs = paths.jsRoot + paths.outputJs;
paths.concatMinJs = paths.jsRoot + paths.outputMinJs;

paths.libs = paths.jsRoot + "/libs/";
paths.libsCss = paths.cssRoot + "/libs/";

paths.copyLibs = [
    "./node_modules/jquery-ajax-unobtrusive/jquery.unobtrusive-ajax.js",
    "./node_modules/material-design-lite/material.min.js"
];
paths.copyLibsCss = [
    "./node_modules/material-design-lite/dist/material.indigo-pink.min.css"
];

gulp.task("build", ['clean'], function (ev) {
    gulp.start('get:assets');
});

gulp.task('clean', ["clean:css", "clean:minjs", "clean:concatjs", "clean:libs"]);
gulp.task('get:assets', ["min:css", "min:js", "copy:libs", "copy:libs-css"]);

gulp.task("clean:css", function (cb) {
    return rimraf(paths.cssRoot + paths.outputCss, cb);
});

gulp.task("clean:minjs", function (cb) {
    return rimraf(paths.concatMinJs, cb);
});

gulp.task("clean:concatjs", function (cb) {
    return rimraf(paths.concatJs, cb);
});

gulp.task("clean:libs", function (cb) {
    return rimraf(paths.libs, cb);
});

gulp.task("min:css", function () {
    return gulp.src(paths.scssRoot + 'bundled.scss')
        .pipe(concat('all.scss'))
        .pipe(sass().on('error', sass.logError))
        .pipe(autoprefixer())
        .pipe(rename(paths.outputCss))
        .pipe(cssmin())
        .pipe(gulp.dest(paths.cssRoot));
});

gulp.task("min:js", function () {
    return gulp.src([paths.js, "!" + paths.minJs])
        .pipe(concat(paths.outputJs))
        .pipe(gulp.dest(paths.jsRoot))
        .pipe(uglify()).on('error', function (err) { console.log(err); })
        .pipe(rename(paths.outputMinJs))
        .pipe(gulp.dest(paths.jsRoot));
});

gulp.task("copy:libs", function () {
    return gulp.src(paths.copyLibs)
        .pipe(concat(paths.outputLibsMinJs))
        .pipe(uglify())
        .pipe(gulp.dest(paths.libs));
});

gulp.task("copy:libs-css", function () {
    return gulp.src(paths.copyLibsCss)
        .pipe(concat(paths.outputLibsMinCss))
        .pipe(cssmin())
        .pipe(gulp.dest(paths.libsCss));
});