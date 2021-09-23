function register(event) {
    event.preventDefault();

    var fields = [
        document.getElementsByTagName("input")
    ];
    for (var i = 0; i < fields.length; i++) {
        if (fields[i].value == "") {
            fields[i].placeholder == "Tidak boleh kosong"
            console.log(fields[i].placeholder);
        }
    };
    //var data = $('.form-data').serialize();
    var nik = document.getElementById("inputNik").value;
    //if (nik == "") {
    //    $('#invalid-nik').html('Please insert your NIK!');
    //}
    var firstName = document.getElementById("inputFirstName").value;
    var lastName = document.getElementById("inputLastName").value;
    var email = document.getElementById("inputEmail").value;
    var password = document.getElementById("inputPassword").value;
    var phone = document.getElementById("inputPhone").value;
    var genders = document.getElementsByName("gender");
    for (var i = 0; i < genders.length; i++) {
        if (genders[i].checked) {
            var gender = genders[i].value;
        }
    }
    console.log("gender: " + gender);
    var phone = document.getElementById("inputPhone").value;
    //var birthDate = "1911-11-11T00:00:00";
    var birthDate = document.getElementById("inputBirthDate").value;
    var salary = document.getElementById("inputSalary").value;
    var university = document.getElementById("inputUniversity").value;
    var degree = document.getElementById("inputDegree").value;
    var gpa = document.getElementById("inputGpa").value;

    //var dataInput = {
    //    "NIK": nik,
    //    "FirstName": firstName,
    //    "LastName": lastName,
    //    "Phone": phone,
    //    "BirthDate": birthDate,
    //    "Gender": parseInt(gender),
    //    "Salary": parseInt(salary),
    //    "Email": email,
    //    "Password": password,
    //    "Degree": degree,
    //    "GPA": gpa,
    //    "UniversityId": parseInt(university)
    //};

    var dataInput = {
        "NIK": $('#inputNik').val(),
        "FirstName": $('#inputNik').val(),
        "LastName": $('#inputNik').val(),
        "Phone": $('#inputNik').val(),
        "BirthDate": $('#inputNik').val(),
        "Gender": parseInt($('#inputNik').val()),
        "Salary": parseInt($('#inputNik').val()),
        "Email": $('#inputNik').val(),
        "Password": $('#inputNik').val(),
        "Degree": $('#inputNik').val(),
        "GPA": $('#inputNik').val(),
        "UniversityId": parseInt($('#inputNik').val())
    };

    var json = JSON.stringify(dataInput);
    console.log(json);

    var dataObject = JSON.stringify(
        {
            'nik': '907',
            'firstName': 'Atta',
            'lastName': "Thunder",
            'phone': "05644712",
            'birthDate': "1911-11-11T00:00:00",
            'gender': 0,
            'salary': 999999999,
            'email': "dsadas@gmail.com",
            'password': "root",
            'degree': "Prank Master",
            'GPA': "0.1",
            'UniversityId': 1
        });

    $.ajax({

        //url: '/persons/register',
        //method: 'POST',
        //dataType: 'json',
        //contentType: 'application/json',
        //data: JSON.stringify(dataInput),
        //success: function (data) {
        //    console.log(data);
        //    $('#contactform')[0].reset();
        //    $('#registerModal').modal('toggle');
        //    Swal.fire(
        //        'Good job!',
        //        'success'
        //    );
        //    mt.ajax.reload(function (json) {
        //        $('#table_id').val(json.lastInput);
        //    });
        //    //location.reload();
        //},
        //error: function (xhr, status, error) {
        //    var err = eval(xhr.responseJSON);
        //    console.log(err);
        //    Swal.fire({
        //        icon: 'error',
        //        title: 'Oops...',
        //        text: 'Something went wrong!',
        //    });
        //}

        url: '@Url.Action("Register", "Persons")',
        type: "POST",
        contentType: 'application/json',
        dataType: "JSON",
        data: dataObject,

    }).done((result) => {
        console.log(result);
        $('#contactform')[0].reset();
        $('#registerModal').modal('toggle');
        Swal.fire(
            'Good job!',
            'success'
        );
        mt.ajax.reload(function (json) {
            $('#table_id').val(json.lastInput);
        });
    }).fail((result) => {
        console.log(result);
    });
};