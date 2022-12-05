var js = jQuery.noConflict(true);
js(document).ready(function () {
    LoadClientList();
});

function LoadClientList() {
    debugger
    var clients = [];
    $.ajax({
        type: "GET",
        url: "/Client/GetClients",
        async: false,
        success: function (data) {
            $.each(data, function (key, value) {
                clients.push([value.code, value.name, 0]);
            })
        },
        failure: function (err) {
            console.log(err);
        }
    });

    if (clients.length === 0) {
        js("#alert").html("No Client(s) found!").removeClass("d-none");
    }
    else {
        js("#tblContainer").removeClass("d-none");
        js("#tbllist").DataTable({
            data: clients
        });

    }
}