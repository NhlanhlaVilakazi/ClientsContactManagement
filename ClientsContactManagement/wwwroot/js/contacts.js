var js = jQuery.noConflict(true);
js(document).ready(function () {
    LoadClientList();
});

function LoadClientList() {
    var clients = [];
    $.ajax({
        type: "GET",
        url: "/Contact/GetContacts",
        async: false,
        success: function (data) {
            $.each(data, function (key, value) {
                clients.push([value.firstName, value.lastName, value.emailAddress, value.numberOfLinkedClients]);
            })
        },
        failure: function (err) {
            console.log(err);
        }
    });

    if (clients.length === 0) {
        js("#alert").html("No Contact(s) found!").removeClass("d-none");
    }
    else {
        js("#tblContainer").removeClass("d-none");
        js("#tblContactList").DataTable({
            data: clients
        });

    }
}