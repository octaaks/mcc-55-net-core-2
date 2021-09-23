


//show char info
function show(nik) {
    $.ajax({
        url: "/persons/getpersonbyid/" + nik
    }).done((result) => {

        console.log(result);

        var gender = "";
        var genderIcon = "";

        if (result.gender == 0) {
            gender = "Male"
            genderIcon = ' <i class="fas fa-mars"></i>';
        } else {
            gender = "Female"
            genderIcon = ' <i class="fas fa-venus"></i>';
        }

        var text = "";
        text += `
            <div>${result.nik}</div>
            <div>${result.firstName + " " + result.lastName}</div>
            <div>${gender} ${genderIcon}</div>
            <div>${result.email}</div>
            <div>(+62)${result.phone.slice(1, 99)}</div>
            <div>${moment(result.birthDate).format("dddd, MMMM Do YYYY")}</div>
            <div>Rp. ${result.salary.toLocaleString('it-IT')}</div>
            <div>${result.universityId}</div>
            <div>${result.degree}</div>
            <div>${result.gpa}</div>
            <div>${result.roles}</div>
        `
        $("#modal-data").html(text);
        $("#exampleModalLabel").html(result.firstName + " " + result.lastName + "'s Profile");
    }).fail((result) => {
        console.log(result);
    });
}

//delete char
function deletePerson(nik) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {

            $.ajax({
                url: "/persons/deleteperson/" + nik,
                method: 'DELETE',
                dataType: 'json',
                contentType: 'application/json',
                success: function (xhr, status, error) {
                    var err = eval(xhr.responseJSON);
                    console.log(err);

                    mt.ajax.reload(function (json) {
                        $('#table_id').val(json.lastInput);
                    });

                    Swal.fire(
                        'Deleted!',
                        'Your file has been deleted.',
                        'success'
                    )
                },
                error: function (xhr, status, error) {
                    var err = eval(xhr.responseJSON);
                    console.log(err);
                }
            });
        }
    })
}