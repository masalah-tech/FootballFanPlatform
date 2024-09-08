window.addEventListener("load", (windowLoadEvent) => {
    main();

    (function(){
    var oldSelect2 = jQuery.fn.select2;
        jQuery.fn.select2 = function() {
            if (arguments.length === 1 && typeof arguments[0] === 'object' && typeof arguments[0].dropdownParent !== 'defined') {
                const modalParent = jQuery(this).parents('div.modal').first();
                if (modalParent.length > 0) {
                    arguments[0].dropdownParent = modalParent;
                }
            }
            return oldSelect2.apply(this,arguments);
        };
    })();

});

// Entry Point
async function main() {
    await initialize().then((value) => {
        applyEvents();
    });
}

async function initialize() {
    initializeSelect2Elements();
}

function applyEvents() {
    $(".modal").on("shown.bs.modal", function () {
        
        initialize();
    });
}

function initializeSelect2Elements() {
    $('.select2').each(function () {
        let $this = $(this);

        $this.select2({
            theme: "bootstrap-5",
            placeholder: 'Select an option',
        });
    });
}
