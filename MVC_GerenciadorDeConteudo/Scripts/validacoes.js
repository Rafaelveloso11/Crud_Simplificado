var ValidaExclusao = function (id, evento) {

    if (confirm("Confirma exclusão?")) {
        return true;
    } else {
        evento.preventDefault();
        return false;
    }

}