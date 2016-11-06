/// <binding BeforeBuild='default' />
var gulp = require('gulp');
var concat = require('gulp-concat');

gulp.task('default', function () {
    // place code for your default task here
});

// For CLNDR to work, underscore and moment has to be loaded first.
gulp.task('scripts', function () {
    return gulp.src(['./Assets/JS/Underscore.js', './Assets/JS/Moment.js', './Assets/JS/CLNDR.js', './Assets/JS/demo.js'])
      .pipe(concat('driversapp.js'))
      .pipe(gulp.dest('./wwwroot/js/'));
});