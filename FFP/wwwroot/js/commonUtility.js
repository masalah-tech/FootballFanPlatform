

// Shows the uploaded image in the UI
function updateProfileImage(senderElem, targetWrapper) {
    document.querySelector(targetWrapper)
        .querySelector('img').src = URL.createObjectURL(senderElem.files[0]);
}

// Hides/Shows password letters in a password input
function togglePassword(senderElem, event) {

    event.preventDefault(); // Prevent default button behavior
    event.stopPropagation(); // Stop event bubbling, avoid form validation triggering

    const activeElem = senderElem.querySelector(".active");
    const inactiveElem = senderElem.querySelector(":not(.active)");
    const inputElem = senderElem.parentElement.querySelector("input");

    activeElem.classList.remove("active");
    inactiveElem.classList.add("active");

    if (inputElem.getAttribute("type") === "password")
        inputElem.setAttribute("type", "text");
    else
        inputElem.setAttribute("type", "password");

    // Refocus the input to prevent validation trigger
    inputElem.focus();
}