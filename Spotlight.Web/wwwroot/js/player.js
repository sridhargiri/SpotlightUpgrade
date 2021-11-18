$(document).ready(function () {
    $("#grid").kendoGrid({
        toolbar: ["excel"],
        dataSource: {
            type: "json",
            transport: {
                read: "https://localhost:44320/Report"
            },
            pageSize: 20

        },
        pageable: {
            refresh: true,
            pageSizes: [50, 100, 200, "all"],
        },
        columnMenu: true,
        columns: [{
            field: "playerId",
            title: "Player Id",
            width: 100
        }, {
            field: "externalId",
            title: "Universal Id"
        }, {
            field: "firstName",
            width: 100
        }, {
            field: "lastName",
            title: "Last name",
            width: 100
        }, {
            field: "hostName",
            title: "Host Name",
            width: 100
        }, {
            field: "playerType",
            title: "Player Type",
            width: 100
        }, {
            field: "Address",
            title: "address",
            width: 100
        }, {
            field: "state",
            title: "State",
            width: 100
        }, {
            field: "city",
            title: "City",
            width: 100
        }, {
            field: "zip",
            title: "Zip",
            width: 100
        }, {
            field: "allowMail",
            title: "Allow Mail",
            width: 100
        }, {
            field: "tier",
            title: "Tier",
            width: 100
        }, {
            field: "phone",
            title: "Phone",
            width: 100
        }, {
            field: "alternativePhone",
            title: "Alternative Phone",
            width: 100
        }, {
            field: "emailAddress",
            title: "EmailAddress",
            width: 150
        }, {
            field: "status",
            title: "Status",
            width: 100
        }, {
            field: "seasonal",
            title: "Seasonal",
            width: 100
        }, {
            field: "prop90Tips",
            title: "90Tips",
            width: 100
        }, {
            field: "prop90ADT",
            title: "90ADT",
            width: 100
        }, {
            field: "prop90ADA",
            title: "90ADA",
            width: 100
        }, {
            field: "frequency",
            title: "Frequency",
            width: 100
        }, {
            field: "favoriteActivity",
            title: "FavoriteActivity",
            width: 100
        }, {
            field: "favoriteGame",
            title: "FavoriteGame",
            width: 100
        }, {
            field: "patronHostLastContact",
            title: "PatronHostLastContact",
            width: 100
        }, {
            field: "otherLastContact",
            title: "OtherLastContact",
            width: 100
        }, {
            field: "otherContactHost",
            title: "OtherContactHost",
            width: 100
        }, {
            field: "lastVisit",
            title: "LastVisit",
            width: 100
        }, {
            field: "lengthHostString",
            title: "LengthHostString",
            width: 100
        }, {
            field: "frequencyColor",
            title: "FrequencyColor",
            width: 100
        }],
        sortable: true,
        filterable: false,
        width: "auto",
        resizable: true,
    });
});