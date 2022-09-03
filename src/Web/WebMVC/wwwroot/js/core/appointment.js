(function ($) {

    'use strict';

    $(document).ready(function () {
        //$('#modalAppointmentRegisterPartial').modal('show');
        $('#menuAppointment').on('click', function (e) {
            $('#modalAppointmentRegisterPartial').modal('show');
        });
        $('#modalAppointmentRegisterDatepicker').datepicker();
    });

})(window.jQuery);

