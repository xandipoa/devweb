
$(document).ready(function () {

    if (document.getElementById("gridBeneficiarios"))
        $('#gridBeneficiarios').jtable({
            title: 'Beneficiarios',
            paging: true, //Enable paging
            pageSize: 5, //Set page size (default: 10)
            sorting: true, //Enable sorting
            defaultSorting: 'Nome ASC', //Set default sorting
            actions: {
                listAction: urlBeneficiarioList,
            },
            fields: {
                CPF: {
                    title: 'CPF',
                    width: '30%'
                },
                Nome: {
                    title: 'Nome',
                    width: '40%'
                },
                Alterar: {
                    title: '',
                    display: function (data) {
                        return '<button onclick="window.location.href=\'' + urlAlteracao + '/' + data.record.Id + '\'" class="btn btn-primary btn-sm">Alterar</button>';
                    }
                },
                Excluir: {
                    title: '',
                    display: function (data) {
                        return '<button onclick="window.location.href=\'' + urlExclusao + '/' + data.record.Id + '\'" class="btn btn-primary btn-sm">Excluir</button>';
                    }
                }
            }
        });

    //Load student list from server
    if (document.getElementById("gridBeneficarios"))
        $('#gridBeneficarios').jtable('load');
})