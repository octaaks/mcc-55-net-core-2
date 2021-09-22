
//show char info
function show(nik) {
    $.ajax({
        url: "https://localhost:44300/api/persons/" + nik
    }).done((result) => {

        var roles = "";
        console.log(result);

        for (let i = 0; i < result.account.accountRoles.length; i++) {
            roles += `<li>${result.account.accountRoles[i].role.name}</li>`;
        }

        var genderIcon = "";
        if (result.gender == "Male") {
            genderIcon = ' <i class="fas fa-mars"></i>';
        } else {
            genderIcon = ' <i class="fas fa-venus"></i>';
        }

        var text = "";
        text += `
            <div>${result.nik}</div>
            <div>${result.firstName + " " + result.lastName}</div>
            <div>${result.gender} ${genderIcon}</div>
            <div>${result.email}</div>
            <div>(+62)${result.phone.slice(1, 99)}</div>
            <div>${moment(result.birthDate).format("dddd, MMMM Do YYYY")}</div>
            <div>Rp. ${result.salary.toLocaleString('it-IT')}</div>
            <div>${result.account.profiling.educations.universities.name}</div>
            <div>${result.account.profiling.educations.degree}</div>
            <div>${result.account.profiling.educations.gpa}</div>
            <div><ul>${roles}</ul></div>
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
                url: 'https://localhost:44300/api/persons/' + nik,
                method: 'DELETE',
                dataType: 'json',
                contentType: 'application/json',
                success: function () {
                },
                error: function (xhr, status, error) {
                    var err = eval(xhr.responseJSON);
                    console.log(err.message);
                }
            });

            Swal.fire(
                'Deleted!',
                'Your file has been deleted.',
                'success'
            )

            mt.ajax.reload(function (json) {
                $('#table_id').val(json.lastInput);
            });
        }
    })
}