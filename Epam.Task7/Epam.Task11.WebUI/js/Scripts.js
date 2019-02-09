var addUserBtn = document.getElementById('addUser'),
    showUsersBtn = document.getElementById('showUsers'),
    delUserBtn = document.getElementById('delUser'),
    getUserbyIdBtn = document.getElementById('getUserById'),
    addAwardBtn = document.getElementById('addAward'),
    delAwardBtn = document.getElementById('delAward'),
    showAwardsBtn = document.getElementById('showAwards'),
    getAwardByIdBtn = document.getElementById('getAwardById'),
    addAwardToUserBtn = document.getElementById('addAwardToUser');


function redirect(url) {
    location = url;
}

addUserBtn.onclick = function () {
    redirect('/pages/AddUserPage.cshtml');
}

showUsersBtn.onclick = function () {
    redirect('/pages/ShowAllUsers.cshtml');
}

delUserBtn.onclick = function () {
    redirect('/pages/DeleteUser.cshtml');
}

getUserbyIdBtn.onclick = function () {
    redirect('/pages/GetUserById.cshtml');
}

addAwardBtn.onclick = function () {
    redirect('/pages/AddAward.cshtml');
}

delAwardBtn.onclick = function () {
    redirect('/pages/DeleteAward.cshtml');
}

showAwardsBtn.onclick = function () {
    redirect('/pages/ShowAwards.cshtml');
}

getAwardByIdBtn.onclick = function () {
    redirect('/pages/GetAwardById.cshtml');
}

addAwardToUserBtn.onclick = function () {
    redirect('/pages/AddAwardToUser.cshtml');
}
