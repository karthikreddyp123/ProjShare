
    $(document).ready(function () {

        $('#poster-upload').change(function (e) {

            var fileName = e.target.files[0].name;

            $("#file-name").html(fileName)

        });
            $('#file-upload').change(function (e) {

                var fileName = e.target.files[0].name;

    $("#file-name1").html(fileName)

});

});

   
        function checkfile(sender) {
            var validExts = new Array(".xlsx", ".xls", ".csv");
        var fileExt = sender.value;
        fileExt = fileExt.substring(fileExt.lastIndexOf('.'));
            if (validExts.indexOf(fileExt) < 0) {
            alert("Invalid file selected, valid files are of " +
                validExts.toString() + " types.");
    return false;
}
else return true;
}
  