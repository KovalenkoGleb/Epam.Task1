var addUserBtn = document.getElementById('addUser'),
    SbmtUser = document.getElementById('SubmitUser');
//    urls = ['~/pages/AddUserPage.cshtml']

function redirect(url) {
    location = url;
}

addUserBtn.onclick = function () {
    redirect('/pages/AddUserPage.cshtml');
}

SbmtUser.onclick = function () {
    
}




