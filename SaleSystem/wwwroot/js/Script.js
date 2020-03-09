$(document).ready(() => {
    $(document).on('click', '#LogOut', () => {
        Swal.fire({
            //title: 'Desea Salir?',
            text: "Cerrar Sessión?",
            type: 'question',
            showCancelButton: true,
            confirmButtonColor: '#17a2b8',
            cancelButtonColor: '#dc3545',
            confirmButtonText: 'Si',
            cancelButtonText: 'No'
        }).then((result) => {
            if (result.value) location.href = '/Login';
        })
    });
    
});