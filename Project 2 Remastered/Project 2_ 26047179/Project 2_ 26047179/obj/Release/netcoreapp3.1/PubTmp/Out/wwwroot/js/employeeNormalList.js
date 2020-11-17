var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    $.fn.dataTable.fixedHeader = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/Employee",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "age", "width": "30%" },
            { "data": "attrition", "width": "30%" },
            { "data": "businessTravel", "width": "30%" },
            { "data": "dailyRate", "width": "30%" },
            { "data": "department", "width": "30%" },
            { "data": "distanceFromHome", "width": "30%" },
            { "data": "education", "width": "30%" },
            { "data": "educationField", "width": "30%" },
            { "data": "employeeCount", "width": "30%" },
            { "data": "employeeNumber", "width": "30%" },
            { "data": "environmentSatisfaction", "width": "30%" },
            { "data": "gender", "width": "30%" },
            { "data": "hourlyRate", "width": "30%" },
            { "data": "jobInvolvement", "width": "30%" },
            { "data": "jobLevel", "width": "30%" },
            { "data": "jobRole", "width": "30%" },
            { "data": "jobSatisfaction", "width": "30%" },
            { "data": "maritalStatus", "width": "30%" },
            { "data": "monthlyIncome", "width": "30%" },
            { "data": "monthlyRate", "width": "30%" },
            { "data": "numCompaniesWorked", "width": "30%" },
            { "data": "over18", "width": "30%" },
            { "data": "overTime", "width": "30%" },
            { "data": "percentSalaryHike", "width": "30%" },
            { "data": "performanceRating", "width": "30%" },
            { "data": "relationshipSatisfaction", "width": "30%" },
            { "data": "standardHours", "width": "30%" },
            { "data": "stockOptionLevel", "width": "30%" },
            { "data": "totalWorkingYears", "width": "30%" },
            { "data": "trainingTimesLastYear", "width": "30%" },
            { "data": "workLifeBalance", "width": "30%" },
            { "data": "yearsAtCompany", "width": "30%" },
            { "data": "yearsInCurrentRole", "width": "30%" },
            { "data": "yearsSinceLastPromotion", "width": "30%" },
            { "data": "yearsWithCurrManager", "width": "30%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                    <a href="/Admin/DBAdministration/Edit?id=${data}" class='btn btn-success text-white' style='cursor:pointer; width:70px;'>
                        No Action Available
                    </a>
                    </div>`;
                }, "width": "40%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%", "scrollY": true,
        "scrollX": "true",
        "scrollCollapse": "true",
        "paging": "false"
    });
}

function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}
/*

   */
