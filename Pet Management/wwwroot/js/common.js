/*function : Check for valid date format*/
function checkDate(strDate) {
    var bRet = false;
    if (strDate != null) {
        var pattern = new RegExp(/\b\d{4}[\/]\d{1,2}[\/]\d{1,2}\b/);
        if (pattern.test(strDate)) {
            var arrDate = strDate.split('/');
            if (0 < arrDate[1] && arrDate[1] <= 12 && 0 < arrDate[2] && arrDate[2] <= 31) {
                bRet = true;
            }
        }
    }
    return bRet;
}