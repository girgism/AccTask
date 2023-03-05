
// Write your JavaScript code.
$(document).ready(function () {
    $(".date-pick").datepicker({
        //format: 'yyyy',
        //viewMode: 'years',
        //minViewMode: 'years',
        autoclose: true,
        startDate: new Date('1750-01-01'),
        endDate: new Date()
    });
});
