var addUserBtn = document.getElementById('addUser'),
    showUsersBtn = document.getElementById('showUsers'),
    delUserBtn = document.getElementById('delUser'),
    getUserbyIdBtn = document.getElementById('getUserById'),
    addAwardBtn = document.getElementById('addAward'),
    delAwardBtn = document.getElementById('delAward'),
    showAwardsBtn = document.getElementById('showAwards'),
    getAwardByIdBtn = document.getElementById('getAwardById'),
    addAwardToUserBtn = document.getElementById('addAwardToUser'),
    changeUserPicBtn = document.getElementById('changeUserPic'),
    changeAwardPicBtn = document.getElementById('changeAwardPic');


function redirect(url) {
    location = url;
}

showUsersBtn.onclick = function () {
    redirect('/pages/ShowAllUsers.cshtml');
}

addUserBtn.onclick = function () {
    redirect('/pages/AddUserPage.cshtml');
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

addAwardToUserBtn.onclick = function () {
    redirect('/pages/AddAwardToUser.cshtml');
}


changeUserPicBtn.onclick = function () {
    redirect('/pages/UserPicChange.cshtml');
}

changeAwardPicBtn.onclick = function () {
    redirect('/pages/AwardPicChange.cshtml');
}