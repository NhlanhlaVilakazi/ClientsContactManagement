function HasErrors() {
    var hasError = false;
    if ($("#firstNameTxt").val() === "" || $("#firstNameTxt").val() === null || $("#firstNameTxt").val() === undefined) {
        hasError = true;
        $("#firstNameErrorLabel").html("First Name is required!");
    }
    else {
        $("#firstNameErrorLabel").html("");
    }

    if ($("#lastNameTxt").val() === "" || $("#lastNameTxt").val() === null || $("#lastNameTxt").val() === undefined) {
        hasError = true;
        $("#lastNameErrorLabel").html("Last Name is required!");
    }
    else {
        $("#lastNameErrorLabel").html("");
    }
    return hasError;
}


$("#add-client").click(function (){
    if (!HasErrors()) {
        debugger
        $("#addClientForm").submit();
        setTimeout(function () {
            $('#add-client').prop("disabled", true);
            $('#add-client').html('<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span> Loading...');
        }, 200);
    }
});