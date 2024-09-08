

// Shows the uploaded image in the UI
function updateProfileImage(senderElem, targetWrapper) {
    document.querySelector(targetWrapper)
        .querySelector('img').src = URL.createObjectURL(senderElem.files[0]);
}