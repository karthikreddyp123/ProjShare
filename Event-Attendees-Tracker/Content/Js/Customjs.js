

    google.charts.load("current", {packages: ["corechart"] });

    google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            var data = google.visualization.arrayToDataTable([

        ['Registered Students', 'Attended Students'],

        [' Approched', 100],

        [' Registered', 80],

        [' Attended', 70],

    ]);

            var options = {

        title: 'Event Details',

    is3D: true,

};

var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));

chart.draw(data, options);



var data1 = google.visualization.arrayToDataTable([

    ['Registered Students', 'Attended Students'],

    [' Event1', 0.2],

    [' Event2', 0.6],

    [' Event3', 0.3],

]);

            var options1 = {

        title: 'Each Event-Student Comparison',

                legend: {position: 'none' },

};

var chart1 = new google.visualization.Histogram(document.getElementById('chart_div'));

chart1.draw(data1, options1);

}

        $(function () {
            $("#accordion").accordion();
    });

