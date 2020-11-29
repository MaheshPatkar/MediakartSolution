
$(document).ready(function () {
    $('#SubmitButton').click(function () {

        debugger;

        let validationFailed = false;
        var errormessages = [];
        $("#ValidationSummary").empty()
        var email = $('#YourEmail').val();
        var phoneNumber = $('#PhoneNumber').val();

        if ($('#FirstName').val() == "") {
            validationFailed = true;
            errormessages.push("FirstName is required");
        }

        if ($('#LastName').val() == "") {
            validationFailed = true;
            errormessages.push("LastName is required");
        }

        if (email == "") {
            validationFailed = true;
            errormessages.push("Your Email is required");
        }
        else if (!testEmailAddress(email)) {

            validationFailed = true;
            errormessages.push("Email is not in the correct format");
        }

        if (phoneNumber == "") {
            validationFailed = true;
            errormessages.push("Your PhoneNumber is required");
        }
        else if (!ValidatePhoneNumber(phoneNumber)) {

            validationFailed = true;
            errormessages.push("Please enter a valid 10 digit Phone Number");
        }

        if (validationFailed) {
            //alert(errormessages);
            errormessages.forEach(function (item, index) {

                $("#ValidationSummary").append('<li>' + item + '</li>');
            })

            $('#ValidationSummary').css("color", "red");
            return false;

        }
    })
})

function testEmailAddress(emailToTest)
{
    var atSymbol = emailToTest.indexOf("@");
    if (atSymbol < 1) return false;

    var dot = emailToTest.indexOf(".");
    if (dot <= atSymbol + 2) return false;

    // check that the dot is not at the end
    if (dot === emailToTest.length - 1) return false;

    return true;
}

function ValidatePhoneNumber(phoneNumber) {
    var pattern = /^[6-9]\d{9}$/;
    return pattern.test(phoneNumber)

}
