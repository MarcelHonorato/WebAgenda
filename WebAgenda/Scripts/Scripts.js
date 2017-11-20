
function formatDate(htmlDateTime) {

    var htmlDateTimeParts = htmlDateTime.split(" ");

    var htmlDateParts = htmlDateTimeParts[0].split("/");
    var htmlTimeParts = htmlDateTimeParts[1].split(":");

    var day = htmlDateParts[0]
    var month = htmlDateParts[1]
    var year = htmlDateParts[2]

    var hours = htmlTimeParts[0]
    var minutes = htmlTimeParts[1]
    var seconds = htmlTimeParts[2]

    return year + '-' + month + '-' + day + 'T' + hours + ':' + minutes + ':' + seconds;

}


