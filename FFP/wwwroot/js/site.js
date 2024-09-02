window.addEventListener("load", windowLoadEvent => {
    main();
});

// Entry Point
async function main() {
    await intialize().then(value => {
        applyEvents();
        //mznApplyEvents();
        applyUtilities();
        enableBootstrapTooltips();
    })
}

// intialize() applies some initial settings such as
//      local storage items and layout preferences
async function intialize() {
    const response = await fetch("/json/countries.json");
    const countries = await response.json();
    let counter = 0;

    $('#addAdminModal').on('shown.bs.modal', function () {
        main();
        $('.select2').select2({
            theme: "bootstrap-5",
            placeholder: 'Select an option',
        });
    });

    document.querySelectorAll(".countries-dropdown").forEach(elemCountries => {
        for (let country of countries) {
            elemCountries.innerHTML += `<option value="${country['code']}">${country['name']}</option>`;
        }
    });

}


// applyEvents() is the only function that applies events
//      on various HTML elements
function applyEvents() {
    const iElements = document.querySelectorAll("i");
    const textInputs = document.querySelectorAll("input[type=text]");
    const buttonElements = document.querySelectorAll("button");
    const fileInputs = document.querySelectorAll("input[type=file]");

    window.addEventListener("click", windowClickEvent => {
        const searchForm = document.querySelector("#search-form");
        const searchPredictionsContainer = document.querySelector("#search-items-container");
        const activateSearchBtn = document.querySelector("#activate-search-btn");
        const clearSearchBtn = document.querySelector("#clear-search-btn");

        if (searchForm != null && !searchForm.contains(windowClickEvent.target)
            && !searchPredictionsContainer.contains(windowClickEvent.target)
            && !activateSearchBtn.contains(windowClickEvent.target)
            && !clearSearchBtn.contains(windowClickEvent.target)) {

            hideSearchPredictions();
        }
    });

    window.addEventListener("scroll", bodyScrollEvent => {
        const header = document.querySelector("#primary-header");
        if (header != null) {
            if (window.scrollY > 20)
                header.classList.add("shadow");
            else
                header.classList.remove("shadow");
        }
    });

    iElements.forEach(iElement => {
        iElement.addEventListener("click", iElementClickEvent => {
            if (iElement.classList.contains("activate-search-btn")) {
                activateSearchMode();
            }

            if (iElement.classList.contains("deactivate-search-btn")) {
                deactivateSearchMode();
            }

            if (iElement.classList.contains("clear-search-btn"))
            {
                clearSearchField();
                deactivateSearchTypingMode();
            }

            if (iElement.classList.contains("show-pass-btn")) {
                const outerBox = iElement.parentElement.parentElement;

                showPassText(outerBox);
            }
            else if (iElement.classList.contains("hide-pass-btn")) {
                const outerBox = iElement.parentElement.parentElement;

                hidePassText(outerBox);
            }
        });
    })

    textInputs.forEach(textInput => {
        textInput.addEventListener("keyup", textInputKeyUpEvent => {
            if (textInput.classList.contains("search-field")) {
                if (textInput.value == "")
                    deactivateSearchTypingMode();
                else
                    activateSearchTypingMode();
            }
        });

        textInput.addEventListener("focus", textInputFocusEvent => {
            if (textInput.classList.contains("search-field")) {
                showSearchPredictions();
            }
        })
    });

    buttonElements.forEach(buttonElement => {
        buttonElement.addEventListener("click", buttonElementClickEvent => {
            if (buttonElement.classList.contains("open-sidenav-btn")) {
                document.querySelector("#sidenav").classList.add("active");
            }
            if (buttonElement.classList.contains("close-sidenav-btn")) {
                document.querySelector("#sidenav").classList.remove("active");
            }

        });
    });

    fileInputs.forEach(fileInput => {

        if (fileInput.classList.contains("editable-profile-photo")) {
            fileInput.addEventListener("change", fileInputsChangeEvent => {
                const outerBox = fileInput.parentElement;
                outerBox.querySelector("img").src = URL.createObjectURL(fileInput.files[0]);
            });
        }

    });
}

// applyUtilities() is the only function that applies scripts
//      required for external utilities such as bootstrap 
//      carosal.
function applyUtilities() {
    setProductSliderProperties();
}

// enableBootstrapTooltips() enables Bootstrap classes that are
//      used to create tooltips
function enableBootstrapTooltips() {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl)
    })
}

// activateSearchMode() adds the class attribute "search-mode"
//      to the page primary header. This class is used in CSS
//      to control the child elements
function activateSearchMode() {
    document.querySelector("#primary-header").classList.add("search-mode");
    document.querySelector("#search-field").focus();
}

// deactivateSearchMode() removes the class attribute "search-mode"
//      from the page primary header. This class is used in CSS
//      to control the child elements
function deactivateSearchMode() {
    document.querySelector("#primary-header").classList.remove("search-mode");
}

// activateSearchTypingMode() adds the class "typing" to the
//      search functionality container. This class is used in CSS
//      to control the child elements
function activateSearchTypingMode() {
    document.querySelector("#search-functionality").classList.add("typing");
}

// deactivateSearchTypingMode() removes the class "typing" from the
//      search functionality container. This class is used in CSS
//      to control the child elements
function deactivateSearchTypingMode() {
    document.querySelector("#search-functionality").classList.remove("typing");
}

// clearSearchField() resets the value of the search
//      text input
function clearSearchField() {
    document.querySelector("#search-field").value = "";
    document.querySelector("#search-field").focus();
}

// showSearchPredictions() shows the search predictions that
//      appear right under the search text field input
function showSearchPredictions() {
    document.querySelector("#search-items-container").classList.add("active");
}

// hideSearchPredictions() hides the search predictions that
//      appear right under the search text field input
function hideSearchPredictions() {
    document.querySelector("#search-items-container").classList.remove("active");
}

// setProductSliderProperties() applies some properties on
//      the product slider
function setProductSliderProperties() {
    $('.product-slider .carousel-item').each(function () {
        var minPerSlide = 4;
        var next = $(this).next();
        if (!next.length) {
            next = $(this).siblings(':first');
        }
        next.children(':first-child').clone().appendTo($(this));

        for (var i = 0; i < minPerSlide; i++) {
            next = next.next();

            if (!next.length)
                next = $(this).siblings(':first');

            next.children(':first-child').clone().appendTo($(this));
        }
    });
}

// showPassText(outerBox) replaces the dots in the password
//      input field with the actual text
function showPassText(outerBox) {
    const input = outerBox.querySelector("input")

    input.setAttribute("type", "text");
    outerBox.querySelector(".show-pass-btn").classList.remove("active");
    outerBox.querySelector(".hide-pass-btn").classList.add("active");

    input.focus();
}

// hidePassText(outerBox) replaces the text in the password
//      input field with dots
function hidePassText(outerBox) {
    const input = outerBox.querySelector("input");

    input.setAttribute("type", "password");
    outerBox.querySelector(".hide-pass-btn").classList.remove("active");
    outerBox.querySelector(".show-pass-btn").classList.add("active");

    input.focus();
}