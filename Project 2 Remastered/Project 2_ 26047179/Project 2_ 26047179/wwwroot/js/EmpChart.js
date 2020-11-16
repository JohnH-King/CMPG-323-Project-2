

$(function () {
    var ctx = document.getElementById("chartContainer").getContext('2d');

    var myChart = new CanvasJS.Chart("chartContainer", {

        type: 'pie',
        data: {
            labels: ["Green", "Blue", "Gray", "Purple",],
            datasets: [{
                backgroundColor: ["", "", "", ""],

            }]
        }

    });
});

   var ctx = document.getElementById('chartContainer').getContext('2d');

        var repArr = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.REP));
    var ages = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.AGES));
    var repArrC = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.REPC));
    var empCount = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.EMPCOUNT));

var data = {
    labels: ages,
    datasets: [{
      label: "My First dataset",
      fill: false,
      lineTension: 0,
      backgroundColor: "rgba(75,192,192,0.4)",
      borderColor: "rgba(75,192,192,1)",
      borderCapStyle: 'butt',
      borderDash: [],
      borderDashOffset: 0.0,
      borderJoinStyle: 'miter',
      pointBorderColor: "rgba(75,192,192,1)",
      pointBackgroundColor: "#fff",
      pointBorderWidth: 1,
      pointHoverRadius: 5,
      pointHoverBackgroundColor: "rgba(75,192,192,1)",
      pointHoverBorderColor: "rgba(220,220,220,1)",
      pointHoverBorderWidth: 2,
      pointRadius: 4,
      pointHitRadius: 10,
      data: repArrC,
    }]
  };

  var myChart = new Chart(ctx, {
    type: 'bar',
    data: data,
    options: {
      "horizontalLine": [{
        "y": 140,
        "style": "rgba(255, 0, 0, .4)",
      }, {
        "y": 120,
        "style": "#00ffff",
      }]
    }
  });
*/

/* working
 * window.onload = function () {
    var chart = new CanvasJS.Chart("chartContainer", {
        theme: "light2",
        animationEnabled: true,
        title: {
            text: "Simple Column Chart in ASP.NET MVC"
        },
        subtitles: [
            { text: "Try Resizing the Browser" }
        ],
        data: [
            {
                type: "bar", //change type to bar, line, area, pie, etc
                dataPoints: [
                    { x: 10, y: 71 },
                    { x: 20, y: 55 },
                    { x: 30, y: 50 },
                    { x: 40, y: 65 },
                    { x: 50, y: 95 },
                    { x: 60, y: 68 },
                    { x: 70, y: 28 },
                    { x: 80, y: 34 },
                    { x: 90, y: 14 }
                ]
            }
        ]
    });
    chart.render();
};*/







/*    var age = Model.Select(m => m.Age);
 * 
 * $(function () {
    var chartName = "chart";
    var ctx = document.getElementById(chartName).getContext('2d');
   // var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Select(x => x.Age).ToList());
   // var YValues = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Select(x => x.EmployeeCount).ToList());
    var data = {
        labels: XLabels,
    datasets: [{
        label: "Departments Chart",
        backgroundColor: [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)',
            'rgba(255, 206, 86, 0.2)',
            'rgba(75, 192, 192, 0.2)',
            'rgba(153, 102, 255, 0.2)',
            'rgba(255, 159, 64, 0.2)',
            'rgba(255, 0, 0)',
            'rgba(0, 255, 0)',
            'rgba(0, 0, 255)',
            'rgba(192, 192, 192)',
            'rgba(255, 255, 0)',
            'rgba(255, 0, 255)'
        ],
        borderColor: [
            'rgba(255,99,132,1)',
            'rgba(54, 162, 235, 1)',
            'rgba(255, 206, 86, 1)',
            'rgba(75, 192, 192, 1)',
            'rgba(153, 102, 255, 1)',
            'rgba(255, 159, 64, 1)',
            'rgba(255, 0, 0)',
            'rgba(0, 255, 0)',
            'rgba(0, 0, 255)',
            'rgba(192, 192, 192)',
            'rgba(255, 255, 0)',
            'rgba(255, 0, 255)'
        ],
        borderWidth: 1,
        data: YValues
}]
            };

var options = {
    maintainAspectRatio: false,
    scales: {
        yAxes: [{
            ticks: {
                min: 0,
                beginAtZero: true
            },
            gridLines: {
                display: true,
                color: "rgba(255,99,164,0.2)"
            }
        }],
        xAxes: [{
            ticks: {
                min: 0,
                beginAtZero: true
            },
            gridLines: {
                display: false
            }
        }]
    }
};

var myChart = new Chart(ctx, {
    options: options,
    data: data,
    type: 'bar'

});
        });







/*var riceData = {
    labels: ["January", "February", "March", "April", "May", "June"],
    datasets: [
        {
            fillColor: "rgba(172,194,132,0.4)",
            strokeColor: "#ACC26D",
            pointColor: "#fff",
            pointStrokeColor: "#9DB86D",
            data: [203000, 15600, 99000, 25100, 30500, 24700]
        }
    ]
}

var rice = document.getElementById('bar_chart').getContext('2d');
new Chart(rice).Line(riceData);


 *                 <script>
                    var repArr = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.REP));
var ages = @Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.AGES));

var ctx = document.getElementById('bar_chart').getContext('2d');// $("#bar_chart");
var barChart = new Chart(ctx, {

    type: 'bar',
    data: {
        labels: ages,
        datasets: [{
            label: "Bar Chart",
            data: repArr,
            backgroundColor: ["rgba(242,166,52,.5)", "rgba(145, 65, 72, .5)", "rgba(74, 25, 92, .5)"],
            borderColor: ["rgba(242,166,52)", "rgba(145, 65, 72,)", "rgba(74, 25, 92)"],
            borderWidth: 1
        }]
    },

    options: {


        scales: {
            xAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }


    }


});
                </script>*/