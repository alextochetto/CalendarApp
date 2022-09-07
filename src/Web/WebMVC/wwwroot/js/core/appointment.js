(function ($) {

    'use strict';

    $(document).ready(function () {
        //$('#modalAppointmentRegisterPartial').modal('show');
        $('#menuAppointment').on('click', function (e) {
            $('#modalAppointmentRegisterPartial').modal('show');
        });
        $('#modalAppointmentRegisterDatepicker').datepicker({
            format: 'dd/mm/yyyy',
            language: 'pt-BR'
        });
        var result = [{
            "text": "Group A",
            "children": [
                {
                    "id": 1,
                    "text": "Option 1.1"
                },
                {
                    "id": 2,
                    "text": "Option 1.2"
                }
            ]
        },
        {
            "text": "Group B",
            "children": [
                {
                    "id": 3,
                    "text": "Option 2.1"
                },
                {
                    "id": 4,
                    "text": "Option 2.2"
                }
            ]
        }
        ];
        $('#modalAppointmentRegisterPatient').select2({
            dropdownParent: $('#modalAppointmentRegisterPartial'),
            data: result
        });
    });

})(window.jQuery);

