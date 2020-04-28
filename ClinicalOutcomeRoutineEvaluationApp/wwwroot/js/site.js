function submitTest() {
    var childDivs = document.getElementsByClassName('input-group');
    var checkedRadioBtns = 0;
    console.log('hrgbfgbh');
    for (var i = 0; i < childDivs.length; i++) {
        if ($("input[name=radioanswer_" + i + "]:checked").val() >= 0) {
            checkedRadioBtns++;
        }
    }
    console.log('Number of checked radios');
    console.log(checkedRadioBtns);
    if (checkedRadioBtns === childDivs.length) {
        scoreW = 0;
        scoreF = 0;
        scoreR = 0;
        scoreP = 0;
        typeW = 0;
        typeF = 0;
        typeR = 0;
        typeP = 0;
        meanW = 0;
        meanF = 0;
        meanR = 0;
        meanP = 0;
        var score = 0;
        console.log(childDivs.length);
        for (i = 0; i < childDivs.length; i++) {
            var questionType = childDivs[i].getElementsByClassName('test').namedItem('QuestionType').getAttribute('value');
            var score = $("input[name=radioanswer_" + i + "]:checked").val();
            switch (questionType) {
                case "F":
                    scoreF += parseInt(score);
                    typeF++;
                    break;
                case "R":
                    scoreR += parseInt(score);
                    typeR++;
                    break;
                case "P":
                    scoreP += parseInt(score);
                    typeP++;
                    break;
                case "W":
                    scoreW += parseInt(score);
                    typeW++;
                    break;
                default:
                    text = "J'attends le week-end !";
            }
        }
        meanW = Math.floor(scoreW / typeW);
        meanF = Math.floor(scoreF / typeF);
        meanP = Math.floor(scoreP / typeP);
        meanR = Math.floor(scoreR / typeR);
        console.log(meanF);

        let scores = [];
        var scoreTypes = ["Bien-être", "Fonctionnement", "Risque", "Problèmes et Symptômes"];
        for (j = 0; j < scoreTypes.length; j++) {
            score = {};
            score.Type = scoreTypes[j];
            switch (score.Type) {
                case "Bien-être":
                    score.Total = scoreW;
                    break;
                case "Fonctionnement":
                    score.Total = scoreF;
                    break;
                case "Risque":
                    score.Total = scoreR;
                    break;
                case "Problèmes et Symptômes":
                    score.Total = scoreP;
                    break;
                default:
                    text = "J'attends le week-end !";
            }
            scores.push(score)
        }
        console.log(scores);
        //$(".lblchart").css("background-color", "blue");
        $("#w").show();
        $("#p").show();
        $("#f").show();
        $("#r").show();

        nv.addGraph(function () {
            var chart = nv.models.gaugeChart()
                .title('')
                .min(0)
                .max(4);

            d3.select('#gauge-chart-r svg')
                .datum([meanR])
                .call(chart);

            nv.utils.windowResize(chart.update);
            return chart;
        });

        nv.addGraph(function () {
            var chart = nv.models.gaugeChart()
                .title('')
                .min(0)
                .max(4);

            d3.select('#gauge-chart-f svg')
                .datum([meanF])
                .call(chart);

            nv.utils.windowResize(chart.update);
            return chart;
        });

        nv.addGraph(function () {
            var chart = nv.models.gaugeChart()
                .title('')
                .min(0)
                .max(4);

            d3.select('#gauge-chart-w svg')
                .datum([meanW])
                .call(chart);

            nv.utils.windowResize(chart.update);
            return chart;
        });

        nv.addGraph(function () {
            var chart = nv.models.gaugeChart()
                .title('')
                .min(0)
                .max(4);

            d3.select('#gauge-chart-p svg')
                .datum([meanP])
                .call(chart);

            nv.utils.windowResize(chart.update);
            return chart;
        });



    }
    else {
        alert('Vous devez repondre a toutes les questions');
    }





}

$(document).ready(function () {
    $("#w").hide();
    $("#p").hide();
    $("#f").hide();
    $("#r").hide();
});



