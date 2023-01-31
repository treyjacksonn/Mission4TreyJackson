// function for element with id calculate, used to calculate the grade average and letter grade
$("#calculate").click(function () {

    // assigns value of the weighted average for each grade category
    var assignment = $('#assignment').val() * .5;
    var group = $('#group').val() * .1;
    var quiz = $('#quizzes').val() * .1;
    var midterm = $('#midterm').val() * .1;
    var final = $('#final').val() * .1;
    var intex = $('#intex').val() * .1;

    // empty variable to hold calculated letter grade
    var grade = "";


    // calculates weighted average 
    var weightedAvg = parseFloat(assignment) + parseFloat(group) + parseFloat(quiz) +
        parseFloat(midterm) + parseFloat(final) + parseFloat(intex);

    // if statements to determine the letter grade earned 
    if (weightedAvg >= 94) {
        grade = 'A'
    }
    else if (weightedAvg < 94 && weightedAvg >= 90) {
        grade = 'A-'
    }
    else if (weightedAvg < 90 && weightedAvg >= 87) {
        grade = 'B+'
    }
    else if (weightedAvg < 87 && weightedAvg >= 84) {
        grade = 'B'
    }
    else if (weightedAvg < 84 && weightedAvg >= 80) {
        grade = 'B-'
    }
    else if (weightedAvg < 80 && weightedAvg >= 77) {
        grade = 'C+'
    }
    else if (weightedAvg < 77 && weightedAvg >= 74) {
        grade = 'C'
    }
    else if (weightedAvg < 74 && weightedAvg >= 70) {
        grade = 'C-'
    }
    else if (weightedAvg < 70 && weightedAvg >= 67) {
        grade = 'D+'
    }
    else if (weightedAvg < 67 && weightedAvg >= 64) {
        grade = 'D'
    }
    else if (weightedAvg < 64 && weightedAvg >= 60) {
        grade = 'D-'
    }
    else {
        grade = 'E'
    }

    // calls p tag on the html page to change to the show the calculated percentage and letter grade
    $('#finalGrade').text('Calculated Final Grade: ' + weightedAvg + '%, ' + grade)

})


