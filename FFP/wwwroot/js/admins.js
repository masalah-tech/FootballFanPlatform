

updateTable();

function updateTable() {

    console.log(`aaaaaaaaaaa`);

    $('#dtlist').DataTable({
        "processing": true,
        "serverSide": true,
        "ajax": {
            "url": "/controlPanel/admin/getTableData",
            "type": "POST",
            "dataSrc": function (json) {
                return json.data;
            }
        },
        "columns": [
            { "data": "id" },
            {
                "data": "profilePhotoPath",
                render: function (data, type, row) {
                    return `<img src="${data}" alt="${row.firstName}" class="circular-user-photo" />`;
                }
            },
            { "data": "name" },
            { "data": "role" },
            { "data": "username" },
            { "data": "password" },
            {
                "data": "status",
                render: function (data) {
                    return data ? `<span class="text-success">Active</span>` : `<span class="text-danger">Inactive</span>`;
                }
            },
            {
                "data": "id",
                render: function (data, type, row) {
                    return `<div class="dropdown">
                                        <a class="fs-5 link-dark d-flex justify-content-center p-0 w-100" href="#" role="button" id="dropdownMenuLink" data-bs-toggle="dropdown" aria-expanded="false">
                                            <i class="fa-solid fa-ellipsis-vertical"></i>
                                        </a>

                                        <ul class="dropdown-menu" aria-labelledby="dropdownMenuLink">
                                            <li><a class="dropdown-item">Show details</a></li>
                                            <li><a class="dropdown-item">Edit details</a></li>
                                            <li>
                                                <a class="dropdown-item" href="#">
                                                    ${row.status ? "<span>Deactivate the admin</span>" : "<span>Activate the admin</span>"}
                                                </a>
                                            </li>
                                            <li><a class="dropdown-item link-danger" href="#">Delete the admin</a></li>
                                        </ul>
                                    </div>`;
                }
            },
        ],
        "columnDefs": [
            {
                "targets": [1, 7],
                "orderable": false
            },
        ],
        "order": [[0, "desc"]],
        "initComplete": function (settings, json) {
            const tableWrapper =
                document.querySelector("div:has(> #dtlist)");

            tableWrapper.classList.add("c-scroll");
            tableWrapper.classList.add("c-x-scroll");
        },
    });
}

function showUpsertModal(id = 0) {
    $(`#addAdminModal`).modal(`show`);
    $(`#addAdminModal .modal-title`).html("Add New Admin");

    $(`#addAdminModal .modal-body`).html(`<div class="loader"><div class="dots"></div></div>`);
    $(`#addAdminModal .modal-body`).load("/controlPanel/admin/Upsert" + (id !== null && id !== undefined ? `?id=${id}` : ""),
        function (responseText, textStatus, XMLHttpRequest) {
            if (textStatus == "success") {

            }
            else {
                console.log(`Something went wrong while fetching data`);
            }
        });
}

function handleUpsertSubmit(senderForm, event) {

    event.preventDefault();

    if (!$(senderForm).valid()) {
        return;
    }

    $(`#addAdminModal .modal-body`).html(`<div class="loader"><div class="dots"></div></div>`);

    const formData = new FormData(senderForm);

    console.log(formData);

    $.ajax({
        method: "post",
        url: "/controlPanel/admin/Upsert",
        processData: false,
        contentType: false,
        data: formData,
        success: function (data) {

            if (data.success) {
                console.log(data.message);
            }

            $(`#addAdminModal`).modal(`hide`);
            loadTable();
        },
        error: function (error) {
            console.log(error);
            console.log(`Something went wrong while trying to send the request`);
            $(`#addAdminModal`).modal(`hide`);
            loadTable();
        }
    });
}