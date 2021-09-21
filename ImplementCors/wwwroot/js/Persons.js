
//show char info
function show(nik) {
    $.ajax({
        url: "https://localhost:44300/api/persons/" + nik
    }).done((result) => {

        var roles = "";
        console.log(result);

        for (let i = 0; i < result.data.account.accountRoles.length; i++) {
            roles += `<li>${result.data.account.accountRoles[i].role.name}</li>`;
        }

        var genderIcon = "";
        if (result.data.gender == "Male") {
            genderIcon = ' <i class="fas fa-mars"></i>';
        } else {
            genderIcon = ' <i class="fas fa-venus"></i>';
        }

        var text = "";
        text += `
            <div>${result.data.nik}</div>
            <div>${result.data.firstName + " " + result.data.lastName}</div>
            <div>${result.data.gender} ${genderIcon}</div>
            <div>${result.data.email}</div>
            <div>(+62)${result.data.phone.slice(1, 99)}</div>
            <div>${moment(result.data.birthDate).format("dddd, MMMM Do YYYY")}</div>
            <div>Rp. ${result.data.salary.toLocaleString('it-IT')}</div>
            <div>${result.data.account.profiling.educations.universities.name}</div>
            <div>${result.data.account.profiling.educations.degree}</div>
            <div>${result.data.account.profiling.educations.gpa}</div>
            <div><ul>${roles}</ul></div>
        `
        $("#modal-data").html(text);
        $("#exampleModalLabel").html(result.data.firstName + " " + result.data.lastName + "'s Profile");
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